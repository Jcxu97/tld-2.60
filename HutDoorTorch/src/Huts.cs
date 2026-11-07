using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using UnityEngine;
using Object = UnityEngine.Object;

namespace HutDoorTorch;

// 没门的钓鱼小屋(STRSPAWN_FishingCabin_fresh/salt)和带门的那种用同一个房子模型,
// 门轴和门的位置照带门那种的预制体抄过来(湖区和海岸公路两种都量过,差不到 3 厘米)。
internal sealed class HutDoor
{
    internal Transform Hut;
    internal Transform Hinge;
    internal GameObject DoorGo;
    internal DoorRecord Record;
    internal float Angle;
    internal float Target;

    internal bool IsOpen => Record != null && Record.open;
}

internal static class Huts
{
    private static readonly Vector3 HingeLocal = new(-1.775f, 1.35f, 0.6f);
    private static readonly Vector3 DoorLocal = new(0.02f, 0f, 0.01f);
    private static readonly Quaternion DoorRot = Quaternion.Euler(0f, -90f, 0f);
    private static readonly Vector3 BoxCenter = new(-0.59f, 0f, 0.02f);
    private static readonly Vector3 BoxSize = new(1.16f, 2.03f, 0.21f);
    // 屋里的范围,抄的是小屋自带的 ParticleKiller(挡落雪那块)
    private static readonly Vector3 InsideCenter = new(-0.08f, 2.59f, 0.02f);
    private static readonly Quaternion InsideRot = Quaternion.Euler(0f, -90f, 0f);
    private static readonly Vector3 InsideSize = new(5.14f, 4.58f, 5.3f);
    private const float OpenAngle = 100f;

    internal static readonly List<Transform> Doorless = new();
    internal static int DoorlessCount => Doorless.Count;
    internal static readonly List<HutDoor> Doors = new();

    internal static bool IsDoorlessHut(string n) =>
        n != null && n.StartsWith("STRSPAWN_FishingCabin_", StringComparison.Ordinal);

    internal static void Clear()
    {
        Doorless.Clear();
        Doors.Clear();
    }

    private static int _lastCount = -1;
    private static string _lastScene;

    internal static void ScanScene()
    {
        Doorless.Clear();
        int named = 0;
        Doors.RemoveAll(d => d.Hut == null || d.DoorGo == null);
        try
        {
            foreach (var md in Object.FindObjectsOfType<MapDetail>())
            {
                if (md == null) continue;
                var t = md.transform;
                if (!IsDoorlessHut(t.name)) continue;
                named++;
                if (!t.gameObject.activeInHierarchy || t.Find("Hinge") != null) continue;
                Doorless.Add(t);
            }
        }
        catch (Exception ex) { ModMain.Log.Error("找钓鱼小屋失败: " + ex); }

        string scene = Store.Scene;
        foreach (var rec in Store.Data.doors)
        {
            if (rec.scene != scene) continue;
            var hut = FindHut(rec.x, rec.z);
            if (hut == null) { ModMain.Log.Warning($"存档里的门对不上小屋 {rec.scene} ({rec.x:F1},{rec.z:F1})"); continue; }
            if (DoorOn(hut) != null) continue;
            Build(hut, rec);
        }
        if (Doorless.Count != _lastCount || scene != _lastScene)
            ModMain.Log.Msg($"{scene}:钓鱼小屋 {named} 间,其中没门又已激活的 {Doorless.Count} 间,装了门的 {Doors.Count} 间");
        _lastCount = Doorless.Count;
        _lastScene = scene;
    }

    private static Transform FindHut(float x, float z)
    {
        foreach (var t in Doorless)
        {
            var p = t.position;
            if (Mathf.Abs(p.x - x) < 0.5f && Mathf.Abs(p.z - z) < 0.5f) return t;
        }
        return null;
    }

    internal static HutDoor DoorOn(Transform hut)
    {
        foreach (var d in Doors) if (d.Hut == hut) return d;
        return null;
    }

    internal static Vector3 DoorwayWorld(Transform hut) =>
        hut.TransformPoint(HingeLocal + DoorRot * (DoorLocal + BoxCenter));

#if HDT_TEST
    internal static void TeleportToNearest()
    {
        var pm = GameManager.GetPlayerManagerComponent();
        var me = GameManager.GetPlayerTransform().position;
        Transform best = null;
        foreach (var h in Doorless) if (h != null && (best == null || (h.position - me).sqrMagnitude < (best.position - me).sqrMagnitude)) best = h;
        foreach (var d in Doors) if (d?.Hinge != null && best == null) best = d.Hinge.parent;
        if (best == null) { ModMain.Log.Msg("测试:附近没有小屋"); return; }
        var door = DoorwayWorld(best);
        var out_ = door - best.TransformPoint(InsideCenter); out_.y = 0f; out_.Normalize();
        var pos = door + out_ * 2.2f; pos.y = best.position.y + 0.1f;
        var look = -out_;
        pm.TeleportPlayer(pos, Quaternion.LookRotation(look));
        ModMain.Log.Msg($"测试:传到 {best.name} 门外 {pos}");
    }
#endif

    // 正对着哪间小屋的空门框
    internal static Transform DoorwayInView(Camera cam, float maxDist)
    {
        if (cam == null) return null;
        Transform best = null;
        float bestAngle = 25f;
        foreach (var hut in Doorless)
        {
            if (hut == null || DoorOn(hut) != null) continue;
            var to = DoorwayWorld(hut) - cam.transform.position;
            if (to.magnitude > maxDist) continue;
            float a = Vector3.Angle(cam.transform.forward, to);
            if (a < bestAngle) { bestAngle = a; best = hut; }
        }
        return best;
    }

