using System;
using System.Reflection;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Trader;
using UnityEngine;

namespace TraderMoving;

// 随身无线电:不走原版无线电的对话,直接开原版的选货面板下单,完成交易也直接调 TraderManager。
//
// 选货面板平时由原版无线电推给它自己(SetTraderRadio),确认和返回会回调那台无线电。
// 这里给它一个不激活的空无线电顶位置,确认和返回两个按钮在随身模式下由下面两个 patch 接管,
// 原版无线电打开面板时 Active 是 false,两个 patch 直接放行。
internal static class RemoteTrade
{
    internal const string DummyName = "TraderMoving_DummyRadio";
    internal static bool Active;
    private static TraderRadio _dummy;
    private static PlayerControlMode _prevMode = PlayerControlMode.Normal;

    internal static void Use()
    {
        var tm = GameManager.GetTraderManager();
        if (tm == null || !tm.IsSystemEnabled) { CarryState.Refuse("这个存档没开商人"); return; }

        var trade = tm.GetActiveTrade();
        if (trade != null)
        {
            ReportTrade(tm, trade);
            return;
        }

        if (!CanReachTrader(tm)) return;

        try
        {
            if (tm.ShouldHaveInitialTraderConversation(out _))
            {
                CarryState.Refuse("第一次要先在原版无线电上和商人聊过,之后才能用随身无线电");
                return;
            }
        }
        catch { }

        if (TradeGuard.DeliveryScene() == null)
        {
            CarryState.Refuse(CarryState.Kind == CarryKind.ExchangeBox
                ? "先把交易箱放下,商人才知道往哪送货"
                : "先搬一个交易箱放好,商人才知道往哪送货");
            return;
        }

        var panel = InterfaceManager.GetPanel<Panel_TradeSelection>();
        if (panel == null) { CarryState.Refuse("打不开交易面板"); return; }

        try
        {
            panel.SetTraderRadio(Dummy());
            Active = true;
            LockPlayer(true);
            ((Panel_Base)panel).Enable(true);
            ModMain.Log?.Msg("[TraderMoving] 随身无线电:打开选货面板");
        }
        catch (Exception ex)
        {
            Active = false;
            LockPlayer(false);
            ModMain.Log?.Error($"[TraderMoving] 打开选货面板失败: {ex}");
            CarryState.Refuse("打不开交易面板,详情见日志");
        }
    }

    private static void ReportTrade(TraderManager tm, ActiveTradeState trade)
    {
        string where = trade.m_ExchangeBoxScene;
        switch (trade.m_TradeState)
        {
            case ActiveTradeState.State.Open:
                HUDMessage.AddMessage($"交易进行中,把货放进交易箱({where})后关上箱子", false, false);
                break;
            case ActiveTradeState.State.Closed:
                if (!CanReachTrader(tm)) return;
                if (!tm.IsTradeFullyFilled()) { HUDMessage.AddMessage("货还没放齐", false, false); return; }
                tm.CompleteTrade();
                World.HookUpTrade();
                try { GameAudioManager.PlayGUIButtonClick(); } catch { }
                HUDMessage.AddMessage($"交易完成,去交易箱({where})拿货", false, false);
                ModMain.Log?.Msg("[TraderMoving] 随身无线电:完成交易");
                break;
            default:
                HUDMessage.AddMessage($"奖励在交易箱({where})里,拿走后才能下新单", false, false);
                break;
        }
    }

    // 原版规矩:商人到了、极光来了、送完货的冷却过了才联系得上
    private static bool CanReachTrader(TraderManager tm)
    {
        bool always = (ModMain.Settings?.PortableRadioAlwaysOn ?? false) || TldHacksAlwaysAvailable();
        try
        {
            if (!tm.IsTraderAvailable())
            {
                CarryState.Refuse("商人还没到,联系不上");
                return false;
            }
            if (always) return true;
            var am = GameManager.GetAuroraManager();
            if (am == null || !am.AuroraIsActive())
            {
                CarryState.Refuse("要等极光出来无线电才有电");
                return false;
            }
            if (tm.IsTraderOutForExchange())
            {
                CarryState.Refuse("商人送货去了,过一阵再联系");
                return false;
            }
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 判断商人能否联系异常: {ex.Message}"); }
        return true;
    }

    private static FieldInfo _tldHacksAlways;
    private static bool _tldHacksLooked;

    private static bool TldHacksAlwaysAvailable()
    {
        if (!_tldHacksLooked)
        {
            _tldHacksLooked = true;
            try
            {
                foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (a.GetName().Name != "TldHacks") continue;
                    _tldHacksAlways = a.GetType("TldHacks.CheatState")?.GetField("TraderAlwaysAvailable", BindingFlags.Public | BindingFlags.Static);
                    break;
                }
            }
            catch { }
        }
        try { return _tldHacksAlways != null && (bool)_tldHacksAlways.GetValue(null); }
        catch { return false; }
    }

