using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppTLD.Gear;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TldHacks;

// 物品生成器悬停预览:游戏原生的背包图标、名字和描述,画在鼠标对面那半边屏幕。
// ponytail: 只留最近 16 条。图标句柄挤出去时还给 Addressables;描述先读 GearItemData(只有数据),
//   没有再临时加载 prefab 读完就放。加载前先查 key 在不在,查不到的不加载,免得 Player.log 刷 InvalidKeyException
internal static class ItemPreview
{
    private const int CacheMax = 16;
    private const float Delay = 0.2f;
    private const int WindowId = 0x71D4_AD;

    private sealed class Entry
    {
        public string Key;
        public Texture Icon;
        public Texture2D Shot;
        public AsyncOperationHandle<Texture2D> IconHandle;
        public bool OwnsIcon;
        public string Name;
        public string Desc;
    }

    private static readonly LinkedList<Entry> _lru = new();
    private static readonly Dictionary<string, LinkedListNode<Entry>> _map = new();
    private static readonly Regex NguiTags = new(@"\[[0-9a-fA-F]{6}\]|\[-\]|\[/?[bisu]\]", RegexOptions.Compiled);

    private static ItemEntry _mark, _hover;
    private static int _markFrame = -10;
    private static float _since;
    private static Entry _shown;
    private static Rect _panel;
    private static bool _broken;
    private static Texture2D _bg;
    private static GUIStyle _nameStyle, _descStyle;
    private static float _styleScale = -1f;

    // 主菜单的 GUI.Window 回调要等 OnGUI 返回后才跑,Draw 那时读到的是上一帧 Repaint 记下的行,所以按帧号判断
    internal static void BeginFrame() { }

    // 在生成器的每一行上调。坐标和 Ui.Hover 一样是窗口内的内容坐标
    internal static void Mark(ItemEntry e, Rect r)
    {
        if (Event.current.type == EventType.Repaint && Ui.InView && r.Contains(Event.current.mousePosition)) { _mark = e; _markFrame = Time.frameCount; }
    }

    // 主窗口画完后调,每个 OnGUI 事件都要调,窗口才收得到 Layout
    internal static void Draw(bool enabled, float scale)
    {
        if (_broken) return;
        try
        {
            var ev = Event.current;
            if (ev.type == EventType.Repaint)
            {
                var cur = enabled && Time.frameCount - _markFrame <= 1 ? _mark : null;
                if (cur != _hover) { _hover = cur; _since = Time.unscaledTime; _shown = null; }
                if (_hover != null && _shown == null && Time.unscaledTime - _since >= Delay)
                {
                    _shown = Get(_hover);
                    Layout(scale);
                }
            }
            if (_shown == null) return;
            GUI.Window(WindowId, _panel, (GUI.WindowFunction)DrawPanel, "", GUIStyle.none);
            GUI.BringWindowToFront(WindowId);
        }
        catch (Exception ex)
        {
            _broken = true;
            ModMain.Log?.Warning($"[ItemPreview] 已停用: {ex.Message}");
        }
    }

    private static void Layout(float scale)
    {
        EnsureStyles(scale);
        float sw = Screen.width, sh = Screen.height;
        float w = sw * 0.45f;
        float pad = 16f * scale;
        float img = _shown.Icon != null ? Mathf.Min(w - pad * 2f, sh * 0.55f) : 0f;
        float textW = w - pad * 2f;
        float nameH = _nameStyle.CalcHeight(new GUIContent(_shown.Name ?? ""), textW);
        float descH = string.IsNullOrEmpty(_shown.Desc) ? 0f : _descStyle.CalcHeight(new GUIContent(_shown.Desc), textW) + 6f * scale;
        float h = Mathf.Min(sh - 20f, pad * 2f + img + (img > 0f ? pad : 0f) + nameH + descH);
        // 鼠标在左半边就放右边,反过来放左边,预览永远不压在鼠标指着的那一行上
        float mx = Input.mousePosition.x;
        float x = mx < sw * 0.5f ? sw - w - 10f : 10f;
        _panel = new Rect(x, (sh - h) * 0.5f, w, h);
    }

