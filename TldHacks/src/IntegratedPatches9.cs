using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
#if !STORY_EDITION   // 2.24 无此命名空间(2.24 之后才加入游戏)
using Il2CppTLD.ModularElectrolizer;
#endif
using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;
using AssetBundle = UnityEngine.AssetBundle;

namespace TldHacks;

// ═══════════════════════════════════════════════════════════════════════════
// HouseLights 整合 (原 mod by DemonBunnyBon)
// 室内灯光开关 — 非极光时也能亮灯,通过墙上 switch 交互 toggle
// ═══════════════════════════════════════════════════════════════════════════

// 每个灯源记住上次被设成的状态(关 / 开 / 交给极光),状态和设置都没变就什么都不做。
//   旧版每 5 帧给每个灯源重写每盏灯的范围、颜色、阴影,再调游戏的四个更新函数,灯关着也照跑。
//   原版在 AuroraManager.Update 里先调 UpdateForceAurora、后更新电灯;没有极光时原版不碰这些灯
//   (否则旧版的灯会 5 帧暗 4 帧),所以只在状态变了、设置变了、或者亮度字段被别处改掉时重设。
internal abstract class HLSource
{
    internal const int Off = 0, On = 1, Aurora = 2;

    public float[] ranges;
    public Color[] colors, whites;
    public LightShadows[] shadows;
    public Vector3 pos;
    public bool skipWhenOn;
    private int _applied = -1, _ver = -1;
    private float _output;

    public abstract bool Alive { get; }
    protected abstract float Output { get; }
    protected abstract void SetProps(bool restore);
    protected abstract void SetState(int want);

    protected void Setup(int n, string goName, Vector3 p)
    {
        ranges = new float[n];
        colors = new Color[n];
        whites = new Color[n];
        shadows = new LightShadows[n];
        pos = p;
        skipWhenOn = goName.Contains("Alarm") || goName.Contains("Headlight") ||
            goName.Contains("Taillight") || goName.Contains("Television") ||
            goName.Contains("Computer") || goName.Contains("Machine") ||
            goName.Contains("ControlBox") || goName.Contains("Interiorlight");
    }

    protected void Record(int i, Light l)
    {
        ranges[i] = l.range;
        colors[i] = l.color;
        shadows[i] = l.shadows;
        Color.RGBToHSV(colors[i], out float h, out float s, out float v);
        whites[i] = Color.HSVToRGB(h, s * 0.15f, v);
    }

    protected void SetLight(int i, Light l, bool restore)
    {
        if (l == null || i >= ranges.Length) return;
        if (restore) { l.range = ranges[i]; l.color = colors[i]; l.shadows = shadows[i]; return; }
        l.range = Math.Min(ranges[i] * CheatState.HL_RangeMultiplier, 20f);
        l.color = CheatState.HL_WhiteLights ? whites[i] : colors[i];
        l.shadows = CheatState.HL_CastShadows ? LightShadows.Soft : shadows[i];
    }

    public void Update(int want, int ver, bool flicker)
    {
        if (ver == _ver && want == _applied)
        {
            if (want == Aurora) return;
            // 开着闪烁时旧版靠每 5 帧重设来刷新,这种情况照旧
            if (_output == Output && !(want == On && flicker)) return;
        }
        SetProps(false);
        _ver = ver;
        _applied = want;
        if (want == Aurora) return;
        SetState(want);
        _output = Output;
    }

    public void Restore(bool aurora)
    {
        SetProps(true);
        if (!aurora) SetState(Off);
        _applied = -1;
        _ver = -1;
    }
}

#if !STORY_EDITION
// 2.24 无 Il2CppTLD.ModularElectrolizer.AuroraModularElectrolizer(极光电解器是后加的)。
// 屋内灯光的另一条路径 AuroraLightingSimple/HLElectroLightConfig 在 2.24 存在,保留。
internal sealed class HLElectrolizerConfig : HLSource
{
    public readonly AuroraModularElectrolizer electrolizer;
    private readonly bool _flickerOrig;

