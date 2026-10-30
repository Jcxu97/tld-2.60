using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace MoreBunkers;

internal sealed class Spot
{
    public string Region, RegionZh, AnchorZh;
    public Vector3 Anchor;
    // 舱口就放在这个点上,不在附近找平地
    public bool Exact;
    public Spot(string region, string regionZh, string anchorZh, float x, float y, float z)
    { Region = region; RegionZh = regionZh; AnchorZh = anchorZh; Anchor = new Vector3(x, y, z); }
}

internal sealed class BunkerDef
{
    public string Id, NameZh, Interior, Guid;
    public Spot[] Spots;
}

internal static class Bunkers
{
    // 参考地点和名字照 TldHacks 传送点,到了传送点附近就能找到舱口。借原版的空地堡当毛坯房,进去后按 Layouts 自己布置。入口是"可共用"的,存档按 场景名_入口编号 单独存,和原版地堡互不影响
    internal static readonly BunkerDef[] All =
    {
        new BunkerDef
        {
            Id = "craft", NameZh = "工匠地堡", Interior = "PrepperCacheCEmpty", Guid = "6d1f3c52-9a4e-4b7a-8c11-4f0e2a7b9d01",
            Spots = new[]
            {
                new Spot("LakeRegion", "神秘湖", "", 721.17f, 91.97f, 489.79f) { Exact = true },
            },
        },
        new BunkerDef
        {
            Id = "merc", NameZh = "雇佣兵地堡", Interior = "PrepperCacheAEmpty", Guid = "a83e5b17-2c6d-4e90-b5f2-7d14c9e0a302",
            Spots = new[]
            {
                new Spot("AirfieldRegion", "废弃机场", "", 74.84f, 181.72f, -818.52f) { Exact = true },
            },
        },
        new BunkerDef
        {
            Id = "stock", NameZh = "囤货地堡", Interior = "PrepperCacheBEmpty", Guid = "f2b9047e-5d38-4a1c-9e6b-3c8a1d5f7e03",
            Spots = new[]
            {
                new Spot("CoastalRegion", "沿海公路", "", 443.64f, 50.24f, -571.02f) { Exact = true },
            },
        },
    };

    private const string HatchPrefab = "Assets/ArtAssets/Env/Objects/OBJ_HatchExteriorDamaged/OBJ_HatchExteriorDamaged_Prefab.prefab";
    // 地堡里出口门指向的出生点名字(原版地堡出口用的就是它)
    internal const string HatchExit = "HatchRandomSelect_ExitPoint";
    // 我们舱口旁边的出生点。和原版的不同名,免得从原版地堡出来被游戏放到我们门口
    private const string ExitPointName = "MoreBunkers_ExitPoint";

    private static readonly Dictionary<string, GameObject> _roots = new();

    // 进了哪个新地堡。出地堡时用来把出口改回它所在的图
    internal static BunkerDef Inside;

    internal static bool Active()
    {
        var s = ModMain.Settings;
        if (s == null || !s.Enabled) return false;
        try { if (GameManager.IsStoryMode()) return false; } catch { }
        if (!s.OnHardModes)
        {
            try
            {
                var t = ExperienceModeManager.GetCurrentExperienceModeType();
                if (t == ExperienceModeType.Interloper || t == ExperienceModeType.Misery) return false;
            }
            catch { }
        }
        return true;
    }

    internal static Spot SpotOf(BunkerDef b)
    {
        var map = SaveData.Current.region;
        if (!map.TryGetValue(b.Id, out int i) || i < 0 || i >= b.Spots.Length)
        {
            i = new System.Random().Next(b.Spots.Length);
            map[b.Id] = i;
            SaveData.Save();
            ModMain.Log?.Msg($"[MoreBunkers] {b.Id} -> {b.Spots[i].Region}");
        }
        return b.Spots[i];
    }

    // 按内部存档名找是哪个新地堡:名字里带我们的编号,或者之前记下过这个存档名
    internal static BunkerDef ByGuid(string s)
    {
        if (string.IsNullOrEmpty(s)) return null;
        foreach (var b in All) if (s.Contains(b.Guid)) return b;
        foreach (var b in All)
            if (SaveData.Current.interior.TryGetValue(b.Id, out var name) && name == s) return b;
        return null;
    }

