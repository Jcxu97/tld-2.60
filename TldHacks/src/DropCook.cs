#if !STORY_EDITION
using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// 丢地烹饪:生肉生鱼丢在点着的火堆或炉子旁边,按原版烹饪时长等够游戏时间就原地换成热的熟肉。
//   熟了继续放在火边,超过原版的焦糊前等待时间(Cookable.m_ReadyTimeMinutes)就烤焦,耐久变 0。
//   计时按"场景名 + 物品名 + 位置"记,离开场景再回来不丢;回来时火还燃着就把离开的时间也算进去,
//   火灭着就只暂停。开关关着时 Tick 第一行就返回,不挂任何 patch。
// ponytail: 每秒对每堆火做一次 OverlapSphere,火多、地上东西多时开销跟着涨;
//           真卡了再改成只在 GearItem.Drop / 放置完成时登记候选。
//           计时只在内存里,退出游戏再读档会从读档那刻重新计时。
internal static class DropCook
{
    internal const float Radius = 2f;
    private const float TickSeconds = 1f;
    private const float StaleAfterLoadSeconds = 10f;

    private sealed class Rec { public float Minutes; public float Last; public float BurnAfter = -1f; }

    private static float _nextTick;
    private static readonly Dictionary<string, Rec> _recs = new();
    private static readonly HashSet<string> _seen = new();
    private static string _scene;
    private static float _sceneSince;
    private static bool _logged, _burnLogged;

    internal static bool On => ModMain.Settings != null && ModMain.Settings.DropCook;

    internal static void Tick()
    {
        if (!On) { if (_recs.Count > 0) _recs.Clear(); return; }
        if (Time.unscaledTime < _nextTick) return;
        _nextTick = Time.unscaledTime + TickSeconds;
        try { Scan(); }
        catch (Exception ex) { ModMain.Log?.Warning($"[DropCook] {ex.Message}"); }
    }

    private static void Scan()
    {
        string scene = GameManager.m_ActiveScene ?? "";
        if (scene != _scene) { _scene = scene; _sceneSince = Time.unscaledTime; }
        var fires = FireManager.m_Fires;
        if (fires == null || fires.Count == 0) return;
        var tod = GameManager.GetTimeOfDayComponent();
        var pm = GameManager.GetPlayerManagerComponent();
        if (tod == null || pm == null) return;
        float now = tod.GetHoursPlayedNotPaused();
        GearItem inspected = null;
        try { if (pm.IsInspectModeActive()) inspected = pm.GearItemBeingInspected(); } catch { }

        _seen.Clear();
        List<(GearItem gi, float over)> done = null;
        List<GearItem> burnt = null;
        // 先过燃着的火再过灭的火:同一块肉挨着两堆火时按燃着的算
        for (int pass = 0; pass < 2; pass++)
        {
            bool burning = pass == 0;
            for (int f = 0; f < fires.Count; f++)
            {
                var fire = fires[f];
                if (fire == null || fire.IsBurning() != burning) continue;
                var hits = Physics.OverlapSphere(fire.transform.position, Radius, ~0, QueryTriggerInteraction.Collide);
                if (hits == null) continue;
                for (int i = 0; i < hits.Length; i++)
                {
                    var col = hits[i];
                    if (col == null) continue;
                    var gi = col.GetComponentInParent<GearItem>();
                    if (gi == null || (inspected != null && inspected.Pointer == gi.Pointer)) continue;
                    bool raw = IsRawOnGround(gi);
                    string key = Key(gi);
                    _recs.TryGetValue(key, out var r);
                    if (!raw && (r == null || r.BurnAfter < 0f || !IsOnGround(gi))) continue;
                    if (!_seen.Add(key)) continue;
                    if (r == null) { _recs[key] = new Rec { Last = now }; continue; }
                    if (burning) r.Minutes += Mathf.Max(0f, now - r.Last) * 60f;
                    r.Last = now;
                    if (raw)
                    {
                        float need = gi.m_Cookable.GetCookTimeMinutesForCaloriesRemaining();
                        if (need <= 0f) need = gi.m_Cookable.m_CookTimeMinutes;
                        if (r.Minutes >= need) (done ??= new()).Add((gi, r.Minutes - need));
                    }
                    else if (r.Minutes >= r.BurnAfter) (burnt ??= new()).Add(gi);
                }
            }
        }

        // 刚进场景那几秒地上的东西可能还没生成,不急着清,免得把离开期间的计时丢掉
        if (Time.unscaledTime - _sceneSince > StaleAfterLoadSeconds)
        {
            string prefix = scene + "|";
            List<string> stale = null;
            foreach (var k in _recs.Keys)
                if (k.StartsWith(prefix, StringComparison.Ordinal) && !_seen.Contains(k)) (stale ??= new()).Add(k);
            if (stale != null) foreach (var k in stale) _recs.Remove(k);
        }
        if (done != null)
            foreach (var (raw, over) in done)
            {
                _recs.Remove(Key(raw));
                Cook(raw, over, now);
            }
        if (burnt != null)
            foreach (var gi in burnt)
            {
                _recs.Remove(Key(gi));
                Burn(gi);
            }
    }

    private static string Key(GearItem gi)
    {
        var p = gi.transform.position;
        string n = (gi.name ?? "").Replace("(Clone)", "").Trim();
        return $"{_scene}|{n}|{Mathf.RoundToInt(p.x * 20f)},{Mathf.RoundToInt(p.y * 20f)},{Mathf.RoundToInt(p.z * 20f)}";
    }

    private static bool IsOnGround(GearItem gi)
    {
        try
        {
            if (gi.m_InPlayerInventory || gi.m_InsideContainer || gi.CurrentHP <= 0f) return false;
            var go = gi.gameObject;
            return go != null && go.activeInHierarchy;
        }
        catch { return false; }
    }

    private static void Burn(GearItem gi)
    {
        try
        {
            gi.CurrentHP = 0f;
            if (!_burnLogged) { _burnLogged = true; ModMain.Log?.Msg($"[DropCook] {gi.name} 烤焦"); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[DropCook] burn {ex.Message}"); }
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

    private static void Cook(GearItem raw, float overMinutes, float now)
    {
        try
        {
            float burnAfter = raw.m_Cookable.m_ReadyTimeMinutes;
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
            if (burnAfter > 0f) _recs[Key(cooked)] = new Rec { Minutes = overMinutes, Last = now, BurnAfter = burnAfter };
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[DropCook] cook {ex.Message}"); }
    }
}
#endif
