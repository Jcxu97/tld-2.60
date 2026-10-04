#if !STORY_EDITION
using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace TldHacks;

// 参照两份 CE 表补的功能。开关直接读设置,不走 CheatState。
internal static class CeX
{
    private static TldHacksSettings S => ModMain.Settings;
    internal static bool SnareSure => S != null && S.CE_SnareSure;
    internal static bool SnareInstant => S != null && S.CE_SnareSure && S.CE_SnareInstant;
    internal static bool IceHoleNoFreeze => S != null && S.CE_IceHoleNoFreeze;
    internal static bool NoMisery => S != null && S.CE_NoMisery;
    internal static bool NoDeath => S != null && S.CE_NoDeath;
    internal static bool TraderCheap => S != null && S.CE_TraderCheap;
    internal static bool AuroraLightSteady => S != null && S.CE_AuroraLightSteady;
    internal static bool AuroraMute => S != null && S.CE_AuroraMute;
    internal static bool StruggleWin => S != null && S.CE_StruggleWin;
    internal static bool NoStun => S != null && S.CE_NoStun;
    internal static bool NoSlide => S != null && S.CE_NoSlide;
    internal static bool LootNoEmpty => S != null && S.CE_LootNoEmpty;
    internal static bool LootLowerTier => S != null && S.CE_LootLowerTier;
    internal static bool AuroraRefill => S != null && S.CE_AuroraRefill;

    internal static bool InStruggle()
    {
        if (!StruggleWin) return false;
        try { var ps = GameManager.GetPlayerStruggleComponent(); return ps != null && ps.InStruggle(); } catch { return false; }
    }

    private static float _slopeOut = -1f, _slopeIn, _slopeCc;

    // 坡上不打滑:坡度上限拉到 89 度,关掉时写回原值
    internal static void Tick()
    {
        bool on = NoSlide;
        if (!on && _slopeOut < 0f) return;
        try
        {
            var pm = GameManager.GetPlayerMovementComponent();
            var cc = GameManager.GetVpFPSPlayer()?.Controller?.m_Controller;
            if (pm == null || cc == null) return;
            if (on)
            {
                if (_slopeOut < 0f) { _slopeOut = pm.m_MaxSlopeOutdoors; _slopeIn = pm.m_MaxSlopeIndoors; _slopeCc = cc.slopeLimit; }
                pm.m_MaxSlopeOutdoors = 89f; pm.m_MaxSlopeIndoors = 89f; cc.slopeLimit = 89f;
            }
            else
            {
                pm.m_MaxSlopeOutdoors = _slopeOut; pm.m_MaxSlopeIndoors = _slopeIn; cc.slopeLimit = _slopeCc;
                _slopeOut = -1f;
            }
        }
        catch { }
    }

