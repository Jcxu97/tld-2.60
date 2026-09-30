using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.Gear;
#endif
using MelonLoader;
using ModData;
using UnityEngine;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════
// AutoSurvey: 自动勘测地图(OnUpdate 轮询,零 Harmony patch)
// ═══════════════════════════════════════════════════════════════
internal static class AutoSurveyHelper
{
    private static float _timer;
    private static int _skip;

    internal static void OnUpdateTick()
    {
        if (!CheatState.QoL_AutoSurvey) return;
        if (++_skip < 15) return; // 每 15 帧检查一次(~250ms),减少 IL2Cpp bridge 开销
        _skip = 0;
        if (GameManager.IsMainMenuActive()) return;
        if (InterfaceManager.IsPanelEnabled<Panel_Map>()) return;
        if (!InterfaceManager.IsPanelLoaded<Panel_Map>()) return;
        var pm = GameManager.GetPlayerManagerComponent();
        if (pm == null) return;
        if (InterfaceManager.IsPanelEnabled<Panel_IceFishing>()) return;
        var s = ModMain.Settings;
        if (!s.QoL_AutoSurveyUnlock && !CharcoalItem.HasSurveyVisibility(0f)) return;

        _timer += UnityEngine.Time.deltaTime * 15f;
        if (_timer >= s.QoL_AutoSurveyDelay)
        {
            UnityEngine.Transform playerT = GameManager.GetPlayerTransform();
            if (playerT == null) return;
            float range = s.QoL_AutoSurveyRange * 20f;
            var panel = InterfaceManager.GetPanel<Panel_Map>();
            if (panel == null) return;
            panel.DoNearbyDetailsCheck(range, true, false, playerT.position, true);
            _timer = 0f;
        }
    }
}

// ═══════════════════════════════════════════════════════════════
// Sprainkle: Sprains.Update Postfix — 实时写入扭伤参数
// ═══════════════════════════════════════════════════════════════
internal static class Patch_Sprains_Update
{
    // 关掉 Sprainkle 时写回原版值:扭伤组件在玩家身上跨场景存在,不还原的话改过的概率要重启游戏才恢复。
    //   按实例存:换存档后组件是新实例(难度不同原值也不同),旧快照直接丢掉。
    private static System.IntPtr _savedPtr;
    private static int _slope;
    private static float _secs, _base, _enc, _exh, _sprint, _crouch, _uiOn, _uiOff;

    // DynamicPatch 的 cleanupDone:写回成功(或没改过)才返回 true 让补丁卸载
    internal static bool RestoreDone()
    {
        if (_savedPtr == System.IntPtr.Zero) return true;
        try
        {
            var sp = GameManager.GetSprainsComponent();
            if (sp == null) return false;   // 主菜单里拿不到,等进场景再还
            if (sp.Pointer == _savedPtr)
            {
                sp.m_MinSlopeDegreesForSprain = _slope;
                sp.m_MinSecondsForSlopeRisk = _secs;
                sp.m_BaseChanceWhenMovingOnSlope = _base;
                sp.m_ChanceIncreaseEncumbered = _enc;
                sp.m_ChanceIncreaseExhausted = _exh;
                sp.m_ChanceIncreaseSprinting = _sprint;
                sp.m_ChanceReduceWhenCrouchedPercent = _crouch;
                sp.m_MinSecondsToShowWarning = _uiOn;
                sp.m_MinSecondsBeforeHidingWarning = _uiOff;
            }
        }
        catch { return false; }
        _savedPtr = System.IntPtr.Zero;
        return true;
    }

    internal static void Postfix(Sprains __instance)
    {
        if (!CheatState.World_Sprainkle) return;
        try
        {
            var s = ModMain.Settings;
            int slope = (int)s.World_SprainkleSlopeMin;
            // 所有字段都一致才跳过;只比坡度会让其余滑条改了不生效
            if (__instance.m_MinSlopeDegreesForSprain == slope
                && __instance.m_MinSecondsForSlopeRisk == s.World_SprainkleMinSecondsRisk
                && __instance.m_BaseChanceWhenMovingOnSlope == s.World_SprainkleBaseChanceMoving
                && __instance.m_ChanceIncreaseEncumbered == s.World_SprainkleEncumberChance
                && __instance.m_ChanceIncreaseExhausted == s.World_SprainkleExhaustionChance
                && __instance.m_ChanceIncreaseSprinting == s.World_SprainkleSprintChance
                && __instance.m_ChanceReduceWhenCrouchedPercent == s.World_SprainkleCrouchChance
                && __instance.m_MinSecondsToShowWarning == s.World_SprainkleSprintUIOn
                && __instance.m_MinSecondsBeforeHidingWarning == s.World_SprainkleSprintUIOff) return;
            if (GameManager.m_IsPaused || GameManager.s_IsGameplaySuspended) return;
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null || pm.m_God) return;

            if (_savedPtr != __instance.Pointer)
            {
                _savedPtr = __instance.Pointer;
                _slope = __instance.m_MinSlopeDegreesForSprain;
                _secs = __instance.m_MinSecondsForSlopeRisk;
                _base = __instance.m_BaseChanceWhenMovingOnSlope;
                _enc = __instance.m_ChanceIncreaseEncumbered;
                _exh = __instance.m_ChanceIncreaseExhausted;
                _sprint = __instance.m_ChanceIncreaseSprinting;
                _crouch = __instance.m_ChanceReduceWhenCrouchedPercent;
                _uiOn = __instance.m_MinSecondsToShowWarning;
                _uiOff = __instance.m_MinSecondsBeforeHidingWarning;
            }
            __instance.m_MinSlopeDegreesForSprain = slope;
            __instance.m_MinSecondsForSlopeRisk = s.World_SprainkleMinSecondsRisk;
            __instance.m_BaseChanceWhenMovingOnSlope = s.World_SprainkleBaseChanceMoving;
            __instance.m_ChanceIncreaseEncumbered = s.World_SprainkleEncumberChance;
            __instance.m_ChanceIncreaseExhausted = s.World_SprainkleExhaustionChance;
            __instance.m_ChanceIncreaseSprinting = s.World_SprainkleSprintChance;
            __instance.m_ChanceReduceWhenCrouchedPercent = s.World_SprainkleCrouchChance;
            __instance.m_MinSecondsToShowWarning = s.World_SprainkleSprintUIOn;
            __instance.m_MinSecondsBeforeHidingWarning = s.World_SprainkleSprintUIOff;
        }
        catch { }
    }
}

// Sprainkle: SprainedAnkle.SprainedAnkleStart Postfix — 设置持续/恢复时间
internal static class Patch_SprainedAnkle_Sprainkle
{
    internal static void Postfix(SprainedAnkle __instance)
    {
        if (!CheatState.World_Sprainkle) return;
        try
        {
            var s = ModMain.Settings;
            if (!s.World_SprainkleAnkleEnabled)
            {
                __instance.Cure();
                return;
            }
            __instance.m_DurationHoursMin = s.World_SprainkleAnkleDurMin;
            __instance.m_DurationHoursMax = s.World_SprainkleAnkleDurMax;
            __instance.m_ChanceSprainAfterFall = s.World_SprainkleAnkleFallChance;
            __instance.m_NumHoursRestForCure = s.World_SprainkleAnkleRestHours;
        }
        catch { }
    }
}

