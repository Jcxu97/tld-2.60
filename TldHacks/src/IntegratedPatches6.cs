using HarmonyLib;
using Il2Cpp;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.BigCarry;
using Il2CppTLD.Gear;
#endif
using Il2CppTLD.IntBackedUnit;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.Interactions;
using Il2CppTLD.Placement;
#endif
using UnityEngine;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════════
//   v3.0.4 IntegratedPatches6 — UniversalTweaks v1.4.8 chunk 3a
//   常用修改 / 食物 / 岩石贮藏 / 喷漆 / 雪橇 (~15 patches)
//   跳过 chunk 3b 的: 手电筒(12 patches) / 容器容量(40+ 项)
// ═══════════════════════════════════════════════════════════════════

// ─── 哈气可见性 (DynamicPatch — 默认开启时不需要 patch) ───
// v3.x: 改为 patch Breath.Update,每帧同步 m_SuppressEffects 并在切换瞬间
//       主动 StopBreathEffectImmediate(),否则正在飘的粒子要等下一次
//       PlayBreathEffect 才会清,toggle 看起来"无效"。
//       Update 每帧只 1 个 Breath 实例(玩家),开销可忽略。
internal static class Patch_UT_BreathVisibility
{
    // patch 挂载本身就代表 toggle 已关 → 每个 Breath 实例只在第一次进 Postfix 时
    // 主动 stop 一次正在飘的粒子;之后只刷字段,避免每帧调 stop。
    private static readonly System.Collections.Generic.HashSet<int> _stoppedIds = new();
    public static void Postfix(Breath __instance)
    {
        try
        {
            if (__instance == null) return;
            __instance.m_SuppressEffects = true;
            int id = __instance.GetInstanceID();
            if (_stoppedIds.Add(id))
            {
                try { __instance.StopBreathEffectImmediate(); } catch { }
            }
        }
        catch { }
    }
    // toggle 重新开启再关闭时,允许再次 stop
    public static void Reset() { _stoppedIds.Clear(); }
}

// ─── 自定义模式徽章 ───
[HarmonyPatch(typeof(Feat), "ShouldBlockIncrement")]
internal static class Patch_UT_FeatCustom
{
    static void Postfix(ref bool __result)
    {
        if (ModMain.Settings != null && ModMain.Settings.UT_FeatProgressInCustom) __result = false;
    }
}

// ─── 左轮改良: 瞄准时可走 (DynamicPatch 注册,不常驻) ───
internal static class Patch_UT_RevolverWalk
{
    public static void Postfix(vp_FPSPlayer __instance)
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) return;
            if ((int)pm.GetControlMode() != 18) return;
            if (!GameManager.IsMoveInputUnblocked()) return;
            __instance.InputWalk();
        }
        catch { }
    }
}

// ─── 左轮改良: 隐藏限制 UI (DynamicPatch 注册,不常驻) ───
internal static class Patch_UT_RevolverUI
{
    public static void Postfix(Panel_HUD __instance)
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) return;
            if ((int)pm.GetControlMode() != 18) return;
            if (__instance.m_AimingLimitedMobility != null)
                ((UnityEngine.Component)__instance.m_AimingLimitedMobility).gameObject.SetActive(false);
        }
        catch { }
    }
}

// ─── 物品掉落随机旋转 ───
[HarmonyPatch(typeof(GearItem), "Drop")]
internal static class Patch_UT_DropRotation
{
    static void Postfix(GearItem __instance)
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.UT_RandomizedItemRotation) return;
            if (__instance == null) return;
            float yaw = Random.Range(0f, 360f);
            var t = ((UnityEngine.Component)__instance).transform;
            string n = ((UnityEngine.Object)__instance).name;
            t.eulerAngles = n.Contains("GEAR_Rifle")
                ? new Vector3(t.eulerAngles.x, yaw, 90f)
                : new Vector3(0f, yaw, 0f);
        }
        catch { }
    }
}

// ─── 制噪器参数 + 头疼 debuff + 绷带重量 + 炖汤疲劳 + MRE 纹理 ───
[HarmonyPatch(typeof(GearItem), "Deserialize")]
internal static class Patch_UT_GearItemDeserialize
{
    static void Postfix(GearItem __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null) return;
            string n = ((UnityEngine.Object)((UnityEngine.Component)__instance).gameObject).name;

