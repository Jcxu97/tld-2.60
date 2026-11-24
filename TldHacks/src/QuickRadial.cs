using System;
using Il2Cpp;
using UnityEngine;
using GearList = Il2CppSystem.Collections.Generic.List<Il2Cpp.GearItem>;

namespace TldHacks;

internal static class QuickInv
{
    internal static GearItem Best(Func<GearItem, float> score)
    {
        var items = GameManager.m_Inventory?.m_Items;
        if (items == null) return null;
        GearItem best = null;
        float bestScore = float.MinValue;
        for (int i = 0; i < items.Count; i++)
        {
            var gi = items[i]?.m_GearItem;
            if (gi == null) continue;
            float sc = score(gi);
            if (sc > bestScore) { bestScore = sc; best = gi; }
        }
        return best;
    }
}

// 手上的火把烧尽后换上背包里状态最好的火把并点着,烧尽的那根留在背包。
//   照原版从火堆取火把的顺序:先 Ignite 再 EquipItem。Extinguish 在 TorchItem.Update 里被调,
//   当场换装备不安全,所以只记下来,0.4 秒后在 OnUpdate 里换。
internal static class TorchAutoSwap
{
    internal static bool Pending;
    private static float _at;

    internal static bool Wanted() => ModMain.Settings != null && ModMain.Settings.Torch_AutoSwap;

    internal static void Postfix(TorchItem __instance, TorchState newState)
    {
        try
        {
            if (newState != TorchState.BurnedOut) return;
            var held = GameManager.GetPlayerManagerComponent()?.m_ItemInHands;
            if (held == null || __instance.m_GearItem == null || held.Pointer != __instance.m_GearItem.Pointer) return;
            Pending = true;
            _at = Time.time + 0.4f;
        }
        catch { }
    }

    internal static void Tick()
    {
        if (Time.time < _at) return;
        Pending = false;
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            var held = pm?.m_ItemInHands;
            if (held == null || held.m_TorchItem == null || !held.m_TorchItem.IsBurnedOut()) return;
            var next = QuickInv.Best(gi =>
            {
                var t = gi.m_TorchItem;
                if (t == null || gi.Pointer == held.Pointer || t.IsBurnedOut() || t.m_State == TorchState.Wet || gi.GetNormalizedCondition() <= 0f) return float.MinValue;
                return gi.GetNormalizedCondition();
            });
            if (next == null || next.m_TorchItem == null || next.m_TorchItem.IsBurnedOut()) return;
            next.m_TorchItem.Ignite();
            pm.EquipItem(next, false);
            ModMain.Log?.Msg($"[TorchAutoSwap] {held.name} 烧尽,换上 {next.name}");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TorchAutoSwap] {ex.Message}"); }
    }
}

#if !STORY_EDITION
// 保温瓶进喝水轮盘。点它就从瓶里取出一杯直接喝:茶优先,同类里卡路里最低的先喝。
internal static class QuickFlask
{
    private static Panel_ActionsRadial.RadialGearDelegate _drink;

    internal static bool RadialWanted() => ModMain.Settings != null && ModMain.Settings.Flask_Radial;
    internal static bool HeatWanted() => ModMain.Settings != null && ModMain.Settings.Flask_FireHeat;

    // GetDrinkItemsInInventory 返回空列表时原版直接提示没东西喝,所以瓶子要塞进这个列表才会出现在轮盘里
    internal static void DrinkListPostfix(ref GearList __result)
    {
        try
        {
            var items = GameManager.m_Inventory?.m_Items;
            if (items == null) return;
            if (__result == null) __result = new GearList();
            int at = 0;
            for (int i = 0; i < items.Count; i++)
            {
                var gi = items[i]?.m_GearItem;
                var f = gi?.m_InsulatedFlask;
                if (f == null || f.GetItemCount() <= 0) continue;
                __result.Insert(at++, gi);
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QuickFlask] {ex.Message}"); }
    }

    internal static void ShowDrinkPostfix(Panel_ActionsRadial __instance)
    {
        try
        {
            var arms = __instance.m_RadialArms;
            if (arms == null) return;
            _drink ??= (Action<GearItem>)Drink;
            for (int i = 0; i < arms.Length; i++)
            {
                var gi = arms[i]?.GetGearItem();
                if (gi != null && gi.m_InsulatedFlask != null) arms[i].SetRadialInfoGear(_drink, gi);
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QuickFlask] {ex.Message}"); }
    }

    private static void Drink(GearItem flaskGi)
    {
        try
        {
            var flask = flaskGi?.m_InsulatedFlask;
            if (flask == null) return;
            var list = new GearList();
            flask.GetAllItems(list);
            GearItem pick = null;
            bool pickTea = false;
            float pickCal = float.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                var gi = list[i];
                if (gi == null) continue;
                bool tea = (gi.name ?? "").Contains("Tea");
                float cal = gi.m_FoodItem != null ? gi.m_FoodItem.m_CaloriesRemaining : float.MaxValue;
                if (pick == null || (tea && !pickTea) || (tea == pickTea && cal < pickCal))
                { pick = gi; pickTea = tea; pickCal = cal; }
            }
            if (pick == null) return;
            // TryRemoveItem 会把瓶子当前的热度写给这一杯,喝下去照样算热饮
            if (!flask.TryRemoveItem(pick)) return;
            var inInv = GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(pick, false, false) ?? pick;
            InterfaceManager.GetPanel<Panel_ActionsRadial>()?.UseItem(inInv);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QuickFlask.Drink] {ex.Message}"); }
    }

    // 原版靠近火只是不降温。这里让它在火边回温,大约游戏内 15 分钟从冷到满
    internal static void HeatPostfix(Il2CppTLD.Gear.InsulatedFlask __instance, float deltaTODHours)
    {
        try
        {
            float h = __instance.m_HeatPercent;
            if (h >= 100f || deltaTODHours <= 0f || !__instance.IsNearFire()) return;
            __instance.m_HeatPercent = Mathf.Min(100f, h + deltaTODHours * 400f);
        }
        catch { }
    }
}
#endif

#if !EP5_EDITION && !STORY_EDITION
// 背包里的鲸油取暖器进营地轮盘(生火、休息那一页)的下一个空位,点了进入放置
internal static class QuickHeater
{
    private static Panel_ActionsRadial.RadialGearDelegate _place;
    private static bool _noRoomLogged;

    internal static bool Wanted() => ModMain.Settings != null && ModMain.Settings.Heater_Radial;

    internal static void ShowPlacePostfix(Panel_ActionsRadial __instance)
    {
        try
        {
            var heater = QuickInv.Best(gi => gi.m_WhaleOilHeaterItem != null ? gi.GetNormalizedCondition() : float.MinValue);
            if (heater == null || heater.m_WhaleOilHeaterItem == null) return;
            var arms = __instance.m_RadialArms;
            int n = __instance.m_NextArmToAdd;
            if (arms == null || n < 0 || n >= arms.Length)
            {
                if (!_noRoomLogged) { _noRoomLogged = true; ModMain.Log?.Msg($"[QuickHeater] 营地轮盘没有空位 ({n}/{arms?.Length})"); }
                return;
            }
            _place ??= (Action<GearItem>)Place;
            __instance.AddRadialSelectionGear(_place, heater);
            arms[n].SetHoverColor(false);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QuickHeater] {ex.Message}"); }
    }

    private static void Place(GearItem gi)
    {
        if (gi == null) return;
        PlaceFromInvUI.StartPlaceObject(gi.gameObject);
    }
}
#endif
