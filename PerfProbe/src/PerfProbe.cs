using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using HarmonyLib;
using MelonLoader;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

[assembly: MelonInfo(typeof(PerfProbe.Probe), "PerfProbe", "1.0.0", "TldHacks")]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonPriority(-1000)]

namespace PerfProbe;

// Measures frame time and the cost of every mod hook. Ctrl+F9 starts a window by hand.
public class Probe : MelonMod
{
    const float AutoDelay = 20f, Window = 60f;

    class Stat { public string Owner, Label; public long Ticks, Calls, Max; public bool Inner; }
    record struct Frame(float Dt, long ModTicks, Stat Worst, long WorstTicks, Stat Inner, long InnerTicks, bool GcManaged, bool GcIl2);

    static long _frameTicks, _frameMax, _frameInnerMax;
    static Stat _frameWorst, _frameInner;
    readonly List<Frame> _frames = new(8192);
    int _lastGcM, _lastGcI;

    static readonly Dictionary<MethodBase, Stat> Stats = new();
    static HarmonyLib.Harmony _h;
    static MelonLogger.Instance _log;

    readonly List<float> _dt = new(8192);
    float _autoAt = -1, _endAt = -1;
    bool _running;
    string _scene = "", _qualityAtInit = "";
    readonly List<(string name, ProfilerRecorder rec)> _recs = new();
    readonly Dictionary<string, double> _recSum = new();
    int _gc0Managed, _gc0Il2;

    public override void OnInitializeMelon()
    {
        _log = LoggerInstance;
        _h = new HarmonyLib.Harmony("tldhacks.perfprobe");
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        if (_running) return;
        _scene = sceneName;
        _qualityAtInit = QualityText();
        string s = sceneName.ToLowerInvariant();
        _autoAt = (_autoDone || s.Contains("menu") || s.Contains("boot") || s.Contains("empty")) ? -1 : Time.realtimeSinceStartup + AutoDelay;
    }

    bool _autoDone;

