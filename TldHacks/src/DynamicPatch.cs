using System;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
#if !STORY_EDITION
// 2.24(剧情模式)没有这些命名空间:装备重构、交互系统重构、电解器、新闻轮播
// 都是 2.24 之后加进游戏的。对应的 Spec 条目同样按 !STORY_EDITION 排除。
using Il2CppTLD.Gear;
using Il2CppTLD.Interactions;
using Il2CppTLD.ModularElectrolizer;
using Il2CppTLD.News;
#endif
using UnityEngine;

namespace TldHacks;

// 按 toggle 动态 Harmony.Patch / Unpatch 每帧高频方法,消除 IL2Cpp bridge 开销。
// 无状态 patch:立即挂/卸。
// 有状态 patch(Fire/HeatSource snapshot restore):toggle off 保留 patch 直到 cleanup 完成再卸。
internal static class DynamicPatch
{
    private const string HARMONY_ID = "TldHacks.Dynamic";
    private static HarmonyLib.Harmony _h;
    private static readonly Type[] OneFloat = { typeof(float) };
    private static readonly Type[] OneBool = { typeof(bool) };
    private static readonly Type[] OneGearItem = { typeof(GearItem) };
    private static readonly Type[] HealthDamageArgs = { typeof(float), typeof(DamageSource) };
    private static readonly Type[] HealthDamageBoolArgs = { typeof(float), typeof(DamageSource), typeof(bool) };
    private static readonly Type[] OneIntString = { typeof(int), typeof(string) };
    private static readonly Type[] TwoCookingFloats = { typeof(float), typeof(float) };
    private static readonly Type[] PanelBreakDownEnableArgs = { typeof(bool) };
#if STORY_EDITION
    // 2.24 Panel_Container.Enable 只有 (bool) 和 (bool, bool) 两个重载,没有 2.55 的
    // (bool, bool, Action)。取 2 参那个 —— 1 参版在 2.24 里就是转调它,挂 2 参覆盖面更全。
    private static readonly Type[] ContainerEnableArgs = { typeof(bool), typeof(bool) };
#else
    private static readonly Type[] ContainerEnableArgs = { typeof(bool), typeof(bool), typeof(Il2CppSystem.Action) };
#endif
#if !STORY_EDITION
    // 2.24 无 Il2Cpp.FatigueFlags(疲劳标志枚举是后加的)。这是运行时 cctor
    // TypeLoadException 的元凶之一:静态数组里任何一个 typeof 解析失败,整个 mod 初始化就死。
    private static readonly Type[] FloatFatigueFlags = { typeof(float), typeof(FatigueFlags) };
#endif
    private static readonly Type[] AnimStateArgs = { typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int) };
    private static readonly Type[] OneString = { typeof(string) };
#if !STORY_EDITION
    private static bool CeDamageWanted => CeX.NoDeath || CeX.StruggleWin;
#else
    private static bool CeDamageWanted => false;
