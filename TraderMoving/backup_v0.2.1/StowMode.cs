using System;
using Il2Cpp;
using UnityEngine;

namespace TraderMoving;

// ═══════════════════════════════════════════════════════════════
// 待收纳模式:按 Y 进入,右键确认收进背包
//
// 两步确认的理由:右键在 TLD 里到处都是(瞄准、取消、放下),单独吃右键会误触。
// 先按 Y 锁定目标、给出 HUD 提示,再用右键确认,和游戏里其他两步操作一致。
//
// 【避坑】装修模式下 SCPlus 把 InputManager.ExecuteAltFire patch 成了 BreakDown
// (WorkbenchPatches.cs:49),此时右键归它。所以待收纳态在装修模式下不吃右键,
// 避免和它对撞 —— 玩家在装修模式里本来就能直接拖动物件,不需要我们插手。
// ═══════════════════════════════════════════════════════════════

internal static class StowMode
{
    internal static bool Armed;              // 是否处于待收纳状态
    internal static GameObject Target;       // 锁定的目标
    internal static CarryKind TargetKind;

    private static float _armedTime;
    private static float _lastHintTime;

    private const float Timeout = 8f;        // 超时自动解除,别让状态一直挂着

    // ── 进入 / 解除 ───────────────────────────────────────

    internal static bool TryArm(GameObject root, CarryKind kind)
    {
        if (root == null || kind == CarryKind.None) return false;
        if (!CarryState.KindEnabled(kind)) return false;

        // 交易进行中不许搬(会吞装备,理由见 TradeGuard)
        if (!TradeGuard.CanStartCarry()) return false;

        if (CarryState.HasInjuryPreventing())
        {
            GameAudioManager.PlayGUIError();
            HUDMessage.AddMessage("受伤时无法搬运", false, false);
            return false;
        }

        Armed = true;
        Target = root;
        TargetKind = kind;
        _armedTime = Time.time;

        string label = kind == CarryKind.Radio ? "无线电" : "交易箱";
        HUDMessage.AddMessage($"已选中{label} — 点右键收进背包", false, false);
        ModMain.Log?.Msg($"[TraderMoving] 待收纳: {kind}");
        return true;
    }

    internal static void Disarm(bool silent = false)
    {
        if (!Armed) return;
        Armed = false;
        Target = null;
        TargetKind = CarryKind.None;
        if (!silent) HUDMessage.AddMessage("已取消", false, false);
    }

    // ── 每帧 ──────────────────────────────────────────────

    internal static void Tick()
    {
        if (!Armed) return;

        // 目标没了(被销毁/场景卸载)
        if (Target == null) { Disarm(silent: true); return; }

        // 超时
        if (Time.time - _armedTime > Timeout)
        {
            ModMain.Log?.Msg("[TraderMoving] 待收纳超时,自动解除");
            Disarm();
            return;
        }

        // 走开了就解除:目标不再在准星上
        var hit = CarryTarget.UnderCrosshair();
        bool stillLooking = hit != null
            && CarryTarget.Resolve(hit, out var root, out _)
            && root == Target;
        if (!stillLooking) { Disarm(silent: true); return; }

        RepeatHint();

        // 装修模式下右键归 SCPlus,不抢
        if (InCustomizing())
        {
            HUDMessage.AddMessage("装修模式下请直接拖动物件", false, false);
            Disarm(silent: true);
            return;
        }

        if (Input.GetMouseButtonDown(1))
            Confirm();
    }

    private static void RepeatHint()
    {
        if (Time.time - _lastHintTime < 2.5f) return;
        _lastHintTime = Time.time;
        HUDMessage.AddMessage("点右键收进背包", false, false);
    }

    // ── 确认收纳 ──────────────────────────────────────────

    private static void Confirm()
    {
        var target = Target;
        var kind = TargetKind;
        Disarm(silent: true);

        if (target == null) return;

        // 首选:走 SCPlus 的背包收纳(手感和搬壁炉一致)
        if (ScPlusBridge.Available && kind == CarryKind.Radio)
        {
            // 记下原始位置:收纳失败时要把物体放回去,
            // 否则 RemoveFromHierarchy 之后它既不在背包也不在场景 = 凭空消失
            var savedPos = target.transform.position;
            var savedRot = target.transform.rotation;

            if (ScPlusBridge.EnsureDecoration(target) && ScPlusBridge.StowToInventory(target))
            {
                try
                {
                    GameAudioManager.PlaySound("Play_RopeGetOn", InterfaceManager.GetSoundEmitter());
                }
                catch { }
                HUDMessage.AddMessage("无线电已收进背包", false, false);
                StowRecord.MarkStowed(kind);
                ModMain.Log?.Msg("[TraderMoving] 收纳成功(SCPlus 背包)");
                return;
            }
            // 收纳失败:把物体恢复回原位再降级,绝不让它消失
            ModMain.Log?.Warning("[TraderMoving] SCPlus 收纳失败,恢复原位并降级为抱着走");
            ScPlusBridge.RestoreToScene(target, savedPos, savedRot);
        }

        // 降级:抱着走(桥接不可用、或搬的是交易箱)
        if (CarryState.TryPickUp(target, kind))
        {
            string why = ScPlusBridge.Available ? "此类型暂不支持背包收纳" : "SCPlus 不可用";
            HUDMessage.AddMessage($"抱起搬运({why})", false, false);
        }
    }

    // 装修模式判定。注意 SCPlus 在 Panel_BreakDown 打开期间会直接改
    // m_IsCustomizing 字段来回翻(BreakDownPatches.cs:32/56/65),这个值
    // 在那段时间会说谎。这里只用它做"要不要让出右键"的判断,判错的后果
    // 仅是这一次收纳没生效,可接受。
    private static bool InCustomizing()
    {
        try
        {
            var sm = GameManager.GetSafehouseManager();
            return sm != null && sm.IsCustomizing();
        }
        catch { return false; }
    }
}
