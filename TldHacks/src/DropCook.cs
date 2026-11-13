#if !STORY_EDITION
using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// 丢地烹饪:生肉生鱼丢在点着的火堆或炉子旁边,按原版烹饪时长等够游戏时间就原地换成热的熟肉。
//   开关关着时 Tick 第一行就返回,不挂任何 patch。
// ponytail: 每秒对每堆燃着的火做一次 OverlapSphere,火多、地上东西多时开销跟着涨;
//           真卡了再改成只在 GearItem.Drop / 放置完成时登记候选。
internal static class DropCook
{
    internal const float Radius = 2f;
    private const float TickSeconds = 1f;

    private static float _nextTick;
    private static readonly Dictionary<int, float> _startHours = new();
    private static readonly HashSet<int> _seen = new();
    private static bool _logged;

    internal static bool On => ModMain.Settings != null && ModMain.Settings.DropCook;

    internal static void Tick()
    {
        if (!On) { if (_startHours.Count > 0) _startHours.Clear(); return; }
        if (Time.unscaledTime < _nextTick) return;
        _nextTick = Time.unscaledTime + TickSeconds;
        try { Scan(); }
        catch (Exception ex) { ModMain.Log?.Warning($"[DropCook] {ex.Message}"); }
    }

    private static void Scan()
    {
        var fires = FireManager.m_Fires;
        if (fires == null || fires.Count == 0) { _startHours.Clear(); return; }
        var tod = GameManager.GetTimeOfDayComponent();
        var pm = GameManager.GetPlayerManagerComponent();
        if (tod == null || pm == null) return;
        float now = tod.GetHoursPlayedNotPaused();
        GearItem inspected = null;
        try { if (pm.IsInspectModeActive()) inspected = pm.GearItemBeingInspected(); } catch { }

        _seen.Clear();
        List<GearItem> done = null;
        for (int f = 0; f < fires.Count; f++)
        {
            var fire = fires[f];
            if (fire == null || !fire.IsBurning()) continue;
            var hits = Physics.OverlapSphere(fire.transform.position, Radius, ~0, QueryTriggerInteraction.Collide);
            if (hits == null) continue;
            for (int i = 0; i < hits.Length; i++)
            {
                var col = hits[i];
                if (col == null) continue;
                var gi = col.GetComponentInParent<GearItem>();
                if (gi == null || !IsRawOnGround(gi) || (inspected != null && inspected.Pointer == gi.Pointer)) continue;
                int id = gi.GetInstanceID();
                if (!_seen.Add(id)) continue;
                if (!_startHours.TryGetValue(id, out float start)) { _startHours[id] = now; continue; }
                float need = gi.m_Cookable.GetCookTimeMinutesForCaloriesRemaining();
                if (need <= 0f) need = gi.m_Cookable.m_CookTimeMinutes;
                if ((now - start) * 60f >= need) (done ??= new List<GearItem>()).Add(gi);
            }
        }

        if (_startHours.Count > _seen.Count)
        {
            var stale = new List<int>();
            foreach (var k in _startHours.Keys) if (!_seen.Contains(k)) stale.Add(k);
            foreach (var k in stale) _startHours.Remove(k);
        }
        if (done == null) return;
        foreach (var raw in done)
        {
            _startHours.Remove(raw.GetInstanceID());
            Cook(raw);
        }
    }

    private static bool IsRawOnGround(GearItem gi)
    {
        try
        {
            var ck = gi.m_Cookable;
            if (ck == null || ck.m_CookedPrefab == null || ck.m_CookableType != Cookable.CookableType.Meat) return false;
            if (gi.m_InPlayerInventory || gi.m_InsideContainer || gi.m_BodyHarvest != null) return false;
            var go = gi.gameObject;
            if (go == null || !go.activeInHierarchy) return false;
            // 已经摆在火上烤的生肉挂在锅(或火堆自带的烤架)下面,交给原版烹饪
            var parent = gi.transform.parent;
            if (parent != null && parent.GetComponentInParent<CookingPotItem>() != null) return false;
            return true;
        }
        catch { return false; }
    }

    private static void Cook(GearItem raw)
    {
        try
        {
            var prefab = raw.m_Cookable.m_CookedPrefab;
            var cooked = GearItem.InstantiateGearItem(prefab.name);
            if (cooked == null) { ModMain.Log?.Warning($"[DropCook] 生成 {prefab.name} 失败"); return; }
            var t = raw.transform;
            cooked.transform.SetPositionAndRotation(t.position, t.rotation);
            DisableObjectForXPMode.RemoveDisabler(cooked.gameObject);

            cooked.CurrentHP = CookingPotItem.GetCookedHp(raw.CurrentHP, raw.m_GearItemData, cooked.m_GearItemData);
            var rf = raw.m_FoodItem;
            var cf = cooked.m_FoodItem;
            if (rf != null && cf != null)
            {
                cf.m_CaloriesTotal = rf.m_CaloriesTotal;
                cf.m_CaloriesRemaining = rf.m_CaloriesRemaining;
                cf.m_HarvestedByPlayer = rf.m_HarvestedByPlayer;
                if (cf.m_HeatedWhenCooked) cf.m_HeatPercent = 100f;
            }
            cooked.WeightKG = raw.WeightKG;
            if (!cooked.gameObject.activeSelf) cooked.gameObject.SetActive(true);

            if (!_logged)
            {
                _logged = true;
                ModMain.Log?.Msg($"[DropCook] {raw.name} -> {cooked.name} hp={cooked.CurrentHP:F1} cal={cf?.m_CaloriesRemaining:F0}");
            }
            GearManager.DestroyGearObject(raw.gameObject);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[DropCook] cook {ex.Message}"); }
    }
}
#endif
