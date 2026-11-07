using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;
using Object = UnityEngine.Object;

namespace HutDoorTorch;

// 挂上墙的火把不是真火把:用原版火把的模型、火焰和灯光拼一个摆件,去掉所有脚本,
// 所以不会烧完、不会被风吹灭,离开场景再回来按存档重新摆出来。
internal sealed class WallTorch
{
    internal GameObject Root;
    internal TorchRecord Record;
    internal Light[] Lights;
    internal float[] BaseIntensity;
    internal float Seed;
}

internal static class Torches
{
    internal static readonly List<WallTorch> Placed = new();
    private const float HoldFraction = 0.3f;
    private const float WallGap = 0.09f;

    private static GameObject _ghost;
    private static bool _placing;
    private static int _startFrame;
    private static Vector3 _pos;
    private static Quaternion _rot;
    private static bool _valid;

    internal static bool Placing => _placing;

    internal static void Clear()
    {
        Placed.Clear();
        Cancel(false);
    }

    internal static void ScanScene()
    {
        Placed.RemoveAll(t => t.Root == null);
        string scene = Store.Scene;
        foreach (var rec in Store.Data.torches)
        {
            if (rec.scene != scene) continue;
            bool exists = false;
            foreach (var t in Placed) if (t.Record == rec) { exists = true; break; }
            if (!exists) Spawn(rec);
        }
    }

    private static Quaternion WallRot(Vector3 normal)
    {
        var flat = new Vector3(normal.x, 0f, normal.z);
        if (flat.sqrMagnitude < 1e-4f) flat = Vector3.forward;
        return Quaternion.LookRotation(flat.normalized, Vector3.up);
    }

    // 根物体贴在墙上,z 轴朝外;火把绕 x 轴往外斜
    private static GameObject Build(bool lit)
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
        Vector3 axis;
        if (fxGo != null)
        {
            var fxLocal = copy.transform.InverseTransformPoint(fxGo.transform.position);
            axis = (fxLocal - center).normalized;
        }
        else axis = m2c.MultiplyVector(Vector3.up).normalized;
        if (axis.sqrMagnitude < 0.5f) axis = Vector3.up;
        float half = 0f;
        var ext = b.extents;
        for (int i = 0; i < 8; i++)
        {
            var corner = b.center + Vector3.Scale(ext, new Vector3((i & 1) == 0 ? -1 : 1, (i & 2) == 0 ? -1 : 1, (i & 4) == 0 ? -1 : 1));
            half = Mathf.Max(half, Vector3.Dot(m2c.MultiplyPoint(corner) - center, axis));
        }
        if (half < 0.05f) half = 0.3f;
        Vector3 hold = center - axis * half + axis * (2f * half * HoldFraction);

        float tilt = ModMain.Settings != null ? ModMain.Settings.TiltDegrees : 35f;
        var root = new GameObject("HDT_WallTorch");
        root.SetActive(false);
        var arm = new GameObject("Tilt").transform;
        arm.SetParent(root.transform, false);
        arm.localPosition = new Vector3(0f, 0f, WallGap);
        arm.localRotation = Quaternion.Euler(tilt, 0f, 0f);

        var r = Quaternion.FromToRotation(axis, Vector3.up);
        copy.transform.SetParent(arm, false);
        copy.transform.localRotation = r;
        copy.transform.localPosition = -(r * hold);

        if (fxGo != null)
        {
            fxGo.SetActive(lit);
            if (lit) fxGo.transform.rotation = Quaternion.FromToRotation(arm.up, Vector3.up) * fxGo.transform.rotation;
        }
        var lights = new List<Light>();
        foreach (var l in copy.GetComponentsInChildren<Light>(true))
        {
            bool use = lit && (l == PickLight(lightIn, lightOut) || (lightIn == null && lightOut == null));
            l.enabled = use;
            if (use) l.gameObject.SetActive(true);
            if (!use) continue;
            if (l.range < 1f) l.range = 8f;
            lights.Add(l);
        }

        BuildBracket(root.transform, arm, meshGo);

        var box = root.AddComponent<BoxCollider>();
        box.center = new Vector3(0f, 0.1f, 0.15f);
        box.size = new Vector3(0.25f, 0.6f, 0.3f);
        SetLayer(root, vp_Layer.InteractiveProp);

