using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using Il2Cpp;
using Il2CppInterop.Runtime;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[assembly: MelonInfo(typeof(LightPlus.Mod), "LightPlus", "0.1.0", "TldHacks")]
[assembly: MelonGame("Hinterland", "TheLongDark")]

namespace LightPlus;

public class Cfg
{
    public bool Enabled { get; set; } = true;
    public bool ForceDeferred { get; set; } = true;
    public bool Ssr { get; set; } = true;
    public int SsrPreset { get; set; } = 3;
    public float SunIntensity { get; set; } = 1.15f;
    public float AmbientIntensity { get; set; } = 1f;
    public float SunShadowStrength { get; set; } = 1f;
    public bool SoftShadows { get; set; } = true;
    public int ShadowResolution { get; set; } = 3;
    public float SsaoIntensity { get; set; } = 1.5f;
    public float SdfAO { get; set; } = 1.5f;
    public float SdfShadow { get; set; } = 1.5f;
    public float SdfTerrainShadow { get; set; } = 1.5f;
    public float GodrayOpacity { get; set; } = 2f;
    public bool TerrainShadows { get; set; } = true;
    public float BloomBlend { get; set; } = 1f;
    public float BloomThreshold { get; set; } = 0.7f;
    public float BloomSoftKnee { get; set; } = 0.7f;
    public float BloomDiffusion { get; set; } = 8f;
    public float SunSize { get; set; } = 1.5f;
    public float SunDiffusion { get; set; } = 1.5f;
    public bool Shafts { get; set; } = true;
    public float ShaftStrength { get; set; } = 1f;
    public float ShaftSceneIntensity { get; set; } = 0f;
    public float ShaftMaxDistance { get; set; } = 256f;
    public float ShaftShadowRange { get; set; } = 100f;
    public int ShaftShadowRes { get; set; } = 2048;
    public int ShaftSamples { get; set; } = 16;
    public float ShaftShadowBias { get; set; } = 0.0002f;
    public bool ShaftFlipY { get; set; } = true;
    public bool ShaftShadowFlipY { get; set; } = false;
    public int ShaftDebug { get; set; } = 0;
    public int ShaftEvent { get; set; } = 20;
    public int ShaftDepthEvent { get; set; } = 18;
    public int ShaftShadowMode { get; set; } = 2;
    public bool Relight { get; set; } = true;
    public bool Grade { get; set; } = true;
    public int ShaftShadowEvery { get; set; } = 3;
    public float GradeMix { get; set; } = 0.6f;
    public float GradeSplit { get; set; } = 1.7f;
    public float GradeContrast { get; set; } = 0.45f;
    public float GradeSunBoost { get; set; } = 0.55f;
    public float GradeVibrance { get; set; } = 1.1f;
    public float GradeVignette { get; set; } = 0.72f;
    public float GradeSunGlow { get; set; } = 0.1f;
    public bool Reflect { get; set; } = true;
    public float ReflectStrength { get; set; } = 0.6f;
    public float ReflectSmooth { get; set; } = 0.5f;
    public float ReflectDistance { get; set; } = 120f;
    public int GBufferEvent { get; set; } = 5;
    public int RelightEvent { get; set; } = 7;
    public float RelightTint { get; set; } = 1f;
    public float RelightSpecular { get; set; } = 1f;
    public float RelightContrast { get; set; } = 2f;
    public int RelightDebug { get; set; } = 0;
}

public partial class Mod : MelonMod
{
    static readonly string CfgPath = Path.Combine(MelonEnvironment.ModsDirectory, "LightPlus.json");
    static readonly string DumpPath = Path.Combine(MelonEnvironment.ModsDirectory, "LightPlus_dump.txt");
    static readonly JsonSerializerOptions Json = new() { WriteIndented = true, ReadCommentHandling = JsonCommentHandling.Skip, AllowTrailingCommas = true };

    Cfg C = new();
    DateTime cfgTime;
    float nextCfgCheck;
    bool on = true;

    readonly Dictionary<string, float> orig = new();
    readonly Dictionary<string, float> written = new();
    DistanceFieldShadows[] sdf = Array.Empty<DistanceFieldShadows>();
    CameraGlobalRT rt;
    RenderingPath? origPath;
    IntPtr origPathCam;
    bool? terrainOrig;
    CameraEffects.BloomOverride bloom;
    IntPtr bloomOwner;
    PostProcessVolume ssrVol;
    float dumpAt = -1;
    Shafts shafts;

    bool started;

