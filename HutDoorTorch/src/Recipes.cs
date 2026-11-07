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

    private static readonly (string id, GearDef result, int minutes, (string gear, int count)[] mats)[] Specs =
    {
        ("BP_HDT_HutDoor_Fir", Gear.Door, 120, new[] { ("GEAR_Hardwood", 10) }),
        ("BP_HDT_HutDoor_Cedar", Gear.Door, 120, new[] { ("GEAR_Softwood", 10) }),
        ("BP_HDT_WallTorch_Fir", Gear.Torch, 30, new[] { ("GEAR_Stick", 2), ("GEAR_Hardwood", 1), ("GEAR_Torch", 1) }),
        ("BP_HDT_WallTorch_Cedar", Gear.Torch, 30, new[] { ("GEAR_Stick", 2), ("GEAR_Softwood", 1), ("GEAR_Torch", 1) }),
    };

    internal static void AddTo(BPManager mgr)
    {
        if (mgr == null) return;
        Gear.EnsureTemplates();
        if (!Gear.Ready) return;
        var all = mgr.m_AllBlueprints;
        if (all == null) return;
        if (Made.Count == 0) Build(all);
        foreach (var bp in Made)
            if (!all.Contains(bp)) all.Add(bp);
    }

    private static void Build(Il2CppSystem.Collections.Generic.List<BlueprintData> all)
    {
        BlueprintData baseBp = null;
        foreach (var bp in all)
        {
            if (bp == null || bp.m_CraftedResultGear == null) continue;
            if (bp.m_RequiredCraftingLocation != CraftingLocation.Workbench) continue;
            if (baseBp == null) baseBp = bp;
            if (bp.m_CraftedResultGear.name.Contains("Snare")) { baseBp = bp; break; }
        }
        if (baseBp == null) { ModMain.Log.Error("没找到可以照抄的工作台配方"); return; }
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
            bp.m_CraftingResultType = CraftingResult.StandardGear;
            bp.m_CraftedResultGear = s.result.Template;
            bp.m_CraftedResultDecoration = null;
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
            Made.Add(bp);
        }
        ModMain.Log.Msg($"加了 {Made.Count} 条配方");
    }

    internal static GearDef ResultOf(BlueprintData bp)
    {
        if (bp == null) return null;
        foreach (var s in Specs) if (bp.name == s.id) return s.result;
        return null;
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

[HarmonyPatch(typeof(Panel_Crafting), nameof(Panel_Crafting.Initialize))]
internal static class Patch_PanelCraftingInit
{
    private static void Prefix()
    {
        try { Recipes.AddTo(BPManager.Instance); }
        catch (Exception ex) { ModMain.Log.Error("加配方失败: " + ex); }
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
