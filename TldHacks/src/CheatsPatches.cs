using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.Gear;
#endif
using Il2CppTLD.IntBackedUnit;
using UnityEngine;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════════
//  帧级武器状态缓存 — 避免同一帧多次穿越 IL2CPP bridge 查 GetComponent<GunItem>
// ═══════════════════════════════════════════════════════════════════
internal static class WeaponCache
{
    private static int _frame = -1;
    private static bool _holdingGun;
    private static IntPtr _lastItemPtr;
    private static bool _isRifle;
    private static bool _isRevolver;

    internal static bool IsHoldingGun()
    {
        int f = Time.frameCount;
        if (f == _frame) return _holdingGun;
        _frame = f;
        _holdingGun = false;
        _isRifle = false;
        _isRevolver = false;
        _lastItemPtr = IntPtr.Zero;
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null || pm.m_ItemInHands == null) return false;
            var gi = pm.m_ItemInHands;
            _lastItemPtr = gi.Pointer;
            _holdingGun = gi.GetComponent<GunItem>() != null;
            if (_holdingGun)
            {
                string n = ((UnityEngine.Object)gi).name;
                if (n != null)
                {
                    _isRifle = n.IndexOf("Rifle", StringComparison.OrdinalIgnoreCase) >= 0;
                    _isRevolver = n.IndexOf("Revolver", StringComparison.OrdinalIgnoreCase) >= 0;
                }
            }
        }
        catch { _holdingGun = false; }
        return _holdingGun;
    }

    internal static bool IsRifle => IsHoldingGun() && _isRifle;
    internal static bool IsRevolver => IsHoldingGun() && _isRevolver;
}

// —— 武器相关的方法级 patch(比 tick 改字段更可靠)——

// 无限弹药:每次 RemoveNextFromClip 被调用,若 InfiniteAmmo 则 skip
// v2.7.75 DynamicPatch
internal static class Patch_Gun_RemoveNextFromClip
{
    internal static bool Prefix() => !CheatState.InfiniteAmmo;
}

// v2.7.75 删 5 个 GunItem getter "belt-n-suspenders" patch —— TickCamera 的
// m_DisableAimSway / m_DisableAimShake / m_DisableAimBreathing / m_DisableAimStamina /
// m_RecoilSpring 重置是主力,这些 getter patch 是 v2.7.0 留的冗余,删掉减少启动 bridge 数

// ——— Condition 伤害过滤总闸 ———
// v2.7.29:AddHealth 有 3 个重载(2 参 / 3 参 / AddHealthWithNoHudNotification)
//   之前只 patch 2 参,狼咬 BloodLoss 持续掉血走的是 3 参版 → 绕过 filter
//   "真隐身彻底无效" / "免动物伤害失效" 根因
//   现在 3 个重载全 patch,共用 HurtFilter 逻辑
internal static class DamageFilter
{
    // 返回 false = 跳过原伤害;true = 放行(治疗或未配 toggle 的伤害)
    public static bool ShouldBlock(float hp, DamageSource cause)
    {
        if (hp > 0f) return false;  // 治疗放行 (v2.7.29 从 >= 改 > 更严格)

        // v2.7.84:GodMode 拦所有伤害源(含 Freezing/Hypothermia/FrostBite/Starving/Dehydrated/Exhausted)
        //   之前 GodMode 只在 TickStatus 里每帧刷满 HP,但冻伤每帧又扣 → HUD 闪烁
        //   现在直接在 AddHealth Prefix 拦截,HP 永远不掉,TickStatus 只做兜底
        if (CheatState.GodMode) return true;
        if (CheatState.TrueInvisible) return true;  // 真隐身 = 绝对无敌
#if !STORY_EDITION
        if (CeX.InStruggle()) return true;
#endif

        // v2.7.85:各状态 toggle 独立拦截对应伤害源 —— 修复"GodMode OFF + AlwaysWarm ON 时 HP 条闪烁"
        //   之前只在 GodMode 时拦全部,Now 每个 toggle 拦自己的源,减少 TickStatus "先掉再补"的 HUD 闪烁
        if (CheatState.AlwaysWarm && (cause == DamageSource.Freezing || cause == DamageSource.Hypothermia || cause == DamageSource.FrostBite))
            return true;
        if (CheatState.NoFrostbiteRisk && cause == DamageSource.FrostBite)
            return true;
        if (CheatState.NoHunger && cause == DamageSource.Starving) return true;
        if (CheatState.NoThirst && cause == DamageSource.Dehydrated) return true;
        if (CheatState.NoFatigue && cause == DamageSource.Exhausted) return true;

        if (CheatState.NoFallDamage && cause == DamageSource.Falling) return true;
        if (CheatState.NoSuffocating && cause == DamageSource.Suffocating) return true;
        if (CheatState.ImmuneAnimalDamage)
        {
#if STORY_EDITION
            // 2.24 无美洲狮(DamageSource.Cougar 是 2.55 才加的)
            if (cause == DamageSource.Wolf || cause == DamageSource.Bear)
#else
            if (cause == DamageSource.Wolf || cause == DamageSource.Bear || cause == DamageSource.Cougar)
#endif
                return true;
        }
#if !STORY_EDITION
        if (CeX.WouldDie(hp)) { CeX.Rescue(); return true; }
#endif
        return false;
    }
}

internal static class Patch_Condition_AddHealth_2
{
    internal static bool Prefix(float hp, DamageSource cause)
        => !DamageFilter.ShouldBlock(hp, cause);
}

internal static class Patch_Condition_AddHealth_3
{
    internal static bool Prefix(float hp, DamageSource cause)
        => !DamageFilter.ShouldBlock(hp, cause);
}

internal static class Patch_Condition_AddHealthNoHud
{
    internal static bool Prefix(float hp, DamageSource damageSource)
        => !DamageFilter.ShouldBlock(hp, damageSource);
}

// ——— 快速采集 v2.7.19:彻底换方案 —— 延迟调 HarvestSuccessful/QuarterSuccessful 跳过整个时间流逝 + fade
// 之前 Patch_Harvest_Accelerate 把 minutes=0 → panel 等时间但时间不走 = 卡死
// 之前 Patch_Harvest_Update 每帧强推字段 + CameraFade FinishFade = 黑屏 + 递归 = 点取消游戏都卡死
// 现在:Postfix 只记录"2 帧后完成",由 ModMain.OnUpdate 调 QuickHarvestRunner.Tick 完成
internal static class Patch_Harvest_Start
{
    internal static void Postfix(Panel_BodyHarvest __instance)
    {
        if (!CheatState.QuickAction) return;
        // v3.0.4r2 fix: 当 QuickHarvest 已开启,m_HarvestTimeSeconds=Total 让 vanilla 自动 HarvestSuccessful,
        // Runner 不应再 Queue 第二次,否则 vanilla + Runner 双重触发 → 尸体多扣 m_HarvestUnits 个 + stack 合并产出错乱
        if (CheatState.QuickHarvest) return;
        FadeSuppressionWindow.Arm();  // v2.7.29:采集过程内吃 fade
        QuickHarvestRunner.Queue(__instance, QuickHarvestRunner.Action.Harvest);
    }
}

internal static class Patch_Harvest_StartQuarter
{
    internal static void Postfix(Panel_BodyHarvest __instance)
    {
        if (!CheatState.QuickAction) return;
        // v3.0.4r2 fix: 见 Patch_Harvest_Start 同样防双重触发
        if (CheatState.QuickHarvest) return;
        FadeSuppressionWindow.Arm();
        QuickHarvestRunner.Queue(__instance, QuickHarvestRunner.Action.Quarter);
    }
}

// 延迟完成执行器 —— 每帧在 ModMain.OnUpdate 里 tick。
// 分离成 runner 是因为在 StartHarvest Postfix 直接调 HarvestSuccessful,此时 panel state 还未稳定,必报错
internal static class QuickHarvestRunner
{
    internal enum Action { None, Harvest, Quarter }
    internal static Panel_BodyHarvest Instance;
    internal static Action PendingAction = Action.None;
    internal static int Countdown = 0;

    public static void Queue(Panel_BodyHarvest inst, Action a)
    {
        // v2.7.29:防连采覆盖。正在等第一次完成时,第二次 Queue 会覆盖 Instance 导致第一次丢失
        if (PendingAction != Action.None) return;
        Instance = inst; PendingAction = a; Countdown = 2;
    }

    public static void Tick()
    {
        if (PendingAction == Action.None) return;
        if (Instance == null) { Reset(); return; }
        // v2.7.29:panel 已关或 disabled 时不调完成方法,避免 panel 生命周期错乱
        try
        {
            if (!Instance.isActiveAndEnabled) { Reset(); return; }
        }
        catch { Reset(); return; }

        Countdown--;
        if (Countdown > 0) return;
        try
        {
            if (PendingAction == Action.Harvest) Instance.HarvestSuccessful();
            else if (PendingAction == Action.Quarter) Instance.QuarterSuccessful();
            ModMain.Log?.Msg($"[QuickHarvest] {PendingAction} done");
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[QuickHarvest] {ex.Message}"); }
        finally { Reset(); }
    }

    private static void Reset() { PendingAction = Action.None; Instance = null; Countdown = 0; }
}

// ——— 快速修理 v2.7.29:只保留 StartRepair Postfix 一次 set,删 Update Postfix ———
// v2.8.1: 移除 [HarmonyPatch] 属性(IL2CPP 下静默失败),改用 DynamicPatch spec
internal static class Patch_Repair_StartRepair
{
    private static void Postfix(Panel_Repair __instance)
    {
        if (!CheatState.QuickAction) return;
        FadeSuppressionWindow.Arm();
        try
        {
            __instance.m_ElapsedProgressBarSeconds = 999f;
            __instance.m_RepairTimeSeconds = 0.01f;
            __instance.m_ProgressBarTimeSeconds = 0.01f;
            __instance.m_RepairWillSucceed = true;
            __instance.m_TimeAccelerated = true;
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[QuickRepair] {ex.Message}"); }
    }
}

// ——— 快速拆解 v2.7.29:改 OnBreakDown Postfix 一次 set,删 Update Postfix ———
// 秒采集与秒拆解共用同一条拆解流程。
internal static class Patch_BreakDown_OnBreakDown
{
    private static readonly System.Reflection.MethodInfo UpdateDurationLabel =
        HarmonyLib.AccessTools.Method(typeof(Panel_BreakDown), "UpdateDurationLabel");

    internal static void Prefix(Panel_BreakDown __instance)
    {
        Patch_BreakDown_UpdateDuration.Prefix(__instance);
        try
        {
            if (UpdateDurationLabel == null)
                ModMain.Log?.Error("[QuickBreakDown] UpdateDurationLabel method not found");
            else
                UpdateDurationLabel.Invoke(__instance, null);
        }
        catch (System.Exception ex) { ModMain.Log?.Error($"[QuickBreakDown] Duration refresh failed: {ex}"); }
    }

    internal static void Postfix(Panel_BreakDown __instance)
    {
        if ((!CheatState.QuickAction && !CheatState.QuickBreakDown) || !__instance.m_IsBreakingDown) return;
        FadeSuppressionWindow.Arm(5.0f);
        try
        {
            BreakDownCleanup.Armed = true;
            // v2.7.65 关键修:冻结 TOD 避免游戏推进时钟触发 UniStorm 昼夜/天气 ScreenTint(变灰源头)
            //   和 QuickCraft 用的 m_HoursToSpendCrafting=100 但 TOD 不真实推进是同逻辑
            try { var tod = GameManager.GetTimeOfDayComponent(); if (tod != null) tod.SetTODLocked(true); } catch { }
            __instance.m_TimeSpentBreakingDown = __instance.m_SecondsToBreakDown + 1f;
            // 不设 m_TimeIsAccelerated=true —— 它也会触发 ScreenTint
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[QuickBreakDown] {ex.Message}"); }
    }
}

// v2.7.65 打碎完成解锁 TOD + 强制亮屏 —— 必须解锁,不然整个游戏时钟会卡住
// v2.7.73 修"持续暗":之前 FadeIn(0,0) 没拦住 alpha 往 target 走,加 FinishFade(true) 跳过进行中 fade
// v2.7.74 定位到真源头 —— CT 也会出现,说明不是 CameraFade,是 PassTime.m_TimeAccelerated 触发的 ScreenTint;
//   原 BreakDownFinished 可能没 call PassTime.End(),或 End 被我们 force 到的字段抄近路绕过;
//   显式 End() + reset Panel 实例 m_TimeIsAccelerated + PassTime.m_TimeAccelerated
internal static class Patch_BreakDown_Finished_Unfade
{
    internal static void Postfix(Panel_BreakDown __instance)
    {
        if (!BreakDownCleanup.Armed) return;
        try
        {
            try { var tod = GameManager.GetTimeOfDayComponent(); if (tod != null) tod.SetTODLocked(false); } catch { }
            FadeSuppressionWindow.Arm(3.0f);
#if STORY_EDITION
            // 2.24 的 CameraFade 只有 StartAlphaFade + NotifyFadeFinish,没有
            // FadeIn/FinishFade 和 m_TargetAlpha 那组字段。StoryShim 里做等价"立刻亮"。
            StoryShim.FadeInInstant();
#else
            CameraFade.FadeIn(0f, 0f, null);
            try
            {
                CameraFade.m_TargetAlpha = 0f;
                CameraFade.m_StartAlpha = 0f;
                CameraFade.m_FadeTimer = 0f;
                CameraFade.m_FadeDuration = 0f;
                CameraFade.FinishFade(true);
            }
            catch { }
#endif
            // v2.7.74 关键:强制终结 PassTime — "阴天感" overlay 来自 m_TimeAccelerated
            try
            {
                if (__instance != null) __instance.m_TimeIsAccelerated = false;
                var pt = GameManager.GetPassTime();
                if (pt != null)
                {
                    bool wasActive = false;
                    try { wasActive = pt.IsPassingTime(); } catch { }
                    try { if (wasActive) pt.End(); } catch { }
                    try { pt.m_TimeAccelerated = false; } catch { }
                    ModMain.Log?.Msg($"[QuickBD.Finished] PassTime.End (wasActive={wasActive}) + m_TimeAccelerated=false");
                }
                else ModMain.Log?.Msg("[QuickBD.Finished] PassTime null");
            }
            catch (System.Exception ex) { ModMain.Log?.Warning($"[QuickBD.PassTime] {ex.Message}"); }
        }
        catch { }
        finally { BreakDownCleanup.Armed = false; }
    }
}

// 防御性:如果玩家中途取消或退出界面,也要解锁 TOD 不然时钟永远冻
internal static class Patch_BreakDown_ExitInterface_UnlockTOD
{
    internal static void Postfix(Panel_BreakDown __instance)
    {
        BreakDownCleanup.Run(__instance, "ExitInterface");
    }
}

internal static class Patch_BreakDown_OnCancel_UnlockTOD
{
    internal static void Postfix(Panel_BreakDown __instance)
    {
        BreakDownCleanup.Run(__instance, "OnCancel");
    }
}

// v2.7.74 Update 边沿检测:BreakDownFinished 被内联没 fire,用 IsBreakingDown true→false 替代
// v2.7.75 DynamicPatch: 去 [HarmonyPatch] attribute,只在 QuickAction || QuickBreakDown 时挂
internal static class Patch_BreakDown_Update_Edge
{
    private static bool _wasBreaking;
    internal static void Postfix(Panel_BreakDown __instance)
    {
        if (__instance == null) return;
        bool now = false;
        try { now = __instance.m_IsBreakingDown; } catch { }
        if (_wasBreaking && !now) BreakDownCleanup.Run(__instance, "UpdateEdge");
        _wasBreaking = now;
    }
}

// Panel 关闭时也 cleanup —— 兜底覆盖所有退出 path
internal static class Patch_BreakDown_Enable_Cleanup
{
    internal static void Postfix(Panel_BreakDown __instance, bool enable)
    {
        if (!enable) BreakDownCleanup.Run(__instance, "Enable(false)");
    }
}

internal static class BreakDownCleanup
{
    internal static bool Armed;

    public static void Run(Panel_BreakDown inst, string tag)
    {
        if (!Armed) return;
        try { FadeSuppressionWindow.Arm(5.0f); } catch { }
#if STORY_EDITION
        StoryShim.FadeInInstant();
#else
        try { CameraFade.FadeIn(0f, 0f, null); } catch { }
        try
        {
            CameraFade.m_TargetAlpha = 0f;
            CameraFade.m_StartAlpha = 0f;
            CameraFade.m_FadeTimer = 0f;
            CameraFade.m_FadeDuration = 0f;
            CameraFade.FinishFade(true);
        }
        catch { }
#endif
        try { if (inst != null) inst.m_TimeIsAccelerated = false; } catch { }
        bool ptWasActive = false;
        try
        {
            var pt = GameManager.GetPassTime();
            if (pt != null)
            {
                try { ptWasActive = pt.IsPassingTime(); } catch { }
                try { if (ptWasActive) pt.End(); } catch { }
                try { pt.m_TimeAccelerated = false; } catch { }
            }
        }
        catch { }
        try { var tod = GameManager.GetTimeOfDayComponent(); if (tod != null) tod.SetTODLocked(false); } catch { }
        Armed = false;
        ModMain.Log?.Msg($"[QuickBD.Cleanup:{tag}] ptWasActive={ptWasActive}");
    }
}

// v2.7.19 撤掉所有 CameraFade patch + Panel_BodyHarvest.Update Patch:
//   前者递归风险,后者每帧强推字段让游戏状态机错乱 → 2.7.18 卡死根因
//   新方案靠 QuickHarvestRunner 延迟完成 = 直接跳过整个 fade + time 流程,根本不让黑屏出现

// v2.7.29 —— CameraFade 吃 fade 加时间窗口,避免死亡/切场景的正常黑屏被误吃
//   Panel_BodyHarvest / Panel_Crafting / Panel_Repair / Panel_BreakDown 的 Start/Postfix 里
//   调 FadeSuppressionWindow.Arm(1.5f) 打开 1.5s 吃 fade 窗口
//   1.5s 外的 fade 正常显示(死亡/切场景/烟雾效果不受影响)
internal static class FadeSuppressionWindow
{
    private static float _expiresAt = 0f;
    // v2.7.64 从 1.5s 拉长到 3s —— 打碎完成时 TimeIsAccelerated 可能触发 ScreenTint,窗口太短漏掉
    public static void Arm(float seconds = 3.0f)
    {
        try { _expiresAt = UnityEngine.Time.realtimeSinceStartup + seconds; } catch { }
    }
    public static bool IsActive
    {
        get
        {
            try { return UnityEngine.Time.realtimeSinceStartup < _expiresAt; }
            catch { return false; }
        }
    }
}

#if STORY_EDITION
// 2.24 的淡入淡出全走 StartAlphaFade(Color, bool fadeIn, time, delay, cb),
// 没有 FadeOut/FadeIn/FadeTo/Fade 四个入口。窗口内把 time/delay 归零即可,
// 语义与沙盒那四个 patch 一致(吃掉快速操作后的残留黑屏)。
[HarmonyPatch(typeof(CameraFade), "StartAlphaFade")]
internal static class Patch_CameraFade_StartAlphaFade
{
    // 参数名照 2.24 实签:StartAlphaFade(newScreenOverlayColor, isFadeIn, fadeDuration, delay, OnFadeFinish)
    private static void Prefix(ref float fadeDuration, ref float delay)
    {
        if (FadeSuppressionWindow.IsActive) { fadeDuration = 0f; delay = 0f; }
    }
}
#else
[HarmonyPatch(typeof(CameraFade), "FadeOut", new System.Type[] { typeof(float), typeof(float), typeof(Il2CppSystem.Action) })]
internal static class Patch_CameraFade_FadeOut
{
    private static void Prefix(ref float time, ref float delay)
    {
        if (FadeSuppressionWindow.IsActive)
        {
            ModMain.Log?.Msg($"[FadeSuppress] FadeOut time={time} delay={delay}");
            time = 0f; delay = 0f;
        }
    }
}

[HarmonyPatch(typeof(CameraFade), "FadeIn", new System.Type[] { typeof(float), typeof(float), typeof(Il2CppSystem.Action) })]
internal static class Patch_CameraFade_FadeIn
{
    private static void Prefix(ref float time, ref float delay)
    {
        if (FadeSuppressionWindow.IsActive) { time = 0f; delay = 0f; }
    }
}

[HarmonyPatch(typeof(CameraFade), "FadeTo", new System.Type[] { typeof(float), typeof(float), typeof(float), typeof(Il2CppSystem.Action) })]
internal static class Patch_CameraFade_FadeTo
{
    private static void Prefix(ref float time, ref float delay)
    {
        if (FadeSuppressionWindow.IsActive) { time = 0f; delay = 0f; }
    }
}

// v2.7.73 合并 Fade(startAlpha, targetAlpha, time, delay, action) 5 参数
//   窗口内把 start/target 也归 0,避免 Fade(1,1,...) 把黑屏锁死
[HarmonyPatch(typeof(CameraFade), "Fade", new System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float), typeof(Il2CppSystem.Action) })]
internal static class Patch_CameraFade_Fade
{
    private static void Prefix(ref float startAlpha, ref float targetAlpha, ref float time, ref float delay)
    {
        if (FadeSuppressionWindow.IsActive)
        {
            ModMain.Log?.Msg($"[FadeSuppress] Fade5 s={startAlpha} t={targetAlpha} time={time} delay={delay}");
            startAlpha = 0f; targetAlpha = 0f; time = 0f; delay = 0f;
        }
    }
}
#endif

// v2.7.30 重新加回 TimeOfDay.Accelerate Prefix,但只在 QuickCraft 开时改 gameTimeHours=0
//   根因:v2.7.29 只把 craft time=1 秒,但 Accelerate 的 gameTimeHours 原值 8h 仍推进游戏时钟
//   现在 QuickCraft 时 gameTimeHours=0,配合 craft time=1 秒(GetFinalCraftingTime Postfix)
//   → 单个制作 1 秒真实时间完成,游戏时钟不跳,不黑屏
//   batch 不受影响 —— Panel_Crafting.Update 按 craft time 推进 percent,不依赖 gameTimeHours
// 注意:QuickAction(采集/修理/拆解) 不吃 Accelerate,避免 v2.7.26 "关了 QuickCraft 还不消耗时间"的误伤
// v2.7.33 —— 撤销 TimeOfDay.Accelerate Prefix(Panel_Crafting 可能不走 Accelerate 推进时钟)
// 改用 TimeOfDay.SetTODLocked 直接冻结整个游戏时钟:
//   CraftingStart Postfix → SetTODLocked(true)
//   CraftingEnd Postfix → SetTODLocked(false)  (整个 batch 结束才解锁)
// 用户接受黑屏,doFadeToBlack 不再拦(保持游戏默认行为)

// ——— 一击必杀:任何命中动物的伤害都放大到 9999 ———
// 用户要的是"我打它一下它就死",不是"开关一开所有动物全死"
// 4 参虚方法 ApplyDamage(damage, bleedOutMinutes, DamageSource, collider) 指定签名避免歧义
[HarmonyPatch(typeof(BaseAi), "ApplyDamage",
    new System.Type[] { typeof(float), typeof(float), typeof(DamageSource), typeof(string) })]
internal static class Patch_BaseAi_ApplyDamage
{
    private static void Prefix(ref float damage)
    {
        if (CheatState.InstantKillAnimals && damage > 0f) damage = 9999f;
    }
}

// ——— 免费制作:强制返回 "能造",跳过材料检查 ———
[HarmonyPatch(typeof(Panel_Crafting), "CanCraftSelectedBlueprint")]
internal static class Patch_Craft_CanCraftSelected
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeCraft) __result = true;
    }
}

[HarmonyPatch(typeof(Panel_Crafting), "CanCraftBlueprint")]
internal static class Patch_Craft_CanCraft
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeCraft) __result = true;
    }
}

#if !STORY_EDITION
// ——— 免费制作扩展:BlueprintData.HasRequiredMaterials 强制返回 true ———
// 2.24 无 Il2CppTLD.Gear.BlueprintData / Il2CppTLD.Cooking.RecipeBook。
[HarmonyPatch(typeof(Il2CppTLD.Gear.BlueprintData), "HasRequiredMaterials")]
internal static class Patch_BlueprintData_HasRequiredMaterials
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeCraft) __result = true;
    }
}

// ——— 免费制作扩展:RecipeBook.IsRecipeUnlocked 强制返回 true(解锁 DLC/mod 食谱) ———
[HarmonyPatch(typeof(Il2CppTLD.Cooking.RecipeBook), "IsRecipeUnlocked")]
internal static class Patch_RecipeBook_IsRecipeUnlocked
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeCraft) __result = true;
    }
}
#endif

// ——— 免费制作扩展:Panel_Crafting 内部材料检查(mod 物品路径) ———
[HarmonyPatch(typeof(Panel_Milling), "HasEnoughMaterials")]
internal static class Patch_Crafting_HasEnoughMaterials
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeCraft) __result = true;
    }
}

// 原先这里还有一个带参数类型的 CanCraftBlueprint Postfix:2.55 只有这一个重载,和上面 Patch_Craft_CanCraft
//   落在同一个方法上、方法体相同,每次检查配方多过一次 Harmony 桥,已删。

// v7.7 删掉 Patch_Crafting_CanCraftSelected —— 和上面的 Patch_Craft_CanCraftSelected
//   打在同一个方法上、Postfix 体完全一样,等于每次调用白付一次 IL2Cpp 桥开销。

[HarmonyPatch(typeof(Panel_Cooking), "PlayerHasEnoughPotableWaterForCookingItem")]
internal static class Patch_Crafting_HasWater
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeCraft) __result = true;
    }
}

#if !STORY_EDITION   // 2.24 无 CraftingOperation(制作流程在 2.24 之后重构)
[HarmonyPatch(typeof(CraftingOperation), "ConsumeMaterialsUsedForCrafting")]
internal static class Patch_Crafting_SkipConsume
{
    private static bool Prefix() => !CheatState.FreeCraft;
}
#endif

// ——— 免费修理:静态 Postfix 强制修理按钮可用 ———
[HarmonyPatch(typeof(Panel_Inventory_Examine), "CanRepair")]
internal static class Patch_Repair_CanRepair
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeRepair) __result = true;
    }
}

// v2.8.1: HasMaterialsForRepair/RepairHasRequiredTool/RepairHasRequiredMaterial
// 已在 TLD 2.55 中改名或移除,删除失败的 attribute patches(CanRepair + SkipConsume 已足够)

