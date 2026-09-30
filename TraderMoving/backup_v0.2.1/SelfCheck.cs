using System;
using System.Reflection;
using System.Text;
using Il2Cpp;
using Il2CppTLD.Trader;

namespace TraderMoving;

// 启动自检:确认所有 patch 目标方法和交易系统类型都能解析。
// 思路照 TldHacks/src/DynamicPatch.cs:772 的 SelfCheck() —— 编译通过不代表
// 运行时签名对得上,游戏更新改了签名的话 Harmony 会静默不挂,功能默默失效。
// 宁愿启动时报错,也不要玩家搬半天发现按键没反应。
internal static class SelfCheck
{
    private const BindingFlags Any = BindingFlags.Public | BindingFlags.NonPublic
                                   | BindingFlags.Instance | BindingFlags.Static;

    public static void Run()
    {
        var missing = new StringBuilder();
        int total = 0, bad = 0;

        void Check(string label, Func<bool> probe)
        {
            total++;
            bool ok;
            try { ok = probe(); } catch { ok = false; }
            if (!ok)
            {
                bad++;
                if (missing.Length > 0) missing.Append(", ");
                missing.Append(label);
            }
        }

        // 交易系统类型(整个 mod 的地基)
        Check("TraderRadio", () => typeof(TraderRadio) != null);
        Check("ExchangeBox", () => typeof(ExchangeBox) != null);
        Check("TraderManager.GetActiveTrade", () =>
            typeof(TraderManager).GetMethod("GetActiveTrade", Any) != null);
        Check("GameManager.GetTraderManager", () =>
            typeof(GameManager).GetMethod("GetTraderManager", Any) != null);

        // patch 目标。带参数的一律显式指定签名 —— 和 Patches.cs 里的声明保持一致,
        // 这样"自检通过"才真的等于"patch 挂得上"。
        Check("LoadScene.Activate()", () =>
            typeof(LoadScene).GetMethod("Activate", Any, null, Type.EmptyTypes, null) != null);
        Check("GameManager.SetAudioModeForLoadedScene", () =>
            typeof(GameManager).GetMethod("SetAudioModeForLoadedScene", Any) != null);
        Check("GameManager.TriggerSurvivalSaveAndDisplayHUDMessage", () =>
            typeof(GameManager).GetMethod("TriggerSurvivalSaveAndDisplayHUDMessage", Any) != null);
        Check("SaveGameSystem.SaveSceneData(SlotData,string)", () =>
            typeof(SaveGameSystem).GetMethod("SaveSceneData", Any, null,
                new[] { typeof(SlotData), typeof(string) }, null) != null);
        Check("SaveGameSystem.LoadSceneData(string,string)", () =>
            typeof(SaveGameSystem).GetMethod("LoadSceneData", Any, null,
                new[] { typeof(string), typeof(string) }, null) != null);
        Check("PlayerManager.PlayerCanSprint", () =>
            typeof(PlayerManager).GetMethod("PlayerCanSprint", Any) != null);
        Check("PlayerManager.EquipItem(GearItem,bool)", () =>
            typeof(PlayerManager).GetMethod("EquipItem", Any, null,
                new[] { typeof(GearItem), typeof(bool) }, null) != null);
        Check("PlayerManager.GetInteractiveObjectUnderCrosshairs", () =>
            typeof(PlayerManager).GetMethod("GetInteractiveObjectUnderCrosshairs", Any) != null);
        Check("PlayerManager.ComputeModifiedPickupRange", () =>
            typeof(PlayerManager).GetMethod("ComputeModifiedPickupRange", Any) != null);
        Check("Fatigue.CalculateFatigueIncrease(float)", () =>
            typeof(Fatigue).GetMethod("CalculateFatigueIncrease", Any, null,
                new[] { typeof(float) }, null) != null);
        Check("PlayerManager.CalculateModifiedCalorieBurnRate(float)", () =>
            typeof(PlayerManager).GetMethod("CalculateModifiedCalorieBurnRate", Any, null,
                new[] { typeof(float) }, null) != null);
        Check("RopeClimbPoint.OnRopeTransition(bool)", () =>
            typeof(RopeClimbPoint).GetMethod("OnRopeTransition", Any, null,
                new[] { typeof(bool) }, null) != null);
        Check("PlayerManager.AttemptToPlaceMesh", () =>
            typeof(PlayerManager).GetMethod("AttemptToPlaceMesh", Any) != null);

        // 背包收纳链用到的 API(SCPlus 桥接走这两个)
        Check("DecorationItem.RemoveFromHierarchy", () =>
            typeof(DecorationItem).GetMethod("RemoveFromHierarchy", Any) != null);
        Check("Inventory.AddDecoration", () =>
            typeof(Inventory).GetMethod("AddDecoration", Any) != null);
        Check("GameManager.GetSafehouseManager", () =>
            typeof(GameManager).GetMethod("GetSafehouseManager", Any) != null);

        if (bad == 0)
            ModMain.Log?.Msg($"[TraderMoving.SelfCheck] OK — {total} 个目标全部可解析");
        else
            ModMain.Log?.Error($"[TraderMoving.SelfCheck] {bad}/{total} 个目标解析失败"
                             + $"(对应功能不会生效,疑似游戏更新改了签名): {missing}");
    }
}