// Sprainkle: SprainedWrist.SprainedWristStart Postfix — 设置持续/恢复时间
internal static class Patch_SprainedWrist_Sprainkle
{
    internal static void Postfix(SprainedWrist __instance)
    {
        if (!CheatState.World_Sprainkle) return;
        try
        {
            var s = ModMain.Settings;
            if (!s.World_SprainkleWristEnabled)
            {
                __instance.Cure();
                return;
            }
            __instance.m_DurationHoursMin = s.World_SprainkleWristDurMin;
            __instance.m_DurationHoursMax = s.World_SprainkleWristDurMax;
            __instance.m_ChanceSprainAfterFall = s.World_SprainkleWristFallChance;
            __instance.m_NumHoursRestForCure = s.World_SprainkleWristRestHours;
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════
// MoreCookingSlots: WoodStove.Awake Postfix — 增加烹饪槽位
// 2.24 没有 FireplaceInteraction 这个类,CookingSlot 也没有 m_FireplaceHost
// (烹饪槽跟火源的关联是 2.55 重构出来的)。整个功能在剧情下无法实现,
// patch 类连同 DynamicPatch 的 Spec 一起排除,StoryGuard 里再把开关强制关掉。
// ═══════════════════════════════════════════════════════════════
#if !STORY_EDITION
internal static class Patch_WoodStove_Awake_CookingSlots
{
    internal static void Postfix(WoodStove __instance)
    {
        if (!CheatState.Craft_MoreCookingSlots) return;
        try
        {
            var s = ModMain.Settings;
            var go = ((Component)__instance).gameObject;
            string name = ((UnityEngine.Object)go).name;

            if (name.Contains("INTERACTIVE_FirePlace") && s.Craft_MoreSlots_Fireplace)
                AddFireplaceSlots(go);
            else if (name.Contains("INTERACTIVE_RimGrill") && s.Craft_MoreSlots_Grill)
                AddGrillSlots(go);
            else if (name.Contains("INTERACTIVE_FireBarrel") && s.Craft_MoreSlots_Barrel)
                AddBarrelSlots(go);
        }
        catch { }
    }

    private static GameObject GetPlacePoints(GameObject stove)
    {
        var t = stove.transform.FindChild("PlacePoints");
        return t != null ? ((Component)t).gameObject : null;
    }

    private static GameObject InstantiatePlacePoint(GameObject original, Transform parent, Vector3 offset)
    {
        if (original == null || parent == null) return null;
        var clone = UnityEngine.Object.Instantiate(original, parent);
        clone.transform.localPosition += offset;
        return clone;
    }

    private static GameObject InstantiateCookingSpot(GameObject original, GameObject placePointObj, Transform placePointsParent, Vector3 offset, GameObject fireplace)
    {
        if (original == null || placePointObj == null || placePointsParent == null) return null;
        var clone = UnityEngine.Object.Instantiate(original, placePointsParent);
        clone.transform.localPosition += offset;
        var cs = clone.GetComponent<CookingSlot>();
        if (cs != null)
        {
            cs.m_GearPlacePoint = placePointObj.GetComponent<GearPlacePoint>();
            cs.m_FireplaceHost = (FireplaceInteraction)(object)fireplace.GetComponent<WoodStove>();
        }
        return clone;
    }

    private static void RecreateArrays(GameObject stove, GameObject placePointsObj)
    {
        var allSlots = stove.GetComponentsInChildren<CookingSlot>();
        ((FireplaceInteraction)stove.GetComponent<WoodStove>()).m_CookingSlots = new Il2CppReferenceArray<CookingSlot>(allSlots);
        var renderers = placePointsObj.GetComponentsInChildren<MeshRenderer>();
        var pp = placePointsObj.GetComponent<PlacePoints>();
        if (pp != null)
            pp.m_PlacePoints = new Il2CppReferenceArray<Renderer>(renderers.Length);
    }

    private static void AddFireplaceSlots(GameObject go)
    {
        var pp = GetPlacePoints(go);
        if (pp == null) return;
        var cylinder = pp.transform.FindChild("Cylinder");
        var gearPP = go.transform.FindChild("GearPlacePoint");
        if (cylinder == null || gearPP == null) return;
        var cylObj = ((Component)cylinder).gameObject;
        var gearObj = ((Component)gearPP).gameObject;
        cylObj.transform.localPosition -= new Vector3(0.2f, 0f, -0.015f);
        gearObj.transform.localPosition -= new Vector3(0.2f, 0f, 0f);
        var newGear = InstantiatePlacePoint(gearObj, pp.transform, new Vector3(0.4f, 0f, 0f));
        InstantiateCookingSpot(cylObj, newGear, pp.transform, new Vector3(0.4f, 0f, 0f), go);
        RecreateArrays(go, pp);
    }

    private static void AddGrillSlots(GameObject go)
    {
        var pp = GetPlacePoints(go);
        if (pp == null) return;
        var cylinder = pp.transform.FindChild("Cylinder (1)");
        var rack = go.transform.FindChild("OBJ_RimGrillRack");
        if (cylinder == null || rack == null) return;
        var gearPP = rack.FindChild("GearPlacePoint (1)");
        if (gearPP == null) return;
        var cylObj = ((Component)cylinder).gameObject;
        var gearObj = ((Component)gearPP).gameObject;
        var newGear1 = InstantiatePlacePoint(gearObj, rack, new Vector3(-0.07f, 0f, -0.15f));
        InstantiateCookingSpot(cylObj, newGear1, pp.transform, new Vector3(-0.07f, 0f, -0.15f), go);
        var newGear2 = InstantiatePlacePoint(gearObj, rack, new Vector3(-0.2f, 0f, 0.1f));
        InstantiateCookingSpot(cylObj, newGear2, pp.transform, new Vector3(-0.2f, 0f, 0.1f), go);
        cylObj.transform.localPosition += new Vector3(0f, 0f, 0.03f);
        gearObj.transform.localPosition += new Vector3(0f, 0f, 0.03f);
        RecreateArrays(go, pp);
    }

    private static void AddBarrelSlots(GameObject go)
    {
        var pp = GetPlacePoints(go);
        if (pp == null) return;
        var cylinder = pp.transform.FindChild("Cylinder (1)");
        var rack = go.transform.FindChild("OBJ_RimGrillRack");
        if (cylinder == null || rack == null) return;
        var gearPP = rack.FindChild("GearPlacePoint (1)");
        if (gearPP == null) return;
        var cylObj = ((Component)cylinder).gameObject;
        var gearObj = ((Component)gearPP).gameObject;
        cylObj.transform.localScale = new Vector3(0.15f, 0.005f, 0.15f);
        var newGear1 = InstantiatePlacePoint(gearObj, rack, new Vector3(0.16f, 0f, 0.1f));
        InstantiateCookingSpot(cylObj, newGear1, pp.transform, new Vector3(0.16f, 0f, 0.1f), go);
        var newGear2 = InstantiatePlacePoint(gearObj, rack, new Vector3(0f, 0f, -0.13f));
        InstantiateCookingSpot(cylObj, newGear2, pp.transform, new Vector3(0f, 0f, -0.13f), go);
        cylObj.transform.localPosition += new Vector3(-0.05f, 0f, 0.05f);
        gearObj.transform.localPosition += new Vector3(-0.05f, 0f, 0.05f);
        var cylFirst = pp.transform.FindChild("Cylinder");
        if (cylFirst != null) ((Component)cylFirst).gameObject.transform.localScale = new Vector3(0.15f, 0.005f, 0.15f);
        RecreateArrays(go, pp);
    }
}
#endif

// ═══════════════════════════════════════════════════════════════
// UT Encumbrance: 额外负重
// ═══════════════════════════════════════════════════════════════

// ═══════════════════════════════════════════════════════════════
// BowRepair: GearItem.Awake Postfix — 给弓添加 Repairable/Millable
// ═══════════════════════════════════════════════════════════════
internal static class Patch_GearItem_Awake_BowRepair
{
    private static ToolsItem _simpleTools;
    private static ToolsItem _qualityTools;
    private static GearItem _gutDried;
    private static GearItem _scrapMetal;
    private static GearItem _scrapLead;
    private static GearItem _softwood;
    private static GearItem _hardwood;
    private static GearItem _cloth;
    private static bool _loaded;
    private static bool _attempted;
    private static bool _sceneInitialized;

    private static GearItem LoadGear(string key) =>
        UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)key)
            .WaitForCompletion().GetComponent<GearItem>();

    internal static void PreloadMaterials()
    {
        if (_loaded || _attempted || !_sceneInitialized) return;
        _attempted = true;
        try
        {
            _simpleTools = LoadGear("GEAR_SimpleTools").m_ToolsItem;
            _qualityTools = LoadGear("GEAR_HighQualityTools").m_ToolsItem;
            _gutDried = LoadGear("GEAR_GutDried");
            _scrapMetal = LoadGear("GEAR_ScrapMetal");
            _scrapLead = LoadGear("GEAR_ScrapLead");
            _softwood = LoadGear("GEAR_Softwood");
            _hardwood = LoadGear("GEAR_Hardwood");
            _cloth = LoadGear("GEAR_Cloth");
            _loaded = true;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[BowRepair] Material preload failed: {ex}"); }
    }

    internal static void OnSceneInitialized()
    {
        _sceneInitialized = true;
        _attempted = false;
        if (ModMain.Settings != null && ModMain.Settings.World_BowRepair
            && !ModMain.Settings.DiagUnpatchAll) PreloadMaterials();
    }

    private static Il2CppReferenceArray<ToolsItem> Tools() =>
        new Il2CppReferenceArray<ToolsItem>(new ToolsItem[] { _simpleTools, _qualityTools });

    private static Il2CppReferenceArray<GearItem> Materials(GearItem a, GearItem b) =>
        new Il2CppReferenceArray<GearItem>(new GearItem[] { a, b });

    private static Il2CppStructArray<int> Units(int a, int b) =>
        new Il2CppStructArray<int>(new int[] { a, b });

    private static (int, int) MatAmounts(int level)
    {
        return level switch { 0 => (1, 1), 1 => (2, 1), _ => (3, 3) };
    }

    private static (int, int) MatAmountsRestore(int level)
    {
        return level switch { 0 => (1, 1), 1 => (2, 2), _ => (3, 4) };
    }

    private static void AddRepairable(GearItem gi, GearItem mat1, GearItem mat2, int matLevel, int duration = 65, float condInc = 35f, string audio = "Play_CraftingGeneric")
    {
        var (a, b) = MatAmounts(matLevel);
        var rep = ((Component)gi).gameObject.AddComponent<Repairable>();
        gi.m_Repairable = rep;
        rep.m_RepairToolChoices = Tools();
        rep.m_DurationMinutes = duration;
        rep.m_ConditionIncrease = condInc;
        rep.m_RequiredGear = Materials(mat1, mat2);
        rep.m_RequiredGearUnits = Units(a, b);
        rep.m_RequiresToolToRepair = true;
        rep.m_RepairAudio = audio;
    }

    private static void AddMillable(GearItem gi, GearItem mat1, GearItem mat2, int matLevel, int repDur = 50, int recDur = 145)
    {
        var (a, b) = MatAmounts(matLevel);
        var mill = ((Component)gi).gameObject.AddComponent<Millable>();
        gi.m_Millable = mill;
        mill.m_CanRestoreFromWornOut = true;
        mill.m_RecoveryDurationMinutes = recDur;
        mill.m_RepairDurationMinutes = repDur;
        mill.m_RepairRequiredGear = Materials(mat1, mat2);
        mill.m_RepairRequiredGearUnits = Units(a, b);
        var (ra, rb) = MatAmountsRestore(matLevel);
        mill.m_RestoreRequiredGear = Materials(mat1, mat2);
        mill.m_RestoreRequiredGearUnits = Units(ra, rb);
        mill.m_Skill = (SkillType)5;
    }

    internal static void Postfix(GearItem __instance)
    {
        try
        {
            if (!CheatState.World_BowRepair) return;
            if (__instance.m_BowItem == null) return;

            if (!_loaded) return;

            var s = ModMain.Settings;
            string name = ((UnityEngine.Object)__instance).name.ToLowerInvariant();

            if (name.Contains("gear_bow_manufactured"))
            {
                if (!s.World_BowRepairDLC) return;
                int mode = s.World_SportBowRepairMode;
                int mat = s.World_SportBowMaterialNeed;
                if (mode == 0 || mode == 2) AddRepairable(__instance, _scrapLead, _scrapMetal, mat);
                if (mode == 1 || mode == 2) AddMillable(__instance, _scrapLead, _scrapMetal, mat);
            }
            else if (name.Contains("gear_bow_woodwrights"))
            {
                if (!s.World_BowRepairDLC) return;
                int mode = s.World_WoodBowRepairMode;
                int mat = s.World_WoodBowMaterialNeed;
                if (mode == 0 || mode == 2) AddRepairable(__instance, _hardwood, _scrapMetal, mat, 60, 35f, "Play_CraftingWood");
                if (mode == 1 || mode == 2) AddMillable(__instance, _hardwood, _scrapMetal, mat, 45, 115);
            }
            else if (name.Contains("gear_bow_bushcraft"))
            {
                if (!s.World_BowRepairDLC) return;
                int mode = s.World_BushBowRepairMode;
                int mat = s.World_BushBowMaterialNeed;
                if (mode == 0 || mode == 2) AddRepairable(__instance, _hardwood, _cloth, mat, 60, 40f, "Play_CraftingWood");
                if (mode == 1 || mode == 2) AddMillable(__instance, _hardwood, _scrapMetal, mat, 30, 60);
            }
            else if (name.Contains("gear_bow"))
            {
                int mode = s.World_BowRepairMode;
                int mat = s.World_BowMaterialNeed;
                if (mode == 0 || mode == 2) AddRepairable(__instance, _softwood, _gutDried, mat);
                if (mode == 1 || mode == 2) AddMillable(__instance, _softwood, _scrapMetal, mat);
            }
        }
        catch (Exception ex) { ModMain.Log?.Error($"[BowRepair] GearItem.Awake: {ex}"); }
    }
}

// ═══════════════════════════════════════════════════════════════
// QoL: NoSaveOnSprain — 阻止扭伤自动存档
// 原理: 在 SprainedAnkle/WristStart 的 Prefix 里清除 AfflictionOptions 的 NeedsSave 位(bit 1)
// ═══════════════════════════════════════════════════════════════
internal static class NoSaveOnSprain_State
{
    internal static bool FromFall;
}

[HarmonyLib.HarmonyPatch(typeof(FallDamage), "MaybeSprainAnkle")]
internal static class Patch_FallDamage_MaybeSprainAnkle_Track
{
    internal static void Postfix() => NoSaveOnSprain_State.FromFall = true;
}

[HarmonyLib.HarmonyPatch(typeof(FallDamage), "MaybeSprainWrist")]
internal static class Patch_FallDamage_MaybeSprainWrist_Track
{
    internal static void Postfix() => NoSaveOnSprain_State.FromFall = true;
}

internal static class Patch_NoSaveOnSprain_Ankle
{
    internal static bool Prefix(ref AfflictionOptions options)
    {
        if (CheatState.NoFallDamage) return false;
        if (!CheatState.QoL_NoSaveOnSprain) { NoSaveOnSprain_State.FromFall = false; return true; }
        bool fromFall = NoSaveOnSprain_State.FromFall;
        NoSaveOnSprain_State.FromFall = false;
        if (((uint)options & 2u) == 0) return true;
        if (fromFall && !CheatState.QoL_NoSaveOnSprainFalls) return true;
        options = (AfflictionOptions)((uint)options & 0xFFFFFFFDu);
        return true;
    }

    // IL2CPP may ignore Prefix return false — Postfix immediately ends the sprain
    internal static void Postfix(SprainedAnkle __instance)
    {
        if (!CheatState.NoFallDamage) return;
        try
        {
            __instance.SprainedAnkleEnd(0, (AfflictionOptions)0);
            __instance.SprainedAnkleEnd(1, (AfflictionOptions)0);
        }
        catch { }
    }
}

internal static class Patch_NoSaveOnSprain_Wrist
{
    internal static bool Prefix(ref AfflictionOptions options)
    {
        if (CheatState.NoFallDamage) return false;
        if (!CheatState.QoL_NoSaveOnSprain) { NoSaveOnSprain_State.FromFall = false; return true; }
        bool fromFall = NoSaveOnSprain_State.FromFall;
        NoSaveOnSprain_State.FromFall = false;
        if (((uint)options & 2u) == 0) return true;
        if (fromFall && !CheatState.QoL_NoSaveOnSprainFalls) return true;
        options = (AfflictionOptions)((uint)options & 0xFFFFFFFDu);
        return true;
    }

    internal static void Postfix(SprainedWrist __instance)
    {
        if (!CheatState.NoFallDamage) return;
        try
        {
            __instance.SprainedWristEnd(0, (AfflictionOptions)0);
            __instance.SprainedWristEnd(1, (AfflictionOptions)0);
        }
        catch { }
    }
}

#if !STORY_EDITION
// ═══════════════════════════════════════════════════════════════
// CraftAnywhere: Panel_Crafting.ItemPassesFilter Prefix/Postfix — 覆写蓝图制作位置
// 2.24 无 Il2CppTLD.Gear.BlueprintData(蓝图数据在 2.24 之后才拆到该命名空间)。
// ═══════════════════════════════════════════════════════════════
internal static class Patch_CraftAnywhere
{
    // v4.0r3: 旧 Postfix `__result = true` 一刀切让左侧分类按钮失效 ——
    //   vanilla ItemPassesFilter 同时做"位置检查"和"分类筛选",强制 true 把分类也覆盖了。
    //   改成 CraftAnywhereRedux 原版思路:Prefix 临时把 m_RequiredCraftingLocation 设为
    //   Anywhere,vanilla 内部位置检查通过 + 分类筛选独立工作;Postfix 还原原值。
    //
    // v8.0.1 修"任意制作不生效":上一版用 AccessTools.Field 找 m_RequiredCraftingLocation,
    //   永远返回 null,于是 Prefix 在 `if (_locField == null) return;` 就掉头,整个开关空转。
    //   Il2CppInterop 把 IL2CPP 实例成员一律生成成 property,interop 类上唯一的真字段是
    //   static NativeFieldInfoPtr_*,所以任何 GetField / AccessTools.Field 打在 Il2Cpp 类型
    //   上都拿不到东西。改成直接写属性:编译期校验成员存在(同类错误变成编译错误而不是
    //   静默失效),顺带省掉反射装箱。

    [System.ThreadStatic] private static CraftingLocation _saved;
    [System.ThreadStatic] private static bool _hasSaved;

    internal static void Prefix(BlueprintData bpi)
    {
        _hasSaved = false;
        if (!CheatState.Craft_Anywhere || bpi == null) return;
        try
        {
            _saved = bpi.m_RequiredCraftingLocation;
            _hasSaved = true;
            bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
        }
        catch { _hasSaved = false; }
    }

    internal static void Postfix(BlueprintData bpi)
    {
        if (!_hasSaved || bpi == null) return;
        try { bpi.m_RequiredCraftingLocation = _saved; } catch { }
        _hasSaved = false;
    }
}

// ═══════════════════════════════════════════════════════════════
// CraftAnywhere 第二道闸:BlueprintData.CanCraftAtLocation Postfix
// 上面那个只让蓝图在列表里"看得见";真正按下制作还要过位置检查这一关
// (不开免费制作时,CanCraftBlueprint 里的位置分支照样会拦)。这里直接放行。
// ═══════════════════════════════════════════════════════════════
internal static class Patch_CraftAnywhere_Location
{
    internal static void Postfix(ref bool __result)
    {
        if (CheatState.Craft_Anywhere) __result = true;
    }
}
#endif

// ═══════════════════════════════════════════════════════════════
// MapTextOutline: Panel_Map.CreateObjectPools Postfix — 地图文字描边
// ═══════════════════════════════════════════════════════════════
internal static class Patch_MapTextOutline
{
    internal static void Postfix(Panel_Map __instance)
    {
        if (!CheatState.QoL_MapTextOutline) return;
        try
        {
            int style = ModMain.Settings.QoL_MapTextOutline;
            var parent = __instance.m_TextPoolParent;
            for (int i = 0; i < parent.childCount; i++)
            {
                var label = parent.GetChild(i).GetComponent<UILabel>();
                if (label == null) continue;
                float a = 0.7f;
                switch (style)
                {
                    case 0:
                        ((UIWidget)label).color = new Color(0.125f, 0.094f, 0.094f, 1f);
                        label.effectStyle = UILabel.Effect.Outline;
                        label.effectColor = new Color(0.581f, 0.551f, 0.495f, a);
                        label.effectDistance = new Vector2(1.2f, 0.5f);
                        break;
                    case 1:
                        ((UIWidget)label).color = new Color(0.125f, 0.094f, 0.094f, 1f);
                        label.effectStyle = UILabel.Effect.Outline;
                        label.effectColor = new Color(1f, 1f, 1f, a);
                        label.effectDistance = new Vector2(1.2f, 0.5f);
                        break;
                    case 2:
                        ((UIWidget)label).color = new Color(0.88f, 0.83f, 0.735f, 1f);
                        label.effectStyle = UILabel.Effect.Outline;
                        label.effectColor = new Color(0.125f, 0.094f, 0.094f, a);
                        label.effectDistance = new Vector2(1.2f, 0.5f);
                        break;
                    default:
                        ((UIWidget)label).color = new Color(1f, 1f, 1f, 1f);
                        label.effectStyle = UILabel.Effect.Outline;
                        label.effectColor = new Color(0.125f, 0.094f, 0.094f, a);
                        label.effectDistance = new Vector2(1.2f, 0.5f);
                        break;
                }
            }
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════
// WakeUpCall: 睡眠中允许唤醒 + 极光唤醒 + 显示时间 + 微光
// ═══════════════════════════════════════════════════════════════
internal static class WakeUpCallState
{
    internal static bool WentSleepDuringAurora;
    internal const float FadeAlpha = 0.3f;
}

internal static class Patch_WakeUpCall_BeginSleeping
{
    internal static void Prefix(ref int __4, ref Il2CppSystem.Action __5)
    {
        if (!CheatState.QoL_WakeUpCall) return;
        try
        {
            WakeUpCallState.WentSleepDuringAurora = GameManager.GetAuroraManager().IsFullyActive();
            __4 = 4;

            var hud = InterfaceManager.GetPanel<Panel_HUD>();
            hud.m_AccelTimePopup.m_CancelCallback = (Il2CppSystem.Action)new System.Action(WakeUpCallHelper.WakeUp);

            ((Component)hud.m_Sprite_SystemFadeOverlay).transform.SetParent(hud.m_NonEssentialHud.transform);
            ((UIWidget)hud.m_Sprite_SystemFadeOverlay).depth = 0;
            ((UIRect)hud.m_Sprite_SystemFadeOverlay).OnEnable();
            hud.HideHudElements(true);

            __5 = (Il2CppSystem.Action)new System.Action(WakeUpCallHelper.PostWakeUp);

            float target = CheatState.QoL_NoPitchBlack ? WakeUpCallState.FadeAlpha : 1f;
#if STORY_EDITION
            StoryShim.FadeTo(target, 0.5f);   // 2.24 无 CameraFade.Fade,见 StoryCompat
#else
            CameraFade.Fade(0f, target, 0.5f, 0f, (Il2CppSystem.Action)null);
#endif
        }
        catch { }
    }
}

internal static class Patch_WakeUpCall_AuroraWake
{
    internal static void Postfix(AuroraManager __instance)
    {
        if (!CheatState.QoL_AuroraSense) return;
        try
        {
            if (GameManager.GetRestComponent().IsSleeping() && __instance.IsFullyActive() && !WakeUpCallState.WentSleepDuringAurora)
                WakeUpCallHelper.WakeUp();
        }
        catch { }
    }
}

internal static class Patch_WakeUpCall_TimeWidget
{
    internal static void Prefix(ref bool active)
    {
        if (!CheatState.QoL_ShowTimeSleep) return;
        try
        {
            if (GameManager.GetRestComponent().IsSleeping() && !active)
                active = true;
        }
        catch { }
    }
}

internal static class Patch_WakeUpCall_RestEnable
{
    internal static void Postfix(bool enable)
    {
        if (!CheatState.QoL_NoPitchBlack) return;
        try
        {
            if (GameManager.GetRestComponent().IsSleeping() && !enable)
                GameManager.GetCameraEffects().DepthOfFieldTurnOn();
        }
        catch { }
    }
}

internal static class WakeUpCallHelper
{
    public static void WakeUp()
    {
        try { GameManager.GetRestComponent().m_InterruptionAfterSecondsSleeping = 1; }
        catch { }
    }

    public static void PostWakeUp()
    {
        try
        {
            var hud = InterfaceManager.GetPanel<Panel_HUD>();
            ((Component)hud.m_Sprite_SystemFadeOverlay).transform.SetParent(((Component)hud).transform);
            ((UIWidget)hud.m_Sprite_SystemFadeOverlay).depth = 50;
            hud.HideHudElements(false);
            if (CheatState.QoL_NoPitchBlack)
                GameManager.GetCameraEffects().DepthOfFieldTurnOff(false);
            float from = CheatState.QoL_NoPitchBlack ? WakeUpCallState.FadeAlpha : 1f;
#if STORY_EDITION
            StoryShim.FadeTo(0f, 0.5f);       // 2.24 无 CameraFade.Fade
#else
            CameraFade.Fade(from, 0f, 0.5f, 0f, (Il2CppSystem.Action)null);
#endif
            if (CheatState.QoL_ShowTimeSleep)
                InterfaceManager.GetInstance().SetTimeWidgetActive(false);
        }
        catch { }
    }

    private static bool _overlayMoved;

    public static void OnUpdateTick()
    {
        if (!CheatState.QoL_WakeUpCall && !CheatState.QoL_AuroraSense) return;
        try
        {
            var rest = GameManager.GetRestComponent();
            if (rest != null && rest.IsSleeping())
            {
                _overlayMoved = true;
                if (InputManager.GetPauseMenuTogglePressed(InputManager.m_CurrentContext))
                    WakeUp();
            }
            else if (_overlayMoved)
            {
                // 安全网: 不在睡眠状态但 overlay 可能残留 → 强制恢复
                _overlayMoved = false;
                try { PostWakeUp(); } catch { }
            }
        }
        catch { }
    }
}

// v2.8.1 Bug 5+6 安全网: 睡眠结束后强制恢复 HUD overlay 防黑屏
internal static class Patch_WakeUpCall_EndSleeping_Safety
{
    internal static void Postfix()
    {
        if (!CheatState.QoL_WakeUpCall && !CheatState.QoL_AuroraSense) return;
        try { WakeUpCallHelper.PostWakeUp(); } catch { }
    }
}

// ═══════════════════════════════════════════════════════════════
// BuryHumanCorpses: Alt 交互埋葬人类尸体
// 完全照抄 TinyTweaks-BuryHumanCorpses v1.3.0
// ═══════════════════════════════════════════════════════════════
internal static class BuryCorpsesState
{
    public static readonly string SaveDataTag = "buryCorpses";
    public static ModDataManager DataManager = new ModDataManager("TinyTweaks");
    public static readonly int HoursToBury = 1;
    public static readonly float SecondsToInteract = 3f;
    public static Dictionary<string, List<string>> BuriedCorpses = new Dictionary<string, List<string>>();
    public static bool Interrupted;
    public static bool InProgress;

    public static bool IsCorpse(GameObject corpse)
    {
        if (corpse != null && corpse.GetComponent<Container>() == null)
        {
            var parent = corpse.transform.GetParent();
            corpse = (parent != null) ? parent.gameObject : null;
        }
        if (corpse == null || corpse.GetComponent<Container>() == null || !corpse.GetComponent<Container>().m_IsCorpse)
            return false;
        return true;
    }

    public static GameObject GetGameObjectUnderCrosshair()
    {
        PlayerManager pm = GameManager.GetPlayerManagerComponent();
        float maxRange = GameManager.GetGlobalParameters().m_MaxPickupRange;
        float range = pm.ComputeModifiedPickupRange(maxRange);
        if ((int)pm.GetControlMode() == 16)
            range = 50f;
        return pm.GetInteractiveObjectUnderCrosshairs(range);
    }

    public static IEnumerator BuryCorpse(GameObject corpse)
    {
        GameManager.GetPlayerVoiceComponent().BlockNonCriticalVoiceForDuration(10f);
        Interrupted = false;
        InProgress = true;
#if STORY_EDITION
        // 2.24 Launch(string, float, float, float, string, string, bool, bool, OnExitDelegate)
        // 比 2.55 多两个音效名参数和一个 supressHeavyBreathing。
        InterfaceManager.GetPanel<Panel_GenericProgressBar>().Launch(
            I18n.T("埋葬遗体", "Bury a friend"), SecondsToInteract, (float)HoursToBury * 60f, 0f,
            string.Empty, string.Empty, true, false, (OnExitDelegate)null);
#else
        InterfaceManager.GetPanel<Panel_GenericProgressBar>().Launch(
            I18n.T("埋葬遗体", "Bury a friend"), SecondsToInteract, (float)HoursToBury * 60f, 0f, true, (OnExitDelegate)null);
#endif
        while (InProgress)
        {
            yield return new WaitForEndOfFrame();
        }
        if (!Interrupted)
        {
            corpse.active = false;
            var crows = corpse.GetComponent<Carrion>();
            if (crows != null)
                crows.Destroy();
#if STORY_EDITION
            // 2.24 ObjectGuid 只有实例 Get(),没有 static GetGuidFromGameObject
            string guid = null;
            try { var og = corpse.GetComponent<ObjectGuid>(); if (og != null) guid = og.Get(); } catch { }
#else
            string guid = ObjectGuid.GetGuidFromGameObject(corpse);
#endif
            if (BuriedCorpses.ContainsKey(GameManager.m_ActiveScene))
            {
                BuriedCorpses[GameManager.m_ActiveScene].Add(guid);
            }
            else
            {
                BuriedCorpses[GameManager.m_ActiveScene] = new List<string> { guid };
            }
        }
    }
}

internal static class Patch_BuryCorpses_AltFire
{
    internal static void Prefix()
    {
        if (!CheatState.QoL_BuryCorpses) return;
        try
        {
            if (GameManager.GetPlayerManagerComponent() == null) return;
            GameObject obj = BuryCorpsesState.GetGameObjectUnderCrosshair();
            if (BuryCorpsesState.IsCorpse(obj))
                MelonCoroutines.Start(BuryCorpsesState.BuryCorpse(obj));
        }
        catch { }
    }
}

internal static class Patch_BuryCorpses_HoverText
{
    internal static void Prefix(ref GameObject itemUnderCrosshairs)
    {
        if (!CheatState.QoL_BuryCorpses) return;
        try
        {
            if (BuryCorpsesState.IsCorpse(itemUnderCrosshairs))
            {
                var hud = InterfaceManager.GetPanel<Panel_HUD>();
                hud.m_EquipItemPopup.enabled = true;
                hud.m_EquipItemPopup.ShowGenericPopupWithDefaultActions(I18n.T("搜索", "Search"), I18n.T("埋葬", "Bury"));
            }
        }
        catch { }
    }
}

internal static class Patch_BuryCorpses_ProgressBarEnded
{
    internal static void Prefix(ref bool success, ref bool playerCancel)
    {
        if (!CheatState.QoL_BuryCorpses) return;
        try
        {
            if (BuryCorpsesState.InProgress)
            {
                if (!success)
                    BuryCorpsesState.Interrupted = true;
                BuryCorpsesState.InProgress = false;
            }
        }
        catch { }
    }
}

internal static class Patch_BuryCorpses_SaveScene
{
    internal static void Prefix(ref SlotData slot)
    {
        if (!CheatState.QoL_BuryCorpses) return;
        try
        {
            string data = JsonSerializer.Serialize(BuryCorpsesState.BuriedCorpses);
            BuryCorpsesState.DataManager.Save(data, BuryCorpsesState.SaveDataTag);
        }
        catch { }
    }
}

internal static class Patch_BuryCorpses_LoadScene
{
    internal static void Postfix(ref string name)
    {
        if (!CheatState.QoL_BuryCorpses) return;
        try
        {
            string text = BuryCorpsesState.DataManager.Load(BuryCorpsesState.SaveDataTag);
            if (!string.IsNullOrEmpty(text))
            {
                BuryCorpsesState.BuriedCorpses = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(text) ?? new Dictionary<string, List<string>>();
            }
            if (!BuryCorpsesState.BuriedCorpses.ContainsKey(GameManager.m_ActiveScene))
                return;
            foreach (string guid in BuryCorpsesState.BuriedCorpses[GameManager.m_ActiveScene])
            {
                Container c = ContainerManager.FindContainerByGuid(guid);
                if (c != null)
                    ((Component)c).gameObject.SetActive(false);
            }
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════
// SleepWithoutABed: 无床睡觉(创建临时虚拟睡袋)
// 完全照抄 SleepWithoutABed v2.3.1 by Ezinw
// ═══════════════════════════════════════════════════════════════
internal static class SleepAnywhereState
{
    public static GearItem TempBedroll;

    public static float FatigueRecoveryPenalty = 0.75f;
    public static float ConditionGainRate = 0.5f;
    public static float FreezingScale = 1.75f;
    public static float FreezingHealthLoss = 1.2f;
    public static float HypothermicHealthLoss = 1.4f;
    public static float PassTimeExposurePenalty = 0.75f;
    public static float SleepInterruptionThreshold = 0.1f;
    public static float InterruptionCooldown = 15f;
    public static bool LowHealthInterrupt = true;
    public static bool HudMessage = true;
    public static bool ApplyInterruptToBeds = true;
    public static float SensitivityScale = 0.2f;
    public static float AdjustedSensitivity = 0.75f;

    public static float ApplyExposurePenalty()
    {
        var weather = GameManager.GetWeatherComponent();
        float ambientTemp = (weather != null) ? weather.GetCurrentTemperatureWithWindchill() : 0f;
        var pm = GameManager.GetPlayerManagerComponent();
        float warmth = 0f;
        if (pm != null)
            warmth = pm.m_WarmthBonusFromClothing + pm.m_WindproofBonusFromClothing;
        float effectiveTemp = ambientTemp + warmth;
        if (effectiveTemp >= 0f) return 0f;
        float diff = 0f - effectiveTemp;
        float scaled = SensitivityScale * diff;
        float adjusted = AdjustedSensitivity + scaled;
        return diff * adjusted;
    }

    public static float GetMaxCondition()
    {
        var cond = GameManager.GetConditionComponent();
        return (cond != null) ? cond.m_MaxHP : 100f;
    }
}

internal static class Patch_SleepAnywhere_RestEnable
{
    internal static void Prefix(Panel_Rest __instance, ref bool enable, ref bool passTimeOnly)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            passTimeOnly = false;
            if (enable)
            {
                if (__instance.m_Bed != null)
                {
                    var tb = SleepAnywhereState.TempBedroll;
                    if (__instance.m_Bed != ((tb != null) ? ((Component)tb).GetComponent<Bed>() : null))
                        return;
                }
                if (__instance.m_Bed != null || SleepAnywhereState.TempBedroll != null)
                    return;

#if STORY_EDITION
                GearItem prefab = StoryShim.LoadGearItemPrefab("GEAR_BedRoll");
#else
                GearItem prefab = GearItem.LoadGearItemPrefab("GEAR_BedRoll");
#endif
                if (prefab == null) return;
                GearItem item = GearItem.InstantiateDepletedGearPrefab(((Component)prefab).gameObject).GetComponent<GearItem>();
#if STORY_EDITION
                // 2.24 的 StoryShim 已经实例化了一件,复制完就销毁,别留一个床卷在场景里
                try { GearManager.DestroyGearObject(((Component)prefab).gameObject); } catch { }
#endif
                if (item != null)
                {
                    item.m_CurrentHP = Mathf.Max(2f, item.m_CurrentHP);
                    item.m_WornOut = false;
                    item.m_InPlayerInventory = false;
                    ((Component)item).gameObject.transform.position = GameManager.GetPlayerTransform().position;
                    ((Component)item).gameObject.SetActive(true);
                    Bed bed = ((Component)item).GetComponent<Bed>();
                    if (bed != null)
                    {
                        __instance.m_Bed = bed;
                        SleepAnywhereState.TempBedroll = item;
                        bed.m_OpenAudio = null;
                        bed.m_CloseAudio = null;
                        bed.SetState((BedRollState)1);
                    }
                }
            }
            else
            {
                if (__instance.m_Bed != null)
                {
                    var tb = SleepAnywhereState.TempBedroll;
                    if (__instance.m_Bed != ((tb != null) ? ((Component)tb).GetComponent<Bed>() : null) &&
                        !GameManager.GetRestComponent().IsSleeping())
                    {
                        __instance.m_Bed = null;
                    }
                }
                if (__instance.m_Bed != null)
                {
                    var tb = SleepAnywhereState.TempBedroll;
                    if (__instance.m_Bed == ((tb != null) ? ((Component)tb).GetComponent<Bed>() : null) &&
                        !GameManager.GetRestComponent().IsSleeping() &&
                        SleepAnywhereState.TempBedroll != null)
                    {
                        GearManager.DestroyGearObject(((Component)SleepAnywhereState.TempBedroll).gameObject);
                        SleepAnywhereState.TempBedroll = null;
                        __instance.m_Bed = null;
                    }
                }
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_RadialPassTime
{
    internal static void Postfix()
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            Panel_Rest panel = InterfaceManager.GetPanel<Panel_Rest>();
            if (panel != null)
            {
                panel.m_ShowPassTime = true;
                panel.m_ShowPassTimeOnly = false;
                panel.m_RestOnlyObject.SetActive(false);
                panel.m_PassTimeOnlyObject.SetActive(true);
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_ButtonLegend
{
    internal static void Postfix(Panel_Rest __instance)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            if (SleepAnywhereState.TempBedroll != null)
            {
                var tb = SleepAnywhereState.TempBedroll;
                if (__instance.m_Bed == ((Component)tb).GetComponent<Bed>() && __instance.m_PickUpButton.activeSelf)
                {
                    Utils.SetActive(__instance.m_PickUpButton, false);
                    __instance.m_SleepButton.transform.localPosition = __instance.m_SleepButtonCenteredPos;
                }
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_OnRest
{
    internal static void Postfix(Panel_Rest __instance)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            if (GameManager.m_IsPaused || GameManager.s_IsGameplaySuspended) return;
            Rest rest = GameManager.GetRestComponent();
            Freezing freezing = GameManager.GetFreezingComponent();
            Condition condition = GameManager.GetConditionComponent();
            Hypothermia hypothermia = GameManager.GetHypothermiaComponent();
            if (__instance == null || rest == null || freezing == null || condition == null || hypothermia == null) return;

            bool isTempBed = false;
            if (__instance.m_Bed != null)
            {
                var tb = SleepAnywhereState.TempBedroll;
                if (__instance.m_Bed == ((tb != null) ? ((Component)tb).GetComponent<Bed>() : null))
                    isTempBed = true;
            }
            if (__instance.m_Bed == null)
                isTempBed = true;

            if (isTempBed)
            {
                var tb = SleepAnywhereState.TempBedroll;
                __instance.m_Bed = (tb != null) ? ((Component)tb).GetComponent<Bed>() : null;
            }

            rest.m_ReduceFatiguePerHourRest = 8.33f;
            freezing.m_FreezingIncreasePerHourPerDegreeCelsius = 6f;
            condition.m_HPDecreasePerDayFromFreezing = 450f;
            hypothermia.m_HPDrainPerHour = 40f;

            if (SleepAnywhereState.TempBedroll != null)
            {
                var tb = SleepAnywhereState.TempBedroll;
                if (__instance.m_Bed == ((Component)tb).GetComponent<Bed>())
                {
                    float exposure = SleepAnywhereState.ApplyExposurePenalty();
                    rest.m_ReduceFatiguePerHourRest = 8.33f * SleepAnywhereState.FatigueRecoveryPenalty;
                    freezing.m_FreezingIncreasePerHourPerDegreeCelsius = 6f * SleepAnywhereState.FreezingScale;
                    condition.m_HPDecreasePerDayFromFreezing = 450f * SleepAnywhereState.FreezingHealthLoss + exposure;
                    hypothermia.m_HPDrainPerHour = 40f * SleepAnywhereState.HypothermicHealthLoss + exposure;
                }
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_ConditionRecovery
{
    internal static void Postfix(Rest __instance)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            if (__instance == null || __instance.m_Bed == null || GameManager.m_IsPaused || GameManager.s_IsGameplaySuspended)
                return;
            __instance.m_Bed.m_ConditionPercentGainPerHour = 1f;
            __instance.m_Bed.m_UinterruptedRestPercentGainPerHour = 1f;
            if (SleepAnywhereState.TempBedroll != null)
            {
                var tb = SleepAnywhereState.TempBedroll;
                if (__instance.m_Bed == ((Component)tb).GetComponent<Bed>())
                {
                    __instance.m_Bed.m_ConditionPercentGainPerHour = 1f * SleepAnywhereState.ConditionGainRate;
                    __instance.m_Bed.m_UinterruptedRestPercentGainPerHour = 1f * SleepAnywhereState.ConditionGainRate;
                }
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_SleepInterruption
{
    private static float _lastInterruptTime = -1f;
    private static bool _lastWasCondition;

    internal static void Postfix(Rest __instance)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        if (!SleepAnywhereState.LowHealthInterrupt) return;
        try
        {
            if (__instance == null || GameManager.GetPlayerManagerComponent().PlayerIsDead()) return;
            bool isTempBed = SleepAnywhereState.TempBedroll != null;
            if (__instance.m_Bed != null && !isTempBed && !SleepAnywhereState.ApplyInterruptToBeds)
                return;

            Condition cond = GameManager.GetConditionComponent();
            Freezing freezing = GameManager.GetFreezingComponent();
            if (cond == null || freezing == null) return;

            float maxHP = SleepAnywhereState.GetMaxCondition();
            float hpRatio = cond.m_CurrentHP / maxHP;
            bool isFreezing = freezing.IsFreezing();
            float time = UnityEngine.Time.time;

            if (_lastWasCondition && _lastInterruptTime >= 0f &&
                time - _lastInterruptTime < SleepAnywhereState.InterruptionCooldown)
                return;

            if (hpRatio < SleepAnywhereState.SleepInterruptionThreshold && isFreezing)
            {
                __instance.EndSleeping(true);
                _lastInterruptTime = time;
                _lastWasCondition = true;
                if (SleepAnywhereState.HudMessage)
                    HUDMessage.AddMessage(I18n.T("你即将坠入漫漫长夜。快寻找庇护和温暖！", "You are about to fade into the long dark. Seek shelter and warmth!"), 5f, false, false);
#if STORY_EDITION
                StoryShim.FadeIn(0.5f);       // 2.24 无 CameraFade.FadeIn
#else
                CameraFade.FadeIn(0.5f, 0f, (Il2CppSystem.Action)null);
#endif
            }
            else
            {
                _lastWasCondition = false;
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_EndSleeping
{
    internal static void Postfix(Rest __instance, ref bool interrupted)
    {
        // v7.7 修临时床卷泄漏:这是销毁临时 bedroll、把 Rest.m_Bed 置空的唯一路径,
        //   原先和「注入床卷」共用 QoL_SleepAnywhere 门控 —— 野外睡觉途中把开关关掉,
        //   这个 Postfix 就不再执行,假床对象泄漏且 m_Bed 继续指向它(后续休息/存档行为未定义)。
        //   现在只要还有临时床卷需要清理就允许执行。
        if (!CheatState.QoL_SleepAnywhere && SleepAnywhereState.TempBedroll == null) return;
        try
        {
            if (__instance == null) return;
            // 开关已关时正常睡醒也要销毁:平时负责销毁的 Panel_Rest.Enable(false) 那条路径随开关卸了
            if (SleepAnywhereState.TempBedroll != null && (interrupted || !CheatState.QoL_SleepAnywhere))
            {
                GearManager.DestroyGearObject(((Component)SleepAnywhereState.TempBedroll).gameObject);
                SleepAnywhereState.TempBedroll = null;
            }
            __instance.m_Bed = null;
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_PassTimeExposure
{
    internal static void Postfix(Panel_Rest __instance)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            if (GameManager.m_IsPaused || GameManager.s_IsGameplaySuspended) return;
            Freezing freezing = GameManager.GetFreezingComponent();
            Condition condition = GameManager.GetConditionComponent();
            Hypothermia hypothermia = GameManager.GetHypothermiaComponent();
            if (__instance == null || freezing == null || condition == null || hypothermia == null) return;

            bool isTempBed = false;
            if (__instance.m_Bed != null)
            {
                var tb = SleepAnywhereState.TempBedroll;
                if (__instance.m_Bed == ((tb != null) ? ((Component)tb).GetComponent<Bed>() : null))
                    isTempBed = true;
            }
            if (__instance.m_Bed == null)
                isTempBed = true;

            if (isTempBed)
            {
                var tb = SleepAnywhereState.TempBedroll;
                __instance.m_Bed = (tb != null) ? ((Component)tb).GetComponent<Bed>() : null;
            }

            freezing.m_FreezingIncreasePerHourPerDegreeCelsius = 6f;
            condition.m_HPDecreasePerDayFromFreezing = 450f;
            hypothermia.m_HPDrainPerHour = 40f;

            if (SleepAnywhereState.TempBedroll != null)
            {
                var tb = SleepAnywhereState.TempBedroll;
                if (__instance.m_Bed == ((Component)tb).GetComponent<Bed>())
                {
                    float exposure = SleepAnywhereState.ApplyExposurePenalty();
                    float ptPenalty = SleepAnywhereState.PassTimeExposurePenalty;
                    float freezeRate = 6f * SleepAnywhereState.FreezingScale;
                    float hpFromFreezing = 450f * SleepAnywhereState.FreezingHealthLoss + exposure;
                    float hypothermiaDrain = 40f * SleepAnywhereState.HypothermicHealthLoss + exposure;
                    freezing.m_FreezingIncreasePerHourPerDegreeCelsius = freezeRate * ptPenalty;
                    condition.m_HPDecreasePerDayFromFreezing = hpFromFreezing * ptPenalty;
                    hypothermia.m_HPDrainPerHour = hypothermiaDrain * ptPenalty;
                }
            }
        }
        catch { }
    }
}

internal static class Patch_SleepAnywhere_RestPanelClose
{
    internal static void Postfix(PlayerManager __instance, ref bool __result)
    {
        if (!CheatState.QoL_SleepAnywhere) return;
        try
        {
            if (__instance == null || GameManager.m_IsPaused || GameManager.s_IsGameplaySuspended) return;
            if (__result)
            {
                Panel_Rest panel = InterfaceManager.GetPanel<Panel_Rest>();
                if (panel != null && ((Panel_Base)panel).IsEnabled())
                    ((Panel_Base)panel).Enable(false);
            }
        }
        catch { }
    }
}
