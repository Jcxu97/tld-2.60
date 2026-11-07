using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gear;
using Il2CppTLD.Placement;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Object = UnityEngine.Object;

namespace HutDoorTorch;

// 壁挂火把是一件家具(DecorationItem),摆放、挂墙、收进背包、读档都走原版装修系统。
// 底子是原版的墙挂铜鱼标本(本来就是挂墙的家具),把鱼换成火把加铁支架,再给它一个自己的资源编号。
// 原版读档按编号生成家具,遇到我们的编号先按铜鱼生成,生成完再换成火把。
// 火把模型、火焰和灯光取自原版火把,脚本全部去掉,所以不会烧完也不会被风吹灭。
internal static class Torches
{
    internal const string BasePath = "Assets/ArtAssets/Env/Objects/OBJ_Safehouse_Deco/OBJ_Mounted_Copper_Fish_Prefab.prefab";
    internal const string FakeGuid = "8d1f0c2a9b7e4c11a5f3d6e0b2c4a702";
    private const string VisualName = "HDT_TorchVisual";
    private const float HoldFraction = 0.3f;
    private const float WallGap = 0.09f;

    internal static DecorationItem Template;
    private const string LightInName = "HDT_LightIndoor";
    private const string LightOutName = "HDT_LightOutdoor";
    private const float LightOut = 0.35f;
    private static readonly List<(GameObject indoor, GameObject outdoor)> Pairs = new();
    private static string _lightScene;
    private static bool _outside;
    internal static DecorationItem BaseItem;
    private static AssetReferencePlaceable _baseRef;
    private static GameObject _holder;
    private static readonly List<(Light light, float seed, float baseIntensity, float baseRange)> Lights = new();

