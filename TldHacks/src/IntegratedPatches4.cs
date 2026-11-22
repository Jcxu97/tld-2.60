using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppAK;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.IntBackedUnit;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.Interactions;
#endif
using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════
// CarcassMoving: 搬运猎物尸骸(鹿/狼)跨场景
// ═══════════════════════════════════════════════════════════════

internal class CarcassMovingBehaviour : MonoBehaviour
{
    static CarcassMovingBehaviour() => ClassInjector.RegisterTypeInIl2Cpp<CarcassMovingBehaviour>();
    public CarcassMovingBehaviour(IntPtr ptr) : base(ptr) { }

    void Update()
    {
        if (CarcassMovingState.SaveTrigger)
        {
            CarcassMovingState.SaveTrigger = false;
            try { GearManager.UpdateAll(); GameManager.TriggerSurvivalSaveAndDisplayHUDMessage(); } catch { }
        }
        if (GameManager.m_IsPaused || !CarcassMovingState.IsCarrying) return;
        if (!CheatState.World_CarcassMoving) { CarcassMovingState.Drop(); return; }
        CarcassMovingState.DisplayDropHint();
        var struggle = GameManager.GetPlayerStruggleComponent();
        if ((Input.GetMouseButtonDown(1) && Time.time - CarcassMovingState.PickUpTime > 0.5f) ||
            CarcassMovingState.HasInjuryPreventing() ||
            (struggle != null && struggle.InStruggle()))
            CarcassMovingState.Drop();
    }
}

internal static class CarcassMovingState
{
    internal static GameObject MoveBtnObj;
    internal static GameObject CarcassObj;
    internal static BodyHarvest Harvest;
    internal static string OriginalScene;
    internal static float Weight;
    internal static bool IsCarrying;
    internal static bool SaveTrigger;
    internal static float PickUpTime;
    private static HashSet<int> _enabledColliders;

    internal static bool IsMovable(BodyHarvest bh)
    {
        var n = ((UnityEngine.Object)bh).name;
        if (n.Contains("Quarter")) return false;
        if (n.Contains("Doe") || n.Contains("Stag") || n.Contains("Deer") || n.Contains("Wolf")) return true;
        if (CheatState.World_CarcassMovingAll && (n.Contains("Bear") || n.Contains("Moose") || n.Contains("Cougar"))) return true;
        return false;
    }

    internal static bool HasInjuryPreventing() =>
        GameManager.GetSprainedAnkleComponent().HasSprainedAnkle() ||
        GameManager.GetSprainedWristComponent().HasSprainedWrist() ||
        GameManager.GetBrokenRibComponent().HasBrokenRib();

    internal static void PickUp()
    {
        IsCarrying = true;
        PickUpTime = Time.time;
#if STORY_EDITION
        // 2.24 这三个都返回裸 float(2.55 才换成 ItemWeight)
        Weight = Harvest.m_MeatAvailableKG + Harvest.GetGutsAvailableWeightKg() + Harvest.GetHideAvailableWeightKg();
#else
        ItemWeight mw = Harvest.m_MeatAvailableKG;
        ItemWeight gw = Harvest.GetGutsAvailableWeightKg();
        ItemWeight hw = Harvest.GetHideAvailableWeightKg();
        Weight = ((ItemWeight)mw).ToQuantity(1f) + ((ItemWeight)gw).ToQuantity(1f) + ((ItemWeight)hw).ToQuantity(1f);
#endif
        OriginalScene = GameManager.m_ActiveScene;
#if !STORY_EDITION
        MapMCorpse.Remove(CarcassObj);
#endif
        if (CarcassObj.GetComponent<CarcassMovingBehaviour>() == null)
            CarcassObj.AddComponent<CarcassMovingBehaviour>();
        GameManager.GetPlayerManagerComponent().UnequipItemInHands();
        SetCarcassVisible(false);
        GameAudioManager.PlaySound("Play_RopeGetOn", InterfaceManager.GetSoundEmitter());
        GameAudioManager.PlaySound(EVENTS.PLAY_EXERTIONLOW, InterfaceManager.GetSoundEmitter());
    }

