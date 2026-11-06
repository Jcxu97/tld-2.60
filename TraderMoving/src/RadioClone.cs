using System;
using System.Collections;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppTLD.Trader;
using MelonLoader;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace TraderMoving;

// 让别的场景里也是一台完整的原版无线电。
//
// 带交互的无线电不是可加载资源,只存在于它自己的 *_DLC01 场景里,整套东西
// (对话选项、动画、语音、灯)拆不开,只能整个复制。原件在眼前时直接复制一份存成模板;
// 读档后原件不在眼前,就在后台把原件所在的 DLC 场景单独加载一下,复制完马上卸掉。
// 模板挂在不激活的物体下面,不会跑任何逻辑。复制失败时退回美术模型做的随身无线电。
internal static class RadioClone
{
    private static GameObject _holder;
    private static GameObject _template;
    private static string _templateOrigin;

    internal static bool Harvesting { get; private set; }
    internal static string HarvestScene { get; private set; }
    private static readonly HashSet<string> _failed = new();

    internal static bool HasTemplate(string origin) => _template != null && _templateOrigin == origin;
    internal static bool Failed(string origin) => _failed.Contains(origin);

    internal static void Forget()
    {
        _failed.Clear();
    }

    // 从一台原版无线电复制模板(原件是否激活都行,模板挂在不激活的物体下)
    internal static void MakeTemplate(GameObject real, string origin)
    {
        if (real == null || HasTemplate(origin)) return;
        try
        {
            if (_holder == null)
            {
                _holder = new GameObject("TraderMoving_Templates");
                _holder.SetActive(false);
                UnityEngine.Object.DontDestroyOnLoad(_holder);
            }
            if (_template != null) UnityEngine.Object.Destroy(_template);

            var clone = UnityEngine.Object.Instantiate(real, _holder.transform);
            clone.name = World.RadioName;
            StripDecoration(clone);
            // 装修模式下 SCPlus 会关掉 TraderRadio 组件,复制品要开着
            foreach (var tr in clone.GetComponentsInChildren<TraderRadio>(true)) ((Behaviour)tr).enabled = true;
            clone.SetActive(true);
            _template = clone;
            _templateOrigin = origin;
            ModMain.Log?.Msg($"[TraderMoving] 已复制无线电模板(来自 {origin})");
        }
        catch (Exception ex) { ModMain.Log?.Error($"[TraderMoving] 复制无线电失败: {ex}"); }
    }

    // SCPlus 在 DLC 场景里给无线电加了装修用的组件。复制品不归它管,去掉免得它拿去存档重建
    private static void StripDecoration(GameObject go)
    {
        foreach (var c in go.GetComponentsInChildren<Component>(true))
        {
            if (c == null) continue;
            string n;
            try { n = c.GetIl2CppType().Name; } catch { continue; }
            if (n == "DecorationItem" || n == "SCPlusCarryable" || n == "Placeable" || n == "ObjectGuid")
                UnityEngine.Object.DestroyImmediate(c);
        }
    }