    internal static void Install(Transform hut)
    {
        if (hut == null || DoorOn(hut) != null) return;
        if (!Gear.ConsumeOne(Gear.Door)) { HUDMessage.AddMessage("背包里没有钓鱼小屋门", false, false); return; }
        var p = hut.position;
        var rec = new DoorRecord { scene = Store.Scene, x = p.x, z = p.z, open = false };
        Store.Data.doors.Add(rec);
        Build(hut, rec);
        Sound("PLAY_SNDMECHDOORWOODCLOSE1");
        HUDMessage.AddMessage("钓鱼小屋门装好了", false, false);
        ModMain.Log.Msg($"装门 {rec.scene} ({rec.x:F1},{rec.z:F1})");
    }

    internal static void Remove(HutDoor d)
    {
        if (d == null) return;
        Store.Data.doors.Remove(d.Record);
        Doors.Remove(d);
        if (d.Hinge != null) Object.Destroy(d.Hinge.gameObject);
        Gear.GiveOne(Gear.Door);
        HUDMessage.AddMessage("拆下了钓鱼小屋门", false, false);
    }

    internal static void Toggle(HutDoor d)
    {
        if (d?.Record == null) return;
        d.Record.open = !d.Record.open;
        d.Target = d.Record.open ? Sign() * OpenAngle : 0f;
        Sound(d.Record.open ? "PLAY_SNDMECHDOORWOODOPEN1" : "PLAY_SNDMECHDOORWOODCLOSE1");
    }

    private static float Sign() => ModMain.Settings != null && ModMain.Settings.DoorOpensInward ? -1f : 1f;

    private static void Build(Transform hut, DoorRecord rec)
    {
        var mesh = Res.DoorMesh();
        var mats = Res.DoorMaterials(hut);
        if (mesh == null || mats == null) { ModMain.Log.Error("门的模型没准备好"); return; }

        var hinge = new GameObject("HDT_Hinge").transform;
        hinge.SetParent(hut, false);
        hinge.localPosition = HingeLocal;
        hinge.localRotation = Quaternion.identity;

        var door = new GameObject("HDT_HutDoor");
        door.layer = vp_Layer.InteractiveProp;
        door.transform.SetParent(hinge, false);
        door.transform.localPosition = DoorLocal;
        door.transform.localRotation = DoorRot;
        door.AddComponent<MeshFilter>().sharedMesh = mesh;
        door.AddComponent<MeshRenderer>().sharedMaterials = mats;
        var box = door.AddComponent<BoxCollider>();
        box.center = BoxCenter;
        box.size = BoxSize;

        var d = new HutDoor { Hut = hut, Hinge = hinge, DoorGo = door, Record = rec };
        d.Target = d.Angle = rec.open ? Sign() * OpenAngle : 0f;
        hinge.localRotation = Quaternion.Euler(0f, d.Angle, 0f);
        Doors.Add(d);
    }

    internal static void Tick(float dt)
    {
        foreach (var d in Doors)
        {
            if (d.Hinge == null || Mathf.Approximately(d.Angle, d.Target)) continue;
            d.Angle = Mathf.MoveTowards(d.Angle, d.Target, 180f * dt);
            d.Hinge.localRotation = Quaternion.Euler(0f, d.Angle, 0f);
        }
    }

    internal static HutDoor DoorFromCollider(Collider c)
    {
        if (c == null) return null;
        foreach (var d in Doors) if (d.DoorGo == c.gameObject) return d;
        return null;
    }

    // 关着门的小屋里面算不进风
    internal static bool InsideClosedHut(Vector3 pos)
    {
        if (ModMain.Settings != null && !ModMain.Settings.DoorBlocksWind) return false;
        foreach (var d in Doors)
        {
            if (d.Hut == null || d.IsOpen || !Mathf.Approximately(d.Angle, 0f)) continue;
            var local = Quaternion.Inverse(InsideRot) * (d.Hut.InverseTransformPoint(pos) - InsideCenter);
            if (Mathf.Abs(local.x) <= InsideSize.x * 0.5f && Mathf.Abs(local.y) <= InsideSize.y * 0.5f && Mathf.Abs(local.z) <= InsideSize.z * 0.5f)
                return true;
        }
        return false;
    }

    private static void Sound(string ev)
    {
        try { GameAudioManager.PlaySound(ev, GameManager.GetPlayerObject()); } catch { }
    }
}

[HarmonyPatch(typeof(Wind), nameof(Wind.PointInsideWindKiller))]
internal static class Patch_PointInsideWindKiller
{
    private static void Postfix(Vector3 pos, ref bool __result) { if (!__result && Huts.InsideClosedHut(pos)) __result = true; }
}

[HarmonyPatch(typeof(Wind), nameof(Wind.IsPositionOccludedFromWind))]
internal static class Patch_IsPositionOccludedFromWind
{
    private static void Postfix(Vector3 pos, ref bool __result) { if (!__result && Huts.InsideClosedHut(pos)) __result = true; }
}

[HarmonyPatch(typeof(Wind), nameof(Wind.PlayerShelteredFromWind))]
internal static class Patch_PlayerShelteredFromWind
{
    private static void Postfix(ref bool __result)
    {
        if (__result) return;
        try
        {
            var p = GameManager.GetPlayerTransform();
            if (p != null && Huts.InsideClosedHut(p.position + Vector3.up)) __result = true;
        }
        catch { }
    }
}