[HarmonyPatch(typeof(Panel_Repair), "ToolCanRepairSelectedItem")]
internal static class Patch_Repair_ToolCanRepair
{
    private static void Postfix(ref bool __result)
    {
        if (CheatState.FreeRepair) __result = true;
    }
}

// ——— 免费修理:跳过消耗材料和工具损耗 ———
internal static class Patch_Repair_SkipConsume
{
    internal static bool Prefix() => !CheatState.FreeRepair;
}

internal static class Patch_Repair_SkipToolDegrade
{
    internal static bool Prefix() => !CheatState.FreeRepair;
}

// ——— 快速制作 v2.7.29:简化为 time=1 策略,完全移除循环递归护栏 ———
// v2.7.27 的 static _busy 护栏有 bug:OnCraftingSuccess 递归触发 CraftingStart 时内层 return
// 跳过 batch 第 2+ 个 item。改成纯粹 "每个 craft time 归 1 秒" 让游戏自己跑 batch:
//   GetFinalCraftingTimeWithAllModifiers / GetAdjustedCraftingTime Postfix = 1
//   → 游戏 Update 读 craftTime=1 → 第 1 个 1 秒完成 → 自动跑第 2 个 1 秒 → ...
//   batch 10 个 = 10 秒,无黑屏,游戏时钟跳动极少
// 不再 patch CraftingStart Postfix —— 让游戏流程自洽推进
// v2.7.40 按用户思路重写:撤销 craft time=1 (那让进度卡 3%)
//   保留原 craft time (比如 10h),但加速 TOD 流速让真实秒走几小时游戏时间
//   craft 完成瞬间 TOD 拉回 → 用户看不到跳
// GetFinalCraftingTime / GetAdjustedCraftingTime 不再 patch,游戏看到正常 craft 时长

// v2.7.43/44 QuickCraft 完整复刻 CT 方案 —— 在 CraftingOperation.Update 开头设字段
// v2.7.75 DynamicPatch
// v6.8.2 移除 m_HoursToSpendCrafting=100 —— 它会让 vanilla ConsumeMaterials 把每帧
//   消耗量按 100h 比例放大(rate × hoursThisTick),实测堆叠材料制作时把整堆吞光。
//   只需缩 m_RealTimeDuration 让真实秒走完;TOD 已被 CraftingStart→SetTODLocked(true) 锁住,
//   不依赖 m_HoursToSpendCrafting 拉时钟。
// v6.8.4 BUG FIX —— 从 Update Prefix 改成 StartCrafting Postfix(单次写入而非每帧重写)
//   根因:Update Prefix 每帧把 m_RealTimeDuration=0.2f。开制作后用户切 toggle 到 OFF →
//   DynamicPatch.Reconcile 立即 Unpatch → 但运行中的 CraftingOperation 已经在前一次 Prefix
//   把 m_RealTimeDuration 写成 0.2f,字段没有 restore。vanilla Update 继续用 0.2 算
//   progress 跳变,单帧 hoursThisTick = m_HoursToSpendCrafting × dt/0.2 异常放大,
//   ConsumeMaterials 一次吞光堆叠材料(用户报"东西直接耗尽")。
//   改成 StartCrafting Postfix:开始时一次性缩短 duration,vanilla Update 自然完成;
//   toggle OFF 中途切也不会留下残余 mutation。同时 FPS 收益更大(每帧 bridge → 每次 craft 1 次)。
#if !STORY_EDITION   // 2.24 无 CraftingOperation
internal static class Patch_CraftingOp_StartCrafting
{
    internal static void Postfix(CraftingOperation __instance)
    {
        if (!CheatState.QuickCraft) return;
        try
        {
            __instance.m_RealTimeDuration = 0.2f;
            FadeSuppressionWindow.Arm(3f);  // 一次性 arm 3 秒,覆盖整个 0.2s craft + 收尾
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QuickCraft] {ex.Message}"); }
    }
}
#endif

// v2.7.44 —— 修 "做完屏幕暗一点" 残留 fade
//   craft 完成后 CameraFade 可能留在 alpha > 0,强制 FadeIn(0,0) 瞬亮
internal static class Patch_Craft_End_ForceBright
{
    internal static void Postfix()
    {
        if (!CheatState.QuickCraft) return;
        try
        {
#if STORY_EDITION
            StoryShim.FadeInInstant();
#else
            CameraFade.FadeIn(0f, 0f, null);  // 瞬 fade in,强制亮
#endif
        }
        catch { }
    }
}

// OnCraftingSuccess 每个 item 完成时调,继续 Arm fade 但不解锁(batch 里还有剩余)
internal static class Patch_Craft_OnSuccess_ArmFade
{
    internal static void Postfix()
    {
        if (CheatState.QuickCraft) FadeSuppressionWindow.Arm(3f);
    }
}

// ——— 隐身感知切断:CanSeeTarget / ScanForSmells ———
// v2.7.23 —— TrueInvisible 语义恢复为"全动物忽略玩家"(狼熊不追/兔鹿不逃)
//   Stealth 仍保持原语义(SetAiMode(Flee) 强制威胁动物逃跑,但兔鹿也会跟着逃,所以 Stealth 是"吓跑模式")
//   TrueInvisible 靠感知层切断 → AI 根本感知不到玩家 → 所有动物当玩家不存在
// v2.7.75 DynamicPatch: 去掉 [HarmonyPatch] attribute,由 DynamicPatch.Reconcile 按 toggle 挂卸
internal static class Patch_BaseAi_CanSeeTarget
{
    internal static bool Prefix(ref bool __result)
    {
        if (CheatState.Stealth || CheatState.TrueInvisible) { __result = false; return false; }
        return true;
    }
}

internal static class Patch_BaseAi_ScanForSmells
{
    internal static bool Prefix() => !(CheatState.Stealth || CheatState.TrueInvisible);
}

// v2.7.29 —— BaseAi 注册式:Start Postfix 加入 HashSet + OnDisable Prefix 移除
//   替代 TickAnimalsFull 每 N 秒 FindObjectsOfType<BaseAi> 的高开销(大地图 200+ AI)
//   Start Postfix 在新 AI 出生时 (1) 注册到 _knownAis (2) 若 TrueInvisible 开则一次性设字段
internal static class BaseAiRegistry
{
    public static readonly System.Collections.Generic.HashSet<BaseAi> Known = new();

    public static void ApplyInvisibleFields(BaseAi ai)
    {
        try
        {
            ai.m_DisableScanForTargets = true;
            ai.ClearTarget();
        }
        catch (System.Exception ex) { ModMain.Log?.Warning($"[TrueInvisible] field set failed: {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(BaseAi), "Start")]
internal static class Patch_BaseAi_Start_Register
{
    private static void Postfix(BaseAi __instance)
    {
        if (__instance == null) return;
        BaseAiRegistry.Known.Add(__instance);
        if (CheatState.TrueInvisible) BaseAiRegistry.ApplyInvisibleFields(__instance);
    }
}

[HarmonyPatch(typeof(BaseAi), "OnDisable")]
internal static class Patch_BaseAi_OnDisable_Unregister
{
    private static void Prefix(BaseAi __instance)
    {
        if (__instance != null) BaseAiRegistry.Known.Remove(__instance);
    }
}

// v2.7.93 注册表:替代 TickInfiniteDurability 每 5s FindObjectsOfType<GearItem> 大地图 50-200ms spike
// v6.8.4 修:TLD 2.55 引擎层移除了 GearItem/Lock/PlayerClimbRope 的 Start/OnDisable
//       改用 TargetMethod() 在 Awake/Start/OnEnable / OnDestroy/OnDisable 候选名里搜
//       使用方 (TickGuns/TickLocks/TickClimbRope) 已经做了 null 检查,死引用积累不会出错
// v6.8.6 修:Harmony 不接受 TargetMethod() 返回 null —— 改用 [HarmonyPrepare]
//       Prepare 返回 false 整个 patch class 静默跳过,不再抛 init 错误。
//       Lock 没 OnDestroy/OnDisable / PlayerClimbRope 没 Awake/OnDestroy/OnDisable 时
//       对应 Unregister patch 自动跳过,使用方 null 检查兜底,功能不变。
internal static class LifecyclePatchHelper
{
    private static readonly string[] RegisterCandidates = new[] { "Awake", "Start", "OnEnable" };
    private static readonly string[] UnregisterCandidates = new[] { "OnDestroy", "OnDisable" };

    public static System.Reflection.MethodBase FindRegister(System.Type t)
    {
        foreach (var name in RegisterCandidates)
        {
            var m = AccessTools.Method(t, name);
            if (m != null) return m;
        }
        return null;
    }

    public static System.Reflection.MethodBase FindUnregister(System.Type t)
    {
        foreach (var name in UnregisterCandidates)
        {
            var m = AccessTools.Method(t, name);
            if (m != null) return m;
        }
        return null;
    }

    // v6.8.6: HarmonyPrepare 用,Available* 任一为 true 才让 Harmony 调 TargetMethod()
    public static bool IsRegisterAvailable(System.Type t) => FindRegister(t) != null;
    public static bool IsUnregisterAvailable(System.Type t) => FindUnregister(t) != null;
}

internal static class GearItemRegistry { public static readonly System.Collections.Generic.HashSet<GearItem> Known = new(); }

[HarmonyPatch(typeof(GearItem))]
internal static class Patch_GearItem_Start_Register
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsRegisterAvailable(typeof(GearItem));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindRegister(typeof(GearItem));
    private static void Postfix(GearItem __instance) { if (__instance != null) GearItemRegistry.Known.Add(__instance); }
}

[HarmonyPatch(typeof(GearItem))]
internal static class Patch_GearItem_OnDisable_Unregister
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsUnregisterAvailable(typeof(GearItem));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindUnregister(typeof(GearItem));
    private static void Prefix(GearItem __instance) { if (__instance != null) GearItemRegistry.Known.Remove(__instance); }
}

// v2.7.93 注册表:替代 TickGuns 每 3s FindObjectsOfType<GunItem>(GunItem 继承 GearItem 但 C# 不传递 Start,需独立 patch)
internal static class GunItemRegistry { public static readonly System.Collections.Generic.HashSet<GunItem> Known = new(); }

[HarmonyPatch(typeof(GunItem))]
internal static class Patch_GunItem_Start_Register
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsRegisterAvailable(typeof(GunItem));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindRegister(typeof(GunItem));
    private static void Postfix(GunItem __instance) { if (__instance != null) GunItemRegistry.Known.Add(__instance); }
}

[HarmonyPatch(typeof(GunItem))]
internal static class Patch_GunItem_OnDisable_Unregister
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsUnregisterAvailable(typeof(GunItem));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindUnregister(typeof(GunItem));
    private static void Prefix(GunItem __instance) { if (__instance != null) GunItemRegistry.Known.Remove(__instance); }
}

// v2.7.93 注册表:替代 TickLocks 每 3s FindObjectsOfType<Lock>
internal static class LockRegistry { public static readonly System.Collections.Generic.HashSet<Lock> Known = new(); }

[HarmonyPatch(typeof(Lock))]
internal static class Patch_Lock_Start_Register
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsRegisterAvailable(typeof(Lock));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindRegister(typeof(Lock));
    private static void Postfix(Lock __instance) { if (__instance != null) LockRegistry.Known.Add(__instance); }
}

[HarmonyPatch(typeof(Lock))]
internal static class Patch_Lock_OnDisable_Unregister
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsUnregisterAvailable(typeof(Lock));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindUnregister(typeof(Lock));
    private static void Prefix(Lock __instance) { if (__instance != null) LockRegistry.Known.Remove(__instance); }
}

// v2.7.93 注册表:替代 TickClimbRope 每 3s FindObjectsOfType<PlayerClimbRope>
internal static class PlayerClimbRopeRegistry { public static readonly System.Collections.Generic.HashSet<PlayerClimbRope> Known = new(); }

[HarmonyPatch(typeof(PlayerClimbRope))]
internal static class Patch_PlayerClimbRope_Start_Register
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsRegisterAvailable(typeof(PlayerClimbRope));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindRegister(typeof(PlayerClimbRope));
    private static void Postfix(PlayerClimbRope __instance) { if (__instance != null) PlayerClimbRopeRegistry.Known.Add(__instance); }
}

[HarmonyPatch(typeof(PlayerClimbRope))]
internal static class Patch_PlayerClimbRope_OnDisable_Unregister
{
    [HarmonyPrepare] static bool Prepare() => LifecyclePatchHelper.IsUnregisterAvailable(typeof(PlayerClimbRope));
    static System.Reflection.MethodBase TargetMethod() => LifecyclePatchHelper.FindUnregister(typeof(PlayerClimbRope));
    private static void Prefix(PlayerClimbRope __instance) { if (__instance != null) PlayerClimbRopeRegistry.Known.Remove(__instance); }
}

// ——— 忽略上锁(只保留 IsLocked,其余 patch 去掉 —— 2.7.1 启动卡死嫌疑)———
// v2.7.75 DynamicPatch: 去 [HarmonyPatch] attribute —— TLD 里锁查询高频(AI/物理/视线)
internal static class Patch_Lock_IsLocked
{
    internal static void Postfix(Lock __instance, ref bool __result)
    {
        if (CheatState.IgnoreLock)
        {
            __result = false;
            // Actually unlock so the lock icon disappears (same as prying open)
            try { __instance.m_LockState = LockState.Unlocked; } catch { }
        }
    }
}
// Lock.RequiresToolToUnlock + PlayerHasRequiredToolToUnlock, Breath.GetBreathTimePercent,
// Encumber.IsEncumbered + GetEncumbranceSlowdownMultiplier 这 5 个 patch 去掉 ——
// 前者因启动卡死嫌疑,后者因为对应功能(IC/IS)已去除(交给 UniversalTweaks 等 mod)

// v2.7.75 DynamicPatch: 去 [HarmonyPatch] attribute —— 下雨时每件衣服每帧调,bridge 开销大
internal static class Patch_Clothing_IncreaseWet
{
    internal static bool Prefix() => !CheatState.NoWetClothes;
}

internal static class Patch_Clothing_GetWetOnGround
{
    internal static bool Prefix() => !CheatState.NoWetClothes;
}

// v2.7.18:删了 ClothingItem.Update Postfix —— 每帧每件 Harmony bridge 是主要 FPS 杀手
// 只靠 2 个 Prefix(IncreaseWetnessPercent + MaybeGetWetOnGround)+ TickClothingWetness(低频)
// 如果还漏,再加另一个 Prefix 拦源头,不要 Update Postfix

// ——— 冰面不破:冰面破裂触发 / 落水 直接跳过 ———
internal static class Patch_IceBreak_BreakIce
{
    internal static bool Prefix() => !CheatState.ThinIceNoBreak;
}

internal static class Patch_IceBreak_FallInWater
{
    internal static bool Prefix() => !CheatState.ThinIceNoBreak;
}

// ——— 生火 100% 成功 ———
// v2.7.31 修:CalculateFireStartSuccess 返回的是 0-100 的 percent(不是 0-1 概率)
//   之前设 1f 实际 = 1% 成功率 —— 用户报告 "开 toggle 只有 1% 概率"
internal static class Patch_FireMgr_Success
{
    internal static void Postfix(ref float __result)
    {
        if (CheatState.QuickFire) __result = 100f;
    }
}

// ——— 钓鱼 100% 成功:缩短咬钩时间到极小值,保证每次必出鱼 ———
internal static class Patch_IceFishing_GuaranteedCatch
{
    internal static void Prefix(IceFishingHole __instance)
    {
        if (!CheatState.QuickFishing) return;
        __instance.m_MinGameMinutesCatchFish = 0.5f;
        __instance.m_MaxGameMinutesCatchFish = 1.0f;
    }
}

// ——— 快速开容器 ——
// v2.7.13:原 Patch_Container_Enable Postfix 覆盖字段不够 —— 改 EnableAfterDelay Prefix 拦源头
internal static class Patch_Container_EnableAfterDelay
{
    internal static void Prefix(ref float delaySeconds)
    {
        if (CheatState.QuickOpenContainer) delaySeconds /= 50f;
    }
}

// 兜底:Enable(bool,bool,Action) Postfix 把 delay 缩短到 1/10
internal static class Patch_Container_Enable
{
    internal static void Postfix(Panel_Container __instance)
    {
        try
        {
            if (CheatState.QuickOpenContainer)
            {
                __instance.m_EnableDelaySeconds /= 50f;
            }
            if (CheatState.InfiniteContainer && __instance.m_Container != null)
#if STORY_EDITION
                // 2.24 Container.m_CapacityKG 是裸 float
                __instance.m_Container.m_CapacityKG = 10000f;
#else
                __instance.m_Container.m_Capacity = Il2CppTLD.IntBackedUnit.ItemWeight.FromKilograms(10000f);
#endif
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════════
//   v2.7.86 无后坐力根治 —— Hook PlayFireAnimation
// ═══════════════════════════════════════════════════════════════════
// CT 实现:hook vp_FPSWeapon.PlayFireAnimation → 设 [rdi+120..12c] = 0
//   这 4 个偏移 = vp_FPSWeapon 的 recoil 动画参数(继承自 vp_Component 的 float 字段)
//   之前只改 GunItem 字段(m_PitchRecoilMin/Max)无效——后坐力在 PlayFireAnimation 内施加
//   现在 Harmony Postfix 在开枪动画触发后立刻归零这些参数,彻底消除后坐力视觉

// —— 无后坐力 + 超级精准:Hook vp_FPSWeapon.PlayFireAnimation ——
// v2.7.89 无后坐力:零化 GunItem 的后坐力参数,让 PlayFireAnimation 正常播放动画
// 原理:PlayFireAnimation 读 GunItem.m_PitchRecoilMin/Max + m_YawRecoilMin/Max 计算后坐力。
// 值为 0 → 不施加力 → 无后坐。Postfix 恢复原值避免持久修改。
internal static class Patch_FPSWeapon_PlayFireAnimation
{
    private static GunItem _gun;
    private static float _pitchMin, _pitchMax, _yawMin, _yawMax;

    internal static bool Prefix(vp_FPSWeapon __instance)
    {
        bool fullSuppress = CheatState.NoRecoil || CheatState.SuperAccuracy;
        bool partialSuppress = CheatStateESP.RecoilScale < 0.99f;
        if (!fullSuppress && !partialSuppress) return true;
        _gun = null;
        try
        {
            // 反编译确认:PlayFireAnimation 读的就是 vp_FPSWeapon.m_GunItem(+0x210)的后坐字段
            var gun = __instance.m_GunItem;
            if (gun != null)
            {
                _gun = gun;
                _pitchMin = gun.m_PitchRecoilMin;
                _pitchMax = gun.m_PitchRecoilMax;
                _yawMin = gun.m_YawRecoilMin;
                _yawMax = gun.m_YawRecoilMax;
                float scale = fullSuppress ? 0f : CheatStateESP.RecoilScale;
                gun.m_PitchRecoilMin = _pitchMin * scale;
                gun.m_PitchRecoilMax = _pitchMax * scale;
                gun.m_YawRecoilMin = _yawMin * scale;
                gun.m_YawRecoilMax = _yawMax * scale;
            }
        }
        catch { }
        return true;
    }

    internal static void Postfix(vp_FPSWeapon __instance)
    {
        // 魔法子弹:开枪后直接对准星前方目标施加伤害(必须在 _gun==null 早退之前,
        // 否则只在后坐力抑制同时开启时才生效)
        try { MagicBulletSystem.OnFired(); } catch { }
        if (_gun == null) return;
        try
        {
            _gun.m_PitchRecoilMin = _pitchMin;
            _gun.m_PitchRecoilMax = _pitchMax;
            _gun.m_YawRecoilMin = _yawMin;
            _gun.m_YawRecoilMax = _yawMax;
        }
        catch { }
        _gun = null;
    }
}

// v7.7 删掉 Patch_FPSWeapon_AddForce2 / Patch_FPSCamera_AddForce2 —— 两个类既没有
//   [HarmonyPatch] attribute 也没有 DynamicPatch Spec,从来没挂载过;而且它们唯一的
//   守卫条件读的是 InFireAnimation,那个字段全工程无人赋值(编译器 CS0649),恒为 false
//   → 即便挂上也永远直接 return true。无后坐力实际由 PlayFireAnimation 前后零化/还原
//   GunItem 的 recoil 字段实现(见上),与这两个类无关。

// 相机只处理晃动。后坐力在源头(PlayFireAnimation 前后零化 GunItem 后坐字段)就没有了,
//   游戏里没有第二个后坐入口(反编译确认 SetTarget 只被 PlayFireAnimation 调用),这里不再碰弹簧。
internal static class Patch_FPSCamera_ClearRecoil
{
    private static bool _logged;
    private static bool _swayOn;
    private static bool _gunHeld;

    internal static void Prefix(vp_FPSCamera __instance)
    {
        _swayOn = CheatState.NoAimSway || CheatState.SuperAccuracy;
        if (!_swayOn) { _gunHeld = false; return; }
        _gunHeld = WeaponCache.IsHoldingGun();
        if (!_gunHeld) return;

        try { __instance.m_MaxAmbientSwayAngleDegreesA = 0f; } catch { }
        try { __instance.m_MaxAmbientAimingSwayAngleDegreesA = 0f; } catch { }
        try { __instance.m_AmbientSwaySpeedA = 0f; } catch { }
        try { __instance.m_AmbientAimingSwaySpeedA = 0f; } catch { }
        try { __instance.m_CurrentMaxAmbientSwayAngle = 0f; } catch { }
        try { __instance.m_CurrentAmbientSwaySpeed = 0f; } catch { }
        try { __instance.ShakeAmplitude = UnityEngine.Vector3.zero; } catch { }
        try { __instance.ShakeSpeed = 0f; } catch { }
        try { __instance.BobAmplitude = UnityEngine.Vector4.zero; } catch { }
    }

    internal static void Postfix(vp_FPSCamera __instance)
    {
        if (_swayOn && _gunHeld)
        {
            try
            {
                var pm = GameManager.GetPlayerManagerComponent();
                var gi = pm?.m_ItemInHands;
                if (gi != null)
                {
                    var gun = gi.GetComponent<GunItem>();
                    if (gun != null)
                    {
                        gun.m_SwayValue = 0f;
                        gun.m_SwayValueZeroFatigue = 0f;
                        gun.m_SwayValueMaxFatigue = 0f;
                    }
                }
                __instance.m_CurrentMaxAmbientSwayAngle = 0f;
                __instance.m_CurrentAmbientSwaySpeed = 0f;
                __instance.ShakeAmplitude = UnityEngine.Vector3.zero;
                __instance.ShakeSpeed = 0f;
            }
            catch { }
        }
        if (!_logged && _swayOn)
        {
            _logged = true;
            try { ModMain.Log?.Msg("[Aim] Camera Update Postfix active (steady aim)"); } catch { }
        }
    }
}

// LateUpdate 只剩晃动清零和 GunZoom。原先开枪后 0.5 秒把相机旋转锁回上一帧的补偿已删除
//   (它丢掉当帧鼠标位移,开枪后视角会卡住再跳一下)。
internal static class Patch_FPSCamera_LateUpdate
{
    internal static void Postfix(vp_FPSCamera __instance)
    {
        if ((CheatState.NoAimSway || CheatState.SuperAccuracy) && WeaponCache.IsHoldingGun())
        {
            try
            {
                __instance.ShakeAmplitude = UnityEngine.Vector3.zero;
                __instance.ShakeSpeed = 0f;
                __instance.BobAmplitude = UnityEngine.Vector4.zero;
                __instance.m_CurrentMaxAmbientSwayAngle = 0f;
                __instance.m_CurrentAmbientSwaySpeed = 0f;
            }
            catch { }
        }
        // GunZoom:瞄准时滚轮缩放 FOV
        GunZoomState.ApplyZoom(__instance);
    }
}

// —— 超级精准:子弹在 vp_FPSShooter.Fire 里以相机朝向生成,再随机偏转 ProjectileSpread 度。
//   开枪前把散布置 0,子弹就沿准星射出;开枪后还原。 ——
internal static class Patch_FPSShooter_Fire
{
    private static vp_FPSShooter _shooter;
    private static float _spread;
    private static bool _logged;

    internal static void Prefix(vp_FPSShooter __instance)
    {
        _shooter = null;
        if (!CheatState.SuperAccuracy) return;
        try
        {
            _spread = __instance.ProjectileSpread;
            __instance.ProjectileSpread = 0f;
            _shooter = __instance;
            if (!_logged)
            {
                _logged = true;
                ModMain.Log?.Msg($"[Aim] SuperAccuracy: spread {_spread} -> 0");
            }
        }
        catch { }
    }

    internal static void Postfix()
    {
        if (_shooter == null) return;
        try { _shooter.ProjectileSpread = _spread; } catch { }
        _shooter = null;
    }
}

// —— 瞄准滚轮缩放:整合 GunZoom ——
internal static class GunZoomState
{
    public static float RifleMult = 1f;
    public static float RevolverMult = 1f;
    private static float _lerpMult = 1f;
    private static float _originalMainFOV = -1f;
    private static float _originalWeaponFOV = -1f;
    private static float _baseSensitivity = -1f;
    private static bool _wasZooming;
    private const float ZoomIncrement = 1.2f;
    private const float ZoomSpeed = 15f;

    public static void UpdateScroll()
    {
        var s = ModMain.Settings;
        if (s == null || !s.GunZoomEnabled) return;
        var cam = GameManager.m_vpFPSCamera;
        if (cam == null || !cam.IsZoomed) { _lerpMult = 1f; return; }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll == 0f) return;

        if (!WeaponCache.IsHoldingGun()) return;
        bool rifle = WeaponCache.IsRifle;
        bool revolver = WeaponCache.IsRevolver;
        if (!rifle && !revolver) return;

        if (rifle)
        {
            if (scroll > 0f) RifleMult /= ZoomIncrement; else RifleMult *= ZoomIncrement;
            RifleMult = Mathf.Clamp(RifleMult, 0.05f, 1f);
        }
        else
        {
            if (scroll > 0f) RevolverMult /= ZoomIncrement; else RevolverMult *= ZoomIncrement;
            RevolverMult = Mathf.Clamp(RevolverMult, 0.33f, 1f);
        }
    }

    public static void ApplyZoom(vp_FPSCamera cam)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || !s.GunZoomEnabled) return;
            if (!cam.IsZoomed)
            {
                if (_wasZooming) RestoreFOV(cam);
                _lerpMult = 1f;
                return;
            }

            if (!WeaponCache.IsHoldingGun()) { if (_wasZooming) RestoreFOV(cam); return; }
            bool rifle = WeaponCache.IsRifle;
            bool revolver = WeaponCache.IsRevolver;
            if (!rifle && !revolver) { if (_wasZooming) RestoreFOV(cam); return; }

            if (_baseSensitivity <= 0f)
            {
                _baseSensitivity = cam.MouseSensitivity;
                var mainCam = cam.GetComponent<Camera>();
                if (mainCam != null) _originalMainFOV = mainCam.fieldOfView;
                if (cam.m_WeaponCamera != null) _originalWeaponFOV = cam.m_WeaponCamera.fieldOfView;
            }

            float target = rifle ? RifleMult : RevolverMult;
            _lerpMult = Mathf.Lerp(_lerpMult, target, Time.deltaTime * ZoomSpeed);

            var mc = cam.GetComponent<Camera>();
            if (mc != null) mc.fieldOfView = _originalMainFOV * _lerpMult;
            if (cam.m_WeaponCamera != null) cam.m_WeaponCamera.fieldOfView = _originalWeaponFOV * _lerpMult;
            cam.MouseSensitivity = _baseSensitivity * Mathf.Clamp(_lerpMult + 0.15f, 0f, 1f);
            _wasZooming = true;
        }
        catch { }
    }

    private static void RestoreFOV(vp_FPSCamera cam)
    {
        try
        {
            if (_baseSensitivity > 0f) cam.MouseSensitivity = _baseSensitivity;
            var mc = cam.GetComponent<Camera>();
            if (mc != null && _originalMainFOV > 0f) mc.fieldOfView = _originalMainFOV;
            if (cam.m_WeaponCamera != null && _originalWeaponFOV > 0f) cam.m_WeaponCamera.fieldOfView = _originalWeaponFOV;
        }
        catch { }
        _wasZooming = false;
    }
}