    internal static BunkerDef ByDoor(LoadScene door)
    {
        if (door == null) return null;
        var b = ByGuid(door.m_GUID);
        if (b != null) return b;
        var root = door.transform.parent;
        if (root == null || !root.name.StartsWith("MoreBunkers_")) return null;
        string id = root.name.Substring("MoreBunkers_".Length);
        foreach (var x in All) if (x.Id == id) return x;
        return null;
    }

    // 刚从新地堡的舱口进去,下一个地堡场景就是它。只在进门后一分钟内有效,游戏拒绝进门时不会留到下次
    internal static BunkerDef JustEntered;
    internal static float JustEnteredAt;
    // 走我们舱口出去的时间;到户外时出生点名字已被游戏清空,TldHacks 传送反倒带着舱口名字,只能靠这个分
    internal static float LeftAt = -1f;

    internal static BunkerDef Entered(string scene)
    {
        var b = JustEntered;
        if (b == null || b.Interior != scene || Time.realtimeSinceStartup - JustEnteredAt > 60f) return null;
        return b;
    }

    internal static void Forget() { _roots.Clear(); Inside = null; JustEntered = null; LeftAt = -1f; }

    // 关掉开关时把这张图上的舱口拿掉
    internal static void RemoveAll()
    {
        foreach (var r in _roots.Values) if (r != null) UnityEngine.Object.Destroy(r);
        _roots.Clear();
    }

    // 户外场景加载完调一次:这张图上该有的新地堡都摆出来
    internal static void OnRegionLoaded(string scene)
    {
        if (!Active()) return;
        foreach (var b in All)
        {
            var spot = SpotOf(b);
            if (spot.Region != scene) continue;
            if (_roots.TryGetValue(b.Id, out var old) && old != null) continue;
            var root = Build(b, spot);
            if (root != null) _roots[b.Id] = root;
        }
    }

    // 刚从新地堡出来:游戏可能把人放在原版地堡的出口或者出生点,这里挪到新地堡门口。
    // 场景加载慢时游戏会晚一点才放人,所以挪两次,最后一次才算出来了
    internal static void FixExit(string scene, bool last)
    {
        var b = Inside;
        if (b == null) return;
        if (SpotOf(b).Region != scene) { Inside = null; return; }
        if (last) Inside = null;
        if (!_roots.TryGetValue(b.Id, out var root) || root == null) return;
        var exit = root.transform.Find(ExitPointName);
        var pos = exit != null ? exit.position : root.transform.position + root.transform.right * 1.5f + Vector3.up * 0.3f;
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            var p = GameManager.GetPlayerTransform();
            if (pm != null && p != null && (p.position - pos).sqrMagnitude > 4f)
            {
                pm.TeleportPlayer(pos, exit != null ? exit.rotation : p.rotation);
                ModMain.Log?.Msg($"[MoreBunkers] moved to {b.Id} exit {pos}");
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] fix exit {ex.Message}"); }
    }

    private static GameObject Build(BunkerDef b, Spot spot)
    {
        try
        {
            FindSpot(b, spot, out var pos, out float yaw);
            var root = new GameObject("MoreBunkers_" + b.Id);
            root.transform.position = pos;
            root.transform.rotation = Quaternion.Euler(0f, yaw, 0f);

            try
            {
                var prefab = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)HatchPrefab).WaitForCompletion();
                if (prefab != null)
                {
                    var vis = UnityEngine.Object.Instantiate(prefab, root.transform);
                    vis.transform.localPosition = Vector3.zero;
                    vis.transform.localRotation = Quaternion.identity;
                    // 模型自带的交互会多出一个能点的入口,只留外观和碰撞;碰撞放到原版舱口用的场景层,准星不会停在上面
                    var stripped = new List<string>();
                    foreach (var m in vis.GetComponentsInChildren<MonoBehaviour>(true))
                        if (m != null) { stripped.Add(m.GetIl2CppType().Name); UnityEngine.Object.DestroyImmediate(m); }
                    foreach (var c in vis.GetComponentsInChildren<Collider>(true))
                        if (c != null) { if (c.isTrigger) UnityEngine.Object.DestroyImmediate(c); else c.gameObject.layer = 11; }
                    if (stripped.Count > 0) ModMain.Log?.Msg($"[MoreBunkers] hatch model parts removed: {string.Join(",", stripped)}");
                }
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] hatch model {ex.Message}"); }

