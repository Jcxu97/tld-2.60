using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using ModSettings;

namespace MoreBunkers;

// ModSettings 建面板时从这里读每一项的文字;游戏语言是英文就换成英文。只碰本 mod 的设置
[HarmonyPatch]
internal static class SettingsEn
{
    private static readonly Dictionary<string, (string name, string desc, string[] choice)> En = new()
    {
        ["Enabled"] = ("Enable new bunkers", "Adds three bunkers: the Craftsman Bunker in Mystery Lake, the Stockpile Bunker on Coastal Highway, and the Mercenary Bunker in Forsaken Airfield. TldHacks fast travel has all three.", null),
        ["OnHardModes"] = ("Also on Interloper and Misery", "Turn off to remove the new bunkers on Interloper and Misery.", null),
        ["Amount"] = ("Supply amount", "Amount of food, water, ammo, medicine, fuel and materials. Items on the shelves count too. Pilgrim gets the full amount. The Stockpile Bunker then keeps one person alive for six months. Voyageur gets one half, Stalker one third, Interloper about one fifth, Misery about one twelfth. Custom uses Stalker. On Interloper each piece of clothing, tool, weapon and book stays with a 75% chance. On Misery the chance is 40%. Other modes keep all. The value applies the first time you enter a bunker in a new save. Bunkers that already have supplies do not change.",
            new[] { "Follow game", "Pilgrim", "Voyageur", "Stalker", "Interloper", "Misery" }),
        ["InfoKey"] = ("Location hint key", "Press to show the region of each new bunker in this save.", null),
    };

    private static MethodBase TargetMethod() => AccessTools.Method(typeof(NameAttribute).Assembly.GetType("ModSettings.Attributes"), "GetAttributes");

    private static void Postfix(FieldInfo field, ref SectionAttribute section, ref NameAttribute name, ref DescriptionAttribute description, ref ChoiceAttribute choice)
    {
        try
        {
            if (field == null || field.DeclaringType != typeof(Settings) || !ModMain.En) return;
            if (section != null) section = new SectionAttribute("More Bunkers");
            if (!En.TryGetValue(field.Name, out var t)) return;
            if (name != null) name = new NameAttribute(t.name);
            if (description != null) description = new DescriptionAttribute(t.desc);
            if (choice != null && t.choice != null) choice = new ChoiceAttribute(t.choice);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] settings text {ex.Message}"); }
    }
}

// ModSettings 建设置页之前:这时游戏语言已经读好
[HarmonyPatch]
internal static class SettingsBuildStart
{
    private static IEnumerable<MethodBase> TargetMethods()
    {
        var asm = typeof(NameAttribute).Assembly;
        foreach (var n in new[] { "ModSettings.ModSettingsMenu", "ModSettings.CustomModeMenu" })
        {
            var m = AccessTools.Method(asm.GetType(n), "BuildGUI");
            if (m != null) yield return m;
        }
    }

    private static void Prefix() => ModMain.LangReady = true;
}

// 设置菜单左边的 mod 名。建页、加选择项、点开都用这个名字当钥匙,中英只定一次,前后必须一致
[HarmonyPatch]
internal static class SettingsTabEn
{
    private static bool? _en;

    private static IEnumerable<MethodBase> TargetMethods()
    {
        var t = typeof(NameAttribute).Assembly.GetType("ModSettings.ModSettingsGUI");
        foreach (var n in new[] { "CreateModTab", "AddModSelector", "RemoveModSelector", "SelectMod" })
        {
            var m = AccessTools.Method(t, n, new[] { typeof(string) });
            if (m != null) yield return m;
        }
    }

    private static void Prefix(ref string modName)
    {
        if (modName != "更多地堡") return;
        _en ??= ModMain.En;
        if (_en.Value) modName = "More Bunkers";
    }
}
