using System;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

// 识别准星指向的东西是不是可搬运的无线电 / 交易箱。
//
// 【按组件类型识别,不按名字】。理由:SCPlus 的 SetupCarryable / ManagePlacement 用的是
// 双向子串匹配(name.ToLower().Contains(key.ToLower())),它的 SanitizeObjectName 还会
// 吃掉结尾数字和括号内容 —— 靠名字匹配既容易误判也容易被别的 mod 改名搞坏。
// TraderRadio 和 ExchangeBox 都是明确的组件类型,GetComponentInParent 一步到位。
internal static class CarryTarget
{
    // 从准星指到的物体往上找可搬运的根对象。
    internal static bool Resolve(GameObject hit, out GameObject root, out CarryKind kind)
    {
        root = null;
        kind = CarryKind.None;
        if (hit == null) return false;

        try
        {
            var radio = hit.GetComponentInParent<TraderRadio>();
            if (radio != null)
            {
                root = ((Component)radio).gameObject;
                kind = CarryKind.Radio;
                return true;
            }

            var box = hit.GetComponentInParent<ExchangeBox>();
            if (box != null)
            {
                root = ((Component)box).gameObject;
                kind = CarryKind.ExchangeBox;
                return true;
            }
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[TraderMoving] Resolve 异常: {ex.Message}");
        }

        return false;
    }

    // 拿准星下的交互物体。范围走游戏自己的 ComputeModifiedPickupRange,
    // 这样 TldHacks 的"交互距离"修改器(它 patch 了这个方法)也能生效。
    internal static GameObject UnderCrosshair()
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) return null;
            float range = pm.ComputeModifiedPickupRange(GameManager.GetGlobalParameters().m_MaxPickupRange);
            return pm.GetInteractiveObjectUnderCrosshairs(range);
        }
        catch { return null; }
    }
}