    private static void DrawPanel(int id)
    {
        var s = _shown;
        if (s == null) return;
        float scale = _styleScale;
        float pad = 16f * scale;
        float w = _panel.width, h = _panel.height;
        GUI.DrawTexture(new Rect(0f, 0f, w, h), _bg);
        float y = pad;
        if (s.Icon != null)
        {
            float img = Mathf.Min(w - pad * 2f, Screen.height * 0.55f);
            GUI.DrawTexture(new Rect((w - img) * 0.5f, y, img, img), s.Icon, ScaleMode.ScaleToFit);
            y += img + pad;
        }
        float textW = w - pad * 2f;
        var nc = new GUIContent(s.Name ?? "");
        float nameH = _nameStyle.CalcHeight(nc, textW);
        GUI.Label(new Rect(pad, y, textW, nameH), nc, _nameStyle);
        y += nameH + 6f * scale;
        if (!string.IsNullOrEmpty(s.Desc))
            GUI.Label(new Rect(pad, y, textW, Mathf.Max(0f, h - y - pad)), s.Desc, _descStyle);
    }

    private static void EnsureStyles(float scale)
    {
        if (_bg == null)
        {
            _bg = new Texture2D(1, 1);
            _bg.SetPixel(0, 0, new Color(0.06f, 0.07f, 0.08f, 0.92f));
            _bg.Apply();
            _bg.hideFlags = HideFlags.HideAndDontSave;
        }
        if (_nameStyle != null && Mathf.Approximately(scale, _styleScale)) return;
        _styleScale = scale;
        var baseStyle = Ui.TipStyle ?? GUI.skin.label;
        _nameStyle = new GUIStyle(baseStyle) { fontSize = Mathf.RoundToInt(24f * scale), fontStyle = FontStyle.Bold, wordWrap = true, alignment = TextAnchor.UpperLeft };
        _nameStyle.normal.background = null;
        _nameStyle.normal.textColor = Color.white;
        _descStyle = new GUIStyle(baseStyle) { fontSize = Mathf.RoundToInt(17f * scale), wordWrap = true, alignment = TextAnchor.UpperLeft };
        _descStyle.normal.background = null;
        _descStyle.normal.textColor = new Color(0.85f, 0.85f, 0.85f);
    }