    public HLElectrolizerConfig(AuroraModularElectrolizer e)
    {
        electrolizer = e;
        _flickerOrig = e.m_HasFlickerSet;
        var lights = e.m_LocalLights;
        int n = lights._size;
        Setup(n, e.gameObject.name, e.transform.position);
        for (int i = 0; i < n; i++) Record(i, lights[i]);
    }

    public override bool Alive => electrolizer != null;
    protected override float Output => electrolizer.m_OutputIntensity;

    protected override void SetProps(bool restore)
    {
        var lights = electrolizer.m_LocalLights;
        if (lights != null)
        {
            int n = Math.Min(lights._size, ranges.Length);
            for (int i = 0; i < n; i++) SetLight(i, lights[i], restore);
        }
        electrolizer.m_HasFlickerSet = restore ? _flickerOrig : !CheatState.HL_NoFlicker;
    }

    protected override void SetState(int want)
    {
        var e = electrolizer;
        if (want == On)
        {
            e.UpdateIntensity(1f, CheatState.HL_Intensity);
            e.UpdateLight(false);
            e.UpdateEmissiveObjects(false);
            if (CheatState.HL_LightAudio) e.UpdateAudio();
            else e.StopAudio();
        }
        else
        {
            e.UpdateIntensity(1f, 0f);
            e.UpdateLight(true);
            e.UpdateEmissiveObjects(true);
            e.UpdateAudio();
        }
    }
}
#endif

internal sealed class HLElectroLightConfig : HLSource
{
    public readonly AuroraLightingSimple electrolizer;

    public HLElectroLightConfig(AuroraLightingSimple e)
    {
        electrolizer = e;
        var lights = (Il2CppArrayBase<Light>)(object)e.m_LocalLights;
        int n = lights.Length;
        Setup(n, e.gameObject.name, e.transform.position);
        for (int i = 0; i < n; i++) Record(i, lights[i]);
    }

    public override bool Alive => electrolizer != null;
    protected override float Output => electrolizer.m_CurIntensity;

    protected override void SetProps(bool restore)
    {
        var arr = electrolizer.m_LocalLights;
        if (arr == null) return;
        var lights = (Il2CppArrayBase<Light>)(object)arr;
        int n = Math.Min(lights.Length, ranges.Length);
        for (int i = 0; i < n; i++) SetLight(i, lights[i], restore);
    }

    protected override void SetState(int want)
    {
        var e = electrolizer;
        if (want == On)
        {
            e.m_CurIntensity = CheatState.HL_Intensity;
            e.UpdateLight(false);
            e.UpdateEmissiveObjects(false);
            if (CheatState.HL_LightAudio) e.UpdateAudio();
            else e.StopAudio();
        }
        else
        {
            e.m_CurIntensity = 0f;
            e.UpdateLight(true);
            e.UpdateEmissiveObjects(true);
            e.UpdateAudio();
        }
    }
}

internal static class HouseLightsState
{
    internal static AssetBundle HLBundle;
    internal static bool LightsOn;
#if !STORY_EDITION
    internal static List<HLElectrolizerConfig> ElectroSources = new();
#endif
    internal static List<HLElectroLightConfig> ElectroLightSources = new();
    internal static List<GameObject> LightSwitches = new();
    private static readonly HashSet<IntPtr> _switchPtrs = new();

    internal static readonly List<string> NotReallyOutdoors = new() { "DamTransitionZone" };

    internal static Shader VanillaShader;

