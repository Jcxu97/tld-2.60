using System;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

internal enum CarryKind { None, Radio, ExchangeBox }

internal enum TargetType { None, VanillaRadio, PortableRadio, VanillaBox, MovedBox }

// 找准星指着的东西。先认自己放的两样(按根物体名字),再认原版的(按组件)。
internal static class CarryTarget
{
    internal const float Range = 3f;

    internal static bool UnderCrosshair(out GameObject root, out TargetType type)
    {
        root = null;
        type = TargetType.None;
        try
        {
            var cam = GameManager.GetMainCamera();
            if (cam != null)
            {
                var ray = new Ray(cam.transform.position, cam.transform.forward);
                if (Physics.Raycast(ray, out RaycastHit hit, Range, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Ignore))
                {
                    var own = World.FindOwnRoot(hit.collider.transform);
                    if (own != null)
                    {
                        root = own;
                        type = own.name == World.RadioName ? TargetType.PortableRadio : TargetType.MovedBox;
                        return true;
                    }
                }
            }

            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) return false;
            float range = pm.ComputeModifiedPickupRange(GameManager.GetGlobalParameters().m_MaxPickupRange);
            var go = pm.GetInteractiveObjectUnderCrosshairs(range);
            if (go == null) return false;

            var own2 = World.FindOwnRoot(go.transform);
            if (own2 != null)
            {
                root = own2;
                type = own2.name == World.RadioName ? TargetType.PortableRadio : TargetType.MovedBox;
                return true;
            }

            var radio = go.GetComponentInParent<TraderRadio>();
            if (radio != null)
            {
                root = ((Component)radio).gameObject;
                type = TargetType.VanillaRadio;
                return true;
            }
            var box = go.GetComponentInParent<ExchangeBox>();
            if (box != null)
            {
                root = ((Component)box).gameObject;
                type = TargetType.VanillaBox;
                return true;
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 准星检测异常: {ex.Message}"); }
        return false;
    }

    // 只在按键没选中时写日志用
    internal static string DescribeCrosshair()
    {
        string ray = "射线没打到东西", inter = "没有可交互物";
        try
        {
            var cam = GameManager.GetMainCamera();
            if (cam != null && Physics.Raycast(new Ray(cam.transform.position, cam.transform.forward), out RaycastHit hit, Range,
                    Physics.DefaultRaycastLayers, QueryTriggerInteraction.Ignore))
                ray = $"射线打到 {Path(hit.collider.transform)}";
            var pm = GameManager.GetPlayerManagerComponent();
            var go = pm?.GetInteractiveObjectUnderCrosshairs(pm.ComputeModifiedPickupRange(GameManager.GetGlobalParameters().m_MaxPickupRange));
            if (go != null) inter = $"可交互物 {Path(go.transform)}";
        }
        catch (Exception ex) { return ex.Message; }
        return ray + " / " + inter;
    }

    private static string Path(Transform t)
    {
        string p = t.name;
        for (int i = 0; i < 3 && t.parent != null; i++) { t = t.parent; p = t.name + "/" + p; }
        return p;
    }

    internal static CarryKind KindOf(TargetType t) => t switch
    {
        TargetType.VanillaRadio or TargetType.PortableRadio => CarryKind.Radio,
        TargetType.VanillaBox or TargetType.MovedBox => CarryKind.ExchangeBox,
        _ => CarryKind.None,
    };
}
