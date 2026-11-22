using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace MoreBunkers;

internal sealed class Level
{
    public readonly float Top, X0, X1, Z0, Z1, Clear;
    public Level(float top, float x0, float x1, float z0, float z1, float clear) { Top = top; X0 = x0; X1 = x1; Z0 = z0; Z1 = z1; Clear = clear; }
}

internal sealed class Furn
{
    public readonly string Path;
    public readonly float W, D, Cx, Cz, H, RootY;
    public readonly float Yaw0;
    public readonly Level[] Levels;
    public Furn(string path, float w, float d, float cx, float cz, float h, float rootY, float yaw0, Level[] levels)
    { Path = path; W = w; D = d; Cx = cx; Cz = cz; H = h; RootY = rootY; Yaw0 = yaw0; Levels = levels; }
}

internal readonly struct G
{
    public readonly string Gear;
    public readonly int Min, Max, Pile;
    public G(string gear, int min, int max, int pile = 1) { Gear = gear; Min = min; Max = max; Pile = pile; }
}

internal sealed class Layout
{
    public readonly string Interior;
    public readonly Piece[] Pieces;
    public Layout(string interior, Piece[] pieces) { Interior = interior; Pieces = pieces; }
}

internal sealed class Piece
{
    public string F, Station;
    public float X, Z, Face, Mount, LineDir, LineGap;
    // 负数表示叠在前面第几件上面
    public int On;
    // 不贴墙:就放在设计位置,落到下面的桌面或地面上(椅子、地毯、桌上的小摆件)
    public bool Free;
    public string[] Rack, Items;
    public G[][] Levels;
    public G[] Theme;
}

// 布置数据在 Layouts.g.cs(由 design/design.py 生成);这里是摆放用的工具
internal static partial class Layouts
{
    // 设计图上的入口点。实际场景若有偏移,整体平移
    internal static readonly Dictionary<string, Vector3> DesignEnter = new()
    {
        ["PrepperCacheAEmpty"] = new Vector3(1.86f, 0f, 0f),
        ["PrepperCacheBEmpty"] = new Vector3(-6.17f, 0.3f, 0f),
        ["PrepperCacheCEmpty"] = new Vector3(1.17f, 0.38f, -8.04f),
    };

    // 原版留下的杂物、旧货架和随机刷物点,进来就藏掉,地上保持干净
    private static readonly string[] Junk =
    {
        "OBJ_FlatCardboard", "OBJ_BoxCardboard", "OBJ_PaperDebris", "OBJ_DishPlate", "OBJ_DishBowl", "OBJ_PrepperCacheBrick",
        "OBJ_BoxCrate", "BoxCrate", "Obj_Crates", "OBJ_PlasticBarrel", "OBJ_MilkCrate", "OBJ_MetalShelf", "OBJ_LargeShelf",
        "OBJ_WoodShelf", "OBJ_StoreShelfHook", "OBJ_MetalBucket", "OBJ_CoatRack", "OBJ_WoodSpatula", "OBJ_BackPack",
        "OBJ_MetalContainerLid", "OBJ_PlasticContainerLid", "OBJ_MedkitBLid", "Decal-", "SpawnPrefab_", "RandomSpawnObject",
    };

    internal static bool IsJunk(string n)
    {
        if (string.IsNullOrEmpty(n)) return false;
        foreach (var j in Junk) if (n.StartsWith(j, StringComparison.Ordinal)) return true;
        return false;
    }

    internal static Quaternion RotOf(Piece p, Furn f) => Quaternion.Euler(0f, p.Face + (f == null ? 0f : f.Yaw0), 0f);
    internal static Vector3 FaceDir(float face) => Quaternion.Euler(0f, face, 0f) * Vector3.forward;

    // 打到的东西算不算房间本身:自己摆的、物品、玩家都不算
    internal static bool IsRoom(Collider c, Transform ours)
    {
        if (c == null || c.isTrigger) return false;
        var t = c.transform;
        if (ours != null && t.IsChildOf(ours)) return false;
        if (c.GetComponentInParent<GearItem>() != null) return false;
        var p = GameManager.GetPlayerTransform();
        if (p != null && t.IsChildOf(p)) return false;
        return true;
    }

