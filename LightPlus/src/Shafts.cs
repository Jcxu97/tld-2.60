using System;
using System.IO;
using System.Runtime.InteropServices;
using MelonLoader;
using UnityEngine;
using UnityEngine.Rendering;
using Il2Cpp;
using NL = System.Runtime.InteropServices.NativeLibrary;

namespace LightPlus;

// Drives lpnative.dll: renders a sun-aligned depth map and queues the composite pass on the world camera.
class Shafts
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] delegate void InitFn([MarshalAs(UnmanagedType.LPWStr)] string dir);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] delegate void SetShadowFn(IntPtr tex);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] delegate IntPtr EventFuncFn();
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] delegate float GpuMsFn();
    GpuMsFn gpuMs;
    public float GpuMs() => gpuMs != null ? gpuMs() : -1f;

    const int Floats = 256, Slots = 8;
    readonly MelonLogger.Instance log;
    SetShadowFn setShadow;
    IntPtr eventFn, ring;
    int slot, frame;
    readonly float[] p = new float[Floats];

    Camera shadowCam, hooked;
    RenderTexture shadowRT;
    Shader depthShader;
    IntPtr shadowPtr;
    CommandBuffer cbMask;
    Light maskLight;
    Renderer[] noShadow = new Renderer[0];
    float noShadowAt = -1f;
    Vector3 noShadowPos;
    readonly System.Diagnostics.Stopwatch sw = new();
    double msSum;
    int msCount;

    public bool Ready => eventFn != IntPtr.Zero;

    public Shafts(MelonLogger.Instance log, string dir)
    {
        this.log = log;
        try
        {
            var h = NL.Load(Path.Combine(dir, "lpnative.dll"));
            Marshal.GetDelegateForFunctionPointer<InitFn>(NL.GetExport(h, "LP_Init"))(dir);
            setShadow = Marshal.GetDelegateForFunctionPointer<SetShadowFn>(NL.GetExport(h, "LP_SetShadow"));
            eventFn = Marshal.GetDelegateForFunctionPointer<EventFuncFn>(NL.GetExport(h, "LP_EventFunc"))();
            gpuMs = Marshal.GetDelegateForFunctionPointer<GpuMsFn>(NL.GetExport(h, "LP_GpuMs"));
            ring = Marshal.AllocHGlobal(Floats * 4 * Slots);
        }
        catch (Exception e) { log.Warning("lpnative.dll not loaded: " + e.Message); }
    }

    // event ids in lpnative: 1 shafts, 2 save depth, 3 save gbuffer, 4 relight
    readonly int[] ids = { 3, 4, 2, 1 };
    readonly CommandBuffer[] cbs = new CommandBuffer[4];
    readonly CameraEvent[] hookedAt = new CameraEvent[4];

    public void Update(Cfg c, Camera world, Light sun, Light moon, bool on)
    {
        if (!Ready || world == null) return;
        var want = new[] { (CameraEvent)c.GBufferEvent, (CameraEvent)c.RelightEvent, (CameraEvent)c.ShaftDepthEvent, (CameraEvent)c.ShaftEvent };
        bool moved = hooked != world;
        for (int i = 0; i < 4; i++) moved |= hookedAt[i] != want[i];
        if (moved)
        {
            for (int i = 0; i < 4; i++)
            {
                if (hooked != null && cbs[i] != null) try { hooked.RemoveCommandBuffer(hookedAt[i], cbs[i]); } catch { }
                cbs[i] ??= new CommandBuffer { name = "LightPlus " + ids[i] };
                world.AddCommandBuffer(want[i], cbs[i]);
                hookedAt[i] = want[i];
            }
            hooked = world;
            log.Msg($"gbuffer at {want[0]}, relight at {want[1]}, depth at {want[2]}, shafts at {want[3]}");
        }
        foreach (var b in cbs) b.Clear();
        cbMask?.Clear();
        if (!on || !(c.Shafts || c.Relight || c.Grade || c.Reflect) || sun == null) return;
        float sunUp = -sun.transform.forward.y;
        var src = sunUp > 0f || moon == null ? sun : moon;
        if (!src.isActiveAndEnabled) return;

        // relight takes its shadow from the game now, so only the shafts need our own sun map
        // ponytail: the sun map is redrawn every few frames to save CPU; shafts lag a little when the sun or player moves fast
        // the plugin takes its D3D device from the sun map texture, so make a tiny one when the shafts are off
        if (!c.Shafts && shadowPtr == IntPtr.Zero)
        {
            shadowRT = new RenderTexture(16, 16, 24, RenderTextureFormat.Depth) { name = "LightPlus_Shadow" };
            shadowRT.Create();
            shadowPtr = shadowRT.GetNativeTexturePtr();
            setShadow(shadowPtr);
        }
        if (c.Shafts && (shadowCam == null || frame % Math.Max(c.ShaftShadowEvery, 1) == 0)) RenderShadow(c, world, src);

        var t = world.transform;
        var vp = GL.GetGPUProjectionMatrix(world.projectionMatrix, true) * world.worldToCameraMatrix;
        Put(0, vp.inverse);
        var svp = shadowCam == null ? Matrix4x4.identity : GL.GetGPUProjectionMatrix(shadowCam.projectionMatrix, true) * shadowCam.worldToCameraMatrix;
        Put(16, svp);
        Vector3 toLight = -src.transform.forward;
        Set(32, t.position.x, t.position.y, t.position.z, Time.time);
        Set(36, toLight.x, toLight.y, toLight.z, sunUp);
        Set(40, c.ShaftStrength, c.ShaftSceneIntensity, 0f, 1f);
        Set(44, c.ShaftMaxDistance, c.ShaftShadowRange, c.ShaftSamples, c.ShaftDebug);
        Set(48, c.ShaftFlipY ? 1 : 0, c.ShaftShadowFlipY ? 1 : 0, c.ShaftShadowBias, frame++);
        int hour = 12;
        try { hour = GameManager.GetTimeOfDayComponent().GetHour(); } catch { }
        Set(52, hour >= 12 ? 1f : 0f, world.nearClipPlane, c.Shafts ? 1f : 0f, c.Grade ? 1f : 0f);
        // slots 15 and 16 (floats 60..67) are written by the plugin
        Set(56, c.Relight ? 1f : 0f, c.Reflect ? 1f : 0f, 0f, 0f);
        Set(68, c.RelightTint, c.RelightSpecular, c.RelightContrast, c.RelightDebug);
        Set(72, c.GradeMix, c.GradeSplit, c.GradeContrast, c.GradeSunBoost);
        Set(76, c.GradeVibrance, c.GradeVignette, c.GradeSunGlow, 0f);
        Put(80, vp);
        Set(96, c.ReflectStrength, c.ReflectSmooth, c.ReflectDistance, c.Reflect ? 1f : 0f);

        slot = (slot + 1) % Slots;
        var ptr = ring + slot * Floats * 4;
        Marshal.Copy(p, 0, ptr, Floats);
        // the game's own screen-space sun shadow: the relight pass uses it so its shadows match what the game draws
        if (maskLight != src)
        {
            if (maskLight != null) try { maskLight.RemoveCommandBuffer(LightEvent.AfterScreenspaceMask, cbMask); } catch { }
            cbMask ??= new CommandBuffer { name = "LightPlus mask" };
            src.AddCommandBuffer(LightEvent.AfterScreenspaceMask, cbMask);
            maskLight = src;
            log.Msg($"shadow mask hooked on {src.name}");
        }
        cbMask.IssuePluginEventAndData(eventFn, 5, ptr);
        // the gbuffer event must see Unity's own MRT binding, so it gets no SetRenderTarget
        cbs[0].IssuePluginEventAndData(eventFn, 3, ptr);
        cbs[2].SetRenderTarget(BuiltinRenderTextureType.CameraTarget);
        cbs[2].IssuePluginEventAndData(eventFn, 2, ptr);
        if (c.Relight)
        {
            cbs[1].SetRenderTarget(BuiltinRenderTextureType.CameraTarget);
            cbs[1].IssuePluginEventAndData(eventFn, 4, ptr);
        }
        if (c.Shafts || c.Grade || c.Reflect)
        {
            cbs[3].SetRenderTarget(BuiltinRenderTextureType.CameraTarget);
            cbs[3].IssuePluginEventAndData(eventFn, 1, ptr);
        }
    }

    void RenderShadow(Cfg c, Camera world, Light sun)
    {
        int res = Mathf.Clamp(c.ShaftShadowRes, 256, 8192);
        if (shadowRT == null || shadowRT.width != res)
        {
            if (shadowRT != null) shadowRT.Release();
            shadowRT = new RenderTexture(res, res, 24, RenderTextureFormat.Depth) { name = "LightPlus_Shadow" };
            shadowRT.Create();
            shadowPtr = IntPtr.Zero;
        }
        if (shadowCam == null)
        {
            var go = new GameObject("LightPlus_ShadowCam");
            UnityEngine.Object.DontDestroyOnLoad(go);
            shadowCam = go.AddComponent<Camera>();
            shadowCam.enabled = false;
            shadowCam.orthographic = true;
            shadowCam.aspect = 1f;
            shadowCam.clearFlags = CameraClearFlags.Depth;
            shadowCam.renderingPath = RenderingPath.Forward;
            shadowCam.allowHDR = false;
            shadowCam.allowMSAA = false;
            shadowCam.useOcclusionCulling = false;
            depthShader = Shader.Find("Hidden/Internal-DepthNormalsTexture");
            log.Msg($"shadow camera made, depth shader {(depthShader != null ? "found" : "missing, using full render")}");
        }
        float r = c.ShaftShadowRange, back = 500f;
        shadowCam.targetTexture = shadowRT;
        shadowCam.cullingMask = world.cullingMask;
        shadowCam.orthographicSize = r;
        shadowCam.nearClipPlane = 1f;
        shadowCam.farClipPlane = back * 2f;

        var rot = sun.transform.rotation;
        var center = world.transform.position + world.transform.forward * (r * 0.4f);
        // snap to whole texels in light space so the map does not shimmer when the player moves
        var ls = Quaternion.Inverse(rot) * center;
        float texel = 2f * r / res;
        ls.x = Mathf.Floor(ls.x / texel) * texel;
        ls.y = Mathf.Floor(ls.y / texel) * texel;
        center = rot * ls;
        shadowCam.transform.SetPositionAndRotation(center - sun.transform.forward * back, rot);

        // 0: replacement by RenderType tag, 1: replacement for every object, 2: full render with the real materials
        int how = depthShader == null ? 2 : c.ShaftShadowMode;
        sw.Restart();
        HideNoShadow(world.transform.position, true);
        if (how == 0) shadowCam.RenderWithShader(depthShader, "RenderType");
        else if (how == 1) shadowCam.RenderWithShader(depthShader, "");
        else shadowCam.Render();
        HideNoShadow(world.transform.position, false);
        sw.Stop();
        msSum += sw.Elapsed.TotalMilliseconds;
        if (++msCount == 300)
        {
            log.Msg($"shadow map mode {how}: {msSum / msCount:F2} ms CPU per frame");
            msSum = 0; msCount = 0;
        }

        var np = shadowRT.GetNativeTexturePtr();
        if (np != shadowPtr) { shadowPtr = np; setShadow(np); }
    }

    // Renderers the game marks as not casting shadows (sky dome, clouds, fog cards) must stay out of the sun map too.
    // ponytail: the list is rebuilt by a full scene scan when the player moves far or every 30 s; a scene-load hook would be cheaper
    void HideNoShadow(Vector3 at, bool hide)
    {
        if (hide && (Time.realtimeSinceStartup > noShadowAt || (at - noShadowPos).sqrMagnitude > 200f * 200f))
        {
            var keep = new System.Collections.Generic.List<Renderer>();
            Renderer big = null;
            foreach (var r in UnityEngine.Object.FindObjectsOfType<Renderer>())
            {
                // only the huge ones (sky horizon, cloud domes); toggling all 8000+ small non-casters cost 1.8 ms CPU a frame
                if (r == null || !r.enabled || r.forceRenderingOff || r.shadowCastingMode != ShadowCastingMode.Off || r.bounds.size.sqrMagnitude < 300f * 300f) continue;
                keep.Add(r);
                if (big == null || r.bounds.size.sqrMagnitude > big.bounds.size.sqrMagnitude) big = r;
            }
            noShadow = keep.ToArray();
            noShadowAt = Time.realtimeSinceStartup + 30f;
            noShadowPos = at;
            log.Msg($"sun map skips {noShadow.Length} non-casting renderers, largest {(big != null ? big.name + " " + big.bounds.size.ToString("F0") : "none")}");
        }
        foreach (var r in noShadow) if (r != null) r.forceRenderingOff = hide;
    }

    void Put(int at, Matrix4x4 m)
    {
        for (int r = 0; r < 4; r++)
            for (int col = 0; col < 4; col++)
                p[at + r * 4 + col] = m[r, col];
    }

    void Set(int at, float x, float y, float z, float w) { p[at] = x; p[at + 1] = y; p[at + 2] = z; p[at + 3] = w; }
}