    internal static void LoadBundle()
    {
        if (HLBundle != null) return;
        try
        {
            using var stream = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("TldHacks.HouseLights.hlbundle");
            if (stream == null)
            {
                MelonLogger.Warning("[HouseLights] hlbundle not found as embedded resource");
                return;
            }
            var ms = new MemoryStream((int)stream.Length);
            stream.CopyTo(ms);
            var il2ms = new Il2CppSystem.IO.MemoryStream(
                (Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<byte>)ms.ToArray());
            HLBundle = AssetBundle.LoadFromStream((Il2CppSystem.IO.Stream)(object)il2ms);
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[HouseLights] 加载 bundle 失败: {ex.Message}");
        }
    }

    internal static void Init()
    {
#if !STORY_EDITION
        ElectroSources.Clear();
#endif
        ElectroLightSources.Clear();
        LightSwitches.Clear();
        _switchPtrs.Clear();
        LightsOn = false;
    }

#if !STORY_EDITION
    internal static void AddElectrolizer(AuroraModularElectrolizer light)
    {
        if (light.m_LocalLights == null) return;
        ElectroSources.Add(new HLElectrolizerConfig(light));
    }
#endif

    internal static void AddElectrolizerLight(AuroraLightingSimple light)
    {
        if (light.m_LocalLights == null) return;
        ElectroLightSources.Add(new HLElectroLightConfig(light));
    }

    internal static bool IsSwitch(GameObject obj) => _switchPtrs.Contains(obj.Pointer);

    private static readonly string[] SwitchNames =
    {
        "houselightswitch", "lightswitcha", "lightswitchblack", "switch_a_black",
        "switch_a_white", "switch_a_purple", "switch_b_white",
    };

    internal static void GetSwitches()
    {
        var found = new List<GameObject>();
        foreach (var root in GetRootObjects()) FindSwitches(root.transform, found);

        foreach (var obj in found)
        {
            if (!obj.active) continue;
            string switchName = obj.name;
            int variant = (switchName.IndexOf("houselightswitch", System.StringComparison.OrdinalIgnoreCase) >= 0
                || switchName.IndexOf("lightswitcha", System.StringComparison.OrdinalIgnoreCase) >= 0) ? 1 : 2;
            obj.active = false;
            Vector3 pos = obj.transform.position;
            Quaternion rot = obj.transform.rotation;
            var sw = InstantiateSwitch(pos, rot.eulerAngles, variant);
            if (sw == null) continue;
            var mesh = sw.transform.FindChild("SM_LightSwitchBlack")?.gameObject;
            if (mesh == null) continue;
            mesh.layer = 19;
            LightSwitches.Add(mesh);
            _switchPtrs.Add(mesh.Pointer);
            mesh.name = "MOD_HouseLightSwitch";
            if (mesh.GetComponent<Collider>() == null)
            {
                var col = mesh.AddComponent<BoxCollider>();
                // v6.9.6 原版 0.1³(10cm)碰撞体太小 → 准星极难对准 → "有些人交互不了开关"。
                //   放大到 0.3³(30cm)纯命中检测体,不影响外观/FPS,大幅提高交互可靠性。
                col.size = new Vector3(0.3f, 0.3f, 0.3f);
            }
        }
    }

    // 一次遍历同时比七个名字:旧版每个名字各遍历一遍整棵场景树,进场景时每个节点的名字要读七次
    private static void FindSwitches(Transform t, List<GameObject> result)
    {
        int n = t.childCount;
        for (int i = 0; i < n; i++)
        {
            var child = t.GetChild(i);
            string name = child.name;
            for (int k = 0; k < SwitchNames.Length; k++)
            {
                if (name.IndexOf(SwitchNames[k], System.StringComparison.OrdinalIgnoreCase) < 0) continue;
                result.Add(child.gameObject);
                break;
            }
            FindSwitches(child, result);
        }
    }

    private static float _kRange = float.NaN, _kIntensity = float.NaN;
    private static int _kFlags = -1, _ver;