// —— 稳定瞄准:锁定武器位置/旋转 + 归零 bob/shake/sway 参数 ——
internal static class Patch_FPSWeapon_SteadyAim
{
    [ThreadStatic] private static Vector3 _savedPos;
    [ThreadStatic] private static Quaternion _savedRot;
    [ThreadStatic] private static bool _hasSaved;

    internal static void Prefix(vp_FPSWeapon __instance)
    {
        if (!CheatState.NoAimSway && !CheatState.SuperAccuracy) { _hasSaved = false; return; }
        if (!WeaponCache.IsHoldingGun()) { _hasSaved = false; return; }
        try
        {
            var t = __instance.transform;
            if (t != null) { _savedPos = t.localPosition; _savedRot = t.localRotation; _hasSaved = true; }
            else _hasSaved = false;
        }
        catch { _hasSaved = false; }
    }

    internal static void Postfix(vp_FPSWeapon __instance)
    {
        // _hasSaved 只有在 Prefix 确认了 NoAimSway/SuperAccuracy + IsHoldingGun 后才为 true
        // 故直接用它作早退出，省去重复读 CheatState + WeaponCache
        if (!_hasSaved) return;
        try { __instance.transform.localPosition = _savedPos; } catch { }
        try { __instance.transform.localRotation = _savedRot; } catch { }
        try { __instance.BobAmplitude = Vector4.zero; } catch { }
        try { __instance.ShakeAmplitude = Vector3.zero; } catch { }
        try { __instance.ShakeSpeed = 0f; } catch { }
        try { __instance.SwayMaxFatigue = 0f; } catch { }
        try { __instance.SwayStartFatigue = 999f; } catch { }
    }
}


// v7.7 删掉 Patch_Camera_NoAmbientSway —— 无 attribute 无 Spec,从未挂载。
//   "瞄准不晃"实际由上面 Patch_Weapon_NoSway 零化 Sway* 字段实现。

// ═══════════════════════════════════════════════════════════════════
//   v2.7.86 新增功能 —— 随意生火 / 生火材料不减 / 科技背包 / 火把满值 / 无条件冲刺 / 无限体力
// ═══════════════════════════════════════════════════════════════════


// —— 无限体力 + 体力恢复倍率 + 体力消耗倍率:PlayerMovement.AddSprintStamina ——
// CT 实现:patch AddSprintStamina → mov [rbx+80],(float)100
// v2.7.88r2: 同 patch 顺带处理体力恢复倍率 — 每次 vanilla 加正向体力时按 StaminaRecharge 乘倍率
//   这是 vanilla 真正的体力恢复入口(每帧调用,amount 是该帧恢复量),比改 m_Sprint... 字段稳
// v2.7.88r4: 加 StaminaDrain (amount<0 路径) + 挂载条件扩到任一滑条非默认值 (见 DynamicPatch)
internal static class Patch_AddSprintStamina
{
    // v7.7 修「滑条 4 倍实际 16 倍」:倍率原本在这里(精确 hook)和 Patch_StaminaTweaks.ApplyTick
    //   (每帧 diff)两处各算一遍,两者叠乘。
    //   注意挂载条件原先是「任一滑条 != 出厂默认(4.9/0.44)」,所以
    //     - 用默认值的玩家 → 本补丁不挂 → 只有 ApplyTick 生效 → 4.9 倍(正确)
    //     - 拖过滑条的玩家 → 本补丁挂上 → 两处叠乘 → 4 倍变约 16 倍(错)
    //   保留 ApplyTick 作为唯一施加点(它是轮询式的,不依赖 hook 能否挂上,且默认值下也在跑,
    //   一致性最好),这里只留无限体力的钳位。
    internal static bool ShouldPatch() => CheatState.InfiniteStamina;

    // v6.8.6 修:Harmony 按参数名匹配,vanilla 真实签名是 AddSprintStamina(float stamina) 不是 amount
    internal static void Postfix(PlayerMovement __instance, float stamina)
    {
        if (!CheatState.InfiniteStamina) return;
        try { __instance.m_SprintStamina = 100f; } catch { }
    }
}

// —— 速度倍率:vp_FPSController.GetSlopeMultiplier Postfix ——
// 复制自 SonicMode:根据移动状态(蹲/走/冲刺)乘以对应系数
internal static class Patch_SpeedMultiplier
{
    internal static void Postfix(ref float __result)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || !s.SpeedTweaksEnabled) return;
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) return;
            if (pm.PlayerIsSprinting())
                __result *= s.SprintSpeed;
            else if (pm.PlayerIsCrouched())
                __result *= s.CrouchSpeed;
            else
                __result *= s.WalkSpeed;
        }
        catch { }
    }
}

// —— 体力恢复:PlayerMovement.Update Postfix ——
// 复制自 SonicMode:每帧设置恢复速率和延迟
// v2.7.87 修:解绑 SpeedTweaksEnabled — 体力滑条独立生效,不再被"启用速度调节"锁住
internal static class Patch_StaminaTweaks
{
    private static float _initSeconds;
    private static bool _inited;
    private static float _lastDelay = -1f;

    // v7.7 删掉 Postfix / RestoreVanilla / ShouldPatch / DefaultRecharge / DefaultDelay:
    //   这个类既没有 [HarmonyPatch] attribute 也没有 DynamicPatch Spec,Postfix 从未挂载过
    //   (全工程只有 ModMain 调 ApplyTick)。而且 Postfix 写的是
    //   m_SprintStaminaRecoverPerHour *= recharge,与 ApplyTick 的 diff 补差是同一个倍率的
    //   第二个施加点 —— 一旦有人给它补上 Spec 就会重演 H1 的「4 倍变 16 倍」。
    //   体力恢复/消耗倍率现在只由 ApplyTick 施加,延迟字段的还原也在 ApplyTick 内闭环。

    // v7.7 ApplyTick 的零成本快速门(见 ApplyTick 里的注释)。
    //   三个倍率全 ≈1 时,ApplyTick 内每条分支都已经是 no-op(delay 写的是 _initSeconds*1,
    //   两条 diff 分支都被 Mathf.Abs(mult) > 0.01f 挡掉),所以直接退出与跑完全等价。
    //   _lastDelay 也要一起判:滑条从非默认拖回 1.0 时得让 ApplyTick 再跑一次把字段写回,
    //   否则会卡在改过的值上。
    private static bool NeedsTick(TldHacksSettings s)
    {
        return Mathf.Abs(s.StaminaRecharge - 1f) > 0.01f
            || Mathf.Abs(s.StaminaDrain - 1f) > 0.01f
            || Mathf.Abs(s.StaminaRecoveryDelay - 1f) > 0.01f
            || (_lastDelay >= 0f && _lastDelay != s.StaminaRecoveryDelay);
    }

    // v2.7.88r5: diff trick — 每帧观察 vanilla 改了多少体力,补一笔差值实现倍率
    //   Harmony hook AddSprintStamina 在 IL2Cpp 下可能静默失败,这里完全绕开,无依赖
    private static float _lastSprintStamina = -1f;
    private static int _diffInited = 0;
    internal static void ApplyTick()
    {
        var s = ModMain.Settings;
        if (s == null) return;

        // v7.7 性能修:这个方法由 ModMain.OnUpdate 每帧无条件调用,原先只有 s==null / pm==null
        //   两道门,于是即使三个体力参数全是原版值也照样每帧 4-6 次 IL2Cpp 桥穿越
        //   (GetPlayerMovementComponent + 读写 m_SprintStamina)。
        //   下面这道门是纯浮点比较,三参数全默认时直接退出 → 零桥调用。
        //   注意:必须同时判 Drain(ShouldPatch() 只判 Recharge/Delay,不能直接复用),
        //   且 InfiniteStamina 开着时也要继续跑,因为要维护 _lastSprintStamina 基线。
        if (!NeedsTick(s) && !CheatState.InfiniteStamina)
        {
            _diffInited = 0; _lastSprintStamina = -1f;
            return;
        }

        var pm = GameManager.GetPlayerMovementComponent();
        if (pm == null) { _diffInited = 0; _lastSprintStamina = -1f; return; }

        // 延迟字段(只在滑条变化时写一次)
        float delay = s.StaminaRecoveryDelay;
        if (delay != _lastDelay)
        {
            if (!_inited)
            {
                // v7.7 不再快照 m_SprintStaminaRecoverPerHour:唯一的读取方(已删的 Postfix)
                //   走的是"改 vanilla 恢复速率"路线,而 ApplyTick 走的是 diff 补差,不碰这个字段。
                _initSeconds = pm.m_SecondsNotSprintingBeforeRecovery;
                if (_initSeconds <= 0f) _initSeconds = 1.5f;
                _inited = true;
            }
            _lastDelay = delay;
            try { pm.m_SecondsNotSprintingBeforeRecovery = _initSeconds * delay; } catch { }
        }

        // diff trick:观察 vanilla 这帧 m_SprintStamina 的变化量,按倍率补差
        float cur = pm.m_SprintStamina;
        if (_diffInited < 3) { _lastSprintStamina = cur; _diffInited++; return; } // 头几帧 warm up
        if (CheatState.InfiniteStamina) { _lastSprintStamina = cur; return; }     // 由 Patch_AddSprintStamina 处理

        float delta = cur - _lastSprintStamina;
        if (delta > 0.001f)
        {
            // vanilla 加了 delta → 总恢复 = delta*recharge,补 delta*(recharge-1)
            float mult = s.StaminaRecharge - 1f;
            if (Mathf.Abs(mult) > 0.01f)
            {
                cur = Mathf.Clamp(cur + delta * mult, 0f, 100f);
                try { pm.m_SprintStamina = cur; } catch { }
            }
        }
        else if (delta < -0.001f)
        {
            // vanilla 扣了 |delta| → 总扣 = drain*|delta|,补加 delta*(drain-1)
            //   drain=2:cur+=delta*1=多扣一份 → 总扣 2*|delta|
            //   drain=0.5:cur+=delta*(-0.5)=还回一半 → 总扣 0.5*|delta|
            float mult = s.StaminaDrain - 1f;
            if (Mathf.Abs(mult) > 0.01f)
            {
                cur = Mathf.Clamp(cur + delta * mult, 0f, 100f);
                try { pm.m_SprintStamina = cur; } catch { }
            }
        }
        _lastSprintStamina = cur;
    }
}

#if !STORY_EDITION
// —— 火把燃烧时间:Panel_FeedFire.Enable Postfix ——
// 复制自 TorchTweaker:设置 min/max condition
// 2.24 无 Panel_FeedFire.m_Min/MaxNormalizedTorchCondition,两个类连同 DynamicPatch 的 Spec 一起排除。
internal static class Patch_TorchCondition
{
    internal static void Postfix(Panel_FeedFire __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;
            __instance.m_MinNormalizedTorchCondition = s.TorchMinCondition;
            __instance.m_MaxNormalizedTorchCondition = s.TorchMaxCondition;
        }
        catch { }
    }
}

// —— 火把 condition:Panel_ActionPicker.Enable Postfix ——
// TorchTweaker 原版同时 patch 这两个面板,保证从地上/靠近火堆等交互也生效
internal static class Patch_TorchCondition_ActionPicker
{
    internal static void Postfix()
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;
            var panel = InterfaceManager.GetPanel<Panel_FeedFire>();
            if (panel == null) return;
            panel.m_MinNormalizedTorchCondition = s.TorchMinCondition;
            panel.m_MaxNormalizedTorchCondition = s.TorchMaxCondition;
        }
        catch { }
    }
}
#endif


// —— 交互距离:PlayerManager.ComputeModifiedPickupRange Postfix ——
// 复制自 StretchArmstrong:乘以滑块倍率
internal static class Patch_PickupRange
{
    internal static void Postfix(ref float __result)
    {
        try
        {
            var s = ModMain.Settings;
            if (s != null) __result *= s.PickupRange;
        }
        catch { }
    }
}

// —— 脚步静音:FootStepSounds.PlayFootStepSound Prefix ——
// 复制自 SilentWalker:toggle on 时完全不播放脚步声
// 2 参数重载 PlayFootStepSound(Vector3, string)
internal static class Patch_SilentFootsteps
{
    internal static bool Prefix() => !CheatState.SilentFootsteps;
}
// 3 参数重载 PlayFootStepSound(Vector3, string, State)
internal static class Patch_SilentFootsteps_3p
{
    internal static bool Prefix() => !CheatState.SilentFootsteps;
}

// 复制自 SilentWalker:按 RTPC ID 缩放背包物品发声音量
internal static class Patch_SilentWalker_RTPC
{
    internal static void Prefix(uint rtpcID, ref float rtpcValue)
    {
        var s = ModMain.Settings;
        if (s == null) return;
        int pct;
        switch (rtpcID)
        {
            case 135115684u: pct = s.InvWeightMetalVol; break;
            case 330491720u: pct = s.InvWeightWoodVol; break;
            case 1721946080u: pct = s.InvWeightWaterVol; break;
            case 2064316281u: pct = s.InvWeightGeneralVol; break;
            default: return;
        }
        rtpcValue *= pct / 100f;
    }
}

// —— 衰减倍率:GearItem.Degrade Prefix ——
// 复制自 GearDecayModifier:根据物品类型乘以对应衰减系数
internal static class Patch_GearDegrade
{
    private static readonly System.Collections.Generic.Dictionary<IntPtr, float> _cache = new();
    internal static void InvalidateCache() => _cache.Clear();
    private static bool Has(string name, string key) => name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0;

    internal static bool Prefix(GearItem __instance, ref float hp)
    {
        try
        {
            if (FallClothingGuard.Active) { hp = 0f; return true; }
            if (CheatState.InfiniteDurability) { hp = 0f; return true; }
            // 原先这里还有 QuickCraft → hp=0:v3.0.4 时快速制作把制作小时数设成 100,不归零会磨光工具。
            //   v6.8.2 起只缩真实时长,工具磨损总量就是原版量;留着它等于开快速制作就全局无限耐久。
            if (__instance == null) return true;

            // 快速路径：已知物品直接用缓存倍率(子类别 mult,GeneralDecay/OnUseDecay 作为额外乘子在外面再乘)
            if (_cache.TryGetValue(__instance.Pointer, out float cached))
            {
                float h = hp * cached;
                // v6.0.x: GeneralDecay 作为全局总缩放,所有路径都乘
                h *= DecayState.GeneralDecay;
                // v6.0.x: OnUseDecay 对所有"使用时衰减"物品再乘一次(枪/弓/工具/磨刀石等都触发)
                if (__instance.m_DegradeOnUse != null) h *= DecayState.OnUseDecay;
                // FoodDecay("食物总倍率")对所有食物再乘一次,与 GeneralDecay 同级的食物伞
                if (__instance.m_FoodItem != null) h *= DecayState.FoodDecay;
                if (!__instance.m_BeenInspected && !__instance.m_BeenInPlayerInventory)
                    h *= DecayState.DecayBeforePickup;
                hp = h;
                return true;
            }

            // 子类别 mult(默认 1.0,被分支覆盖时改成具体子类倍率);GeneralDecay/OnUseDecay 不参与缓存,在外面乘
            float mult = 1f;
            string name = __instance.gameObject.name;

            // Check specific item types by name first
            // 下面几个关键词游戏里的大小写和这里不同(GEAR_BedRoll / GEAR_BottlePainKillers / GEAR_Firestriker /
            //   GEAR_CatTailStalk / GEAR_RawRockfish),用 Has 忽略大小写;其余保持区分大小写,免得 Tea 误中 Steak 这类名字
            if (Has(name, "Bedroll")) mult = DecayState.BedrollDecay;
            else if (name.Contains("Travois")) mult = DecayState.TravoisDecay;
            else if (name.Contains("Arrow")) mult = DecayState.ArrowDecay;
            else if (name.Contains("Snare")) mult = DecayState.SnareDecay;
            else if (name.Contains("FlareGunAmmo")) mult = DecayState.FlareGunAmmoDecay;
            else if (name.Contains("CookingPot") || name.Contains("RecycledCan")) mult = DecayState.CookingPotDecay;
            else if (name.Contains("Hide") || name.Contains("Pelt") || name.Contains("Gut") || name.Contains("Leather"))
                mult = DecayState.HideDecay;
            else if (name.Contains("FirstAid") || name.Contains("Bandage") || name.Contains("Antibiotic") || Has(name, "Painkiller"))
                mult = DecayState.FirstAidDecay;
            else if (name.Contains("WaterPurifier")) mult = DecayState.WaterPurifierDecay;
            else if (__instance.m_DegradeOnUse != null)
            {
                if (__instance.m_GunItem != null) mult = DecayState.GunDecay;
                else if (__instance.m_BowItem != null) mult = DecayState.BowDecay;
                else if (name.Contains("Whetstone") || name.Contains("SharpeningStone"))
                    mult = DecayState.WhetstoneDecay;
                else if (name.Contains("CanOpener")) mult = DecayState.CanOpenerDecay;
                else if (name.Contains("Prybar")) mult = DecayState.PrybarDecay;
                else if (Has(name, "FireStriker") || name.Contains("Matches") || name.Contains("Flare"))
                    mult = DecayState.FirestartingDecay;
                else if (__instance.m_ToolsItem != null)
                {
                    if (name.Contains("Hatchet") || name.Contains("Knife") || name.Contains("Hacksaw"))
                        mult = DecayState.BodyHarvestDecay;
                    else
                        mult = DecayState.ToolsDecay;
                }
                // v6.0.x: 兜底也用 1.0;OnUseDecay 在外面统一乘,不再当 fallback
            }
            else if (__instance.m_FoodItem != null)
            {
                if (name.Contains("Coffee") || name.Contains("Tea") || name.Contains("HerbalTea"))
                    mult = DecayState.CoffeeTeaDecay;
                else if (__instance.m_FoodItem.m_IsDrink) mult = DecayState.DrinksDecay;
                else if (name.Contains("Canned") || name.Contains("PinnacleCanPeaches") || name.Contains("TomatoSoup") || name.Contains("DogFood"))
                    mult = DecayState.CannedFoodDecay;
                else if (name.Contains("PackagedFood") || name.Contains("GranolaBar") || name.Contains("EnergyBar") || Has(name, "CattailStalk"))
                    mult = DecayState.PackagedFoodDecay;
                else if (name.Contains("CookingFat") || name.Contains("BearFat"))
                    mult = DecayState.FatDecay;
                else if (name.Contains("CuredFish") || name.Contains("Jerky") && name.Contains("Fish"))
                    mult = DecayState.CuredFishDecay;
                else if (__instance.m_FoodItem.m_IsRawMeat && Has(name, "Fish"))
                    mult = DecayState.RawFishDecay;
                else if (__instance.m_FoodItem.m_IsMeat && Has(name, "Fish"))
                    mult = DecayState.CookedFishDecay;
                else if (name.Contains("Cured") || name.Contains("Jerky"))
                    mult = DecayState.CuredMeatDecay;
                else if (name.Contains("Flour") || name.Contains("Yeast") || name.Contains("Salt") || name.Contains("Sugar"))
                    mult = DecayState.IngredientsDecay;
                else if (__instance.m_FoodItem.m_IsRawMeat) mult = DecayState.RawMeatDecay;
                else if (__instance.m_FoodItem.m_IsMeat) mult = DecayState.CookedMeatDecay;
                else mult = DecayState.OtherFoodDecay;
            }
            else if (__instance.m_ClothingItem != null)
            {
                mult = DecayState.ClothingDecayRate;
            }

            _cache[__instance.Pointer] = mult;

            // v6.0.x: GeneralDecay 全局总缩放,所有路径都乘
            mult *= DecayState.GeneralDecay;
            // v6.0.x: OnUseDecay 对所有"使用时衰减"物品再乘一次(枪/弓/工具/磨刀石等都触发)
            if (__instance.m_DegradeOnUse != null) mult *= DecayState.OnUseDecay;
            // FoodDecay("食物总倍率")对所有食物再乘一次,与 GeneralDecay 同级的食物伞
            if (__instance.m_FoodItem != null) mult *= DecayState.FoodDecay;

            if (!__instance.m_BeenInspected && !__instance.m_BeenInPlayerInventory)
                mult *= DecayState.DecayBeforePickup;

            hp *= mult;
        }
        catch { }
        return true;
    }
}

// —— 随意生火:绕过室内生火限制 ——
// CT 实现:patch InputManager.CanStartFireIndoors → NOP 2 bytes
// Harmony 做法:Prefix 强制 return true
internal static class Patch_FireAnywhere
{
    internal static bool Prefix(ref bool __result)
    {
        if (CheatState.FireAnywhere)
        {
            __result = true;
            return false; // skip original
        }
        return true;
    }
}

// —— 生火/修理材料不减:PlayerManager.ConsumeUnitFromInventory(void) skip ——
internal static class Patch_ConsumeUnit
{
    internal static bool Prefix()
    {
        if (CheatState.FreeFireFuel || CheatState.FreeRepair) return false;
        return true;
    }
}

// —— 自定义背包负重:Encumber.Update Postfix 直接覆盖原版 30kg 上限 ——
// v3.0.4 fix: 移除 dirty-check —— vanilla Encumber.Update 每帧重置字段,
//   dirty-check 第一次写后被 vanilla 覆盖 → 永远 return → 看似无效。
//   照抄 UniversalTweaks 写法: 每帧 Postfix 写 7 字段(开销可忽略,Update 1 次/帧)
internal static class Patch_TechBackpack
{
    private static float _lastKg;

    internal static void Postfix(Encumber __instance)
    {
        try
        {
            if (__instance == null || !CheatState.TechBackpack) return;
            float kg = CheatState.TechBackpackKg;
#if STORY_EDITION
            // 2.24 这 7 个字段名都带 KG 后缀且是裸 float(2.55 才改成 ItemWeight 并去掉后缀)
            if (kg == _lastKg && __instance.m_MaxCarryCapacityKG == kg) return;
            _lastKg = kg;
            __instance.m_MaxCarryCapacityKG = kg;
            __instance.m_MaxCarryCapacityWhenExhaustedKG = kg * 0.5f;
            __instance.m_NoSprintCarryCapacityKG = kg + 10f;
            __instance.m_NoWalkCarryCapacityKG = kg + 30f;
            __instance.m_EncumberLowThresholdKG = kg + 1f;
            __instance.m_EncumberMedThresholdKG = kg + 10f;
            __instance.m_EncumberHighThresholdKG = kg + 30f;
#else
            if (kg == _lastKg && __instance.m_MaxCarryCapacity == ItemWeight.FromKilograms(kg)) return;
            _lastKg = kg;
            __instance.m_MaxCarryCapacity = ItemWeight.FromKilograms(kg);
            __instance.m_MaxCarryCapacityWhenExhausted = ItemWeight.FromKilograms(kg * 0.5f);
            __instance.m_NoSprintCarryCapacity = ItemWeight.FromKilograms(kg + 10f);
            __instance.m_NoWalkCarryCapacity = ItemWeight.FromKilograms(kg + 30f);
            __instance.m_EncumberLowThreshold = ItemWeight.FromKilograms(kg + 1f);
            __instance.m_EncumberMedThreshold = ItemWeight.FromKilograms(kg + 10f);
            __instance.m_EncumberHighThreshold = ItemWeight.FromKilograms(kg + 30f);
#endif
        }
        catch { }
    }
}

// —— 关闭自定义负重时手动还原原版值(由 Menu UI 调) ——
internal static class EncumberVanilla
{
    internal static void Reset()
    {
        try
        {
            var e = GameManager.GetEncumberComponent();
            if (e == null) return;
#if STORY_EDITION
            e.m_MaxCarryCapacityKG = 30f;
            e.m_MaxCarryCapacityWhenExhaustedKG = 15f;
            e.m_NoSprintCarryCapacityKG = 40f;
            e.m_NoWalkCarryCapacityKG = 60f;
            e.m_EncumberLowThresholdKG = 31f;
            e.m_EncumberMedThresholdKG = 40f;
            e.m_EncumberHighThresholdKG = 60f;
#else
            e.m_MaxCarryCapacity = ItemWeight.FromKilograms(30f);
            e.m_MaxCarryCapacityWhenExhausted = ItemWeight.FromKilograms(15f);
            e.m_NoSprintCarryCapacity = ItemWeight.FromKilograms(40f);
            e.m_NoWalkCarryCapacity = ItemWeight.FromKilograms(60f);
            e.m_EncumberLowThreshold = ItemWeight.FromKilograms(31f);
            e.m_EncumberMedThreshold = ItemWeight.FromKilograms(40f);
            e.m_EncumberHighThreshold = ItemWeight.FromKilograms(60f);
#endif
        }
        catch { }
    }
}

// —— 火把燃烧时间:TorchItem.Update Prefix 同步 settings 到实例 ——
// SetTorchPrefab 只改模板,已存在的火把实例不受影响;此 patch 保证所有活跃火把都用用户设定的 BurnLifetimeMinutes
internal static class Patch_TorchBurnTime
{
    internal static void Prefix(TorchItem __instance)
    {
        var s = ModMain.Settings;
        if (s == null) return;
        __instance.m_BurnLifetimeMinutes = s.TorchBurnMinutes;
    }
}

