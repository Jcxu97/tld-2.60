using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace TldHacks;

// 模组物品自动发现。硬编码的 ItemDatabaseMod 只当"精修层"(人工校过的中文名和分类),
// 实际装了什么由这里现扫:Mods 目录下每个 .modcomponent 其实是 ZIP,里面
// auto-mapped/ 下一个 json = 一件注册进游戏的物品(blueprints 是配方、gear-spawns 是刷新点,都不算)。
//
// 三种情况都能兜住:
//   换机器 / 装新 mod → 这里扫出来的新名字直接补进清单
//   删 mod            → 清单里那些条目在 Menu.ResolveDisplayNames 里 LoadGearItemPrefab 拿不到,
//                       IsValid=false 自动隐藏,不用这边管
// 去重按不分大小写比:宁可漏补一条大小写写错的,也不要让同一件东西在清单里出现两行。
// 真有写错的,ResolveDisplayNames 那条日志会把失效的名字打出来,按名字改硬编码清单。
internal static class ItemDiscovery
{
    private static bool _done;
    internal static int Scanned, Added;

    // 这两类不是能放进背包的东西,别往清单里塞:
    //   ModRandomItemComponent / ModRandomWeightedItemComponent —— 拾取瞬间解析成别的物品的模板
    //   ModBodyHarvestComponent —— 世界里的尸体,采集产物本身是另外的条目
    private static readonly string[] SkipComponents =
        { "ModRandomItemComponent", "ModRandomWeightedItemComponent", "ModBodyHarvestComponent" };

    private static readonly Regex ReGear = new Regex("GEAR_[A-Za-z0-9_]+", RegexOptions.Compiled);
    private static readonly Regex ReComponent = new Regex("\"(Mod[A-Za-z]+Component)\"\\s*:", RegexOptions.Compiled);
    private static readonly Regex ReWeight = new Regex("\"WeightKG\"\\s*:\\s*([0-9.]+)", RegexOptions.Compiled);
    private static readonly Regex ReCalories = new Regex("\"Calories\"\\s*:\\s*([0-9.]+)", RegexOptions.Compiled);
    private static readonly Regex ReCategory = new Regex("\"InventoryCategory\"\\s*:\\s*\"([^\"]*)\"", RegexOptions.Compiled);
    private static readonly Regex ReLocId = new Regex("\"DisplayNameLocalizationId\"\\s*:\\s*\"([^\"]*)\"", RegexOptions.Compiled);

