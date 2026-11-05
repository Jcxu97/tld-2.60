using System.Text;

namespace TldHacks;

// 物品生成器搜索框的匹配逻辑。支持三种输入:拼音首字母(xs)、完整拼音(xiangshi)、英文原名(acorn)。
// 每个物品的索引在第一次搜索时算一次,存回 ItemEntry,之后只做 string.Contains。
internal static class PinyinSearch
{
    private static string[] _syllables;

    private static string Syllable(char c)
    {
        if (c < PinyinData.First || c > PinyinData.Last) return null;
        int v = PinyinData.Index[c - PinyinData.First] - PinyinData.Base;
        if (v <= 0) return null;
        if (_syllables == null) _syllables = PinyinData.Syllables.Split(',');
        return v <= _syllables.Length ? _syllables[v - 1] : null;
    }

    // 中文名 → 全拼 + 首字母。名字里混的英文和数字原样留下(军用速食口粮 600k、MRE 这种),
    // 括号、空格、连接符丢掉,这样"橡实(熟)"用 xss 和 xiangshishu 都搜得到。
    internal static void Build(string name, out string full, out string initials)
    {
        if (string.IsNullOrEmpty(name)) { full = ""; initials = ""; return; }
        var f = new StringBuilder(name.Length * 4);
        var i = new StringBuilder(name.Length);
        for (int k = 0; k < name.Length; k++)
        {
            char c = name[k];
            string syl = Syllable(c);
            if (syl != null) { f.Append(syl); i.Append(syl[0]); continue; }
            if (c >= 'A' && c <= 'Z') c = (char)(c + 32);
            if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')) { f.Append(c); i.Append(c); }
        }
        full = f.ToString();
        initials = i.ToString();
    }

    // query 必须已经是小写、非空;拼音两项用去掉空格的 compact(xiang shi 也能搜到橡实),英文名本来带空格用原串
    internal static bool Match(ItemEntry e, string query, string compact)
    {
        if (e.SearchFull == null) BuildFor(e);
        if (compact.Length > 0 && e.SearchInit.Length > 0 && e.SearchInit.Contains(compact)) return true;
        if (compact.Length > 0 && e.SearchFull.Length > 0 && e.SearchFull.Contains(compact)) return true;
        if (e.SearchEn.Length > 0 && e.SearchEn.Contains(query)) return true;
        string zh = StripMod(e.NameZh, e.IsMod);
        return zh != null && zh.Contains(query);   // 粘贴中文名也能搜
    }

    // 显示名末尾拼的 " (mod)" 不能进索引,否则敲 m / o / d 会命中全部 mod 物品
    private static string StripMod(string s, bool isMod)
        => isMod && s != null && s.EndsWith(" (mod)") ? s.Substring(0, s.Length - 6) : s;

    private static void BuildFor(ItemEntry e)
    {
        string zh = StripMod(e.NameZh, e.IsMod);
        Build(string.IsNullOrEmpty(zh) ? e.Name : zh, out string full, out string initials);
        e.SearchFull = full;
        e.SearchInit = initials;
        string prefab = e.PrefabName ?? "";
        if (prefab.StartsWith("GEAR_")) prefab = prefab.Substring(5);
        // 家具的 PrefabName 是资源路径,只留文件名,不然 assets / prefabs 这些词谁都能搜中
        if (prefab.EndsWith(".prefab")) prefab = prefab.Substring(prefab.LastIndexOf('/') + 1, prefab.Length - prefab.LastIndexOf('/') - 8);
        e.SearchEn = ((StripMod(e.NameEn, e.IsMod) ?? "") + " " + prefab.Replace('_', ' ')).ToLowerInvariant();
    }
}