// —— 火把满值:TorchItem.Update 重置燃烧时间 + HP ——
internal static class Patch_TorchFullValue
{
    internal static void Prefix(TorchItem __instance)
    {
        if (!CheatState.TorchFullValue) return;
        if (!__instance.IsBurning()) return;
        __instance.m_ElapsedBurnMinutes = 0f;
        var gi = __instance.m_GearItem;
        if (gi != null) gi.m_CurrentHP = 100f;
    }
}

// —— 天气锁定:阻止 WeatherTransition 自动切换 ——
internal static class Patch_WeatherLock
{
    internal static bool Prefix() => !CheatState.WeatherLocked;
}

// ——————————— Tick-based 补丁 ———————————
// OnUpdate 每帧/每 N 帧扫一次实例,直接改字段。
internal static class CheatsTick
{
    // ——— 武器:无限弹药 / 永不卡壳 / 无后坐(字段层 fallback)———
    // v2.7.92 性能:InfiniteAmmo/NoJam 需扫全场景;其余只需手持武器,避免 FindObjectsOfType
    public static void TickGuns()
    {
        if (!CheatState.InfiniteAmmo && !CheatState.NoJam && !CheatState.SuperAccuracy && !CheatState.NoAimSway) return;
        try
        {
            if (CheatState.NoJam)
            {
                try { GunItem.m_ForceNoJam = true; } catch { }
            }

            // 只有 InfiniteAmmo/NoJam 需要遍历所有枪(补满全部弹夹/清卡壳)
            if (CheatState.InfiniteAmmo || CheatState.NoJam)
            {
                // v2.7.93 改用注册表,避免每 3s FindObjectsOfType<GunItem> spike
                var guns = GunItemRegistry.Known;
                foreach (var g in guns)
                {
                    if (g == null) continue;
                    try
                    {
                        if (CheatState.NoJam) try { g.m_IsJammed = false; } catch { }
                        if (CheatState.InfiniteAmmo && g.m_ClipSize > 0 && g.m_RoundsInClip < g.m_ClipSize)
                            g.m_RoundsInClip = g.m_ClipSize;
                    }
                    catch { }
                }
            }

            if (CheatState.SuperAccuracy || CheatState.NoAimSway)
            {
                var pm = GameManager.GetPlayerManagerComponent();
                var gi = pm?.m_ItemInHands;
                var g = gi != null ? gi.GetComponent<GunItem>() : null;
                if (g != null)
                {
                    if (CheatState.NoAimSway || CheatState.SuperAccuracy)
                    {
                        try { g.m_SwayValueZeroFatigue = 0f; } catch { }
                        try { g.m_SwayValueMaxFatigue = 0f; } catch { }
                        try { g.m_SwayValue = 0f; } catch { }
                    }
                }
            }
        }
        catch { }
    }

    // ——— 摄像机:NoRecoil / NoAimSway / NoAimShake / NoBreathSway / NoAimStamina ———
    // v2.7.2 优化:(1) 所有 FieldInfo lazy 缓存到 static,不再每次 GetField;
    //             (2) 有任一 toggle ON 才跑 full path,全关且上次也关 → 早退 0 开销;
    //             (3) 从每帧改成 ModMain 里调用 —— 调用频率由 ModMain 决定(30 帧 = 0.5s)
    // v2.7.83 修:加诊断日志 + 多重 fallback 武器查找 + 降频到 30 帧
    private static bool _lastAnyAimToggle = false;
    private static bool _aimDiagDone = false; // 只打一次诊断日志
    // v2.7.84:vp_FPSCamera 缓存 + 兜底查找节流
    private static vp_FPSCamera _cachedCam = null;
    private static int _lastCamScanFrame = -999;
    private static int _camNullLogCount = 0;
    // v2.7.84 重写:只保留 FindWeapon 需要的 + RecoilSpring struct 操作需要的反射
    // v8.0.1: m_CurrentWeapon / m_RecoilSpring 原先走 camT.GetField(...),恒为 null ——
    //   vp_FPSCamera 是 class,interop 把它的实例成员全生成成 property。直接读属性即可。
    //   (嵌套 struct RecoilSpring 是 ValueType,interop 给的是真字段,所以 _fi_rs* 保留反射;
    //    不过它们的解析入口原先挂在 _fi_recoilSpring 上,一起改成 typeof 拿。)
    private static FieldInfo _fi_rsCur, _fi_rsTgt, _fi_rsVel;
    private static bool _reflectionInited = false;

    // v2.7.84:跨场景时清相机缓存 + 重置诊断开关 —— 从 ModMain.OnSceneWasInitialized 调
    public static void InvalidateCameraCache()
    {
        _cachedCam = null;
        // 不重置 _aimDiagDone:诊断本意是每个进程只打一次,原先每次切场景都重跑(反射 1206 个方法名,写十几行日志)
        _camNullLogCount = 0;
        _lastCamScanFrame = -999;
        _lastWeaponScanFrame = -999;   // v7.7 跨场景允许立刻重扫一次武器层级
        // 同时清空 TickStatus 组件缓存,场景切换后组件引用失效
        _cFrostbite = null;
        _cFatigue = null;
        _cHunger = null;
        _cThirst = null;
        _cFreezing = null;
        _cCondition = null;
        _cPlayerManager = null;
    }

    // v7.7 路径 2/3 的候选成员缓存(见 FindWeapon 内注释)。跨场景不失效:
    //   缓存的是类型的 FieldInfo/MethodInfo,不是实例引用。
    private static FieldInfo[] _weaponFieldCache;
    private static MethodInfo[] _weaponMethodCache;
    private static int _lastWeaponScanFrame = -999;

    private static FieldInfo[] ResolveWeaponFields(Type camT)
    {
        var list = new System.Collections.Generic.List<FieldInfo>(4);
        foreach (var name in new[] { "m_Weapon", "m_ActiveWeapon", "currentWeapon", "Weapon" })
        {
            var fi = camT.GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (fi != null) list.Add(fi);
        }
        return list.ToArray();
    }