    private static Entry Get(ItemEntry e)
    {
        string key = e.PrefabName ?? "";
        if (_map.TryGetValue(key, out var node))
        {
            _lru.Remove(node);
            _lru.AddFirst(node);
            return node.Value;
        }
        var en = new Entry { Key = key };
        string shortName = key.StartsWith("GEAR_", StringComparison.Ordinal) ? key.Substring(5) : key;
        bool furniture = e.Category == "家具";

        if (!furniture)
        {
            LoadIcon("ico_GearItem__" + shortName, en);

            string dataKey = "GearItemData_" + shortName;
            if (Exists<GearItemData>(dataKey))
            {
                try
                {
                    var h = Addressables.LoadAssetAsync<GearItemData>((Il2CppSystem.Object)dataKey);
                    var d = h.WaitForCompletion();
                    if (d != null) { en.Name = d.DisplayName; en.Desc = d.Description; }
                    Addressables.Release(h);
                }
                catch { }
            }

            if (string.IsNullOrEmpty(en.Desc) && Exists<GameObject>(key))
            {
                try
                {
                    var h = Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)key);
                    var go = h.WaitForCompletion();
                    var gi = go != null ? go.GetComponent<GearItem>() : null;
                    if (gi != null)
                    {
                        if (string.IsNullOrEmpty(en.Name)) en.Name = gi.DisplayName;
                        en.Desc = gi.Description;
                        // mod 物品的图标不一定按 ico_GearItem__ 登记,退回物品自己的图标(游戏管它的生命周期)
                        if (en.Icon == null) { try { en.Icon = gi.GetInventoryIconTexture(); } catch { } }
                    }
                    Addressables.Release(h);
                }
                catch { }
            }
        }

        else
        {
            // SCPlus 器械(铣床、炉子这些)没有 DecorationItem,先找 SCPlus 自带的图标,模型路径也从 SCPlus 的器械表拿
            bool carry = string.IsNullOrEmpty(e.Remark);
            if (carry) LoadIcon(ScPlusIconKey(key), en);
            string path = carry ? ScPlusAssetPath(key) : key;
            if (!string.IsNullOrEmpty(path) && Exists<GameObject>(path))
            {
                try
                {
                    var h = Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)path);
                    var go = h.WaitForCompletion();
                    var di = go != null ? go.GetComponent<DecorationItem>() : null;
                    if (di != null)
                    {
                        try { en.Name = di.DisplayName; } catch { }
                        try { en.Desc = di.m_Description?.Text(); } catch { }
                        if (en.Icon == null)
                        {
                            try
                            {
                                var r = di.IconReference;
                                if (r != null && r.RuntimeKeyIsValid()) LoadIcon(r.RuntimeKey.ToString(), en);
                            }
                            catch { }
                        }
                    }
                    if (en.Icon == null) LoadIcon(ScPlusIconKey(go_name(path)), en);
                    if (en.Icon == null && go != null)
                    {
                        try { en.Shot = Snapshot(go, 512); en.Icon = en.Shot; }
                        catch (Exception ex) { ModMain.Log?.Warning($"[ItemPreview] 拍 {key} 失败: {ex.Message}"); }
                    }
                    Addressables.Release(h);
                }
                catch { }
            }
        }

        if (string.IsNullOrEmpty(en.Name))
            en.Name = I18n.IsEnglish ? (e.NameEn ?? e.Name) : (e.NameZh ?? e.Name);
        if (!string.IsNullOrEmpty(en.Desc)) en.Desc = NguiTags.Replace(en.Desc, "");

        _map[key] = _lru.AddFirst(en);
        while (_lru.Count > CacheMax)
        {
            var last = _lru.Last;
            _lru.RemoveLast();
            _map.Remove(last.Value.Key);
            if (last.Value.OwnsIcon) { try { Addressables.Release(last.Value.IconHandle); } catch { } }
            if (last.Value.Shot != null) UnityEngine.Object.Destroy(last.Value.Shot);
        }
        return en;
    }

    private static void LoadIcon(string key, Entry en)
    {
        if (string.IsNullOrEmpty(key) || !Exists<Texture2D>(key)) return;
        try
        {
            var h = Addressables.LoadAssetAsync<Texture2D>((Il2CppSystem.Object)key);
            var t = h.WaitForCompletion();
            if (t != null) { en.Icon = t; en.IconHandle = h; en.OwnsIcon = true; }
            else Addressables.Release(h);
        }
        catch { }
    }

    private static string go_name(string path)
    {
        int a = path.LastIndexOf('/') + 1;
        int b = path.EndsWith(".prefab", StringComparison.OrdinalIgnoreCase) ? path.Length - 7 : path.Length;
        return b > a ? path.Substring(a, b - a) : path;
    }

    private static Dictionary<string, string> _scpIcons;
    private static bool _scpLooked;

    // SCPlusFix++ 启动时把自己的图标包目录读进 SCPMain.catalogParsed(物品名 → 图标 key),这里直接借用
    private static string ScPlusIconKey(string name)
    {
        if (!_scpLooked)
        {
            _scpLooked = true;
            try
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    var t = asm.GetType("SCPlusPP.SCPMain", false);
                    if (t == null) continue;
                    _scpIcons = t.GetField("catalogParsed", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)?.GetValue(null) as Dictionary<string, string>;
                    break;
                }
            }
            catch { }
        }
        return _scpIcons != null && name != null && _scpIcons.TryGetValue(name, out var k) ? k : null;
    }

    private static System.Collections.IDictionary _scpDefs;
    private static bool _scpDefsLooked;

    private static string ScPlusAssetPath(string name)
    {
        if (!_scpDefsLooked)
        {
            _scpDefsLooked = true;
            try
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    var t = asm.GetType("SCPlusPP.CarryableData", false);
                    if (t == null) continue;
                    _scpDefs = t.GetField("carryablePrefabDefinition", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)?.GetValue(null) as System.Collections.IDictionary;
                    break;
                }
            }
            catch { }
        }
        if (_scpDefs == null || name == null || !_scpDefs.Contains(name)) return null;
        var def = _scpDefs[name];
        var ty = def.GetType();
        if (ty.GetField("needsReconstruction")?.GetValue(def) is true) return null;
        return ty.GetField("assetPath")?.GetValue(def) as string;
    }

    private const int ShotLayer = 31;

    // 没有图标的家具现拍一张。只复制 LOD0 的网格和材质到隐藏图层,不实例化 prefab(它的脚本会登记存档),拍完全部删掉
    // ponytail: 朝向按 Unity 习惯假定正面朝 +Z,有的家具会拍成侧面;灯光是临时的一盏平行光,靠场景环境光的材质会偏暗
    private static Texture2D Snapshot(GameObject prefab, int size)
    {
        var root = new GameObject("TldHacksPreviewShot");
        root.transform.position = new Vector3(0f, -5000f, 0f);
        GameObject camGo = null, lightGo = null;
        RenderTexture rt = null;
        var prevActive = RenderTexture.active;
        try
        {
            var lod0 = new HashSet<IntPtr>();
            var otherLod = new HashSet<IntPtr>();
            var lg = prefab.GetComponentInChildren<LODGroup>(true);
            if (lg != null)
            {
                var lods = lg.GetLODs();
                for (int i = 0; i < lods.Length; i++)
                {
                    var rs = lods[i].renderers;
                    if (rs == null) continue;
                    foreach (var r in rs)
                        if (r != null) (i == 0 ? lod0 : otherLod).Add(r.Pointer);
                }
            }

            var inv = prefab.transform.worldToLocalMatrix;
            bool any = false;
            Bounds b = default;
            foreach (var r in prefab.GetComponentsInChildren<Renderer>(true))
            {
                if (r == null || !r.enabled || !r.gameObject.activeSelf) continue;
                if (otherLod.Contains(r.Pointer) && !lod0.Contains(r.Pointer)) continue;
                Mesh mesh = null;
                var smr = r.TryCast<SkinnedMeshRenderer>();
                if (smr != null) mesh = smr.sharedMesh;
                else if (r.TryCast<MeshRenderer>() != null)
                {
                    var mf = r.GetComponent<MeshFilter>();
                    if (mf != null) mesh = mf.sharedMesh;
                }
                if (mesh == null) continue;

                var m = inv * r.transform.localToWorldMatrix;
                var part = new GameObject("p");
                part.layer = ShotLayer;
                part.transform.SetParent(root.transform, false);
                part.transform.localPosition = m.GetColumn(3);
                part.transform.localRotation = m.rotation;
                part.transform.localScale = m.lossyScale;
                part.AddComponent<MeshFilter>().sharedMesh = mesh;
                var mr = part.AddComponent<MeshRenderer>();
                mr.sharedMaterials = r.sharedMaterials;
                mr.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
                mr.receiveShadows = false;
                if (!any) { b = mr.bounds; any = true; } else b.Encapsulate(mr.bounds);
            }
            if (!any) return null;

            float radius = Mathf.Max(0.05f, b.extents.magnitude);
            const float fov = 30f;
            float dist = radius / Mathf.Sin(fov * 0.5f * Mathf.Deg2Rad) * 1.05f;
            var toCam = new Vector3(0.6f, 0.5f, 1f).normalized;

            camGo = new GameObject("TldHacksPreviewCam");
            var cam = camGo.AddComponent<Camera>();
            cam.enabled = false;
            cam.cullingMask = 1 << ShotLayer;
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = new Color(0f, 0f, 0f, 0f);
            cam.renderingPath = RenderingPath.Forward;
            cam.allowHDR = false;
            cam.allowMSAA = false;
            cam.fieldOfView = fov;
            cam.nearClipPlane = Mathf.Max(0.01f, dist - radius * 1.5f);
            cam.farClipPlane = dist + radius * 2f;
            camGo.transform.position = b.center + toCam * dist;
            camGo.transform.LookAt(b.center);

            lightGo = new GameObject("TldHacksPreviewLight");
            var light = lightGo.AddComponent<Light>();
            light.type = LightType.Directional;
            light.intensity = 1.1f;
            light.color = Color.white;
            light.shadows = LightShadows.None;
            light.cullingMask = 1 << ShotLayer;
            lightGo.transform.rotation = Quaternion.LookRotation(-(toCam + Vector3.up * 0.8f + Vector3.left * 0.4f).normalized);

            rt = new RenderTexture(size, size, 24, RenderTextureFormat.ARGB32);
            cam.targetTexture = rt;
            cam.Render();
            cam.targetTexture = null;

            RenderTexture.active = rt;
            var tex = new Texture2D(size, size, TextureFormat.RGBA32, false);
            tex.ReadPixels(new Rect(0f, 0f, size, size), 0, 0);
            tex.Apply(false, true);
            tex.hideFlags = HideFlags.HideAndDontSave;
            return tex;
        }
        finally
        {
            RenderTexture.active = prevActive;
            if (rt != null) { rt.Release(); UnityEngine.Object.Destroy(rt); }
            if (lightGo != null) UnityEngine.Object.Destroy(lightGo);
            if (camGo != null) UnityEngine.Object.Destroy(camGo);
            UnityEngine.Object.Destroy(root);
        }
    }

    private static bool Exists<T>(string key) where T : Il2CppSystem.Object
    {
        try
        {
            var h = Addressables.LoadResourceLocationsAsync((Il2CppSystem.Object)key, Il2CppType.Of<T>());
            var locs = h.WaitForCompletion();
            bool ok = locs != null && locs.Cast<Il2CppSystem.Collections.Generic.ICollection<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>().Count > 0;
            Addressables.Release(h);
            return ok;
        }
        catch { return false; }
    }
}