            if (!MakeTrigger(b, root)) { UnityEngine.Object.Destroy(root); return null; }

            var exit = new GameObject(ExitPointName);
            exit.transform.SetParent(root.transform, false);
            exit.transform.localPosition = new Vector3(1.5f, 0.3f, 0f);
            exit.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);

            ModMain.Log?.Msg($"[MoreBunkers] {b.Id} placed in {spot.Region} at {pos} yaw {yaw:F0}");
            return root;
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] build {b.Id} {ex.Message}"); return null; }
    }

    // 复制场景里一扇现成的门,拿到完整的 LoadScene 设置,再改成通往新地堡
    private static bool MakeTrigger(BunkerDef b, GameObject root)
    {
        LoadScene src = null;
        var all = UnityEngine.Object.FindObjectsOfType<LoadScene>();
        for (int i = 0; all != null && i < all.Count && src == null; i++)
            if (all[i] != null && !string.IsNullOrEmpty(all[i].m_SceneToLoad) && all[i].GetComponent<BoxCollider>() != null) src = all[i];
        for (int i = 0; all != null && i < all.Count && src == null; i++)
            if (all[i] != null && !string.IsNullOrEmpty(all[i].m_SceneToLoad)) src = all[i];

        GameObject go;
        if (src != null)
        {
            bool was = src.gameObject.activeSelf;
            src.gameObject.SetActive(false);
            go = UnityEngine.Object.Instantiate(src.gameObject);
            src.gameObject.SetActive(was);
        }
        else
        {
            // 这张图找不到门可复制,只能现搭一扇
            ModMain.Log?.Warning("[MoreBunkers] no door to copy in this scene, building a new one");
            go = new GameObject("InteriorLoadTrigger");
            go.SetActive(false);
            go.AddComponent<LoadScene>();
        }
        foreach (var c in go.GetComponents<Collider>())
            if (c != null && c.TryCast<BoxCollider>() == null) UnityEngine.Object.DestroyImmediate(c);
        if (go.GetComponent<BoxCollider>() == null) go.AddComponent<BoxCollider>();

        go.name = "InteriorLoadTrigger";
        foreach (var c in go.GetComponents<MonoBehaviour>())
        {
            var n = c.GetIl2CppType().Name;
            if (n != "LoadScene" && n != "ObjectGuid") UnityEngine.Object.DestroyImmediate(c);
        }
        for (int i = go.transform.childCount - 1; i >= 0; i--) UnityEngine.Object.DestroyImmediate(go.transform.GetChild(i).gameObject);
        // 被复制的门可能自己就带门板模型,去掉,外观只用舱口模型
        foreach (var c in go.GetComponents<LODGroup>()) UnityEngine.Object.DestroyImmediate(c);
        foreach (var c in go.GetComponents<MeshRenderer>()) UnityEngine.Object.DestroyImmediate(c);
        foreach (var c in go.GetComponents<MeshFilter>()) UnityEngine.Object.DestroyImmediate(c);

        go.layer = 21;
        go.transform.SetParent(root.transform, false);
        go.transform.localPosition = new Vector3(0f, 1.28f, 0f);
        go.transform.localRotation = Quaternion.identity;
        go.transform.localScale = new Vector3(1.98f, 1.77f, 1.86f);
        var box = go.GetComponent<BoxCollider>();
        box.isTrigger = true;
        box.size = Vector3.one;
        box.center = Vector3.zero;

        var ls = go.GetComponent<LoadScene>();
        ls.m_SceneToLoad = b.Interior;
        ls.m_ExitPointName = "PrepperCacheEnterPoint";
        ls.m_SceneCanBeInstanced = true;
        ls.m_SoundDuringFadeOut = "Play_MetalHatchDoorOpen1";
        ls.m_SoundDuringFadeIn = "Play_SndActionLadderDown2";
        ls.m_LocalizedTransitionType = new LocalizedString { m_LocalizationID = "GAMEPLAY_Hatch" };
        ls.m_ParentGO = null;
        ls.m_LoadSceneParent = null;
        ls.m_AnimatedInteraction = null;
        ls.m_AnimatedObjectAnimator = null;
        ls.m_AnimatedObjectTrackName = "";
        ls.m_SceneLocationLocIDToShow = "";
        ls.m_DisableInChallengeMode = false;
        ls.m_TransitionOnContact = false;
        ls.m_Active = true;
        ls.m_GUID = b.Guid;
        ForceGuid(go, b.Guid);
        go.SetActive(true);
        // 复制来的门带着原门的编号,激活时游戏会因为重复换成随机编号;激活后再写一遍
        ls.m_GUID = b.Guid;
        ForceGuid(go, b.Guid);
        string got = "";
        try { got = ls.GetGUID(); } catch { }
        ModMain.Log?.Msg($"[MoreBunkers] {b.Id} door id {got}");
        return true;
    }

    // 门的编号决定地堡内部的存档名。游戏在门激活后有时会把编号换成随机的,每次进门前写回来,内部存档才一直是同一份
    internal static void KeepGuid(LoadScene door, BunkerDef b)
    {
        string was = "";
        try { was = door.GetGUID(); } catch { }
        door.m_GUID = b.Guid;
        ForceGuid(door.gameObject, b.Guid);
        if (was != b.Guid) ModMain.Log?.Msg($"[MoreBunkers] {b.Id} door id was {was}, set back to {b.Guid}");
    }

    private static void ForceGuid(GameObject go, string guid)
    {
        try
        {
            var og = go.GetComponent<ObjectGuid>() ?? go.AddComponent<ObjectGuid>();
            og.SetRuntimeCachedPdid(guid);
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[MoreBunkers] door id {ex.Message}"); }
    }

    // 在参考地点周围一圈圈找平地,找不到就一级级放宽;最后一级直接放在传送点脚下,保证一定有
    private static bool FindSpot(BunkerDef b, Spot spot, out Vector3 pos, out float yaw)
    {
        if (SaveData.Current.pos.TryGetValue(b.Id, out var saved) && saved != null && saved.Length == 4
            && (!spot.Exact || (new Vector3(saved[0], saved[1], saved[2]) - spot.Anchor).sqrMagnitude < 5f * 5f))
        {
            pos = new Vector3(saved[0], saved[1], saved[2]);
            yaw = saved[3];
            return true;
        }
        if (spot.Exact)
        {
            yaw = 0f;
            pos = Physics.Raycast(spot.Anchor + Vector3.up * 1f, Vector3.down, out var eh, 6f, ~0, QueryTriggerInteraction.Ignore) ? eh.point : spot.Anchor;
            SaveData.Current.pos[b.Id] = new[] { pos.x, pos.y, pos.z, yaw };
            SaveData.Save();
            ModMain.Log?.Msg($"[MoreBunkers] {b.Id} placed at the fixed spot {pos}");
            return true;
        }
        int start = (int)(Fnv(b.Id) % 18);
        bool ok = Search(spot, start, new[] { 12f, 16f, 20f, 25f, 30f, 38f }, true, 0.94f, 8f, 1.6f, out pos, out yaw)
               || Search(spot, start, new[] { 8f, 12f, 18f, 25f, 35f, 45f, 60f }, false, 0.85f, 15f, 1.1f, out pos, out yaw);
        if (!ok)
        {
            yaw = 0f;
            pos = Physics.Raycast(spot.Anchor + Vector3.up * 3f, Vector3.down, out var h, 20f, ~0, QueryTriggerInteraction.Ignore) ? h.point : spot.Anchor;
            ModMain.Log?.Warning($"[MoreBunkers] {b.Id}: no clear ground near {spot.AnchorZh}, placed at the teleport point");
        }
        SaveData.Current.pos[b.Id] = new[] { pos.x, pos.y, pos.z, yaw };
        SaveData.Save();
        return true;
    }

    private static bool Search(Spot spot, int start, float[] radii, bool terrainOnly, float minNormal, float maxDy, float clear, out Vector3 pos, out float yaw)
    {
        pos = Vector3.zero;
        yaw = 0f;
        foreach (float r in radii)
        {
            for (int k = 0; k < 18; k++)
            {
                float ang = (start + k) * 20f;
                var dir = Quaternion.Euler(0f, ang, 0f) * Vector3.forward;
                var top = spot.Anchor + dir * r + Vector3.up * 60f;
                if (!Physics.Raycast(top, Vector3.down, out var hit, 160f, ~0, QueryTriggerInteraction.Ignore)) continue;
                if (hit.collider == null) continue;
                if (terrainOnly && hit.collider.TryCast<TerrainCollider>() == null) continue;
                if (hit.normal.y < minNormal || Mathf.Abs(hit.point.y - spot.Anchor.y) > maxDy) continue;
                if (Blocked(hit.point, clear, hit.collider)) continue;
                pos = hit.point;
                yaw = ang + 180f;
                return true;
            }
        }
        return false;
    }

    private static bool Blocked(Vector3 p, float radius, Collider ground)
    {
        var hits = Physics.OverlapSphere(p + Vector3.up * (radius + 0.1f), radius);
        for (int i = 0; hits != null && i < hits.Count; i++)
        {
            var c = hits[i];
            if (c == null || c.isTrigger || c.TryCast<TerrainCollider>() != null || c == ground) continue;
            return true;
        }
        return false;
    }

    private static uint Fnv(string s)
    {
        uint h = 2166136261;
        foreach (char c in s) { h ^= c; h *= 16777619; }
        return h;
    }

    // 人就在这张图上时,补一句离多远、往哪走。地图上方是 +z
    private static string HowFar(BunkerDef b)
    {
        try
        {
            if (!_roots.TryGetValue(b.Id, out var root) || root == null) return "";
            var p = GameManager.GetPlayerTransform();
            if (p == null) return "";
            var d = root.transform.position - p.position;
            float dist = new Vector2(d.x, d.z).magnitude;
            bool en = ModMain.En;
            if (dist < 3f) return en ? ", right here" : ",就在脚下";
            string[] dirs = en ? new[] { "N", "NE", "E", "SE", "S", "SW", "W", "NW" } : new[] { "北", "东北", "东", "东南", "南", "西南", "西", "西北" };
            float ang = (Mathf.Atan2(d.x, d.z) * Mathf.Rad2Deg + 360f + 22.5f) % 360f;
            return en ? $", {dist:F0} m to the {dirs[(int)(ang / 45f)]}" : $",离你 {dist:F0} 米,往{dirs[(int)(ang / 45f)]}";
        }
        catch { return ""; }
    }

    private static string NameEn(BunkerDef b) => b.Id switch { "craft" => "Craftsman Bunker", "merc" => "Mercenary Bunker", "stock" => "Stockpile Bunker", _ => b.NameZh };

    private static string RegionEn(Spot s) => s.Region switch { "LakeRegion" => "Mystery Lake", "AirfieldRegion" => "Forsaken Airfield", "CoastalRegion" => "Coastal Highway", "MarshRegion" => "Forlorn Muskeg", _ => s.Region };

    internal static string DescribeShort()
    {
        var lines = new List<string>();
        foreach (var b in All)
        {
            var s = SpotOf(b);
            if (ModMain.En) { lines.Add($"{NameEn(b)} -> {RegionEn(s)}"); continue; }
            lines.Add(string.IsNullOrEmpty(s.AnchorZh) ? $"{b.NameZh}->{s.RegionZh}" : $"{b.NameZh}->{s.RegionZh}({s.AnchorZh}旁)");
        }
        return string.Join("\n", lines);
    }

    internal static string Describe()
    {
        var lines = new List<string>();
        foreach (var b in All)
        {
            var s = SpotOf(b);
            if (ModMain.En) { lines.Add($"{NameEn(b)}: {RegionEn(s)}" + HowFar(b)); continue; }
            lines.Add((string.IsNullOrEmpty(s.AnchorZh) ? $"{b.NameZh}在{s.RegionZh}" : $"{b.NameZh}在{s.RegionZh},{s.AnchorZh}旁边") + HowFar(b));
        }
        return string.Join("\n", lines);
    }
}