    // 影响灯光属性和开灯效果的设置一变就换版本号,所有灯源下一次都会重设
    private static int SettingsVersion()
    {
        int flags = (CheatState.HL_WhiteLights ? 1 : 0) | (CheatState.HL_CastShadows ? 2 : 0)
            | (CheatState.HL_NoFlicker ? 4 : 0) | (CheatState.HL_LightAudio ? 8 : 0);
        if (flags != _kFlags || CheatState.HL_RangeMultiplier != _kRange || CheatState.HL_Intensity != _kIntensity)
        {
            _kFlags = flags;
            _kRange = CheatState.HL_RangeMultiplier;
            _kIntensity = CheatState.HL_Intensity;
            _ver++;
        }
        return _ver;
    }

    internal static void UpdateElectroLights(AuroraManager mngr)
    {
        var player = GameManager.GetVpFPSPlayer();
        if (player == null) return;
        Vector3 p = player.transform.position;
        bool aurora = mngr.AuroraIsActive();
        float cull = CheatState.HL_CullDistance;
        int ver = SettingsVersion();
        bool flicker = !CheatState.HL_NoFlicker;
#if !STORY_EDITION
        UpdateAll(ElectroSources, p, aurora, cull * cull, ver, flicker);
#endif
        UpdateAll(ElectroLightSources, p, aurora, cull * cull, ver, flicker);
    }

    private static void UpdateAll<T>(List<T> list, Vector3 p, bool aurora, float cull2, int ver, bool flicker)
        where T : HLSource
    {
        for (int i = 0; i < list.Count; i++)
        {
            var src = list[i];
            try
            {
                if (!src.Alive) continue;
                int want = aurora ? HLSource.Aurora
                    : (src.pos - p).sqrMagnitude > cull2 ? HLSource.Off
                    : LightsOn && !src.skipWhenOn ? HLSource.On : HLSource.Off;
                src.Update(want, ver, flicker);
            }
            catch { }
        }
    }

    // HouseLights 关掉时:灯光属性写回原版;没有极光就把灯关掉,之后由原版接管
    internal static bool RestoreAll()
    {
        LightsOn = false;
        bool aurora = false;
        try { var am = GameManager.GetAuroraManager(); aurora = am != null && am.AuroraIsActive(); } catch { }
#if !STORY_EDITION
        foreach (var src in ElectroSources) { try { if (src.Alive) src.Restore(aurora); } catch { } }
#endif
        foreach (var src in ElectroLightSources) { try { if (src.Alive) src.Restore(aurora); } catch { } }
        return true;
    }