            // 制噪器
            if (n == "GEAR_NoiseMaker" && __instance.m_NoiseMakerItem != null)
            {
                __instance.m_NoiseMakerItem.m_BurnLifetimeMinutes = s.UT_NoisemakerBurnLength;
                __instance.m_NoiseMakerItem.m_ThrowForce = s.UT_NoisemakerThrowForce;
            }

#if !STORY_EDITION
            // 2.24 无 FoodStatEffect 类型(炖汤疲劳效果是 2.55 的食物 buff 系统),
            // 也无 GearItemData(重量在 GearItem.m_WeightKG,见下面剧情分支)。
            // 炖汤疲劳调整
            if (n == "GEAR_CookedStewMeat" || n == "GEAR_CookedStewVegetables")
            {
                try
                {
                    var fx = ((UnityEngine.Component)__instance).gameObject.GetComponentInParent<FoodStatEffect>();
                    if (fx != null) fx.m_Effect = s.UT_StewFatigueLoss;
                }
                catch { }
            }

            // 绷带重量
            if (s.UT_ConsistantDressingWeight && n == "GEAR_OldMansBeardDressing"
                && __instance.m_GearItemData != null)
            {
                __instance.m_GearItemData.m_BaseWeight = ItemWeight.FromKilograms(0.03f);
            }
#else
            // 绷带重量(2.24:裸 float 挂在 GearItem 上)
            if (s.UT_ConsistantDressingWeight && n == "GEAR_OldMansBeardDressing")
            {
                __instance.m_WeightKG = 0.03f;
            }
#endif
        }
        catch { }
    }
}

#if !STORY_EDITION
// ─── 滤罐持续时间 ───
// 2.24 无 Respirator / RespiratorCanister(防毒面具随沙盒新区域一起加入)。
[HarmonyPatch(typeof(Respirator), "AttachCanister")]
internal static class Patch_UT_CanisterDuration
{
    static void Postfix(RespiratorCanister canister)
    {
        try
        {
            if (ModMain.Settings == null || canister == null) return;
            canister.m_ProtectionDurationRTSeconds = ModMain.Settings.UT_RespiratorCanisterDuration;
        }
        catch { }
    }
}
#endif

// ─── 岩石贮藏: 室内 + 数量/距离 ───
[HarmonyPatch(typeof(RockCacheManager), "CanAttemptToPlaceRockCache")]
internal static class Patch_UT_RockCacheCheck
{
    static bool Prefix(ref bool __result)
    {
        if (ModMain.Settings != null && ModMain.Settings.UT_RockCacheIndoors)
        {
            __result = true;
            return false;
        }
        return true;
    }

    static void Postfix(RockCacheManager __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;
            __instance.m_MaxRockCachesPerRegion = s.UT_RockCacheMaxPerRegion;
            __instance.m_MinDistanceBetweenRockCaches = s.UT_RockCacheMinDistance;
        }
        catch { }
    }
}

// ─── 雪屋衰减 ───
// 2.24 没有 SnowShelterManager.InstantiateSnowShelter(雪屋实例化走 PlaceMesh 流程),
// 改挂 SnowShelter.BuildFinished:建造完成的那一刻写衰减值,与 2.55 挂实例化等价
// (两者都是"这个雪屋刚诞生"的时点,后续 Update 才开始扣血)。
#if STORY_EDITION
[HarmonyPatch(typeof(SnowShelter), "BuildFinished")]
internal static class Patch_UT_SnowShelterDecay
{
    static void Postfix(SnowShelter __instance)
    {
        try
        {
            if (ModMain.Settings == null || __instance == null) return;
            __instance.m_DailyDecayHP = ModMain.Settings.UT_SnowShelterDecay;
        }
        catch { }
    }
}
#else
[HarmonyPatch(typeof(SnowShelterManager), "InstantiateSnowShelter")]
internal static class Patch_UT_SnowShelterDecay
{
    static void Postfix(ref SnowShelter __result)
    {
        try
        {
            if (ModMain.Settings == null || __result == null) return;
            __result.m_DailyDecayHP = ModMain.Settings.UT_SnowShelterDecay;
        }
        catch { }
    }
}
#endif