    internal static GameObject Spawn(Vector3 pos, Quaternion rot)
    {
        if (_template == null || _holder == null) return null;
        // 先在不激活的物体下摆好位置再激活,组件醒来时看到的就是新位置
        var go = UnityEngine.Object.Instantiate(_template, _holder.transform);
        go.name = World.RadioName;
        go.SetActive(false);
        go.transform.SetParent(null, false);
        try
        {
            var s = UnityEngine.SceneManagement.SceneManager.GetSceneByName(GameManager.m_ActiveScene);
            if (s.IsValid() && s.isLoaded && go.scene != s) UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go, s);
        }
        catch { }
        go.transform.SetPositionAndRotation(pos, rot);
        go.SetActive(true);
        return go;
    }

    // 摆放用的外形:从模板复制,在不激活的物体下把除了模型和碰撞以外的组件全删掉再拿出来
    internal static GameObject MakePreview()
    {
        if (_template == null || _holder == null) return null;
        var go = UnityEngine.Object.Instantiate(_template, _holder.transform);
        go.name = World.PreviewName;
        // 对话选项(平时是关着的)、挡装修的碰撞体和触发区会让游戏把占地算大,虚影无故变红
        foreach (Transform t in go.GetComponentsInChildren<Transform>(true))
        {
            if (t == null || t == go.transform) continue;
            if (t.name == "DialogueChoices" || t.name == "BlockPlacementCollider") UnityEngine.Object.DestroyImmediate(t.gameObject);
        }
        for (int pass = 0; pass < 3; pass++)
        {
            foreach (var c in go.GetComponentsInChildren<Component>(true))
            {
                if (c == null) continue;
                if (c.TryCast<Transform>() != null || c.TryCast<MeshFilter>() != null || c.TryCast<LODGroup>() != null) continue;
                if (c.TryCast<Renderer>() != null && c.GetIl2CppType().Name != "ParticleSystemRenderer") continue;
                var col = c.TryCast<Collider>();
                if (col != null && !col.isTrigger) continue;
                try { UnityEngine.Object.DestroyImmediate(c); } catch { }
            }
        }
        go.transform.SetParent(null, true);
        try
        {
            var s = UnityEngine.SceneManagement.SceneManager.GetSceneByName(GameManager.m_ActiveScene);
            if (s.IsValid() && s.isLoaded && go.scene != s) UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go, s);
        }
        catch { }
        go.SetActive(true);
        return go;
    }

    private static string _pending;
    private static float _pendingAt;

    internal static bool Busy => Harvesting || _pending != null;

    // 不在游戏自己加载场景的途中插一个场景进去:先记下,等玩家能动了再开始
    internal static void StartHarvest(string origin)
    {
        if (Busy || string.IsNullOrEmpty(origin) || HasTemplate(origin) || Failed(origin)) return;
        if (!ScenePaths.ContainsKey(origin))
        {
            ModMain.Log?.Warning($"[TraderMoving] 不认识无线电原场景 {origin},改用随身无线电");
            _failed.Add(origin);
            return;
        }
        _pending = origin;
        _pendingAt = Time.realtimeSinceStartup + 2f;
    }

    internal static void Tick()
    {
        if (_pending == null || Harvesting || Time.realtimeSinceStartup < _pendingAt) return;
        try
        {
            if (GameManager.m_IsPaused) return;
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null || pm.GetControlMode() != PlayerControlMode.Normal) return;
        }
        catch { return; }
        string origin = _pending;
        _pending = null;
        if (HasTemplate(origin) || !ScenePaths.ContainsKey(origin)) return;
        MelonCoroutines.Start(Harvest(origin));
    }

    internal static void CancelPending() => _pending = null;

    private static IEnumerator Harvest(string origin)
    {
        Harvesting = true;
        HarvestScene = origin;
        bool? injectBefore = ScPlusInjectPdids();
        // 那个场景里要是也有交易箱,它醒来会把自己登记到商人管理器上,卸载后要改回来
        ExchangeBox boxBefore = null;
        try { boxBefore = GameManager.GetTraderManager()?.m_ExchangeBoxInScene; } catch { }
        ModMain.Log?.Msg($"[TraderMoving] 后台加载 {origin} 复制无线电");
        AsyncOperationHandle<SceneInstance> handle = default;
        bool loaded = false;
        try
        {
            // 单独的物理空间,里面的东西碰不到当前场景
            var p = new LoadSceneParameters(LoadSceneMode.Additive) { m_LocalPhysicsMode = LocalPhysicsMode.Physics3D };
            // DLC01.json 里场景的地址是场景名,资源路径不是地址,拿路径加载当场就失败
            handle = Addressables.LoadSceneAsync(origin, p, true, 100);
            loaded = true;
        }
        catch (Exception ex) { ModMain.Log?.Error($"[TraderMoving] 加载 {origin} 失败: {ex.Message}"); }

        if (loaded)
        {
            float deadline = Time.realtimeSinceStartup + 20f;
            while (!handle.IsDone && Time.realtimeSinceStartup < deadline) yield return null;

            bool ok = false;
            try
            {
                if (handle.IsDone && handle.Status == AsyncOperationStatus.Succeeded)
                {
                    var scene = handle.Result.Scene;
                    foreach (var root in scene.GetRootGameObjects())
                    {
                        var tr = root.GetComponentInChildren<TraderRadio>(true);
                        if (tr == null) continue;
                        MakeTemplate(((Component)tr).gameObject, origin);
                        ok = HasTemplate(origin);
                        break;
                    }
                    // 马上停用整个场景,卸载前别让里面的东西跑到下一帧
                    foreach (var root in scene.GetRootGameObjects()) root.SetActive(false);
                }
            }
            catch (Exception ex) { ModMain.Log?.Error($"[TraderMoving] 复制 {origin} 里的无线电失败: {ex.Message}"); }

            try
            {
                if (handle.IsDone && handle.Status == AsyncOperationStatus.Succeeded)
                    Addressables.UnloadSceneAsync(handle, true);
            }
            catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 卸载 {origin} 异常: {ex.Message}"); }

            if (!ok)
            {
                _failed.Add(origin);
                string why = "";
                try { why = handle.IsDone ? $" (加载状态 {handle.Status} {handle.OperationException?.Message})" : " (20 秒没加载完)"; } catch { }
                ModMain.Log?.Warning($"[TraderMoving] {origin} 里没复制到无线电,改用随身无线电{why}");
            }
        }
        else _failed.Add(origin);

        // 等卸载完再摆
        for (int i = 0; i < 30; i++) yield return null;
        // SCPlus 在任何场景卸载时把 injectPdids 打开、加载时关上;我们这次加载卸载不该改它
        if (injectBefore.HasValue) ScPlusInjectPdids(injectBefore.Value);
        try
        {
            var tm = GameManager.GetTraderManager();
            if (tm != null) tm.m_ExchangeBoxInScene = boxBefore != null ? boxBefore : null;
        }
        catch { }
        Harvesting = false;
        HarvestScene = null;
        World.Apply();
    }

    private static System.Reflection.FieldInfo _injectField;
    private static bool _injectLooked;

    private static bool? ScPlusInjectPdids(bool? set = null)
    {
        try
        {
            if (!_injectLooked)
            {
                _injectLooked = true;
                _injectField = ScPlusPickup.FindType("DecorationPatches")?.GetField("injectPdids",
                    System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            }
            if (_injectField == null) return null;
            if (set.HasValue) _injectField.SetValue(null, set.Value);
            return (bool)_injectField.GetValue(null);
        }
        catch { return null; }
    }

    // DLC01.json 里全部 *_DLC01 场景(键是加载用的地址,值是资源路径,只作对照)
    private static readonly Dictionary<string, string> ScenePaths = new()
    {
        ["AshCabinF_DLC01"] = "Assets/Scenes/_Interiors/AshCabinF/AshCabinF_DLC01.unity",
        ["AshWoodCabinA_DLC01"] = "Assets/Scenes/_Interiors/AshWoodCabinA/AshWoodCabinA_DLC01.unity",
        ["BlackrockCaveA_DLC01"] = "Assets/Scenes/_Interiors/BlackrockCaveA/BlackrockCaveA_DLC01.unity",
        ["CampOffice_DLC01"] = "Assets/Scenes/_Interiors/CampOffice/CampOffice_DLC01.unity",
        ["CanneryTrailerA_DLC01"] = "Assets/Scenes/_Interiors/CanneryTrailerA/CanneryTrailerA_DLC01.unity",
        ["CanyonRoadCave_DLC01"] = "Assets/Scenes/_Interiors/CanyonRoadCave/CanyonRoadCave_DLC01.unity",
        ["CaveC_DLC01"] = "Assets/Scenes/_Interiors/CaveC/CaveC_DLC01.unity",
        ["CoastalHouseA_DLC01"] = "Assets/Scenes/_Interiors/CoastalHouseA/CoastalHouseA_DLC01.unity",
        ["CoastalHouseB_DLC01"] = "Assets/Scenes/_Interiors/CoastalHouseB/CoastalHouseB_DLC01.unity",
        ["CoastalHouseC_DLC01"] = "Assets/Scenes/_Interiors/CoastalHouseC/CoastalHouseC_DLC01.unity",
        ["CoastalHouseD_DLC01"] = "Assets/Scenes/_Interiors/CoastalHouseD/CoastalHouseD_DLC01.unity",
        ["CoastalHouseE_DLC01"] = "Assets/Scenes/_Interiors/CoastalHouseE/CoastalHouseE_DLC01.unity",
        ["CoastalHouseF_DLC01"] = "Assets/Scenes/_Interiors/CoastalHouseF/CoastalHouseF_DLC01.unity",
        ["CommunityHallA_DLC01"] = "Assets/Scenes/_Interiors/CommunityHallA/CommunityHallA_DLC01.unity",
        ["ConvenienceStoreA_DLC01"] = "Assets/Scenes/_Interiors/ConvenienceStoreA/ConvenienceStoreA_DLC01.unity",
        ["FarmHouseA_DLC01"] = "Assets/Scenes/_Interiors/FarmHouseA/FarmHouseA_DLC01.unity",
        ["FarmHouseABasement_DLC01"] = "Assets/Scenes/_Interiors/FarmHouseABasement/FarmHouseABasement_DLC01.unity",
        ["FarmHouseB_DLC01"] = "Assets/Scenes/_Interiors/FarmHouseB/FarmHouseB_DLC01.unity",
        ["GreyMothersHouseA_DLC01"] = "Assets/Scenes/_Interiors/GreyMothersHouseA/GreyMothersHouseA_DLC01.unity",
        ["HuntingLodgeA_DLC01"] = "Assets/Scenes/_Interiors/HuntingLodgeA/HuntingLodgeA_DLC01.unity",
        ["LighthouseA_DLC01"] = "Assets/Scenes/_Interiors/LighthouseA/LighthouseA_DLC01.unity",
        ["MaintenanceShedA_DLC01"] = "Assets/Scenes/_Interiors/MaintenanceShedA/MaintenanceShedA_DLC01.unity",
        ["MaintenanceShedB_DLC01"] = "Assets/Scenes/_Interiors/MaintenanceShedB/MaintenanceShedB_DLC01.unity",
        ["MiltonHouseA_DLC01"] = "Assets/Scenes/_Interiors/MiltonHouseA/MiltonHouseA_DLC01.unity",
        ["MiltonHouseC_DLC01"] = "Assets/Scenes/_Interiors/MiltonHouseC/MiltonHouseC_DLC01.unity",
        ["MiltonHouseF1_DLC01"] = "Assets/Scenes/_Interiors/MiltonHouseF1/MiltonHouseF1_DLC01.unity",
        ["MiltonHouseF3_DLC01"] = "Assets/Scenes/_Interiors/MiltonHouseF3/MiltonHouseF3_DLC01.unity",
        ["PostOfficeA_DLC01"] = "Assets/Scenes/_Interiors/PostOfficeA/PostOfficeA_DLC01.unity",
        ["PrepperCacheA_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheA/PrepperCacheA_DLC01.unity",
        ["PrepperCacheB_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheB/PrepperCacheB_DLC01.unity",
        ["PrepperCacheBInterloper_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheBInterloper/PrepperCacheBInterloper_DLC01.unity",
        ["PrepperCacheC_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheC/PrepperCacheC_DLC01.unity",
        ["PrepperCacheD_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheD/PrepperCacheD_DLC01.unity",
        ["PrepperCacheE_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheE/PrepperCacheE_DLC01.unity",
        ["PrepperCacheEmpty_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheEmpty/PrepperCacheEmpty_DLC01.unity",
        ["PrepperCacheF_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheF/PrepperCacheF_DLC01.unity",
        ["PrepperCacheFEmpty_DLC01"] = "Assets/Scenes/_Interiors/PrepperCacheFEmpty/PrepperCacheFEmpty_DLC01.unity",
        ["QuonsetGasStation_DLC01"] = "Assets/Scenes/_Interiors/QuonsetGasStation/QuonsetGasStation_DLC01.unity",
        ["RadioControlHut_DLC01"] = "Assets/Scenes/_Interiors/RadioControlHut/RadioControlHut_DLC01.unity",
        ["RadioControlHutB_DLC01"] = "Assets/Scenes/_Interiors/RadioControlHutB/RadioControlHutB_DLC01.unity",
        ["RadioControlHutC_DLC01"] = "Assets/Scenes/_Interiors/RadioControlHutC/RadioControlHutC_DLC01.unity",
        ["RuralStoreA_DLC01"] = "Assets/Scenes/_Interiors/RuralStoreA/RuralStoreA_DLC01.unity",
        ["SafeHouseA_DLC01"] = "Assets/Scenes/_Interiors/SafeHouseA/SafeHouseA_DLC01.unity",
        ["WhalingMine_DLC01"] = "Assets/Scenes/_Interiors/WhalingMine/WhalingMine_DLC01.unity",
        ["WhalingWarehouseA_DLC01"] = "Assets/Scenes/_Interiors/WhalingWarehouseA/WhalingWarehouseA_DLC01.unity",
        ["WoodCabinA_DLC01"] = "Assets/Scenes/_Interiors/WoodCabinA/WoodCabinA_DLC01.unity",
        ["WoodCabinB_DLC01"] = "Assets/Scenes/_Interiors/WoodCabinB/WoodCabinB_DLC01.unity",
        ["WoodCabinC_DLC01"] = "Assets/Scenes/_Interiors/WoodCabinC/WoodCabinC_DLC01.unity",
        ["AshCanyonRegion_DLC01"] = "Assets/Scenes/_Zones/AshCanyonRegion/AshCanyonRegion_DLC01.unity",
        ["BlackrockPrisonSurvivalZone_DLC01"] = "Assets/Scenes/_Zones/BlackrockPrisonSurvivalZone/BlackrockPrisonSurvivalZone_DLC01.unity",
        ["BlackrockRegion_DLC01"] = "Assets/Scenes/_Zones/BlackrockRegion/BlackrockRegion_DLC01.unity",
        ["CanneryRegion_DLC01"] = "Assets/Scenes/_Zones/Cannery/CanneryRegion_DLC01.unity",
        ["CoastalRegion_DLC01"] = "Assets/Scenes/_Zones/CoastalRegion/CoastalRegion_DLC01.unity",
        ["CrashMountainRegion_DLC01"] = "Assets/Scenes/_Zones/CrashMountainRegion/CrashMountainRegion_DLC01.unity",
        ["HighwayMineTransitionZone_DLC01"] = "Assets/Scenes/_Zones/HighwayMineTransitionZone/HighwayMineTransitionZone_DLC01.unity",
        ["LakeRegion_DLC01"] = "Assets/Scenes/_Zones/LakeRegion/LakeRegion_DLC01.unity",
        ["MarshRegion_DLC01"] = "Assets/Scenes/_Zones/MarshRegion/MarshRegion_DLC01.unity",
        ["MineTransitionZone_DLC01"] = "Assets/Scenes/_Zones/MineTransitionZone/MineTransitionZone_DLC01.unity",
        ["MountainTownRegion_DLC01"] = "Assets/Scenes/_Zones/MountainTownRegion/MountainTownRegion_DLC01.unity",
        ["RiverValleyRegion_DLC01"] = "Assets/Scenes/_Zones/RiverValleyRegion/RiverValleyRegion_DLC01.unity",
        ["RuralRegion_DLC01"] = "Assets/Scenes/_Zones/RuralRegion/RuralRegion_DLC01.unity",
        ["TracksRegion_DLC01"] = "Assets/Scenes/_Zones/TracksRegion/TracksRegion_DLC01.unity",
        ["WhalingStationRegion_DLC01"] = "Assets/Scenes/_Zones/WhalingStationRegion/WhalingStationRegion_DLC01.unity",
    };
}