    internal static void InstantiateCustomSwitches(string sceneName)
    {
        if (HLBundle == null) return;
        switch (sceneName.ToLowerInvariant())
        {
            case "lakeregion":
                InstantiateSwitch(new Vector3(791.93f, 214.38f, 965.76f), new Vector3(0f, 265f, 0f), 0);
                break;
            case "trailera":
                InstantiateSwitch(new Vector3(-2.95f, 1.38f, 2.06f), new Vector3(0f, 180f, 0f), 0);
                break;
            case "communityhalla":
                InstantiateSwitch(new Vector3(0.128f, 1.38f, 4.2f), new Vector3(0f, 0f, 0f), 1);
                InstantiateSwitch(new Vector3(8.52f, 1.4f, 0.26f), new Vector3(0f, 0f, 0f), 1);
                InstantiateSwitch(new Vector3(6.91f, 1.54f, -3.97f), new Vector3(0f, 90f, 0f), 1);
                InstantiateSwitch(new Vector3(6.58f, 1.43f, 0.22f), new Vector3(0f, 270f, 0f), 3);
                InstantiateSwitch(new Vector3(-9.2f, 2.24f, 3.16f), new Vector3(0f, 180f, 0f), 3);
                InstantiateSwitch(new Vector3(9.05f, 1.41f, 0.16f), new Vector3(0f, 180f, 0f), 0);
                break;
            case "trailersshape":
                InstantiateSwitch(new Vector3(7.2f, 1.5f, -10.12f), new Vector3(0f, 0f, 0f), 1);
                InstantiateSwitch(new Vector3(0.59f, 1.55f, -5.92f), new Vector3(0f, 0f, 0f), 1);
                InstantiateSwitch(new Vector3(-6.53f, 1.52f, 3.76f), new Vector3(0f, 0f, 0f), 1);
                break;
            case "trailerb":
                InstantiateSwitch(new Vector3(3.88f, 1.34f, 2.07f), new Vector3(0f, 180f, 0f), 3);
                break;
            case "trailerc":
                InstantiateSwitch(new Vector3(-0.88f, 1.32f, 2.07f), new Vector3(0f, 180f, 0f), 0);
                break;
            case "trailerd":
                InstantiateSwitch(new Vector3(-3f, 1.37f, 2.07f), new Vector3(0f, 180f, 0f), 1);
                break;
            case "trailere":
                InstantiateSwitch(new Vector3(-2.94f, 1.34f, 2.07f), new Vector3(0f, 180f, 0f), 0);
                break;
            case "tracksregion":
                InstantiateSwitch(new Vector3(586.17f, 200.48f, 564.31f), new Vector3(0f, 270f, 0f), 3);
                break;
            case "mountainpassburiedcabin":
                InstantiateSwitch(new Vector3(3.89f, 1.26f, 0.82f), new Vector3(0f, 270f, 0f), 1);
                InstantiateSwitch(new Vector3(-0.52f, 5.17f, 1.711f), new Vector3(0f, 180f, 0f), 1);
                InstantiateSwitch(new Vector3(-0.54f, 5.13f, 1.78f), new Vector3(0f, 0f, 0f), 1);
                break;
            case "miltontrailerb":
                InstantiateSwitch(new Vector3(3.92f, 1.5f, 2.07f), new Vector3(0f, 180f, 0f), 3);
                break;
            case "huntinglodgea":
                InstantiateSwitch(new Vector3(7.27f, 1.18f, -1.58f), new Vector3(0f, 90f, 0f), 0);
                InstantiateSwitch(new Vector3(-1.17f, 1.51f, -5.01f), new Vector3(0f, 0f, 0f), 3);
                break;
            case "damtrailerb":
                InstantiateSwitch(new Vector3(4.01f, 1.49f, 2.07f), new Vector3(0f, 180f, 0f), 0);
                break;
            case "crashmountainregion":
                InstantiateSwitch(new Vector3(889.93f, 162.08f, 346.07f), new Vector3(0f, 180f, 0f), 3);
                break;
            case "coastalregion":
                InstantiateSwitch(new Vector3(757.9f, 25.51f, 646.78f), new Vector3(0f, 50f, 0f), 0);
                break;
            case "cannerytrailera":
                InstantiateSwitch(new Vector3(-3.02f, 1.42f, 2.79f), new Vector3(0f, 180f, 0f), 3);
                break;
            case "bunkerc":
                InstantiateSwitch(new Vector3(1.09f, 1.73f, 3.54f), new Vector3(0f, 0f, 0f), 3);
                InstantiateSwitch(new Vector3(-14.72f, 0.33f, 12.93f), new Vector3(0f, 0f, 0f), 3);
                break;
            case "bunkerb":
                InstantiateSwitch(new Vector3(1.13f, 1.67f, 3.54f), new Vector3(0f, 0f, 0f), 3);
                InstantiateSwitch(new Vector3(2.94f, 1.54f, 7.68f), new Vector3(0f, 90f, 0f), 3);
                InstantiateSwitch(new Vector3(-3.19f, 1.61f, 7.66f), new Vector3(0f, 270f, 0f), 3);
                break;
            case "bunkera":
                InstantiateSwitch(new Vector3(5.93f, 1.61f, 12.63f), new Vector3(0f, 180f, 0f), 3);
                InstantiateSwitch(new Vector3(1.18f, 1.65f, 1.62f), new Vector3(0f, 0f, 0f), 3);
                break;
            case "blackrocktrailerb":
                InstantiateSwitch(new Vector3(3.9726f, 1.4155f, 2.0799f), new Vector3(0f, 180f, 0f), 1);
                break;
            case "airfieldtrailerb":
                InstantiateSwitch(new Vector3(4.01f, 1.49f, 2.07f), new Vector3(0f, 180f, 0f), 0);
                break;
        }
    }

