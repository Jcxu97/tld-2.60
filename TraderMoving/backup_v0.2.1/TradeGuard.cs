using System;
using Il2Cpp;

namespace TraderMoving;

// ═══════════════════════════════════════════════════════════════
// 安全守卫:交易进行中禁止搬运
//
// 为什么必须有这个:
//   玩家提交进交易箱的实物被序列化进 ActiveTradeState.PlayerExchangedItem.m_SerializedGear,
//   存在【全局存档】里(GlobalSaveGameFormat.m_TraderSerialized)。取回它必须靠
//   ActiveTradeState.m_ExchangeBoxScene 指向的那个场景里的 ExchangeBox 实例。
//
//   而无线电和交易箱【都没有 ObjectGuid / PDID / Placeable】(已核实反编译源码),
//   跨场景后没有任何句柄能找回它们 —— 只能靠"当前加载的场景里存在这个组件"被发现。
//
//   所以:一笔 active trade 如果指向的场景玩家去不了、或者箱子被搬走了,玩家已提交的
//   装备就永久卡在存档里,CloseTrade() / CompleteTrade() 都进不去。这是本 mod 唯一
//   会造成不可逆损失的路径,必须在源头堵掉。
// ═══════════════════════════════════════════════════════════════

internal static class TradeGuard
{
    // 检查是否允许开始搬运。返回 false 表示拒绝(已给出提示)。
    internal static bool CanStartCarry()
    {
        if (!HasActiveTrade()) return true;

        var s = ModMain.Settings;
        bool block = s == null || s.BlockDuringActiveTrade;

        if (block)
        {
            GameAudioManager.PlayGUIError();
            HUDMessage.AddMessage("交易进行中,无法搬运。请先完成或取消当前交易。", false, false);
            ModMain.Log?.Msg("[TraderMoving] 搬运被守卫拦下:存在进行中的交易");
            return false;
        }

        // 用户主动关掉了守卫:只警告不阻止
        HUDMessage.AddMessage("警告:交易进行中搬运,已提交的物品可能无法取回!", false, false);
        ModMain.Log?.Warning("[TraderMoving] 守卫已被用户关闭,交易进行中仍允许搬运 —— 有丢物品风险");
        return true;
    }

    // 是否存在进行中的交易。
    // 任何一步取不到就当"没有交易"(主菜单 / 加载期 TraderManager 可能为 null)。
    internal static bool HasActiveTrade()
    {
        try
        {
            var tm = GameManager.GetTraderManager();
            if (tm == null) return false;
            return tm.GetActiveTrade() != null;
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[TraderMoving] HasActiveTrade 异常,按无交易处理: {ex.Message}");
            return false;
        }
    }
}