    internal static void Drop()
    {
        IsCarrying = false;
        DropInFrontOfPlayer();
        SetCarcassVisible(true);
        if (Harvest != null) ((Behaviour)Harvest).enabled = true;
        var activeScene = SceneManager.GetActiveScene();
        var root = ((Component)CarcassObj.transform.root).gameObject;
        if (root.scene != activeScene)
        {
            SceneManager.MoveGameObjectToScene(root, activeScene);
            if (Harvest != null) BodyHarvestManager.AddBodyHarvest(Harvest);
        }
        GameAudioManager.PlaySound(EVENTS.PLAY_BODYFALLLARGE, InterfaceManager.GetSoundEmitter());
#if !STORY_EDITION
        MapMCorpse.Show(CarcassObj);
#endif
        var cmb = CarcassObj.GetComponent<CarcassMovingBehaviour>();
        if (cmb != null) UnityEngine.Object.Destroy(cmb);
        Harvest = null;
        CarcassObj = null;
    }

    internal static void MoveToPlayer()
    {
        CarcassObj.transform.position = GameManager.GetPlayerTransform().position;
        CarcassObj.transform.rotation = GameManager.GetPlayerTransform().rotation * Quaternion.Euler(0f, 90f, 0f);
    }

    internal static void DropInFrontOfPlayer()
    {
        var pt = GameManager.GetPlayerTransform();
        var fwd = pt.forward;
        fwd.y = 0f;
        if (fwd.sqrMagnitude < 0.01f) fwd = Vector3.forward;
        else fwd.Normalize();
        CarcassObj.transform.position = pt.position + fwd * 2f;
        CarcassObj.transform.rotation = pt.rotation * Quaternion.Euler(0f, 90f, 0f);
    }

    internal static void SetCarcassVisible(bool visible)
    {
        if (!visible)
        {
            _enabledColliders = new HashSet<int>();
            foreach (var c in CarcassObj.GetComponentsInChildren<Collider>(true))
            {
                if (c.enabled) _enabledColliders.Add(c.GetInstanceID());
                c.enabled = false;
            }
        }
        else
        {
            foreach (var c in CarcassObj.GetComponentsInChildren<Collider>(true))
            {
                c.enabled = _enabledColliders != null && _enabledColliders.Contains(c.GetInstanceID());
            }
            _enabledColliders = null;
        }
        foreach (var r in CarcassObj.GetComponentsInChildren<Renderer>(true))
            r.enabled = visible;
    }

    internal static void AddToSceneSaveData()
    {
        BodyHarvestManager.AddBodyHarvest(Harvest);
        SceneManager.MoveGameObjectToScene(((Component)CarcassObj.transform.root).gameObject, SceneManager.GetActiveScene());
    }

    private static float _lastHintTime;
    internal static void DisplayDropHint()
    {
        if (Time.time - _lastHintTime < 5f) return;
        _lastHintTime = Time.time;
        HUDMessage.AddMessage(I18n.T("右键放下猎物", "Right-click to drop carcass"), false, false);
    }

    internal static bool IsBtnAlive() =>
        MoveBtnObj != null && (bool)(UnityEngine.Object)MoveBtnObj;

    // 搬运按钮是"采集"按钮的兄弟节点(和"拆块"按钮同一父节点、同一原点)。
    // 原版 Refresh 每帧按 tab 开关采集/拆块按钮,所以搬运按钮也要在 Refresh 后同步,
    // 否则切到拆块 tab 时它会盖住拆块按钮。位置一律按原点绝对设置,不做 += 累加。
    private static readonly Dictionary<int, Vector3> _harvestBtnOrigin = new Dictionary<int, Vector3>();
    private static bool _wantMoveBtn;
    private static readonly Vector3 BtnOffset = new Vector3(100f, 0f, 0f);