    internal static bool Ray(Vector3 from, Vector3 dir, float max, Transform ours, bool roomOnly, out RaycastHit best)
    {
        best = default;
        var hits = Physics.RaycastAll(from, dir, max, ~0, QueryTriggerInteraction.Ignore);
        float bd = float.MaxValue;
        bool any = false;
        for (int i = 0; hits != null && i < hits.Count; i++)
        {
            var h = hits[i];
            if (h.collider == null || h.collider.isTrigger) continue;
            if (roomOnly ? !IsRoom(h.collider, ours) : (h.collider.GetComponentInParent<GearItem>() != null)) continue;
            if (h.distance < bd) { bd = h.distance; best = h; any = true; }
        }
        return any;
    }

    // 地板高度:从上往下打,跳过自己摆的东西
    internal static float FloorAt(float x, float z, float refY, Transform ours)
    {
        // 从齐腰高往下打:再高会打到墙上的电闸箱顶面
        var from = new Vector3(x, refY + 0.9f, z);
        var hits = Physics.RaycastAll(from, Vector3.down, 3f, ~0, QueryTriggerInteraction.Ignore);
        float best = float.MaxValue, y = refY;
        for (int i = 0; hits != null && i < hits.Count; i++)
        {
            var h = hits[i];
            if (!IsRoom(h.collider, ours) || h.normal.y < 0.7f) continue;
            if (h.distance < best) { best = h.distance; y = h.point.y; }
        }
        return y;
    }

    // 占地中心到身后墙面的最近距离,在几种高度和左右两端各打一条
    internal static float WallDist(Vector3 center, float floor, Quaternion rot, float w, float h, float y0, Vector3 back, Transform ours)
    {
        float best = float.MaxValue;
        var side = rot * Vector3.right;
        float[] ys = { y0 + 0.12f, y0 + Mathf.Min(0.6f, h * 0.5f), y0 + Mathf.Min(1.0f, h - 0.1f), y0 + Mathf.Max(0.1f, h - 0.15f) };
        float[] xs = { -w * 0.5f + 0.08f, 0f, w * 0.5f - 0.08f };
        foreach (float yy in ys)
            foreach (float xx in xs)
            {
                var from = new Vector3(center.x, floor + yy, center.z) + side * xx;
                if (Ray(from, back, 3f, ours, true, out var hit) && hit.distance < best) best = hit.distance;
            }
        return best;
    }

    internal static bool Blocked(Vector3 center, float floor, Quaternion rot, float w, float d, float h, float y0, Transform ours, Transform self)
    {
        var half = new Vector3(Mathf.Max(0.05f, w * 0.5f - 0.03f), Mathf.Max(0.05f, h * 0.5f - 0.06f), Mathf.Max(0.05f, d * 0.5f - 0.03f));
        var c = new Vector3(center.x, floor + y0 + h * 0.5f + 0.03f, center.z);
        var hits = Physics.OverlapBox(c, half, rot, ~0, QueryTriggerInteraction.Ignore);
        for (int i = 0; hits != null && i < hits.Count; i++)
        {
            var x = hits[i];
            if (x == null || x.isTrigger) continue;
            if (self != null && x.transform.IsChildOf(self)) continue;
            if (x.GetComponentInParent<GearItem>() != null) continue;
            var p = GameManager.GetPlayerTransform();
            if (p != null && x.transform.IsChildOf(p)) continue;
            return true;
        }
        return false;
    }

    // 物品自己的占地框(局部坐标),只算启用的实体碰撞;没有就用网格
    private static readonly Dictionary<string, Bounds> _itemBox = new();

