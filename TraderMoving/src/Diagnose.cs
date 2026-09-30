using System;
using System.Text;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

// 按诊断键(默认 F9)把当前状态写进日志
internal static class Diagnose
{
    internal static void Dump()
    {
        var sb = new StringBuilder();
        sb.AppendLine("═══ TraderMoving 诊断 ═══");
        sb.AppendLine($"场景: {Safe(() => GameManager.m_ActiveScene)} | 存档: {Safe(() => SaveGameSystem.GetCurrentSaveName())}");
        sb.AppendLine($"抱着: {CarryState.Kind} | 随身面板: {RemoteTrade.Active}");
        sb.AppendLine($"无线电记录: {SaveData.Describe(SaveData.Current.radio)} | 原件场景 {SaveData.Current.radio.originObjScene}");
        sb.AppendLine($"交易箱记录: {SaveData.Describe(SaveData.Current.box)} | 原件场景 {SaveData.Current.box.originObjScene}");
        sb.AppendLine($"送货地点(下单时): {TradeGuard.DeliveryScene() ?? "原版随机"}");

        try
        {
            foreach (var r in Resources.FindObjectsOfTypeAll<TraderRadio>())
            {
                var go = ((Component)r).gameObject;
                if (!go.scene.IsValid() || !go.scene.isLoaded) continue;
                sb.AppendLine($"  原版无线电 {go.name} 场景 {go.scene.name} 显示 {go.activeInHierarchy} 位置 {go.transform.position}");
            }
            foreach (var b in Resources.FindObjectsOfTypeAll<ExchangeBox>())
            {
                var go = ((Component)b).gameObject;
                if (!go.scene.IsValid() || !go.scene.isLoaded) continue;
                bool own = World.FindOwnRoot(go.transform) != null;
                sb.AppendLine($"  {(own ? "搬过的" : "原版")}交易箱 场景 {go.scene.name} 显示 {go.activeInHierarchy} 位置 {go.transform.position}"
                            + $" 已接交易 {b.m_ActiveTrade != null} 上锁 {b.m_IsLocked}");
            }
        }
        catch (Exception ex) { sb.AppendLine($"  场景物件读取失败: {ex.Message}"); }

        try
        {
            var tm = GameManager.GetTraderManager();
            if (tm != null)
            {
                sb.AppendLine($"商人: 系统 {tm.IsSystemEnabled} 可用 {tm.IsTraderAvailable()} 送货中 {tm.IsTraderOutForExchange()} 信任 {tm.CurrentTrust}/{tm.MaxTrust}");
                var t = tm.GetActiveTrade();
                sb.AppendLine(t == null
                    ? "进行中交易: 无"
                    : $"进行中交易: 状态 {t.m_TradeState} 送到 {t.m_ExchangeBoxScene} 已放货 {t.HasAnyFilled()} 放齐 {t.IsFullyFilled()} 有奖励 {t.HasRewards()}");
                sb.AppendLine($"管理器登记的交易箱: {(tm.m_ExchangeBoxInScene != null ? ((Component)tm.m_ExchangeBoxInScene).gameObject.name : "无")}");
            }
            var am = GameManager.GetAuroraManager();
            if (am != null) sb.AppendLine($"极光: {am.AuroraIsActive()}");
        }
        catch (Exception ex) { sb.AppendLine($"交易状态读取失败: {ex.Message}"); }

        sb.AppendLine("═══════════════════════");
        ModMain.Log?.Msg(sb.ToString());
        HUDMessage.AddMessage("诊断信息已写入日志", false, false);
    }

    private static string Safe(Func<string> f)
    {
        try { return f() ?? "null"; }
        catch { return "读取失败"; }
    }
}