    // Runs on the first frame, not in OnInitializeMelon: doing this during melon init crashed coreclr now and then.
    void Start()
    {
        started = true;
        if (!File.Exists(CfgPath)) File.WriteAllText(CfgPath, JsonSerializer.Serialize(C, Json));
        LoadCfg();
        // kept out of Mods so MelonLoader never scans the native DLL as a melon
        shafts = new Shafts(LoggerInstance, Path.Combine(MelonEnvironment.UserDataDirectory, "LightPlus"));
    }

    void LoadCfg()
    {
        try
        {
            cfgTime = File.GetLastWriteTimeUtc(CfgPath);
            C = JsonSerializer.Deserialize<Cfg>(File.ReadAllText(CfgPath), Json) ?? new Cfg();
            on = C.Enabled;
            if (ssrVol != null) { UnityEngine.Object.Destroy(ssrVol.gameObject); ssrVol = null; }
            LoggerInstance.Msg("config loaded");
        }
        catch (Exception e) { LoggerInstance.Warning("config read failed: " + e.Message); }
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        // orig/written persist: UniStorm and the cameras survive scene loads, so clearing them re-multiplies.
        sdf = Array.Empty<DistanceFieldShadows>(); nextFind = 0f;
        string s = sceneName.ToLowerInvariant();
        inWorld = !(s.Contains("menu") || s.Contains("boot") || s.Contains("empty"));
        if (inWorld) dumpAt = Time.realtimeSinceStartup + 8f;
    }

    bool inWorld;
    readonly System.Diagnostics.Stopwatch applySw = new();
    double applyMs;
    float nextFind, nextFindRt;
    int applyN;

