using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Placement;
using UnityEngine;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════════
//   v3.0.4 IntegratedPatches5
//   PlaceFromInventory v1.1.3 — 背包/衣物右键放置 + Ctrl 整堆丢
//   v3.0.4r1: MapManager 整合已移除(改回 MapManager.dll 独立 mod)
// ═══════════════════════════════════════════════════════════════════

internal static class PlaceFromInvUI
{
    private static bool _backToInv;
    private static bool _backToCloth;

    public static Panel_Inventory InvPanel => InterfaceManager.GetPanel<Panel_Inventory>();
    public static Panel_Clothing ClothPanel => InterfaceManager.GetPanel<Panel_Clothing>();

    public static void HideCurrentPanel()
    {
        _backToInv = InvPanel != null && ((Panel_Base)InvPanel).IsEnabled();
        if (_backToInv) InvPanel.Enable(false, true);
        _backToCloth = ClothPanel != null && ((Panel_Base)ClothPanel).IsEnabled();
        if (_backToCloth) ((Panel_Base)ClothPanel).Enable(false);
    }

    public static void RestorePreviousPanel()
    {
        if (_backToInv) InvPanel.Enable(true, true);
        if (_backToCloth) ((Panel_Base)ClothPanel).Enable(true);
        _backToInv = _backToCloth = false;
    }

    public static void StartPlaceObject(GameObject go, PlaceMeshFlags flags = (PlaceMeshFlags)0)
    {
        try
        {
            HideCurrentPanel();
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm != null) pm.StartPlaceMesh(go, flags, (PlaceMeshRules)1);
        }
        catch { }
    }
}

[HarmonyPatch(typeof(InventoryGridItem), "OnClick")]
internal static class Patch_PlaceFromInv_GridClick
{
    static int _lastFrameCancelled;
    public static void NotifyCancelled() => _lastFrameCancelled = Time.frameCount;
    static bool ShouldSkipClick => Time.frameCount - _lastFrameCancelled < 10;

    static void Postfix(InventoryGridItem __instance)
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.PlaceFromInv_Enabled) return;
            if (ShouldSkipClick) return;
            if (!Input.GetMouseButtonUp(1)) return;
            if (((Panel_Base)InterfaceManager.GetPanel<Panel_Container>()).IsEnabled()) return;
            var inv = PlaceFromInvUI.InvPanel;
            if (inv == null) return;
            if (!inv.m_ItemDescriptionPage.CanDrop(__instance.m_GearItem)) return;
            if (__instance.m_GearItem.m_WaterSupply != null) return;
            PlaceFromInvUI.StartPlaceObject(((UnityEngine.Component)__instance.m_GearItem).gameObject, (PlaceMeshFlags)2);
        }
        catch { }
    }
}

[HarmonyPatch(typeof(ClothingSlot), "DoClickAction")]
internal static class Patch_PlaceFromInv_ClothClick
{
    internal static GearItem _clothItemToPlace;

    static void Postfix(ClothingSlot __instance)
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.PlaceFromInv_Enabled) return;
            if (!Input.GetMouseButtonUp(1)) return;
            if (__instance.m_GearItem == null) return;
            var cp = PlaceFromInvUI.ClothPanel;
            if (cp == null) return;
            if (!cp.m_ItemDescriptionPage.CanDrop(__instance.m_GearItem)) return;
            _clothItemToPlace = __instance.m_GearItem;
            cp.OnDropItem();
        }
        catch { }
    }
}

[HarmonyPatch(typeof(Panel_Clothing), "OnDropItem")]
internal static class Patch_PlaceFromInv_ClothDrop
{
    static void Postfix()
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.PlaceFromInv_Enabled) return;
            if (Patch_PlaceFromInv_ClothClick._clothItemToPlace == null) return;
            PlaceFromInvUI.StartPlaceObject(((UnityEngine.Component)Patch_PlaceFromInv_ClothClick._clothItemToPlace).gameObject, (PlaceMeshFlags)0);
            Patch_PlaceFromInv_ClothClick._clothItemToPlace = null;
        }
        catch { }
    }
}

