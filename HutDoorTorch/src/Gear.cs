using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gear;
using Il2CppTLD.IntBackedUnit;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Object = UnityEngine.Object;

namespace HutDoorTorch;

// 新物品不在 Addressables 里,游戏按名字或 AssetReference 生成物品时找不到。
// 做法:新物品就是一件原版底子(废金属)换了 GearItemData 和名字。
// 游戏要生成新物品时,先让它按底子正常生成并读存档,出来以后再换回新物品的数据和名字。
internal sealed class GearDef
{
    internal string Name;
    internal string LocName;
    internal string LocDesc;
    internal string IconFrom;
    internal float WeightKg;
    internal string FakeGuid;
    internal GearItemData Data;
    internal GearItem Template;
}

internal static class Gear
{
    internal const string BaseName = "GEAR_ScrapMetal";
    internal const string DoorName = "GEAR_HDT_HutDoor";

    internal static readonly GearDef Door = new()
    {
        Name = DoorName, LocName = "HDT_HutDoor", LocDesc = "HDT_HutDoor_Desc",
        IconFrom = "GEAR_ReclaimedWoodB", WeightKg = 6f, FakeGuid = "8d1f0c2a9b7e4c11a5f3d6e0b2c4a701",
    };
    private static readonly GearDef[] All = { Door };

    private static GameObject _holder;
    private static AssetReferenceGearItem _baseRef;
    internal static bool Ready => Door.Template != null;

    internal static GearDef ByName(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;
        foreach (var d in All)
            if (name.StartsWith(d.Name, StringComparison.Ordinal)) return d;
        return null;
    }

    internal static GearDef ByGuid(string guid)
    {
        if (string.IsNullOrEmpty(guid)) return null;
        foreach (var d in All)
            if (string.Equals(guid, d.FakeGuid, StringComparison.OrdinalIgnoreCase)) return d;
        return null;
    }

    internal static GearItem LoadVanilla(string name)
    {
        try
        {
            var go = Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)name).WaitForCompletion();
            return go != null ? go.GetComponent<GearItem>() : null;
        }
        catch { return null; }
    }

    internal static void EnsureTemplates()
    {
        if (Ready) return;
        var basePrefab = LoadVanilla(BaseName);
        if (basePrefab == null) { ModMain.Log.Error($"找不到底子物品 {BaseName}"); return; }
        _baseRef = basePrefab.m_GearItemData.m_PrefabReference;
        if (_holder == null)
        {
            _holder = new GameObject("HutDoorTorch_Templates");
            _holder.SetActive(false);
            Object.DontDestroyOnLoad(_holder);
        }
        foreach (var d in All)
        {
            if (d.Template != null) continue;
            var data = Object.Instantiate(basePrefab.m_GearItemData);
            data.name = "GearItemData_" + d.Name;
            data.m_LocalizedName = new LocalizedString { m_LocalizationID = d.LocName };
            data.m_LocalizedDescription = new LocalizedString { m_LocalizationID = d.LocDesc };
            data.m_BaseWeight = ItemWeight.FromKilograms(d.WeightKg);
            data.m_PrefabReference = new AssetReferenceGearItem(d.FakeGuid);
            var iconSrc = LoadVanilla(d.IconFrom);
            if (iconSrc != null) data.m_IconData = iconSrc.m_GearItemData.m_IconData;
            Object.DontDestroyOnLoad(data);
            d.Data = data;

            var go = Object.Instantiate(basePrefab.gameObject, _holder.transform);
            go.name = d.Name;
            d.Template = go.GetComponent<GearItem>();
            d.Template.m_GearItemData = data;
        }
        ModMain.Log.Msg("物品模板已建好");
    }

    internal static void Convert(GearItem gi, GearDef d)
    {
        if (gi == null || d?.Data == null) return;
        gi.gameObject.name = d.Name;
        gi.m_GearItemData = d.Data;
    }

    internal static bool Is(GearItem gi, GearDef d) => gi != null && gi.m_GearItemData == d.Data;

    // 背包每格另记了一份物品名,物品进背包后才换的数据,这份名字要跟着改
    internal static void FixInventoryName(GearItem gi)
    {
        if (gi == null) return;
        var d = ByName(gi.gameObject.name);
        if (d == null) return;
        try
        {
            foreach (var w in GameManager.GetInventoryComponent().m_Items)
                if (w != null && w.m_GearItem == gi) w.m_GearItemName = d.Name;
        }
        catch { }
    }

    internal static int CountInInventory(GearDef d)
    {
        int n = 0;
        try
        {
            var inv = GameManager.GetInventoryComponent();
            foreach (var w in inv.m_Items)
            {
                GearItem gi = w?.m_GearItem;
                if (gi != null && Is(gi, d)) n++;
            }
        }
        catch (Exception ex) { ModMain.Log.Warning("数背包失败: " + ex.Message); }
        return n;
    }

    internal static bool ConsumeOne(GearDef d)
    {
        try
        {
            var inv = GameManager.GetInventoryComponent();
            foreach (var w in inv.m_Items)
            {
                GearItem gi = w?.m_GearItem;
                if (gi == null || !Is(gi, d)) continue;
                inv.DestroyGear(gi.gameObject);
                return true;
            }
        }
        catch (Exception ex) { ModMain.Log.Warning("扣物品失败: " + ex.Message); }
        return false;
    }

    internal static void GiveOne(GearDef d)
    {
        EnsureTemplates();
        try
        {
            var gi = GameManager.GetPlayerManagerComponent().InstantiateItemInPlayerInventory(d.Template, 1, 1f, PlayerManager.InventoryInstantiateFlags.None);
            Convert(gi, d);
            FixInventoryName(gi);
        }
        catch (Exception ex) { ModMain.Log.Error("还物品失败: " + ex); }
    }

    // 名字或 GUID 是新物品时换成底子,出来以后再换回来
    internal static AssetReference BaseRef => _baseRef;
}