    internal static Bounds ItemBox(GearItem pf)
    {
        string key = pf.name;
        if (_itemBox.TryGetValue(key, out var cached)) return cached;
        var root = pf.transform;
        var inv = root.worldToLocalMatrix;
        bool any = false;
        var b = new Bounds();
        void Add(Matrix4x4 m, Bounds lb)
        {
            var e = lb.extents;
            for (int i = 0; i < 8; i++)
            {
                var p = m.MultiplyPoint3x4(lb.center + new Vector3((i & 1) == 0 ? -e.x : e.x, (i & 2) == 0 ? -e.y : e.y, (i & 4) == 0 ? -e.z : e.z));
                if (!any) { b = new Bounds(p, Vector3.zero); any = true; } else b.Encapsulate(p);
            }
        }
        // 先用模型大小:拾取用的碰撞框往往比模型大一圈,按它摆会悬空。查看物品时才显示的模型不算
        foreach (var mf in pf.GetComponentsInChildren<MeshFilter>(true))
            if (mf != null && mf.sharedMesh != null && Shown(mf.transform, root)) Add(inv * mf.transform.localToWorldMatrix, mf.sharedMesh.bounds);
        foreach (var sr in pf.GetComponentsInChildren<SkinnedMeshRenderer>(true))
            if (sr != null && sr.sharedMesh != null && Shown(sr.transform, root)) Add(inv * sr.transform.localToWorldMatrix, sr.sharedMesh.bounds);
        if (!any)
        {
            foreach (var c in pf.GetComponentsInChildren<Collider>(true))
            {
                if (c == null || c.isTrigger || !ActiveChain(c.transform, root)) continue;
                var m = inv * c.transform.localToWorldMatrix;
                var bc = c.TryCast<BoxCollider>();
                if (bc != null) { Add(m, new Bounds(bc.center, bc.size)); continue; }
                var mc = c.TryCast<MeshCollider>();
                if (mc != null && mc.sharedMesh != null) { Add(m, mc.sharedMesh.bounds); continue; }
                var cc = c.TryCast<CapsuleCollider>();
                if (cc != null)
                {
                    var s = new Vector3(cc.radius * 2f, cc.radius * 2f, cc.radius * 2f);
                    if (cc.direction == 0) s.x = cc.height; else if (cc.direction == 1) s.y = cc.height; else s.z = cc.height;
                    Add(m, new Bounds(cc.center, s));
                    continue;
                }
                var sc = c.TryCast<SphereCollider>();
                if (sc != null) Add(m, new Bounds(sc.center, Vector3.one * sc.radius * 2f));
            }
        }
        if (!any) b = new Bounds(new Vector3(0f, 0.08f, 0f), new Vector3(0.2f, 0.16f, 0.2f));
        _itemBox[key] = b;
        return b;
    }

    private static bool Shown(Transform t, Transform root)
    {
        if (!ActiveChain(t, root)) return false;
        for (var x = t; x != null && x != root; x = x.parent) if (x.name.Contains("Inspect")) return false;
        return true;
    }

    private static bool ActiveChain(Transform t, Transform root)
    {
        for (var x = t; x != null; x = x.parent)
        {
            if (!x.gameObject.activeSelf) return false;
            if (x == root) break;
        }
        return true;
    }

    // 家具摆法改了就换一个签名,整个重摆。只看摆件和位置,不看里面放什么、放多少:
    // 调数量不该让老存档重摆(重摆会清掉架上的东西),新数量只对新档生效
    internal static string Sig(Layout L)
    {
        var sb = new System.Text.StringBuilder("v2|").Append(L.Interior);
        foreach (var p in L.Pieces)
        {
            // 椅子、地毯这类不放东西的摆件每次进来都按设计位置重新落,挪它们不用整个重摆
            if (p.Free && p.Levels == null && p.Theme == null) { sb.Append('|').Append(p.F); continue; }
            sb.Append('|').Append(p.F).Append(p.Free).Append(p.X).Append(',').Append(p.Z).Append(',').Append(p.Face).Append(',').Append(p.Mount).Append(',').Append(p.On);
            // 家具尺寸和转角改了也要重摆,不然旧存档里记下的位置和朝向一直不变
            if (p.F != null && Furniture.TryGetValue(p.F, out var f))
                sb.Append('~').Append(f.W).Append(',').Append(f.D).Append(',').Append(f.Cx).Append(',').Append(f.Cz).Append(',').Append(f.RootY).Append(',').Append(f.Yaw0);
            if (p.Theme != null) sb.Append('T');
            if (p.Levels != null) sb.Append('L').Append(p.Levels.Length);
        }
        return Stations.MakeGuid(sb.ToString()).Substring(0, 8);
    }

    internal static int Roll(System.Random r, G g) => g.Max <= g.Min ? g.Min : r.Next(g.Min, g.Max + 1);
}