[HarmonyPatch(typeof(PlayerManager), "ExitMeshPlacement")]
internal static class Patch_PlaceFromInv_ExitMesh
{
    static void Postfix(PlayerManager __instance)
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.PlaceFromInv_Enabled) return;
            if (!__instance.m_SkipCancel) Patch_PlaceFromInv_GridClick.NotifyCancelled();
            PlaceFromInvUI.RestorePreviousPanel();
        }
        catch { }
    }
}

// DoPositionCheck 每帧被游戏调用 — 迁到 DynamicPatch,功能关时零 trampoline
internal static class Patch_PlaceFromInv_PositionCheck
{
    public static void Postfix(ref MeshLocationCategory __result)
    {
        try
        {
            if ((int)__result == 11) __result = (MeshLocationCategory)0;
        }
        catch { }
    }
}

// ─── v6.9.6 修:PlaceFromInv_StackDrop("Ctrl 整堆丢出")原本只有 Settings 字段,
//     PanelPickPatches 整个类未移植 → toggle 永不生效。此处补回。
//     Panel_PickUnits 仅在"选择数量"弹窗打开时其 Update 才运行(面板关=零开销),
//     故沿用本文件其余 PlaceFromInv 补丁的静态 [HarmonyPatch]+守卫风格,非每帧热路径。
//     2.55 DropGear 签名变为 (GearItem, int) — 用位置参数 __0/__1 精确解析。
internal static class PlaceFromInvStackDrop
{
    private static bool _dropAsStack;
    private static GearItem _droppedItem;

    private static bool Active =>
        ModMain.Settings != null && ModMain.Settings.PlaceFromInv_Enabled && ModMain.Settings.PlaceFromInv_StackDrop;

    [HarmonyPatch(typeof(Panel_PickUnits), "Update")]
    internal static class Patch_StackDrop_Update
    {
        static void Postfix(Panel_PickUnits __instance)
        {
            try
            {
                if (!Active) { _dropAsStack = false; return; }
                if (!((Panel_Base)__instance).IsEnabled() || (int)__instance.m_ExecuteAction != 0) return;
                _dropAsStack = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
                string text = _dropAsStack
                    ? I18n.T("整堆丢出", "Drop as stack")
                    : Localization.Get("GAMEPLAY_Drop");
                __instance.m_Execute_Button.GetComponentInChildren<UILabel>().text = text;
            }
            catch { }
        }
    }

    [HarmonyPatch(typeof(Panel_PickUnits), "Refresh")]
    internal static class Patch_StackDrop_Refresh
    {
        static void Postfix(Panel_PickUnits __instance)
        {
            try
            {
                if (!Active || (int)__instance.m_ExecuteAction != 0) return;
                __instance.m_Label_Description.text += I18n.T("\n(按住 Ctrl 整堆丢出)", "\n(hold Control to drop as stack)");
            }
            catch { }
        }
    }

    [HarmonyPatch(typeof(Panel_PickUnits), "ExitInterface")]
    internal static class Patch_StackDrop_ExitInterface
    {
        static void Postfix()
        {
            try
            {
                if (_droppedItem == null) return;
                PlaceFromInvUI.StartPlaceObject(((UnityEngine.Component)_droppedItem).gameObject, (PlaceMeshFlags)0);
                _droppedItem = null;
            }
            catch { }
        }
    }

    [HarmonyPatch(typeof(Panel_PickUnits), "DropGear")]
    internal static class Patch_StackDrop_DropGear
    {
        // 返回 false 跳过 vanilla:手动整堆 Drop 并捕获掉落物,ExitInterface 再进入精确放置
        static bool Prefix(Panel_PickUnits __instance, GearItem __0, int __1)
        {
            try
            {
                if (!Active || (int)__instance.m_ExecuteAction != 0 || !_dropAsStack) return true;
                if (__0 == null) return true;
                _droppedItem = __0.Drop(__1, true, true, false);
                return false;
            }
            catch { return true; }
        }
    }
}