[HarmonyPatch(typeof(GearItem), nameof(GearItem.InstantiateGearItem), new Type[] { typeof(string) })]
internal static class Patch_InstantiateByName
{
    private static void Prefix(ref string prefabName, out GearDef __state)
    {
        __state = Gear.ByName(prefabName);
        if (__state != null) prefabName = Gear.BaseName;
    }
    private static void Postfix(GearItem __result, GearDef __state) { if (__state != null) Gear.Convert(__result, __state); }
}

[HarmonyPatch(typeof(GearItem), nameof(GearItem.InstantiateGearItem), new Type[] { typeof(AssetReference) })]
internal static class Patch_InstantiateByRef
{
    private static void Prefix(ref AssetReference assetReference, out GearDef __state)
    {
        __state = null;
        try { __state = Gear.ByGuid(assetReference?.AssetGUID); } catch { }
        if (__state != null) assetReference = Gear.BaseRef;
    }
    private static void Postfix(GearItem __result, GearDef __state) { if (__state != null) Gear.Convert(__result, __state); }
}

[HarmonyPatch(typeof(GearItem), nameof(GearItem.InstantiateAndDeserializeGearItem), new Type[] { typeof(string), typeof(string), typeof(Transform), typeof(bool), typeof(bool) })]
internal static class Patch_DeserializeByName
{
    private static void Prefix(ref string prefabName, out GearDef __state)
    {
        __state = Gear.ByName(prefabName);
        if (__state != null) prefabName = Gear.BaseName;
    }
    private static void Postfix(GearItem __result, GearDef __state) { if (__state != null) Gear.Convert(__result, __state); }
}

[HarmonyPatch(typeof(GearItem), nameof(GearItem.InstantiateAndDeserializeGearItem), new Type[] { typeof(string), typeof(GearItemSaveDataProxy), typeof(Transform), typeof(bool), typeof(bool) })]
internal static class Patch_DeserializeByNameProxy
{
    private static void Prefix(ref string prefabName, out GearDef __state)
    {
        __state = Gear.ByName(prefabName);
        if (__state != null) prefabName = Gear.BaseName;
    }
    private static void Postfix(GearItem __result, GearDef __state) { if (__state != null) Gear.Convert(__result, __state); }
}

[HarmonyPatch(typeof(GearItem), nameof(GearItem.InstantiateAndDeserializeGearItem), new Type[] { typeof(AssetReference), typeof(string), typeof(Transform), typeof(bool), typeof(bool) })]
internal static class Patch_DeserializeByRef
{
    private static void Prefix(ref AssetReference assetReference, out GearDef __state)
    {
        __state = null;
        try { __state = Gear.ByGuid(assetReference?.AssetGUID); } catch { }
        if (__state != null) assetReference = Gear.BaseRef;
    }
    private static void Postfix(GearItem __result, GearDef __state) { if (__state != null) Gear.Convert(__result, __state); }
}

[HarmonyPatch(typeof(GearItem), nameof(GearItem.InstantiateAndDeserializeGearItem), new Type[] { typeof(AssetReference), typeof(GearItemSaveDataProxy), typeof(Transform), typeof(bool), typeof(bool) })]
internal static class Patch_DeserializeByRefProxy
{
    private static void Prefix(ref AssetReference assetReference, out GearDef __state)
    {
        __state = null;
        try { __state = Gear.ByGuid(assetReference?.AssetGUID); } catch { }
        if (__state != null) assetReference = Gear.BaseRef;
    }
    private static void Postfix(GearItem __result, GearDef __state) { if (__state != null) Gear.Convert(__result, __state); }
}

[HarmonyPatch(typeof(Localization), nameof(Localization.Get), new Type[] { typeof(string) })]
internal static class Patch_Localization
{
    internal static readonly Dictionary<string, string> Text = new()
    {
        ["HDT_HutDoor"] = "钓鱼小屋门",
        ["HDT_HutDoor_Desc"] = "照原版钓鱼小屋做的木门。带到没有门的钓鱼小屋门口,看着门框装上。关上门屋里就不进风。",
        ["HDT_WallTorch"] = "壁挂火把",
        ["HDT_WallTorch_Desc"] = "带铁支架的火把,当家具挂在墙上。一直烧着,离开再回来也不会灭。",
    };

    private static bool Prefix(string key, ref string __result)
    {
        if (key == null || !key.StartsWith("HDT_", StringComparison.Ordinal)) return true;
        if (!Text.TryGetValue(key, out __result)) __result = key;
        return false;
    }
}
