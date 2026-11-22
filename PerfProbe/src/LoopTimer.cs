using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.LowLevel;

namespace PerfProbe;

// Times each Unity engine stage: a timestamp callback goes in front of every player loop subsystem,
// so the gap between two callbacks is the cost of the subsystem between them.
static class LoopTimer
{
    public class Stage { public string Name; public long Ticks, Calls; }

    public static readonly List<Stage> Stages = new();
    static readonly List<object> Keep = new();
    static PlayerLoopSystem _orig;
    static int _last = -1;
    static long _lastTs;

    public static int Install()
    {
        Stages.Clear();
        Keep.Clear();
        _last = -1;
        _orig = PlayerLoop.GetCurrentPlayerLoop();
        var root = PlayerLoop.GetCurrentPlayerLoop();
        var tops = root.subSystemList;
        for (int i = 0; i < tops.Length; i++)
        {
            var top = tops[i];
            var subs = top.subSystemList;
            if (subs == null || subs.Length == 0) continue;
            string topName = NameOf(top);
            var list = new Il2CppReferenceArray<PlayerLoopSystem>(subs.Length * 2 + 1);
            for (int j = 0; j < subs.Length; j++)
            {
                list[2 * j] = Marker($"{topName}.{NameOf(subs[j])}");
                list[2 * j + 1] = subs[j];
            }
            // closes the last stage of this group; the gap after it is loop overhead and is not counted
            list[subs.Length * 2] = Marker(null);
            top.subSystemList = list;
            tops[i] = top;
        }
        root.subSystemList = tops;
        PlayerLoop.SetPlayerLoop(root);
        return Stages.Count;
    }

    public static void Uninstall()
    {
        if (_orig != null) PlayerLoop.SetPlayerLoop(_orig);
        _orig = null;
    }

    static string NameOf(PlayerLoopSystem s)
    {
        try { return s.type?.Name ?? "?"; } catch { return "?"; }
    }

    static PlayerLoopSystem Marker(string name)
    {
        int id = Stages.Count;
        Stages.Add(new Stage { Name = name });
        Action a = () => Hit(id);
        PlayerLoopSystem.UpdateFunction f = a;
        Keep.Add(a);
        Keep.Add(f);
        return new PlayerLoopSystem { type = Il2CppType.Of<PlayerLoop>(), updateDelegate = f };
    }

    static void Hit(int id)
    {
        long now = Stopwatch.GetTimestamp();
        if (_last >= 0)
        {
            var s = Stages[_last];
            if (s.Name != null) { s.Ticks += now - _lastTs; s.Calls++; }
        }
        _last = id;
        _lastTs = Stopwatch.GetTimestamp();
    }
}