#endif
    private static readonly Type[] TwoBool = { typeof(bool), typeof(bool) };
    private static readonly Type[] GameObjectFloat = { typeof(UnityEngine.GameObject), typeof(float) };
    private static readonly Type[] RTPCArgs = { typeof(uint), typeof(float), typeof(UnityEngine.GameObject) };
    private static readonly Type[] FootStepArgs2 = { typeof(UnityEngine.Vector3), typeof(string) };
    private static readonly Type[] FootStepArgs3 = { typeof(UnityEngine.Vector3), typeof(string), typeof(FootStepSounds.State) };
    private static readonly Type[] GearItemBool = { typeof(GearItem), typeof(bool) };
    private static readonly Type[] HLRegisterLightArgs = { typeof(AuroraLightingSimple) };
    private static readonly Type[] HLUpdateHUDArgs = { typeof(Panel_HUD) };
    private static readonly Type[] HLTooDarkArgs = { typeof(ActionsToBlock) };
    private static readonly Type[] BodyHarvestEnableArgs = ResolvePanelBodyHarvestEnableArgs();
    private static Type[] ResolvePanelBodyHarvestEnableArgs()
    {
        var cfs = typeof(Panel_BodyHarvest).Assembly.GetType("Il2Cpp.ComingFromScreenCategory");
        if (cfs == null) return null;
        return new Type[] { typeof(bool), typeof(BodyHarvest), typeof(bool), cfs };
    }
    private static readonly Type[] BeginSleepArgs = ResolveBeginSleepArgs();
    private static Type[] ResolveBeginSleepArgs()
    {
        var asm = typeof(Rest).Assembly;
        var pt = asm.GetType("Il2Cpp.PassTimeOptions")
              ?? asm.GetType("PassTimeOptions")
              ?? asm.GetType("Il2Cpp.TLD.PassTimeOptions");
        if (pt != null)
            return new Type[] { typeof(Bed), typeof(int), typeof(int), typeof(float), pt, typeof(Il2CppSystem.Action) };

        // Fallback: find BeginSleeping(Bed, int, int, float, ?, Action) by signature shape
        var methods = typeof(Rest).GetMethods(System.Reflection.BindingFlags.Instance
            | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
        foreach (var m in methods)
        {
            if (m.Name != "BeginSleeping") continue;
            var ps = m.GetParameters();
            if (ps.Length == 6
                && ps[0].ParameterType == typeof(Bed)
                && ps[1].ParameterType == typeof(int)
                && ps[2].ParameterType == typeof(int)
                && ps[3].ParameterType == typeof(float)
                && ps[5].ParameterType == typeof(Il2CppSystem.Action))
            {
                return new Type[] { ps[0].ParameterType, ps[1].ParameterType, ps[2].ParameterType,
                    ps[3].ParameterType, ps[4].ParameterType, ps[5].ParameterType };
            }
        }
        return null;
    }

    private static HarmonyLib.Harmony H { get { if (_h == null) _h = new HarmonyLib.Harmony(HARMONY_ID); return _h; } }

    private static readonly PatchSpec[] Specs =
    {
        Spec(typeof(Condition), "AddHealth", typeof(Patch_Condition_AddHealth_2),
            "Prefix", null, () => CheatState.GodMode || CheatState.TrueInvisible || CheatState.NoFallDamage || CheatState.NoSuffocating || CheatState.ImmuneAnimalDamage || CheatState.NoFrostbiteRisk
                || CheatState.AlwaysWarm || CheatState.NoHunger || CheatState.NoThirst || CheatState.NoFatigue || CeDamageWanted,
            null, HealthDamageArgs),
        Spec(typeof(Condition), "AddHealth", typeof(Patch_Condition_AddHealth_3),
            "Prefix", null, () => CheatState.GodMode || CheatState.TrueInvisible || CheatState.NoFallDamage || CheatState.NoSuffocating || CheatState.ImmuneAnimalDamage || CheatState.NoFrostbiteRisk
                || CheatState.AlwaysWarm || CheatState.NoHunger || CheatState.NoThirst || CheatState.NoFatigue || CeDamageWanted,
            null, HealthDamageBoolArgs),
        Spec(typeof(Condition), "AddHealthWithNoHudNotification", typeof(Patch_Condition_AddHealthNoHud),
            "Prefix", null, () => CheatState.GodMode || CheatState.TrueInvisible || CheatState.NoFallDamage || CheatState.NoSuffocating || CheatState.ImmuneAnimalDamage || CheatState.NoFrostbiteRisk
                || CheatState.AlwaysWarm || CheatState.NoHunger || CheatState.NoThirst || CheatState.NoFatigue || CeDamageWanted,
            null, HealthDamageArgs),

        Spec(typeof(EvolveItem), "Update", typeof(Patch_EvolveItem_Update),
            "Prefix", null, () => CheatState.QuickEvolve),

        Spec(typeof(BaseAi), "CanSeeTarget", typeof(Patch_BaseAi_CanSeeTarget),
            "Prefix", null, () => CheatState.Stealth || CheatState.TrueInvisible),
        Spec(typeof(BaseAi), "ScanForSmells", typeof(Patch_BaseAi_ScanForSmells),
            "Prefix", null, () => CheatState.Stealth || CheatState.TrueInvisible),

        Spec(typeof(Fire), "Update", typeof(Patch_Fire_Update_NeverDie),
            "Prefix", null, () => CheatState.FireNeverDie),
        Spec(typeof(FireManager), "PlayerCalculateFireStartTime", typeof(Patch_FireManager_CalcStartTime_Uncap),
            "Prefix", null, () => CheatState.FireMaxBurnHours > 12f),
        // v7.6:喂火面板打开时同步顶 cap,修"锻造炉/现成炉子喂料仍卡12h"(点火路径的对称补丁,让预览标签也对)
        Spec(typeof(Panel_FeedFire), "Enable", typeof(Patch_FeedFire_UncapOnOpen),
            null, "Postfix", () => CheatState.FireMaxBurnHours > 12f),
        // v7.6:喂料提交时顶 cap(根治面板长开跨过时间/场景后再次喂料被 clamp 回 12h 的竞态)
        Spec(typeof(Panel_FeedFire), "OnFeedFire", typeof(Patch_FeedFire_UncapOnCommit),
            "Prefix", null, () => CheatState.FireMaxBurnHours > 12f),
        Spec(typeof(HeatSource), "Update", typeof(Patch_HeatSource_Update),
            "Prefix", null, () => CheatState.FireTemp300,
            () => Patch_HeatSource_Update.Snapshots.Count == 0),

#if !STORY_EDITION
        Spec(typeof(Il2CppTLD.AI.CougarManager), "Update", typeof(Patch_CougarManager_Update_ForceActivate),
            "Prefix", null, () => CheatState.CougarInstantActivate),
        Spec(typeof(Il2CppTLD.AI.CougarManager), "UpdateWaitingForArrival", typeof(Patch_CougarManager_UpdateWaitingForArrival),
            "Prefix", null, () => CheatState.CougarInstantActivate),
        // 雪橇越过移动限制(UniversalTweaks 原版功能,拖雪橇时每帧调)
        Spec(typeof(Il2CppTLD.BigCarry.TravoisMovement), "CheckMovementRestriction", typeof(Patch_UT_TravoisMovementRestriction),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.UT_TravoisOverrideMovement),
#endif
        Spec(typeof(Panel_BreakDown), "Update", typeof(Patch_BreakDown_Update_Edge),
            null, "Postfix", () => CheatState.QuickBreakDown || CheatState.QuickAction,
            () => !BreakDownCleanup.Armed),
#if !STORY_EDITION
        Spec(typeof(CheatDeathAffliction), "Update", typeof(Patch_CheatDeathAfflict_Update),
            "Prefix", null, () => CheatState.ClearDeathPenalty),
#endif

        Spec(typeof(GearItem), "WearOut", typeof(Patch_GearItem_WearOut),
            "Prefix", null, () => CheatState.InfiniteDurability),
        Spec(typeof(GearItem), "DegradeOnUse", typeof(Patch_GearItem_DegradeOnUse),
            "Prefix", null, () => CheatState.InfiniteDurability),

        Spec(typeof(ClothingItem), "IncreaseWetnessPercent", typeof(Patch_Clothing_IncreaseWet),
            "Prefix", null, () => CheatState.NoWetClothes, null, OneFloat),
        Spec(typeof(ClothingItem), "MaybeGetWetOnGround", typeof(Patch_Clothing_GetWetOnGround),
            "Prefix", null, () => CheatState.NoWetClothes, null, OneFloat),

        Spec(typeof(Lock), "IsLocked", typeof(Patch_Lock_IsLocked),
            null, "Postfix", () => CheatState.IgnoreLock),
#if !STORY_EDITION
        Spec(typeof(LockedInteraction), "IsLocked", typeof(Patch_LockedInteraction_IsLocked_Unlock),
            null, "Postfix", () => CheatState.UnlockSafes || CheatState.IgnoreLock),
#endif
        Spec(typeof(BodyHarvest), "MaybeFreeze", typeof(Patch_BodyHarvest_MaybeFreeze),
            "Prefix", null, () => CheatState.QuickHarvest),
        // 鹿出肉量倍率(只在鹿倍率≠1 时挂载;新鲜击杀 roll 初始肉量时乘)
        Spec(typeof(BodyHarvest), "InitializeResourcesAndConditions", typeof(Patch_DeerMeatYield),
            null, "Postfix", () => MeatState.Enabled()),
#if !STORY_EDITION
        // 2.24 里煤油灯类型在全局命名空间(无 Il2CppTLD.Gear),这三条 Spec 的 typeof 会解析失败。
        // 剧情模式没有煤油灯相关设定项,直接排除。
        Spec(typeof(Il2CppTLD.Gear.KeroseneLampItem), "ReduceFuel", typeof(Patch_KeroseneLamp_ReduceFuel),
            "Prefix", null, () => CheatState.LampFuelNoDrain
                || (ModMain.Settings != null && (Mathf.Abs(ModMain.Settings.LampPlacedBurnMult - 1f) >= 0.01f
                                              || Mathf.Abs(ModMain.Settings.LampHeldBurnMult - 1f) >= 0.01f
                                              || ModMain.Settings.LampConditionThreshold > 0)), null, OneFloat),
        Spec(typeof(Il2CppTLD.Gear.KeroseneLampItem), "OnIgniteComplete", typeof(Patch_KeroseneLamp_OnIgnite),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.LampTurnOnDecay >= 0.001f),
        Spec(typeof(Il2CppTLD.Gear.KeroseneLampItem), "Update", typeof(Patch_KeroseneLamp_LightRange),
            null, "Postfix", () => ModMain.Settings != null && (Mathf.Abs(ModMain.Settings.LampRangeMultiplier - 1f) >= 0.01f
                                                             || ModMain.Settings.LampOverTimeDecay >= 0.001f
                                                             || ModMain.Settings.LampMute || CheatState.LampMute),
            Patch_KeroseneLamp_LightRange.RestoreDone),
#endif
        Spec(typeof(GunItem), "RemoveNextFromClip", typeof(Patch_Gun_RemoveNextFromClip),
            "Prefix", null, () => CheatState.InfiniteAmmo),

#if !STORY_EDITION   // 2.24 无保温瓶(Il2CppTLD.Gear.InsulatedFlask*)
        Spec(typeof(Il2CppTLD.Gear.InsulatedFlask), "CalculateHeatLoss", typeof(Patch_Flask_CalcHeatLoss),
            "Prefix", null, () => CheatState.FlaskNoHeatLoss),
        Spec(typeof(Il2CppTLD.Gear.InsulatedFlask), "UpdateVolume", typeof(Patch_Flask_UpdateVolume),
            "Prefix", null, () => CheatState.FlaskInfiniteVol),
        // FlaskAnyItem: NOP 处理 IsItemCompatibleWithFlask 内部调用, Harmony 处理 UI + 外部类型检查
        Spec(typeof(Panel_InsulatedFlask), "IsCompatibleDrink", typeof(Patch_Flask_IsCompatibleDrink),
            null, "Postfix", () => CheatState.FlaskAnyItem, null, OneGearItem),
        Spec(typeof(Il2CppTLD.Gear.InsulatedFlaskLiquidTypeConstraint), "IsAllowed", typeof(Patch_Flask_ForceTrue),
            null, "Postfix", () => CheatState.FlaskAnyItem, null, OneGearItem),
        Spec(typeof(Il2CppTLD.Gear.InsulatedFlask), "IsItemCompatibleWithFlask", typeof(Patch_Flask_ForceTrue),
            null, "Postfix", () => CheatState.FlaskAnyItem, null, OneGearItem),

        // v6.8.4 改 StartCrafting Postfix(原 Update Prefix 在 toggle OFF 中途切时
        // m_RealTimeDuration 残留 0.2f,导致 vanilla 单帧吞光材料 — 见 Patch_CraftingOp_StartCrafting 注释)
        Spec(typeof(CraftingOperation), "StartCrafting", typeof(Patch_CraftingOp_StartCrafting),
            null, "Postfix", () => CheatState.QuickCraft),
#endif
        Spec(typeof(CookingPotItem), "UpdateCookingTimeAndState", typeof(Patch_CookingPot_Update),
            "Prefix", null, () => CheatState.QuickCook || CheatState.NoBurn, null, TwoCookingFloats),
        Spec(typeof(Panel_Crafting), "CraftingEnd", typeof(Patch_Craft_End_ForceBright),
            null, "Postfix", () => CheatState.QuickCraft),
#if STORY_EDITION   // 2.24 叫 HandleCraftingSuccess
        Spec(typeof(Panel_Crafting), "HandleCraftingSuccess", typeof(Patch_Craft_OnSuccess_ArmFade),
            null, "Postfix", () => CheatState.QuickCraft),
#else
        Spec(typeof(Panel_Crafting), "OnCraftingSuccess", typeof(Patch_Craft_OnSuccess_ArmFade),
            null, "Postfix", () => CheatState.QuickCraft),
#endif

        // v2.8.1: 快速修理 — 从 [HarmonyPatch] 属性迁移到 DynamicPatch(IL2CPP 兼容)
        Spec(typeof(Panel_Repair), "StartRepair", typeof(Patch_Repair_StartRepair),
            null, "Postfix", () => CheatState.QuickAction, null, OneIntString),
        // FreeRepair: 无条件修理 — 消耗 skip + 工具不损耗
        Spec(typeof(Panel_Repair), "ConsumeMaterialsUsedForRepair", typeof(Patch_Repair_SkipConsume),
            "Prefix", null, () => CheatState.FreeRepair),
        Spec(typeof(Panel_Repair), "DegradeToolUsedForRepair", typeof(Patch_Repair_SkipToolDegrade),
            "Prefix", null, () => CheatState.FreeRepair),
        Spec(typeof(SafeCracking), "Update", typeof(Patch_SafeCracking_Update),
            null, "Postfix", () => CheatState.UnlockSafes),
#if !STORY_EDITION   // 2.24 无 Il2CppTLD.Interactions(交互系统重构后才有)
        Spec(typeof(Il2CppTLD.Interactions.TimedHoldInteraction), "InitializeInteraction", typeof(Patch_HarvestableInteraction_Init),
            null, "Postfix", () => CheatState.QuickSearch),
        // v2.7.80 BeginHold 承担 snapshot restore 责任 —— cleanup 未完不卸
        Spec(typeof(HarvestableInteraction), "BeginHold", typeof(Patch_HarvestableInteraction_BeginHold),
            null, "Postfix", () => CheatState.QuickSearch,
            () => HarvestableSnaps.Snapshots.Count == 0),
        Spec(typeof(Il2CppTLD.Interactions.TimedHoldInteraction), "UpdateHoldInteraction",
            typeof(Patch_TimedHold_UpdateHoldInteraction_QuickSearch),
            "Prefix", null, () => CheatState.QuickSearch || CheatState.QuickAction,
            // v7.7 加 cleanupDone:留着 patch 直到把改过的实例都还原完(见该类的 Snapshots)
            () => Patch_TimedHold_UpdateHoldInteraction_QuickSearch.Snapshots.Count == 0, OneFloat),
#endif
        Spec(typeof(Panel_BodyHarvest), "Refresh", typeof(Patch_Harvest_Refresh_Quick),
            "Prefix", null, () => CheatState.QuickHarvest,
            () => Patch_Harvest_Refresh_Quick.Snapshots.Count == 0),
        Spec(typeof(Panel_BreakDown), "UpdateDurationLabel", typeof(Patch_BreakDown_UpdateDuration),
            "Prefix", null, () => CheatState.QuickBreakDown || CheatState.QuickAction,
            () => Patch_BreakDown_UpdateDuration.Snapshots.Count == 0 && Patch_BreakDown_UpdateDuration.PanelSecs < 0f),
        Spec(typeof(Panel_BodyHarvest), "StartHarvest", typeof(Patch_Harvest_Start),
            null, "Postfix", () => CheatState.QuickAction, null, OneIntString),
        Spec(typeof(Panel_BodyHarvest), "StartQuarter", typeof(Patch_Harvest_StartQuarter),
            null, "Postfix", () => CheatState.QuickAction, null, OneIntString),
        Spec(typeof(Panel_BreakDown), "OnBreakDown", typeof(Patch_BreakDown_OnBreakDown),
            "Prefix", "Postfix", () => CheatState.QuickBreakDown || CheatState.QuickAction),
        Spec(typeof(Panel_BreakDown), "BreakDownFinished", typeof(Patch_BreakDown_Finished_Unfade),
            null, "Postfix", () => CheatState.QuickBreakDown || CheatState.QuickAction,
            () => !BreakDownCleanup.Armed),
        Spec(typeof(Panel_BreakDown), "ExitInterface", typeof(Patch_BreakDown_ExitInterface_UnlockTOD),
            null, "Postfix", () => CheatState.QuickBreakDown || CheatState.QuickAction,
            () => !BreakDownCleanup.Armed),
        Spec(typeof(Panel_BreakDown), "OnCancel", typeof(Patch_BreakDown_OnCancel_UnlockTOD),
            null, "Postfix", () => CheatState.QuickBreakDown || CheatState.QuickAction,
            () => !BreakDownCleanup.Armed),
        Spec(typeof(Panel_BreakDown), "Enable", typeof(Patch_BreakDown_Enable_Cleanup),
            null, "Postfix", () => CheatState.QuickBreakDown || CheatState.QuickAction,
            () => !BreakDownCleanup.Armed, PanelBreakDownEnableArgs),

        // v2.7.78:把一批原本静态常驻的中/高频 patch 动态化,逻辑不变。
        Spec(typeof(IceCrackingTrigger), "BreakIce", typeof(Patch_IceBreak_BreakIce),
            "Prefix", null, () => CheatState.ThinIceNoBreak),
        Spec(typeof(IceCrackingTrigger), "FallInWater", typeof(Patch_IceBreak_FallInWater),
            "Prefix", null, () => CheatState.ThinIceNoBreak),
#if STORY_EDITION   // 2.24 官方拼写错误:Calclate(少一个 u),2.55 才改对
        Spec(typeof(FireManager), "CalclateFireStartSuccess", typeof(Patch_FireMgr_Success),
            null, "Postfix", () => CheatState.QuickFire),
#else
        Spec(typeof(FireManager), "CalculateFireStartSuccess", typeof(Patch_FireMgr_Success),
            null, "Postfix", () => CheatState.QuickFire),
#endif
#if STORY_EDITION   // 2.24 叫 SetNextCatchTime;patch 只改 m_Min/MaxGameMinutesCatchFish,两版字段名一致
        Spec(typeof(IceFishingHole), "SetNextCatchTime", typeof(Patch_IceFishing_GuaranteedCatch),
            "Prefix", null, () => CheatState.QuickFishing),
#else
        Spec(typeof(IceFishingHole), "RollNextCatch", typeof(Patch_IceFishing_GuaranteedCatch),
            "Prefix", null, () => CheatState.QuickFishing),
#endif
        Spec(typeof(Panel_Container), "EnableAfterDelay", typeof(Patch_Container_EnableAfterDelay),
            "Prefix", null, () => CheatState.QuickOpenContainer, null, OneFloat),
        Spec(typeof(Panel_Container), "Enable", typeof(Patch_Container_Enable),
            null, "Postfix", () => CheatState.QuickOpenContainer || CheatState.InfiniteContainer, null, ContainerEnableArgs),

#if !STORY_EDITION   // 2.24 无 Il2CppTLD.Trader(剧情模式没有商人)
        Spec(typeof(Il2CppTLD.Trader.TraderManager), "GetAvailableTradeExchanges",
            typeof(Patch_TraderManager_GetAvailableTradeExchanges),
            "Prefix", null, () => CheatState.TraderUnlimitedList || CheatState.TraderMaxTrust,
            cleanupDone: Patch_TraderManager_GetAvailableTradeExchanges.RestoreDone),
        // v6.9.6 改为按需挂载(原 () => true):默认 days>=30(≈原版) → 不挂载 → 商人到货完全走原版进度。
        //   玩家把"到来天数"拖到 <30 或开"商人常驻"才挂,且 Postfix 只升不降(见 Patch 内注释)。
        Spec(typeof(Il2CppTLD.Trader.TraderManager), "IsTraderAvailable",
            typeof(Patch_TraderManager_IsTraderAvailable),
            null, "Postfix", () => CheatState.TraderAlwaysAvailable
                || (ModMain.Settings != null && ModMain.Settings.TraderArrivalDays < 30f)),
        Spec(typeof(Il2CppTLD.Trader.TraderRadio), "CanContactTrader",
            typeof(Patch_TraderRadio_CanContactTrader),
            null, "Postfix", () => CheatState.TraderAlwaysAvailable),
        Spec(typeof(Il2CppTLD.Trader.TraderRadio), "IsTraderAvailable",
            typeof(Patch_TraderRadio_IsTraderAvailable),
            null, "Postfix", () => CheatState.TraderAlwaysAvailable),
        Spec(typeof(Il2CppTLD.Trader.ExchangeItem), "IsFullyExchanged",
            typeof(Patch_ExchangeItem_IsFullyExchanged),
            "Prefix", "Postfix", () => CheatState.TraderInstantExchange),
        Spec(typeof(Il2CppTLD.Trader.TraderManager), "CloseTrade",
            typeof(Patch_TraderManager_CloseTrade),
            null, "Postfix", () => CheatState.TraderInstantExchange),
#endif

        // v2.7.89 无后坐力:零化 GunItem 后坐参数(Prefix 归零 + Postfix 恢复)
        Spec(typeof(vp_FPSWeapon), "PlayFireAnimation", typeof(Patch_FPSWeapon_PlayFireAnimation),
            "Prefix", "Postfix", () => CheatState.NoRecoil || CheatStateESP.RecoilScale < 0.99f || CheatStateESP.MagicBullet),
        // 开枪动画甩镜头骨骼的那部分上跳,见 Patch_CameraAnim_NoRecoil
        Spec(typeof(PlayerCameraAnim), "UpdateMainCamera", typeof(Patch_CameraAnim_NoRecoil),
            "Prefix", "Postfix", () => CheatState.NoRecoil || CheatStateESP.RecoilScale < 0.99f),
        // Phase 2 NativeDetour pending — keep Harmony for now
        Spec(typeof(vp_FPSCamera), "Update", typeof(Patch_FPSCamera_ClearRecoil),
            "Prefix", "Postfix", () => CheatState.SuperAccuracy || CheatState.NoAimSway),
        Spec(typeof(vp_FPSCamera), "LateUpdate", typeof(Patch_FPSCamera_LateUpdate),
            null, "Postfix", () => CheatState.SuperAccuracy || CheatState.NoAimSway || (ModMain.Settings != null && ModMain.Settings.GunZoomEnabled)),
        Spec(typeof(vp_FPSShooter), "Fire", typeof(Patch_FPSShooter_Fire),
            "Prefix", "Postfix", () => CheatState.SuperAccuracy),
        Spec(typeof(vp_FPSWeapon), "Update", typeof(Patch_FPSWeapon_SteadyAim),
            "Prefix", "Postfix", () => CheatState.NoAimSway || CheatState.SuperAccuracy),
        // vp_FPSWeapon.LateUpdate 在 IL2CPP 中不存在,已移除
        // vp_FPSWeapon.LateUpdate 在 IL2CPP 中不存在,已移除

        // v2.7.86 新增功能
        Spec(typeof(InputManager), "CanStartFireIndoors", typeof(Patch_FireAnywhere),
            "Prefix", null, () => CheatState.FireAnywhere),
        Spec(typeof(PlayerMovement), "AddSprintStamina", typeof(Patch_AddSprintStamina),
            null, "Postfix", () => Patch_AddSprintStamina.ShouldPatch()),
        Spec(typeof(PlayerManager), "ConsumeUnitFromInventory", typeof(Patch_ConsumeUnit),
            "Prefix", null, () => CheatState.FreeFireFuel || CheatState.FreeRepair),
        Spec(typeof(Encumber), "Update", typeof(Patch_TechBackpack),
            null, "Postfix", () => CheatState.TechBackpack),
        // v6.9.6 原 sentinel=10f 是错的:实测原版 GEAR_Torch m_BurnLifetimeMinutes=90。
        //   90=原版 → 不挂载补丁(火把完全原版行为)。仅当玩家拖高才挂载。
        Spec(typeof(TorchItem), "Update", typeof(Patch_TorchBurnTime),
            "Prefix", null, () => ModMain.Settings != null && Mathf.Abs(ModMain.Settings.TorchBurnMinutes - 90f) > 0.1f),
        Spec(typeof(TorchItem), "Update", typeof(Patch_TorchFullValue),
            "Prefix", null, () => CheatState.TorchFullValue),
        Spec(typeof(WeatherTransition), "ChooseNextWeatherSet", typeof(Patch_WeatherLock),
            "Prefix", null, () => CheatState.WeatherLocked),

        // CT 复刻:无冻伤/饱饱/温度/疲劳
        Spec(typeof(Frostbite), "DealFrostbiteDamageToLocation", typeof(Patch_Frostbite_DealDamage),
            "Prefix", null, () => CheatState.NoFrostbiteRisk || CheatState.GodMode),
        Spec(typeof(Frostbite), "DealFrostbiteDamageToRegion", typeof(Patch_Frostbite_DealDamage),
            "Prefix", null, () => CheatState.NoFrostbiteRisk || CheatState.GodMode),
        Spec(typeof(Frostbite), "FrostbiteStart", typeof(Patch_Frostbite_DealDamage),
            "Prefix", null, () => CheatState.NoFrostbiteRisk || CheatState.GodMode),

        // v9.6 无敌之前只拦了失温、扭伤、出血、感染,其余伤病照样会挂上(扣血被总闸挡了,但降血量上限、减负重、画面特效照常)
        Spec(typeof(Burns), "BurnsStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(BurnsElectric), "BurnsElectricStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(BrokenRib), "BrokenRibStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(CabinFever), "CabinFeverStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(IntestinalParasites), "IntestinalParasitesStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(InfectionRisk), "InfectionRiskStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(InfectionRisk), "ConstantInfectionRiskStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(FoodPoisoning), "FoodPoisoningStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(Dysentery), "DysenteryStart", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(ToxicFog), "StartAffliction", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(Anxiety), "StartAffliction", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(Fear), "StartAffliction", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(Suffocating), "StartSuffocating", typeof(Patch_NoSuffocating_Start), "Prefix", null, () => CheatState.GodMode || CheatState.NoSuffocating),
#if !STORY_EDITION
        // 2.24 没有撕裂伤、化学中毒、失眠
        Spec(typeof(SevereLacerations), "ApplySevereLacerations", typeof(Patch_SevereLacerations_Apply), "Prefix", null, () => CheatState.GodMode || CheatState.ImmuneAnimalDamage),
        Spec(typeof(ChemicalPoisoning), "AddToxicity", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(ChemicalPoisoning), "SpawnAfflictionInstance", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
        Spec(typeof(Il2CppTLD.Gameplay.Condition.InsomniaManager), "ApplyInsomniaAffliction", typeof(Patch_GodMode_BlockAffliction), "Prefix", null, () => CheatState.GodMode),
#endif
        Spec(typeof(WellFed), "Update", typeof(Patch_WellFed_Update),
            "Prefix", null, () => CheatState.WellFedBuff),
        Spec(typeof(PlayerManager), "FreezingBuffActive", typeof(Patch_PlayerManager_FreezingBuffActive),
            null, "Postfix", () => CheatState.FreezingBuff),
        Spec(typeof(PlayerManager), "FatigueBuffActive", typeof(Patch_PlayerManager_FatigueBuffActive),
            null, "Postfix", () => CheatState.FatigueBuff),

        // 整合 SonicMode:速度倍率(仅 SpeedTweaks 开启时挂载)
        Spec(typeof(vp_FPSController), "GetSlopeMultiplier", typeof(Patch_SpeedMultiplier),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.SpeedTweaksEnabled),
        // v2.7.88 体力恢复改为 ModMain.OnUpdate 主动 ApplyTick (Harmony hook 在此类不可靠),不再注册 Spec

#if !STORY_EDITION
        // 整合 TorchTweaker:火把 condition(两个面板都 patch,覆盖所有交互入口)
        // 2.24 Panel_FeedFire 无 m_Min/MaxNormalizedTorchCondition(取火把品质范围是 2.24 之后加的),
        // 两个 patch 类连同这两条 Spec 一起排除。
        Spec(typeof(Panel_FeedFire), "Enable", typeof(Patch_TorchCondition),
            null, "Postfix", () => ModMain.Settings != null && (ModMain.Settings.TorchMinCondition != 0.6f || ModMain.Settings.TorchMaxCondition != 0.9f)),
        Spec(typeof(Panel_ActionPicker), "Enable", typeof(Patch_TorchCondition_ActionPicker),
            null, "Postfix", () => ModMain.Settings != null && (ModMain.Settings.TorchMinCondition != 0.6f || ModMain.Settings.TorchMaxCondition != 0.9f)),
#endif

        // 整合 GearDecayModifier:物品衰减倍率(仅在有衰减修改/无限耐久时挂载)
        // 睡袋不用另挂 Bed.Degrade:反汇编确认 Bed.Degrade 内部就是调 m_Bedroll 的 GearItem.Degrade,
        //   两边都挂会把睡袋倍率和总倍率各乘两遍。
        Spec(typeof(GearItem), "Degrade", typeof(Patch_GearDegrade),
            "Prefix", null, () => CheatState.InfiniteDurability || DecayState.HasNonDefaultMultiplier(), null, OneFloat),

        // 整合 PauseInJournal: 开日志暂停
        // v7.7 cleanupDone:开关关掉时若时间还冻在 0,补丁必须留着,等玩家关日志那次
        //   Enable(false) 把 m_GlobalTimeScale 写回 1 才允许卸载。
        Spec(typeof(Panel_Log), "Enable", typeof(Patch_PanelLog_Pause),
            null, "Postfix", () => CheatState.PauseInJournal,
            cleanupDone: () => !PauseInJournalState.IsPaused),

        // 整合 SkipIntroRedux: 跳过开场
        Spec(typeof(Panel_Boot), "Update", typeof(Patch_PanelBoot_SkipIntro),
            null, "Postfix", () => CheatState.SkipIntro),
        Spec(typeof(Panel_MainMenu), "Enable", typeof(Patch_PanelMainMenu_SkipIntro),
            "Prefix", null, () => CheatState.SkipIntro),
#if !STORY_EDITION   // 2.24 无 NewsCarousel(主菜单新闻轮播)
        Spec(typeof(NewsCarousel), "Awake", typeof(Patch_NewsCarousel_Hide),
            null, "Postfix", () => CheatState.SkipIntro),
#endif

        // 整合 VehicleFov + FreeLook: 车内FOV/视角
        Spec(typeof(PlayerInVehicle), "EnterVehicle", typeof(Patch_VehicleFov_Enter),
            null, "Postfix", () => CheatState.VehicleKeepFov || CheatState.VehicleFreeLook),
        Spec(typeof(PlayerInVehicle), "EnterVehicle", typeof(Patch_Vehicle_FreeLook),
            null, "Postfix", () => CheatState.VehicleFreeLook),

        // 整合 DroppableUndroppables: 允许丢弃不可丢物品
        // v7.7 挂载条件补上 AllNote / ImportantWeight:这个 Postfix 同时负责三件事,
        //   原先只看 DroppableUndroppables → 单开「收藏品可丢弃」或关掉「关键物品保留重量」时
        //   patch 根本不挂,开关是死的。
        Spec(typeof(GearItem), "Awake", typeof(Patch_GearItem_Awake_Droppable),
            null, "Postfix", () => CheatState.DroppableUndroppables
                                || (ModMain.Settings != null
                                    && (ModMain.Settings.AllNote || !ModMain.Settings.ImportantWeight))),

        // 整合 RememberBreakDownItem: 记忆拆解工具
        Spec(typeof(Panel_BreakDown), "Enable", typeof(Patch_BreakDown_RememberTool_Enable),
            null, "Postfix", () => CheatState.RememberBreakdownTool, null, new[] { typeof(bool) }),
        Spec(typeof(Panel_BreakDown), "OnBreakDown", typeof(Patch_BreakDown_RememberTool_OnBreakDown),
            "Prefix", null, () => CheatState.RememberBreakdownTool),

        // 整合 ExtraGraphicsSettings: 准星
        Spec(typeof(HUDManager), "UpdateCrosshair", typeof(Patch_Crosshair_Show),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.CrosshairEnabled),

        // 整合 StretchArmstrong:交互距离倍率(1.0 = 原版,不挂载)
        Spec(typeof(PlayerManager), "ComputeModifiedPickupRange", typeof(Patch_PickupRange),
            null, "Postfix", () => ModMain.Settings != null && Mathf.Abs(ModMain.Settings.PickupRange - 1f) >= 0.01f),

        // 整合 SilentWalker:脚步静音 — PlayFootStepSound 有两个重载必须分别 patch
        Spec(typeof(FootStepSounds), "PlayFootStepSound", typeof(Patch_SilentFootsteps),
            "Prefix", null, () => CheatState.SilentFootsteps, null, FootStepArgs2),
        Spec(typeof(FootStepSounds), "PlayFootStepSound", typeof(Patch_SilentFootsteps_3p),
            "Prefix", null, () => CheatState.SilentFootsteps, null, FootStepArgs3),
        // 整合 SilentWalker:背包物品声音音量(仅调过音量时挂载)
        Spec(typeof(GameAudioManager), "SetRTPCValue", typeof(Patch_SilentWalker_RTPC),
            "Prefix", null, () => ModMain.Settings != null && (ModMain.Settings.InvWeightMetalVol != 100 || ModMain.Settings.InvWeightWoodVol != 100 || ModMain.Settings.InvWeightWaterVol != 100 || ModMain.Settings.InvWeightGeneralVol != 100), null, RTPCArgs),

        // 整合 RunWithLantern:拿油灯可跑步
        Spec(typeof(GameManager), "IsMovementLockedBecauseOfLantern", typeof(Patch_RunWithLantern),
            "Prefix", null, () => CheatState.RunWithLantern),
        Spec(typeof(CameraOverride), "OnStateUpdate", typeof(Patch_CameraOverride_OnStateUpdate),
            "Prefix", null, () => CheatState.RunWithLantern, null, AnimStateArgs),
        Spec(typeof(CameraOverride), "OnStateEnter", typeof(Patch_CameraOverride_OnStateEnter),
            "Prefix", null, () => CheatState.RunWithLantern, null, AnimStateArgs),

        // 整合 FullSwing:开门角度/速度(仅非默认值时挂载)
        Spec(typeof(ObjectAnim), "Play", typeof(Patch_ObjectAnim_Play),
            "Prefix", null, () => ModMain.Settings != null && (Mathf.Abs(ModMain.Settings.DoorSwingAngle - 0.29f) >= 0.01f || Mathf.Abs(ModMain.Settings.DoorSwingSpeed - 0.53f) >= 0.01f), null, OneString),

        // 整合 DisableAutoEquipCharcoal:取炭不装备
        Spec(typeof(Panel_FireStart), "OnCharcoalHarvest", typeof(Patch_CharcoalHarvest_NoEquip),
            "Prefix", null, () => CheatState.NoAutoEquipCharcoal),
        Spec(typeof(Panel_ActionPicker), "TakeCharcoalCallback", typeof(Patch_CharcoalHarvest_NoEquip),
            "Prefix", null, () => CheatState.NoAutoEquipCharcoal),
        Spec(typeof(PlayerManager), "EquipItem", typeof(Patch_Charcoal_BlockEquip),
            "Prefix", null, () => CheatState.NoAutoEquipCharcoal, null, GearItemBool),

        // 整合 AutoToggleLights:休息自动熄灯
        Spec(typeof(PassTime), "Begin", typeof(Patch_AutoExtinguish_PassTime),
            null, "Postfix", () => CheatState.AutoExtinguishOnRest),
        Spec(typeof(Panel_Rest), "OnRest", typeof(Patch_AutoExtinguish_OnRest),
            null, "Postfix", () => CheatState.AutoExtinguishOnRest),

        // 整合 TorchTweaker: 防误灭
        Spec(typeof(TorchItem), "ExtinguishDelayed", typeof(Patch_TorchExtinguish_Block),
            "Prefix", null, () => CheatState.DisableTorchLeftClick),
        Spec(typeof(KeroseneLampItem), "Toggle", typeof(Patch_LampToggle_Block),
            "Prefix", null, () => CheatState.DisableLampLeftClick),

        // 整合 Sprainkle: 扭伤参数实时覆写
        Spec(typeof(Sprains), "Update", typeof(Patch_Sprains_Update),
            null, "Postfix", () => CheatState.World_Sprainkle, Patch_Sprains_Update.RestoreDone),
        Spec(typeof(SprainedAnkle), "SprainedAnkleStart", typeof(Patch_SprainedAnkle_Sprainkle),
            null, "Postfix", () => CheatState.World_Sprainkle),
        Spec(typeof(SprainedWrist), "SprainedWristStart", typeof(Patch_SprainedWrist_Sprainkle),
            null, "Postfix", () => CheatState.World_Sprainkle),

#if !STORY_EDITION   // 2.24 无 FireplaceInteraction / CookingSlot.m_FireplaceHost
        // 整合 MoreCookingSlots: 增加烹饪槽位
        Spec(typeof(WoodStove), "Awake", typeof(Patch_WoodStove_Awake_CookingSlots),
            null, "Postfix", () => CheatState.Craft_MoreCookingSlots),
#endif


#if !STORY_EDITION   // 2.24 无 Il2CppTLD.Gear.BlueprintData
        // 整合 CraftAnywhere: 制作位置覆写(hook Panel_Crafting.ItemPassesFilter, 非 BlueprintData.Awake)
        Spec(typeof(Panel_Crafting), "ItemPassesFilter", typeof(Patch_CraftAnywhere),
            "Prefix", "Postfix", () => CheatState.Craft_Anywhere, null, new[] { typeof(BlueprintData) }),
        // 同上第二道闸:位置检查本身放行(列表可见 ≠ 能按下制作)
        Spec(typeof(BlueprintData), "CanCraftAtLocation", typeof(Patch_CraftAnywhere_Location),
            null, "Postfix", () => CheatState.Craft_Anywhere, null, new[] { typeof(CraftingLocation) }),
#endif

        // 整合 CaffeinatedSodas: 苏打水加减疲劳 buff
        Spec(typeof(GearItem), "Awake", typeof(Patch_GearItem_Awake_CaffeinatedSodas),
            null, "Postfix", () => CheatState.World_CaffeinatedSodas),

        // 整合 BowRepair: 弓添加 Repairable/Millable 组件
        Spec(typeof(GearItem), "Awake", typeof(Patch_GearItem_Awake_BowRepair),
            null, "Postfix", () => CheatState.World_BowRepair),

        // 整合 NoSaveOnSprain + v2.8.1 NoFallDamage 阻止扭伤
        // Prefix 尝试 skip + Postfix Cure() 双保险(IL2CPP 可能忽略 Prefix return false)
        Spec(typeof(SprainedAnkle), "SprainedAnkleStart", typeof(Patch_NoSaveOnSprain_Ankle),
            "Prefix", "Postfix", () => CheatState.QoL_NoSaveOnSprain || CheatState.NoFallDamage),
        Spec(typeof(SprainedWrist), "SprainedWristStart", typeof(Patch_NoSaveOnSprain_Wrist),
            "Prefix", "Postfix", () => CheatState.QoL_NoSaveOnSprain || CheatState.NoFallDamage),

        // 整合 MapTextOutline: 地图文字描边
        Spec(typeof(Panel_Map), "CreateObjectPools", typeof(Patch_MapTextOutline),
            null, "Postfix", () => CheatState.QoL_MapTextOutline),
#if !STORY_EDITION
        // v9.7 整合地图管理(MapManagerPatches.cs)
        Spec(typeof(Panel_Map), "Enable", typeof(Patch_MapM_MapEnable),
            null, "Postfix", () => MapM.MapOpen, null, new[] { typeof(bool), typeof(bool) }),
        Spec(typeof(Panel_Map), "DoNearbyDetailsCheck", typeof(Patch_MapM_NearbyCheck),
            "Prefix", null, () => MapM.Survey),
        Spec(typeof(CharcoalItem), "Awake", typeof(Patch_MapM_SurveyMinutes),
            null, "Postfix", () => MapM.SurveyTime),
        Spec(typeof(CharcoalItem), "HasSurveyVisibility", typeof(Patch_MapM_SurveyVisibility),
            null, "Postfix", () => MapM.UnlockSurvey),
        Spec(typeof(VistaLocation), "HasRequiredGearItem", typeof(Patch_MapM_VistaPolaroid),
            null, "Postfix", () => MapM.VistaNoPolaroid),
        Spec(typeof(Panel_Map), "RevealOnPolaroidDiscovery", typeof(Patch_MapM_PolaroidReveal),
            "Prefix", null, () => MapM.VistaNoPolaroid),
        Spec(typeof(BaseAi), "EnterDead", typeof(Patch_MapM_CorpseOnMap),
            null, "Postfix", () => MapM.Corpse),
        Spec(typeof(BodyHarvest), "BodyHarvestDestroy", typeof(Patch_MapM_CorpseDestroy),
            "Prefix", null, () => MapM.Corpse),
        Spec(typeof(MapDetail), "Surveyed", typeof(Patch_MapM_DetailSurveyed),
            null, "Postfix", () => MapM.HideHarvested),
        Spec(typeof(MapDetail), "Unlock", typeof(Patch_MapM_DetailUnlock),
            null, "Postfix", () => MapM.HideHarvested),
        Spec(typeof(Il2CppTLD.Gameplay.BunkerDistributor), "DistributeBunkerInteriors", typeof(Patch_MapM_BunkerDistribute),
            null, "Postfix", () => MapM.FillBunkers),
        Spec(typeof(Il2CppTLD.Gameplay.BunkerDistributor), "Deserialize", typeof(Patch_MapM_BunkerDeserialize),
            null, "Postfix", () => MapM.FillBunkers),
        Spec(typeof(Il2CppTLD.Gameplay.BunkerDistributor), "Serialize", typeof(Patch_MapM_BunkerSerialize),
            null, "Postfix", () => MapM.FillBunkers, cleanupDone: Patch_MapM_BunkerDistribute.RestoreDone),
        Spec(typeof(RandomSpawnObject), "ActivateRandomObject", typeof(Patch_MapM_InterloperHatch),
            "Prefix", null, () => MapM.InterloperBunker),
        Spec(typeof(SnareItem), "DoRoll", typeof(Patch_CE_SnareRoll), "Prefix", "Postfix", () => CeX.SnareSure),
        Spec(typeof(SnareItem), "Update", typeof(Patch_CE_SnareUpdate), "Prefix", null, () => CeX.SnareInstant),
        Spec(typeof(SnareItem), "SkipCheckDueToPlayerProximity", typeof(Patch_CE_SnareProximity), null, "Postfix", () => CeX.SnareInstant),
        Spec(typeof(IceFishingHole), "SetNormalizedFrozen", typeof(Patch_CE_IceHoleFrozen), "Prefix", null, () => CeX.IceHoleNoFreeze, null, OneFloat),
        Spec(typeof(IceFishingHole), "PerformInteraction", typeof(Patch_CE_IceHoleInteract), "Prefix", null, () => CeX.IceHoleNoFreeze),
        Spec(typeof(Il2CppTLD.Gameplay.MiseryManager), "ApplyMiseryAffliction", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(WeakConstitution), "ApplyWeakConstitution", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(UnsettledSleep), "ApplyUnsettledSleep", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(WeakJoints), "ApplyWeakJoints", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(PoorCirculation), "ApplyPoorCirculation", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(SourStomach), "ApplySourStomach", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(BrokenBody), "ApplyBrokenBody", typeof(Patch_CE_MiseryBlock), "Prefix", null, () => CeX.NoMisery),
        Spec(typeof(Condition), "PlayerDeath", typeof(Patch_CE_DeathEntry), "Prefix", null, () => CeX.NoDeath, null, OneString),
        Spec(typeof(GameManager), "HandlePlayerDeath", typeof(Patch_CE_DeathEntry), "Prefix", null, () => CeX.NoDeath, null, OneString),
        Spec(typeof(PlayerStruggle), "Update", typeof(Patch_CE_StruggleUpdate), null, "Postfix", () => CeX.StruggleWin || CeX.NoStun, cleanupDone: Patch_CE_StruggleUpdate.RestoreDone),
        Spec(typeof(PlayerStruggle), "ApplyBearDamageAfflictions", typeof(Patch_CE_StruggleSkip), "Prefix", null, () => CeX.StruggleWin),
        Spec(typeof(PlayerStruggle), "ApplyCougarDamageAfflictions", typeof(Patch_CE_StruggleSkip), "Prefix", null, () => CeX.StruggleWin),
        Spec(typeof(PlayerStruggle), "ApplyDamageAfterMooseAttack", typeof(Patch_CE_StruggleSkip), "Prefix", null, () => CeX.StruggleWin, null, OneString),
        Spec(typeof(PlayerStruggle), "OnPlayerDazed", typeof(Patch_CE_NoStunSkip), "Prefix", null, () => CeX.NoStun),
        Spec(typeof(PlayerStruggle), "GetStunnedDurationFromParter", typeof(Patch_CE_StunDuration), null, "Postfix", () => CeX.NoStun),
        Spec(typeof(PlayerStruggle), "CanBeStunned", typeof(Patch_CE_CanBeStunned), null, "Postfix", () => CeX.NoStun),
        Spec(typeof(vp_FPSController), "GetSlopeMultiplier", typeof(Patch_CE_SlopeMult), null, "Postfix", () => CeX.NoSlide),
        Spec(typeof(Container), "PopulateWithRandomGear", typeof(Patch_CE_LootRandomGear), "Prefix", "Postfix", () => CeX.LootNoEmpty || CeX.LootLowerTier),
        Spec(typeof(Container), "BeginContainerClose", typeof(Patch_CE_AuroraRefill), null, "Postfix", () => CeX.AuroraRefill),
        Spec(typeof(Il2CppTLD.Trader.TraderManager), "get_UseCheapPrices", typeof(Patch_CE_TraderCheap), null, "Postfix", () => CeX.TraderCheap),
        Spec(typeof(Il2CppTLD.ModularElectrolizer.AuroraModularElectrolizer), "UpdateIntensity", typeof(Patch_CE_AuroraLight), "Prefix", null, () => CeX.AuroraLightSteady, null, TwoCookingFloats),
        Spec(typeof(AuroraManager), "UpdateAuroraAudio", typeof(Patch_CE_AuroraAudio), "Prefix", null, () => CeX.AuroraMute),
#if !EP5_EDITION
        Spec(typeof(Panel_Map), "Enable", typeof(Patch_Coll_MapEnable),
            null, "Postfix", () => CollMap.On, null, new[] { typeof(bool), typeof(bool) }),
        Spec(typeof(Panel_Map), "LoadMapElementsForScene", typeof(Patch_Coll_LoadElements),
            null, "Postfix", () => CollMap.On),
#endif
#endif

        // 整合 WakeUpCall: 睡眠唤醒+极光+时间+微光
        Spec(typeof(Rest), "BeginSleeping", typeof(Patch_WakeUpCall_BeginSleeping),
            "Prefix", null, () => CheatState.QoL_WakeUpCall || CheatState.QoL_AuroraSense, null, BeginSleepArgs),
#if STORY_EDITION   // 2.24 极光强度推进在 UpdateActivation 里;patch 只读 IsFullyActive(),语义相同
        Spec(typeof(AuroraManager), "UpdateActivation", typeof(Patch_WakeUpCall_AuroraWake),
            null, "Postfix", () => CheatState.QoL_AuroraSense),
#else
        Spec(typeof(AuroraManager), "UpdateAuroraValue", typeof(Patch_WakeUpCall_AuroraWake),
            null, "Postfix", () => CheatState.QoL_AuroraSense),
#endif
        Spec(typeof(InterfaceManager), "SetTimeWidgetActive", typeof(Patch_WakeUpCall_TimeWidget),
            "Prefix", null, () => CheatState.QoL_ShowTimeSleep, null, OneBool),
        Spec(typeof(Panel_Rest), "Enable", typeof(Patch_WakeUpCall_RestEnable),
            null, "Postfix", () => CheatState.QoL_NoPitchBlack, null, TwoBool),

        // 整合 RnStripped-CarcassMoving: 搬运猎物
        Spec(typeof(Panel_BodyHarvest), "CanEnable", typeof(Patch_Carcass_CanEnable),
            null, "Postfix", () => CheatState.World_CarcassMoving, null, new[] { typeof(BodyHarvest) }),
        Spec(typeof(Panel_BodyHarvest), "Enable", typeof(Patch_Carcass_PanelEnable),
            null, "Postfix", () => CheatState.World_CarcassMoving, null, BodyHarvestEnableArgs),
        Spec(typeof(GameManager), "SetAudioModeForLoadedScene", typeof(Patch_Carcass_SceneLoaded),
            null, "Postfix", () => CheatState.World_CarcassMoving),
        // 2.24 LoadScene.Activate 只有无参重载(2.55 才多出 (bool));Postfix 本身不取参数。
        Spec(typeof(LoadScene), "Activate", typeof(Patch_Carcass_LoadScene),
#if STORY_EDITION
            null, "Postfix", () => CheatState.World_CarcassMoving, null, System.Type.EmptyTypes),
#else
            null, "Postfix", () => CheatState.World_CarcassMoving, null, OneBool),
#endif
        Spec(typeof(GameManager), "TriggerSurvivalSaveAndDisplayHUDMessage", typeof(Patch_Carcass_BeforeSave),
            "Prefix", null, () => CheatState.World_CarcassMoving),
        Spec(typeof(PlayerManager), "PlayerCanSprint", typeof(Patch_Carcass_NoSprint),
            null, "Postfix", () => CheatState.World_CarcassMoving),
        Spec(typeof(PlayerManager), "EquipItem", typeof(Patch_Carcass_NoEquip),
            "Prefix", null, () => CheatState.World_CarcassMoving, null, GearItemBool),
        Spec(typeof(Fatigue), "CalculateFatigueIncrease", typeof(Patch_Carcass_Fatigue),
            null, "Postfix", () => CheatState.World_CarcassMoving, null, OneFloat),
        Spec(typeof(PlayerManager), "CalculateModifiedCalorieBurnRate", typeof(Patch_Carcass_Calorie),
            null, "Postfix", () => CheatState.World_CarcassMoving || CheatState.TechBackpack, null, OneFloat),
        Spec(typeof(Inventory), "GetExtraScentIntensity", typeof(Patch_Carcass_Scent),
            null, "Postfix", () => CheatState.World_CarcassMoving),
        Spec(typeof(RopeClimbPoint), "OnRopeTransition", typeof(Patch_Carcass_RopeDrop),
            null, "Postfix", () => CheatState.World_CarcassMoving, null, OneBool),

#if !STORY_EDITION   // 2.24 无 SimpleInteraction / BaseInteraction
        // 整合 RnStripped-ElectricTorchLighting: 极光电点火把
        Spec(typeof(MissionServicesManager), "RegisterAnyMissionObjects", typeof(Patch_ElectricTorch_SceneInit),
            null, "Postfix", () => CheatState.World_ElectricTorch),
        Spec(typeof(PlayerManager), "InteractiveObjectsProcessInteraction", typeof(Patch_ElectricTorch_Interact),
            null, "Postfix", () => CheatState.World_ElectricTorch),
        Spec(typeof(DamageTrigger), "ApplyOneTimeDamage", typeof(Patch_ElectricTorch_NoDamage),
            "Prefix", null, () => CheatState.World_ElectricTorch, null, GameObjectFloat),
        Spec(typeof(DamageTrigger), "ApplyContinuousDamage", typeof(Patch_ElectricTorch_NoDamageCont),
            "Prefix", null, () => CheatState.World_ElectricTorch, null, GameObjectFloat),
        Spec(typeof(DamageTrigger), "OnTriggerExit", typeof(Patch_ElectricTorch_TriggerExit),
            "Prefix", null, () => CheatState.World_ElectricTorch),
        Spec(typeof(PlayerManager), "GetInteractiveObjectUnderCrosshairs", typeof(Patch_ElectricTorch_Crosshair),
            null, "Postfix", () => CheatState.World_ElectricTorch, null, OneFloat),
#endif

        // 整合 TinyTweaks-BuryHumanCorpses: Alt交互埋葬尸体
        Spec(typeof(InputManager), "ExecuteAltFire", typeof(Patch_BuryCorpses_AltFire),
            "Prefix", null, () => CheatState.QoL_BuryCorpses),
        Spec(typeof(Panel_HUD), "SetHoverText", typeof(Patch_BuryCorpses_HoverText),
            "Prefix", null, () => CheatState.QoL_BuryCorpses),
        Spec(typeof(Panel_GenericProgressBar), "ProgressBarEnded", typeof(Patch_BuryCorpses_ProgressBarEnded),
            "Prefix", null, () => CheatState.QoL_BuryCorpses),
        Spec(typeof(SaveGameSystem), "SaveSceneData", typeof(Patch_BuryCorpses_SaveScene),
            "Prefix", null, () => CheatState.QoL_BuryCorpses),
        Spec(typeof(SaveGameSystem), "LoadSceneData", typeof(Patch_BuryCorpses_LoadScene),
            null, "Postfix", () => CheatState.QoL_BuryCorpses),

        // 整合 SleepWithoutABed: 无床睡觉
        Spec(typeof(Panel_Rest), "Enable", typeof(Patch_SleepAnywhere_RestEnable),
            "Prefix", null, () => CheatState.QoL_SleepAnywhere, null, TwoBool),
        Spec(typeof(Panel_ActionsRadial), "DoPassTime", typeof(Patch_SleepAnywhere_RadialPassTime),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),
        Spec(typeof(Panel_Rest), "UpdateButtonLegend", typeof(Patch_SleepAnywhere_ButtonLegend),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),
        Spec(typeof(Panel_Rest), "OnRest", typeof(Patch_SleepAnywhere_OnRest),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),
        Spec(typeof(Rest), "UpdateWhenSleeping", typeof(Patch_SleepAnywhere_ConditionRecovery),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),
        Spec(typeof(Rest), "UpdateWhenSleeping", typeof(Patch_SleepAnywhere_SleepInterruption),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),
        // v7.7 加 cleanupDone:临时床卷还挂在场景里时不能卸载,否则没人销毁它(见该类注释)
        Spec(typeof(Rest), "EndSleeping", typeof(Patch_SleepAnywhere_EndSleeping),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere,
            () => SleepAnywhereState.TempBedroll == null, OneBool),
        Spec(typeof(Panel_Rest), "OnPassTime", typeof(Patch_SleepAnywhere_PassTimeExposure),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),
        Spec(typeof(PlayerManager), "PlayerIsSleeping", typeof(Patch_SleepAnywhere_RestPanelClose),
            null, "Postfix", () => CheatState.QoL_SleepAnywhere),

        // v2.8.1 Bug 5+6: 睡眠黑屏安全网 — EndSleeping 时强制恢复 HUD
        Spec(typeof(Rest), "EndSleeping", typeof(Patch_WakeUpCall_EndSleeping_Safety),
            null, "Postfix", () => CheatState.QoL_WakeUpCall || CheatState.QoL_AuroraSense, null, OneBool),

        // v2.8.1 Bug 2: 无限容器容量
        Spec(typeof(Container), "Awake", typeof(Patch_Container_Awake_InfiniteCapacity),
            null, "Postfix", () => CheatState.InfiniteContainer),

        // v2.8.1 Bug 3: 无坠落伤害(TLD 2.55 存在的方法)
        Spec(typeof(FallDamage), "MaybeSprainAnkle", typeof(Patch_FallDamage_MaybeApply),
            "Prefix", null, () => CheatState.NoFallDamage),
        Spec(typeof(FallDamage), "MaybeSprainWrist", typeof(Patch_FallDamage_MaybeApply),
            "Prefix", null, () => CheatState.NoFallDamage),
        Spec(typeof(FallDamage), "ApplyClothingDamage", typeof(Patch_FallDamage_ApplyAll),
            "Prefix", "Postfix", () => CheatState.NoFallDamage),

        // v2.8.1 Bug 9: 免费制作材料数量 — 方法在 TLD 2.55 中已移除,由 FreeCraft 其他 patches 覆盖

        // ——— TinyTweaks 整合 ———
        Spec(typeof(Freezing), "CalculateBodyTemperature", typeof(Patch_CapFeelsLikeTemp),
            null, "Postfix", () => CheatState.TT_CapFeelsEnabled),

        Spec(typeof(FallDeathTrigger), "OnTriggerEnter", typeof(Patch_FallDeathTrigger),
            null, "Postfix", () => CheatState.TT_FallDeathGoat),
        Spec(typeof(GameManager), "Awake", typeof(Patch_FallDamageMultiplier),
            null, "Postfix", () => CheatState.TT_FallDeathGoat),

        Spec(typeof(GameManager), "Start", typeof(Patch_DroppedObjectOrientation),
            null, "Postfix", () => CheatState.TT_DroppedOrientation),

        Spec(typeof(Panel_OptionsMenu), "ApplyGraphicsModeAndResolution", typeof(Patch_ExtendedFOV_Apply),
            null, "Postfix", () => CheatState.TT_ExtendedFOV),
        Spec(typeof(Panel_OptionsMenu), "OnDisplayTab", typeof(Patch_ExtendedFOV_Display),
            null, "Postfix", () => CheatState.TT_ExtendedFOV),

        // v7.7 加 cleanupDone:这两个 patch 是 timeScale 的唯一恢复者。轮盘正开着(IsSlowed=true)
        //   时关掉开关,若立刻 Unpatch 就没人把 timeScale 从 0.1 写回 1 → 永久慢速。
        //   等 IsSlowed 落回 false 再卸。
        Spec(typeof(Panel_ActionsRadial), "Enable", typeof(Patch_PauseOnRadial_Enable),
            "Prefix", null, () => CheatState.TT_PauseOnRadial,
            () => !PauseOnRadialState.IsSlowed, new[] { typeof(bool), typeof(bool) }),
        Spec(typeof(GameManager), "Update", typeof(Patch_PauseOnRadial_FoolProof),
            null, "Postfix", () => CheatState.TT_PauseOnRadial,
            () => !PauseOnRadialState.IsSlowed),

        // SpeedyInteractions — 只在任一倍率 != 1 时才挂载(避免 20 个无用 hook 拖 FPS)
        Spec(typeof(PlayerManager), "UseFoodInventoryItem", typeof(Patch_Speedy_Eating),
            "Prefix", "Postfix", () => ModMain.Settings.TT_EatingSpeedMult != 1f),
        Spec(typeof(PlayerManager), "UseSmashableItem", typeof(Patch_Speedy_Smash),
            "Prefix", "Postfix", () => ModMain.Settings.TT_EatingSpeedMult != 1f),
        Spec(typeof(PlayerManager), "DrinkFromWaterSupply", typeof(Patch_Speedy_Drink),
            "Prefix", "Postfix", () => ModMain.Settings.TT_EatingSpeedMult != 1f),
        Spec(typeof(Panel_Inventory_Examine), "OnRefuel", typeof(Patch_Speedy_Refuel),
            "Prefix", "Postfix", () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(PlayerManager), "UseWaterPurificationItem", typeof(Patch_Speedy_Purify),
            "Prefix", "Postfix", () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_Inventory_Examine), "AccelerateTimeOfDay", typeof(Patch_Speedy_Examine),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f || ModMain.Settings.TT_ReadingSpeedMult != 1f),
        Spec(typeof(RockCache), "OnBuild", typeof(Patch_Speedy_RockCacheBuild),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(RockCache), "OnDismantle", typeof(Patch_Speedy_RockCacheDismantle),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_BreakDown), "OnBreakDown", typeof(Patch_Speedy_Breakdown),
            "Prefix", null, () => ModMain.Settings.TT_BreakdownSpeedMult != 1f),
        Spec(typeof(Panel_Crafting), "CraftingStart", typeof(Patch_Speedy_Crafting),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_Cooking), "OnCook", typeof(Patch_Speedy_Cook1),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
