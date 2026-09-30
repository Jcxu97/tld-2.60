using System;
using System.Reflection;
using System.Text;
using Il2Cpp;
using Il2CppTLD.Trader;

namespace TraderMoving;

// 启动自检:游戏更新改了签名时 Harmony 会静默不挂,宁愿启动时在日志里报出来
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
            if (ok) return;
            bad++;
            if (missing.Length > 0) missing.Append(", ");
            missing.Append(label);
        }

        Check("SaveGameSystem.SaveSceneData(SlotData,string)", () =>
            typeof(SaveGameSystem).GetMethod("SaveSceneData", Any, null, new[] { typeof(SlotData), typeof(string) }, null) != null);
        Check("SaveGameSystem.LoadSceneData(string,string)", () =>
            typeof(SaveGameSystem).GetMethod("LoadSceneData", Any, null, new[] { typeof(string), typeof(string) }, null) != null);
        Check("SaveGameSystem.RestoreGlobalData", () => typeof(SaveGameSystem).GetMethod("RestoreGlobalData", Any) != null);
        Check("TraderManager.InitiateTrade", () => typeof(TraderManager).GetMethod("InitiateTrade", Any) != null);
        Check("Panel_TradeSelection.AcceptTrade", () => typeof(Panel_TradeSelection).GetMethod("AcceptTrade", Any) != null);
        Check("Panel_TradeSelection.GoBack", () => typeof(Panel_TradeSelection).GetMethod("GoBack", Any) != null);
        Check("PlayerManager.PlayerCanSprint", () => typeof(PlayerManager).GetMethod("PlayerCanSprint", Any) != null);
        Check("PlayerManager.EquipItem(GearItem,bool)", () =>
            typeof(PlayerManager).GetMethod("EquipItem", Any, null, new[] { typeof(GearItem), typeof(bool) }, null) != null);
        Check("Fatigue.CalculateFatigueIncrease(float)", () =>
            typeof(Fatigue).GetMethod("CalculateFatigueIncrease", Any, null, new[] { typeof(float) }, null) != null);
        Check("PlayerManager.CalculateModifiedCalorieBurnRate(float)", () =>
            typeof(PlayerManager).GetMethod("CalculateModifiedCalorieBurnRate", Any, null, new[] { typeof(float) }, null) != null);
        Check("RopeClimbPoint.OnRopeTransition(bool)", () =>
            typeof(RopeClimbPoint).GetMethod("OnRopeTransition", Any, null, new[] { typeof(bool) }, null) != null);
        Check("ExchangeBox.SetActiveTrade", () => typeof(ExchangeBox).GetMethod("SetActiveTrade", Any) != null);
        Check("ExchangeBox.SetLocked", () => typeof(ExchangeBox).GetMethod("SetLocked", Any) != null);
        Check("TraderManager.ShouldHaveInitialTraderConversation", () =>
            typeof(TraderManager).GetMethod("ShouldHaveInitialTraderConversation", Any) != null);

        if (bad == 0)
            ModMain.Log?.Msg($"[TraderMoving.SelfCheck] OK,{total} 个目标全部找到");
        else
            ModMain.Log?.Error($"[TraderMoving.SelfCheck] {bad}/{total} 个目标找不到,对应功能不会生效(可能是游戏更新改了): {missing}");
    }
}
