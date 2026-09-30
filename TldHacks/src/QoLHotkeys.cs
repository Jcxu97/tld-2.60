using System;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace TldHacks;

// v6.7 — 移植 QoL 1.7.6 的 dropKey/bulkKey/backKey 三类热键(整合期漏掉的 hotkey 部分)
// 范围:
//   dropKey  → Panel_Clothing / Panel_Inventory.Update 内丢弃当前所选物品
//   bulkKey  → 修饰键(默认 LeftShift),放大方向键导航/数量调整(×4 / ×5)
//   backKey  → 第二备用 ESC / 放回键
// 不实现 interactKey / modifierKey / fastPick(任务边界)
//
// 妥协说明:本文件用 [HarmonyPatch] 静态挂载,每个 Prefix/Postfix 第一行 toggle 守卫早退。
// 严格的 DynamicPatch 方法论应迁到 DynamicPatch.Specs[] 数组里;但任务边界限定单文件,
// 所以保留静态挂载 + 守卫早退方案。总开关默认 ON,bridge 开销 ≈ 原 QoL 1.7.6 水平。
// 如果未来需要严格零开销,把 13 个 patch 类的目标方法迁到 DynamicPatch.Spec(...) 即可。
internal static class QoLHotkeys
{
    // 总开关守卫:Settings 未就绪 / 总开关关 → return true 让 vanilla 走完
    internal static bool Disabled
    {
        get
        {
            var s = ModMain.Settings;
            // 物品生成器搜索框在收字时也让路:背包开着时敲 q 会把选中物品丢掉
            return s == null || !s.QoL_HotkeysEnabled || Menu.CapturingKeys;
        }
    }

    // QoL 原版用的 Implementation.IM.GetKey 等价于 UnityEngine.Input.GetKey;统一改 UnityEngine.Input。
    internal static bool BulkHeld()
    {
        try { return UnityEngine.Input.GetKey(ModMain.Settings.QoL_BulkKey); }
        catch { return false; }
    }
}

// =============================================================================
// backKey:扩展 ESC / 放回键(全局 InputManager Postfix)
// =============================================================================
[HarmonyPatch(typeof(InputManager), "GetEscapePressed")]
internal static class Patch_QoL_AlternativeEscape
{
    private static void Postfix(ref bool __result)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!__result && InputManager.GetKeyDown(InputManager.m_CurrentContext, ModMain.Settings.QoL_BackKey))
                __result = true;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.AltEscape] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(InputManager), "GetPutBackPressed")]
internal static class Patch_QoL_AlternativePutBack
{
    private static void Postfix(ref bool __result)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!__result && InputManager.GetKeyDown(InputManager.m_CurrentContext, ModMain.Settings.QoL_BackKey))
                __result = true;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.AltPutBack] {ex.Message}"); }
    }
}

// =============================================================================
// dropKey:Panel_Clothing / Panel_Inventory 按 Q 丢当前选中物品
// =============================================================================
[HarmonyPatch(typeof(Panel_Clothing), "Update")]
internal static class Patch_QoL_Clothing_DropKey
{
    private static void Postfix(Panel_Clothing __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, ModMain.Settings.QoL_DropKey))
                __instance.OnDropItem();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.ClothingDrop] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_Inventory), "Update")]
internal static class Patch_QoL_Inventory_DropKey
{
    private static void Postfix(Panel_Inventory __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
#if STORY_EDITION
            // 2.24:Panel_Inventory 无 m_PickUnits,ItemDescriptionPage 无 m_ProgressBar,
            // GetCurrentlySelectedItem 叫 GetCurrentlySelectedGearItem 且直接返回 GearItem,
            // GearItem 也没有 m_CantDropItem。守卫只剩 CanDrop(它内部已判断进行中的操作)。
            if (!InputManager.GetKeyDown(InputManager.m_CurrentContext, ModMain.Settings.QoL_DropKey)) return;

            var gear = __instance.GetCurrentlySelectedGearItem();
            if (gear == null) return;
            var page = __instance.m_ItemDescriptionPage;
            if (page == null || !page.CanDrop(gear)) return;
#else
            if (__instance.m_PickUnits.IsEnabled() || __instance.m_ItemDescriptionPage.m_ProgressBar.IsEnabled()) return;
            if (!InputManager.GetKeyDown(InputManager.m_CurrentContext, ModMain.Settings.QoL_DropKey)) return;

            var sel = __instance.GetCurrentlySelectedItem();
            if (sel == null) return;
            var gear = sel.m_GearItem;
            if (gear == null || gear.m_CantDropItem) return;
            var page = __instance.m_ItemDescriptionPage;
            if (page == null || !page.CanDrop(gear)) return;
#endif

            // 只走 vanilla OnDrop 主路径(原 QoL 的 modifierKey 分支跳过)
            __instance.OnDrop();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.InvDrop] {ex.Message}"); }
    }
}

// =============================================================================
// bulkKey 修饰键:放大导航/数量调整步长(×4 或 ×5)
// =============================================================================

