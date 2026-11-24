using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using ModSettings;
using UnityEngine;

namespace SCPlusPP;

// ModSettings 建面板时从这里读每一项的文字;游戏语言不是中文就换成英文。只碰本 mod 的设置(同 MoreBunkers/SettingsEn.cs)
[HarmonyPatch]
internal static class SettingsEn
{
	internal const string ChineseTab = "SCPlusFix++ 自定义安全屋";
	internal const string EnglishTab = "SCPlusFix++ Safehouse Customization";
	internal static bool LangReady;
	private static bool? _tabEn;

	// 不能在启动时读 Localization.Language,它会提前加载语言表,游戏自己的语言表就加载失败
	internal static bool En
	{
		get
		{
			string l = null;
			try { l = PlayerPrefs.GetString("Language", ""); } catch { }
			if (string.IsNullOrEmpty(l) && LangReady) { try { l = Localization.Language; } catch { } }
			return !string.IsNullOrEmpty(l) && !l.ToLowerInvariant().Contains("chinese");
		}
	}

	internal static bool TabEn => _tabEn ??= En;
	internal static string TabTitle => TabEn ? EnglishTab : ChineseTab;
	internal static string HueName => TabEn ? "Hue" : "色调";

	private static readonly Dictionary<string, (string name, string desc, string section, string[] choice)> Text = new()
	{
		["hideIcon"] = ("Safehouse icon visibility", "Choose when to show the safehouse customization icon. Default: only while customizing.", "General", new[] { "Always show", "Only while customizing", "Always hide" }),
		["altWorkbenchInteraction"] = ("Classic workbench controls", "Outside customization mode, use the primary action to craft and right click to break down the workbench. Default: on.", null, null),
		["doWeightCalculation"] = ("Estimate decoration weight", "Estimate decoration weight from material and model volume. Some estimates can be wrong. Default: on.", null, null),
		["autoWeightMultiplier"] = ("Estimated weight multiplier", "Scale estimated decoration weights. New items and a game restart use the new value. Default: 1.", null, null),
		["outlineVisibility"] = ("Outline visibility", "Choose when decorations show an outline. Exit and enter customization mode again to apply the change.", "Outlines", new[] { "Game default", "Near the player", "Under the crosshair", "Off" }),
		["outlineDistance"] = ("Outline distance", "In Near the player mode, the outline shows when you are this close to a decoration. Lower values require you to get closer.", null, null),
		["outlineHue"] = ("Hue", "Adjust the outline color. Default: 0.61.", null, null),
		["outlineAlpha"] = ("Opacity", "Adjust how visible the outline color is. Default: 0.15.", null, null),
		["outlineThickness"] = ("Thickness", "Adjust the width of the outline. Default: 4.", null, null),
		["devInspect"] = ("Developer inspection mode", "In customization mode, aim at a decoration and hold the sprint key while you start to move it with the right mouse button. Use the arrow keys to move the preview, = and - to resize it, and 0 to take a screenshot and show the item name. Screenshots go to Mods/SCPlus/Screenshots.", "Developer Tools", null),
		["debugLog"] = ("Debug logging", "Write debug messages to the console.", null, null),
		["carryableProcessingInterval"] = ("Furniture processing interval", "This setting has no effect in this version.", null, null),
		["dupeKey"] = ("Duplicate decoration key", "In customization mode, aim at a decoration and press this key to duplicate it.", "Cheats", null),
		["ignorePlaceWeight"] = ("Ignore weight while placing", "While you place or move a decoration with the right mouse button in customization mode, its weight does not slow you down.", null, null),
		["globalWeightModifier"] = ("Global weight multiplier", "Scale decoration weights set by the mod. Weights update when they are set again or after a game restart. Default: 1.", null, null),
	};

	private static MethodBase TargetMethod() => AccessTools.Method(typeof(NameAttribute).Assembly.GetType("ModSettings.Attributes"), "GetAttributes");

	private static void Postfix(FieldInfo field, ref SectionAttribute section, ref NameAttribute name, ref DescriptionAttribute description, ref ChoiceAttribute choice)
	{
		try
		{
			if (field == null || field.DeclaringType != typeof(SCPSettings) || !TabEn || !Text.TryGetValue(field.Name, out var t)) return;
			if (name != null) name = new NameAttribute(t.name);
			if (description != null) description = new DescriptionAttribute(t.desc);
			if (section != null && t.section != null) section = new SectionAttribute(t.section);
			if (choice != null && t.choice != null) choice = new ChoiceAttribute(t.choice);
		}
		catch (Exception ex) { MelonLoader.MelonLogger.Warning($"[SCPlusFix++] settings text {ex.Message}"); }
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

	private static void Prefix() => SettingsEn.LangReady = true;
}

// 设置菜单左边的 mod 名。建页、加选择项、点开都用这个名字当钥匙,中英只定一次,前后必须一致
[HarmonyPatch]
internal static class SettingsTabEn
{
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
		if (modName == SettingsEn.ChineseTab) modName = SettingsEn.TabTitle;
	}
}