#if !STORY_EDITION   // 2.24 无 OnCookRecipe(配方烹饪是后加的);OnCook 那条已由 Cook1 覆盖
        Spec(typeof(Panel_Cooking), "OnCookRecipe", typeof(Patch_Speedy_Cook2),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
#endif
        Spec(typeof(Panel_Milling), "BeginRepair", typeof(Patch_Speedy_Milling),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_SnowShelterBuild), "OnBuild", typeof(Patch_Speedy_SnowShelterBuild),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_SnowShelterInteract), "OnInteractionCommon", typeof(Patch_Speedy_SnowShelterInteract),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_PickWater), "TakeWater", typeof(Patch_Speedy_PickWater),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(Panel_IceFishingHoleClear), "UseTool", typeof(Patch_Speedy_IceFishing),
            "Prefix", null, () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        // IL2CPP 原始名含多余 "d"(DurationdUsed),非 typo
        Spec(typeof(AfflictionDefinition), "GetStandardDurationdUsed", typeof(Patch_Speedy_Affliction1),
            null, "Postfix", () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
        Spec(typeof(AfflictionDefinition), "GetAlternateDurationUsed", typeof(Patch_Speedy_Affliction2),
            null, "Postfix", () => ModMain.Settings.TT_GlobalSpeedMult != 1f),
#if !STORY_EDITION   // 2.24 无 TimedHoldInteraction
        Spec(typeof(TimedHoldInteraction), "BeginHold", typeof(Patch_Speedy_HoldInteraction),
            "Prefix", null, () => ModMain.Settings != null && (ModMain.Settings.TT_InteractionSpeedMult != 1f || CheatState.QuickSearch || Patch_Speedy_HoldInteraction.Data.Count > 0)),
        // v7.7 加 `|| Data.Count > 0`:这是 Data 的唯一清理者,原先它比被保护的 BeginHold spec
        //   先卸载(上面那个 wanted 有 Data.Count > 0,这个没有)→ 字典里的旧 Il2Cpp wrapper
        //   永远留着,跨场景后指向已销毁的原生对象,GetHashCode/Equals 会摸到已释放内存。
        Spec(typeof(GameManager), "ResetLists", typeof(Patch_Speedy_ResetDict),
            null, "Postfix", () => ModMain.Settings.TT_InteractionSpeedMult != 1f || CheatState.QuickSearch
                                || Patch_Speedy_HoldInteraction.Data.Count > 0),
#endif

        // ImprovedFlasks 整合已移除(v6.8.3) —— 原 mod ImprovedFlasks 1.2.3 假设保温瓶里装 GearItem,
        // TLD 2.55 改为液体容器(AddLiquid/RemoveLiquid),GetAllItems 永远返回空,饮用代码全瘫。
        // 删除整合,vanilla Panel_InsulatedFlask UI 仍可用。

        // RespawnablePlants
        Spec(typeof(Harvestable), "Awake", typeof(Patch_RespawnPlants_Awake),
            "Prefix", null, () => CheatState.TT_RespawnPlants),
#if !STORY_EDITION   // 2.24 叫 DoHarvest;但 StoryGuard 已强制 TT_RespawnPlants=false 且
        // patch 体在 STORY 下就是空 return,挂上去纯属浪费,整条排除
        Spec(typeof(Harvestable), "Harvest", typeof(Patch_RespawnPlants_Harvest),
            null, "Postfix", () => CheatState.TT_RespawnPlants),
#endif
        Spec(typeof(Harvestable), "Deserialize", typeof(Patch_RespawnPlants_Deserialize),
            "Prefix", "Postfix", () => CheatState.TT_RespawnPlants),
        Spec(typeof(SaveGameSystem), "SaveSceneData", typeof(Patch_RespawnPlants_Save),
            null, "Postfix", () => CheatState.TT_RespawnPlants),
        Spec(typeof(SaveGameSystem), "LoadSceneData", typeof(Patch_RespawnPlants_Load),
            null, "Postfix", () => CheatState.TT_RespawnPlants),

        // HouseLights
        Spec(typeof(GameManager), "InstantiatePlayerObject", typeof(Patch_HL_GameManager_InstantiatePlayer),
            "Prefix", null, () => CheatState.HL_Enabled),
#if !STORY_EDITION   // 2.24 无 AuroraModularElectrolizer(极光电解器)
        Spec(typeof(AuroraModularElectrolizer), "Initialize", typeof(Patch_HL_Electrolizer_Initialize),
            null, "Postfix", () => CheatState.HL_Enabled),
#endif
        Spec(typeof(AuroraManager), "RegisterAuroraLightSimple", typeof(Patch_HL_AuroraManager_RegisterLightSimple),
            null, "Postfix", () => CheatState.HL_Enabled, null, HLRegisterLightArgs),
        Spec(typeof(AuroraManager), "UpdateForceAurora", typeof(Patch_HL_AuroraManager_UpdateForceAurora),
            null, "Postfix", () => CheatState.HL_Enabled, cleanupDone: HouseLightsState.RestoreAll),
        // 2.24 UpdateHUDText 无参,Panel_HUD 由 patch 自己从 InterfaceManager 取。
        Spec(typeof(PlayerManager), "UpdateHUDText", typeof(Patch_HL_PlayerManager_UpdateHUDText),
#if STORY_EDITION
            null, "Postfix", () => CheatState.HL_Enabled, null, System.Type.EmptyTypes),
#else
            null, "Postfix", () => CheatState.HL_Enabled, null, HLUpdateHUDArgs),