    internal static void EnsureTemplate()
    {
        if (Template != null) return;
        GameObject prefab = null;
        try { prefab = Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)BasePath).WaitForCompletion(); } catch { }
        var pl = prefab != null ? prefab.GetComponent<Placeable>() : null;
        if (prefab == null || prefab.GetComponent<DecorationItem>() == null || pl == null)
        {
            ModMain.Log.Error("找不到铜鱼标本家具,壁挂火把做不出来");
            return;
        }
        _baseRef = pl.m_Addressable;
        BaseItem = prefab.GetComponent<DecorationItem>();
        _holder = new GameObject("HutDoorTorch_DecoTemplate");
        _holder.SetActive(false);
        Object.DontDestroyOnLoad(_holder);
        var go = Object.Instantiate(prefab, _holder.transform);
        go.name = "HDT_WallTorch";
        Convert(go);
        Template = go.GetComponent<DecorationItem>();
        ModMain.Log.Msg($"壁挂火把模板已建好,摆放规则 {Template.m_PlacementRules}");
    }

    internal static DecorationItem GiveOne()
    {
        EnsureTemplate();
        if (Template == null) return null;
        return GameManager.GetPlayerManagerComponent().InstantiateDecorationItemInPlayerInventory(Template, PlayerManager.InventoryInstantiateFlags.None);
    }

    // 背包、制造界面里的图都用原版火把的
    internal static AssetReferenceTexture2D IconRef
    {
        get
        {
            try { return Gear.LoadVanilla("GEAR_Torch")?.m_GearItemData?.m_CoverFlowMainTexture; } catch { return null; }
        }
    }

    internal static bool IsOurs(AssetReference r)
    {
        try { return r != null && string.Equals(r.AssetGUID, FakeGuid, StringComparison.OrdinalIgnoreCase); }
        catch { return false; }
    }

    internal static AssetReferencePlaceable BaseRef => _baseRef;

    internal static void Convert(GameObject go)
    {
        if (go == null || go.transform.Find(VisualName) != null) return;

        // 铜鱼模型最薄的方向就是墙的法线,模型偏向哪边哪边就是朝外
        var outward = Vector3.forward;
        bool any = false;
        var b = new Bounds();
        foreach (var mf in go.GetComponentsInChildren<MeshFilter>(true))
        {
            if (mf.sharedMesh == null) continue;
            var m = go.transform.worldToLocalMatrix * mf.transform.localToWorldMatrix;
            var mb = mf.sharedMesh.bounds;
            for (int i = 0; i < 8; i++)
            {
                var c = m.MultiplyPoint(mb.center + Vector3.Scale(mb.extents, new Vector3((i & 1) == 0 ? -1 : 1, (i & 2) == 0 ? -1 : 1, (i & 4) == 0 ? -1 : 1)));
                if (!any) { b = new Bounds(c, Vector3.zero); any = true; } else b.Encapsulate(c);
            }
        }
        if (any)
        {
            var s = b.size;
            int axis = s.x < s.y ? (s.x < s.z ? 0 : 2) : (s.y < s.z ? 1 : 2);
            var dir = Vector3.zero;
            dir[axis] = b.center[axis] >= 0f ? 1f : -1f;
            outward = dir;
        }

        foreach (var lod in go.GetComponentsInChildren<LODGroup>(true)) Object.DestroyImmediate(lod);
        foreach (var r in go.GetComponentsInChildren<MeshRenderer>(true)) Object.DestroyImmediate(r);
        foreach (var mf in go.GetComponentsInChildren<MeshFilter>(true)) Object.DestroyImmediate(mf);
        foreach (var c in go.GetComponentsInChildren<Collider>(true)) Object.DestroyImmediate(c);

        var visual = BuildVisual();
        if (visual == null) return;
        visual.name = VisualName;
        visual.transform.SetParent(go.transform, false);
        var up = Mathf.Abs(Vector3.Dot(outward, Vector3.up)) > 0.9f ? Vector3.forward : Vector3.up;
        visual.transform.localRotation = Quaternion.LookRotation(outward, up);
        visual.transform.localPosition = Vector3.zero;

        int layer = vp_Layer.InteractiveProp;
        foreach (var t in visual.GetComponentsInChildren<Transform>(true))
            if (t.GetComponent<ParticleSystem>() == null && t.GetComponent<Light>() == null) t.gameObject.layer = layer;

        var di = go.GetComponent<DecorationItem>();
        if (di != null)
        {
            di.m_DisplayName = new LocalizedString { m_LocalizationID = "HDT_WallTorch" };
            di.m_Description = new LocalizedString { m_LocalizationID = "HDT_WallTorch_Desc" };
            di.m_Weight = Il2CppTLD.IntBackedUnit.ItemWeight.FromKilograms(1f);
            di.m_AllowInInventory = true;
            di.m_DecorationPrefab = new AssetReferenceDecorationItem(FakeGuid);
            var torchIcon = IconRef;
            if (torchIcon != null) di.m_IconReference = torchIcon;
            var tinted = new Il2CppSystem.Collections.Generic.List<Renderer>();
            foreach (var r in visual.GetComponentsInChildren<MeshRenderer>(true)) tinted.Add(r);
            di.m_TintedRenderers = tinted;
        }
        var pl = go.GetComponent<Placeable>();
        if (pl != null) pl.m_Addressable = new AssetReferencePlaceable(FakeGuid);

        foreach (var l in visual.GetComponentsInChildren<Light>(true))
            if (l.enabled) Lights.Add((l, UnityEngine.Random.value * 100f, l.intensity, l.range));
        var li = FindDeep(visual.transform, LightInName);
        var lo = FindDeep(visual.transform, LightOutName);
        if (li != null || lo != null) Pairs.Add((li?.gameObject, lo?.gameObject));
    }

    // z 轴朝墙外,火把绕 x 轴往外斜
    private static GameObject BuildVisual()
    {
        var prefab = Gear.LoadVanilla("GEAR_Torch");
        if (prefab == null) { ModMain.Log.Error("找不到原版火把"); return null; }

        var holder = new GameObject("HDT_tmp");
        holder.SetActive(false);
        var copy = Object.Instantiate(prefab.gameObject, holder.transform);
        var ti = copy.GetComponent<TorchItem>();
        GameObject meshGo = ti != null ? ti.m_TorchMeshGameObject : null;
        GameObject burntGo = ti != null ? ti.m_TorchBurntMeshGameObject : null;
        GameObject fxGo = ti != null ? ti.m_FXGameObject : null;
        Light lightIn = ti != null ? ti.m_LightIndoor : null;
        Light lightOut = ti != null ? ti.m_LightOutdoor : null;

        // 原版火把的光和火苗是 TorchIntensity 按燃烧程度调出来的,它离不开火把物品本身,
        // 所以先读出烧得最旺时的数值再删掉;灯光登记、闪烁、粒子的小脚本留着,效果和原版一样
        var ti2 = copy.GetComponentInChildren<TorchIntensity>(true);
        var fx = ReadIntensity(ti2);
        foreach (var mb in copy.GetComponentsInChildren<MonoBehaviour>(true))
        {
            if (mb.TryCast<LightTracking>() != null || mb.TryCast<LightRandomIntensity>() != null || mb.TryCast<ParticleRandomEmission>() != null) continue;
            if (mb.GetComponent<Light>() != null) continue;
            Object.DestroyImmediate(mb);
        }
        foreach (var rb in copy.GetComponentsInChildren<Rigidbody>(true)) Object.DestroyImmediate(rb);
        foreach (var c in copy.GetComponentsInChildren<Collider>(true)) Object.DestroyImmediate(c);
        foreach (var no in copy.GetComponentsInChildren<UnityEngine.AI.NavMeshObstacle>(true)) Object.DestroyImmediate(no);

        if (meshGo == null)
        {
            var mf0 = copy.GetComponentInChildren<MeshFilter>(true);
            meshGo = mf0 != null ? mf0.gameObject : copy;
        }
        if (burntGo != null) burntGo.SetActive(false);
        meshGo.SetActive(true);

        // 火把在预制体里的朝向:网格中心指向火焰那一头就是"上"
        var mf = meshGo.GetComponent<MeshFilter>();
        var b = mf != null && mf.sharedMesh != null ? mf.sharedMesh.bounds : new Bounds(Vector3.zero, new Vector3(0.05f, 0.6f, 0.05f));
        var m2c = copy.transform.worldToLocalMatrix * meshGo.transform.localToWorldMatrix;
        Vector3 center = m2c.MultiplyPoint(b.center);
        // 火把模型是顺着最长的那条边放的,火头那一端就是"上"
        int lng = b.size.x >= b.size.y ? (b.size.x >= b.size.z ? 0 : 2) : (b.size.y >= b.size.z ? 1 : 2);
        var la = Vector3.zero; la[lng] = 1f;
        Vector3 axis = m2c.MultiplyVector(la).normalized;
        var flame = fxGo != null ? FindDeep(fxGo.transform, "TorchFlame") ?? fxGo.transform : null;
        if (flame != null && Vector3.Dot(copy.transform.InverseTransformPoint(flame.position) - center, axis) < 0f) axis = -axis;
        if (axis.sqrMagnitude < 0.5f) axis = Vector3.up;
        // 原版火把平放在地上时火苗是朝上的,火焰就按那个朝向摆
        Quaternion fxRest = fxGo != null ? Quaternion.Inverse(copy.transform.rotation) * fxGo.transform.rotation : Quaternion.identity;
        float half = 0f;
        for (int i = 0; i < 8; i++)
        {
            var corner = b.center + Vector3.Scale(b.extents, new Vector3((i & 1) == 0 ? -1 : 1, (i & 2) == 0 ? -1 : 1, (i & 4) == 0 ? -1 : 1));
            half = Mathf.Max(half, Vector3.Dot(m2c.MultiplyPoint(corner) - center, axis));
        }
        if (half < 0.05f) half = 0.3f;
        Vector3 hold = center - axis * half + axis * (2f * half * HoldFraction);

        float tilt = ModMain.Settings != null ? ModMain.Settings.TiltDegrees : 35f;
        var root = new GameObject("HDT_TorchVisual");
        root.SetActive(false);
        var arm = new GameObject("Tilt").transform;
        arm.SetParent(root.transform, false);
        arm.localPosition = new Vector3(0f, 0f, WallGap);
        arm.localRotation = Quaternion.Euler(tilt, 0f, 0f);

        var r = Quaternion.FromToRotation(axis, Vector3.up);
        copy.transform.SetParent(arm, false);
        copy.transform.localRotation = r;
        copy.transform.localPosition = -(r * hold);

        // root 这时在原点不转,世界空间就是 root 空间。火焰转回平放时的朝向,再挪回火头上
        Vector3 head = Vector3.zero;
        if (fxGo != null)
        {
            fxGo.SetActive(true);
            var core = FindDeep(fxGo.transform, "Core") ?? flame;
            head = core.position;
            fxGo.transform.rotation = fxRest;
            fxGo.transform.position += head - core.position;
        }
        foreach (var l in copy.GetComponentsInChildren<Light>(true))
        {
            bool isOut = lightOut != null && l == lightOut;
            bool isIn = lightIn != null && l == lightIn;
            if (!isOut && !isIn) { l.enabled = false; continue; }
            l.gameObject.name = isOut ? LightOutName : LightInName;
            l.gameObject.SetActive(true);
            l.enabled = true;
            float full = isOut ? fx.outdoor : fx.indoor;
            if (full > 0f) l.intensity = full;
            if (l.range < 1f) l.range = 8f;
            var lri = l.GetComponent<LightRandomIntensity>();
            if (lri != null) Object.DestroyImmediate(lri);
            var lf = l.GetComponent<LightFlickering>();
            if (lf != null)
            {
                l.color = Color.Lerp(lf.color0, lf.color1, 0.5f);
                Object.DestroyImmediate(lf);
            }
            // 灯放在火头外面一点,免得把墙照成一块亮斑
            l.transform.position = head + Vector3.forward * LightOut + Vector3.up * 0.1f;
        }
        fx.Apply();

        BuildBracket(root.transform, arm, meshGo);

        var box = root.AddComponent<BoxCollider>();
        var bb = new Bounds(new Vector3(0f, 0.02f, 0.0125f), new Vector3(0.14f, 0.30f, 0.025f));
        foreach (var rr in root.GetComponentsInChildren<MeshRenderer>(true))
        {
            var lb = rr.GetComponent<MeshFilter>()?.sharedMesh?.bounds;
            if (lb == null) continue;
            var m = root.transform.worldToLocalMatrix * rr.transform.localToWorldMatrix;
            var e = lb.Value.extents;
            for (int i = 0; i < 8; i++)
                bb.Encapsulate(m.MultiplyPoint(lb.Value.center + Vector3.Scale(e, new Vector3((i & 1) == 0 ? -1 : 1, (i & 2) == 0 ? -1 : 1, (i & 4) == 0 ? -1 : 1))));
        }
        bb.SetMinMax(new Vector3(bb.min.x, bb.min.y, 0f), bb.max);
        box.center = bb.center;
        box.size = bb.size;

        Object.Destroy(holder);
        root.SetActive(true);
        foreach (var ps in root.GetComponentsInChildren<ParticleSystem>(true)) ps.Play(true);
        return root;
    }

    private sealed class FullFlame
    {
        internal float indoor, outdoor;
        internal readonly List<(ParticleSystem ps, float rate)> Rates = new();
        internal readonly List<(ParticleRandomEmission pre, float min, float max)> Random = new();
        internal GameObject glow;

        internal void Apply()
        {
            foreach (var (ps, rate) in Rates)
                if (ps != null) { var em = ps.emission; em.rateOverTime = rate; }
            foreach (var (pre, min, max) in Random)
                if (pre != null && min >= 0f && max >= 0f) { pre.m_Min = min; pre.m_Max = max; }
            if (glow != null) glow.SetActive(false);
        }
    }

    private static float At1(AnimationCurve c) => c != null && c.length > 0 ? c.Evaluate(1f) : -1f;

    private static FullFlame ReadIntensity(TorchIntensity t)
    {
        var f = new FullFlame();
        if (t == null) return f;
        try
        {
            // TorchIntensity 的 ParticleSystem 缓存字段要等它 Awake 才有,这里直接从公开的物体上取
            ParticleSystem Ps(GameObject g) => g != null ? g.GetComponent<ParticleSystem>() : null;
            ParticleRandomEmission Pre(GameObject g) => g != null ? g.GetComponent<ParticleRandomEmission>() : null;
            f.indoor = At1(t.m_IndoorIntensityMax);
            f.outdoor = At1(t.m_OutdoorIntensityMax);
            var sprite = Ps(t.m_SpriteParticles);
            var core = Ps(t.m_CoreParticles);
            void Rate(ParticleSystem ps, AnimationCurve c) { float v = At1(c); if (ps != null && v >= 0f) f.Rates.Add((ps, v)); }
            Rate(Ps(t.m_SparkParticles), t.m_SparkRate);
            Rate(Ps(t.m_SmokeParticles), t.m_SmokeRate);
            var spre = Pre(t.m_SpriteParticles);
            if (spre != null) f.Random.Add((spre, At1(t.m_SpriteRateMin), At1(t.m_SpriteRateMax)));
            else Rate(sprite, t.m_SpriteRateMax);
            var cpre = Pre(t.m_CoreParticles);
            if (cpre != null) f.Random.Add((cpre, At1(t.m_CoreRateMin), At1(t.m_CoreRateMax)));
            else Rate(core, t.m_CoreRateMax);
            f.glow = t.m_RadialGradient;
            ModMain.Log.Msg($"原版火把火光 室内 {f.indoor:F2} 室外 {f.outdoor:F2} 光晕 {(f.glow != null ? f.glow.name : "无")} 粒子 {f.Rates.Count}+{f.Random.Count}");
        }
        catch (Exception ex) { ModMain.Log.Warning("读原版火把火光失败: " + ex.Message); }
        return f;
    }

    private static void BuildBracket(Transform root, Transform arm, GameObject torchMesh)
    {
        Material mat = null;
        var mr = torchMesh != null ? torchMesh.GetComponent<MeshRenderer>() : null;
        if (mr != null && mr.sharedMaterial != null) mat = Res.Copy(mr.sharedMaterial, Res.Metal, "HDT_Bracket");

        Material wood = mr != null && mr.sharedMaterial != null ? Res.Copy(mr.sharedMaterial, Res.Board, "HDT_TorchBoard") : mat;
        Part(root, PrimitiveType.Cube, new Vector3(0f, 0.02f, 0.0125f), Quaternion.identity, new Vector3(0.14f, 0.30f, 0.025f), wood);
        Part(root, PrimitiveType.Cube, new Vector3(0f, 0f, WallGap * 0.5f + 0.008f), Quaternion.identity, new Vector3(0.022f, 0.022f, WallGap), mat);
        Part(arm, PrimitiveType.Cylinder, Vector3.zero, Quaternion.identity, new Vector3(0.07f, 0.02f, 0.07f), mat);
    }

    private static void Part(Transform parent, PrimitiveType type, Vector3 pos, Quaternion rot, Vector3 scale, Material mat)
    {
        var go = GameObject.CreatePrimitive(type);
        var col = go.GetComponent<Collider>();
        if (col != null) Object.DestroyImmediate(col);
        go.transform.SetParent(parent, false);
        go.transform.localPosition = pos;
        go.transform.localRotation = rot;
        go.transform.localScale = scale;
        if (mat != null) go.GetComponent<MeshRenderer>().sharedMaterial = mat;
        // 完美放置算外框时会丢掉叫 Cube/Cylinder 的内置网格,换个名字的副本让支架也算进去
        var mf = go.GetComponent<MeshFilter>();
        if (!Renamed.TryGetValue(type, out var mesh) || mesh == null)
        {
            mesh = Object.Instantiate(mf.sharedMesh);
            mesh.name = "HDT_Bracket" + type;
            mesh.hideFlags = HideFlags.DontUnloadUnusedAsset;
            Renamed[type] = mesh;
        }
        mf.sharedMesh = mesh;
    }

    private static readonly Dictionary<PrimitiveType, Mesh> Renamed = new();

    private static Transform FindDeep(Transform t, string name)
    {
        if (t.name == name) return t;
        for (int i = 0; i < t.childCount; i++) { var r = FindDeep(t.GetChild(i), name); if (r != null) return r; }
        return null;
    }

    // 室内外用原版火把各自那盏灯
    private static void TickLights()
    {
        string scene = Store.Scene;
        if (scene != _lightScene)
        {
            _lightScene = scene;
            try { _outside = GameManager.IsOutDoorsScene(scene); } catch { _outside = false; }
        }
        for (int i = Pairs.Count - 1; i >= 0; i--)
        {
            var (a, b) = Pairs[i];
            if (a == null && b == null) { Pairs.RemoveAt(i); continue; }
            bool useOut = _outside && b != null || a == null;
            if (a != null && a.activeSelf == useOut) a.SetActive(!useOut);
            if (b != null && b.activeSelf != useOut) b.SetActive(useOut);
        }
    }

    internal static void TickFlicker()
    {
        TickLights();
        if (Lights.Count == 0) return;
        float time = Time.time;
        float want = ModMain.Settings != null ? ModMain.Settings.LightIntensity : 1f;
        float amp = ModMain.Settings != null ? ModMain.Settings.Flicker : 0.1f;
        bool jump = ModMain.Settings != null && ModMain.Settings.VanillaFlicker;
        int step = Mathf.FloorToInt(time / 0.2f);
        for (int i = Lights.Count - 1; i >= 0; i--)
        {
            var (l, seed, b, range) = Lights[i];
            l.range = range * (ModMain.Settings != null ? ModMain.Settings.LightRange : 1f);
            if (l == null) { Lights.RemoveAt(i); continue; }
            float v;
            if (jump)
            {
                // 原版最暗和最亮的比例:室内 3/5,室外 0.8/1.6
                float low = l.gameObject.name == LightOutName ? 0.5f : 0.6f;
                float k = Mathf.PerlinNoise(seed + step * 7.13f, 0.5f);
                v = b * want * Mathf.Lerp(low, 1f, Mathf.Clamp01(k));
            }
            else v = b * want * (1f - amp * Mathf.PerlinNoise(seed, time * 3f));
            l.intensity = v;
            var lt = l.GetComponent<LightTracking>();
            if (lt != null) lt.SetLightIntensity(v);
        }
    }
}