        Object.Destroy(holder);
        root.name = lit ? "HDT_WallTorch" : "HDT_WallTorchGhost";
        root.SetActive(true);
        foreach (var ps in root.GetComponentsInChildren<ParticleSystem>(true)) { if (lit) ps.Play(true); }
        return root;
    }

    private static Light PickLight(Light indoor, Light outdoor)
    {
        bool outside = false;
        try { outside = GameManager.GetWeatherComponent().IsIndoorEnvironment() == false; } catch { }
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
        // 套住火把的铁箍
        var ring = Part(arm, PrimitiveType.Cylinder, Vector3.zero, Quaternion.identity, new Vector3(0.07f, 0.02f, 0.07f), mat);
        ring.name = "Ring";
        for (int i = 0; i < 4; i++)
        {
            float a = i * 90f;
            Part(root, PrimitiveType.Cube, new Vector3(0f, (i - 1.5f) * 0.045f, 0.017f), Quaternion.Euler(0, 0, a), new Vector3(0.012f, 0.012f, 0.004f), mat).name = "Rivet";
        }
    }

    private static GameObject Part(Transform parent, PrimitiveType type, Vector3 pos, Quaternion rot, Vector3 scale, Material mat)
    {
        var go = GameObject.CreatePrimitive(type);
        var col = go.GetComponent<Collider>();
        if (col != null) Object.DestroyImmediate(col);
        go.transform.SetParent(parent, false);
        go.transform.localPosition = pos;
        go.transform.localRotation = rot;
        go.transform.localScale = scale;
        if (mat != null) go.GetComponent<MeshRenderer>().sharedMaterial = mat;
        return go;
    }

    private static void SetLayer(GameObject go, int layer)
    {
        foreach (var t in go.GetComponentsInChildren<Transform>(true))
            if (t.GetComponent<Light>() == null && t.GetComponent<ParticleSystem>() == null) t.gameObject.layer = layer;
    }

    private static void Spawn(TorchRecord rec)
    {
        var go = Build(true);
        if (go == null) return;
        go.transform.SetPositionAndRotation(rec.Pos, rec.Rot);
        var t = new WallTorch { Root = go, Record = rec, Seed = UnityEngine.Random.value * 100f };
        var ls = go.GetComponentsInChildren<Light>(false);
        var keep = new List<Light>();
        foreach (var l in ls) if (l.enabled) keep.Add(l);
        t.Lights = keep.ToArray();
        t.BaseIntensity = new float[t.Lights.Length];
        float want = ModMain.Settings != null ? ModMain.Settings.LightIntensity : 1.2f;
        for (int i = 0; i < t.Lights.Length; i++)
        {
            if (t.Lights[i].intensity <= 0.01f) t.Lights[i].intensity = 1f;
            t.BaseIntensity[i] = want;
        }
        Placed.Add(t);
    }

    internal static WallTorch FromCollider(Collider c)
    {
        if (c == null) return null;
        foreach (var t in Placed) if (t.Root == c.gameObject) return t;
        return null;
    }

    internal static void Remove(WallTorch t)
    {
        if (t == null) return;
        Store.Data.torches.Remove(t.Record);
        Placed.Remove(t);
        if (t.Root != null) Object.Destroy(t.Root);
        Gear.GiveOne(Gear.Torch);
        HUDMessage.AddMessage("取下了壁挂火把", false, false);
    }

    internal static void BeginPlacing()
    {
        if (_placing) { Cancel(true); return; }
        if (Gear.CountInInventory(Gear.Torch) <= 0) { HUDMessage.AddMessage("背包里没有壁挂火把", false, false); return; }
        _ghost = Build(false);
        if (_ghost == null) return;
        foreach (var c in _ghost.GetComponentsInChildren<Collider>(true)) Object.Destroy(c);
        _ghost.SetActive(false);
        _placing = true;
        _startFrame = Time.frameCount;
        HUDMessage.AddMessage("看着墙面,左键挂上,右键取消", false, false);
    }

    internal static void Cancel(bool msg)
    {
        _placing = false;
        if (_ghost != null) Object.Destroy(_ghost);
        _ghost = null;
        if (msg) HUDMessage.AddMessage("没挂", false, false);
    }

    internal static void TickPlacing(Camera cam)
    {
        if (!_placing) return;
        if (_ghost == null || cam == null) { Cancel(false); return; }
        _valid = false;
        var ray = new Ray(cam.transform.position, cam.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 3f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Ignore)
            && Mathf.Abs(hit.normal.y) < 0.45f)
        {
            _pos = hit.point;
            _rot = WallRot(hit.normal);
            _valid = true;
        }
        _ghost.SetActive(_valid);
        if (_valid) _ghost.transform.SetPositionAndRotation(_pos, _rot);
        if (Time.frameCount <= _startFrame + 1) return;

        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape)) { Cancel(true); return; }
        if (Input.GetMouseButtonDown(0))
        {
            if (!_valid) { HUDMessage.AddMessage("只能挂在竖着的墙面上", false, false); return; }
            if (!Gear.ConsumeOne(Gear.Torch)) { Cancel(false); HUDMessage.AddMessage("背包里没有壁挂火把", false, false); return; }
            var rec = new TorchRecord { scene = Store.Scene, px = _pos.x, py = _pos.y, pz = _pos.z, rx = _rot.x, ry = _rot.y, rz = _rot.z, rw = _rot.w };
            Store.Data.torches.Add(rec);
            Cancel(false);
            Spawn(rec);
            try { GameAudioManager.PlaySound("PLAY_FPH_LIGHTSOURCE_TORCH_IGNITE_SUCCESS", GameManager.GetPlayerObject()); } catch { }
            HUDMessage.AddMessage("壁挂火把挂好了", false, false);
            ModMain.Log.Msg($"挂火把 {rec.scene} {rec.Pos}");
        }
    }

    internal static void TickFlicker()
    {
        float time = Time.time;
        foreach (var t in Placed)
        {
            if (t.Lights == null) continue;
            for (int i = 0; i < t.Lights.Length; i++)
            {
                var l = t.Lights[i];
                if (l == null) continue;
                float n = Mathf.PerlinNoise(t.Seed + i, time * 3f);
                l.intensity = t.BaseIntensity[i] * (0.85f + 0.3f * n);
            }
        }
    }
}
