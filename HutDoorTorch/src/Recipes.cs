using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.Gear;
using UnityEngine;
using Object = UnityEngine.Object;
using BPManager = Il2CppTLD.Gear.BlueprintManager;

namespace HutDoorTorch;

// 四条工作台配方。冷杉和雪松各一条,游戏的配方只认一种材料。
// 新配方是复制一条原版工作台配方再改结果和材料,图标、音效、制作地点这些都沿用原版的。
internal static class Recipes
{
    private static readonly List<BlueprintData> Made = new();

    // result 为 null 的是壁挂火把,做出来是家具
    private static readonly (string id, GearDef result, int minutes, (string gear, int count)[] mats)[] Specs =
    {
        ("BP_HDT_HutDoor_Fir", Gear.Door, 120, new[] { ("GEAR_Hardwood", 10) }),
        ("BP_HDT_HutDoor_Cedar", Gear.Door, 120, new[] { ("GEAR_Softwood", 10) }),
        ("BP_HDT_WallTorch_Fir", null, 30, new[] { ("GEAR_Stick", 2), ("GEAR_Hardwood", 1), ("GEAR_Torch", 1) }),
        ("BP_HDT_WallTorch_Cedar", null, 30, new[] { ("GEAR_Stick", 2), ("GEAR_Softwood", 1), ("GEAR_Torch", 1) }),
    };

    internal static void AddTo(BPManager mgr)
    {
        if (mgr == null) return;
        Gear.EnsureTemplates();
        Torches.EnsureTemplate();
        if (!Gear.Ready || Torches.Template == null) return;
        var all = mgr.m_AllBlueprints;
        if (all == null) return;
        if (Made.Count == 0) Build(all);
        foreach (var bp in Made)
        {
            if (!all.Contains(bp)) all.Add(bp);
            try { mgr.UnlockSilent(bp); } catch { }
        }
    }

    internal static BPManager Manager
    {
        get
        {
            try { var m = InterfaceManager.m_Instance?.m_BlueprintManager; if (m != null) return m; } catch { }
            return BPManager.Instance;
        }
    }

    // 制造界面自己另存了一份能显示的配方,原版工作台配方在里面时把我们的也放进去
    internal static void AddToPanel(Panel_Crafting panel)
    {
        var list = panel?.m_Blueprints;
        if (list == null || Made.Count == 0) return;
        bool workbench = false;
        foreach (var bp in list)
            if (bp != null && bp.m_RequiredCraftingLocation == CraftingLocation.Workbench && !Made.Contains(bp)) { workbench = true; break; }
        int added = 0;
        if (workbench)
            foreach (var bp in Made)
                if (!list.Contains(bp)) { list.Add(bp); added++; }
        if (added > 0) panel.ApplyFilter();
        ModMain.Log.Msg($"制造界面配方 {list.Count} 条,工作台配方 {(workbench ? "有" : "没有")},补进 {added} 条");
    }