// 读档时遇到壁挂火把的编号,先换成铜鱼的编号让原版生成,生成完再改回火把
[HarmonyPatch(typeof(Placeable), nameof(Placeable.FindOrCreateAndDeserialize))]
internal static class Patch_PlaceableFindOrCreate
{
    private static readonly HashSet<string> Pending = new();

    internal static bool TakePending(string guid) => guid != null && Pending.Remove(guid);

    private static void Prefix(string guid, PlaceableSaveData data, out bool __state)
    {
        __state = false;
        if (data == null || !Torches.IsOurs(data.m_Addressable)) return;
        Torches.EnsureTemplate();
        if (Torches.BaseRef == null) return;
        data.m_Addressable = Torches.BaseRef;
        __state = true;
        if (guid != null) Pending.Add(guid);
    }

    private static void Postfix(string guid, PlaceableSaveData data, Placeable __result, bool __state)
    {
        if (!__state) return;
        try { data.m_Addressable = new AssetReferencePlaceable(Torches.FakeGuid); } catch { }
        if (__result == null) { ModMain.Log.Warning($"壁挂火把 {guid} 读档时还没生成出来,等 Deserialize 再换"); return; }
        Pending.Remove(guid);
        Torches.Convert(__result.gameObject);
    }
}

[HarmonyPatch(typeof(Placeable), nameof(Placeable.Deserialize))]
internal static class Patch_PlaceableDeserialize
{
    private static void Postfix(Placeable __instance, string guid)
    {
        if (!Patch_PlaceableFindOrCreate.TakePending(guid)) return;
        Torches.Convert(__instance.gameObject);
    }
}