    private static Vector3 GetHarvestOrigin(GameObject harvestBtn)
    {
        int id = harvestBtn.GetInstanceID();
        if (!_harvestBtnOrigin.TryGetValue(id, out var origin))
        {
            origin = harvestBtn.transform.localPosition;
            _harvestBtnOrigin[id] = origin;
        }
        return origin;
    }

    private static void SetLocalPos(Transform t, Vector3 p)
    {
        if (t.localPosition != p) t.localPosition = p;
    }

    internal static void AddMoveButton(Panel_BodyHarvest panel)
    {
        var harvestBtn = panel.m_Mouse_Button_Harvest;
        if (harvestBtn == null) return;
        var parent = harvestBtn.transform.parent;
        if (IsBtnAlive() && MoveBtnObj.transform.parent != parent)
        {
            UnityEngine.Object.Destroy(MoveBtnObj);
            MoveBtnObj = null;
        }
        if (!IsBtnAlive())
        {
            GetHarvestOrigin(harvestBtn);
            MoveBtnObj = UnityEngine.Object.Instantiate(harvestBtn, parent);
            MoveBtnObj.name = "TldHacks_CarryCarcassButton";
            MoveBtnObj.transform.localScale = harvestBtn.transform.localScale;
            foreach (var loc in MoveBtnObj.GetComponentsInChildren<UILocalize>(true))
                ((Behaviour)loc).enabled = false;
            var lbl = MoveBtnObj.GetComponentInChildren<UILabel>(true);
            if (lbl != null) lbl.text = I18n.T("搬运猎物", "Carry");
            // 采集按钮根节点上挂了 3 个 UIButton,全部清掉,只在第一个上挂回调
            var btns = MoveBtnObj.GetComponentsInChildren<UIButton>(true);
            foreach (var b in btns) b.onClick.Clear();
            if (btns.Length > 0)
            {
                EventDelegate.Callback cb = new System.Action(OnMoveClicked);
                btns[0].onClick.Add(new EventDelegate(cb));
            }
        }
        _wantMoveBtn = true;
        SyncMoveButton(panel);
    }

    internal static void RemoveMoveButton(Panel_BodyHarvest panel)
    {
        _wantMoveBtn = false;
        if (IsBtnAlive())
            MoveBtnObj.SetActive(false);
        var harvestBtn = panel?.m_Mouse_Button_Harvest;
        if (harvestBtn != null && _harvestBtnOrigin.TryGetValue(harvestBtn.GetInstanceID(), out var origin))
            SetLocalPos(harvestBtn.transform, origin);
    }

    // 由 Panel_BodyHarvest.Refresh 的 Postfix 每帧调用(原版 Refresh 刚设置完采集/拆块按钮的显隐)
    internal static void SyncMoveButton(Panel_BodyHarvest panel)
    {
        if (!_wantMoveBtn || !IsBtnAlive()) return;
        var harvestBtn = panel.m_Mouse_Button_Harvest;
        if (harvestBtn == null) return;
        var origin = GetHarvestOrigin(harvestBtn);
        SetLocalPos(harvestBtn.transform, origin - BtnOffset);
        SetLocalPos(MoveBtnObj.transform, origin + BtnOffset);

        bool show = panel.IsTabHarvestSelected() && !panel.IsHarvestingOrQuartering();
        if (MoveBtnObj.activeSelf != show) MoveBtnObj.SetActive(show);
        if (!show) return;
        // 克隆时会连同采集按钮当时的禁用状态一起复制,这里强制可点
        foreach (var b in MoveBtnObj.GetComponentsInChildren<UIButton>(true))
            if (!b.isEnabled) b.isEnabled = true;
        foreach (var c in MoveBtnObj.GetComponentsInChildren<Collider>(true))
            if (!c.enabled) c.enabled = true;
    }