    private static MethodInfo[] ResolveWeaponMethods(Type pmT)
    {
        var list = new System.Collections.Generic.List<MethodInfo>(3);
        foreach (var mname in new[] { "GetWeaponItem", "GetCurrentWeapon", "GetActiveWeapon" })
        {
            var mi = pmT.GetMethod(mname, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (mi != null && mi.GetParameters().Length == 0) list.Add(mi);
        }
        return list.ToArray();
    }

    // v2.7.83:多路径查找武器实例(反射 → PlayerManager → GetComponentInChildren)
    private static object FindWeapon(vp_FPSCamera cam)
    {
        // 路径 1:直接读 m_CurrentWeapon 属性
        try
        {
            var w = cam.m_CurrentWeapon;
            if (w != null) return w;
        }
        catch { }
        // 路径 2:尝试其他字段名(m_Weapon / m_ActiveWeapon / currentWeapon)
        try
        {
            // v7.7 性能:候选成员只解析一次(结果含"一个都没有"),之后每帧复用。
            //   原先没缓存 → 只要手里没枪(路径 1 返回 null),这里每帧重跑 4 次 GetField
            //   + 下面 3 次 GetMethod,而 TickCamera 在任一瞄准开关 ON 时每帧都调。
            //   缓存的是 FieldInfo/MethodInfo 而非取到的值,查找结果与逐帧解析完全一致。
            var camFields = _weaponFieldCache ??= ResolveWeaponFields(cam.GetType());
            for (int i = 0; i < camFields.Length; i++)
            {
                var fi = camFields[i];
                var w = fi.GetValue(cam);
                if (w != null)
                {
                    ModMain.Log?.Msg($"[Aim] Found weapon via fallback field '{fi.Name}'");
                    return w;
                }
            }
        }
        catch { }
        // 路径 3:PlayerManager.GetWeaponItem() 等公开方法
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm != null)
            {
                var pmMethods = _weaponMethodCache ??= ResolveWeaponMethods(pm.GetType());
                for (int i = 0; i < pmMethods.Length; i++)
                {
                    var mi = pmMethods[i];
                    var w = mi.Invoke(pm, null);
                    if (w != null)
                    {
                        ModMain.Log?.Msg($"[Aim] Found weapon via PlayerManager.{mi.Name}()");
                        return w;
                    }
                }
            }
        }
        catch { }
        // 路径 4:从 camera 的 GameObject 子层级找 vp_FPSWeapon 组件
        // v7.7 性能:这条路径要跑两次 GetComponentsInChildren(其中一次是 MonoBehaviour 全量
        //   + 逐个 GetType().Name 字符串匹配),开销远高于路径 1-3。而"手里没武器"时前三条
        //   路径全返回 null → 原先每帧都会走到这里做一次全层级扫描。限流到每 30 帧一次:
        //   真装备了武器时路径 1(m_CurrentWeapon)当帧就命中,永远走不到这里;只有反射路径
        //   全灭的极端情况才依赖路径 4,那种情况下最多晚 0.5 秒找到,行为不变。
        if (Time.frameCount - _lastWeaponScanFrame < 30) return null;
        _lastWeaponScanFrame = Time.frameCount;
        try
        {
            var camGo = cam.gameObject;
            if (camGo != null)
            {
                var weapons = camGo.GetComponentsInChildren<vp_FPSWeapon>(true);
                if (weapons != null && weapons.Count > 0)
                {
                    ModMain.Log?.Msg($"[Aim] Found weapon via GetComponentsInChildren<vp_FPSWeapon> ({weapons.Count})");
                    return weapons[0];
                }
                // 也试 MonoBehaviour 基类搜索
                var allMono = camGo.GetComponentsInChildren<MonoBehaviour>(true);
                if (allMono != null)
                {
                    foreach (var mb in allMono)
                    {
                        if (mb == null) continue;
                        var n = mb.GetType().Name;
                        if (n.Contains("Weapon") || n.Contains("Gun") || n.Contains("Rifle"))
                        {
                            ModMain.Log?.Msg($"[Aim] Found weapon-like component '{n}' on child");
                            return mb;
                        }
                    }
                }
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[Aim] path4 children: {ex.Message}"); }
        return null;
    }

    // v2.7.84 简化:只初始化 RecoilSpring struct 操作需要的 FieldInfo。
    //   武器 bool 开关走 SetDisable* 静态方法(反编译确认存在);
    //   武器/camera float 字段直接通过实例赋值,不需要反射。
    private static void EnsureReflectionInited()
    {
        if (_reflectionInited) return;
        var rsT = typeof(vp_FPSCamera.RecoilSpring);
        _fi_rsCur = _fi_rsCur ?? rsT.GetField("m_Current",  BindingFlags.Instance | BindingFlags.Public);
        _fi_rsTgt = _fi_rsTgt ?? rsT.GetField("m_Target",   BindingFlags.Instance | BindingFlags.Public);
        _fi_rsVel = _fi_rsVel ?? rsT.GetField("m_Velocity", BindingFlags.Instance | BindingFlags.Public);
        _reflectionInited = true;
    }

    // v2.7.84 重写:反编译确认 vp_FPSWeapon 的 Disable* 是 static bool + Set* 静态方法,
    //   不再需要实例反射。camera float 字段直接写实例属性。只剩 m_RecoilSpring(struct) 需要 FieldInfo。
    public static void TickCamera()
    {
        bool anyOn = CheatState.NoAimSway || CheatState.NoAimStamina || CheatState.SuperAccuracy;
        // 全关 AND 上次也全关 → 零开销早退
        if (!anyOn && !_lastAnyAimToggle) return;
        if (GameManager.IsMainMenuActive()) return;

        try
        {
            // v2.7.84:先 cache → GameManager getter → scene-wide scan 兜底
            var cam = _cachedCam;
            if (cam == null)
            {
                cam = GameManager.GetVpFPSCamera();
                if (cam == null && Time.frameCount - _lastCamScanFrame > 30)
                {
                    _lastCamScanFrame = Time.frameCount;
                    try { cam = UnityEngine.Object.FindObjectOfType<vp_FPSCamera>(); } catch { }
                    if (cam != null)
                        ModMain.Log?.Msg("[AimDiag] vp_FPSCamera via FindObjectOfType (GetVpFPSCamera=null)");
                }
                if (cam != null) _cachedCam = cam;
            }
            if (cam == null)
            {
                if ((++_camNullLogCount % 60) == 1)
                    ModMain.Log?.Warning($"[AimDiag] cam=null (try #{_camNullLogCount}), 未进游戏场景?");
                return;
            }

            object weapon = null;
            EnsureReflectionInited();
            weapon = FindWeapon(cam);

            // v2.7.83:首次有 toggle ON 时打诊断日志
            if (!_aimDiagDone && anyOn)
            {
                _aimDiagDone = true;
                // 相机继承链字段 dump
                try
                {
                    var t = cam.GetType(); int depth = 0;
                    while (t != null && depth < 5)
                    {
                        var fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                        var sb = new System.Text.StringBuilder($"[AimDiag] Cam depth={depth} type={t.FullName} fields({fields.Length}):");
                        foreach (var f in fields) sb.Append($" {f.Name}({f.FieldType.Name})");
                        ModMain.Log?.Msg(sb.ToString());
                        t = t.BaseType; depth++;
                    }
                }
                catch (Exception ex) { ModMain.Log?.Warning($"[AimDiag] cam dump: {ex.Message}"); }

                if (weapon != null)
                {
                    try
                    {
                        var wt = weapon.GetType(); int wd = 0;
                        while (wt != null && wd < 5)
                        {
                            var wfields = wt.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                            var wsb = new System.Text.StringBuilder($"[AimDiag] Weap depth={wd} type={wt.FullName} fields({wfields.Length}):");
                            foreach (var wf in wfields) wsb.Append($" {wf.Name}({wf.FieldType.Name})");
                            ModMain.Log?.Msg(wsb.ToString());
                            wt = wt.BaseType; wd++;
                        }
                    }
                    catch (Exception ex) { ModMain.Log?.Warning($"[AimDiag] weapon dump: {ex.Message}"); }
                }
                else ModMain.Log?.Warning("[AimDiag] weapon = NULL — FindWeapon() all 4 paths failed. No weapon equipped?");

                // dump PlayerManager 的 weapon 相关方法
                try
                {
                    var pm = GameManager.GetPlayerManagerComponent();
                    if (pm != null)
                    {
                        var pmT = pm.GetType();
                        var pmMethods = pmT.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        var pmSb = new System.Text.StringBuilder($"[AimDiag] PlayerManager type={pmT.FullName} methods({pmMethods.Length}):");
                        foreach (var m in pmMethods)
                        {
                            if (m.Name.Contains("Weapon") || m.Name.Contains("Gun") || m.Name.Contains("Rifle")
                                || m.Name.Contains("Equip") || m.Name.Contains("Active") || m.Name.Contains("Current"))
                                pmSb.Append($" {m.Name}({m.GetParameters().Length}p)");
                        }
                        ModMain.Log?.Msg(pmSb.ToString());
                    }
                    else ModMain.Log?.Warning("[AimDiag] PlayerManager = null");
                }
                catch (Exception ex) { ModMain.Log?.Warning($"[AimDiag] PM dump: {ex.Message}"); }

                // v2.7.84:静态 bool 字段诊断 —— 确认 Set* 方法可用
                var diags = new System.Text.StringBuilder("[AimDiag] Static Disable fields: ");
                try { diags.Append($"Sway={vp_FPSWeapon.m_DisableAimSway} "); } catch (Exception ex) { diags.Append($"Sway=ERR({ex.Message}) "); }
                try { diags.Append($"Shake={vp_FPSWeapon.m_DisableAimShake} "); } catch (Exception ex) { diags.Append($"Shake=ERR({ex.Message}) "); }
                try { diags.Append($"Breath={vp_FPSWeapon.m_DisableAimBreathing} "); } catch (Exception ex) { diags.Append($"Breath=ERR({ex.Message}) "); }
                try { diags.Append($"Stamina={vp_FPSWeapon.m_DisableAimStamina} "); } catch (Exception ex) { diags.Append($"Stamina=ERR({ex.Message}) "); }
                try { diags.Append($"DOF={vp_FPSWeapon.m_DisableDepthOfField} "); } catch (Exception ex) { diags.Append($"DOF=ERR({ex.Message}) "); }
                try { diags.Append($"CamAmbSway={vp_FPSCamera.m_DisableAmbientSway} "); } catch (Exception ex) { diags.Append($"CamAmbSway=ERR({ex.Message}) "); }
                diags.Append($"recoilSpringFields={(_fi_rsCur != null ? "OK" : "null")} ");
                diags.Append($"weapon={weapon?.GetType().FullName ?? "null"}");
                ModMain.Log?.Msg(diags.ToString());
            }

            // ——— 静态 bool 开关:每帧同步(toggle ON=true / OFF=false) ———
            // 反编译确认:vp_FPSWeapon.m_DisableAimSway 等是 static bool,Set* 是 static 方法
            // 空 weapon 不影响 —— static 字段全局生效,不依赖实例
            // v2.7.84:NoAimSway 合并了 sway+shake+breath 三个 toggle
            try { vp_FPSWeapon.m_DisableAimSway      = CheatState.NoAimSway || CheatState.SuperAccuracy;    } catch (Exception ex) { ModMain.Log?.Warning($"[Aim] SetAimSway: {ex.Message}"); }
            try { vp_FPSWeapon.m_DisableAimShake     = CheatState.NoAimSway || CheatState.SuperAccuracy;    } catch (Exception ex) { ModMain.Log?.Warning($"[Aim] SetAimShake: {ex.Message}"); }
            try { vp_FPSWeapon.m_DisableAimBreathing  = CheatState.NoAimSway || CheatState.SuperAccuracy;    } catch (Exception ex) { ModMain.Log?.Warning($"[Aim] SetAimBreath: {ex.Message}"); }
            try { vp_FPSWeapon.m_DisableAimStamina   = CheatState.NoAimStamina; } catch (Exception ex) { ModMain.Log?.Warning($"[Aim] SetAimStamina: {ex.Message}"); }
            try { vp_FPSCamera.m_DisableAmbientSway   = CheatState.NoAimSway || CheatState.SuperAccuracy;    } catch (Exception ex) { ModMain.Log?.Warning($"[Aim] m_DisableAmbientSway: {ex.Message}"); }

            // v2.7.92 性能:camera sway + recoil spring 清零已由 DynamicPatch 每帧 Prefix 覆盖,
            //   此处只保留 weapon 实例反射(DynamicPatch 的 SteadyAim 也做,但这里是兜底)
            if (!anyOn)
            {
                _lastAnyAimToggle = false;
                return;
            }

            if ((CheatState.NoAimSway || CheatState.SuperAccuracy) && weapon != null)
            {
                // v8.0.1: 原先 wType.GetField("BobAmplitude"/"ShakeAmplitude"/"ShakeSpeed"),
                //   三个在 interop 上都是 property → FieldInfo 恒 null,`?.SetValue` 静默跳过,
                //   这段兜底从来没生效过。改成强转 vp_FPSWeapon 直接写属性。
                try
                {
                    if (weapon is vp_FPSWeapon w)
                    {
                        w.BobAmplitude = UnityEngine.Vector4.zero;
                        w.ShakeAmplitude = UnityEngine.Vector3.zero;
                        w.ShakeSpeed = 0f;
                    }
                } catch { }
            }

            _lastAnyAimToggle = true;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TickCamera] {ex.Message}"); }
    }

    // ——— 动物不能动 / 隐身 ———
    // v2.7.9 重写 Stealth:之前 m_DisableScanForTargets 单靠它不够 ——
    // 游戏内部的检测路径还有别的入口。现在强力方案:
    //   1) 设 m_DisableScanForTargets = true(阻止新增探测)
    //   2) 对已经在 Attack/Stalking/Investigate/HoldGround 的 AI,立即 SetAiMode(Wander)
    //      —— 公开方法,可靠;等于把玩家从威胁列表踢出
    private static bool _lastTickedStealth = false;
    private static bool _lastTickedFreeze = false;
    private static bool _lastTickedInvis = false;

    // v2.7.24 TrueInvisible cheap:每 1s 设玩家 AiTarget.m_IsEnabled + ClearTarget 所有 AI
    //   关玩家 AiTarget 让世界查询 FindAiTargets 拿不到玩家;清 AI 现有 target 避免已 target 的残留
    public static void TickAnimalsCheap()
    {
        if (!CheatState.TrueInvisible && !_lastTickedInvis) return;
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm != null && pm.m_AiTarget != null)
                pm.m_AiTarget.m_IsEnabled = !CheatState.TrueInvisible;
        }
        catch { }
        _lastTickedInvis = CheatState.TrueInvisible;
    }

    public static void TickAnimalsFull() => TickAnimals();

    public static void TickAnimals()
    {
        bool runStealth = CheatState.Stealth || _lastTickedStealth;
        bool runFreeze  = CheatState.FreezeAnimals || _lastTickedFreeze;
        bool runInvis   = CheatState.TrueInvisible || _lastTickedInvis;
        if (!runStealth && !runFreeze && !runInvis) return;

        try
        {
            // v2.7.29:改用注册表(HashSet)而不是 FindObjectsOfType<BaseAi>
            //   大地图 200+ AI 的 FindObjects 要 ~20-50ms,HashSet iterate 只几百纳秒
            //   HashSet 维护:BaseAi.Start Postfix 加入,OnDisable Prefix 移除
            var ais = BaseAiRegistry.Known;
            if (ais.Count == 0)
            {
                _lastTickedStealth = CheatState.Stealth;
                _lastTickedFreeze  = CheatState.FreezeAnimals;
                _lastTickedInvis   = CheatState.TrueInvisible;
                return;
            }

            // v2.7.29 兜底:Il2Cpp wrapper == null 判断不可靠,还要检查 Pointer
            System.Collections.Generic.List<BaseAi> stale = null;
            foreach (var ai in ais)
            {
                if (ai == null || ai.Pointer == System.IntPtr.Zero)
                {
                    (stale ??= new()).Add(ai);
                    continue;
                }
                try
                {
                    if (runFreeze)
                    {
                        try { ai.m_SpeedForPathfindingOverride = CheatState.FreezeAnimals; } catch { }
                        if (CheatState.FreezeAnimals)
                            try { ai.m_OverrideSpeed = 0f; } catch { }
                    }

                    // v2.7.24 TrueInvisible 核心修:用强类型属性直接访问(Il2CppInterop 下 m_X 是 property 不是 field,反射无效)
                    // 切断所有感知通道 —— AI 像瞎子聋子,闻不到看不见听不见,加清现有 target 踢出残留
                    if (runInvis)
                    {
                        try { ai.m_DisableScanForTargets = CheatState.TrueInvisible; } catch { }
                        if (CheatState.TrueInvisible)
                        {
                            try { ai.ClearTarget(); } catch { }
                        }
                    }

                    // Stealth 主力:看到动物就强制切 Flee(逃跑)
                    // (Stealth 和 TrueInvisible 互斥使用建议:TrueInvisible = 全忽略;Stealth = 全吓跑)
                    if (CheatState.Stealth)
                    {
                        try
                        {
                            var mode = ai.GetAiMode();
                            if (mode != AiMode.Flee
                                && mode != AiMode.Dead
                                && mode != AiMode.Sleep
                                && mode != AiMode.Struggle
                                && mode != AiMode.Stunned
                                && mode != AiMode.ScriptedSequence)
                            {
                                try { ai.ClearTarget(); } catch { }
                                ai.SetAiMode(AiMode.Flee);
                            }
                        }
                        catch { }
                    }
                    // v2.7.74 Stealth 关闭边沿:把之前被强推到 Flee 的动物拉回 Wander,让 AI 重新按 fear/感知判断
                    else if (_lastTickedStealth)
                    {
                        try
                        {
                            if (ai.GetAiMode() == AiMode.Flee)
                            {
                                try { ai.ClearTarget(); } catch { }
                                ai.SetAiMode(AiMode.Wander);
                            }
                        }
                        catch { }
                    }
                }
                catch { }
            }

            // v2.7.29:清 stale AI(场景切换时可能遗留的 disposed wrapper)
            if (stale != null) foreach (var s in stale) ais.Remove(s);

            _lastTickedStealth = CheatState.Stealth;
            _lastTickedFreeze  = CheatState.FreezeAnimals;
            _lastTickedInvis   = CheatState.TrueInvisible;
        }
        catch { }
    }

    // ——— 忽略上锁:v2.7.8 修 —— 不能用 lk.IsLocked() 判(被 Patch_Lock_IsLocked 篡返回 false)
    // 改直接读 m_LockState 字段
    private static System.Reflection.MethodInfo _mi_lock_setLockState;
    public static void TickLocks()
    {
        if (!CheatState.IgnoreLock) return;
        try
        {
            // v2.7.93 改用注册表,避免每 3s FindObjectsOfType<Lock> spike
            var locks = LockRegistry.Known;

            if (_mi_lock_setLockState == null)
                _mi_lock_setLockState = typeof(Lock).GetMethod("SetLockState", BindingFlags.Instance | BindingFlags.Public);
            if (_mi_lock_setLockState == null) return;

            foreach (var lk in locks)
            {
                if (lk == null) continue;
                try
                {
                    // v8.0.1: 原先用 GetField("m_LockState") 读,Il2CppInterop 把实例成员生成成
                    //   property(真字段只有 static NativeFieldInfoPtr_*),FieldInfo 恒为 null →
                    //   整个 TickLocks 在 null 检查处直接 return,无视锁全程空转。改成直接读属性。
                    if (lk.m_LockState == LockState.Locked)
                        _mi_lock_setLockState.Invoke(lk, new object[] { LockState.Unlocked });
                }
                catch { }
            }
        }
        catch { }
    }

    // ——— 爬绳加速 ———
    // 直接设固定值 5.0(原值 0.3~1.5 左右),幂等:多次 tick 不会叠加。
    // 注意:无法在 toggle 关掉后还原原值(原值没记录),要等场景重载。
    public static void TickClimbRope()
    {
        if (!CheatState.QuickClimb) return;
        try
        {
            // v2.7.93 改用注册表,避免每 3s FindObjectsOfType<PlayerClimbRope> spike
            var all = PlayerClimbRopeRegistry.Known;
            foreach (var p in all)
            {
                if (p == null) continue;
                try
                {
                    // v8.0.1: 原先 GetField 这五个名字,interop 实例成员是 property → 恒 null,
                    //   爬绳加速完全不生效。改成直接写属性(幂等:设到 5 就不再动)。
                    if (p.m_ClimbSpeed > 0f && p.m_ClimbSpeed < 5f) p.m_ClimbSpeed = 5f;
                    if (p.m_ClimbSpeedUpFullyRested > 0f && p.m_ClimbSpeedUpFullyRested < 5f) p.m_ClimbSpeedUpFullyRested = 5f;
                    if (p.m_ClimbSpeedUpExhausted > 0f && p.m_ClimbSpeedUpExhausted < 5f) p.m_ClimbSpeedUpExhausted = 5f;
                    if (p.m_ClimbSpeedDownFullyRested > 0f && p.m_ClimbSpeedDownFullyRested < 5f) p.m_ClimbSpeedDownFullyRested = 5f;
                    if (p.m_ClimbSpeedDownExhausted > 0f && p.m_ClimbSpeedDownExhausted < 5f) p.m_ClimbSpeedDownExhausted = 5f;
                }
                catch { }
            }
        }
        catch { }
    }

    // ——— 无饥饿 / 无口渴 / 无疲劳 / 始终温暖 / GodMode 兜底 ———
    // v2.7.62 仿 CT:设"合理低值"而非"max/0",让游戏的吃喝睡 UI 认为还有空间,交互可用
    //   - Fatigue: 10(CT 原值)—— 玩家仍能触发睡觉(0 时游戏可能不让睡)
    //   - Hunger: 2450 cal(CT 原值,≈ 1 day starting reserve)—— 玩家仍能吃东西
    //   - Thirst: 0 —— UI 显示不渴即可,喝水仍能触发(游戏不 check "thirst > 0 才能喝")
    //   - Freezing: 0 —— 同上
    //   - GodMode 走 max HP 路径(玩家不会死,与吃喝睡 UI 无关)
    private static bool _frostbiteWasOn;
    // v2.7.x 性能:组件缓存,避免每帧 IL2CPP bridge 分配 managed wrapper
    private static Frostbite _cFrostbite;
    private static Fatigue _cFatigue;
    private static Hunger _cHunger;
    private static Thirst _cThirst;
    private static Freezing _cFreezing;
    private static Condition _cCondition;
    private static PlayerManager _cPlayerManager;

    private static void EnsureStatusComponents()
    {
        if (_cFrostbite != null) return;
        try { _cFrostbite = GameManager.GetFrostbiteComponent(); } catch { }
        try { _cFatigue = GameManager.GetFatigueComponent(); } catch { }
        try { _cHunger = GameManager.GetHungerComponent(); } catch { }
        try { _cThirst = GameManager.GetThirstComponent(); } catch { }
        try { _cFreezing = GameManager.GetFreezingComponent(); } catch { }
        try { _cCondition = GameManager.GetConditionComponent(); } catch { }
        try { _cPlayerManager = GameManager.GetPlayerManagerComponent(); } catch { }
    }

    public static void TickStatus()
    {
        // master early exit: 全部关掉且 frostbite 也不需要关闭时跳过
        bool needFrostbite = CheatState.NoFrostbiteRisk || _frostbiteWasOn;
        if (!needFrostbite && !CheatState.NoFatigue && !CheatState.NoHunger
            && !CheatState.NoThirst && !CheatState.AlwaysWarm
            && !CheatState.GodMode && !CheatState.FatigueBuff) return;

        EnsureStatusComponents();

        // NoFrostbiteRisk: 只用 m_SuppressFrostbite 标志,不清列表(清列表会破坏游戏状态导致关不掉)
        if (CheatState.NoFrostbiteRisk)
        {
            _frostbiteWasOn = true;
            try
            {
                if (_cFrostbite != null) _cFrostbite.m_SuppressFrostbite = true;
            }
            catch { }
        }
        else if (_frostbiteWasOn)
        {
            _frostbiteWasOn = false;
            try
            {
                if (_cFrostbite != null) _cFrostbite.m_SuppressFrostbite = false;
            }
            catch { }
        }

        if (!CheatState.NoFatigue && !CheatState.NoHunger
            && !CheatState.NoThirst && !CheatState.AlwaysWarm
            && !CheatState.GodMode && !CheatState.FatigueBuff) return;

        try
        {
            if (CheatState.NoFatigue || CheatState.GodMode)
            {
                if (_cFatigue != null) { try { _cFatigue.m_CurrentFatigue = 10f; } catch { } }
            }
            else if (CheatState.FatigueBuff)
            {
                // 保持原生 buff 的剩余时间不归零,防止游戏倒计时关掉 buff
                try
                {
                    if (_cPlayerManager != null) _cPlayerManager.m_FatigueBuffHoursRemaining = 100f;
                }
                catch { }
            }
            if (CheatState.NoHunger || CheatState.GodMode)
            {
                if (_cHunger != null) { try { _cHunger.m_CurrentReserveCalories = 2450f; } catch { } }
            }
            if (CheatState.NoThirst || CheatState.GodMode)
            {
                if (_cThirst != null) { try { _cThirst.m_CurrentThirst = 0f; } catch { } }
            }
            if (CheatState.AlwaysWarm || CheatState.GodMode)
            {
                if (_cFreezing != null) { try { _cFreezing.m_CurrentFreezing = 0f; } catch { } }
            }
            if (CheatState.GodMode)
            {
                if (_cCondition != null) { try { _cCondition.m_CurrentHP = _cCondition.m_MaxHP; } catch { } }
            }
        }
        catch { }
    }

    // 面板已改写的拆解时长在关闭快速操作后还原。
    public static void TickQuickActions()
    {
        if (CheatState.QuickBreakDown || CheatState.QuickAction) return;
        var snaps = Patch_BreakDown_UpdateDuration.Snapshots;
        if (snaps.Count == 0 && Patch_BreakDown_UpdateDuration.PanelSecs < 0f) return;

        // 每件被改过的物品直接写回原耗时,不用等玩家再打开它;已经拆掉(销毁)的直接丢掉
        foreach (var kv in snaps)
        {
            var bd = kv.Value.bd;
            if (bd == null) continue;
            try
            {
                bd.m_TimeCostHours = kv.Value.timeCost;
#if !STORY_EDITION
                bd.m_EditModeDestroyTimeCostHours = kv.Value.destroyCost;   // 2.24 没有这个字段
#endif
            }
            catch { }
        }
        snaps.Clear();

        // 面板读条秒数:面板开着就当场写回,关着就留给下次打开时 UpdateDurationLabel 的 Prefix 写
        if (Patch_BreakDown_UpdateDuration.PanelSecs < 0f) return;
        try
        {
            var panels = UnityEngine.Object.FindObjectsOfType<Panel_BreakDown>();
            if (panels == null) return;
            foreach (var p in panels)
            {
                try
                {
                    if (p.m_IsBreakingDown) continue;
                    p.m_SecondsToBreakDown = Patch_BreakDown_UpdateDuration.PanelSecs;
                    Patch_BreakDown_UpdateDuration.PanelSecs = -1f;
                }
                catch { }
            }
        }
        catch { }
    }

    // ——— 衣物不潮湿 ——— v2.7.15 改进:直接 wrapper 字段访问 + tick 频率跟 90 帧
    public static void TickClothingWetness()
    {
        if (!CheatState.NoWetClothes) return;
        try
        {
            var clothes = UnityEngine.Object.FindObjectsOfType<ClothingItem>();
            if (clothes == null) return;
            foreach (var c in clothes)
            {
                if (c == null) continue;
                try { c.m_PercentWet = 0f; } catch { }
            }
        }
        catch { }
    }

    // TryLockFieldOnAll 已移除 —— 仅 TickFires 用,TickFires 本身已删

    // v2.8.2 NoFallDamage tick — 反应式:既然 IL2CPP prefix return false 不可靠,
    // 每几帧检查+清除坠落产生的扭伤/衣物破损
    // v6.9.6 衣物 HP 快照 —— 按 gear 指针 key(不能用列表位置 index:m_Items 会增删/重排,
    //   旧版用 _clothingHpSnapshot[i] 导致把 A 衣物的高 HP 误还原到换位后的 B 小件衣物 → 超过其 MaxHP → 显示 >100%)
    private static readonly System.Collections.Generic.Dictionary<System.IntPtr, float> _clothingHpSnapshot
        = new System.Collections.Generic.Dictionary<System.IntPtr, float>();
    private static int _clothingSnapshotFrame;

    public static void TickNoFallDamage()
    {
        if (!CheatState.NoFallDamage) return;
        try
        {
            // 1. 手腕扭伤的强制关闭标记改由 ExtraOneShot.TickSprainRisk 统一管(会写进存档,关开关要放回)。
            //   原先这里自己设、自己复位,但本函数只在开关开着时才被调用,复位那支永远走不到。

            // 2. 检测并清除已有的坠落扭伤
            try
            {
                var ankle = GameManager.GetSprainedAnkleComponent();
                if (ankle != null && ankle.HasSprainedAnkle())
                {
                    ankle.SprainedAnkleEnd(0, (AfflictionOptions)0);
                    ankle.SprainedAnkleEnd(1, (AfflictionOptions)0);
                }
            }
            catch { }
            try
            {
                var wrist = GameManager.GetSprainedWristComponent();
                if (wrist != null && wrist.HasSprainedWrist())
                {
                    wrist.SprainedWristEnd(0, (AfflictionOptions)0);
                    wrist.SprainedWristEnd(1, (AfflictionOptions)0);
                }
            }
            catch { }

            // 3. 衣物 HP 快照/恢复 — 检测突然降低并还原(用背包列表,轻量)
            try
            {
                var inv = GameManager.m_Inventory;
                var items = inv?.m_Items;
                if (items != null)
                {
                    int count = items.Count;
                    int frame = UnityEngine.Time.frameCount;
                    bool withinWindow = (frame - _clothingSnapshotFrame) <= 30;

                    // 一遍扫:窗口内还原突降 HP(按指针取上次快照),同时刷新本帧快照
                    for (int i = 0; i < count; i++)
                    {
                        try
                        {
                            var obj = items[i];
                            if (obj == null) continue;
                            var gi = obj.m_GearItem;
                            if (gi == null || gi.m_ClothingItem == null) continue;

                            System.IntPtr key = gi.Pointer;
                            float cur = gi.m_CurrentHP;

                            if (withinWindow && _clothingHpSnapshot.TryGetValue(key, out float prev)
                                && prev > 0f && cur < prev - 1f)
                            {
                                // 还原到坠落前 HP,但绝不超过该衣物自身 MaxHP(防 >100%)
                                float maxHp = 100f;
#if STORY_EDITION
                                try { maxHp = gi.m_MaxHP; } catch { }   // 2.24 无 GearItemData
#else
                                try { var d = gi.GearItemData; if (d != null) maxHp = d.MaxHP; } catch { }
#endif
                                float restore = (prev > maxHp) ? maxHp : prev;
                                gi.m_CurrentHP = restore;
                                cur = restore;
                            }

                            _clothingHpSnapshot[key] = cur;
                        }
                        catch { }
                    }
                    _clothingSnapshotFrame = frame;

                    // 防字典无界增长:背包件数远小于快照数(物品被卖/丢/转移)时整体重建
                    if (_clothingHpSnapshot.Count > count + 32)
                        _clothingHpSnapshot.Clear();
                }
            }
            catch { }
        }
        catch { }
    }

    // v6.9.1 AfflictionGuard reactive tick — 和 NoFallDamage 同理:
    // IL2CPP 下 Prefix return false 不可靠,Postfix 也可能在特殊时序下漏网
    // 每 60 帧(~1s)检查一次:当前 toggle 说不应有的 affliction 如果存在就清掉
    // 防止游戏内部状态因"半启动"的 affliction 而损坏(导致后续所有 affliction auto-resolve 的连锁 bug)
    private static bool _lacerLogged;

    public static void TickAfflictionGuard()
    {
        bool guardBlood = CheatState.GodMode || CheatState.ImmuneAnimalDamage;
        bool guardGeneral = CheatState.GodMode;
        bool guardSuffocate = CheatState.GodMode || CheatState.NoSuffocating;
        if (!guardBlood && !guardGeneral && !guardSuffocate) return;

        // v9.6 新伤病兜底:都先判断有没有再清,避免每秒空调 End 触发第三方 mod 的治愈后并发症
        if (guardSuffocate)
        {
            try { var c = GameManager.GetSuffocatingComponent(); if (c != null && c.IsSuffocating()) c.ForceStopSuffocating(true); } catch { }
        }
#if !STORY_EDITION
        if (guardBlood)
        {
            try
            {
                var c = GameManager.GetSevereLacerations();
                if (c != null && (c.HasAffliction() || c.HaveAnyActiveWounds()))
                {
                    c.Cure((AfflictionOptions)0);
                    // Cure 清不掉时每秒都会进来,日志只打一次
                    if (!_lacerLogged) { _lacerLogged = true; ModMain.Log?.Msg("[AfflictionGuard] Tick cleared SevereLacerations"); }
                }
                else _lacerLogged = false;
            }
            catch { }
        }
#endif
        if (guardGeneral)
        {
            try { var c = GameManager.GetBurnsComponent(); if (c != null && c.HasBurns()) c.BurnsEnd(true); } catch { }
#if STORY_EDITION
            try { var c = GameManager.GetBurnsElectricComponent(); if (c != null && c.HasBurnsElectric()) c.BurnsElectricEnd(); } catch { }
#else
            try { var c = GameManager.GetBurnsElectricComponent(); if (c != null && c.HasBurnsElectric()) c.BurnsElectricEnd(true); } catch { }
            try { var c = GameManager.GetChemicalPoisoningComponent(); if (c != null && (c.HasAffliction() || c.HasRisk())) c.CureAll(); } catch { }
            try { var c = GameManager.GetInsomniaComponent(); if (c != null && (c.HasInsomniaAffliction() || c.HasInsomniaRisk())) c.RemoveInsomniaAll(); } catch { }
#endif
            try { var c = GameManager.GetBrokenRibComponent(); if (c != null && c.HasBrokenRib()) for (int i = 0; i < 6; i++) try { c.BrokenRibEnd(i, true); } catch { } } catch { }
            try { var c = GameManager.GetFrostbiteComponent(); if (c != null && c.HasFrostbite()) c.FrostbiteEnd(); } catch { }
            try { var c = GameManager.GetCabinFeverComponent(); if (c != null && c.HasCabinFever()) c.CabinFeverEnd(); } catch { }
            try { var c = GameManager.GetIntestinalParasitesComponent(); if (c != null && c.HasIntestinalParasites()) c.IntestinalParasitesEnd(true); } catch { }
            try { var c = GameManager.GetInfectionRiskComponent(); if (c != null && c.HasInfectionRisk()) c.Cure(); } catch { }
            try { var c = GameManager.GetToxicFogComponent(); if (c != null && c.HasAffliction()) c.StopAffliction(); } catch { }
            try { var c = GameManager.GetAnxietyComponent(); if (c != null && c.HasAffliction()) c.StopAffliction(true); } catch { }
            try { var c = GameManager.GetFearComponent(); if (c != null && c.HasAffliction()) c.StopAffliction(true); } catch { }
        }

        try
        {
            if (guardBlood)
            {
                var bl = GameManager.GetBloodLossComponent();
                if (bl != null && bl.HasBloodLoss())
                {
                    for (int i = 0; i < 6; i++)
                        try { bl.BloodLossEnd(i, (AfflictionOptions)0); } catch { }
                    ModMain.Log?.Msg("[AfflictionGuard] Tick cleared lingering BloodLoss");
                }
            }
            if (guardGeneral)
            {
                try
                {
                    var hypo = GameManager.GetHypothermiaComponent();
                    if (hypo != null && hypo.HasHypothermia())
                    {
                        hypo.HypothermiaEnd();
                        ModMain.Log?.Msg("[AfflictionGuard] Tick cleared lingering Hypothermia");
                    }
                }
                catch { }

                try
                {
                    var inf = GameManager.GetInfectionComponent();
                    if (inf != null && inf.HasInfection())
                    {
                        for (int i = 0; i < 6; i++)
                            try { inf.InfectionEnd(i); } catch { }
                        ModMain.Log?.Msg("[AfflictionGuard] Tick cleared lingering Infection");
                    }
                }
                catch { }

                try
                {
                    var fp = GameManager.GetFoodPoisoningComponent();
                    if (fp != null && fp.HasFoodPoisoning())
                    {
                        fp.FoodPoisoningEnd(true);
                        ModMain.Log?.Msg("[AfflictionGuard] Tick cleared lingering FoodPoisoning");
                    }
                }
                catch { }

                try
                {
                    var dy = GameManager.GetDysenteryComponent();
                    if (dy != null && dy.HasDysentery())
                    {
                        dy.DysenteryEnd(true);
                        ModMain.Log?.Msg("[AfflictionGuard] Tick cleared lingering Dysentery");
                    }
                }
                catch { }
            }
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════════
//   v2.7.45 CT 复刻 —— 从 CT 脚本直接映射的 Harmony patches
// ═══════════════════════════════════════════════════════════════════

// —— 秒烤肉 v2.7.51 —— 仿 CT:只推 m_CookingElapsedHours,不碰 percent/state
//   CT 做法:mov [rcx+m_CookingElapsedHours],(float)10; jmp original;
//   之前 v2.7.49/50 直接写 state=Ready,拾取时游戏内部想换状态被 Postfix 抢回 → 抽搐卡死
//   新法:Prefix 拿 cookTimeMinutes 参数,把 elapsed 推到刚好过熟透阈值,让原方法自然转 Ready
//   仅在 Cooking 状态下干预;Ready/Ruined 状态完全不动,pickup / eat 流程正常
// v2.7.75 DynamicPatch
internal static class Patch_CookingPot_Update
{
    private static bool _logged;
    internal static void Prefix(CookingPotItem __instance, float cookTimeMinutes, float readyTimeMinutes)
    {
        if (!CheatState.QuickCook && !CheatState.NoBurn) return;
        try
        {
            if (cookTimeMinutes <= 0f) return;
            var state = __instance.m_CookingState;
            if (state == CookingPotItem.CookingState.Ruined) return;

            float target = cookTimeMinutes / 60f * 1.01f;
            if (state == CookingPotItem.CookingState.Cooking)
            {
                // 只有 QuickCook 才推(防烤焦单开不秒熟,需要正常等熟)
                // 原版放上去就是 Cooking 状态,火没点只是不涨进度,不查火就会冷灶秒熟
                if (CheatState.QuickCook && __instance.AttachedFireIsBurning())
                {
                    if (!_logged)
                    {
                        _logged = true;
                        ModMain.Log.Msg($"[QuickCook] elapsed-push cookTimeMin={cookTimeMinutes} target={target:F3}h");
                    }
                    __instance.m_CookingElapsedHours = target;
                }
            }
            else if (state == CookingPotItem.CookingState.Ready)
            {
                // 两个开关都需要 Ready clamp,防漂到 Ruined
                if (__instance.m_CookingElapsedHours > target)
                    __instance.m_CookingElapsedHours = target;
            }
        }
        catch (System.Exception e) { ModMain.Log.Error($"[QuickCook/NoBurn] {e.Message}"); }
    }
}

// —— 秒采集地上作物 v2.7.54 —— 回退 PerformHold 方案(采不了 bug)
//   v2.7.52 PerformHold Prefix __result=true 导致按 E 无响应 —— 猜 true 在 TLD 语义是"继续 hold"
//   回退到 v2.7.49 方案:字段压爆 + UpdateHoldInteraction deltaTime ×10000
//   代价是看得见 ~0.1s 读条,但能采集
// v2.7.80 snapshot+restore 闭环 —— 修"toggle off 后秒采效果永久残留"
//   Init/BeginHold 共用 HarvestableSnaps.Snapshots;toggle off 时 BeginHold 再触发一次 restore 原值
//   场景切换 OnSceneWasInitialized 清 dict(实例随场景销毁,字段污染自然消失)
internal static class HarvestableSnaps
{
    public static readonly System.Collections.Generic.Dictionary<System.IntPtr, (float holdTime, float timer)> Snapshots = new();
}

#if !STORY_EDITION
// 2.24 无 Il2CppTLD.Interactions(交互系统在 2.24 之后整体重构:TimedHoldInteraction /
// HarvestableInteraction 都不存在)。以下三个类连同 DynamicPatch 里对应的 Spec 一起排除。
// 上面的 HarvestableSnaps 只用 IntPtr/float,保留(ModMain 的清 dict 调用不受影响)。
internal static class Patch_HarvestableInteraction_Init
{
    internal static void Postfix(Il2CppTLD.Interactions.TimedHoldInteraction __instance)
    {
        try
        {
            if (!CheatState.QuickSearch) return;
            if (__instance is not HarvestableInteraction hi) return;
            var ptr = hi.Pointer;
            if (!HarvestableSnaps.Snapshots.ContainsKey(ptr))
                HarvestableSnaps.Snapshots[ptr] = (hi.m_DefaultHoldTime, hi.m_Timer);
            // v7.7 同一实例的 hold-time 还有 UpdateHoldInteraction 那条还原路径,
            //   这里是最早的写入点,先让它把真值存下来(见 CaptureVanilla 的注释)。
            Patch_TimedHold_UpdateHoldInteraction_QuickSearch.CaptureVanilla(hi);
            hi.m_DefaultHoldTime = 0.001f;
        }
        catch { }
    }
}

internal static class Patch_HarvestableInteraction_BeginHold
{
    internal static void Postfix(HarvestableInteraction __instance)
    {
        try
        {
            var ptr = __instance.Pointer;
            if (CheatState.QuickSearch)
            {
                if (!HarvestableSnaps.Snapshots.ContainsKey(ptr))
                    HarvestableSnaps.Snapshots[ptr] = (__instance.m_DefaultHoldTime, __instance.m_Timer);
                __instance.m_DefaultHoldTime = 0.001f;
                __instance.m_Timer = 99999f;
            }
            else if (HarvestableSnaps.Snapshots.TryGetValue(ptr, out var s))
            {
                __instance.m_DefaultHoldTime = s.holdTime;
                __instance.m_Timer = s.timer;
                HarvestableSnaps.Snapshots.Remove(ptr);
            }
        }
        catch { }
    }
}

internal static class Patch_TimedHold_UpdateHoldInteraction_QuickSearch
{
    // v7.7 修「关掉秒搜刮后已交互过的容器还是秒开」:原先只写 0.001 不留快照,
    //   spec 卸载后那些 TimedHoldInteraction 实例的字段永远停在 0.001,
    //   只有换场景重建对象才恢复。改成和同文件 HarvestableSnaps / Patch_Harvest_Refresh_Quick
    //   一致的 IntPtr 快照 + 关掉时下一次 Update 归还原值。
    internal static readonly System.Collections.Generic.Dictionary<System.IntPtr, (float def, float hold)> Snapshots
        = new System.Collections.Generic.Dictionary<System.IntPtr, (float, float)>();

    // vanilla 交互没有短于 0.05 秒的 hold time,低于这个值只可能是别的补丁写进去的加速哨兵
    //   (Patch_Speedy_HoldInteraction 写 0.01,Patch_HarvestableInteraction_Init 写 0.001)。
    internal const float AccelSentinel = 0.05f;

    // v7.7 所有会改写 hold-time 的补丁共用的取真值入口。必须在改脏之前调。
    //   背景:同一个 TimedHoldInteraction 实例上有三个写入者,执行顺序是
    //   InitializeInteraction → BeginHold → UpdateHoldInteraction(本类),
    //   所以本类自己去读字段时读到的可能已经是别人写的 0.001/0.01,
    //   直接当 vanilla 存下来 → 关掉开关"还原"写回去的还是加速值,等于没修。
    internal static void CaptureVanilla(Il2CppTLD.Interactions.TimedHoldInteraction inst)
    {
        try
        {
            var ptr = inst.Pointer;
            if (Snapshots.ContainsKey(ptr)) return;
            float def = inst.m_DefaultHoldTime, hold = inst.HoldTime;
            // 采集类交互的真值 Init 已经存进 HarvestableSnaps,优先采信那份
            if (HarvestableSnaps.Snapshots.TryGetValue(ptr, out var hs) && hs.holdTime > AccelSentinel)
                def = hs.holdTime;
            // 仍然是哨兵值 → 拒绝登记(退化成 v7.6 的"不还原",不会更差,
            //   但绝不把 0.001 冒充 vanilla 还回去)
            if (def > AccelSentinel && hold > AccelSentinel)
                Snapshots[ptr] = (def, hold);
        }
        catch { }
    }

    internal static void Prefix(Il2CppTLD.Interactions.TimedHoldInteraction __instance, ref float deltaTime)
    {
        try
        {
            var name = __instance.GetType().Name;
            // v5.0: 按 toggle 拆分白名单 — 秒搜刮(QuickSearch)= 容器/储物;秒采集(QuickAction)= 采集/破坏/拾取.
            //   修 bug:之前 ContainerInteraction 被合并进单一白名单,导致只开秒采集时容器也被加速.
            // v3.0.6: exclude Locked* to avoid breaking cave/interior entry hold
            bool searchType = name == "ContainerInteraction"
                           || name == "RockCacheInteraction"
                           || name == "WildlifeItemInteraction";
            bool actionType = name == "HarvestableInteraction"
                           || name == "BodyHarvestInteraction"
                           || name == "BrokenDecorationInteraction"
                           || name.Contains("Harvest")
                           || name.Contains("PickUp");
            bool apply = (CheatState.QuickSearch && searchType)
                      || (CheatState.QuickAction && actionType);

            var ptr = __instance.Pointer;
            if (!apply)
            {
                // 关掉了(或这个类型不在白名单):把之前改过的实例还原,只还一次
                if (Snapshots.TryGetValue(ptr, out var old))
                {
                    __instance.m_DefaultHoldTime = old.def;
                    __instance.HoldTime = old.hold;
                    Snapshots.Remove(ptr);
                }
                return;
            }

            CaptureVanilla(__instance);

            __instance.m_DefaultHoldTime = 0.001f;
            __instance.HoldTime = 0.001f;
            deltaTime *= 10000f;
        }
        catch { }
    }
}
#endif

// —— 秒割肉 CT:Panel_BodyHarvest.Refresh 设 HarvestTimeSeconds=TotalHarvestTimeSeconds,Minutes=0 ——
// v2.7.80 snapshot+restore 闭环 —— toggle off 后下次打开割肉面板 Refresh 时恢复原值
internal static class Patch_Harvest_Refresh_Quick
{
    internal static readonly System.Collections.Generic.Dictionary<System.IntPtr, (float sec, float min)> Snapshots
        = new System.Collections.Generic.Dictionary<System.IntPtr, (float, float)>();

    internal static void Prefix(Panel_BodyHarvest __instance)
    {
        try
        {
            var ptr = __instance.Pointer;
#if STORY_EDITION
            // 2.24 只有 m_HarvestTimeSeconds(进度条实时秒),没有 m_HarvestTimeMinutes
            // (游戏内分钟由 StartHarvest(minutes,...) 的实参决定)也没有 m_TotalHarvestTimeSeconds。
            // 这里把实时秒归零 = 进度条秒满;游戏内时间消耗仍走 QuickAction 那条
            // Patch_Harvest_Start → QuickHarvestRunner → HarvestSuccessful 的路。
            // ponytail: 天花板是 2.24 下"秒割肉"只免实时等待不免游戏内小时;
            // 要连游戏内时间一起免就得再 patch StartHarvest 的 minutes 实参。
            if (CheatState.QuickHarvest)
            {
                if (!Snapshots.ContainsKey(ptr))
                    Snapshots[ptr] = (__instance.m_HarvestTimeSeconds, 0f);
                __instance.m_HarvestTimeSeconds = 0f;
            }
            else if (Snapshots.TryGetValue(ptr, out var s))
            {
                __instance.m_HarvestTimeSeconds = s.sec;
                Snapshots.Remove(ptr);
            }
#else
            if (CheatState.QuickHarvest)
            {
                if (!Snapshots.ContainsKey(ptr))
                    Snapshots[ptr] = (__instance.m_HarvestTimeSeconds, __instance.m_HarvestTimeMinutes);
                __instance.m_HarvestTimeSeconds = __instance.m_TotalHarvestTimeSeconds;
                __instance.m_HarvestTimeMinutes = 0f;
            }
            else if (Snapshots.TryGetValue(ptr, out var s))
            {
                __instance.m_HarvestTimeSeconds = s.sec;
                __instance.m_HarvestTimeMinutes = s.min;
                Snapshots.Remove(ptr);
            }
#endif
        }
        catch { }
    }
}

// 秒割肉 CT 还加:BodyHarvest.MaybeFreeze 设 m_PercentFrozen=0(冻肉也能割)
// v2.7.75 DynamicPatch
internal static class Patch_BodyHarvest_MaybeFreeze
{
    internal static void Prefix(BodyHarvest __instance)
    {
        if (!CheatState.QuickHarvest) return;
        try { __instance.m_PercentFrozen = 0f; } catch { }
    }
}

// —— 鹿出肉量倍率:BodyHarvest.InitializeResourcesAndConditions Postfix ——
// 原版鹿净肉 6-9kg,真实骡鹿/白尾鹿约 18-25kg。给新鲜鹿尸体初始肉量乘 [Min,Max] 区间内随机倍率。
// 只在新鲜击杀(本方法 roll 初始肉量)时触发;存档恢复走 Deserialize 不进这里 → 无累乘、不坏存档。
// 排除 Quarter:尸块由原尸体切分而来已带倍率,再乘会累乘。
internal static class Patch_DeerMeatYield
{
    internal static void Postfix(BodyHarvest __instance)
    {
        try
        {
            if (!MeatState.Enabled()) return;
            var n = ((UnityEngine.Object)__instance).name;
            if (n.Contains("Quarter")) return;
            if (!(n.Contains("Deer") || n.Contains("Doe") || n.Contains("Stag"))) return;
#if STORY_EDITION
            float kg = __instance.m_MeatAvailableKG;   // 2.24 是裸 float,不是 ItemWeight
#else
            float kg = ((ItemWeight)__instance.m_MeatAvailableKG).ToQuantity(1f);
#endif
            if (kg <= 0f) return;
            float lo = Mathf.Min(MeatState.DeerMin, MeatState.DeerMax);
            float hi = Mathf.Max(MeatState.DeerMin, MeatState.DeerMax);
            float mult = UnityEngine.Random.Range(lo, hi);
#if STORY_EDITION
            __instance.m_MeatAvailableKG = kg * mult;
#else
            __instance.m_MeatAvailableKG = ItemWeight.FromKilograms(kg * mult);
#endif
        }
        catch { }
    }
}

// —— 秒打碎/回收 CT:Panel_BreakDown.UpdateDurationLabel 设 SecondsToBreakDown=0.2,两种拆解的时间花费=0 ——
//   v2.7.61 加 snapshot+restore —— toggle off 时恢复 BreakDown.m_TimeCostHours,否则"UI 还是 0 min"
//           key 用 m_BreakDown.Pointer(每个物品的 BreakDown 组件独立)
// v2.7.75 DynamicPatch(有 snapshot,需 SyncWithCleanup)
// v2.7.82 修:同时存 m_SecondsToBreakDown,toggle OFF 一并恢复(之前只恢复 TimeCostHours 导致读条仍加速)
internal static class Patch_BreakDown_UpdateDuration
{
    internal static readonly System.Collections.Generic.Dictionary<System.IntPtr, (BreakDown bd, float timeCost, float destroyCost)> Snapshots
        = new System.Collections.Generic.Dictionary<System.IntPtr, (BreakDown bd, float timeCost, float destroyCost)>();
    // 读条秒数是面板上的字段,所有物品共用,单独存一份。原先跟着物品快照走:拆掉的那件物品连同
    //   原值一起销毁,关开关后面板读条永远停在 0.2 秒,快照也清不空,补丁一直卸不掉。
    internal static float PanelSecs = -1f;

    internal static void Prefix(Panel_BreakDown __instance)
    {
        try
        {
            var bd = __instance.m_BreakDown;
            if (bd == null) return;
            var ptr = bd.Pointer;
            if (CheatState.QuickBreakDown || CheatState.QuickAction)
            {
                // 快照秒数取 SpeedyGuard 记下的 vanilla 基准,没记过才用字段当前值。
                //   照当前值快照会有这个顺序漏洞:拆解倍率 4x(字段已被写成 base/4)→ 开秒拆解
                //   (快照把 base/4 当原值)→ 倍率拖回 1(SpeedyGuard 写回 base 并消掉还原登记)
                //   → 关秒拆解(把 base/4 还回去)。此时两边的还原都用完了,字段永久停在 4 倍速。
                if (PanelSecs < 0f)
                    PanelSecs = SpeedyGuard.VanillaOr("Breakdown", __instance.m_SecondsToBreakDown);
                if (!Snapshots.ContainsKey(ptr))
                {
#if STORY_EDITION
                    float destroyCost = 0f;   // 2.24 BreakDown 没有 m_EditModeDestroyTimeCostHours
#else
                    float destroyCost = bd.m_EditModeDestroyTimeCostHours;
#endif
                    Snapshots[ptr] = (bd, bd.m_TimeCostHours, destroyCost);
                }
                __instance.m_SecondsToBreakDown = 0.2f;
                bd.m_TimeCostHours = 0f;
#if !STORY_EDITION
                bd.m_EditModeDestroyTimeCostHours = 0f;
#endif
            }
            else
            {
                if (PanelSecs >= 0f) { __instance.m_SecondsToBreakDown = PanelSecs; PanelSecs = -1f; }
                if (Snapshots.TryGetValue(ptr, out var snap))
                {
                    bd.m_TimeCostHours = snap.timeCost;
#if !STORY_EDITION
                    bd.m_EditModeDestroyTimeCostHours = snap.destroyCost;
#endif
                    Snapshots.Remove(ptr);
                }
            }
        }
        catch { }
    }
}

// v2.7.61 删除 Patch_BreakDown_Update_ForceFinish —— 每帧强推 m_TimeSpentBreakingDown 但没 Fade.Arm,
//   拆完留黑屏。改由 Patch_BreakDown_OnBreakDown 响应 QuickBreakDown 即可(原路径已带 Fade.Arm)

// —— 解锁保险箱 CT:SafeCracking.Update 直接 jmp UnlockSafe ——
// v2.7.75 DynamicPatch
internal static class Patch_SafeCracking_Update
{
    internal static void Postfix(SafeCracking __instance)
    {
        if (!CheatState.UnlockSafes) return;
        try { __instance.UnlockSafe(); } catch { }
    }
}

#if !STORY_EDITION
// —— 解锁上锁门/柜子 CT:LockedInteraction.IsLocked 强 return false ——
// v2.7.75 DynamicPatch
// 2.24 无 LockedInteraction(交互系统重构的一部分)。上面的 Patch_Lock_IsLocked
// 打的是 Lock.IsLocked,Lock 在 2.24 存在,保留。
internal static class Patch_LockedInteraction_IsLocked_Unlock
{
    internal static void Postfix(LockedInteraction __instance, ref bool __result)
    {
        if (CheatState.UnlockSafes || CheatState.IgnoreLock)
        {
            __result = false;
            // Actually unlock the underlying Lock component so the lock icon disappears
            try
            {
                var lk = __instance.Lock;
                if (lk != null) lk.m_LockState = LockState.Unlocked;
            }
            catch { }
        }
    }
}
#endif

// —— 油灯 Update Postfix: 光照范围 + 持续 HP 损耗 + 静音 ——
// v3.0.4 整合 KeroseneLampTweaks v2.4.1 三个 Update 行为:lamp_range/overTimeDecay/muteLamps
internal static class Patch_KeroseneLamp_LightRange
{
    // v3.0.4r4 性能优化: 缓存 lamp instance ID → (Light[], 各自原始 range[])
    // 旧版每帧 GetComponentsInChildren<Light>(true) 扫整个 transform 树 + 分配数组,大开销
    // 新版第一次扫一次 light 子组件,记录原始 range,之后帧直接索引数组
    private struct LampCache
    {
        public UnityEngine.Light[] Lights;
        public float[] BaseRanges;
    }
    private static readonly System.Collections.Generic.Dictionary<int, LampCache> s_Cache = new();

    // 倍率拖回 1 后,patch 要等所有改过的灯都还原才卸载。已销毁的灯(换场景)直接丢掉。
    internal static bool RestoreDone()
    {
        if (s_Cache.Count == 0) return true;
        var dead = new System.Collections.Generic.List<int>();
        foreach (var kv in s_Cache)
        {
            bool alive = false;
            var arr = kv.Value.Lights;
            for (int i = 0; i < arr.Length && !alive; i++) alive = arr[i] != null;
            if (!alive) dead.Add(kv.Key);
        }
        for (int i = 0; i < dead.Count; i++) s_Cache.Remove(dead[i]);
        return s_Cache.Count == 0;
    }

    internal static void Postfix(KeroseneLampItem __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;

            // 1. 持续 HP 损耗(只在点亮时)
            if (s.LampOverTimeDecay > 0.001f && __instance.IsOn())
            {
                var gi = __instance.m_GearItem;
                if (gi != null)
                {
                    var tod = GameManager.GetTimeOfDayComponent();
                    float scale = (tod != null && tod.m_DayLengthScale > 0.001f) ? tod.m_DayLengthScale : 1f;
                    gi.m_CurrentHP = Mathf.Max(0f, gi.m_CurrentHP - s.LampOverTimeDecay * (Time.deltaTime / 300f) * (1f / scale));
                }
            }

            // 2. 静音(放置且非手持时)
            if (s.LampMute || CheatState.LampMute)
            {
                var gi2 = __instance.m_GearItem;
                if (gi2 != null && !gi2.m_InPlayerInventory)
                {
                    try { __instance.StopLoopingAudio(); } catch { }
                }
            }

            // 3. 光照范围倍率(性能关键路径) — 缓存 lamp 子 Light 数组
            float mult = s.LampRangeMultiplier;
            if (Mathf.Abs(mult - 1f) >= 0.01f)
            {
                int lampId = ((UnityEngine.Object)__instance).GetInstanceID();
                LampCache cache;
                if (!s_Cache.TryGetValue(lampId, out cache))
                {
                    var lts = __instance.GetComponentsInChildren<UnityEngine.Light>(true);
                    if (lts == null) return;
                    int n = lts.Length;
                    cache.Lights = new UnityEngine.Light[n];
                    cache.BaseRanges = new float[n];
                    for (int i = 0; i < n; i++)
                    {
                        var lt = lts[i];
                        cache.Lights[i] = lt;
                        cache.BaseRanges[i] = lt != null ? lt.range : 0f;
                    }
                    s_Cache[lampId] = cache;
                }
                // 用缓存数组(无 GC 分配,无 transform 树扫描)
                var lightsArr = cache.Lights;
                var baseArr = cache.BaseRanges;
                int len = lightsArr.Length;
                for (int i = 0; i < len; i++)
                {
                    var lt = lightsArr[i];
                    if (lt == null) continue;
                    float target = baseArr[i] * mult;
                    if (Mathf.Abs(lt.range - target) > 0.01f) lt.range = target;
                }
            }
            else if (s_Cache.Count > 0)
            {
                // 倍率拖回 1 时把改过的范围还原,否则灯一直停在上次的倍率
                int lampId = ((UnityEngine.Object)__instance).GetInstanceID();
                if (s_Cache.TryGetValue(lampId, out var cache))
                {
                    for (int i = 0; i < cache.Lights.Length; i++)
                    {
                        var lt = cache.Lights[i];
                        if (lt != null) lt.range = cache.BaseRanges[i];
                    }
                    s_Cache.Remove(lampId);
                }
            }
        }
        catch { }
    }
}

// —— 油灯燃油消耗 v3.0.4 重写: KeroseneLampTweaks v2.4.1 完整版 ——
// 拆分手持/放置消耗倍率 + HP 阈值惩罚机制
// v3.0.4 替换原 LampBurnMultiplier 单一倍率
internal static class Patch_KeroseneLamp_ReduceFuel
{
    internal static bool Prefix(KeroseneLampItem __instance, ref float hoursBurned)
    {
        if (CheatState.LampFuelNoDrain) return false;
        var s = ModMain.Settings;
        if (s == null) return true;
        var gi = __instance != null ? __instance.m_GearItem : null;

        // 手持 vs 放置 倍率
        bool inInv = gi != null && gi.m_InPlayerInventory;
        float mult = inInv ? s.LampHeldBurnMult : s.LampPlacedBurnMult;

        // HP 阈值惩罚: HP 低于阈值时额外耗油
        float penalty = 1f;
        if (gi != null && s.LampConditionThreshold > 0 && gi.m_CurrentHP < s.LampConditionThreshold)
        {
            penalty += (1f - gi.m_CurrentHP / (float)s.LampConditionThreshold) * (s.LampMaxPenalty / 100f);
        }

        float effective = mult * penalty;
        if (effective < 0.001f) return false;  // 0 = 无限燃烧
        hoursBurned *= effective;
        return true;
    }
}

// —— v3.0.4 油灯开启时一次性 HP 损耗 (KeroseneLampTweaks turnOnDecay) ——
internal static class Patch_KeroseneLamp_OnIgnite
{
    internal static void Postfix(KeroseneLampItem __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || s.LampTurnOnDecay < 0.001f) return;
            var gi = __instance != null ? __instance.m_GearItem : null;
            if (gi != null) gi.m_CurrentHP -= s.LampTurnOnDecay;
        }
        catch { }
    }
}

