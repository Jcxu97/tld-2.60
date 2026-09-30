using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

// —— 存档写入 ——
// private static void SaveSceneData(SlotData slot, string sceneSaveName)
[HarmonyPatch(typeof(SaveGameSystem), "SaveSceneData", new Type[] { typeof(SlotData), typeof(string) })]
internal static class Patch_SaveSceneData
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        try { SaveData.Save(); }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] SaveSceneData: {ex.Message}"); }
    }
}

// —— 读档 / 进场景 ——
// private static bool LoadSceneData(string name, string sceneSaveName)。
// 跑在 SCPlus 之后:它读档时会挪装修过的物件,我们最后摆。
[HarmonyPatch(typeof(SaveGameSystem), "LoadSceneData", new Type[] { typeof(string), typeof(string) })]
internal static class Patch_LoadSceneData
{
    [HarmonyPriority(Priority.Last)]
    internal static void Postfix()
    {
        try
        {
            SaveData.LoadIfNewSession();
            World.Apply();
            ModMain.ScheduleApply();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] LoadSceneData: {ex.Message}"); }
    }
}

// —— 下单时改送货地点 ——
// 原版无线电从自己的 m_ExchangeBoxScenes 里随机抽一个场景,这里换成玩家搬的交易箱所在场景
[HarmonyPatch(typeof(TraderManager), nameof(TraderManager.InitiateTrade))]
internal static class Patch_InitiateTrade
{
    internal static void Prefix(ref string exchangeBoxScene)
    {
        try
        {
            string to = TradeGuard.DeliveryScene();
            if (to == null || to == exchangeBoxScene) return;
            ModMain.Log?.Msg($"[TraderMoving] 送货地点 {exchangeBoxScene} → {to}");
            exchangeBoxScene = to;
        }
        catch { }
    }

    internal static void Postfix()
    {
        try { World.HookUpTrade(); } catch { }
    }
}

// —— 抱着东西时的限制 ——
// 冲刺判定和体力、热量计算每帧都跑,常挂会白白多几座 IL2CPP 桥。
// 所以不写 [HarmonyPatch],抱起时挂上、放下时卸掉(和 TldHacks 的 DynamicPatch 一个思路)。
internal static class CarryPatches
{
    private static HarmonyLib.Harmony _h;
    private static bool _on;
    private static readonly List<MethodBase> _targets = new();

    private const BindingFlags Any = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

    internal static void Enable()
    {
        if (_on) return;
        _h ??= new HarmonyLib.Harmony("TraderMoving.Carry");
        _targets.Clear();
        Hook(typeof(PlayerManager).GetMethod("PlayerCanSprint", Any), nameof(NoSprint), false);
        Hook(typeof(PlayerManager).GetMethod("EquipItem", Any, null, new[] { typeof(GearItem), typeof(bool) }, null), nameof(NoEquip), true);
        Hook(typeof(Fatigue).GetMethod("CalculateFatigueIncrease", Any, null, new[] { typeof(float) }, null), nameof(FatigueMore), false);
        Hook(typeof(PlayerManager).GetMethod("CalculateModifiedCalorieBurnRate", Any, null, new[] { typeof(float) }, null), nameof(CaloriesMore), false);
        Hook(typeof(RopeClimbPoint).GetMethod("OnRopeTransition", Any, null, new[] { typeof(bool) }, null), nameof(RopeDrop), false);
        var place = typeof(PlayerManager).GetMethod("PlaceMeshInWorld", Any, null, Type.EmptyTypes, null);
        Hook(place, nameof(PlacedPre), true);
        Hook(place, nameof(PlacedPost), false);
        _on = true;
    }

    internal static void Disable()
    {
        if (!_on || _h == null) return;
        foreach (var m in _targets)
        {
            try { _h.Unpatch(m, HarmonyPatchType.All, _h.Id); }
            catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 卸载 {m.Name} 失败: {ex.Message}"); }
        }
        _targets.Clear();
        _on = false;
    }

    private static void Hook(MethodBase target, string handler, bool prefix)
    {
        if (target == null) { ModMain.Log?.Warning($"[TraderMoving] 找不到 {handler} 的目标方法"); return; }
        try
        {
            var hm = new HarmonyMethod(typeof(CarryPatches).GetMethod(handler, BindingFlags.NonPublic | BindingFlags.Static));
            if (prefix) _h.Patch(target, prefix: hm); else _h.Patch(target, postfix: hm);
            if (!_targets.Contains(target)) _targets.Add(target);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 挂 {target.Name} 失败: {ex.Message}"); }
    }

    private static void NoSprint(ref bool __result)
    {
        if (CarryState.IsCarrying) __result = false;
    }

    private static bool NoEquip(bool fromDeserialize)
    {
        if (!CarryState.IsCarrying || fromDeserialize) return true;
        CarryState.Refuse("抱着东西没法拿别的");
        return false;
    }

    private static void FatigueMore(ref float __result)
    {
        if (CarryState.IsCarrying) __result *= 1f + CarryState.Weight * 0.05f;
    }

    private static void CaloriesMore(ref float __result)
    {
        if (CarryState.IsCarrying) __result += CarryState.Weight * 15f;
    }

    private static void PlacedPre(PlayerManager __instance) => Placement.BeforePlaceMeshInWorld(__instance);
    private static void PlacedPost(PlayerManager __instance) => Placement.AfterPlaceMeshInWorld(__instance);

    private static void RopeDrop()
    {
        // 不能在这个方法自己的补丁里卸补丁,记下来下一帧放
        if (CarryState.IsCarrying) CarryState.RopeDropPending = true;
    }
}

// —— 读取存档 ——
// 死亡后重读同一个存档时存档名不变,这里标记一下,下一次 LoadSceneData 重新读我们的记录
[HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.RestoreGlobalData))]
internal static class Patch_RestoreGlobalData
{
    internal static void Postfix()
    {
        SaveData.InvalidateSession();
    }
}