    internal static void OnMoveClicked()
    {
        if (HasInjuryPreventing())
        {
            GameAudioManager.PlayGUIError();
            HUDMessage.AddMessage(I18n.T("受伤时无法搬运猎物", "Cannot carry while injured"), false, false);
            return;
        }
        PickUp();
        InterfaceManager.GetPanel<Panel_BodyHarvest>().OnBack();
    }
}

// --- CarcassMoving Patches ---

internal static class Patch_Carcass_CanEnable
{
    internal static void Postfix(BodyHarvest bodyHarvest, ref bool __result)
    {
        if (!CheatState.World_CarcassMoving) return;
        if (bodyHarvest.GetCondition() > 0f) __result = true;
    }
}

internal static class Patch_Carcass_PanelEnable
{
    internal static void Postfix(Panel_BodyHarvest __instance, BodyHarvest bh, bool enable)
    {
        if (!CheatState.World_CarcassMoving) return;
        try
        {
            if (!enable)
            {
                CarcassMovingState.RemoveMoveButton(__instance);
                return;
            }
            bool canEn = __instance.CanEnable(bh);
            bool movable = bh != null && CarcassMovingState.IsMovable(bh);
            if (!canEn) return;
            if (CarcassMovingState.IsCarrying) CarcassMovingState.Drop();
            if (movable && !CarcassMovingState.IsCarrying)
            {
                CarcassMovingState.Harvest = bh;
                CarcassMovingState.CarcassObj = ((Component)bh).gameObject;
                CarcassMovingState.AddMoveButton(__instance);
            }
            else
                CarcassMovingState.RemoveMoveButton(__instance);
        }
        catch (Exception ex) { MelonLoader.MelonLogger.Msg($"[CarcassMove] PanelEnable exception: {ex}"); }
    }
}

internal static class Patch_Carcass_PanelRefresh
{
    internal static void Postfix(Panel_BodyHarvest __instance)
    {
        try { CarcassMovingState.SyncMoveButton(__instance); }
        catch (Exception ex) { MelonLoader.MelonLogger.Msg($"[CarcassMove] Refresh sync exception: {ex.Message}"); }
    }
}

internal static class Patch_Carcass_SceneLoaded
{
    internal static void Postfix()
    {
        if (!CheatState.World_CarcassMoving || !CarcassMovingState.IsCarrying) return;
        try
        {
            if (CarcassMovingState.CarcassObj == null) { CarcassMovingState.IsCarrying = false; return; }
            if (CarcassMovingState.Harvest != null) ((Behaviour)CarcassMovingState.Harvest).enabled = true;
            CarcassMovingState.SaveTrigger = true;
        }
        catch { }
    }
}

internal static class Patch_Carcass_LoadScene
{
    internal static void Postfix()
    {
        if (!CheatState.World_CarcassMoving || !CarcassMovingState.IsCarrying) return;
        if (CarcassMovingState.CarcassObj == null) return;
        try
        {
            UnityEngine.Object.DontDestroyOnLoad(((Component)CarcassMovingState.CarcassObj.transform.root).gameObject);
            ((Behaviour)CarcassMovingState.Harvest).enabled = false;
        }
        catch { }
    }
}

internal static class Patch_Carcass_BeforeSave
{
    internal static void Prefix()
    {
        if (!CheatState.World_CarcassMoving || !CarcassMovingState.IsCarrying || CarcassMovingState.Harvest == null) return;
        try
        {
            ((Behaviour)CarcassMovingState.Harvest).enabled = true;
            CarcassMovingState.MoveToPlayer();
            CarcassMovingState.AddToSceneSaveData();
        }
        catch { }
    }
}

internal static class Patch_Carcass_NoSprint
{
    internal static void Postfix(ref bool __result)
    {
        if (CheatState.World_CarcassMoving && CarcassMovingState.IsCarrying) __result = false;
    }
}

