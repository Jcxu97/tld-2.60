using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gear;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(BlueprintIconFix.Mod), "BlueprintIconFix", "1.0.0", "Akul")]
[assembly: MelonGame("Hinterland", "TheLongDark")]

namespace BlueprintIconFix;

public sealed class Mod : MelonMod
{
    internal static MelonLogger.Instance Log = null!;
    public override void OnInitializeMelon() => Log = LoggerInstance;
}

// ModComponent 按 ico_CraftItem__物品名 找配方图,原版只有本来能做的物品才有这张图,
// mod 做原版物品或 mod 没打包配方图时就是空的。空的时候改用结果物品的背包图标。
internal static class Icons
{
    private static readonly Dictionary<string, Texture2D?> Cache = new();

    internal static Texture2D? Fallback(BlueprintData bp)
    {
        if (bp == null) return null;
        string key = bp.name;
        // HutDoorTorch 的配方它自己设图
        if (key.StartsWith("BP_HDT_")) return null;
        if (Cache.TryGetValue(key, out var t) && t != null) return t;
        Texture2D? tex = null;
        try
        {
            if (bp.m_CraftedResultGear != null) tex = bp.m_CraftedResultGear.GetInventoryIconTexture();
            else if (bp.m_CraftedResultDecoration != null) tex = bp.m_CraftedResultDecoration.GetInventoryIconTexture();
        }
        catch (Exception ex) { Mod.Log.Warning($"{key} 取背包图标失败: {ex.Message}"); }
        if (tex != null && Cache.TryAdd(key, tex)) Mod.Log.Msg($"补图标 {key} 用 {tex.name},累计 {Cache.Count} 条");
        return tex;
    }
}

[HarmonyPatch(typeof(BlueprintDisplayItem), nameof(BlueprintDisplayItem.Setup))]
internal static class Patch_Setup
{
    private static void Postfix(BlueprintDisplayItem __instance, BlueprintData bpi)
    {
        var icon = __instance.m_Icon;
        if (icon == null || icon.mainTexture != null) return;
        var t = Icons.Fallback(bpi);
        if (t == null) return;
        icon.mainTexture = t;
        icon.enabled = true;
    }
}