// 游戏按家具自己的资源编号生成家具,我们的编号不在资源表里会生成失败。
// 和读档一样,先让游戏按铜鱼标本生成并放进背包,出来以后再换成火把。制造、物品生成器、测试键都走这里
[HarmonyPatch(typeof(PlayerManager), nameof(PlayerManager.InstantiateDecorationItemInPlayerInventory))]
internal static class Patch_InstantiateDecoration
{
    private static bool _allow;
    private static void Prefix(ref DecorationItem decorationItem, out bool __state)
    {
        __state = decorationItem != null && decorationItem == Torches.Template && Torches.BaseItem != null;
        if (!__state) return;
        decorationItem = Torches.BaseItem;
        _allow = Torches.BaseItem.m_AllowInInventory;
        Torches.BaseItem.m_AllowInInventory = true;
    }

    private static void Postfix(DecorationItem __result, bool __state)
    {
        if (!__state) return;
        Torches.BaseItem.m_AllowInInventory = _allow;
        if (__result == null) { ModMain.Log.Warning("壁挂火把放进背包失败"); return; }
        Torches.Convert(__result.gameObject);
        __result.gameObject.name = Torches.Template.name;
        __result.m_AllowInInventory = true;
        ModMain.Log.Msg("壁挂火把放进背包了");
    }
}