internal static class Patch_Carcass_NoEquip
{
    internal static bool Prefix()
    {
        if (!CheatState.World_CarcassMoving || !CarcassMovingState.IsCarrying) return true;
#if STORY_EDITION
        // 2.24 GameAudioManager 没有 Instance 单例(PlaySound 本身是 static),
        // 报错音直接走 static PlayGUIError()。
        GameAudioManager.PlayGUIError();
#else
        GameAudioManager.PlaySound(GameAudioManager.Instance.m_ErrorAudio, ((Component)GameAudioManager.Instance).gameObject);
#endif
        HUDMessage.AddMessage(I18n.T("搬运猎物时无法装备物品", "Cannot equip while carrying"), false, false);
        return false;
    }
}

internal static class Patch_Carcass_Fatigue
{
    internal static void Postfix(ref float __result)
    {
        if (CheatState.World_CarcassMoving && CarcassMovingState.IsCarrying)
            __result *= 1f + CarcassMovingState.Weight * 0.05f;
    }
}

internal static class Patch_Carcass_Calorie
{
    private static bool _logged;

    // __0 = vanilla CalculateModifiedCalorieBurnRate 的第一个输入参数(基础消耗率,根据走/跑/睡等活动)
    internal static void Postfix(ref float __result, float __0)
    {
        if (CheatState.World_CarcassMoving && CarcassMovingState.IsCarrying)
            __result += CarcassMovingState.Weight * 15f;

        // TechBackpack: 消除超重卡路里惩罚,完全对齐 vanilla 不超重时的消耗
        // 当 __result 大于 __0 (base) 说明 vanilla 在加超重/疲劳修正,直接钳回 __0
        // 走路/冲刺/睡觉等活动差异通过 __0 本身体现,不会被破坏
        if ((CheatState.TechBackpack || CheatState.InfiniteCarry) && __0 > 0f)
        {
            if (!_logged)
            {
                _logged = true;
                ModMain.Log?.Msg($"[CalorieCap] TechBackpack active, base={__0:F1} result={__result:F1} → cap={__0:F1}");
            }
            if (__result > __0)
                __result = __0;
        }
    }
}

internal static class Patch_Carcass_Scent
{
    internal static void Postfix(ref float __result)
    {
        if (CheatState.World_CarcassMoving && CarcassMovingState.IsCarrying)
            __result += 33f;
    }
}

internal static class Patch_Carcass_RopeDrop
{
    internal static void Postfix()
    {
        if (CheatState.World_CarcassMoving && CarcassMovingState.IsCarrying)
            CarcassMovingState.Drop();
    }
}

// ═══════════════════════════════════════════════════════════════
// ElectricTorchLighting: 极光期间从电源点燃火把
// 2.24 没有 SimpleInteraction / BaseInteraction(交互体系是 2.55 重构出来的),
// 整套功能(把插座变成可交互物、点亮悬停文字)在剧情下无法实现。整块 6 个 patch 类
// 连同 DynamicPatch 里对应的 6 条 Spec 一起排除;StoryGuard 本来就把
// World_ElectricTorch 强制关掉了(它挂 MissionServicesManager,会碰任务对象注册)。
// ═══════════════════════════════════════════════════════════════
#if !STORY_EDITION

internal static class ElectricTorchState
{
    internal static readonly string[] LightSources = { "socket", "outlet", "cableset", "electricdamage_temp" };
    internal static GameObject LookingAt;

    internal static bool NameMatchesSource(string name)
    {
        if (name == null) return false;
        for (int i = 0; i < LightSources.Length; i++)
            if (name.IndexOf(LightSources[i], System.StringComparison.OrdinalIgnoreCase) >= 0)
                return true;
        return false;
    }
}

internal static class Patch_ElectricTorch_SceneInit
{
    internal static void Postfix()
    {
        if (!CheatState.World_ElectricTorch) return;
        try { ElectricTorchHelper.MakeInteractible(); } catch { }
    }
}