#endif
        Spec(typeof(PlayerManager), "InteractiveObjectsProcessInteraction", typeof(Patch_HL_PlayerManager_ProcessInteraction),
            null, "Postfix", () => CheatState.HL_Enabled),
        Spec(typeof(Weather), "IsTooDarkForAction", typeof(Patch_HL_Weather_IsTooDarkForAction),
            null, "Postfix", () => CheatState.HL_Enabled, null, HLTooDarkArgs),

        // FlashFlicker 已改为 [HarmonyPatch] 属性直接注册(IL2Cpp 下 DynamicPatch Prefix return false 不可靠)

        // v6.1 性能优化: 原常驻 Update patch 迁移到 DynamicPatch,toggle 关时零开销
        Spec(typeof(vp_FPSPlayer), "Update", typeof(Patch_UT_RevolverWalk),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.UT_RevolverImprovements),
        Spec(typeof(Panel_HUD), "Update", typeof(Patch_UT_RevolverUI),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.UT_RevolverImprovements),
        Spec(typeof(WaterSource), "Update", typeof(Patch_UT_ToiletWater),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.UT_ToiletWaterPotable),
        Spec(typeof(FlashlightItem), "Update", typeof(Patch_FlashInfiniteBattery),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.UT_FlashInfiniteBattery),
        // 渲染路径: 每帧 × 每喷漆标记,不开功能时完全卸载
        Spec(typeof(DynamicDecalsManager), "RenderDynamicDecal", typeof(Patch_UT_GlowingDecals),
            "Prefix", null, () => ModMain.Settings != null && ModMain.Settings.UT_GlowingDecals),
        // DoPositionCheck 每帧被游戏调用,功能关时零 trampoline
        Spec(typeof(PlayerManager), "DoPositionCheck", typeof(Patch_PlaceFromInv_PositionCheck),
            null, "Postfix", () => ModMain.Settings != null && ModMain.Settings.PlaceFromInv_AllowClose),
        // 呼吸可见性:默认开启(true)时不需要 patch;用户关闭时才挂载抑制
        // v3.x: patch Update 而不是 PlayBreathEffect — 后者间隔触发,toggle 切换后
        //       已飘的粒子要很久才会清,看起来 toggle 无效。Update 每帧同步并
        //       在切换瞬间 StopBreathEffectImmediate。
        Spec(typeof(Breath), "Update", typeof(Patch_UT_BreathVisibility),
            null, "Postfix", () => ModMain.Settings != null && !ModMain.Settings.UT_BreathVisibility),

    };

    public static void Reconcile()
    {
        for (int i = 0; i < Specs.Length; i++)
        {
            try { Specs[i].Sync(); }
            catch (Exception ex)
            {
                // 挂载条件或清理判断抛了异常(Patch/Unpatch 自己会吞异常,能抛到这里的只有这两个回调)。
                //   这一轮不动挂载状态,下一轮再判。原先直接标成永久失败:当时补丁若正挂着,
                //   就一直挂到退游戏,日志却写着 disabled。日志每个 spec 只写一次。
                if (!Specs[i]._warned)
                {
                    Specs[i]._warned = true;
                    ModMain.Log?.Error($"[DynPatch] {Specs[i].Key} 条件判断异常,本轮跳过: {ex.GetType().Name}: {ex.Message}");
                }
            }
        }
        try { AutoPickupGuard.ReconcileItemPickerPatch(); }
        catch (Exception ex) { ModMain.Log?.Error($"[DynPatch.AutoPickup] {ex.Message}"); }
    }

    // v7.0 可维护性自检:启动时一次性解析每个 Spec 的目标方法(不挂载,只解析),
    //   把"游戏更新后某方法被改名/删除 → 该功能静默失效"提前暴露在启动日志,
    //   而不是等玩家某天打开那个开关才发现不生效。运行时零开销(只在 OnInitializeMelon 跑一次)。
    //   配合静态 [HarmonyPatch] 的 PatchAll 失败已由 MelonLoader 直接 ERROR 出来,两者合起来
    //   覆盖本版修过的两类"功能不生效"根因(参数名绑定失败 / 整类漏移植或方法不存在)。
    public static void SelfCheck()
    {
        try
        {
            int total = Specs.Length, missing = 0;
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < total; i++)
            {
                if (!Specs[i].TargetResolves())
                {
                    missing++;
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(Specs[i].Key);
                }
            }
            if (missing == 0)
                ModMain.Log?.Msg($"[DynPatch.SelfCheck] OK — 全部 {total} 个动态补丁目标方法均可解析。");
            else
                ModMain.Log?.Error($"[DynPatch.SelfCheck] {missing}/{total} 个补丁目标方法解析失败(对应功能将无法生效,疑似游戏更新改了签名): {sb}");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[DynPatch.SelfCheck] 自检异常(已忽略): {ex.Message}"); }
    }

    public static string ActiveSummary()
    {
        try
        {
            int count = 0;
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < Specs.Length; i++)
            {
                var spec = Specs[i];
                if (!spec.Applied) continue;
                if (count > 0) sb.Append(',');
                sb.Append(spec.Key);
                count++;
            }
            return count == 0 ? "none" : sb.ToString();
        }
        catch { return "err"; }
    }

    private static PatchSpec Spec(Type target, string method, Type patchHolder,
        string prefixName, string postfixName, Func<bool> wanted, Func<bool> cleanupDone = null, Type[] paramTypes = null)
    {
        return new PatchSpec(target, method, patchHolder, prefixName, postfixName, wanted, cleanupDone, paramTypes);
    }

    private sealed class PatchSpec
    {
        public readonly string Key;
        public bool Applied;
        internal bool _failed;
        internal bool _warned;
        // 前缀、后缀各记各的:卸载时第二个抛异常的话,原先 Applied 仍是 true,再开开关不会重挂,只剩一半在跑
        private bool _preOn, _postOn;

        private readonly Type _target;
        private readonly string _method;
        private readonly Type[] _paramTypes;
        private readonly Func<bool> _wanted;
        private readonly Func<bool> _cleanupDone;
        private readonly HarmonyMethod _prefix;
        private readonly HarmonyMethod _postfix;
        private MethodBase _original;

        public PatchSpec(Type target, string method, Type patchHolder,
            string prefixName, string postfixName, Func<bool> wanted, Func<bool> cleanupDone, Type[] paramTypes)
        {
            _target = target;
            _method = method;
            _paramTypes = paramTypes;
            _wanted = wanted;
            _cleanupDone = cleanupDone;
            Key = target.FullName + "." + method + (paramTypes != null ? "(" + paramTypes.Length + ")" : "");
            _prefix = prefixName != null ? new HarmonyMethod(AccessTools.Method(patchHolder, prefixName)) : null;
            _postfix = postfixName != null ? new HarmonyMethod(AccessTools.Method(patchHolder, postfixName)) : null;
        }

        // v7.0 自检用:只解析目标方法,不挂载、不改 _failed 状态(保持懒解析语义)。
        public bool TargetResolves()
        {
            try { return Original != null; }
            catch { return false; }
        }

        public void Sync()
        {
            if (_failed) return;
            bool wanted = _wanted();
            if (wanted)
            {
                if (!Applied || (_prefix != null && !_preOn) || (_postfix != null && !_postOn)) Patch();
                return;
            }

            if (Applied && (_cleanupDone == null || _cleanupDone())) Unpatch();
        }

        private MethodBase Original
        {
            get
            {
                if (_original == null)
                {
                    if (_paramTypes != null && System.Array.Exists(_paramTypes, t => t == null))
                        return null;
                    try
                    {
                        _original = _paramTypes != null
                            ? AccessTools.Method(_target, _method, _paramTypes)
                            : AccessTools.Method(_target, _method);
                    }
                    catch (System.Reflection.AmbiguousMatchException)
                    {
                        // IL2CPP may generate multiple overloads with the same arity.
                        // Fall back to exact parameter-type matching.
                        _original = FindMethodByParamTypes(_target, _method, _paramTypes);
                        if (_original == null)
                            ModMain.Log?.Warning($"[DynPatch] AmbiguousMatch fallback failed: {Key}");
                    }
                }
                return _original;
            }
        }

        private static System.Reflection.MethodInfo FindMethodByParamTypes(Type type, string name, Type[] paramTypes)
        {
            if (paramTypes == null) return null;
            var methods = type.GetMethods(System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic);
            foreach (var m in methods)
            {
                if (m.Name != name) continue;
                var ps = m.GetParameters();
                if (ps.Length != paramTypes.Length) continue;
                bool match = true;
                for (int i = 0; i < ps.Length; i++)
                {
                    if (ps[i].ParameterType != paramTypes[i]) { match = false; break; }
                }
                if (match) return m;
            }
            return null;
        }

        private void Patch()
        {
            try
            {
                var original = Original;
                if (original == null) { _failed = true; ModMain.Log?.Warning($"[DynPatch] method not found (disabled): {Key}"); return; }
                H.Patch(original, _preOn ? null : _prefix, _postOn ? null : _postfix);
                _preOn = _prefix != null;
                _postOn = _postfix != null;
                Applied = true;
                ModMain.Log?.Msg($"[DynPatch] ON  {Key}");
            }
            catch (Exception ex) { _failed = true; ModMain.Log?.Error($"[DynPatch] Patch {Key} (disabled): {ex.Message}"); }
        }

        private void Unpatch()
        {
            var original = Original;
            if (original == null) return;
            // v7.7 修「关一个功能连带关掉另一个」:原先是
            //     H.Unpatch(original, HarmonyPatchType.All, HARMONY_ID)
            //   按 ID 卸载 = 把这个方法上所有 TldHacks.Dynamic 的补丁全删掉,而 15 组 spec
            //   共享同一个目标方法(如 Panel_BreakDown.OnBreakDown 上同时有 QuickBreakDown、
            //   RememberBreakdownTool、BreakdownSpeedMult)。关掉其中一个 → 另外两个也被删,
            //   而它们的 Applied 仍是 true → Reconcile 走 wanted&&Applied 分支直接 return,
            //   整个 session 都不会重新挂上。改成按补丁方法精确卸载,只动自己这一份。
            //   前缀、后缀分开卸,各自成功才清自己的标记;失败的那一半下一轮 Reconcile 再卸。
            if (_preOn && _prefix?.method != null)
            {
                try { H.Unpatch(original, _prefix.method); _preOn = false; }
                catch (Exception ex) { WarnUnpatch(ex); }
            }
            if (_postOn && _postfix?.method != null)
            {
                try { H.Unpatch(original, _postfix.method); _postOn = false; }
                catch (Exception ex) { WarnUnpatch(ex); }
            }
            Applied = _preOn || _postOn;
            if (!Applied) ModMain.Log?.Msg($"[DynPatch] OFF {Key}");
        }

        private void WarnUnpatch(Exception ex)
        {
            if (_warned) return;
            _warned = true;
            ModMain.Log?.Error($"[DynPatch] Unpatch {Key}(下一轮重试): {ex.Message}");
        }
    }
}
