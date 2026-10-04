using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using HarmonyLib;
using ModSettings;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════════════════════
// Mod Options(游戏内 Options → Mod Settings 那一页)的英文适配层。
//
// 切点:ModSettings.Attributes.GetAttributes —— 全库唯一读 [Section]/[Name]/
//   [Description]/[Choice] 的地方,只被调 2 次(ModSettingsBase 构造函数的
//   ValidateFields、GUIBuilder.AddSettings 建面板时)。不在 Update / OnGUI 上,
//   每帧刷新的悬停说明读的是预烘焙的 DescriptionHolder.Text,不碰 attribute。
//   所以本 patch 每局只付两次 329 次字典查找的成本,对 FPS 零影响。
//
// 为什么不能直接改 attribute 的字段:GetCustomAttributes 每次返回新构造的实例,
//   反射写 backing field 会被下一次调用丢弃(已实测)。必须在 postfix 里换掉
//   out 参数引用,new 出新的 attribute 实例。
//
// 爆炸半径:postfix 第一件事就是判 field.DeclaringType == typeof(TldHacksSettings),
//   本机 80+ mod 的设置面板一律原样返回。任何异常在 postfix 内部吞掉 —— 抛出去会
//   炸整个 Mod Settings 面板(玩家改不了按键)。
//
// 退化路径:patch 应用失败 / 词条缺失 / 语言=中文 → 面板照旧显示中文,等于现状。
// ═══════════════════════════════════════════════════════════════════════════════
internal static class ModSettingsEn
{
    private static HarmonyLib.Harmony _harmony;
    private static MethodInfo _target;
    private static MethodInfo _postfix;

    // 启动时一次性定的语言。false → 根本不挂 patch(中文用户零 Harmony bridge)。
    private static bool _english;
    private static bool _applied;

    private static Dictionary<string, string> _names;
    private static Dictionary<string, string> _descs;
    private static Dictionary<string, string> _sections;
    private static Dictionary<string, string[]> _choices;

    /// <summary>
    /// 必须在 <c>new TldHacksSettings()</c> 之前调用 —— ModSettingsBase 构造函数会跑
    /// ValidateFields → GetAttributes,晚了就赶不上第一次流出。
    /// 此时 ModMain.Settings 还是 null,不能用 I18n.IsEnglish,只能直接从磁盘 JSON 里
    /// 偷看 LanguageMode(与 I18n 的三态语义完全一致)。
    /// </summary>
    internal static void Apply(string jsonPath)
    {
        if (_applied) return;
        _applied = true;
        try
        {
            _english = ResolveEnglishFromDisk(jsonPath);
            if (!_english)
            {
                ModMain.Log?.Msg("[ModSettingsEn] 语言=中文 → 不挂载英文化 patch(零开销)");
                return;
            }

            var attrsType = typeof(NameAttribute).Assembly.GetType("ModSettings.Attributes");
            if (attrsType == null) throw new MissingMemberException("ModSettings.Attributes not found");
            _target = AccessTools.Method(attrsType, "GetAttributes");
            if (_target == null) throw new MissingMethodException("Attributes.GetAttributes not found");
            _postfix = AccessTools.Method(typeof(ModSettingsEn), nameof(GetAttributesPostfix));

            _harmony = new HarmonyLib.Harmony("TldHacks.ModSettingsEn");
            _harmony.Patch(_target, postfix: new HarmonyMethod(_postfix));
            ModMain.Log?.Msg("[ModSettingsEn] 语言=English → Mod Options 面板英文化已挂载");
        }
        catch (Exception ex)
        {
            // 失败就退化成中文面板(= 现状,无害)
            _english = false;
            ModMain.Log?.Warning($"[ModSettingsEn] 挂载失败,Mod Options 面板保持中文: {ex.Message}");
        }
    }

    /// <summary>诊断开关 DiagUnpatchAll 用:把本 patch 也卸掉,做到真正零挂载。</summary>
    internal static void Remove()
    {
        if (_harmony == null || _target == null || _postfix == null) return;
        try { _harmony.Unpatch(_target, _postfix); }
        catch (Exception ex) { ModMain.Log?.Warning($"[ModSettingsEn] Unpatch: {ex.Message}"); }
        _harmony = null;
        _english = false;
    }

