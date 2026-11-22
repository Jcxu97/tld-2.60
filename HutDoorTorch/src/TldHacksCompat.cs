using System;
using System.Collections;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace HutDoorTorch;

// 装了 TldHacks 时,把门放进物品生成器,把壁挂火把放进生成器的家具栏。
// TldHacks 按 Addressables 找物品,找不到我们的,所以顺带 patch 它查物品和生成家具的两个方法。没装就什么都不做。
internal static class TldHacksCompat
{
    private const string TorchKey = "HDT_WallTorch";

    internal static void Install(HarmonyLib.Harmony h)
    {
        Type entry = AccessTools.TypeByName("TldHacks.ItemEntry");
        Type modDb = AccessTools.TypeByName("TldHacks.ItemDatabaseMod");
        Type furDb = AccessTools.TypeByName("TldHacks.FurnitureDatabase");
        Type gearPrefab = AccessTools.TypeByName("TldHacks.GearPrefab");
        Type furniture = AccessTools.TypeByName("TldHacks.Furniture");
        if (entry == null || modDb == null || gearPrefab == null) return;
        try
        {
            var all = (IList)AccessTools.Field(modDb, "All").GetValue(null);
            all.Add(Activator.CreateInstance(entry, Gear.DoorName, "钓鱼小屋门", "工具", "", 6f, 0, ""));
            h.Patch(AccessTools.Method(gearPrefab, "Load"), postfix: new HarmonyMethod(typeof(TldHacksCompat), nameof(LoadPostfix)));

            if (furDb != null && furniture != null)
            {
                var native = (IList)AccessTools.Field(furDb, "Native").GetValue(null);
                native.Add(Activator.CreateInstance(entry, TorchKey, "壁挂火把", "家具", "", 1f, 0, TorchKey));
                h.Patch(AccessTools.Method(furniture, "SpawnNative"), prefix: new HarmonyMethod(typeof(TldHacksCompat), nameof(SpawnNativePrefix)));
            }
            ModMain.Log.Msg("已加进 TldHacks 物品生成器");
        }
        catch (Exception ex) { ModMain.Log.Warning("加进 TldHacks 物品生成器失败: " + ex.Message); }
    }

    private static void LoadPostfix(string name, ref GearItem __result)
    {
        if (__result != null || Gear.ByName(name) == null) return;
        Gear.EnsureTemplates();
        __result = Gear.Door.Template;
    }

    private static bool SpawnNativePrefix(string path, ref bool __result)
    {
        if (path != TorchKey) return true;
        __result = false;
        try
        {
            Torches.EnsureTemplate();
            if (Torches.Template == null) { ModMain.Log.Warning("壁挂火把模板没建好"); return false; }
            var di = Torches.GiveOne();
            __result = di != null;
            if (di == null) ModMain.Log.Warning("壁挂火把没能放进背包");
        }
        catch (Exception ex) { ModMain.Log.Error("生成壁挂火把失败: " + ex); }
        return false;
    }
}