    // ——— Utility ———

    internal static List<GameObject> GetRootObjects()
    {
        var list = new List<GameObject>();
        for (int i = 0; i < UnityEngine.SceneManagement.SceneManager.sceneCount; i++)
        {
            Scene scene = UnityEngine.SceneManagement.SceneManager.GetSceneAt(i);
            var roots = scene.GetRootGameObjects();
            if (roots != null) foreach (var go in roots) list.Add(go);
        }
        return list;
    }

    internal static GameObject InstantiateSwitch(Vector3 pos, Vector3 rot, int variant)
    {
        if (HLBundle == null) return null;
        string asset = variant switch
        {
            1 => "OBJ_SwitchHLB",
            2 => "OBJ_SwitchHLC",
            3 => "OBJ_SwitchHLD",
            _ => "OBJ_SwitchHL"
        };
        var go = UnityEngine.Object.Instantiate(HLBundle.LoadAsset<GameObject>(asset));

        if (VanillaShader == null) VanillaShader = Shader.Find("Shader Forge/TLD_StandardDiffuse");
        var renderers = go.GetComponentsInChildren<MeshRenderer>();
        foreach (var mr in renderers)
        {
            var shared = mr.sharedMaterial;   // 读 .material 会先复制一份材质,马上又被下面换掉
            Texture tex = shared != null ? shared.mainTexture : null;
            Material mat = new Material(VanillaShader);
            mat.mainTexture = tex;
            mr.material = mat;
        }

        go.transform.eulerAngles = rot;
        go.transform.position = pos;
        go.transform.localScale = Vector3.one;
        return go;
    }

    private static bool _sceneMenu, _sceneOutdoor, _sceneNotReally;

    // 场景名每读一次都要分配一个新字符串:进场景时读一次记下来,每帧的判断只用记下的结果
    internal static void CacheScene()
    {
        string scene = GameManager.m_ActiveScene;
        _sceneMenu = scene != null && scene.Contains("MainMenu");
        _sceneOutdoor = scene != null && GameManager.IsOutDoorsScene(scene);
        _sceneNotReally = scene != null && NotReallyOutdoors.Contains(scene);
    }

    internal static bool IsMenu() => _sceneMenu || InterfaceManager.IsMainMenuEnabled();

    internal static bool ShouldRun() =>
        !IsMenu() && (!_sceneOutdoor || CheatState.HL_EnableOutside || _sceneNotReally);
}

// ═══════════════════════════════════════════════════════════════════════════
// Harmony Patches (走 DynamicPatch)
// ═══════════════════════════════════════════════════════════════════════════

internal static class Patch_HL_GameManager_InstantiatePlayer
{
    internal static void Prefix()
    {
        // 先清掉上个场景的灯源和开关:去室外时下面 ShouldRun 为 false,不会重新登记,
        //   列表里只剩已销毁的对象。HUD / 交互补丁靠开关列表是否为空来跳过射线检测
        HouseLightsState.CacheScene();
        HouseLightsState.Init();
        if (!HouseLightsState.ShouldRun()) return;
        HouseLightsState.LoadBundle();
        HouseLightsState.InstantiateCustomSwitches(GameManager.m_ActiveScene);
        HouseLightsState.GetSwitches();
    }
}