// 收获面板:Shift+A/D 在 Harvest tab 上 ±4 (当 m_SelectedButtonIndex == 0 肉, == 2 内脏)
[HarmonyPatch(typeof(Panel_BodyHarvest), "Update")]
internal static class Patch_QoL_BodyHarvest_Bulk
{
    private static void Postfix(Panel_BodyHarvest __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (__instance.IsHarvestingOrQuartering()) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (!__instance.IsTabHarvestSelected()) return;
            int idx = __instance.m_SelectedButtonIndex;

            bool dDown = InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)100);
            bool aDown = InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)97);

            if (dDown && idx == 0)
            { for (int i = 0; i < 4; i++) __instance.OnIncreaseMeatHarvest(); }
            else if (aDown && idx == 0)
            { for (int i = 0; i < 4; i++) __instance.OnDecreaseMeatHarvest(); }
            else if (dDown && idx == 2)
            { for (int i = 0; i < 4; i++) __instance.OnIncreaseGutHarvest(); }
            else if (aDown && idx == 2)
            { for (int i = 0; i < 4; i++) __instance.OnDecreaseGutHarvest(); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.HarvestBulk] {ex.Message}"); }
    }
}

// PickUnits:刚开就按住 Shift = OnExecuteAll;开着时 Shift+A/D ±4
[HarmonyPatch(typeof(Panel_PickUnits), "Update")]
internal static class Patch_QoL_PickUnits_Bulk
{
    internal static int s_lastOpened;
    internal static int s_lastOn;

    private static void Postfix(Panel_PickUnits __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (s_lastOn != Time.frameCount - 1) s_lastOpened = Time.frameCount;
            s_lastOn = Time.frameCount;

            if (!QoLHotkeys.BulkHeld()) return;

            if (s_lastOpened == Time.frameCount)
            { __instance.OnExecuteAll(); return; }
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)97))
            { for (int i = 0; i < 4; i++) __instance.OnDecrease(); }
            else if (InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)100))
            { for (int i = 0; i < 4; i++) __instance.OnIncrease(); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.PickUnitsBulk] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_PickWater), "Update")]
internal static class Patch_QoL_PickWater_Bulk
{
    internal static int s_lastOpened;
    internal static int s_lastOn;

    private static void Postfix(Panel_PickWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (s_lastOn != Time.frameCount - 1) s_lastOpened = Time.frameCount;
            s_lastOn = Time.frameCount;

            if (!QoLHotkeys.BulkHeld()) return;

            if (s_lastOpened == Time.frameCount)
            { __instance.OnExecuteAll(); return; }
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)97))
            { for (int i = 0; i < 4; i++) __instance.OnDecrease(); }
            else if (InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)100))
            { for (int i = 0; i < 4; i++) __instance.OnIncrease(); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.PickWaterBulk] {ex.Message}"); }
    }
}

// Panel_Rest:Shift+A/D / 滚轮配合 时间步长 ×5(原版 1+4 共 5 次)
[HarmonyPatch(typeof(Panel_Rest), "Update")]
internal static class Patch_QoL_Rest_Bulk
{
    private static void Postfix(Panel_Rest __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;

            bool decKey = InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)97)
                       || InputManager.GetScroll(InputManager.m_CurrentContext) > 0f;
            bool incKey = InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)100)
                       || InputManager.GetScroll(InputManager.m_CurrentContext) < 0f;

            if (decKey)
            { for (int i = 0; i < 4; i++) __instance.OnDecreaseHours(); }
            else if (incKey)
            { for (int i = 0; i < 4; i++) __instance.OnIncreaseHours(); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.RestBulk] {ex.Message}"); }
    }
}

// Panel_Crafting / Panel_Cooking 的 Shift 批量滚动:
// 2.24 两个面板都没有 m_ScrollBehaviour(滚动列表是 2.55 引入的
// Il2CppTLD.UI.Scroll 体系),也没有 m_CraftingOperation / m_RecipePrepOperation。
// 两个 patch 类整体排除;它们是静态 [HarmonyPatch],无 DynamicPatch Spec 需要配对。
#if !STORY_EDITION
// Panel_Crafting:Shift+W/S 滚动 4 行
[HarmonyPatch(typeof(Panel_Crafting), "Update")]
internal static class Patch_QoL_Crafting_Bulk
{
    private static void Postfix(Panel_Crafting __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            var op = __instance.m_CraftingOperation;
            if (op != null && op.InProgress) return;
            if (!QoLHotkeys.BulkHeld()) return;

            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)119))
                __instance.m_ScrollBehaviour.SetSelectedIndex(Mathf.Max(0, __instance.m_ScrollBehaviour.SelectedIndex - 4), false, false);
            else if (InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)115))
                __instance.m_ScrollBehaviour.SetSelectedIndex(Mathf.Min(__instance.m_ScrollBehaviour.m_TotalItems - 1, __instance.m_ScrollBehaviour.SelectedIndex + 4), false, false);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CraftingBulk] {ex.Message}"); }
    }
}