    // 菜单按钮:重抽一遍商人的商品,交易面板开着就顺手刷新界面
    internal static void RefreshTrader()
    {
        try
        {
            var tm = GameManager.GetTraderManager();
            if (tm?.m_CurrentState == null) { CheatState.LastActionLog = I18n.T("还没联系过商人", "Trader not met yet"); return; }
            tm.RollExchanges();
            var p = InterfaceManager.GetPanel<Panel_TradeSelection>();
            if (p != null && p.IsEnabled()) { p.m_SelectedTradeExchanges?.Clear(); p.RefreshAvailableExchanges(); }
            CheatState.LastActionLog = I18n.T("商品已刷新", "Trader goods refreshed");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[CE] trader refresh {ex.Message}"); }
    }

    private static float _lastRescue = -100f;

    internal static bool WouldDie(float hp)
    {
        if (!NoDeath || hp >= 0f) return false;
        var c = GameManager.GetConditionComponent();
        return c != null && c.m_CurrentHP + hp <= 1f;
    }

    // 血量快归零时救回来:血量回到三成,清掉负面,饿、渴、冷补到不再掉血
    internal static void Rescue()
    {
        try
        {
            var c = GameManager.GetConditionComponent();
            if (c == null) return;
            c.m_CurrentHP = Mathf.Max(c.m_CurrentHP, c.m_MaxHP * 0.3f);
            if (Time.realtimeSinceStartup - _lastRescue < 3f) return;
            _lastRescue = Time.realtimeSinceStartup;
            try { var h = GameManager.GetHungerComponent(); if (h != null && h.m_CurrentReserveCalories < 600f) h.m_CurrentReserveCalories = 600f; } catch { }
            try { var t = GameManager.GetThirstComponent(); if (t != null && t.m_CurrentThirst > 50f) t.m_CurrentThirst = 50f; } catch { }
            try { var f = GameManager.GetFreezingComponent(); if (f != null && f.m_CurrentFreezing > 50f) f.m_CurrentFreezing = 50f; } catch { }
            try { Cheats.ClearAllAfflictions(); } catch { }
            ModMain.Log?.Msg("[CE] no death: rescued");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[CE] rescue {ex.Message}"); }
    }

    // 厄难难度的 6 种负面,"清除所有负面"会调这里
    internal static void CureMisery(System.Text.StringBuilder log, ref int cleared)
    {
        void One(bool had, Action cure, string zh, string en, System.Text.StringBuilder lg, ref int n)
        {
            if (!had) return;
            try { cure(); } catch { }
            n++; lg.Append(I18n.T(zh + "; ", en + "; "));
        }
        try { var c = GameManager.GetWeakConstitution(); if (c != null) One(c.HasAffliction, () => c.Cure(AfflictionOptions.None), "体质衰弱", "Weak Constitution", log, ref cleared); } catch { }
        try { var c = GameManager.GetUnsettledSleep(); if (c != null) One(c.HasAffliction, () => c.Cure(AfflictionOptions.None), "心神不宁", "Unsettled Sleep", log, ref cleared); } catch { }
        try { var c = GameManager.GetWeakJoints(); if (c != null) One(c.HasAffliction, () => c.Cure(AfflictionOptions.None), "风湿关节", "Weak Joints", log, ref cleared); } catch { }
        try { var c = GameManager.GetPoorCirculation(); if (c != null) One(c.HasAffliction, () => c.Cure(AfflictionOptions.None), "冰冷刺骨", "Poor Circulation", log, ref cleared); } catch { }
        try { var c = GameManager.GetSourStomach(); if (c != null) One(c.HasAffliction, () => c.Cure(AfflictionOptions.None), "胃酸过多", "Sour Stomach", log, ref cleared); } catch { }
        try { var c = GameManager.GetBrokenBody(); if (c != null) One(c.HasAffliction, () => c.Cure(AfflictionOptions.None), "残破身躯", "Broken Body", log, ref cleared); } catch { }
        // 存档里记着已经施加过的,不清的话读档又会挂回来
        try
        {
            var mm = GameManager.GetMiseryManager();
            if (mm == null) return;
            mm.m_PendingAfflictions?.Clear();
            var st = mm.m_State?.m_MiseryStages;
            for (int i = 0; st != null && i < st.Count; i++) st[i]?.m_Afflictions?.Clear();
        }
        catch { }
    }
}

internal static class Patch_CE_MiseryBlock
{
    internal static bool Prefix() => !CeX.NoMisery;
}

internal static class Patch_CE_DeathEntry
{
    internal static bool Prefix()
    {
        if (!CeX.NoDeath) return true;
        CeX.Rescue();
        return false;
    }
}

// 陷阱必中:判定时抓到的概率拉满、不会坏;兔子数量上限清零。判定完把原值写回去
internal static class Patch_CE_SnareRoll
{
    // 刷新区的已抓数会存进存档,判定前清零、判定完加回原值
    private static readonly List<int> _trapped = new();

    internal static void Prefix(SnareItem __instance, out (float c, float b) __state)
    {
        __state = (__instance.m_ChanceSpawnCarcassOnRoll, __instance.m_ChanceBreakOnRoll);
        _trapped.Clear();
        if (!CeX.SnareSure) return;
        __instance.m_ChanceSpawnCarcassOnRoll = 1000f;
        __instance.m_ChanceBreakOnRoll = 0f;
        try
        {
            var rs = GameManager.GetSpawnRegionManager()?.m_SpawnRegions;
            for (int i = 0; rs != null && i < rs.Count; i++)
            {
                _trapped.Add(rs[i] != null ? rs[i].m_NumTrapped : 0);
                if (rs[i] != null) rs[i].m_NumTrapped = 0;
            }
        }
        catch { }
    }

    internal static void Postfix(SnareItem __instance, (float c, float b) __state)
    {
        __instance.m_ChanceSpawnCarcassOnRoll = __state.c;
        __instance.m_ChanceBreakOnRoll = __state.b;
        if (_trapped.Count == 0) return;
        try
        {
            var rs = GameManager.GetSpawnRegionManager()?.m_SpawnRegions;
            for (int i = 0; rs != null && i < rs.Count && i < _trapped.Count; i++)
                if (rs[i] != null) rs[i].m_NumTrapped += _trapped[i];
        }
        catch { }
        _trapped.Clear();
    }
}

// 放下就抓到:每个陷阱放下后只提前判定一次,没抓到就回到原版的间隔
internal static class Patch_CE_SnareUpdate
{
    private static readonly HashSet<IntPtr> _pushed = new();

    internal static void Prefix(SnareItem __instance)
    {
        if (__instance.m_State != SnareState.Set) { _pushed.Remove(__instance.Pointer); return; }
        if (!CeX.SnareInstant || !_pushed.Add(__instance.Pointer)) return;
        // 只往前推一个判定间隔,原版要是按过了几个间隔补算,也只补一次
        float now = 0f;
        try { now = GameManager.GetTimeOfDayComponent().GetHoursPlayedNotPaused(); } catch { }
        __instance.m_HoursAtLastRoll = now - __instance.m_HoursBeforeRoll - 0.01f;
    }
}

internal static class Patch_CE_SnareProximity
{
    internal static void Postfix(ref bool __result)
    {
        if (CeX.SnareInstant) __result = false;
    }
}

internal static class Patch_CE_IceHoleFrozen
{
    internal static void Prefix(ref float normalized)
    {
        if (CeX.IceHoleNoFreeze) normalized = 0f;
    }
}

internal static class Patch_CE_IceHoleInteract
{
    internal static void Prefix(IceFishingHole __instance)
    {
        if (CeX.IceHoleNoFreeze && __instance.m_FrozenPercent > 0) __instance.SetNormalizedFrozen(0f);
    }
}

// 扑倒必胜:进度条一直是满的、不往回掉,狼和美洲狮走原版挣脱成功那条路;熊和驼鹿没有进度条,只去掉伤害和后续负面
internal static class Patch_CE_StruggleUpdate
{
    // 改的是 PlayerStruggle 的配置字段,第一次改之前记下原值,开关关掉时写回
    private static PlayerStruggle _ps;
    private static bool _saved;
    private static float _tapDec, _bearStun, _wolfStun;
    private static int _dropMin, _dropMax;

    internal static void Postfix(PlayerStruggle __instance)
    {
        if (!_saved || _ps == null || _ps.Pointer != __instance.Pointer)
        {
            _ps = __instance; _saved = true;
            _tapDec = __instance.m_TapDecreasePerSecond;
            _bearStun = __instance.m_LayStunnedAfterBearAttackSeconds;
            _wolfStun = __instance.m_LayStunnedAfterWolfAttackSeconds;
            _dropMin = __instance.m_DazedDropItemsMin; _dropMax = __instance.m_DazedDropItemsMax;
        }
        __instance.m_TapDecreasePerSecond = CeX.StruggleWin ? 0f : _tapDec;
        if (CeX.NoStun)
        {
            __instance.m_LayStunnedAfterBearAttackSeconds = 0f;
            __instance.m_LayStunnedAfterWolfAttackSeconds = 0f;
            __instance.m_DazedDropItemsMin = 0;
            __instance.m_DazedDropItemsMax = 0;
        }
        else RestoreStun(__instance);
        if (__instance.m_Active && CeX.StruggleWin) __instance.m_TapBarNormalized = 1f;
    }

    private static void RestoreStun(PlayerStruggle ps)
    {
        ps.m_LayStunnedAfterBearAttackSeconds = _bearStun;
        ps.m_LayStunnedAfterWolfAttackSeconds = _wolfStun;
        ps.m_DazedDropItemsMin = _dropMin; ps.m_DazedDropItemsMax = _dropMax;
    }

    internal static bool RestoreDone()
    {
        try
        {
            if (_saved && _ps != null)
            {
                _ps.m_TapDecreasePerSecond = _tapDec;
                RestoreStun(_ps);
            }
        }
        catch { }
        _saved = false; _ps = null;
        return true;
    }
}

internal static class Patch_CE_StruggleSkip
{
    internal static bool Prefix() => !CeX.StruggleWin;
}

internal static class Patch_CE_NoStunSkip
{
    internal static bool Prefix() => !CeX.NoStun;
}

internal static class Patch_CE_StunDuration
{
    internal static void Postfix(ref float __result)
    {
        if (CeX.NoStun) __result = 0f;
    }
}

internal static class Patch_CE_CanBeStunned
{
    internal static void Postfix(ref bool __result)
    {
        if (CeX.NoStun) __result = false;
    }
}

internal static class Patch_CE_SlopeMult
{
    internal static void Postfix(ref float __result)
    {
        if (CeX.NoSlide && __result < 1f) __result = 1f;
    }
}

// 容器生成东西那一下:不开空、件数至少 1;可选按低一档难度的表出。生成完把难度的值写回去
internal static class Patch_CE_LootRandomGear
{
    private static Il2CppTLD.Gameplay.ExperienceMode _xp;
    private static int _red, _emp;
    private static ExperienceModeType _mt;

    private static ExperienceModeType Lower(ExperienceModeType t) => t switch
    {
        ExperienceModeType.Misery => ExperienceModeType.Interloper,
        ExperienceModeType.Interloper => ExperienceModeType.Stalker,
        ExperienceModeType.Stalker => ExperienceModeType.Voyageur,
        ExperienceModeType.Voyageur => ExperienceModeType.Pilgrim,
        _ => t,
    };

    internal static void Prefix(Container __instance)
    {
        try
        {
            Restore(__instance);
            var c = __instance;
            if (CeX.LootNoEmpty)
            {
                c.m_ChanceEmpty = 0f;
                if (c.m_MinRandomItems < 1) c.m_MinRandomItems = 1;
                if (c.m_MaxRandomItems < c.m_MinRandomItems) c.m_MaxRandomItems = c.m_MinRandomItems;
                if (c.m_MinRandomItemsLocked < 1) c.m_MinRandomItemsLocked = 1;
                if (c.m_MaxRandomItemsLocked < c.m_MinRandomItemsLocked) c.m_MaxRandomItemsLocked = c.m_MinRandomItemsLocked;
            }
            _xp = GameManager.GetExperienceModeManagerComponent()?.GetCurrentExperienceMode();
            if (_xp == null) return;
            _red = _xp.m_ReduceMaxItemsInContainer; _emp = _xp.m_ChanceForEmptyContainer; _mt = _xp.m_ModeType;
            if (CeX.LootNoEmpty) { _xp.m_ReduceMaxItemsInContainer = 0; _xp.m_ChanceForEmptyContainer = 0; }
            if (CeX.LootLowerTier && Lower(_mt) != _mt) { _xp.m_ModeType = Lower(_mt); Dirty(c); }
        }
        catch { }
    }

    internal static void Postfix(Container __instance) => Restore(__instance);

    private static void Restore(Container c)
    {
        if (_xp == null) return;
        try
        {
            _xp.m_ReduceMaxItemsInContainer = _red; _xp.m_ChanceForEmptyContainer = _emp;
            if (_xp.m_ModeType != _mt) { _xp.m_ModeType = _mt; Dirty(c); }
        }
        catch { }
        _xp = null;
    }

    // 物品表按难度筛过一遍会缓存,改难度前后都要让它重筛
    private static void Dirty(Container c)
    {
        try
        {
            if (c.m_LootTableData != null) Il2CppTLD.Gameplay.RandomTableDataManager.SetTableDirty(c.m_LootTableData);
            if (c.m_LockedLootTableData != null) Il2CppTLD.Gameplay.RandomTableDataManager.SetTableDirty(c.m_LockedLootTableData);
        }
        catch { }
    }
}

// 极光夜关上一个搜空的容器,把它重新生成一次。每次极光每个容器只刷一次;尸体和任务容器不刷
internal static class Patch_CE_AuroraRefill
{
    private static readonly HashSet<IntPtr> _done = new();
    private static int _aurora = -1;

    internal static void Postfix(Container __instance)
    {
        try
        {
            var c = __instance;
            var am = GameManager.GetAuroraManager();
            if (am == null || !am.AuroraIsActive()) return;
            if (am.m_NumAurorasForSave != _aurora) { _aurora = am.m_NumAurorasForSave; _done.Clear(); }
            if (c.m_IsCorpse || c.m_MissionObject != null || !string.IsNullOrEmpty(c.m_MissionSupplyObjectiveId)) return;
            if (!c.IsInspected() || !c.IsEmpty() || !_done.Add(c.Pointer)) return;
            c.m_GearToInstantiate?.Clear();
            c.m_RolledSpawnChance = false;
            c.m_NotPopulated = false;
            c.PopulateContents();
            int n = c.m_GearToInstantiate?.Count ?? 0;
            if (c.IsEmpty() && n > 0) c.InstantiateContents();
            ModMain.Log?.Msg($"[CE] aurora refill {c.name}: rolled={n} empty={c.IsEmpty()}");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[CE] aurora refill {ex.Message}"); }
    }
}

// 打折:用游戏自带的便宜价清单(原版信任很高才有)
internal static class Patch_CE_TraderCheap
{
    internal static void Postfix(ref bool __result)
    {
        if (CeX.TraderCheap) __result = true;
    }
}

// 极光夜电灯常亮:只在真有极光时把强度拉满、关掉闪烁;室内灯光传 0 关灯的那条路不动
internal static class Patch_CE_AuroraLight
{
    internal static void Prefix(Il2CppTLD.ModularElectrolizer.AuroraModularElectrolizer __instance, ref float auroraIntensity)
    {
        if (!CeX.AuroraLightSteady || auroraIntensity <= 0f) return;
        try
        {
            var am = GameManager.GetAuroraManager();
            if (am == null || !am.AuroraIsActive()) return;
            __instance.m_HasFlickerSet = false;
            auroraIntensity = 1f;
        }
        catch { }
    }
}

// 关掉极光那阵嗡嗡声。不放也不更新;开关关掉后实例是 0,原版会自己重新播
internal static class Patch_CE_AuroraAudio
{
    internal static bool Prefix(AuroraManager __instance)
    {
        if (!CeX.AuroraMute) return true;
        try
        {
            uint id = __instance.m_AuroaAudioInstance;
            if (id != 0) { GameAudioManager.StopPlayingID(ref id, 500); __instance.m_AuroaAudioInstance = 0; }
        }
        catch { }
        return false;
    }
}
#endif