// —— 保温杯永不失温 CT:InsulatedFlask.CalculateHeatLoss NOP 关键字节 ——
// v2.7.75 DynamicPatch
internal static class Patch_Flask_CalcHeatLoss
{
    internal static bool Prefix() => !CheatState.FlaskNoHeatLoss;
}

// —— 保温杯存放无限 CT:InsulatedFlask.UpdateVolume NOP ——
// v2.7.75 DynamicPatch
internal static class Patch_Flask_UpdateVolume
{
    internal static bool Prefix() => !CheatState.FlaskInfiniteVol;
}

// —— 保温瓶 UI 过滤: 让所有饮品显示(不限类型) ——
internal static class Patch_Flask_ForceTrue
{
    internal static void Postfix(ref bool __result) { __result = true; }
}

internal static class Patch_Flask_IsCompatibleDrink
{
    internal static void Postfix(ref bool __result, GearItem gearItem)
    {
        if (__result) return;
        if (gearItem == null) return;
        try
        {
            if (gearItem.m_FoodItem == null || !gearItem.m_FoodItem.m_IsDrink) return;
            var name = ((UnityEngine.Object)gearItem).name;
            if (name != null && (name.Contains("Cup") || name.Contains("Tea")))
                __result = true;
        }
        catch { }
    }
}

#if !STORY_EDITION
// —— 无后坐力 v6.1.0: 原生 code cave 注入 ——
// —— 保温瓶装任意饮品 v6.0.8: 原生 NOP patch ——
// IsItemCompatibleWithFlask: AOB NOP(跟 CT 一样)
// IsAllowed: 直接把函数开头改成 mov al,1; ret(始终返回 true)
// 2.24 无 Il2CppTLD.Gear.InsulatedFlask / InsulatedFlaskLiquidTypeConstraint(保温瓶是后加物品),
// 本类全部方法都靠反射取这两个类型的字段拿原生函数地址,整类排除;ModMain 的 Sync() 调用同步排除。
internal static class FlaskNativePatch
{
    private static byte[] _origBytes;
    private static IntPtr _patchAddr;
    private static byte[] _origBytesAllowed;
    private static IntPtr _patchAddrAllowed;
    private static byte[] _origBytesTryAdd;
    private static IntPtr _patchAddrTryAdd;
    private static bool _applied;

    public static void Sync()
    {
        if (CheatState.FlaskAnyItem && !_applied) Apply();
        else if (!CheatState.FlaskAnyItem && _applied) Remove();
    }

    // AOB: 前 6 字节是要 NOP 的,后续是验证签名
    // CT pattern: x x x x x x 488B??????????488B????83????????????75??
    private static readonly byte?[] Pattern = new byte?[]
    {
        null, null, null, null, null, null, // 6 bytes to NOP
        0x48, 0x8B, null, null, null, null, null, // mov reg,[rip+...]
        0x48, 0x8B, null, null,                   // mov reg,[reg+...]
        0x83, null, null, null, null, null, null,  // cmp ...
        0x75, null,                                // jne
    };

