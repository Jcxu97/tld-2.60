using System;
using System.IO;
using System.Reflection;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using Object = UnityEngine.Object;

namespace HutDoorTorch;

// 门的模型和两张贴图是从带门的钓鱼小屋里抽出来的(STR_FishingCabin_Door、STR_DoorWood_B、GLB_MetalRusted_B_Flat),
// 没门的地区不加载这些资源,所以打进 DLL 里。着色器借小屋墙板自己的材质。
internal static class Res
{
    private static Mesh _doorMesh;
    private static Texture2D _wood, _metal;
    private static Material[] _doorMats;
    private static string _matScene;

    private static byte[] Bytes(string name)
    {
        using var s = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
        if (s == null) throw new FileNotFoundException(name);
        using var ms = new MemoryStream();
        s.CopyTo(ms);
        return ms.ToArray();
    }

    internal static Texture2D Tex(ref Texture2D cache, string name)
    {
        if (cache != null) return cache;
        var t = new Texture2D(2, 2, TextureFormat.RGBA32, true);
        ImageConversion.LoadImage(t, (Il2CppStructArray<byte>)Bytes(name));
        t.name = "HDT_" + name;
        t.hideFlags = HideFlags.DontUnloadUnusedAsset;
        cache = t;
        return t;
    }

    internal static Texture2D Metal => Tex(ref _metal, "GLB_MetalRusted_B_Flat.png");
    internal static Texture2D Wood => Tex(ref _wood, "STR_DoorWood_B.png");

    internal static Mesh DoorMesh()
    {
        if (_doorMesh != null) return _doorMesh;
        try
        {
            using var r = new BinaryReader(new MemoryStream(Bytes("door.mesh")));
            int n = r.ReadInt32();
            var v = new Vector3[n];
            var nm = new Vector3[n];
            var uv = new Vector2[n];
            for (int i = 0; i < n; i++) v[i] = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
            for (int i = 0; i < n; i++) nm[i] = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
            for (int i = 0; i < n; i++) uv[i] = new Vector2(r.ReadSingle(), r.ReadSingle());
            var m = new Mesh { name = "HDT_FishingCabinDoor" };
            m.vertices = v;
            m.normals = nm;
            m.uv = uv;
            int subs = r.ReadInt32();
            m.subMeshCount = subs;
            for (int s = 0; s < subs; s++)
            {
                int c = r.ReadInt32();
                var idx = new int[c];
                for (int i = 0; i < c; i++) idx[i] = r.ReadInt32();
                m.SetTriangles(idx, s);
            }
            m.RecalculateBounds();
            m.RecalculateTangents();
            m.hideFlags = HideFlags.DontUnloadUnusedAsset;
            _doorMesh = m;
        }
        catch (Exception ex) { ModMain.Log.Error("读门模型失败: " + ex); }
        return _doorMesh;
    }

    internal static Material[] DoorMaterials(Transform hut)
    {
        string scene = Store.Scene;
        if (_doorMats != null && _matScene == scene && _doorMats[0] != null) return _doorMats;
        var src = HutMaterial(hut);
        if (src == null) return null;
        _doorMats = new[] { Copy(src, Wood, "HDT_DoorWood"), Copy(src, Metal, "HDT_DoorMetal") };
        _matScene = scene;
        return _doorMats;
    }

    internal static Material Copy(Material src, Texture2D tex, string name)
    {
        var m = new Material(src) { name = name };
        m.mainTexture = tex;
        if (m.HasProperty("_Color")) m.color = Color.white;
        return m;
    }

    private static Material HutMaterial(Transform hut)
    {
        var baseT = hut.Find("STR_FishingCabinBase_Prefab");
        var r = baseT != null ? baseT.GetComponent<MeshRenderer>() : hut.GetComponentInChildren<MeshRenderer>();
        return r != null ? r.sharedMaterial : null;
    }
}
