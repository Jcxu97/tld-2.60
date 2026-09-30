using System;
using Il2Cpp;
using Il2CppTLD.Trader;

namespace TraderMoving;

// 交易箱和进行中交易的关系。
//
// 玩家放进交易箱的实物存在全局存档的 ActiveTradeState 里,取回时由
// m_ExchangeBoxScene 指向的那个场景里的箱子重新摆出来。所以只要交易里还没放货,
// 把 m_ExchangeBoxScene 改成箱子新的场景就等于把这笔交易跟着箱子搬走;
// 已经放了货、交易已关闭或奖励没拿,就不让搬这个箱子。
internal static class TradeGuard
{
    internal static ActiveTradeState ActiveTrade()
    {
        try { return GameManager.GetTraderManager()?.GetActiveTrade(); }
        catch { return null; }
    }

    // 这笔交易是不是正压在眼前这个箱子上(箱里有货 / 等着完成 / 奖励没拿)
    private static bool TradeHasGoodsHere(ActiveTradeState t)
    {
        if (t == null) return false;
        if (t.m_ExchangeBoxScene != GameManager.m_ActiveScene) return false;
        if (t.m_TradeState != ActiveTradeState.State.Open) return true;
        try { return t.HasAnyFilled(); } catch { return true; }
    }

    internal static bool CanMoveBox()
    {
        var t = ActiveTrade();
        if (!TradeHasGoodsHere(t)) return true;

        var s = ModMain.Settings;
        if (s == null || s.BlockDuringActiveTrade)
        {
            CarryState.Refuse(t.m_TradeState == ActiveTradeState.State.Completed
                ? "箱里的奖励还没拿,先拿走再搬"
                : "箱里有交易中的货,先完成或取消交易再搬");
            ModMain.Log?.Msg($"[TraderMoving] 搬交易箱被拦下:交易状态 {t.m_TradeState}");
            return false;
        }
        HUDMessage.AddMessage("警告:箱里有交易中的货,搬走后可能拿不回来", false, false);
        ModMain.Log?.Warning("[TraderMoving] 守卫已关,箱里有货仍然搬走");
        return true;
    }

    // 箱子放下后改送货地点:交易本来就指向箱子上一个位置的,不管什么状态都跟过来
    // (货存在交易状态里,由指向的场景里的箱子重新摆出);指向别处的只改还没放货的
    internal static void RetargetActiveTrade(string scene, string carriedFrom)
    {
        var t = ActiveTrade();
        if (t == null || string.IsNullOrEmpty(scene)) return;
        try
        {
            if (t.m_ExchangeBoxScene == scene) { World.HookUpTrade(); return; }
            bool followsBox = !string.IsNullOrEmpty(carriedFrom) && t.m_ExchangeBoxScene == carriedFrom;
            if (!followsBox && (t.m_TradeState != ActiveTradeState.State.Open || t.HasAnyFilled())) return;
            ModMain.Log?.Msg($"[TraderMoving] 进行中的交易改送到 {scene}(原来是 {t.m_ExchangeBoxScene})");
            t.m_ExchangeBoxScene = scene;
            World.HookUpTrade();
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 改送货地点异常: {ex.Message}"); }
    }

    // 下单时送货地点改成玩家搬的箱子
    internal static string DeliveryScene()
    {
        var s = ModMain.Settings;
        if (s == null || !s.DeliverToMovedBox || !s.EnableExchangeBox) return null;
        var r = SaveData.Current.box;
        if (!r.taken || !r.placed || r.carrying || string.IsNullOrEmpty(r.scene)) return null;
        return r.scene;
    }
}