    public static unsafe void Apply()
    {
        try
        {
            // 获取 IL2CPP native method info pointer(跟 CT 的 TLD.Gear.InsulatedFlask.IsItemCompatibleWithFlask 一样）
            var field = typeof(Il2CppTLD.Gear.InsulatedFlask).GetField(
                "NativeMethodInfoPtr_IsItemCompatibleWithFlask_Public_Boolean_GearItem_0",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (field == null)
            {
                ModMain.Log?.Warning("[FlaskNOP] NativeMethodInfoPtr field not found");
                return;
            }
            IntPtr methodInfo = (IntPtr)field.GetValue(null);
            if (methodInfo == IntPtr.Zero) { ModMain.Log?.Warning("[FlaskNOP] methodInfo is zero"); return; }
            // Il2Cpp MethodInfo 第一个字段就是 native code pointer
            IntPtr methodPtr = *(IntPtr*)methodInfo;
            if (methodPtr == IntPtr.Zero) { ModMain.Log?.Warning("[FlaskNOP] native code ptr is zero"); return; }

            // scan within first 1500 bytes for the pattern
            _patchAddr = ScanForPattern(methodPtr, 1500);
            if (_patchAddr == IntPtr.Zero)
            {
                ModMain.Log?.Warning("[FlaskNOP] AOB pattern not found in IsItemCompatibleWithFlask");
                return;
            }

            // save original 6 bytes
            _origBytes = new byte[6];
            System.Runtime.InteropServices.Marshal.Copy(_patchAddr, _origBytes, 0, 6);

            // write 6x NOP (0x90)
            WriteNops(_patchAddr, 6);
            ModMain.Log?.Msg($"[FlaskNOP] IsItemCompatibleWithFlask: patched 6 bytes at 0x{_patchAddr:X}");

            // 同样处理 IsAllowed: 直接改函数开头为 mov al,1; ret
            var fieldAllowed = typeof(Il2CppTLD.Gear.InsulatedFlaskLiquidTypeConstraint).GetField(
                "NativeMethodInfoPtr_IsAllowed_Public_Boolean_GearItem_0",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (fieldAllowed != null)
            {
                IntPtr miAllowed = (IntPtr)fieldAllowed.GetValue(null);
                if (miAllowed != IntPtr.Zero)
                {
                    IntPtr ptrAllowed = *(IntPtr*)miAllowed;
                    if (ptrAllowed != IntPtr.Zero)
                    {
                        _origBytesAllowed = new byte[3];
                        System.Runtime.InteropServices.Marshal.Copy(ptrAllowed, _origBytesAllowed, 0, 3);
                        _patchAddrAllowed = ptrAllowed;
                        // mov al,1 (B0 01); ret (C3)
                        WriteBytes(ptrAllowed, new byte[] { 0xB0, 0x01, 0xC3 });
                        ModMain.Log?.Msg($"[FlaskNOP] IsAllowed: patched to ret true at 0x{ptrAllowed:X}");
                    }
                }
            }

            // v8.0.1 删掉原 IsMatchingType 那段:2.55 的 InsulatedFlask 没有这个方法
            //   (IsMatchingType 在 Il2CppTLD.Trader.ExchangeItem 上),NativeMethodInfoPtr 字段
            //   恒为 null,整段是永不执行的死代码。类型匹配已由 IsItemCompatibleWithFlask +
            //   IsAllowed 两处覆盖。

            // NOP TryAddItem 内部的兼容性检查跳转(offset 172: 0F 84 xx xx xx xx = je far)
            var fieldTryAdd = typeof(Il2CppTLD.Gear.InsulatedFlask).GetField(
                "NativeMethodInfoPtr_TryAddItem_Public_Boolean_GearItem_0",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (fieldTryAdd != null)
            {
                IntPtr miTryAdd = (IntPtr)fieldTryAdd.GetValue(null);
                if (miTryAdd != IntPtr.Zero)
                {
                    IntPtr ptrTryAdd = *(IntPtr*)miTryAdd;
                    if (ptrTryAdd != IntPtr.Zero)
                    {
                        // offset 172 from function start: the je that skips on compatibility failure
                        IntPtr jeAddr = ptrTryAdd + 172;
                        byte* p = (byte*)jeAddr;
                        // verify it's actually 0F 84 (je near)
                        if (p[0] == 0x0F && p[1] == 0x84)
                        {
                            _origBytesTryAdd = new byte[6];
                            System.Runtime.InteropServices.Marshal.Copy(jeAddr, _origBytesTryAdd, 0, 6);
                            _patchAddrTryAdd = jeAddr;
                            WriteNops(jeAddr, 6);
                            ModMain.Log?.Msg($"[FlaskNOP] TryAddItem: NOP'd je at offset 172 (0x{jeAddr:X})");
                        }
                        else
                        {
                            ModMain.Log?.Warning($"[FlaskNOP] TryAddItem offset 172: expected 0F 84, got {p[0]:X2} {p[1]:X2}");
                        }
                    }
                }
            }

            // Dump TryAddItem 头 200 字节到日志,方便找到类型检查的位置
            var fieldTry = typeof(Il2CppTLD.Gear.InsulatedFlask).GetField(
                "NativeMethodInfoPtr_TryAddItem_Public_Boolean_GearItem_0",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (fieldTry != null)
            {
                IntPtr miTry = (IntPtr)fieldTry.GetValue(null);
                if (miTry != IntPtr.Zero)
                {
                    IntPtr ptrTry = *(IntPtr*)miTry;
                    if (ptrTry != IntPtr.Zero)
                    {
                        var bytes = new byte[1024];
                        System.Runtime.InteropServices.Marshal.Copy(ptrTry, bytes, 0, 1024);
                        for (int chunk = 0; chunk < 4; chunk++)
                        {
                            var seg = new byte[256];
                            Array.Copy(bytes, chunk * 256, seg, 0, 256);
                            ModMain.Log?.Msg($"[FlaskNOP] TryAddItem+{chunk*256}: {BitConverter.ToString(seg).Replace("-"," ")}");
                        }
                    }
                }
            }

            _applied = true;
        }
        catch (Exception ex) { ModMain.Log?.Error($"[FlaskNOP] {ex}"); }
    }

    public static void Remove()
    {
        if (_patchAddr == IntPtr.Zero || _origBytes == null) return;
        try
        {
            WriteBytes(_patchAddr, _origBytes);
            if (_patchAddrAllowed != IntPtr.Zero && _origBytesAllowed != null)
                WriteBytes(_patchAddrAllowed, _origBytesAllowed);
            if (_patchAddrTryAdd != IntPtr.Zero && _origBytesTryAdd != null)
                WriteBytes(_patchAddrTryAdd, _origBytesTryAdd);
            _applied = false;
            ModMain.Log?.Msg("[FlaskNOP] restored original bytes");
            _patchAddr = IntPtr.Zero; _origBytes = null;
            _patchAddrAllowed = IntPtr.Zero; _origBytesAllowed = null;
            _patchAddrTryAdd = IntPtr.Zero; _origBytesTryAdd = null;
        }
        catch (Exception ex) { ModMain.Log?.Error($"[FlaskNOP.Remove] {ex}"); }
    }

    private static unsafe IntPtr ScanForPattern(IntPtr start, int length)
    {
        byte* p = (byte*)start;
        int patLen = Pattern.Length;
        for (int i = 0; i <= length - patLen; i++)
        {
            bool match = true;
            for (int j = 0; j < patLen; j++)
            {
                if (Pattern[j].HasValue && p[i + j] != Pattern[j].Value)
                { match = false; break; }
            }
            if (match) return (IntPtr)(p + i);
        }
        return IntPtr.Zero;
    }

    private static unsafe void WriteNops(IntPtr addr, int count)
    {
        uint oldProtect;
        VirtualProtect(addr, (UIntPtr)count, 0x40, out oldProtect); // PAGE_EXECUTE_READWRITE
        byte* p = (byte*)addr;
        for (int i = 0; i < count; i++) p[i] = 0x90;
        VirtualProtect(addr, (UIntPtr)count, oldProtect, out _);
    }

    private static unsafe void WriteBytes(IntPtr addr, byte[] bytes)
    {
        uint oldProtect;
        VirtualProtect(addr, (UIntPtr)bytes.Length, 0x40, out oldProtect);
        System.Runtime.InteropServices.Marshal.Copy(bytes, 0, addr, bytes.Length);
        VirtualProtect(addr, (UIntPtr)bytes.Length, oldProtect, out _);
    }

    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);
}
#endif

// —— 加工秒完成 CT:EvolveItem.Update 设 TimeToEvolveGameDays=0, TimeSpentEvolvingGameHours=1 ——
// v2.7.75 DynamicPatch: 去掉 [HarmonyPatch] attribute
// v6.8.5 修: 用户报开秒风干后虎鲸尸体直接腐烂
//   根因: vanilla EvolveItem 同时承载"风干→Cured/Dried"和"鲜→Spoiled/Decayed/Ravaged"两条转化链
//         秒风干无差别清零所有 evolve 计时,把鲜肉→腐烂的等待时间也压到 0
//   方案 v6.8.5 (旧): 黑名单只挡 "Spoiled" 字符串
// v6.8.7 修: v6.8.5 guard 仍漏了 BleakInletFalls (Bountiful_Foraging) mod 虎鲸 carcass
//   根因: BF mod evolve 目标是 GEAR_OrcaCarcassDecayed / GEAR_OrcaCarcassRavaged
//         (用户实测 catalog_Foraging.json 验证 — 不含 "Spoiled" 字符串)
//   方案 v6.8.7: 改成白名单 — 只对合法风干目标(Cured/Dried/Jerky/Smoked/Salted)秒
//         其它(Spoiled/Decayed/Ravaged/Rotten/未知)一律放行 vanilla 节奏
//         最差情况:第三方 mod 自定义风干目标命名不在白名单 → 不秒(退化但不回归)
internal static class Patch_EvolveItem_Update
{
    // v6.8.7: 白名单 — 命中其一即视为"合法风干目标",才秒
    private static readonly string[] CureTargetTokens = new[]
    {
        "Cured",       // GEAR_CuredMeat* / GEAR_CuredFish* / GEAR_Gut_Cured*
        "Dried",       // GEAR_*Dried* / GEAR_DriedApples / GEAR_*PeltDried 等
        "Jerky",       // GEAR_BeefJerky
        "Smoked",      // 预留(若 mod 加 Smoked* 风干物)
        "Salted",      // BF mod GEAR_SaltedMeat* / GEAR_SaltedFish*
    };

    // v6.8.7: 黑名单 — 命中其一直接 veto(覆盖白名单)
    //   eg GEAR_CuredFish_SpoiledA_Dif 同时含 "Cured" 和 "Spoiled" — 必须放行 vanilla 节奏
    //      GEAR_OrcaCarcassDecayed / GEAR_OrcaCarcassRavaged — BF mod 虎鲸尸体腐烂态
    private static readonly string[] DecayTargetTokens = new[]
    {
        "Spoiled",     // vanilla *_Spoiled_Dif / *Spoiled
        "Decayed",     // BF mod OrcaCarcassDecayed
        "Ravaged",     // BF mod OrcaCarcassRavaged
        "Rotten",      // 预留
        "Rotted",      // 预留
        // v7.2 修(用户报虎鲸第一天即成骨架):秒风干只该作用于玩家的风干物,
        //   世界尸体腐烂链(鲜尸→啃残→腐烂→骸骨)一律放行 vanilla 节奏。
        //   BF 虎鲸链 GEAR_OrcaCarcass1→Ravaged→Decayed→OrcaBones1,终点 Bones 不含上面任何 token。
        "Carcass",     // 任何尸体目标(OrcaCarcass*/CrowCarcass*)— 从第一级就拦死,不让秒风干碰
        "Bones",       // 腐烂链终点骸骨(OrcaBones1/2)— 用户报"成骨架"的那一级
        "Corpse",      // 预留:人类/动物尸体类
        "Skeleton",    // 预留:骨架态命名变体
    };

    internal static void Prefix(EvolveItem __instance)
    {
        if (!CheatState.QuickEvolve) return;
        try
        {
            // v6.8.7: 白名单 + 黑名单 双重决策 — 只有目标是合法风干物且非腐烂态才秒
            var become = __instance.m_GearItemToBecome;
            if (become == null) return;
            var go = ((UnityEngine.Component)become).gameObject;
            if (go == null) return;
            string n = go.name;
            if (string.IsNullOrEmpty(n)) return;

            // 黑名单优先 — 任何腐烂/啃残目标一律放行 vanilla
            for (int i = 0; i < DecayTargetTokens.Length; i++)
            {
                if (n.IndexOf(DecayTargetTokens[i], System.StringComparison.OrdinalIgnoreCase) >= 0)
                    return;
            }

            // 白名单 — 必须是合法风干目标才秒
            bool isCureTarget = false;
            for (int i = 0; i < CureTargetTokens.Length; i++)
            {
                if (n.IndexOf(CureTargetTokens[i], System.StringComparison.OrdinalIgnoreCase) >= 0)
                { isCureTarget = true; break; }
            }
            if (!isCureTarget) return;  // 非白名单 — 默认放行 vanilla(保守不秒,不主动伤未知 mod)

            // 采树苗时原版先在世界里生成一根放进检视,这根被秒干就会在原地掉出一根风干的。没进过背包的不秒
            var gi = __instance.m_GearItem;
            if (gi == null || (!gi.m_InPlayerInventory && !gi.m_BeenInPlayerInventory)) return;

            __instance.m_TimeToEvolveGameDays = 0f;
            __instance.m_TimeSpentEvolvingGameHours = 1f;
        }
        catch { }
    }
}

// —— v3.0.4r3 修: stack 物品 evolve 数量丢失(用户报"10 内脏只产 1 干内脏") ——
// 根因: vanilla EvolveItem.DoEvolution 把 stack 整体替换为 1 个 evolved,原 N 个鲜内脏全消耗
// 方案 A(失败): Postfix 改 evolved 物品 m_Units → __instance 状态已变,设置无效
// 方案 C: Prefix 在 vanilla evolve 前,先用 InventoryComponent 直接 spawn N-1 个 evolved 物品到背包
//   (vanilla 自己 evolve 1 个 → 总产出 N 个;原 stack 消耗 N 个匹配)
[HarmonyPatch(typeof(EvolveItem), "DoEvolution")]
internal static class Patch_EvolveItem_DoEvolution_StackFix
{
    static void Prefix(EvolveItem __instance)
    {
        try
        {
            if (__instance == null) return;
            var gi = __instance.m_GearItem;
            if (gi == null || gi.m_StackableItem == null) return;
            int extraUnits = gi.m_StackableItem.m_Units - 1;
            if (extraUnits <= 0) return;

            var prefab = __instance.m_GearItemToBecome;
            if (prefab == null) return;

            // 用 vanilla InstantiateGearItem + AddGearItem 给背包加 N-1 个 evolved 副本
            var pm = GameManager.GetPlayerManagerComponent();
            var inv = GameManager.GetInventoryComponent();
            if (pm == null || inv == null) return;

            for (int i = 0; i < extraUnits; i++)
            {
                try
                {
                    // GearItem.Instantiate 的标准方式 — 用 GearItemPrefabUtility 或直接 Object.Instantiate
                    var go = UnityEngine.Object.Instantiate(((UnityEngine.Component)prefab).gameObject);
                    if (go == null) continue;
                    var newGi = go.GetComponent<GearItem>();
                    if (newGi == null) { UnityEngine.Object.Destroy(go); continue; }
                    pm.AddItemToPlayerInventory(newGi, false, true);
                }
                catch { }
            }
        }
        catch { }
    }
}

// —— 篝火温度 300℃ v2.7.49 加 snapshot+restore —— toggle off 必须还原
//   v2.7.48 只写不还原 → 关 toggle 后 m_MaxTempIncrease 仍是 300
// v2.7.75 DynamicPatch: 去掉 [HarmonyPatch] attribute
internal static class Patch_HeatSource_Update
{
    // 每实例原值快照:toggle 第一次 on 时记,toggle off 时恢复并删除
    internal static readonly System.Collections.Generic.Dictionary<System.IntPtr, float> Snapshots
        = new System.Collections.Generic.Dictionary<System.IntPtr, float>();

    internal static void Prefix(HeatSource __instance)
    {
        try
        {
            var ptr = __instance.Pointer;
            if (CheatState.FireTemp300)
            {
                if (!Snapshots.ContainsKey(ptr))
                    Snapshots[ptr] = __instance.m_MaxTempIncrease;   // 首次开启 snapshot
                __instance.m_MaxTempIncrease = 300f;
            }
            else if (Snapshots.TryGetValue(ptr, out var orig))
            {
                __instance.m_MaxTempIncrease = orig;                 // 关闭 → 恢复
                Snapshots.Remove(ptr);
            }
        }
        catch { }
    }
}

// —— 篝火永不熄灭 v3.0.5 重写 ——
// 旧版写 m_IsPerpetual=true 导致 Fire 状态机走永久火分支,toggle off 后状态不一致(0°/不可灭/不可加燃料)。
// 新版不碰 m_IsPerpetual,只阻止两种死亡条件:时间超时 + 燃料耗尽。关闭后火自然倒计时,无需恢复。
internal static class Patch_Fire_Update_NeverDie
{
    private const float FUEL_FLOOR = 1000f;

    internal static void Prefix(Fire __instance)
    {
        try
        {
            if (!CheatState.FireNeverDie) return;
            if (__instance.m_ElapsedOnTODSeconds == 0f && __instance.m_BurnMinutesIfLit >= FUEL_FLOOR) return;
            __instance.m_ElapsedOnTODSeconds = 0f;
            if (__instance.m_BurnMinutesIfLit < FUEL_FLOOR)
                __instance.m_BurnMinutesIfLit = FUEL_FLOOR;
        }
        catch { }
    }
}

// —— 篝火燃烧上限解锁 v3.0.7 ——
// 原版 cap 来源:FireManager.m_MaxDurationHoursOfFire = 12,在 PlayerCalculateFireStartTime
// 里 clamp 玩家加燃料后火能烧多久。AddFuel 本身不直接 clamp,它信任 PlayerCalculateFireStartTime
// 的结果。所以正确做法是改 m_MaxDurationHoursOfFire,等价 CT 表里的方法。
// 这样玩家加燃料就是正常的"在当前 burn 上累加,直到 cap",不会出现"先 4000h 加满后改 9999h
// 加不进"的情况(那是因为旧版 hack 直接覆写 fire 实例 m_BurnMinutesIfLit,vanilla 自己的累加
// 被冻住了)。
internal static class Patch_FireManager_CalcStartTime_Uncap
{
    // Prefix:在原方法计算前先把 cap 字段改大,vanilla 内部 clamp 会按新 cap 算。
    // CT 等价代码:MonoMethodInit { mov [rcx+m_MaxDurationHoursOfFire],(float)1000; jmp original; }
    internal static void Prefix(FireManager __instance)
    {
        try
        {
            if (__instance == null) return;
            if (CheatState.FireMaxBurnHours <= 12f) return;
            __instance.m_MaxDurationHoursOfFire = CheatState.FireMaxBurnHours;
        }
        catch { }
    }
}

// —— 篝火燃烧上限 keeper v7.5(修"只有新篝火能超12h,已存在的篝火加不进")——
// 根因:上面的 Prefix 只在 PlayerCalculateFireStartTime(点新火)时触发。玩家读档后若没先点
//   一堆新火,FireManager 单例的 m_MaxDurationHoursOfFire 仍是 vanilla 12 → 给已存在的火加燃料
//   时按 12h clamp,加不进去;一旦点了新火 Prefix 才把 cap 顶上去,之后加旧火也就正常了。
// 修法:低频 tick 持续把单例的 cap 字段保持在目标值(覆盖 新火/旧火/FeedFire 时长标签 所有路径),
//   关闭时恢复 vanilla 12。~5s 一次一个 float set,FPS 无感;从没开过则完全零开销。
// ponytail: 固定 vanilla 默认 12f 作恢复值(与本文件注释、Slider 下限一致);若哪天别的 mod 也改
//   这个字段,再改成"首次捕获原值"策略。
internal static class FireCapKeeper
{
    private const float VanillaCap = 12f;
    private static bool _raised;

    public static void Tick()
    {
        try
        {
            float target = CheatState.FireMaxBurnHours;
            // 从没开过 → 什么都不做,零开销
            if (target <= VanillaCap && !_raised) return;

            var fm = GameManager.GetFireManagerComponent();
            if (fm == null) return;

            if (target > VanillaCap)
            {
                if (fm.m_MaxDurationHoursOfFire != target) fm.m_MaxDurationHoursOfFire = target;
                _raised = true;
            }
            else
            {
                // 用户调回 ≤12 → 恢复 vanilla,之后不再 tick
                if (fm.m_MaxDurationHoursOfFire != VanillaCap) fm.m_MaxDurationHoursOfFire = VanillaCap;
                _raised = false;
            }
        }
        catch { }
    }
}

// —— 篝火燃烧上限:喂火路径同步顶 cap v7.6(修"锻造炉/现成炉子加燃料仍卡12h")——
// 根因:上面的 uncap Prefix 只在 PlayerCalculateFireStartTime(点新火)时触发。锻造炉和已存在的
//   火炉玩家只"喂料"从不"点火" → 那条路径永不跑,只能靠 5s keeper;而场景切换/过时间会把
//   FireManager 单例的 m_MaxDurationHoursOfFire 重置回 inspector 默认 12,喂料的 clamp 抢在
//   keeper 下次 tick 之前执行 → 结果卡回 12h(正是"燃烧时间掉到一定程度再加燃料就不能超12h")。
// 两个 hook 一起补:
//   1) Panel_FeedFire.Enable Postfix —— 开面板即顶 cap,让时长预览标签也显示 >12h。
//   2) Panel_FeedFire.OnFeedFire Prefix(真正提交喂料的入口,内部走 AddFuel→PlayerCalculateFireStartTime
//      读 cap 做 clamp)—— 在 clamp 真正发生的那一刻同步顶 cap,与点火路径 CalcStartTime_Uncap 完全对称。
//      这条才是根治:面板可长开、反复喂料("再加燃料"),期间若过时间/切场景把单例重置回 12,
//      仅靠 Enable(只在开面板时跑一次)会漏,提交时的 Prefix 每次喂料都先顶 cap,彻底消除 keeper 竞态。
internal static class Patch_FeedFire_UncapOnOpen
{
    private static void RaiseCap()
    {
        try
        {
            if (CheatState.FireMaxBurnHours <= 12f) return;
            var fm = GameManager.GetFireManagerComponent();
            if (fm == null) return;
            if (fm.m_MaxDurationHoursOfFire != CheatState.FireMaxBurnHours)
                fm.m_MaxDurationHoursOfFire = CheatState.FireMaxBurnHours;
        }
        catch { }
    }

    // 开面板:顶 cap,预览标签正确
    internal static void Postfix() => RaiseCap();
}

// —— 喂料提交时顶 cap:Panel_FeedFire.OnFeedFire Prefix ——
// 与 CalcStartTime_Uncap 对称,在每次实际"加燃料"提交前把单例 cap 顶到目标值,clamp 据此算,
//   彻底解决面板长开跨过时间/场景后再次喂料被 clamp 回 12h 的竞态。
internal static class Patch_FeedFire_UncapOnCommit
{
    internal static void Prefix()
    {
        try
        {
            if (CheatState.FireMaxBurnHours <= 12f) return;
            var fm = GameManager.GetFireManagerComponent();
            if (fm == null) return;
            if (fm.m_MaxDurationHoursOfFire != CheatState.FireMaxBurnHours)
                fm.m_MaxDurationHoursOfFire = CheatState.FireMaxBurnHours;
        }
        catch { }
    }
}

#if !STORY_EDITION   // 2.24 无 CheatDeathAffliction(第二次机会病症是后加的)
// —— 清除死亡惩罚 CT:CheatDeathAffliction 设为 cured ——
// v2.7.75 DynamicPatch: 去 [HarmonyPatch] attribute,只在 ClearDeathPenalty 时挂
internal static class Patch_CheatDeathAfflict_Update
{
    internal static void Prefix(CheatDeathAffliction __instance)
    {
        if (!CheatState.ClearDeathPenalty) return;
        try { if (__instance.HasAffliction) __instance.Cure(AfflictionOptions.None); } catch { }
    }
}
#endif

#if !STORY_EDITION
// ═══════════════════════════════════════════════════════════════════
//   v2.7.55 CT 复刻 —— 商人 Trader + 美洲狮 Cougar
//   2.24 既无 Il2CppTLD.Trader 也无 Il2CppTLD.AI(商人与美洲狮都是沙盒后加内容),
//   整段排除,连带 DynamicPatch 里 CougarManager / TraderManager / ExchangeItem 的 Spec。
// ═══════════════════════════════════════════════════════════════════

// —— 商人:一次交易可选的商品数上限 + 信任最大化 ——
//   m_MaxExchangesInTrade 是一次交易最多选几样(原版 3),和清单长度无关:清单由 RollExchanges
//   按已解锁商品每样抽一条,每次极光抽一次。旧版为了"满信任还卖低级货"每次打开都全解锁、
//   重抽、把 m_LastAuroraNum 写成 -1,结果清单每次联系都变,原版"同一次极光重复联系扣信任"
//   也失效了。低级货的真正原因是直接改信任值跳过了原版解锁,见 TraderTrust。
internal static class Patch_TraderManager_GetAvailableTradeExchanges
{
    private static int _origCap = -1;

    internal static void Prefix(Il2CppTLD.Trader.TraderManager __instance)
    {
        try
        {
            if (CheatState.TraderUnlimitedList)
            {
                if (_origCap < 0) _origCap = __instance.m_MaxExchangesInTrade;
                __instance.m_MaxExchangesInTrade = 64;
            }
            else RestoreCap(__instance);

            TraderTrust.HealOnce(__instance);
            if (CheatState.TraderMaxTrust) TraderTrust.Set(__instance, __instance.m_MaxTrustLevel);
        }
        catch { }
    }

    private static void RestoreCap(Il2CppTLD.Trader.TraderManager tm)
    {
        if (_origCap < 0) return;
        if (tm != null) tm.m_MaxExchangesInTrade = _origCap;
        _origCap = -1;
    }

    internal static bool RestoreDone()
    {
        try { RestoreCap(GameManager.GetTraderManager()); } catch { _origCap = -1; }
        return true;
    }
}

// 信任满值和信任滑条走原版 AddTrust:历史最高升上去时它按阈值解锁交易和改进,每次都按当前信任
//   解锁对话,信任第一次到满格时解锁 DLC 成就 DLC01_GoodAndServices(用户确认要这个成就)。
internal static class TraderTrust
{
    private static IntPtr _healedState;

    internal static void Set(Il2CppTLD.Trader.TraderManager tm, int value)
    {
        var st = tm.m_CurrentState;
        if (st == null) return;
        int delta = Math.Clamp(value, tm.m_MinTrustLevel, tm.m_MaxTrustLevel) - st.m_CurrentTrust;
        if (delta != 0) tm.AddTrust(delta);
    }

    // 旧版直接写信任值:存档里历史最高已经很高,AddTrust 只在超过历史最高时解锁,那些阈值永远补不上。
    //   每个存档补一次,阈值不超过历史最高的交易、改进、对话都补上(三个解锁函数都会跳过已解锁的)。
    internal static void HealOnce(Il2CppTLD.Trader.TraderManager tm)
    {
        var st = tm.m_CurrentState;
        if (st == null || st.Pointer == _healedState) return;
        _healedState = st.Pointer;
        int high = st.m_HighestTrust;

        var ex = tm.m_TradeExchangeUnlocks;
        if (ex != null)
            for (int i = 0; i < ex.Count; i++)
            {
                try
                {
                    var u = ex[i];
                    if (u != null && u.Unlock != null && u.TrustThreshold <= high) tm.UnlockExchange(u.Unlock);
                }
                catch { }
            }
        var im = tm.m_TraderImprovementUnlocks;
        if (im != null)
            for (int i = 0; i < im.Count; i++)
            {
                try
                {
                    var u = im[i];
                    if (u != null && u.TrustThreshold <= high) tm.UnlockImprovement(u.Unlock);
                }
                catch { }
            }
        var cv = tm.m_ConversationUnlocks;
        if (cv != null)
            for (int i = 0; i < cv.Count; i++)
            {
                try
                {
                    var u = cv[i];
                    if (u != null && u.Unlock != null && u.TrustThreshold >= 0 && u.TrustThreshold <= high)
                        tm.UnlockConversation(u.Unlock, u.TrustThreshold);
                }
                catch { }
            }
    }
}

// —— 商人:随时可联系(无线电)——
//   CT: IsTraderAvailable 直接 mov al,01; ret → __result = true
internal static class Patch_TraderManager_IsTraderAvailable
{
    internal static void Postfix(ref bool __result)
    {
        // v6.9.6 只升不降:原版已判定商人可用(剧情/任务进度)→ 绝不覆盖为 false。
        //   旧版无条件 __result = (hoursPlayed >= days*24) 会在第 N 天前把原版的 true 也压成 false
        //   → 挡掉正常游戏进度(玩家反馈的"商人修改导致进度卡住")。现在本 patch 只能让商人"更早可用",
        //   永远不会让它"更晚"。
        if (__result) return;
        if (CheatState.TraderAlwaysAvailable) { __result = true; return; }
        try
        {
            var tod = GameManager.GetTimeOfDayComponent();
            if (tod == null) return; // 加载/主菜单期 tod 可能为 null,旧版无防护会抛 NPE
            float days = ModMain.Settings != null ? ModMain.Settings.TraderArrivalDays : 25f;
            if (tod.GetHoursPlayedNotPaused() >= days * 24f)
                __result = true;
        }
        catch { }
    }
}

// —— 商人:无线电随时可联系(CT: CanContactTrader → true) ——
internal static class Patch_TraderRadio_CanContactTrader
{
    internal static void Postfix(ref bool __result)
    {
        if (CheatState.TraderAlwaysAvailable) __result = true;
    }
}

// —— 商人:商人常驻时交易完成后的冷却也不用等 ——
//   电台版 IsTraderAvailable = 管理器 IsTraderAvailable && 已过交易完成后的冷却(Tunables.m_HoursUnavailableAfterCompletedTrade)。
//   奖励没拿走前电台主菜单不给开新单(ShowMain 只在没有进行中交易时加这一项),去掉冷却不会冲掉奖励。
internal static class Patch_TraderRadio_IsTraderAvailable
{
    internal static void Postfix(ref bool __result)
    {
        if (CheatState.TraderAlwaysAvailable) __result = true;
    }
}

// —— 商人:免费即时交易 ——
//   Prefix: 填充已交换数量(免费,不需要投入物品),交换箱进度显示满格
//   Postfix: 强制 true。CompleteTrade / IsFullyFilled / HasRewards 都只经这里判定交齐;
//   玩家往箱里放取东西时原版 UpdateExchanged 会按实物重算数量,关掉开关后自己改回来。
internal static class Patch_ExchangeItem_IsFullyExchanged
{
    internal static void Prefix(Il2CppTLD.Trader.ExchangeItem __instance)
    {
        if (!CheatState.TraderInstantExchange) return;
        try
        {
            __instance.m_ExchangedAmount       = __instance.m_Amount;
            __instance.m_ExchangedWeight       = __instance.m_Weight;
            __instance.m_ExchangedLiquidVolume = __instance.m_LiquidVolume;
        }
        catch { }
    }

    internal static void Postfix(ref bool __result)
    {
        if (CheatState.TraderInstantExchange) __result = true;
    }
}

// —— 商人:即时交易时关箱就完成交易 ——
//   原版:关箱确认(CloseTrade,状态改成已关闭)后,要等下次能用电台联系商人、在对话里选一项才调
//   CompleteTrade 放奖励;完成后商人出去 m_HoursUnavailableAfterCompletedTrade 小时,期间电台联系不上。
//   这里关箱后补调 CompleteTrade,再把完成时间往前挪一个冷却,商人马上能再联系。
//   奖励没拿走之前 m_ActiveTrade 一直挂着,电台开不了新单,挪冷却不会冲掉奖励。
//   不在 CloseTrade 里直接调:那时交换箱面板还在关闭流程里,等面板关完再动交易状态。
internal static class Patch_TraderManager_CloseTrade
{
    internal static bool Pending;

    internal static void Postfix()
    {
        if (CheatState.TraderInstantExchange) Pending = true;
    }

    internal static void Tick()
    {
        try
        {
            if (!CheatState.TraderInstantExchange) { Pending = false; return; }
            var panel = InterfaceManager.GetPanel<Panel_ExchangeBox>();
            if (panel != null && ((Panel_Base)panel).IsEnabled()) return;
            Pending = false;
            var tm = GameManager.GetTraderManager();
            var st = tm?.m_CurrentState;
            var trade = st?.m_ActiveTrade;
            if (trade == null || (int)trade.m_TradeState != 1 || !tm.IsTradeFullyFilled()) return;
            tm.CompleteTrade();
            if ((int)trade.m_TradeState == 2)
                st.m_TimeLastTradeComplete -= tm.Tunables.m_HoursUnavailableAfterCompletedTrade;
        }
        catch { Pending = false; }
    }
}

// —— 美洲狮:新档首次立即激活 ——
//   CT: UpdateWaitingForArrival Prefix,设 __instance.m_ActiveTerritory.m_CougarState = 2 (WaitingForTransition)
//   enum CougarState { Start=0, WaitingForArrival=1, WaitingForTransition=2, HasArrivedAfterTransition=3, PlayingIntroTimeline=4, HasArrived=5 }
//   激活后进出门/睡觉会触发到 HasArrivedAfterTransition 动画
// v2.7.63 双路并行:
//   A. Patch UpdateWaitingForArrival Prefix(CT 原路径)—— 仅 state=WaitingForArrival 时调
//   B. 加 tick 扫 m_ActiveTerritory,state < 2 时强推 2 —— 绕开 CT 路径只在特定 state 才触发的限制
// 去掉 [HarmonyPatch],改由 DynamicPatch 按开关挂卸:静态挂载时开关关着也每帧过一次 bridge
//   (美洲狮处于 WaitingForArrival 的整段时间里每帧都调),和下面 Update_ForceActivate 同一个原因
internal static class Patch_CougarManager_UpdateWaitingForArrival
{
    internal static void Prefix(Il2CppTLD.AI.CougarManager __instance)
    {
        if (!CheatState.CougarInstantActivate) return;
        try
        {
            var terr = __instance.m_ActiveTerritory;
            if (terr != null)
                terr.m_CougarState = Il2CppTLD.AI.CougarManager.CougarState.WaitingForTransition;
        }
        catch { }
    }
}

// v2.7.75 DynamicPatch: 去 [HarmonyPatch] attribute —— 美洲狮地图每帧 bridge 是 23:40 卡的嫌疑
internal static class Patch_CougarManager_Update_ForceActivate
{
    private static bool _logged;
    internal static void Prefix(Il2CppTLD.AI.CougarManager __instance)
    {
        if (!CheatState.CougarInstantActivate) return;
        try
        {
            var terr = __instance.m_ActiveTerritory;
            if (terr == null) return;
            // 只在 state < WaitingForTransition(2)时推;>=2 不动,让进出门/睡觉自然触发动画
            if ((int)terr.m_CougarState < 2)
            {
                if (!_logged)
                {
                    _logged = true;
                    ModMain.Log?.Msg($"[Cougar] 强推 state {terr.m_CougarState} → WaitingForTransition (2)");
                }
                terr.m_CougarState = Il2CppTLD.AI.CougarManager.CougarState.WaitingForTransition;
            }
        }
        catch { }
    }
}
#endif

// ═══════════════════════════════════════════════════════════════════
//   CT 复刻 —— 无冻伤风险 / 饱饱 buff / 温度加成 / 疲劳加成 / 坏血病查看
// ═══════════════════════════════════════════════════════════════════

// —— 无冻伤风险:Frostbite.DealFrostbiteDamageToLocation → skip ——
// CT 做法:hook +100 处,设 [rcx+rbx*4+20]=(float)0(伤害归零)
// Harmony:Prefix return false = skip entire method
internal static class Patch_Frostbite_DealDamage
{
    internal static bool Prefix() => !(CheatState.NoFrostbiteRisk || CheatState.GodMode);
}

// v9.6 无敌挡新伤病。同一个 Prefix 挂到多个 XxxStart 上(见 DynamicPatch),IL2CPP 下漏网的由 TickAfflictionGuard 每秒兜底
internal static class Patch_GodMode_BlockAffliction
{
    internal static bool Prefix() => !CheatState.GodMode;
}

internal static class Patch_NoSuffocating_Start
{
    internal static bool Prefix() => !(CheatState.GodMode || CheatState.NoSuffocating);
}

#if !STORY_EDITION
// 美洲狮扑击挂的严重撕裂伤,免动物伤害之前只挡了扣血和出血
internal static class Patch_SevereLacerations_Apply
{
    internal static bool Prefix() => !(CheatState.GodMode || CheatState.ImmuneAnimalDamage);
}
#endif

// —— 饱饱 buff:WellFed.Update Prefix 强制 m_Active=true ——
// CT 做法:NOP WellFed.Update 前 2 字节(跳过退出条件),条件:饥饿不为0
// Harmony:Prefix 设 m_Active = true,原方法继续正常跑
internal static class Patch_WellFed_Update
{
    internal static void Prefix(WellFed __instance)
    {
        if (!CheatState.WellFedBuff) return;
        try { __instance.m_Active = true; } catch { }
    }
}

// —— 温度加成:FreezingBuff getter → __result = true ——
// CT 做法:hook PlayerManager.FreezingBuffActive,设 [rbx+50]=(float)1
// Harmony:Postfix 强制 __result = true
internal static class Patch_PlayerManager_FreezingBuffActive
{
    internal static void Postfix(ref bool __result)
    {
        if (CheatState.FreezingBuff) __result = true;
    }
}

// —— 疲劳加成:PlayerManager.FatigueBuffActive → true ——
// CT 做法:hook StatusBar.IsBuffActive,设 [rax+3C]=(float)1
// 游戏原生: PlayerManager.FatigueBuffActive() 返回 true 时,Fatigue 系统自动降低积累速率
// 与 FreezingBuffActive 完全对称的 Postfix 模式
internal static class Patch_PlayerManager_FatigueBuffActive
{
    internal static void Postfix(ref bool __result)
    {
        if (CheatState.FatigueBuff) __result = true;
    }
}

// —— 坏血病查看:直接读 ScurvyManager 属性(Menu 打开时调用,零 patch 开销)——
internal static class ScurvyViewer
{
    public static float VitaminC;
    public static float Threshold;
    public static string Status = "";

    public static void Poll()
    {
#if STORY_EDITION
        // 2.24 无坏血病系统。保留类壳(Menu 里的调用点不变),状态恒为不可用。
        Status = "—";
#else
        try
        {
            var mgr = GameManager.GetScurvyComponent();
            if (mgr == null) { Status = "—"; return; }
            VitaminC = mgr.GetVitaminCNormalized();
            Threshold = 1f;
            int state = (int)mgr.m_ScurvyState;
            Status = state >= 2 ? (I18n.IsEnglish ? "SCURVY" : "坏血病!")
                   : state == 1 ? (I18n.IsEnglish ? "Risk" : "风险")
                   :              (I18n.IsEnglish ? "OK" : "正常");
        }
        catch { Status = "err"; }
#endif
    }
}

// ═══════════════════════════════════════════════════════════════════
//   整合 RunWithLantern:拿油灯时可以跑步
// ═══════════════════════════════════════════════════════════════════

internal static class Patch_RunWithLantern
{
    internal static bool Prefix() => false;
}

// OnStateUpdate 是手持油灯时每帧都调的回调。原先每次 new 一个名字数组再调 3 次 IsName
//   (每次把托管字符串封送成一个新的 Il2Cpp 字符串再算哈希);这里把哈希算一次存起来,只比整数。
//   IsName 比的是短名和完整路径哈希,这里两个都比。
internal static class LanternStateHashes
{
    private static int[] _h;

    internal static bool IsLanternState(AnimatorStateInfo stateInfo)
    {
        _h ??= new[] { Animator.StringToHash("Lantern_Prepare"), Animator.StringToHash("Lantern_Idle"), Animator.StringToHash("Lantern_Extinguish") };
        int sn = stateInfo.shortNameHash, fp = stateInfo.fullPathHash;
        for (int i = 0; i < _h.Length; i++)
            if (sn == _h[i] || fp == _h[i]) return true;
        return false;
    }
}

internal static class Patch_CameraOverride_OnStateUpdate
{
    internal static bool Prefix(AnimatorStateInfo stateInfo)
    {
        if (!CheatState.RunWithLantern) return true;
        return !LanternStateHashes.IsLanternState(stateInfo);
    }
}

internal static class Patch_CameraOverride_OnStateEnter
{
    internal static bool Prefix(AnimatorStateInfo stateInfo)
    {
        if (!CheatState.RunWithLantern) return true;
        return !LanternStateHashes.IsLanternState(stateInfo);
    }
}

// ═══════════════════════════════════════════════════════════════════
//   整合 FullSwing:门开角度和开门速度可调
// ═══════════════════════════════════════════════════════════════════

internal static class Patch_ObjectAnim_Play
{
    internal static void Prefix(ObjectAnim __instance, ref string name)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;
            if ((UnityEngine.Object)__instance.m_Target == null || __instance.m_Events == null) return;
            if (name != "open" && name != "close") return;
            if (name == "open" && ((UnityEngine.Object)((Component)__instance).gameObject).name != "Door") return;

            iTweenEvent openEvt = null, closeEvt = null;
            var events = (Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<iTweenEvent>)(object)__instance.m_Events;
            foreach (var ev in events)
            {
                if (ev.tweenName == "open") openEvt = ev;
                if (ev.tweenName == "close") closeEvt = ev;
            }

            if (name == "open" && openEvt != null && closeEvt != null)
            {
                float angle = s.DoorSwingAngle;
                float speed = s.DoorSwingSpeed;
                ((Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<Vector3>)(object)openEvt.vector3s)[0] = new Vector3(angle, 0f, 0f);
                ((Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<Vector3>)(object)closeEvt.vector3s)[0] = new Vector3(0f - angle, 0f, 0f);
                ((Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<float>)(object)openEvt.floats)[0] = speed;
                ((Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppArrayBase<float>)(object)closeEvt.floats)[0] = speed;
                openEvt.DeserializeValues();
                closeEvt.DeserializeValues();
            }
        }
        catch (Exception ex)
        {
            MelonLoader.MelonLogger.Warning($"[TldHacks] FullSwing patch error: {ex.Message}");
        }
    }
}

// ═══════════════════════════════════════════════════════════════════
//   整合 DisableAutoEquipCharcoal:取炭不自动装备
// ═══════════════════════════════════════════════════════════════════

// 原版取炭后是排队、下一帧才装上,取完再卸那时手上还不是木炭。改成取炭时开 2 秒窗口,窗口内装备木炭直接挡掉
internal static class Patch_CharcoalHarvest_NoEquip
{
    internal static float BlockUntil = -1f;

