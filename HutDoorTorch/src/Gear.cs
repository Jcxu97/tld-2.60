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
            if (iconSrc != null) SetIcon(data, iconSrc);
            Object.DontDestroyOnLoad(data);
            d.Data = data;

            var go = Object.Instantiate(basePrefab.gameObject, _holder.transform);
            go.name = d.Name;
            d.Template = go.GetComponent<GearItem>();
            Convert(d.Template, d);
        }
        ModMain.Log.Msg("物品模板已建好");
    }

    // 和 ModComponent 一样另建一份图标数据,背包格子和大图都指到原版物品的图
    private static void SetIcon(GearItemData data, GearItem src)
    {
        var sd = src.m_GearItemData;
        Texture2D tex = null;
        try { tex = src.GetInventoryIconTexture(); } catch { }
        if (tex == null)
            try { tex = Addressables.LoadAssetAsync<Texture2D>((Il2CppSystem.Object)src.name.Replace("GEAR_", "ico_GearItem__")).WaitForCompletion(); } catch { }
        var icon = ScriptableObject.CreateInstance<GearItemInventoryIconSimpleData>();
        icon.name = data.name.Replace("GearItemData_GEAR_", "ico_GearItem__");
        icon.m_Icon = tex;
        Object.DontDestroyOnLoad(icon);
        data.m_IconData = icon;
        data.m_CoverFlowMainTexture = sd.m_CoverFlowMainTexture;
        data.m_CoverFlowBlendTexture = sd.m_CoverFlowBlendTexture;
        data.m_CoverFlowDamageTexture = sd.m_CoverFlowDamageTexture;
        data.m_CoverFlowOpenedTexture = sd.m_CoverFlowOpenedTexture;
        ModMain.Log.Msg($"图标 {icon.name} 取自 {src.name}: {(tex != null ? tex.name : "没取到")}");
    }

    internal static void Convert(GearItem gi, GearDef d)
    {
        if (gi == null || d?.Data == null) return;
        gi.gameObject.name = d.Name;
        gi.m_GearItemData = d.Data;
        // 废金属能叠放,不去掉的话进背包会并进废金属那一格,门就看不见了
        var st = gi.m_StackableItem ?? gi.GetComponent<StackableItem>();
        if (st != null) { Object.DestroyImmediate(st); gi.m_StackableItem = null; }
    }

    internal static string DumpInventory()
    {
        var sb = new System.Text.StringBuilder();
        try
        {
            foreach (var w in GameManager.GetInventoryComponent().m_Items)
            {
                var gi = w?.m_GearItem;
                if (gi == null) continue;
                string n = gi.name;
                if (!n.Contains("HDT") && !n.Contains("ScrapMetal")) continue;
                sb.Append($" [{n} 格名 {w.m_GearItemName} 数据 {gi.m_GearItemData?.name} 叠 {(gi.m_StackableItem != null ? gi.m_StackableItem.m_Units : 0)}]");
            }
        }
        catch (Exception ex) { sb.Append(" 出错 " + ex.Message); }
        return sb.ToString();
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
            ModMain.Log.Msg($"给物品 {d.Name}: {(gi != null ? gi.name + " 在背包 " + gi.m_InPlayerInventory + " 父 " + (gi.transform.parent != null ? gi.transform.parent.name : "无") : "生成失败")}");
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

// 界面上的字是直接查字符串表的,所以和 ModComponent 一样把词条写进当前语言的表里
[HarmonyPatch(typeof(Localization), nameof(Localization.LoadStringTableForLanguage))]
internal static class Patch_Localization
{
    internal static readonly Dictionary<string, (string zh, string en)> Text = new()
    {
        ["HDT_HutDoor"] = ("钓鱼小屋门", "Fishing Hut Door"),
        ["HDT_HutDoor_Desc"] = ("照原版钓鱼小屋做的木门。带到没有门的钓鱼小屋门口,看着门框装上。关上门屋里就不进风。",
            "A wooden door for a fishing hut. Carry it to a fishing hut without a door and look at the door frame to install it. Close it to keep the wind out."),
        ["HDT_WallTorch"] = ("壁挂火把", "Wall Torch"),
        ["HDT_WallTorch_Desc"] = ("带铁支架的火把,当家具挂在墙上。一直烧着,离开再回来也不会灭。",
            "A torch on an iron bracket. Place it on a wall like furniture. It burns forever."),
    };

    private static void Postfix() => Inject();

    internal static void Inject()
    {
        try
        {
            var table = Localization.s_CurrentLanguageStringTable;
            if (table == null) return;
            var langs = table.GetLanguages();
            foreach (var kv in Text)
            {
                var e = table.GetEntryFromKey(kv.Key) ?? table.AddEntryForKey(kv.Key);
                while (e.m_Languages.Count < langs.Count) e.m_Languages.Add("");
                for (int i = 0; i < langs.Count; i++)
                    e.m_Languages[i] = langs[i].Contains("English") ? kv.Value.en : kv.Value.zh;
            }
        }
        catch (Exception ex) { ModMain.Log.Warning("写入文字失败: " + ex.Message); }
    }
}

// 背包界面按分类筛物品,门被筛掉时记下来并放行,看日志能知道是哪个分类把它拦了
[HarmonyPatch(typeof(Panel_Inventory), nameof(Panel_Inventory.ItemPassesFilter), new Type[] { typeof(GearItem), typeof(string) })]
internal static class Patch_InventoryFilter
{
    private static readonly HashSet<string> Seen = new();
    private static void Postfix(GearItem pi, string filterName, ref bool __result)
    {
        if (pi == null || Gear.ByName(pi.name) == null) return;
        string key = filterName + ":" + __result;
        if (Seen.Add(key)) ModMain.Log.Msg($"背包分类 {filterName} 原本显示门 {__result}");
        if (!__result && filterName != null && (filterName.IndexOf("All", StringComparison.OrdinalIgnoreCase) >= 0 || filterName.IndexOf("Material", StringComparison.OrdinalIgnoreCase) >= 0))
            __result = true;
    }
}

[HarmonyPatch(typeof(Panel_Inventory), nameof(Panel_Inventory.UpdateFilteredInventoryList))]
internal static class Patch_InventoryList
{
    private static readonly HashSet<string> Logged = new();

    // 背包界面列物品时没把门列进来(门确实在背包里),这里在"全部"和"材料"两栏里把它补上
    private static void Postfix(Panel_Inventory __instance)
    {
        try
        {
            var list = __instance.m_FilteredInventoryList;
            string filter = __instance.m_FilterName ?? "";
            bool show = filter.IndexOf("All", StringComparison.OrdinalIgnoreCase) >= 0 || filter.IndexOf("Material", StringComparison.OrdinalIgnoreCase) >= 0;
            int added = 0;
            foreach (var w in GameManager.GetInventoryComponent().m_Items)
            {
                var gi = w?.m_GearItem;
                if (gi == null || Gear.ByName(gi.name) == null) continue;
                bool listed = false;
                foreach (var e in list) if (e != null && e.m_GearItem == gi) { listed = true; break; }
                if (listed || !show) continue;
                list.Add(new InventoryGridDataItem { m_GearItem = gi });
                added++;
            }
            if (Logged.Add(filter)) ModMain.Log.Msg($"背包分类 {filter} 共 {list.Count} 格,补进门 {added} 格");
        }
        catch (Exception ex) { ModMain.Log.Warning("背包补门失败: " + ex.Message); }
    }
}
