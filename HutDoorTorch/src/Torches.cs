using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
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
    private static AssetReferencePlaceable _baseRef;
    private static GameObject _holder;
    private static readonly List<(Light light, float seed)> Lights = new();

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
        _holder = new GameObject("HutDoorTorch_DecoTemplate");
        _holder.SetActive(false);
        Object.DontDestroyOnLoad(_holder);
        var go = Object.Instantiate(prefab, _holder.transform);
        go.name = "HDT_WallTorch";
        Convert(go);
        Template = go.GetComponent<DecorationItem>();
        ModMain.Log.Msg($"壁挂火把模板已建好,摆放规则 {Template.m_PlacementRules}");
    }

    // 和 TldHacks 生成家具一样,先临时允许进背包,再走游戏自己的放进背包
    internal static DecorationItem GiveOne()
    {
        EnsureTemplate();
        if (Template == null) return null;
        bool allow = Template.m_AllowInInventory;
        DecorationItem di;
        try
        {
            Template.m_AllowInInventory = true;
            di = GameManager.GetPlayerManagerComponent().InstantiateDecorationItemInPlayerInventory(Template, PlayerManager.InventoryInstantiateFlags.None);
        }
        finally { Template.m_AllowInInventory = allow; }
        if (di == null) return null;
        di.gameObject.name = Template.name;
        di.m_AllowInInventory = true;
        ModMain.Log.Msg("壁挂火把放进背包了");
        return di;
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
            di.m_DecorationPrefab = new AssetReferenceDecorationItem(FakeGuid);
            var tinted = new Il2CppSystem.Collections.Generic.List<Renderer>();
            foreach (var r in visual.GetComponentsInChildren<MeshRenderer>(true)) tinted.Add(r);
            di.m_TintedRenderers = tinted;
        }
        var pl = go.GetComponent<Placeable>();
        if (pl != null) pl.m_Addressable = new AssetReferencePlaceable(FakeGuid);

        foreach (var l in visual.GetComponentsInChildren<Light>(true))
            if (l.enabled) Lights.Add((l, UnityEngine.Random.value * 100f));
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

        foreach (var mb in copy.GetComponentsInChildren<MonoBehaviour>(true)) Object.DestroyImmediate(mb);
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
        Vector3 axis = fxGo != null ? (copy.transform.InverseTransformPoint(fxGo.transform.position) - center).normalized
                                    : m2c.MultiplyVector(Vector3.up).normalized;
        if (axis.sqrMagnitude < 0.5f) axis = Vector3.up;
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

        // 火焰按火把竖着拿时的样子摆,这样斜插时火苗还是朝上
        if (fxGo != null)
        {
            fxGo.SetActive(true);
            // root 这时在原点不转,世界空间就是 root 空间,把斜出去的角度从火焰上转回来
            fxGo.transform.rotation = Quaternion.Euler(-tilt, 0f, 0f) * fxGo.transform.rotation;
        }
        var want = PickLight(lightIn, lightOut);
        float intensity = ModMain.Settings != null ? ModMain.Settings.LightIntensity : 1.2f;
        foreach (var l in copy.GetComponentsInChildren<Light>(true))
        {
            bool use = want == null || l == want;
            l.enabled = use;
            if (!use) continue;
            l.gameObject.SetActive(true);
            if (l.range < 1f) l.range = 8f;
            l.intensity = intensity;
        }
        if (fxGo != null)
            foreach (var l in fxGo.GetComponentsInChildren<Light>(true))
            {
                bool use = want == null || l == want;
                l.enabled = use;
                if (use) { if (l.range < 1f) l.range = 8f; l.intensity = intensity; }
            }

        BuildBracket(root.transform, arm, meshGo);

        var box = root.AddComponent<BoxCollider>();
        box.center = new Vector3(0f, 0.1f, 0.15f);
        box.size = new Vector3(0.25f, 0.6f, 0.3f);

        Object.Destroy(holder);
        root.SetActive(true);
        foreach (var ps in root.GetComponentsInChildren<ParticleSystem>(true)) ps.Play(true);
        return root;
    }

    private static Light PickLight(Light indoor, Light outdoor)
    {
        bool outside = false;
        try { outside = GameManager.IsOutDoorsScene(GameManager.m_ActiveScene); } catch { }
        if (outside && outdoor != null) return outdoor;
        return indoor ?? outdoor;
    }

    private static void BuildBracket(Transform root, Transform arm, GameObject torchMesh)
    {
        Material mat = null;
        var mr = torchMesh != null ? torchMesh.GetComponent<MeshRenderer>() : null;
        if (mr != null && mr.sharedMaterial != null) mat = Res.Copy(mr.sharedMaterial, Res.Metal, "HDT_Bracket");

        Part(root, PrimitiveType.Cube, new Vector3(0f, 0f, 0.008f), Quaternion.identity, new Vector3(0.09f, 0.16f, 0.016f), mat);
        Part(root, PrimitiveType.Cube, new Vector3(0f, 0f, WallGap * 0.5f + 0.008f), Quaternion.identity, new Vector3(0.022f, 0.022f, WallGap), mat);
        Part(arm, PrimitiveType.Cylinder, Vector3.zero, Quaternion.identity, new Vector3(0.07f, 0.02f, 0.07f), mat);
        for (int i = 0; i < 4; i++)
            Part(root, PrimitiveType.Cube, new Vector3(0f, (i - 1.5f) * 0.045f, 0.017f), Quaternion.identity, new Vector3(0.012f, 0.012f, 0.004f), mat);
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
    }

    internal static void TickFlicker()
    {
        if (Lights.Count == 0) return;
        float time = Time.time;
        float want = ModMain.Settings != null ? ModMain.Settings.LightIntensity : 1.2f;
        for (int i = Lights.Count - 1; i >= 0; i--)
        {
            var (l, seed) = Lights[i];
            if (l == null) { Lights.RemoveAt(i); continue; }
            l.intensity = want * (0.85f + 0.3f * Mathf.PerlinNoise(seed, time * 3f));
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