#if !STORY_EDITION
// ─── 雪橇: 互动限制 ───
// 2.24 无 TravoisBigCarryItem / IInteraction(雪橇与交互系统重构都在 2.24 之后)。
[HarmonyPatch(typeof(TravoisBigCarryItem), "CanPerformInteractionWhileCarrying")]
internal static class Patch_UT_TravoisInteract
{
    static void Postfix(ref bool __result, IInteraction interaction)
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.UT_TravoisOverrideInteraction) return;
            __result = !(GameManager.GetPlayerInVehicle().IsEntering()
                      || GameManager.GetSnowShelterManager().PlayerEnteringShelter());
        }
        catch { }
    }
}

// ─── 雪橇: 移动限制 ───
// 照抄 UniversalTweaks.Travois.OverrideMovementRestrictions:检查结果一律改成 None(没有限制)。
//   v3.0.4 移植时跳过了,开关一直没接上。CheckMovementRestriction 拖雪橇移动时每帧都调,走 DynamicPatch。
internal static class Patch_UT_TravoisMovementRestriction
{
    internal static void Postfix(ref CarryDisplayError __result)
    {
        __result = CarryDisplayError.None;   // 原版写的是 (CarryDisplayError)(-1),就是 None
    }
}

// ─── 雪橇: 全参数 (OnCarried) ───
[HarmonyPatch(typeof(TravoisBigCarryItem), "OnCarried")]
internal static class Patch_UT_TravoisParams
{
    static void Postfix(TravoisBigCarryItem __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null || __instance == null || __instance.m_TravoisMovement == null) return;
            __instance.m_TravoisMovement.m_TurnSpeed = s.UT_TravoisTurnSpeed;
            __instance.m_TravoisMovement.m_MaxSlopeClimbAngle = s.UT_TravoisMaxSlope;
            __instance.m_TravoisMovement.m_MaxSlopeDownhillAngle = s.UT_TravoisMaxSlope;
            __instance.m_BlizzardDecayPerHour = s.UT_TravoisDecayBlizzard;
            __instance.m_DecayHPPerHour = s.UT_TravoisDecayHourly / 1000f;
            __instance.m_MovementDecayPerUnit = s.UT_TravoisDecayMovement / 100f;
        }
        catch { }
    }
}
#endif

// ─── 喷漆: 高亮 (DynamicPatch 注册,不常驻 — 渲染路径,每帧每喷漆标记触发一次) ───
internal static class Patch_UT_GlowingDecals
{
    private static float _lastMult;
    private static bool _applied;

    public static void Prefix(DynamicDecalsManager __instance)
    {
        try
        {
            if (__instance == null || __instance.m_GlowMaterial == null) return;
            float mult = ModMain.Settings.UT_GlowingDecalMult;
            if (_applied && mult == _lastMult) return;
            _lastMult = mult;
            _applied = true;
            __instance.m_GlowMaterial.SetColor("_GlowColor", new Color(1f, 0.45f, 0f, 0f));
            __instance.m_GlowMaterial.SetFloat("_GlowMult", mult);
            __instance.m_AnimatedRevealMaterial = __instance.m_GlowMaterial;
        }
        catch { }
    }
}

// ─── 喷漆: 重叠率 ───
[HarmonyPatch(typeof(Panel_SprayPaint), "Enable", new System.Type[] { typeof(bool) })]
internal static class Patch_UT_DecalOverlap
{
    static void Postfix()
    {
        try
        {
            if (ModMain.Settings == null) return;
            var dm = GameManager.GetDynamicDecalsManager();
            if (dm != null) dm.m_DecalOverlapLeniencyPercent = ModMain.Settings.UT_DecalOverlap;
        }
        catch { }
    }
}

// ─── 马桶水可饮用 (DynamicPatch 注册,不常驻) ───
internal static class Patch_UT_ToiletWater
{
    public static void Postfix(WaterSource __instance)
    {
        try
        {
            if (__instance == null) return;
            if ((int)__instance.m_CurrentLiquidQuality == 0) return;
            __instance.m_CurrentLiquidQuality = (LiquidQuality)0;
        }
        catch { }
    }
}
