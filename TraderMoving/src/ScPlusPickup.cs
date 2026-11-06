using System;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

// 装修模式里对无线电或交易箱点"拿起"时,改用我们的抱起。
//
// SCPlus 把 DLC 场景里的无线电和交易箱做成了装饰品,但在它自己的 DecorationItem.OnPickup
// 前缀里标成不许拿起,弹 "This object cannot be picked up"。这版 Harmony 在一个前缀返回 false 以后
// 照样跑后面的前缀,所以在 OnPickup 上再挂前缀拦不住它,只能直接补 SCPlus 的那个前缀。
// 当帧先记下,下一帧退出装修模式,等玩家能动了再抱起。
internal static class ScPlusPickup
{
    private static GameObject _pending;
    private static TargetType _pendingType;
    private static float _pendingSince;
    private static bool _stopAsked;

    // SCPlusFix++(程序集 SCPlusFix++,命名空间 SCPlusPP)在的时候,旧版 SafehouseCustomizationPlus.dll 留在 Mods 里也被它拦着没启动,所以先找 SCPlusPP
    internal static Type FindType(string name)
    {
        foreach (var ns in new[] { "SCPlusPP.", "SCPlus." })
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
            {
                var t = a.GetType(ns + name, false);
                if (t != null) return t;
            }
        return null;
    }

    internal static void Install(HarmonyLib.Harmony harmony)
    {
        try
        {
            var t = FindType("DecorationPatches+PreventPickingUp");
            var m = t?.GetMethod("Prefix", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (m == null)
            {
                ModMain.Log?.Msg("[TraderMoving] 没装 SCPlus 或它改了结构,装修模式里的拿起不接管");
                return;
            }
            harmony.Patch(m, prefix: new HarmonyMethod(typeof(ScPlusPickup).GetMethod(nameof(Prefix), BindingFlags.Static | BindingFlags.NonPublic)));
            ModMain.Log?.Msg($"[TraderMoving] 已接管装修模式里无线电和交易箱的拿起({t.Assembly.GetName().Name})");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 接管 SCPlus 拿起失败: {ex.Message}"); }
    }

    // SCPlus 前缀的参数名本身就叫 __instance,这里拿不到,用 __args 取
    private static bool Prefix(object[] __args, ref bool __result)
    {
        try
        {
            if (__args == null || __args.Length == 0 || __args[0] is not DecorationItem deco || deco == null) return true;
            var go = ((Component)deco).gameObject;

            GameObject root = null;
            var type = TargetType.None;
            var radio = go.GetComponentInChildren<TraderRadio>(true);
            if (radio != null) { root = ((Component)radio).gameObject; type = TargetType.VanillaRadio; }
            else
            {
                var box = go.GetComponentInChildren<ExchangeBox>(true);
                if (box != null) { root = ((Component)box).gameObject; type = TargetType.VanillaBox; }
            }
            if (root == null || !CarryState.KindEnabled(CarryTarget.KindOf(type)) || CarryState.IsCarrying) return true;

            __result = false;   // 等于 SCPlus 前缀返回 false:原版 OnPickup 不跑
            if (CarryState.PickUpBlocked(root, type)) return false;   // 已经提示了原因,不退出装修模式

            _pending = root;
            _pendingType = type;
            _pendingSince = Time.time;
            _stopAsked = false;
            ModMain.Log?.Msg($"[TraderMoving] 装修模式里拿起 {type},退出装修模式后抱起");
            return false;       // SCPlus 前缀本身也不跑,不弹"不能拿起"
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[TraderMoving] 装修模式拿起异常: {ex.Message}");
            return true;
        }
    }

    internal static void Tick()
    {
        if (_pending == null) return;
        if (Time.time - _pendingSince > 5f)
        {
            _pending = null;
            CarryState.Refuse("没能退出装修模式,先手动退出再看着它按 Y 选中、右键抱起");
            return;
        }
        if (ModMain.InCustomizing())
        {
            if (!_stopAsked)
            {
                _stopAsked = true;
                try { GameManager.GetSafehouseManager()?.TryStopCustomizing(); } catch { }
            }
            return;
        }
        if (ModMain.BusyElsewhere()) return;

        var target = _pending;
        var type = _pendingType;
        _pending = null;
        if (target != null) CarryState.TryPickUp(target, type);
    }

    internal static void Reset() => _pending = null;
}