    public override void OnUpdate()
    {
        float now = Time.realtimeSinceStartup;
        bool hot = Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F9);
        // a file named "start" in UserData\PerfProbe also starts a window, so a run needs no key press
        if (!_running && Time.frameCount % 60 == 0)
        {
            string flag = Path.Combine(MelonLoader.Utils.MelonEnvironment.UserDataDirectory, "PerfProbe", "start");
            if (File.Exists(flag)) { try { File.Delete(flag); } catch { } hot = true; }
        }
        if (!_running && (hot || (_autoAt > 0 && now >= _autoAt)))
        {
            _autoAt = -1;
            _autoDone = true;
            Begin();
            return;
        }
        if (!_running) return;
        _dt.Add(Time.unscaledDeltaTime);
        int gm = GC.CollectionCount(0), gi = SafeIl2Gc();
        _frames.Add(new Frame(Time.unscaledDeltaTime, _frameTicks, _frameWorst, _frameMax, _frameInner, _frameInnerMax, gm != _lastGcM, gi != _lastGcI));
        _lastGcM = gm; _lastGcI = gi;
        _frameTicks = 0; _frameMax = 0; _frameWorst = null; _frameInnerMax = 0; _frameInner = null;
        foreach (var (name, rec) in _recs)
        {
            try { _recSum[name] = _recSum.GetValueOrDefault(name) + rec.LastValue; } catch { }
        }
        if (now >= _endAt) End();
    }

    void Begin()
    {
        _running = true;
        _dt.Clear();
        _frames.Clear();
        Stats.Clear();
        _recSum.Clear();
        var sw = Stopwatch.StartNew();
        int n = Instrument();
        StartRecorders();
        _gc0Managed = GC.CollectionCount(0);
        try { _gc0Il2 = Il2CppSystem.GC.CollectionCount(0); } catch { }
        _lastGcM = _gc0Managed; _lastGcI = _gc0Il2;
        _endAt = Time.realtimeSinceStartup + Window;
        _log.Msg($"measuring {Window}s in {_scene}, {n} hooks wrapped in {sw.ElapsedMilliseconds} ms");
    }

    void End()
    {
        _running = false;
        _h.UnpatchSelf();
        foreach (var (_, rec) in _recs) try { rec.Dispose(); } catch { }
        string path = WriteReport();
        _recs.Clear();
        _log.Msg($"report: {path}");
    }

    // Wrap mod code that runs per frame: every Harmony patch method, plus Melon and injected MonoBehaviour update callbacks.
    static int Instrument()
    {
        var targets = new Dictionary<MethodBase, Stat>();
        foreach (var orig in HarmonyLib.Harmony.GetAllPatchedMethods().ToList())
        {
            var info = HarmonyLib.Harmony.GetPatchInfo(orig);
            if (info == null) continue;
            string tgt = $"{orig.DeclaringType?.Name}.{orig.Name}";
            void Add(IEnumerable<Patch> ps, string kind)
            {
                foreach (var p in ps)
                {
                    if (p.owner == _h.Id || p.PatchMethod == null) continue;
                    targets.TryAdd(p.PatchMethod, new Stat { Owner = p.PatchMethod.DeclaringType?.Assembly.GetName().Name, Label = $"{tgt} {kind} ({p.PatchMethod.DeclaringType?.Name}.{p.PatchMethod.Name})" });
                }
            }
            Add(info.Prefixes, "pre");
            Add(info.Postfixes, "post");
            Add(info.Finalizers, "fin");
        }

        string[] cb = { "OnUpdate", "OnLateUpdate", "OnFixedUpdate", "OnGUI" };
        foreach (var m in MelonBase.RegisteredMelons)
        {
            var t = m.GetType();
            if (t == typeof(Probe)) continue;
            foreach (var name in cb)
            {
                var mi = t.GetMethod(name, BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
                if (mi != null && mi.DeclaringType != typeof(MelonMod) && mi.DeclaringType != typeof(MelonBase) && mi.DeclaringType != typeof(MelonPlugin))
                {
                    targets.TryAdd(mi, new Stat { Owner = t.Assembly.GetName().Name, Label = $"{t.Name}.{name}" });
                    AddCallees(mi, targets, 1);
                }
            }
        }

        string[] mb = { "Update", "LateUpdate", "FixedUpdate", "OnGUI" };
        foreach (var m in MelonBase.RegisteredMelons)
        {
            Type[] types;
            try { types = m.MelonAssembly.Assembly.GetTypes(); } catch (ReflectionTypeLoadException e) { types = e.Types.Where(x => x != null).ToArray(); }
            foreach (var t in types)
            {
                if (t.IsGenericTypeDefinition || !typeof(MonoBehaviour).IsAssignableFrom(t)) continue;
                foreach (var name in mb)
                {
                    var mi = t.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly, null, Type.EmptyTypes, null);
                    if (mi != null) targets.TryAdd(mi, new Stat { Owner = t.Assembly.GetName().Name, Label = $"{t.Name}.{name} (MonoBehaviour)" });
                }
            }
        }

        foreach (var kv in targets) Stats[kv.Key] = kv.Value;
        var pre = new HarmonyMethod(typeof(Probe), nameof(Pre)) { priority = HarmonyLib.Priority.First };
        var post = new HarmonyMethod(typeof(Probe), nameof(Post)) { priority = HarmonyLib.Priority.Last };
        int ok = 0;
        string dir = Path.Combine(MelonLoader.Utils.MelonEnvironment.UserDataDirectory, "PerfProbe");
        Directory.CreateDirectory(dir);
        // Written line by line before each patch, so a hard crash still names the last method.
        using var trace = new StreamWriter(Path.Combine(dir, "last_wrap.txt")) { AutoFlush = true };
        foreach (var mi in targets.Keys)
        {
            if (mi.IsAbstract || mi.ContainsGenericParameters) { Stats.Remove(mi); continue; }
            trace.WriteLine($"{mi.DeclaringType?.FullName}.{mi.Name}");
            try { _h.Patch(mi, prefix: pre, postfix: post); ok++; }
            catch (Exception e) { Stats.Remove(mi); _log.Warning($"skip {mi.DeclaringType?.Name}.{mi.Name}: {e.GetType().Name}"); }
        }
        return ok;
    }

    // Wrap what the Melon update callbacks call, so a slow periodic tick shows up by name.
    // ponytail: scans raw IL bytes for call opcodes; a stray 0x28/0x6F inside an operand may wrap an unrelated method, which only adds a harmless timer.
    static void AddCallees(MethodInfo root, Dictionary<MethodBase, Stat> targets, int depth)
    {
        byte[] il;
        try { il = root.GetMethodBody()?.GetILAsByteArray(); } catch { return; }
        if (il == null) return;
        var asm = root.DeclaringType.Assembly;
        for (int i = 0; i + 4 < il.Length; i++)
        {
            if (il[i] != 0x28 && il[i] != 0x6F) continue;
            MethodBase m;
            try { m = root.Module.ResolveMethod(BitConverter.ToInt32(il, i + 1)); } catch { continue; }
            if (m is not MethodInfo mi || !SafeToWrap(mi, asm)) continue;
            if (targets.ContainsKey(mi)) continue;
            targets[mi] = new Stat { Owner = asm.GetName().Name, Label = $"{mi.DeclaringType.Name}.{mi.Name} (inside)", Inner = true };
            if (depth > 1) AddCallees(mi, targets, depth - 1);
        }
    }

    // A crash inside RuntimeHelpers.PrepareMethod is an ExecutionEngineException that no catch can stop
    // (14:28 crash dump: a generic instantiation found by the IL scan). Only plain static or managed-class methods pass.
    static bool SafeToWrap(MethodInfo mi, Assembly asm)
    {
        var t = mi.DeclaringType;
        if (t == null || t.Assembly != asm || mi.IsAbstract || mi.IsGenericMethod || mi.ContainsGenericParameters) return false;
        if (t.IsGenericType || t.ContainsGenericParameters || t.IsValueType) return false;
        if (typeof(Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase).IsAssignableFrom(t)) return false;
        if ((mi.MethodImplementationFlags & (MethodImplAttributes.InternalCall | MethodImplAttributes.Runtime)) != 0 || (mi.Attributes & MethodAttributes.PinvokeImpl) != 0) return false;
        if (mi.ReturnType.IsPointer || mi.ReturnType.IsByRef || mi.ReturnType.IsByRefLike) return false;
        foreach (var p in mi.GetParameters())
            if (p.ParameterType.IsPointer || p.ParameterType.IsByRef || p.ParameterType.IsByRefLike) return false;
        try { return mi.GetMethodBody() != null; } catch { return false; }
    }

    static void Pre(out long __state) => __state = Stopwatch.GetTimestamp();

    static void Post(long __state, MethodBase __originalMethod)
    {
        long d = Stopwatch.GetTimestamp() - __state;
        if (__originalMethod != null && Stats.TryGetValue(__originalMethod, out var s))
        {
            Interlocked.Add(ref s.Ticks, d);
            Interlocked.Increment(ref s.Calls);
            if (d > s.Max) s.Max = d;
            if (s.Inner) { if (d > _frameInnerMax) { _frameInnerMax = d; _frameInner = s; } }
            else
            {
                _frameTicks += d;
                if (d > _frameMax) { _frameMax = d; _frameWorst = s; }
            }
        }
    }

    void StartRecorders()
    {
        var want = new (ProfilerCategory cat, string name)[]
        {
            (ProfilerCategory.Internal, "CPU Main Thread Frame Time"),
            (ProfilerCategory.Internal, "CPU Render Thread Frame Time"),
            (ProfilerCategory.Internal, "GPU Frame Time"),
            (ProfilerCategory.Render, "Batches Count"),
            (ProfilerCategory.Render, "SetPass Calls Count"),
            (ProfilerCategory.Render, "Draw Calls Count"),
            (ProfilerCategory.Render, "Triangles Count"),
            (ProfilerCategory.Render, "Shadow Casters Count"),
            (ProfilerCategory.Render, "Visible Skinned Meshes Count"),
            (ProfilerCategory.Memory, "GC Allocated In Frame"),
        };
        string[] markers =
        {
            "PlayerLoop", "BehaviourUpdate", "LateBehaviourUpdate", "FixedBehaviourUpdate", "CoroutinesDelayedCalls",
            "Camera.Render", "Culling", "Shadows.RenderShadowmap", "RenderForward.RenderLoopJob", "Drawing", "PostProcess.Render",
            "Physics.Simulate", "Physics.FetchResults", "Animators.Update", "Director.ProcessFrame", "ParticleSystem.Update",
            "UpdateRendererBoundingVolumes", "Gfx.WaitForPresentOnGfxThread", "Gfx.WaitForRenderThread", "WaitForTargetFPS",
            "GC.Collect", "GC.Alloc", "Terrain.Heightmap.RenderStep2", "Terrain.Details.Render", "Terrain.Trees.Render",
            "Update.ScriptRunBehaviourUpdate", "PreLateUpdate.ScriptRunBehaviourLateUpdate", "FixedUpdate.PhysicsFixedUpdate",
            "PostLateUpdate.FinishFrameRendering", "PostLateUpdate.UpdateAllRenderers", "PreUpdate.AIUpdatePostScript",
            "Navmesh.Update", "Audio.Update", "UIEvents.WindowUpdate",
        };
        foreach (var m in markers)
        {
            try
            {
                var rec = MakeRecorder(ProfilerCategory.Any, m);
                if (rec.Valid) _recs.Add(("[m] " + m, rec));
            }
            catch { }
        }
        _log.Msg($"markers available: {_recs.Count(r => r.name.StartsWith("[m]"))}/{markers.Length}");
        foreach (var (cat, name) in want)
        {
            try
            {
                var rec = MakeRecorder(cat, name);
                if (rec.Valid) _recs.Add((name, rec));
                else _log.Msg($"counter not available: {name}");
            }
            catch (Exception e) { _log.Msg($"counter failed: {name} ({e.GetType().Name})"); }
        }
    }

    static unsafe ProfilerRecorder MakeRecorder(ProfilerCategory cat, string name)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(name);
        fixed (byte* p = bytes)
        {
            var handle = ProfilerRecorderHandle.GetByName__Unmanaged(cat, p, bytes.Length);
            // 25 = StartImmediately | WrapAround | SumAllSamplesInFrame (Unity's Default)
            return ProfilerRecorder.Create(handle, 1, (ProfilerRecorderOptions)25);
        }
    }

    static string QualityText()
    {
        try
        {
            var r = Screen.currentResolution;
            return $"res {Screen.width}x{Screen.height} fullscreen={Screen.fullScreenMode} refresh={r.refreshRateRatio.value:0.##}Hz vSync={QualitySettings.vSyncCount} targetFps={Application.targetFrameRate}\n" +
                   $"lodBias={QualitySettings.lodBias} maxLOD={QualitySettings.maximumLODLevel} shadows={QualitySettings.shadows} shadowRes={QualitySettings.shadowResolution} cascades={QualitySettings.shadowCascades} shadowDist={QualitySettings.shadowDistance} " +
                   $"pixelLights={QualitySettings.pixelLightCount} aniso={QualitySettings.anisotropicFiltering} aa={QualitySettings.antiAliasing} mipStreaming={QualitySettings.streamingMipmapsActive} mipBudget={QualitySettings.streamingMipmapsMemoryBudget} " +
                   $"masterTexLimit={QualitySettings.globalTextureMipmapLimit} softParticles={QualitySettings.softParticles} realtimeReflProbes={QualitySettings.realtimeReflectionProbes} frameTiming={FrameTimingManager.IsFeatureEnabled()}";
        }
        catch (Exception e) { return "quality read failed: " + e.Message; }
    }

    static string SceneCounts()
    {
        try
        {
            var lights = UnityEngine.Object.FindObjectsOfType<Light>();
            int on = 0, shadowed = 0;
            foreach (var l in lights)
            {
                if (!l.isActiveAndEnabled) continue;
                on++;
                if (l.shadows != LightShadows.None) shadowed++;
            }
            var rends = UnityEngine.Object.FindObjectsOfType<Renderer>();
            int vis = 0, casters = 0;
            foreach (var r in rends)
            {
                if (!r.enabled) continue;
                if (r.isVisible) vis++;
                if (r.shadowCastingMode != UnityEngine.Rendering.ShadowCastingMode.Off) casters++;
            }
            return $"lights active={on} withShadows={shadowed} | renderers={rends.Length} visible={vis} castShadows={casters} | cameras={Camera.allCamerasCount}";
        }
        catch (Exception e) { return "scene count failed: " + e.Message; }
    }

    string WriteReport()
    {
        int frames = Math.Max(_dt.Count, 1);
        var sorted = _dt.OrderBy(x => x).ToArray();
        float P(double q) => sorted.Length == 0 ? 0 : sorted[Math.Min(sorted.Length - 1, (int)(q * sorted.Length))] * 1000f;
        double avg = _dt.Count == 0 ? 0 : _dt.Average() * 1000;
        double tickMs = 1000.0 / Stopwatch.Frequency;
        var sb = new StringBuilder();
        sb.AppendLine($"PerfProbe {DateTime.Now:yyyy-MM-dd HH:mm:ss} scene={_scene} frames={_dt.Count}");
        sb.AppendLine($"frame ms avg={avg:0.00} (fps {1000 / Math.Max(avg, 0.001):0.0}) p50={P(.5):0.00} p95={P(.95):0.00} p99={P(.99):0.00} max={P(1):0.00} hitches>50ms={_dt.Count(x => x > .05f)}");
        sb.AppendLine($"GC gen0 managed={GC.CollectionCount(0) - _gc0Managed} il2cpp={SafeIl2Gc() - _gc0Il2}");
        foreach (var kv in _recSum)
        {
            double v = kv.Value / frames;
            sb.AppendLine(kv.Key.Contains("Time") || kv.Key.StartsWith("[m]") ? $"  {kv.Key}: {v / 1e6:0.00} ms/frame" : $"  {kv.Key}: {v:0} /frame");
        }
        sb.AppendLine("quality at scene init (before other mods): " + _qualityAtInit);
        sb.AppendLine("quality now: " + QualityText());
        sb.AppendLine(SceneCounts());
        sb.AppendLine("game quality: " + GameQualityText());

        var stats = Stats.Values.Where(s => s.Calls > 0).ToList();
        var outer = stats.Where(s => !s.Inner).ToList();
        double total = outer.Sum(s => s.Ticks) * tickMs / frames;
        long calls = outer.Sum(s => s.Calls);
        sb.AppendLine($"\nwrapped mod code: {total:0.000} ms/frame, {calls / (double)frames:0} calls/frame (nested hooks count twice; wrapper adds ~0.1-0.3 us per call)");
        sb.AppendLine("\nby mod (ms/frame):");
        foreach (var g in outer.GroupBy(s => s.Owner).Select(g => (g.Key, ms: g.Sum(s => s.Ticks) * tickMs / frames, c: g.Sum(s => s.Calls) / (double)frames)).OrderByDescending(x => x.ms))
            sb.AppendLine($"  {g.ms,8:0.000}  {g.c,8:0.0} calls  {g.Key}");
        sb.AppendLine("\ntop hooks (ms/frame, calls/frame, us/call):");
        foreach (var s in stats.OrderByDescending(s => s.Ticks).Take(60))
            sb.AppendLine($"  {s.Ticks * tickMs / frames,8:0.000} {s.Calls / (double)frames,8:0.0} {s.Ticks * tickMs * 1000 / s.Calls,8:0.0}  [{s.Owner}] {s.Label}");

        sb.AppendLine("\nworst single call (us):");
        foreach (var s in stats.OrderByDescending(s => s.Max).Take(25))
            sb.AppendLine($"  {s.Max * tickMs * 1000,10:0}  [{s.Owner}] {s.Label}");

        // skip the first frames: wrapping the hooks itself stalls the game
        var fr = _frames.Skip(3).ToList();
        float p50 = P(.5) / 1000f, lim = Math.Max(3 * p50, 0.025f);
        var hitches = fr.Where(f => f.Dt > lim).ToList();
        sb.AppendLine($"\nhitches > {lim * 1000:0.0} ms: {hitches.Count} (with managed GC {hitches.Count(f => f.GcManaged)}, with il2cpp GC {hitches.Count(f => f.GcIl2)}); GC frames overall managed={fr.Count(f => f.GcManaged)} il2cpp={fr.Count(f => f.GcIl2)}");
        sb.AppendLine($"avg mod ms in hitch frames={(hitches.Count == 0 ? 0 : hitches.Average(f => f.ModTicks) * tickMs):0.000}, in all frames={(fr.Count == 0 ? 0 : fr.Average(f => f.ModTicks) * tickMs):0.000}");
        foreach (var f in hitches.OrderByDescending(f => f.Dt).Take(40))
            sb.AppendLine($"  {f.Dt * 1000,7:0.0} ms  mods {f.ModTicks * tickMs,6:0.00} ms  gc[{(f.GcManaged ? "M" : "-")}{(f.GcIl2 ? "I" : "-")}]  worst {f.WorstTicks * tickMs,6:0.00} ms [{f.Worst?.Owner}] {f.Worst?.Label}" + (f.Inner == null ? "" : $"  | inside: {f.InnerTicks * tickMs:0.00} ms {f.Inner.Label}"));

        string dir = Path.Combine(MelonLoader.Utils.MelonEnvironment.UserDataDirectory, "PerfProbe");
        Directory.CreateDirectory(dir);
        string path = Path.Combine(dir, $"report_{DateTime.Now:MMdd_HHmmss}_{_scene}.txt");
        File.WriteAllText(path, sb.ToString());
        return path;
    }

    static string GameQualityText()
    {
        try
        {
            var q = Il2Cpp.GameManager.GetQualitySettingsManager()?.GetCurrentQualitySettings();
            if (q == null) return "none";
            var parts = new List<string> { "level=" + Il2Cpp.QualitySettingsManager.m_CurrentQuality };
            foreach (var pi in typeof(Il2Cpp.QualityLevelSettings).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                if (pi.Name.StartsWith("m_")) try { parts.Add($"{pi.Name[2..]}={pi.GetValue(q)}"); } catch { }
            return string.Join(" ", parts);
        }
        catch (Exception e) { return "read failed: " + e.Message; }
    }

    int SafeIl2Gc() { try { return Il2CppSystem.GC.CollectionCount(0); } catch { return _gc0Il2; } }
}
