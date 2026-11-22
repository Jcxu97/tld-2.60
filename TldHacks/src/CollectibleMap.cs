#if !STORY_EDITION && !EP5_EDITION
using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

namespace TldHacks;

// 收藏品标在地图上。点位来自离线扫描(CollectibleData.cs),室内的标在进门的位置。
// 收没收过:石堆看 CollectionManager 的石堆表,纸条和拍立得看背包里有没有同名物品(原版捡了就一直在背包里)。
// 当前加载着的场景再对一遍实物:随机没刷出来的、这个模式不刷的,场景里找不到就不标。
internal static class CollMap
{
    private static TldHacksSettings S => ModMain.Settings;
    internal static bool On => S != null && S.Coll_Enabled && (S.Coll_Cairn || S.Coll_Note || S.Coll_Polaroid);

    private sealed class Row
    {
        public char Kind;
        public string Region, Name, Src, Inner;
        public Vector3 Pos, SrcPos;
        public int Journal;
        public bool Alt;
    }

    private static List<Row> _rows;
    private static readonly Dictionary<string, string> _mapOf = new();
    private static readonly List<GameObject> _marks = new();
    private static GameObject _legend;
    private static UILabel _template;
    private static string _lastMap;

    private static List<Row> Rows()
    {
        if (_rows != null) return _rows;
        _rows = new List<Row>();
        foreach (var line in CollectibleData.Rows.Split('\n'))
        {
            var f = line.Trim().Split('|');
            if (f.Length < 13) continue;
            try
            {
                _rows.Add(new Row
                {
                    Kind = f[0][0], Region = f[1],
                    Pos = new Vector3(F(f[2]), F(f[3]), F(f[4])),
                    Name = f[5], Journal = int.Parse(f[6]), Alt = f[7] == "1",
                    Src = f[8], SrcPos = new Vector3(F(f[9]), F(f[10]), F(f[11])), Inner = f[12],
                });
            }
            catch { }
        }
        return _rows;
    }

    private static float F(string s) => float.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

    private static string Norm(string n)
    {
        if (string.IsNullOrEmpty(n)) return "";
        n = n.Replace("(Clone)", "").Trim();
        int p = n.LastIndexOf(" (", StringComparison.Ordinal);
        if (p > 0 && n.EndsWith(")")) n = n.Substring(0, p);
        return n;
    }

    private static bool KindOn(char k) => k switch
    {
        'C' => S.Coll_Cairn,
        'N' => S.Coll_Note,
        'P' => S.Coll_Polaroid,
        _ => false,
    };

    private static string MapOf(Panel_Map panel, string scene)
    {
        if (_mapOf.TryGetValue(scene, out var m)) return m;
        try { m = panel.GetMapNameOfScene(scene); } catch { m = null; }
        if (string.IsNullOrEmpty(m)) m = scene;
        _mapOf[scene] = m;
        return m;
    }

    internal static void Clear()
    {
        _sizeLogged = false;
        foreach (var go in _marks) if (go != null) UnityEngine.Object.Destroy(go);
        _marks.Clear();
        if (_legend != null) _legend.SetActive(false);
        _lastMap = null;
    }

    internal static void Tick()
    {
        if (!On && (_marks.Count > 0 || (_legend != null && _legend.activeSelf))) Clear();
        if (_marks.Count > 0) FitSize();
    }

    private const int MarkFont = 16;
    private static UISprite _refIcon;
    private static bool _sizeLogged;

    // 跟原版小图标(兔子、植物那类)一个规矩:地图拉远不显示,拉近照着一个小图标的实际高度定大小
    private static void FitSize()
    {
        try
        {
            var panel = InterfaceManager.GetPanel<Panel_Map>();
            if (panel == null || !panel.IsEnabled() || panel.m_MapElementsTransform == null) return;
            bool show = panel.m_IsZoomed;
            foreach (var go in _marks) if (go != null && go.activeSelf != show) go.SetActive(show);
            if (!show) return;
            if (_refIcon == null || !_refIcon.gameObject.activeInHierarchy) _refIcon = FindRefIcon(panel);
            if (_refIcon == null) return;
            float target = _refIcon.height * _refIcon.transform.lossyScale.y;
            float parent = panel.m_MapElementsTransform.lossyScale.y;
            UILabel lb = null;
            foreach (var go in _marks) if (go != null && (lb = go.GetComponent<UILabel>()) != null) break;
            float glyph = lb != null ? lb.printedSize.y : 0f;
            if (glyph <= 0f) glyph = MarkFont;
            if (target <= 0f || parent <= 0f) return;
            var sc = Vector3.one * (0.5f * target / (glyph * parent));
            foreach (var go in _marks) if (go != null) go.transform.localScale = sc;
            if (!_sizeLogged)
            {
                _sizeLogged = true;
                ModMain.Log?.Msg($"[CollMap] size ref={_refIcon.name} h={_refIcon.height} refScale={_refIcon.transform.lossyScale.y:F5} parent={parent:F5} glyph={glyph:F1} scale={sc.x:F3}");
            }
        }
        catch { }
    }