    private static TraderRadio Dummy()
    {
        if (_dummy != null) return _dummy;
        var go = new GameObject(DummyName);
        go.SetActive(false);
        UnityEngine.Object.DontDestroyOnLoad(go);
        _dummy = go.AddComponent<TraderRadio>();
        _dummy.m_CurrentState = TraderRadio.RadioState.Trading;
        return _dummy;
    }

    private static void LockPlayer(bool locked)
    {
        try
        {
            var pm = GameManager.GetPlayerManagerComponent();
            if (pm == null) return;
            if (locked)
            {
                _prevMode = pm.GetControlMode();
                if (_prevMode == PlayerControlMode.Normal) pm.SetControlMode(PlayerControlMode.Locked);
            }
            else if (pm.GetControlMode() == PlayerControlMode.Locked && _prevMode == PlayerControlMode.Normal)
                pm.SetControlMode(PlayerControlMode.Normal);
        }
        catch { }
    }

    internal static void Close(Panel_TradeSelection panel)
    {
        try { ((Panel_Base)panel).Enable(false); }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 关选货面板异常: {ex.Message}"); }
    }

    // 面板被别的路径关掉(比如按了 Esc 走的不是 GoBack)时收尾
    internal static void Tick()
    {
        if (!Active) return;
        try
        {
            var panel = InterfaceManager.GetPanel<Panel_TradeSelection>();
            if (panel == null || !((Panel_Base)panel).IsEnabled())
            {
                Active = false;
                LockPlayer(false);
            }
        }
        catch { Active = false; LockPlayer(false); }
    }

    internal static void Accept(Panel_TradeSelection panel)
    {
        var tm = GameManager.GetTraderManager();
        var sel = panel.m_SelectedTradeExchanges;
        string scene = TradeGuard.DeliveryScene();
        if (tm == null || sel == null || sel.Count == 0 || scene == null)
        {
            try { GameAudioManager.PlayGUIError(); } catch { }
            return;
        }

        var list = new Il2CppSystem.Collections.Generic.List<TradeExchangeData>();
        for (int i = 0; i < sel.Count; i++) list.Add(sel[i]);
        tm.InitiateTrade(list, scene);
        Close(panel);
        World.HookUpTrade();
        try { GameAudioManager.PlayGUIButtonClick(); } catch { }
        HUDMessage.AddMessage($"下单了,把货放进交易箱({scene})后关上箱子", false, false);
        ModMain.Log?.Msg($"[TraderMoving] 随身无线电:下单 {list.Count} 项,送到 {scene}");
    }
}

[HarmonyPatch(typeof(Panel_TradeSelection), nameof(Panel_TradeSelection.AcceptTrade))]
internal static class Patch_TradeSelection_Accept
{
    internal static bool Prefix(Panel_TradeSelection __instance)
    {
        if (!RemoteTrade.Active) return true;
        try { RemoteTrade.Accept(__instance); }
        catch (Exception ex) { ModMain.Log?.Error($"[TraderMoving] 随身下单失败: {ex}"); RemoteTrade.Close(__instance); }
        return false;
    }
}

[HarmonyPatch(typeof(Panel_TradeSelection), nameof(Panel_TradeSelection.GoBack))]
internal static class Patch_TradeSelection_GoBack
{
    internal static bool Prefix(Panel_TradeSelection __instance)
    {
        if (!RemoteTrade.Active) return true;
        RemoteTrade.Close(__instance);
        return false;
    }
}
