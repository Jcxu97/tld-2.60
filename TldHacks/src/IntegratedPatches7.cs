using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace TldHacks;

// ─── 手电筒无限电量 (DynamicPatch 注册,不常驻) ───
internal static class Patch_FlashInfiniteBattery
{
    public static void Postfix(FlashlightItem __instance)
    {
        try
        {
            if (__instance.m_CurrentBatteryCharge >= 0.999f) return;
            __instance.m_CurrentBatteryCharge = 1f;
        }
        catch { }
    }
}

// ═══════════════════════════════════════════════════════════════════
//   v3.0.4 IntegratedPatches7
//   chunk 3c: StackManager v1.0.6 — 核心 GearItem.Awake + 默认列表
// ═══════════════════════════════════════════════════════════════════

// ═══════════════════════════════════════════════════════════════════
//   StackManager — GearItem.Awake 给指定物品添加 StackableItem 组件
// ═══════════════════════════════════════════════════════════════════

internal static class StackManagerData
{
    // 复制自 StackManager v1.0.6 SetupDefaultConfig (StackManager.decompiled.cs:225-229)
    internal static readonly System.Collections.Generic.HashSet<string> AddStackableComponent = new()
    {
        "GEAR_Potato",
        "GEAR_StumpRemover",
    };

    internal static readonly System.Collections.Generic.HashSet<string> StackMerge = new()
    {
        "GEAR_BirchSaplingDried", "GEAR_BearHideDried", "GEAR_BottleAntibiotics", "GEAR_BottlePainKillers",
        "GEAR_Carrot", "GEAR_CoffeeTin", "GEAR_GreenTeaPackage", "GEAR_GutDried",
        "GEAR_LeatherDried", "GEAR_LeatherHideDried", "GEAR_MapleSaplingDried", "GEAR_MooseHideDried",
        "GEAR_PackMatches", "GEAR_Potato", "GEAR_RabbitPeltDried", "GEAR_StumpRemover",
        "GEAR_WolfPeltDried", "GEAR_WoodMatches",
    };

    internal static string Normalize(string name)
    {
        if (string.IsNullOrEmpty(name)) return name;
        // 去 (Clone) 后缀
        int idx = name.IndexOf("(Clone)");
        return idx >= 0 ? name.Substring(0, idx) : name;
    }
}

[HarmonyPatch(typeof(GearItem), "Awake")]
internal static class Patch_StackMgr_GearAwake
{
    static void Prefix(GearItem __instance)
    {
        try
        {
            if (ModMain.Settings == null || !ModMain.Settings.Stack_AddComponent) return;
            if (__instance == null || GameManager.IsMainMenuActive()) return;
            string n = ((UnityEngine.Object)__instance).name;
            if (string.IsNullOrEmpty(n)) return;
            n = StackManagerData.Normalize(n);
            if (__instance.m_StackableItem != null) return;
            if (((UnityEngine.Component)__instance).gameObject.GetComponent<StackableItem>() != null) return;
            if (!StackManagerData.AddStackableComponent.Contains(n)) return;

            var si = ((UnityEngine.Component)__instance).gameObject.AddComponent<StackableItem>();
#if STORY_EDITION
            si.m_UnitsPerItem = 1;          // 2.24 字段名
#else
            si.m_DefaultUnitsInItem = 1;
#endif
            si.m_StackConditionDifferenceConstraint = 100f;
            si.m_StackSpriteName = string.Empty;
            si.m_ShareStackWithGear = new Il2CppReferenceArray<StackableItem>(0L);
            if (si.m_Units == 0) si.m_Units = 1;
            __instance.m_StackableItem = si;
        }
        catch { }
    }

    static void Postfix(GearItem __instance)
    {
        try
        {
            var s = ModMain.Settings;
            if (s == null) return;
            // v7.7 加总开关早退:这是个静态 [HarmonyPatch],挂在 GearItem.Awake(高频)上,
            //   原先无论 Stack_* 开关是什么状态都会往下跑,连带下面的「防腐」也是无条件生效
            //   (关掉堆叠功能后咖啡罐/绿茶/胡萝卜/土豆照样永不腐坏,且 HP 被改写)。
            if (!s.Stack_AddComponent && !s.Stack_UseMaxHP) return;
            if (__instance == null || GameManager.IsMainMenuActive()) return;
            string n = ((UnityEngine.Object)__instance).name;
            if (string.IsNullOrEmpty(n)) return;
            n = StackManagerData.Normalize(n);
            var si = ((UnityEngine.Component)__instance).gameObject.GetComponent<StackableItem>();

            if (s.Stack_UseMaxHP
                && StackManagerData.StackMerge.Contains(n) && si != null)
            {
                si.m_StackConditionDifferenceConstraint = 100f;
            }

            // 防腐物品(高 HP)—— 这是「添加堆叠组件」的配套行为(堆叠靠 HP 一致性合并,
            //   所以这几样要锁 HP),跟随 Stack_AddComponent 开关。
            if (!s.Stack_AddComponent) return;
#if STORY_EDITION
            // 2.24 属性名是 m_CurrentHP(2.55 才加了无前缀的 CurrentHP)
            if (n == "GEAR_CoffeeTin") { __instance.SetHaltDecay(true); __instance.m_CurrentHP = 1000f; }
            else if (n == "GEAR_GreenTeaPackage") { __instance.SetHaltDecay(true); __instance.m_CurrentHP = 1500f; }
            else if (n == "GEAR_Carrot") { __instance.SetHaltDecay(true); __instance.m_CurrentHP = 50f; }
            else if (n == "GEAR_Potato") { __instance.SetHaltDecay(true); __instance.m_CurrentHP = 100f; }
#else
            if (n == "GEAR_CoffeeTin") { __instance.SetHaltDecay(true); __instance.CurrentHP = 1000f; }
            else if (n == "GEAR_GreenTeaPackage") { __instance.SetHaltDecay(true); __instance.CurrentHP = 1500f; }
            else if (n == "GEAR_Carrot") { __instance.SetHaltDecay(true); __instance.CurrentHP = 50f; }
            else if (n == "GEAR_Potato") { __instance.SetHaltDecay(true); __instance.CurrentHP = 100f; }
#endif
        }
        catch { }
    }
}