    private static void Build(Il2CppSystem.Collections.Generic.List<BlueprintData> all)
    {
        BlueprintData baseBp = null, anyBp = null;
        foreach (var bp in all)
        {
            if (bp == null || bp.m_CraftedResultGear == null) continue;
            anyBp ??= bp;
            if (bp.m_RequiredCraftingLocation != CraftingLocation.Workbench) continue;
            baseBp ??= bp;
            if (bp.m_CraftedResultGear.name.Contains("Snare")) { baseBp = bp; break; }
        }
        baseBp ??= anyBp;
        // 游戏刚启动时配方表还是空的,进存档或打开制造界面时再试
        if (baseBp == null) { ModMain.Log.Msg($"配方表里还没有能照抄的配方(共 {all.Count} 条),稍后再加"); return; }
        ModMain.Log.Msg($"配方照抄 {baseBp.name}");

        foreach (var s in Specs)
        {
            var mats = new List<BlueprintData.RequiredGearItem>();
            bool ok = true;
            foreach (var (gear, count) in s.mats)
            {
                var gi = Gear.LoadVanilla(gear);
                if (gi == null) { ModMain.Log.Error($"配方 {s.id} 缺材料 {gear}"); ok = false; break; }
                mats.Add(new BlueprintData.RequiredGearItem { m_Item = gi, m_Count = count });
            }
            if (!ok) continue;

            var bp = Object.Instantiate(baseBp);
            bp.name = s.id;
            Object.DontDestroyOnLoad(bp);
            if (s.result != null)
            {
                bp.m_CraftingResultType = CraftingResult.StandardGear;
                bp.m_CraftedResultGear = s.result.Template;
                bp.m_CraftedResultDecoration = null;
            }
            else
            {
                bp.m_CraftingResultType = CraftingResult.Decoration;
                bp.m_CraftedResultDecoration = Torches.Template;
                bp.m_CraftedResultGear = null;
            }
            bp.m_CraftedResultCount = 1;
            bp.m_DurationMinutes = s.minutes;
            bp.m_RequiredGear = new Il2CppReferenceArray<BlueprintData.RequiredGearItem>(mats.ToArray());
            bp.m_RequiredPowder = new Il2CppReferenceArray<BlueprintData.RequiredPowder>(0);
            bp.m_RequiredLiquid = new Il2CppReferenceArray<BlueprintData.RequiredLiquid>(0);
            bp.m_RequiredTool = null;
            bp.m_RequiredCraftingLocation = CraftingLocation.Workbench;
            bp.m_Locked = false;
            bp.m_AppearsInStoryOnly = false;
            bp.m_RequiresLitFire = false;
            bp.m_XPModesToDisable = new Il2CppSystem.Collections.Generic.List<ExperienceModeType>();
            Made.Add(bp);
        }
        ModMain.Log.Msg($"加了 {Made.Count} 条配方");
    }

}

[HarmonyPatch(typeof(BPManager), nameof(BPManager.LoadAllUserBlueprints))]
internal static class Patch_LoadAllUserBlueprints
{
    private static void Postfix(BPManager __instance)
    {
        try { Recipes.AddTo(__instance); }
        catch (Exception ex) { ModMain.Log.Error("加配方失败: " + ex); }
    }
}

[HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.Enable), new Type[] { typeof(bool), typeof(bool) })]
internal static class Patch_PanelCraftingEnable
{
    private static void Prefix(bool enable)
    {
        if (!enable) return;
        try { Recipes.AddTo(Recipes.Manager); }
        catch (Exception ex) { ModMain.Log.Error("加配方失败: " + ex); }
    }
}

[HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.Initialize))]
internal static class Patch_PanelCraftingInit
{
    private static void Prefix()
    {
        try { Recipes.AddTo(Recipes.Manager); }
        catch (Exception ex) { ModMain.Log.Error("加配方失败: " + ex); }
    }
}

[HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.RefreshAvailableBlueprints))]
internal static class Patch_PanelCraftingRefresh
{
    private static void Postfix(Panel_Crafting __instance)
    {
        try { Recipes.AddToPanel(__instance); }
        catch (Exception ex) { ModMain.Log.Error("制造界面加配方失败: " + ex); }
    }
}

// 做出来的东西是按底子生成的时候,换回新物品
[HarmonyPatch(typeof(PlayerManager), nameof(PlayerManager.InstantiateItemInPlayerInventory), new Type[] { typeof(GearItem), typeof(int), typeof(float), typeof(PlayerManager.InventoryInstantiateFlags) })]
internal static class Patch_InstantiateInInventory
{
    private static void Postfix(GearItem gearItem, GearItem __result)
    {
        if (__result == null || gearItem == null) return;
        var d = Gear.ByName(gearItem.name);
        if (d == null || Gear.Is(__result, d)) { Gear.FixInventoryName(__result); return; }
        Gear.Convert(__result, d);
        Gear.FixInventoryName(__result);
    }
}