// Panel_Cooking:Shift+W/S/scroll 跳 5 项
[HarmonyPatch(typeof(Panel_Cooking), "Update")]
internal static class Patch_QoL_Cooking_Bulk
{
    private static void Postfix(Panel_Cooking __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (__instance.m_RecipePrepOperation.InProgress) return;
            if (!QoLHotkeys.BulkHeld()) return;

            if (InputManager.GetScroll(InputManager.m_CurrentContext) > 0f
                || InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)119))
            {
                __instance.m_ScrollBehaviour.SetSelectedIndex(Mathf.Max(0, __instance.m_ScrollBehaviour.SelectedIndex - 5), false, false);
            }
            else if ((InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)115)
                     || InputManager.GetScroll(InputManager.m_CurrentContext) < 0f)
                     && (float)__instance.m_ScrollBehaviour.m_TotalItems > 0f)
            {
                __instance.m_ScrollBehaviour.SetSelectedIndex(Mathf.Min(__instance.m_ScrollBehaviour.m_TotalItems - 1, __instance.m_ScrollBehaviour.SelectedIndex + 5), false, false);
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CookingBulk] {ex.Message}"); }
    }
}
#endif

// Panel_Inventory_Examine 阅读:Shift+A/D / 滚轮 阅读小时 ×5
[HarmonyPatch(typeof(Panel_Inventory_Examine), "Update")]
internal static class Patch_QoL_Examine_ReadBulk
{
    private static void Postfix(Panel_Inventory_Examine __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (__instance.IsCleaning() || __instance.IsRepairing() || __instance.IsHarvesting()
                || __instance.IsReading() || __instance.IsSharpening()
                || __instance.m_ActionInProgressWindow.active
                || ((UnityEngine.Behaviour)InterfaceManager.GetPanel<Panel_GenericProgressBar>()).isActiveAndEnabled) return;
            if (!__instance.m_ReadPanel.active) return;
            if (!QoLHotkeys.BulkHeld()) return;

            bool dec = InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)97)
                    || InputManager.GetScroll(InputManager.m_CurrentContext) > 0f;
            bool inc = InputManager.GetKeyDown(InputManager.m_CurrentContext, (KeyCode)100)
                    || InputManager.GetScroll(InputManager.m_CurrentContext) < 0f;

            if (dec)
            { for (int i = 0; i < 4; i++) __instance.OnReadHoursDecrease(); }
            else if (inc)
            { for (int i = 0; i < 4; i++) __instance.OnReadHoursIncrease(); }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.ExamineRead] {ex.Message}"); }
    }
}

#if !STORY_EDITION
// Panel_CookWater:6 个独立 OnXxxUp/Down,bulk 持有时 Postfix 重复调用 4 次 → 总 5 次
// 注意 vanilla 已经触发 1 次,所以这里再补 4 次
// 2.24 无 Panel_CookWater(融雪/煮水面板是 2.24 之后重做的),整块 6 个 patch 类一起排除。
[HarmonyPatch(typeof(Panel_CookWater), "OnMeltSnowUp")]
internal static class Patch_QoL_CookWater_MeltUp
{
    private static int s_count;
    private static void Postfix(Panel_CookWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (s_count++ >= 4) { s_count = 0; return; }
            __instance.OnMeltSnowUp();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CWMeltUp] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_CookWater), "OnMeltSnowDown")]
internal static class Patch_QoL_CookWater_MeltDown
{
    private static int s_count;
    private static void Postfix(Panel_CookWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (s_count++ >= 4) { s_count = 0; return; }
            __instance.OnMeltSnowDown();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CWMeltDown] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_CookWater), "OnWaterUp")]
internal static class Patch_QoL_CookWater_WaterUp
{
    private static int s_count;
    private static void Postfix(Panel_CookWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (s_count++ >= 4) { s_count = 0; return; }
            __instance.OnWaterUp();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CWWaterUp] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_CookWater), "OnWaterDown")]
internal static class Patch_QoL_CookWater_WaterDown
{
    private static int s_count;
    private static void Postfix(Panel_CookWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (s_count++ >= 4) { s_count = 0; return; }
            __instance.OnWaterDown();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CWWaterDown] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_CookWater), "OnBoilUp")]
internal static class Patch_QoL_CookWater_BoilUp
{
    private static int s_count;
    private static void Postfix(Panel_CookWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (s_count++ >= 4) { s_count = 0; return; }
            __instance.OnBoilUp();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CWBoilUp] {ex.Message}"); }
    }
}

[HarmonyPatch(typeof(Panel_CookWater), "OnBoilDown")]
internal static class Patch_QoL_CookWater_BoilDown
{
    private static int s_count;
    private static void Postfix(Panel_CookWater __instance)
    {
        try
        {
            if (QoLHotkeys.Disabled) return;
            if (!QoLHotkeys.BulkHeld()) return;
            if (s_count++ >= 4) { s_count = 0; return; }
            __instance.OnBoilDown();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[QoLHotkeys.CWBoilDown] {ex.Message}"); }
    }
}
#endif