    // ModMain.Settings 尚未构造 → 复刻 I18n 的判定:1=强制中文 2=强制英文 其它=按游戏语言
    private static bool ResolveEnglishFromDisk(string jsonPath)
    {
        int mode = I18n.MODE_AUTO;
        try
        {
            if (!string.IsNullOrEmpty(jsonPath) && System.IO.File.Exists(jsonPath))
            {
                var jobj = Newtonsoft.Json.Linq.JObject.Parse(System.IO.File.ReadAllText(jsonPath));
                var tok = jobj["LanguageMode"];
                if (tok != null) mode = tok.ToObject<int>();
            }
        }
        catch { }
        if (mode == I18n.MODE_ZH) return false;
        if (mode == I18n.MODE_EN) return true;
        return I18n.GameIsEnglish();
    }

    // ─────────────────────────── Harmony postfix ───────────────────────────
    // 原型: void GetAttributes(FieldInfo, out SectionAttribute, out NameAttribute,
    //                          out DescriptionAttribute, out SliderAttribute, out ChoiceAttribute)
    // slider 不需要改,直接不写进签名(Harmony 允许取参数子集)。
    private static void GetAttributesPostfix(FieldInfo field,
        ref SectionAttribute section, ref NameAttribute name,
        ref DescriptionAttribute description, ref ChoiceAttribute choice)
    {
        if (!_english) return;
        if (field == null || field.DeclaringType != typeof(TldHacksSettings)) return;   // 别人的 mod 一律不碰
        try
        {
            // 运行时切回中文(玩家在 TldHacks 菜单里改了 Language)→ 下次面板重建就是中文
            if (ModMain.Settings != null && !I18n.IsEnglish) return;

            EnsureTables();
            string key = field.Name;
            string en;

            if (name != null && _names.TryGetValue(key, out en) && en.Length > 0)
                name = new NameAttribute(en) { Localize = name.Localize };

            if (description != null && _descs.TryGetValue(key, out en) && en.Length > 0)
                description = new DescriptionAttribute(en) { Localize = description.Localize };

            if (section != null && _sections.TryGetValue(key, out en) && en.Length > 0)
                section = new SectionAttribute(en) { Localize = section.Localize };

            if (choice != null && _choices.TryGetValue(key, out var enArr))
            {
                var src = choice.Names;
                // 长度必须一致 —— ChoiceAttribute.ValidateFor 会在构造期按长度校验,变了就抛。
                if (src != null && enArr != null && src.Length == enArr.Length)
                {
                    var merged = new string[src.Length];
                    for (int i = 0; i < src.Length; i++)
                        merged[i] = string.IsNullOrEmpty(enArr[i]) ? src[i] : enArr[i];   // 缺译的单项保留中文
                    choice = new ChoiceAttribute(merged) { Localize = choice.Localize };
                }
            }
        }
        catch (Exception ex)
        {
            // 绝不让异常穿出去:ValidateFields / BuildGUI 任一处抛 = 整个 Mod Settings 面板挂掉
            _english = false;
            ModMain.Log?.Warning($"[ModSettingsEn] postfix 异常,已停用英文化: {ex.Message}");
        }
    }

    // 懒加载:中文用户永远不会走到这里,不付这份内存
    private static void EnsureTables()
    {
        if (_names != null) return;
        _names = Flat(ModSettingsEnData.Names);
        _descs = Flat(ModSettingsEnData.Descriptions);
        _sections = Flat(ModSettingsEnData.Sections);
        var raw = Flat(ModSettingsEnData.Choices);
        _choices = new Dictionary<string, string[]>(raw.Count);
        foreach (var kv in raw) _choices[kv.Key] = kv.Value.Split('|');
    }

    private static Dictionary<string, string> Flat(string[] arr)
    {
        var d = new Dictionary<string, string>(arr.Length / 2);
        for (int i = 0; i + 1 < arr.Length; i += 2) d[arr[i]] = arr[i + 1];
        return d;
    }
}