#if !STORY_EDITION
internal static class Patch_HL_Electrolizer_Initialize
{
    internal static void Postfix(AuroraModularElectrolizer __instance)
    {
        if (!HouseLightsState.ShouldRun()) return;
        var toggles = __instance.gameObject.GetComponentsInParent<AuroraActivatedToggle>();
        var screens = __instance.gameObject.GetComponentsInChildren<AuroraScreenDisplay>();
        if ((toggles == null || toggles.Count == 0) && (screens == null || screens.Count == 0))
            HouseLightsState.AddElectrolizer(__instance);
        __instance.m_HasFlickerSet = !CheatState.HL_NoFlicker;
    }
}
#endif

internal static class Patch_HL_AuroraManager_RegisterLightSimple
{
    internal static void Postfix(AuroraManager __instance, AuroraLightingSimple auroraLightSimple)
    {
        if (!HouseLightsState.ShouldRun()) return;
        HouseLightsState.AddElectrolizerLight(auroraLightSimple);
    }
}

internal static class Patch_HL_AuroraManager_UpdateForceAurora
{
    private static int _skip;
    internal static void Postfix(AuroraManager __instance)
    {
        if (++_skip < 5) return;
        _skip = 0;
        if (!HouseLightsState.ShouldRun()) return;
#if STORY_EDITION
        if (HouseLightsState.ElectroLightSources.Count > 0)
#else
        if (HouseLightsState.ElectroSources.Count > 0 || HouseLightsState.ElectroLightSources.Count > 0)
#endif
            HouseLightsState.UpdateElectroLights(__instance);
    }
}

internal static class Patch_HL_PlayerManager_UpdateHUDText
{
    private static string _textOn, _textOff;

    // 2.24 PlayerManager.UpdateHUDText 是无参的(2.55 才把 Panel_HUD 作参数传进来),
    // 所以剧情版从 InterfaceManager.m_Panel_HUD 自己取,函数体其余部分共用。
#if STORY_EDITION
    internal static void Postfix(PlayerManager __instance)
    {
        var hud = InterfaceManager.m_Panel_HUD;
        if (hud == null) return;
#else
    internal static void Postfix(PlayerManager __instance, Panel_HUD hud)
    {
#endif
        // 本场景没登记开关就不可能对准开关,别每帧做射线检测
        if (HouseLightsState.LightSwitches.Count == 0) return;
        if (HouseLightsState.IsMenu()) return;
        if (GameManager.GetMainCamera() == null) return;
        var obj = __instance.GetInteractiveObjectUnderCrosshairs(CheatState.HL_InteractDistance);
        if (obj != null && HouseLightsState.IsSwitch(obj))
        {
            _textOn ??= I18n.T("关灯", "Turn Lights Off");
            _textOff ??= I18n.T("开灯", "Turn Lights On");
            hud.SetHoverText(HouseLightsState.LightsOn ? _textOn : _textOff, obj, (HoverTextState)3);
        }
    }
}

internal static class Patch_HL_PlayerManager_ProcessInteraction
{
    internal static void Postfix(PlayerManager __instance, ref bool __result)
    {
        if (HouseLightsState.LightSwitches.Count == 0) return;
        if (HouseLightsState.IsMenu()) return;
        var obj = __instance.GetInteractiveObjectUnderCrosshairs(CheatState.HL_InteractDistance);
        if (obj == null || !HouseLightsState.IsSwitch(obj)) return;
        HouseLightsState.LightsOn = !HouseLightsState.LightsOn;
        GameAudioManager.PlaySound("Stop_RadioAurora", __instance.gameObject);
        float x = obj.transform.localScale.x;
        float y = obj.transform.localScale.y;
        float z = obj.transform.localScale.z;
        obj.transform.localScale = new Vector3(x, y * -1f, z);
        __result = true;
    }
}

internal static class Patch_HL_Weather_IsTooDarkForAction
{
    internal static void Postfix(Weather __instance, ref bool __result)
    {
        if (__result && HouseLightsState.LightsOn && !HouseLightsState.IsMenu() &&
            __instance != null && __instance.IsIndoorScene())
        {
            __result = false;
        }
    }
}