internal static class Patch_ElectricTorch_Interact
{
    internal static void Postfix(PlayerManager __instance)
    {
        if (!CheatState.World_ElectricTorch) return;
        try
        {
            if (!GameManager.GetAuroraManager().AuroraIsActive()) return;
            if (!ElectricTorchHelper.PlayerNearSource(__instance)) return;
            if (!__instance.PlayerHoldingTorchThatCanBeLit()) return;
            var panel = InterfaceManager.GetPanel<Panel_TorchLight>();
            if (panel != null) panel.StartTorchIgnite(2f, string.Empty, true);
        }
        catch { }
    }
}

internal static class Patch_ElectricTorch_NoDamage
{
    internal static bool Prefix(DamageTrigger __instance)
    {
        if (!CheatState.World_ElectricTorch) return true;
        return (int)__instance.m_DamageSource != 7;
    }
}

internal static class Patch_ElectricTorch_NoDamageCont
{
    internal static bool Prefix(DamageTrigger __instance)
    {
        if (!CheatState.World_ElectricTorch) return true;
        return (int)__instance.m_DamageSource != 7;
    }
}

internal static class Patch_ElectricTorch_TriggerExit
{
    internal static bool Prefix(DamageTrigger __instance)
    {
        if (!CheatState.World_ElectricTorch) return true;
        return false;
    }
}

internal static class Patch_ElectricTorch_Crosshair
{
    internal static void Postfix(PlayerManager __instance, ref GameObject __result)
    {
        if (!CheatState.World_ElectricTorch) return;
        try
        {
            if ((__result == null || __result != ElectricTorchState.LookingAt) && ElectricTorchState.LookingAt != null)
            {
                var si = ElectricTorchState.LookingAt.GetComponent<SimpleInteraction>();
                if (si != null) { ((Behaviour)si).enabled = false; ElectricTorchState.LookingAt = null; }
            }
            // 先判极光再读名字:准星对着任何可交互物体时每帧都进这里,.name 每次分配一个字符串,而极光绝大多数时间都没有
            if (__result != null && GameManager.GetAuroraManager().AuroraIsActive()
                && ElectricTorchState.NameMatchesSource(((UnityEngine.Object)__result).name)
                && __instance.PlayerHoldingTorchThatCanBeLit())
            {
                var si2 = __result.GetComponent<SimpleInteraction>();
                if (si2 != null && __result != ElectricTorchState.LookingAt)
                {
                    ((Behaviour)si2).enabled = true;
                    ElectricTorchState.LookingAt = __result;
                }
            }
        }
        catch { }
    }
}

internal static class ElectricTorchHelper
{
    internal static bool PlayerNearSource(PlayerManager pm)
    {
        float range = pm.ComputeModifiedPickupRange(GameManager.GetGlobalParameters().m_MaxPickupRange);
        var obj = pm.GetInteractiveObjectUnderCrosshairs(range);
        return obj != null && ElectricTorchState.NameMatchesSource(((UnityEngine.Object)obj).name);
    }

    internal static void MakeInteractible()
    {
        var scene = SceneManager.GetActiveScene();
        var roots = scene.GetRootGameObjects();
        var found = new Dictionary<int, GameObject>();
        foreach (var root in roots)
        {
            found.Clear();
            ScanChildren(root, found);
            foreach (var kv in found)
            {
                kv.Value.layer = vp_Layer.InteractivePropNoCollideGear;
                var si = kv.Value.AddComponent<SimpleInteraction>();
                var ls = new LocalizedString();
                ls.m_LocalizationID = "GAMEPLAY_Light";
                ((BaseInteraction)si).m_DefaultHoverText = ls;
                ((Behaviour)si).enabled = false;
            }
        }
    }

    private static void ScanChildren(GameObject obj, Dictionary<int, GameObject> found)
    {
        for (int i = 0; i < obj.transform.childCount; i++)
        {
            var child = obj.transform.GetChild(i).gameObject;
            if (ElectricTorchState.NameMatchesSource(((UnityEngine.Object)child).name)
                && !found.ContainsKey(child.GetInstanceID()))
                found.Add(child.GetInstanceID(), child);
            ScanChildren(child, found);
        }
    }
}
#endif