    internal static void Prefix()
    {
        BlockUntil = UnityEngine.Time.realtimeSinceStartup + 2f;
    }
}

internal static class Patch_Charcoal_BlockEquip
{
    internal static bool Prefix(GearItem gi)
    {
        if (!CheatState.NoAutoEquipCharcoal || gi == null) return true;
        if (UnityEngine.Time.realtimeSinceStartup > Patch_CharcoalHarvest_NoEquip.BlockUntil) return true;
        try { return gi.m_CharcoalItem == null; }
        catch { return true; }
    }
}

// ═══════════════════════════════════════════════════════════════════
//   整合 AutoToggleLights:休息/等待时自动熄灯
// ═══════════════════════════════════════════════════════════════════

internal static class Patch_AutoExtinguish_PassTime
{
    internal static void Postfix()
    {
        if (CheatState.AutoExtinguishOnRest) AutoExtinguishHelper.ExtinguishHeld();
    }
}

internal static class Patch_AutoExtinguish_OnRest
{
    internal static void Postfix()
    {
        if (CheatState.AutoExtinguishOnRest) AutoExtinguishHelper.ExtinguishHeld();
    }
}

internal static class AutoExtinguishHelper
{
    public static void ExtinguishHeld()
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null || pm.m_ItemInHands == null) return;
            var lamp = pm.m_ItemInHands.GetComponent<KeroseneLampItem>();
            if (lamp != null && lamp.IsOn()) { lamp.TurnOff(true); return; }
            var torch = pm.m_ItemInHands.GetComponent<TorchItem>();
            if (torch != null && torch.IsBurning()) { torch.Extinguish((TorchState)4); return; }
            var flash = pm.m_ItemInHands.GetComponent<FlashlightItem>();
            if (flash != null && flash.IsOn()) flash.TurnOff();
        }
        catch { }
    }
}

// —— 防止左键误灭火把 / 油灯 ——
// v9.0:原来是一律吞掉,遇到状态不同步(比如拆解、休息期间 mod 自动熄灯之后 IsOn() 还报 true)
//   左键就彻底失效,只能放回背包再拿出来。现在同一件东西 1.2 秒内连点第二下就放过去:
//   误碰一下仍然拦住,真想操作连点两下总能生效,不会再出现点不动的死局。
internal static class LeftClickGuard
{
    private const float DOUBLE_CLICK_WINDOW = 1.2f;
    private static IntPtr _last;
    private static float _lastTime;

    // 只有真的按着左键才算"误碰左键"。游戏自己在流程里熄灭(用完自动熄、收起、点火流程内部再调一次
    // Toggle)一律放过 —— 拦下来会让道具停在"还在燃烧 / 半开"的状态,之后怎么点都点不亮。
    internal static bool FromLeftClick() => UnityEngine.Input.GetMouseButton(0);

    // true = 这一下要拦住
    internal static bool Block(IntPtr item)
    {
        float now = UnityEngine.Time.realtimeSinceStartup;
        if (item == _last && now - _lastTime <= DOUBLE_CLICK_WINDOW)
        {
            _last = IntPtr.Zero;   // 放过这一下,并且不把它算成新的第一下
            return false;
        }
        _last = item;
        _lastTime = now;
        return true;
    }
}

internal static class Patch_TorchExtinguish_Block
{
    internal static bool Prefix(TorchItem __instance)
    {
        if (!CheatState.DisableTorchLeftClick) return true;
        if (!LeftClickGuard.FromLeftClick()) return true;
        if (!LeftClickGuard.Block(__instance.Pointer)) return true;
        // 关键:吞掉这次熄灭之后必须把"正在熄灭"的中间态撤回。不撤的话这根火把 / 火柴
        // 永远停在 IsExtinguishing(),表现是点不燃、切不出别的物品、H 也没反应(实测)。
        try { if (__instance.IsExtinguishing()) __instance.CancelExtinguish(); } catch { }
        return false;
    }
}

internal static class Patch_LampToggle_Block
{
    internal static bool Prefix(KeroseneLampItem __instance)
    {
        if (!CheatState.DisableLampLeftClick) return true;
        // 点燃 / 熄灭的过渡动画期间一律不插手:这时候拦一下就会把灯卡在过渡态
        if (!__instance.IsOn() || __instance.IsIgnitingOrExtinguishing()) return true;
        if (!LeftClickGuard.FromLeftClick()) return true;
        return !LeftClickGuard.Block(__instance.Pointer);
    }
}

// ═══════════════════════════════════════════════════════════════════
//   整合 CaffeinatedSodas:苏打水加 FatigueBuff
// ═══════════════════════════════════════════════════════════════════

internal static class Patch_GearItem_Awake_CaffeinatedSodas
{
    private static float DurationHours(int choice) => choice switch
    {
        0 => 0.085f,
        1 => 0.167f,
        2 => 0.25f,
        3 => 0.5f,
        _ => 0.167f,
    };

    internal static void Postfix(GearItem __instance)
    {
        try
        {
            if (!CheatState.World_CaffeinatedSodas) return;
            var s = ModMain.Settings;
            if (s == null) return;

            string objName = ((UnityEngine.Object)__instance).name;

            if (objName.Contains("GEAR_SodaOrange") && s.World_SodaOrangeEnabled)
            {
                var buff = ((Component)__instance).gameObject.AddComponent<FatigueBuff>();
                __instance.m_FatigueBuff = buff;
                buff.m_InitialPercentDecrease = s.World_SodaOrangeInitial;
                buff.m_RateOfIncreaseScale = 1f;
                buff.m_DurationHours = DurationHours(s.World_SodaOrangeDuration);
            }
            else if (objName.Contains("GEAR_SodaGrape") && s.World_SodaGrapeEnabled)
            {
                var buff = ((Component)__instance).gameObject.AddComponent<FatigueBuff>();
                __instance.m_FatigueBuff = buff;
                buff.m_InitialPercentDecrease = s.World_SodaGrapeInitial;
                buff.m_RateOfIncreaseScale = 1f;
                buff.m_DurationHours = DurationHours(s.World_SodaGrapeDuration);
            }
            else if (objName.Contains("GEAR_Soda") && !objName.Contains("GEAR_SodaOrange")
                     && !objName.Contains("GEAR_SodaGrape") && s.World_SodaSummitEnabled)
            {
                var buff = ((Component)__instance).gameObject.AddComponent<FatigueBuff>();
                __instance.m_FatigueBuff = buff;
                buff.m_InitialPercentDecrease = s.World_SodaSummitInitial;
                buff.m_RateOfIncreaseScale = 1f;
                buff.m_DurationHours = DurationHours(s.World_SodaSummitDuration);
            }
        }
        catch (Exception ex)
        {
            MelonLoader.MelonLogger.Warning($"[TldHacks] CaffeinatedSodas patch error: {ex.Message}");
        }
    }
}

// ═══════════════════════════════════════════════════════════════════
//   v2.8.1 容器无限容量 — 照抄 UniversalTweaks 方案
// ═══════════════════════════════════════════════════════════════════

internal static class Patch_Container_Awake_InfiniteCapacity
{
    internal static void Postfix(Container __instance)
    {
        if (!CheatState.InfiniteContainer) return;
#if STORY_EDITION
        try { __instance.m_CapacityKG = 10000f; } catch { }
#else
        try { __instance.m_Capacity = Il2CppTLD.IntBackedUnit.ItemWeight.FromKilograms(10000f); } catch { }
#endif
    }
}

// ═══════════════════════════════════════════════════════════════════
//   v2.8.1 坠落伤害 — patch FallDamage 入口方法彻底屏蔽
// ═══════════════════════════════════════════════════════════════════

internal static class Patch_FallDamage_MaybeApply
{
    internal static bool Prefix() => !CheatState.NoFallDamage && !TeleportFallGuard.Active;
}

internal static class Patch_FallDamage_ApplyAll
{
    // v3.0.4r3 修: 用户报衣物撕裂仍发生
    // 根因: IL2CPP 下 Prefix return false 不可靠,vanilla 仍跑 ApplyClothingDamage(fallHeight) → HP 减损 → 撕裂
    // 修复: ref 改 fallHeight=0,让 vanilla 自己算出 damage(0)=0,完全不依赖 return false
    internal static void Prefix(ref float fallHeight)
    {
        if (CheatState.NoFallDamage || TeleportFallGuard.Active)
        {
            fallHeight = 0f;            // 关键: vanilla 算 damage = f(height) → 0
            FallClothingGuard.Arm();    // 双保险: GearDegrade 也 hp=0
        }
    }
    internal static void Postfix()
    {
        FallClothingGuard.Clear();
    }
}

// v3.0.4r3: 主入口 ApplyFallDamage(height, damageOverride) 也清零,
// 防止内部 ApplyTravoisDamage / ApplyInsulatedFlaskDamage 等子方法用到非零 height
[HarmonyPatch(typeof(FallDamage), "ApplyFallDamage", new System.Type[] { typeof(float), typeof(float) })]
internal static class Patch_FallDamage_ApplyFallDamage_ZeroHeight
{
    static void Prefix(ref float height, ref float damageOverride)
    {
        if (CheatState.NoFallDamage || TeleportFallGuard.Active)
        {
            height = 0f;
            damageOverride = 0f;
        }
    }
}

internal static class FallClothingGuard
{
    public static bool Active;
    public static void Arm() => Active = true;
    public static void Clear() => Active = false;
}

internal static class TeleportFallGuard
{
    public static bool Active;
    private static int _frames;
    public static void Arm() { Active = true; _frames = 180; }
    public static void Tick() { if (Active && --_frames <= 0) Active = false; }
}

// v7.7 删掉 Patch_Blueprint_NumSets —— 目标方法 NumSetsOfMaterialsAvailable 在 TLD 2.55
//   已被移除(见 DynamicPatch.cs:529 的注释),类因此既无 attribute 也无 Spec,从未挂载。
//   免费制作由上面 7 个 CanCraft/材料检查 patch 覆盖。

// ═══════════════════════════════════════════════════════════════════
// ═══════════════════════════════════════════════════════════════════
// v2.7.88r3 出门自动开 MotionTrackerLite 小地图: 检测 室内→室外 场景切换,延迟 1 秒后开
//   每 15 帧 poll 一次 m_ActiveScene,降低开销
//   反射调用 MotionTrackerLite.ModMain.SetActive(true) — 不依赖 ToggleKey,适配玩家改键
// ═══════════════════════════════════════════════════════════════════
internal static class AutoOpenMapHandler
{
    private static string _lastScene = null;
    private static int _delayTicks = 0;
    private static int _pollSkip = 0;
    private static int _pressesRemaining = 0; // v2.7.88r5: 模拟连按 N 次

    // MotionTrackerLite 反射缓存
    private static bool _mtlResolved;
    private static System.Reflection.FieldInfo _mtlEnabledField;     // Tracker.Enabled (public static bool)
    private static System.Reflection.MethodInfo _mtlSetActiveMethod; // ModMain.SetActive(bool) (private static)
    private static bool _loggedSuccess;
    private static bool _loggedFail;

    private static bool ResolveMTL()
    {
        if (_mtlResolved) return _mtlSetActiveMethod != null && _mtlEnabledField != null;
        _mtlResolved = true;
        try
        {
            System.Reflection.Assembly asm = null;
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (a.GetName().Name == "MotionTrackerLite") { asm = a; break; }
            }
            if (asm == null)
            {
                if (!_loggedFail) { _loggedFail = true; ModMain.Log?.Msg("[AutoMTL] MotionTrackerLite 未安装,自动开图无效(toggle 静默)"); }
                return false;
            }
            var trackerType = asm.GetType("MotionTrackerLite.Tracker");
            var modMainType = asm.GetType("MotionTrackerLite.ModMain");
            if (trackerType == null || modMainType == null)
            {
                if (!_loggedFail) { _loggedFail = true; ModMain.Log?.Warning("[AutoMTL] 找不到 Tracker / ModMain 类型,内部 API 可能变了"); }
                return false;
            }
            _mtlEnabledField = trackerType.GetField("Enabled", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            _mtlSetActiveMethod = modMainType.GetMethod("SetActive",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static,
                null, new System.Type[] { typeof(bool) }, null);
            if (_mtlEnabledField == null || _mtlSetActiveMethod == null)
            {
                if (!_loggedFail) { _loggedFail = true; ModMain.Log?.Warning($"[AutoMTL] 反射失败: EnabledField={_mtlEnabledField != null}, SetActive={_mtlSetActiveMethod != null}"); }
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            if (!_loggedFail) { _loggedFail = true; ModMain.Log?.Warning($"[AutoMTL] resolve 异常: {ex.Message}"); }
            return false;
        }
    }

    public static void Tick()
    {
        var s = ModMain.Settings;
        if (s == null || !s.QoL_Enabled || !s.QoL_AutoOpenMapOnExit) return;
        if (++_pollSkip < 15) return;
        _pollSkip = 0;
        if (GameManager.IsMainMenuActive()) { _lastScene = null; _delayTicks = 0; return; }

        // v2.7.88r5: 用户实测手动按 U 也要 3 次才开 → 自动调用模拟连按 3 次
        if (_delayTicks > 0)
        {
            _delayTicks--;
            if (_delayTicks == 0 && _pressesRemaining > 0)
            {
                try
                {
                    if (!ResolveMTL()) { _pressesRemaining = 0; return; }
                    _mtlEnabledField.SetValue(null, true);
                    _mtlSetActiveMethod.Invoke(null, new object[] { true });
                    _pressesRemaining--;
                    if (!_loggedSuccess) { _loggedSuccess = true; ModMain.Log?.Msg("[AutoMTL] 调用 SetActive(true) (剩余 " + _pressesRemaining + " 次)"); }
                }
                catch (Exception ex)
                {
                    if (!_loggedFail) { _loggedFail = true; ModMain.Log?.Warning($"[AutoMTL] invoke 失败: {ex.Message}"); }
                    _pressesRemaining = 0;
                }
                if (_pressesRemaining > 0) _delayTicks = 2; // 隔 2 个 tick (~30 帧) 再调下一次
            }
            return;
        }

        string cur = GameManager.m_ActiveScene;
        if (string.IsNullOrEmpty(cur)) return;
        if (cur == _lastScene) return;

        bool wasIndoor = !string.IsNullOrEmpty(_lastScene) && !GameManager.IsOutDoorsScene(_lastScene);
        bool nowOutdoor = false;
        try { nowOutdoor = GameManager.IsOutDoorsScene(cur); } catch { }
        _lastScene = cur;
        if (wasIndoor && nowOutdoor)
        {
            _delayTicks = 4;     // 等 1 秒 loading 稳定
            _pressesRemaining = 3; // 模拟连按 3 次 U
        }
    }
}

// ═══════════════════════════════════════════════════════════════════
// v2.7.88r2 哈气特效兜底:缓存 Breath 引用避免每帧 FindObjectOfType 掉帧
//   只在 toggle 状态切换瞬间执行;非切换帧零开销
// ═══════════════════════════════════════════════════════════════════
internal static class BreathHandlerTick
{
    private static Breath _cachedBreath;
    private static bool _lastVisible = true;
    private static int _findCooldown = 0;

    public static void Tick()
    {
        var s = ModMain.Settings;
        if (s == null) return;
        bool visible = s.UT_BreathVisibility;
        // 状态没变 → 完全跳过(零开销)
        if (visible == _lastVisible) return;
        _lastVisible = visible;

        // 状态切换 → 找 Breath 实例(带 30 帧冷却,避免连按抖动)
        if (_cachedBreath == null)
        {
            if (_findCooldown > 0) { _findCooldown--; return; }
            _cachedBreath = UnityEngine.Object.FindObjectOfType<Breath>();
            _findCooldown = 30;
            if (_cachedBreath == null) return;
        }
        try
        {
            _cachedBreath.m_SuppressEffects = !visible;
            if (!visible) try { _cachedBreath.StopBreathEffectImmediate(); } catch { }
        }
        catch { _cachedBreath = null; }
    }
}

// ═══════════════════════════════════════════════════════════════════
// v2.7.88 空格代替鼠标点击 "拆解/采集/制作/修理" 按钮
//   面板打开 + 按空格 = 直接触发 vanilla 的 StartXxx/OnXxx 方法
//   等同于鼠标左键点击主操作按钮 (vanilla 进度条仍然走,除非另开 QuickX toggle)
// ═══════════════════════════════════════════════════════════════════
internal static class SpaceFinishHandler
{
    public static void Tick()
    {
        var s = ModMain.Settings;
        if (s == null) return;
        if (!s.SpaceFinish_BreakDown && !s.SpaceFinish_Harvest
            && !s.SpaceFinish_Craft && !s.SpaceFinish_Repair) return;
        if (!UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Space)) return;
        if (Menu.CapturingKeys) return;   // 在搜索框里敲空格

        if (s.SpaceFinish_BreakDown)
        {
            try
            {
                var p = InterfaceManager.GetPanel<Panel_BreakDown>();   // 游戏自己的面板表,不扫场景(每按一次空格原先要全场景搜 4 遍)
                if (p != null && p.isActiveAndEnabled && !p.m_IsBreakingDown)
                {
                    p.OnBreakDown();
                    ModMain.Log?.Msg("[SpaceClick] BreakDown");
                }
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[SpaceClick.BD] {ex.Message}"); }
        }

        if (s.SpaceFinish_Harvest)
        {
            try
            {
                var p = InterfaceManager.GetPanel<Panel_BodyHarvest>();
                if (p != null && p.isActiveAndEnabled)
                {
#if STORY_EDITION
                    // 2.24 无 m_HarvestTimeMinutes 字段,时长由 GetHarvestDurationMinutes() 算出
                    int mins = Mathf.Max(1, (int)p.GetHarvestDurationMinutes());
#else
                    int mins = Mathf.Max(1, (int)p.m_HarvestTimeMinutes);
#endif
                    p.StartHarvest(mins, string.Empty);
                    ModMain.Log?.Msg("[SpaceClick] Harvest");
                }
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[SpaceClick.HV] {ex.Message}"); }
        }

        if (s.SpaceFinish_Craft)
        {
            try
            {
                var p = InterfaceManager.GetPanel<Panel_Crafting>();
                if (p != null && p.isActiveAndEnabled)
                {
                    p.CraftingStart();
                    ModMain.Log?.Msg("[SpaceClick] Craft");
                }
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[SpaceClick.CR] {ex.Message}"); }
        }

        if (s.SpaceFinish_Repair)
        {
            try
            {
                var p = InterfaceManager.GetPanel<Panel_Repair>();
                if (p != null && p.isActiveAndEnabled)
                {
                    int mins = Mathf.Max(1, (int)Mathf.Ceil(p.m_RepairTimeSeconds / 60f));
                    p.StartRepair(mins, string.Empty);
                    ModMain.Log?.Msg("[SpaceClick] Repair");
                }
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[SpaceClick.RP] {ex.Message}"); }
        }
    }
}