// 背包格子里的小图换成原版火把的
[HarmonyPatch(typeof(DecorationItem), nameof(DecorationItem.GetInventoryIconTexture))]
internal static class Patch_DecorationIcon
{
    private static Texture2D _tex;
    private static void Postfix(DecorationItem __instance, ref Texture2D __result)
    {
        if (__instance == null || !__instance.name.StartsWith("HDT_WallTorch")) return;
        if (_tex == null)
            try { _tex = Gear.LoadVanilla("GEAR_Torch")?.GetInventoryIconTexture(); } catch { }
        if (_tex != null) __result = _tex;
    }
}

// 制造完成时游戏按成品自己的资源编号生成,新物品不在资源表里会什么都不给。
// 成品是门或壁挂火把时,改走能用的那条路直接放进背包
internal static class CraftedResult
{
    internal static bool TryMake(ICraftingResult result, ref ICraftingResult made)
    {
        if (result == null) return false;
        var pm = GameManager.GetPlayerManagerComponent();
        var di = result.TryCast<DecorationItem>();
        if (di != null && Torches.Template != null && di.Pointer == Torches.Template.Pointer)
        {
            var got = pm.InstantiateDecorationItemInPlayerInventory(Torches.Template, PlayerManager.InventoryInstantiateFlags.None);
            made = got != null ? got.Cast<ICraftingResult>() : null;
            ModMain.Log.Msg($"做好壁挂火把 {(got != null)}");
            return true;
        }
        var gi = result.TryCast<GearItem>();
        if (gi != null && Gear.ByName(gi.name) != null)
        {
            var got = pm.InstantiateItemInPlayerInventory(gi, 1, 1f, PlayerManager.InventoryInstantiateFlags.None);
            made = got != null ? got.Cast<ICraftingResult>() : null;
            ModMain.Log.Msg($"做好 {gi.name} {(got != null)}");
            return true;
        }
        return false;
    }
}

[HarmonyPatch(typeof(PlayerManager), nameof(PlayerManager.InstantiateCraftedItemInPlayerInventory))]
internal static class Patch_CraftedToInventory
{
    private static bool Prefix(ICraftingResult result, ref ICraftingResult __result)
    {
        try { return !CraftedResult.TryMake(result, ref __result); }
        catch (Exception ex) { ModMain.Log.Error("制造成品失败: " + ex); return true; }
    }
}

[HarmonyPatch(typeof(Container), nameof(Container.InstantiateCraftedItem))]
internal static class Patch_CraftedToContainer
{
    private static bool Prefix(ICraftingResult craftedItem, ref ICraftingResult __result)
    {
        try { return !CraftedResult.TryMake(craftedItem, ref __result); }
        catch (Exception ex) { ModMain.Log.Error("制造成品失败: " + ex); return true; }
    }
}
