using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(PerfFix.ModMain), "PerfFix", "1.0.0", "TldHacks")]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonPriority(1000)]

namespace PerfFix;

// Cuts per-frame CPU cost of other mods without changing what they compute.
public class ModMain : MelonMod
{
    internal static HarmonyLib.Harmony H;
    internal static MelonLogger.Instance Log;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;
        H = new HarmonyLib.Harmony("tldhacks.perffix");
    }

    // Other mods apply their [HarmonyPatch] classes during their own init, so wait until all melons are up.
    public override void OnLateInitializeMelon()
    {
        Try("Forager's Delight carry bonus", ForagerCarryCache.Apply);
    }

    static void Try(string name, Func<bool> apply)
    {
        try { Log.Msg(apply() ? $"on: {name}" : $"skipped (mod not found): {name}"); }
        catch (Exception e) { Log.Warning($"failed: {name}: {e}"); }
    }

    internal static MethodInfo FindPatch(MethodBase target, string patchTypeFullName)
    {
        var info = HarmonyLib.Harmony.GetPatchInfo(target);
        return info?.Postfixes.Concat(info.Prefixes).Select(p => p.PatchMethod)
            .FirstOrDefault(m => m.DeclaringType?.FullName == patchTypeFullName);
    }
}

// Forager's Delight adds a clothing bonus in a postfix on GetCarryCapacityKGBuff. The game calls that
// method ~44 times per frame and each run reads 6 slots and compares ~40 Il2Cpp names (~15 us).
// Worn clothing cannot change within one frame, so run the original postfix once per frame and reuse its delta.
static class ForagerCarryCache
{
    delegate void Postfix(PlayerManager instance, ref ItemWeight result);

    static Postfix _orig;
    static int _frame = -1;
    static IntPtr _inst;
    static long _delta;

    public static bool Apply()
    {
        var target = AccessTools.Method(typeof(PlayerManager), nameof(PlayerManager.GetCarryCapacityKGBuff));
        var patch = ModMain.FindPatch(target, "ForagersDelightMod.CarryCapacityBuffManager+ApplyCarryCapacityBuff");
        if (patch == null) return false;
        _orig = patch.CreateDelegate<Postfix>();
        var owner = HarmonyLib.Harmony.GetPatchInfo(target).Postfixes.First(p => p.PatchMethod == patch).owner;
        new HarmonyLib.Harmony(owner).Unpatch(target, patch);
        ModMain.H.Patch(target, postfix: new HarmonyMethod(typeof(ForagerCarryCache), nameof(Post)));
        return true;
    }

    static void Post(PlayerManager __instance, ref ItemWeight __result)
    {
        int f = Time.frameCount;
        IntPtr p = __instance == null ? IntPtr.Zero : __instance.Pointer;
        if (f != _frame || p != _inst)
        {
            long before = __result.m_Units;
            _orig(__instance, ref __result);
            long d = __result.m_Units - before;
            if (d != _delta) ModMain.Log.Msg($"Forager's Delight carry bonus now {d} units");
            _delta = d;
            _frame = f;
            _inst = p;
        }
        else __result.m_Units += _delta;
    }
}