    private static UISprite FindRefIcon(Panel_Map panel)
    {
        foreach (var root in new[] { panel.m_DetailEntryActiveObjects, panel.m_SmallSpriteActiveObjects })
        {
            if (root == null) continue;
            var sps = root.GetComponentsInChildren<UISprite>(false);
            for (int i = 0; sps != null && i < sps.Count; i++)
                if (sps[i] != null && sps[i].height > 0) return sps[i];
        }
        return null;
    }

    internal static void Rebuild(Panel_Map panel, string scene)
    {
        try
        {
            Clear();
            if (!On || panel == null || panel.m_MapElementsTransform == null) return;
            string map = MapOf(panel, string.IsNullOrEmpty(scene) ? panel.GetMapNameOfCurrentScene() : scene);
            if (string.IsNullOrEmpty(map)) return;
            _lastMap = map;

            var bag = new HashSet<string>();
            var inv = GameManager.m_Inventory;
            for (int i = 0; inv?.m_Items != null && i < inv.m_Items.Count; i++)
            {
                var gi = inv.m_Items[i]?.m_GearItem;
                if (gi != null) bag.Add(Norm(gi.name));
            }
            var cairns = CollectionManager.m_UnlockedCairnsDict;

            var loaded = new HashSet<string>();
            for (int i = 0; i < SceneManager.sceneCount; i++) loaded.Add(SceneManager.GetSceneAt(i).name);
            List<(string name, Vector3 pos)> liveItems = null;
            HashSet<int> liveCairns = null;

            int[] total = new int[3], left = new int[3];
            var counted = new HashSet<string>();
            foreach (var r in Rows())
            {
                if (!KindOn(r.Kind) || MapOf(panel, r.Region) != map) continue;
                bool got = r.Kind == 'C'
                    ? cairns != null && cairns.ContainsKey(r.Journal)
                    : bag.Contains(r.Name) || bag.Contains(r.Name.Replace("OBJ_", "GEAR_"));
                bool alt = r.Alt;
                if (!got && loaded.Contains(r.Src))
                {
                    if (liveItems == null) Scan(out liveItems, out liveCairns);
                    if (!Live(r, liveItems, liveCairns)) continue;
                    alt = false;
                }
                int k = r.Kind == 'C' ? 0 : r.Kind == 'N' ? 1 : 2;
                if (counted.Add(r.Kind + (r.Kind == 'C' ? r.Journal.ToString() : r.Name)))
                {
                    total[k]++;
                    if (!got) left[k]++;
                }
                if (got && !S.Coll_ShowCollected) continue;
                Mark(panel, map, r, got, alt);
            }
            Legend(panel, total, left);
            ModMain.Log?.Msg($"[CollMap] {map} marks={_marks.Count} cairn {left[0]}/{total[0]} note {left[1]}/{total[1]} polaroid {left[2]}/{total[2]}");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[CollMap] rebuild {ex.Message}"); }
    }

    private static void Scan(out List<(string, Vector3)> items, out HashSet<int> cairns)
    {
        items = new List<(string, Vector3)>();
        cairns = new HashSet<int>();
        var nci = UnityEngine.Object.FindObjectsOfType<NarrativeCollectibleItem>();
        for (int i = 0; nci != null && i < nci.Count; i++)
        {
            if (nci[i] == null) continue;
            // 有的纸条物体在场景里但没显示(模型关着),看不见也捡不到,不算
            var rd = nci[i].GetComponentInChildren<Renderer>();
            bool seen = rd != null && rd.enabled && rd.gameObject.activeInHierarchy;
            if (!seen) { ModMain.Log?.Msg($"[CollMap] hidden {nci[i].gameObject.name} at {nci[i].transform.position}"); continue; }
            items.Add((Norm(nci[i].gameObject.name), nci[i].transform.position));
        }
        var cs = UnityEngine.Object.FindObjectsOfType<Cairn>();
        for (int i = 0; cs != null && i < cs.Count; i++)
            if (cs[i] != null) cairns.Add(cs[i].m_JournalEntryNumber);
    }

    private static bool Live(Row r, List<(string name, Vector3 pos)> items, HashSet<int> cairns)
    {
        if (r.Kind == 'C') return cairns.Contains(r.Journal);
        foreach (var it in items)
            if (it.name == r.Name && (it.pos - r.SrcPos).sqrMagnitude < 25f) return true;
        return false;
    }

    private static UILabel Template(Panel_Map panel)
    {
        if (_template != null) return _template;
        var pool = panel.m_TextPoolParent;
        for (int i = 0; pool != null && i < pool.childCount && _template == null; i++)
            _template = pool.GetChild(i).GetComponent<UILabel>();
        if (_template == null) _template = panel.m_LastUpdatedLabel;
        return _template;
    }

    private static UILabel NewLabel(UILabel tpl, Transform parent, string name)
    {
        var go = UnityEngine.Object.Instantiate(tpl.gameObject);
        go.name = name;
        var comps = go.GetComponents<MonoBehaviour>();
        foreach (var c in comps)
        {
            var n = c.GetIl2CppType().Name;
            if (n != "UILabel" && n != "UIWidget") UnityEngine.Object.Destroy(c);
        }
        for (int i = go.transform.childCount - 1; i >= 0; i--) UnityEngine.Object.Destroy(go.transform.GetChild(i).gameObject);
        go.transform.SetParent(parent, false);
        go.SetActive(true);
        return go.GetComponent<UILabel>();
    }

    private static readonly Color[] Colors =
    {
        new(0.92f, 0.92f, 0.92f, 1f),
        new(1f, 0.82f, 0.25f, 1f),
        new(0.35f, 0.9f, 1f, 1f),
    };

    private static void Mark(Panel_Map panel, string map, Row r, bool got, bool alt)
    {
        var tpl = Template(panel);
        if (tpl == null) return;
        var lb = NewLabel(tpl, panel.m_MapElementsTransform, "TldHacks_Coll");
        int k = r.Kind == 'C' ? 0 : r.Kind == 'N' ? 1 : 2;
        bool inside = r.Inner.Length > 0;
        string g = k switch { 0 => inside ? "△" : "▲", 1 => inside ? "□" : "■", _ => inside ? "○" : "●" };
        lb.text = alt ? g + "?" : g;
        lb.fontSize = MarkFont;
        lb.overflowMethod = UILabel.Overflow.ResizeFreely;
        lb.pivot = UIWidget.Pivot.Center;
        var c = Colors[k];
        if (got) c = new Color(c.r * 0.5f, c.g * 0.5f, c.b * 0.5f, 0.6f);
        lb.color = c;
        lb.effectStyle = UILabel.Effect.Outline;
        lb.effectColor = new Color(0f, 0f, 0f, 0.85f);
        lb.effectDistance = new Vector2(1f, 1f);
        lb.depth = 5000;
        var p = panel.WorldPositionToMapPosition(map, r.Pos);
        lb.transform.localPosition = new Vector3(p.x, p.y, 0f);
        lb.transform.localRotation = Quaternion.identity;
        lb.transform.localScale = Vector3.one;
        _marks.Add(lb.gameObject);
    }

    private static void Legend(Panel_Map panel, int[] total, int[] left)
    {
        var anchor = panel.m_LastUpdatedLabel;
        if (anchor == null) return;
        if (_legend == null)
        {
            var lb = NewLabel(anchor, anchor.transform.parent, "TldHacks_CollLegend");
            lb.overflowMethod = UILabel.Overflow.ResizeFreely;
            _legend = lb.gameObject;
        }
        var l = _legend.GetComponent<UILabel>();
        var parts = new List<string>();
        if (S.Coll_Cairn) parts.Add(I18n.T($"▲ 石堆 {left[0]}/{total[0]}", $"▲ Cairns {left[0]}/{total[0]}"));
        if (S.Coll_Note) parts.Add(I18n.T($"■ 纸条 {left[1]}/{total[1]}", $"■ Notes {left[1]}/{total[1]}"));
        if (S.Coll_Polaroid) parts.Add(I18n.T($"● 拍立得 {left[2]}/{total[2]}", $"● Polaroids {left[2]}/{total[2]}"));
        l.text = I18n.T("未收集 ", "Not found ") + string.Join("   ", parts);
        l.transform.localPosition = anchor.transform.localPosition + new Vector3(0f, -(anchor.fontSize + 8), 0f);
        _legend.SetActive(true);
    }
}

internal static class Patch_Coll_MapEnable
{
    private static void Postfix(Panel_Map __instance, bool enable)
    {
        if (enable) CollMap.Rebuild(__instance, null);
    }
}

internal static class Patch_Coll_LoadElements
{
    private static void Postfix(Panel_Map __instance, string sceneName)
    {
        if (__instance.IsEnabled()) CollMap.Rebuild(__instance, sceneName);
    }
}
#endif