    public override void OnLateUpdate()
    {
        if (!started) Start();
        PanelUpdate();
        if (Input.GetKeyDown(KeyCode.F8))
        {
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) dumpAt = 0;
            else { on = !on; LoggerInstance.Msg(on ? "effects ON" : "effects OFF"); }
        }
        if (Time.realtimeSinceStartup > nextCfgCheck)
        {
            nextCfgCheck = Time.realtimeSinceStartup + 1f;
            try { if (File.GetLastWriteTimeUtc(CfgPath) != cfgTime) LoadCfg(); } catch { }
        }
        if (!inWorld) return;
        try { if (GameManager.GetUniStorm() == null) return; } catch { return; }
        applySw.Restart();
        try { Apply(); } catch (Exception e) { LoggerInstance.Warning("apply: " + e.Message); }
        applySw.Stop();
        applyMs += applySw.Elapsed.TotalMilliseconds;
        if (++applyN == 600) { LoggerInstance.Msg($"apply {applyMs / applyN:F3} ms CPU per frame, gpu {(shafts != null ? shafts.GpuMs() : -1):F3} ms"); applyMs = 0; applyN = 0; }
        if (dumpAt >= 0 && Time.realtimeSinceStartup > dumpAt) { dumpAt = -1; Dump(); }
    }

    // Keep the game's value as base; if the game rewrites the field, take the new value as base.
    void Mul(Il2CppSystem.Object o, string name, float cur, Action<float> set, float mult)
    {
        string k = o.Pointer + name;
        if (!orig.ContainsKey(k) || (written.TryGetValue(k, out var w) && Math.Abs(w - cur) > 1e-5f)) orig[k] = cur;
        float target = on ? orig[k] * mult : orig[k];
        written[k] = target;
        if (Math.Abs(cur - target) > 1e-6f) set(target);
    }

    void Apply()
    {
        var us = GameManager.GetUniStorm();
        Mul(us, "sun", us.m_MasterSunLightIntensityScalar, v => us.m_MasterSunLightIntensityScalar = v, C.SunIntensity);
        Mul(us, "amb", us.m_MasterAmbientIntensityScalar, v => us.m_MasterAmbientIntensityScalar = v, C.AmbientIntensity);

        var sun = us.m_SunLight;
        if (sun != null && on)
        {
            if (C.SunShadowStrength >= 0) sun.shadowStrength = C.SunShadowStrength;
            if (C.SoftShadows && sun.shadows != LightShadows.None) sun.shadows = LightShadows.Soft;
            if (C.ShadowResolution >= 0) sun.shadowResolution = (UnityEngine.Rendering.LightShadowResolution)C.ShadowResolution;
        }

        var gr = us.m_GodrayManager;
        if (gr != null) Mul(gr, "gr", gr.m_MasterOpacity, v => gr.m_MasterOpacity = v, C.GodrayOpacity);

        var sky = us.m_SkyboxMaterialCopy ?? us.m_SkyboxMaterial;
        if (sky != null)
        {
            int sz = UniStormWeatherSystem.s_SunSizeShaderID, df = UniStormWeatherSystem.s_SunDiffusionShaderID;
            if (sky.HasProperty(sz)) Mul(sky, "sunsize", sky.GetFloat(sz), v => sky.SetFloat(sz, v), C.SunSize);
            if (sky.HasProperty(df)) Mul(sky, "sundiff", sky.GetFloat(df), v => sky.SetFloat(df, v), C.SunDiffusion);
        }

        var ce = GameManager.GetCameraEffects();
        if (ce != null)
        {
            Mul(ce, "ssao", ce.m_SSAO_IntensityScalar, v => ce.m_SSAO_IntensityScalar = v, C.SsaoIntensity);
            if (bloomOwner != ce.Pointer) { bloom = null; bloomOwner = ce.Pointer; }
            if (on && bloom == null)
            {
                bloom = new CameraEffects.BloomOverride();
                ce.AddBloomOverride(bloom);
            }
            else if (!on && bloom != null) { ce.RemoveBloomOverride(bloom); bloom = null; }
            if (bloom != null)
            {
                bloom.m_BlendStrength = C.BloomBlend;
                bloom.m_OverrideThreshold = C.BloomThreshold >= 0; bloom.m_Threshold = C.BloomThreshold;
                bloom.m_OverrideSoftKnee = C.BloomSoftKnee >= 0; bloom.m_SoftKnee = C.BloomSoftKnee;
                bloom.m_OverrideDiffusion = C.BloomDiffusion >= 0; bloom.m_Diffusion = C.BloomDiffusion;
            }
        }

        // a full scene search costs milliseconds, so a scene without these objects is searched again only every 5 s
        if (sdf.Length == 0 && Time.realtimeSinceStartup > nextFind) { sdf = FindAll<DistanceFieldShadows>(); nextFind = Time.realtimeSinceStartup + 5f; }
        foreach (var d in sdf)
        {
            if (d == null) continue;
            Mul(d, "ao", d.m_AOIntensity, v => d.m_AOIntensity = v, C.SdfAO);
            Mul(d, "sh", d.m_ShadowIntensity, v => d.m_ShadowIntensity = v, C.SdfShadow);
            Mul(d, "th", d.m_TerrainShadowIntensity, v => d.m_TerrainShadowIntensity = v, C.SdfTerrainShadow);
        }

        var qm = GameManager.GetQualitySettingsManager();
        var q = qm != null ? qm.GetCurrentQualitySettings() : null;
        if (q != null)
        {
            bool want = on && C.TerrainShadows ? true : (terrainOrig ?? q.m_AdditionalShadowsTerrainEnabled);
            if (q.m_AdditionalShadowsTerrainEnabled != want)
            {
                terrainOrig ??= q.m_AdditionalShadowsTerrainEnabled;
                q.m_AdditionalShadowsTerrainEnabled = want;
                // another mod's patch on this call throws on some frames; the flag is already set, so keep going
                try { qm.ApplyCurrentQualitySettings(); } catch (Exception e) { LoggerInstance.Warning("quality apply: " + e.Message); }
                sdf = Array.Empty<DistanceFieldShadows>(); nextFind = 0f;
                LoggerInstance.Msg($"terrain shadows {want}");
            }
        }

        if (rt == null && Time.realtimeSinceStartup > nextFindRt) { var a = FindAll<CameraGlobalRT>(); rt = a.Length > 0 ? a[0] : null; nextFindRt = Time.realtimeSinceStartup + 5f; }
        var cam = rt != null ? rt.m_WorldCamera : null;
        if (cam != null)
        {
            if (cam.Pointer != origPathCam) { origPathCam = cam.Pointer; origPath = cam.renderingPath; LoggerInstance.Msg($"{cam.name} original path {origPath}"); }
            var want = on && C.ForceDeferred ? RenderingPath.DeferredShading : origPath.Value;
            if (cam.renderingPath != want) cam.renderingPath = want;
        }

        bool indoor = false;
        try { indoor = GameManager.GetWeatherComponent().IsIndoorEnvironment(); } catch { }
        shafts?.Update(C, cam, indoor ? null : us.m_SunLight, us.m_MoonLight, on);

        if (C.Ssr && ssrVol == null && rt != null && rt.m_WorldPostProcessLayer != null) ssrVol = MakeSsrVolume(rt.m_WorldPostProcessLayer);
        if (ssrVol != null && ssrVol.enabled != on) ssrVol.enabled = on;
    }

    PostProcessVolume MakeSsrVolume(PostProcessLayer layer)
    {
        var old = GameObject.Find("LightPlus_SSR");
        if (old != null) return old.GetComponent<PostProcessVolume>();
        int mask = layer.volumeLayer.value, bit = 0;
        while (bit < 31 && (mask & (1 << bit)) == 0) bit++;
        var go = new GameObject("LightPlus_SSR") { layer = bit };
        var vol = go.AddComponent<PostProcessVolume>();
        vol.isGlobal = true; vol.priority = 1000f; vol.weight = 1f;
        var prof = ScriptableObject.CreateInstance<PostProcessProfile>();
        var s = prof.AddSettings(Il2CppType.Of<ScreenSpaceReflections>()).Cast<ScreenSpaceReflections>();
        s.active = true;
        s.enabled.value = true; s.enabled.overrideState = true;
        s.preset.value = (ScreenSpaceReflectionPreset)C.SsrPreset; s.preset.overrideState = true;
        vol.sharedProfile = prof;
        LoggerInstance.Msg($"SSR volume on layer {bit} (mask {mask})");
        return vol;
    }

    static T[] FindAll<T>() where T : UnityEngine.Object
    {
        var arr = UnityEngine.Object.FindObjectsOfType(Il2CppType.Of<T>());
        var r = new T[arr.Length];
        for (int i = 0; i < arr.Length; i++) r[i] = arr[i].Cast<T>();
        return r;
    }

    static string Fx(PostProcessEffectSettings s) => s == null ? "null" : $"{s.GetIl2CppType().Name}(en={s.enabled.value},act={s.active})";

    void Dump()
    {
        var b = new StringBuilder();
        void L(string s) => b.AppendLine(s);
        try
        {
            L($"scene={UnityEngine.SceneManagement.SceneManager.GetActiveScene().name} on={on}");
            L($"Quality shadows={QualitySettings.shadows} dist={QualitySettings.shadowDistance} res={QualitySettings.shadowResolution} casc={QualitySettings.shadowCascades} proj={QualitySettings.shadowProjection} color={QualitySettings.activeColorSpace}");
            L($"RenderSettings ambMode={RenderSettings.ambientMode} amb={RenderSettings.ambientLight} ambInt={RenderSettings.ambientIntensity} fog={RenderSettings.fog} fogMode={RenderSettings.fogMode} fogDens={RenderSettings.fogDensity} refl={RenderSettings.reflectionIntensity}");
            foreach (var c in Camera.allCameras)
                L($"Camera {c.name} path={c.renderingPath} actual={c.actualRenderingPath} hdr={c.allowHDR} depthMode={c.depthTextureMode} rt={(c.targetTexture != null)} far={c.farClipPlane}");
            if (rt != null)
            {
                var w = rt.m_WorldCamera;
                L($"CameraGlobalRT world={w?.name} weapon={rt.m_WeaponCamera?.name} origPath={origPath}");
                if (w != null) L($"WorldCam path={w.renderingPath} actual={w.actualRenderingPath} hdr={w.allowHDR} depthMode={w.depthTextureMode} far={w.farClipPlane}");
            }
            foreach (var pl in FindAll<PostProcessLayer>())
            {
                L($"PPLayer {pl.name} en={pl.enabled} volMask={pl.volumeLayer.value} aa={pl.antialiasingMode}");
                try { L($"   SSR={Fx(pl.GetSettings<ScreenSpaceReflections>())} AO={Fx(pl.GetSettings<AmbientOcclusion>())} Bloom={Fx(pl.GetSettings<UnityEngine.Rendering.PostProcessing.Bloom>())} CG={Fx(pl.GetSettings<UnityEngine.Rendering.PostProcessing.ColorGrading>())}"); } catch (Exception e) { L("   GetSettings failed " + e.Message); }
            }
            foreach (var v in FindAll<PostProcessVolume>())
            {
                var p = v.sharedProfile;
                var names = new List<string>();
                if (p != null) foreach (var s in p.settings) names.Add(Fx(s));
                L($"PPVolume {v.name} en={v.enabled} layer={v.gameObject.layer} global={v.isGlobal} prio={v.priority} w={v.weight} profile={p?.name}: {string.Join(", ", names)}");
            }
            var us = GameManager.GetUniStorm();
            L($"UniStorm sunScalar={us.m_MasterSunLightIntensityScalar} ambScalar={us.m_MasterAmbientIntensityScalar} moonScalar={us.m_MasterMoonLightIntensityScalar} sunShadowStrength()={us.GetSunShadowStrength()} fogDensity={us.m_FogDensity}");
            var sun = us.m_SunLight;
            if (sun != null) L($"Sun en={sun.enabled} int={sun.intensity} col={sun.color} shadows={sun.shadows} str={sun.shadowStrength} res={sun.shadowResolution} bias={sun.shadowBias} nbias={sun.shadowNormalBias} rot={sun.transform.eulerAngles}");
            var gr = us.m_GodrayManager;
            if (gr != null) L($"Godray en={gr.enabled} active={gr.gameObject.activeInHierarchy} opacity={gr.m_MasterOpacity} rays={(gr.m_Rays != null ? gr.m_Rays.Length : -1)} requireTrigger={gr.m_RequireTrigger}");
            var ce = GameManager.GetCameraEffects();
            if (ce != null)
            {
                var cs = ce.m_CurrentSettings;
                L($"CameraEffects ssaoOn={ce.IsSSAOEnabled()} mode={ce.GetCurrentSSAOMode()} scalar={ce.m_SSAO_IntensityScalar} cur={(cs != null ? $"{cs.name} r={cs.m_Radius} i={cs.m_Intensity}" : "null")}");
                var bl = ce.m_Bloom;
                if (bl != null) L($"   Bloom int={bl.intensity.value} thr={bl.threshold.value} knee={bl.softKnee.value} diff={bl.diffusion.value} overrides={ce.m_BloomOverrides?.Count}");
                var sky = us.m_SkyboxMaterialCopy ?? us.m_SkyboxMaterial;
                if (sky != null) L($"   Sky {sky.name} sunSize={sky.GetFloat(UniStormWeatherSystem.s_SunSizeShaderID)} sunDiff={sky.GetFloat(UniStormWeatherSystem.s_SunDiffusionShaderID)} exposure={sky.GetFloat(UniStormWeatherSystem.s_ExposureShaderID)}");
                var ao = ce.m_AmbientOcclusionWorldCam;
                if (ao != null) L($"   AOWorld en={ao.enabled.value} mode={ao.mode.value} int={ao.intensity.value} radius={ao.radius.value} quality={ao.quality.value} ambientOnly={ao.ambientOnly.value} direct={ao.directLightingStrength.value}");
            }
            foreach (var d in sdf.Length > 0 ? sdf : FindAll<DistanceFieldShadows>())
                L($"SDFShadows en={d.enabled} init={d.m_Initialized} ao={d.m_AOIntensity}/{d.m_AOPenumbra} sh={d.m_ShadowIntensity}/{d.m_ShadowPenumbra} terr={d.m_TerrainShadowIntensity}/{d.m_TerrainPenumbra} pow={d.m_ResultPower} mul={d.m_ResultMultiplier} snow={d.m_SnowIceMultiplier}");
            L($"MeshDistanceFieldManager count={FindAll<MeshDistanceFieldManager>().Length} HeightFog count={FindAll<HeightFogManager>().Length}");
            var q = GameManager.GetQualitySettingsManager()?.GetCurrentQualitySettings();
            if (q != null) L($"QualityLevel shadows={q.m_ShadowsEnabled} sq={q.m_ShadowQuality} sres={q.m_ShadowResolution} postfx={q.m_PostFxQuality} aa={q.m_AntiAliasingQuality} ssao={q.m_SSAO} addShadowStruct={q.m_AdditionalShadowsStructuresEnabled} addShadowTerrain={q.m_AdditionalShadowsTerrainEnabled} shadowDraw={q.m_ShadowDrawDistance}");
            var stats = new Dictionary<string, int>();
            foreach (var r in FindAll<Renderer>())
            {
                var m = r.sharedMaterial;
                if (m == null) continue;
                string k = $"{m.shader?.name} [{m.GetTag("RenderType", true)}] layer={r.gameObject.layer}";
                stats[k] = stats.GetValueOrDefault(k) + 1;
            }
            foreach (var kv in stats.OrderByDescending(x => x.Value).Take(40)) L($"   {kv.Value} {kv.Key}");
            L($"GameManager forceDeferred={GameManager.m_ForceDeferredRendering} forceForward={GameManager.m_ForceForwardRendering}");
        }
        catch (Exception e) { L("dump error: " + e); }
        File.WriteAllText(DumpPath, b.ToString());
        LoggerInstance.Msg("dump written:\n" + b);
    }
}