    internal static void Run()
    {
        if (_done) return;
        _done = true;
        var sw = Stopwatch.StartNew();
        try
        {
            string mods;
            try { mods = MelonLoader.Utils.MelonEnvironment.ModsDirectory; }
            catch { mods = Path.Combine(Directory.GetCurrentDirectory(), "Mods"); }
            if (!Directory.Exists(mods)) return;

            var known = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < ItemDatabase.All.Count; i++) known.Add(ItemDatabase.All[i].PrefabName);
            for (int i = 0; i < ItemDatabaseMod.All.Count; i++) known.Add(ItemDatabaseMod.All[i].PrefabName);

            // 只扫顶层:玩家把停用的 mod 放在 Mods\_disabled 里,那些不该出现在清单上
            var files = Directory.GetFiles(mods, "*.modcomponent", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                try { ScanOne(file, known); Scanned++; }
                catch (Exception ex) { ModMain.Log?.Warning($"[Discovery] {Path.GetFileName(file)}: {ex.Message}"); }
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[Discovery] {ex.Message}"); }
        ModMain.Log?.Msg($"[Discovery] 扫了 {Scanned} 个模组包,自动补 {Added} 件物品,用时 {sw.ElapsedMilliseconds}ms");
    }

    private static void ScanOne(string path, HashSet<string> known)
    {
        using (var zip = ZipFile.OpenRead(path))
        {
            // auto-mapped 的文件名是全小写的,prefab 的正确大小写要从 catalog 里对
            var canon = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            string localization = null;
            var items = new List<ZipArchiveEntry>();

            foreach (var e in zip.Entries)
            {
                string n = e.FullName;
                if (n.EndsWith(".json", StringComparison.OrdinalIgnoreCase)
                    && n.IndexOf("catalog", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foreach (Match m in ReGear.Matches(Read(e))) canon[m.Value] = m.Value;
                }
                else if (n.EndsWith(".json", StringComparison.OrdinalIgnoreCase)
                    && n.IndexOf("local", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    localization = Read(e);
                }
                else if (n.StartsWith("auto-mapped/", StringComparison.OrdinalIgnoreCase)
                    && n.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    items.Add(e);
                }
            }

            string tag = Path.GetFileNameWithoutExtension(path);
            foreach (var e in items)
            {
                string body = Read(e);
                string comp = ReComponent.Match(body).Groups[1].Value;
                if (Array.IndexOf(SkipComponents, comp) >= 0) continue;

                string prefab = Path.GetFileNameWithoutExtension(e.FullName);
                if (!prefab.StartsWith("GEAR_", StringComparison.OrdinalIgnoreCase)) prefab = "GEAR_" + prefab;
                if (canon.TryGetValue(prefab, out string exact)) prefab = exact;
                if (!known.Add(prefab)) continue;

                float weight = Num(ReWeight, body);
                int calories = (int)Num(ReCalories, body);
                string name = DisplayName(localization, ReLocId.Match(body).Groups[1].Value) ?? Pretty(prefab);
                var entry = new ItemEntry(prefab, name + " [自动]", Category(ReCategory.Match(body).Groups[1].Value, comp),
                    "", weight, calories, tag);
                ItemDatabaseMod.All.Add(entry);
                Added++;
            }
        }
    }

    private static string Read(ZipArchiveEntry e)
    {
        using (var r = new StreamReader(e.Open()))
            return r.ReadToEnd();
    }

    private static float Num(Regex re, string body)
    {
        var m = re.Match(body);
        return m.Success && float.TryParse(m.Groups[1].Value,
            System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float v) ? v : 0f;
    }

    // mod 自带的本地化里有简体中文就用它,没有就用英文。中文名最终还会被游戏本体的
    // 本地化覆盖(见 Menu.ResolveDisplayNames),这里给的是兜底。
    private static string DisplayName(string localization, string key)
    {
        if (string.IsNullOrEmpty(localization) || string.IsNullOrEmpty(key)) return null;
        int i = localization.IndexOf("\"" + key + "\"", StringComparison.Ordinal);
        if (i < 0) return null;
        string window = localization.Substring(i, Math.Min(900, localization.Length - i));
        int end = window.IndexOf('}');
        if (end > 0) window = window.Substring(0, end);
        var zh = Regex.Match(window, "\"Simplified Chinese\"\\s*:\\s*\"([^\"]*)\"");
        if (zh.Success && zh.Groups[1].Value.Length > 0) return zh.Groups[1].Value;
        var en = Regex.Match(window, "\"English\"\\s*:\\s*\"([^\"]*)\"");
        return en.Success && en.Groups[1].Value.Length > 0 ? en.Groups[1].Value : null;
    }

    private static string Category(string inventoryCategory, string comp)
    {
        switch (inventoryCategory)
        {
            case "Food": return "食物";
            case "Drink": return "饮料";
            case "Tool":
            case "Tools": return "工具";
            case "Clothing": return "衣物";
            case "FirstAid":
            case "Firstaid": return "医疗";
            case "Weapon":
            case "Ranged": return "武器";
            case "Decoration": return "装饰";
        }
        // 游戏内分类经常写成怪值,能吃的一律归食物
        if (comp == "ModFoodComponent" || comp == "ModCookableComponent") return "食物";
        if (comp == "ModLiquidComponent") return "饮料";
        if (comp == "ModClothingComponent") return "衣物";
        return "材料";
    }

    private static string Pretty(string prefab)
    {
        string s = prefab.StartsWith("GEAR_") ? prefab.Substring(5) : prefab;
        return s.Replace('_', ' ');
    }
}
