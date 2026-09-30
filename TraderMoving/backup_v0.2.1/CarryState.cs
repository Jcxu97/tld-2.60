using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

namespace TraderMoving;

internal enum CarryKind { None, Radio, ExchangeBox }

// ═══════════════════════════════════════════════════════════════
// 搬运状态机
//
// 架构照 TldHacks/src/IntegratedPatches4.cs 的 CarcassMovingState —— 那套已经在
// 搬运猎物上验证过,四个坑都踩完了(见 memory project_tldhacks_carcassmoving)。
// 这里复用的关键点:
//   1. 搬【原版实例本身】,不重建。因为带交互的无线电/交易箱 prefab 不在
//      addressables 里(已核实主 catalog 和 DLC01.json 都没有),重建出来的
//      是个空壳,呼不出商人。SCPlus 就是在这里放弃的。
//   2. SetVisible 必须【精确恢复】collider:隐藏时记下原本 enabled 的 InstanceID,
//      显示时只恢复记过的那些。CarcassMoving 的 bug #3 就是盲目启用所有 collider,
//      把原本禁用的物理体也打开了,挡住交互 trigger。
//   3. 隐藏原件只用 SetActive(false),【绝不 Destroy】。TraderRadio.OnDestroy()
//      只有 20 字节,极可能是复位 public static bool s_IsOnRadio;绕过它会留下
//      幽灵态,换场景和读档都清不掉,只有重启进程能清。
// ═══════════════════════════════════════════════════════════════

internal static class CarryState
{
    internal static GameObject CarriedObj;
    internal static CarryKind Kind = CarryKind.None;
    internal static string OriginalScene;
    internal static float Weight;
    internal static bool IsCarrying;
    internal static float PickUpTime;
    internal static bool SaveTrigger;

    private static HashSet<int> _enabledColliders;
    private static float _lastHintTime;

    // ── 判定 ──────────────────────────────────────────────

    internal static bool HasInjuryPreventing()
    {
        var s = ModMain.Settings;
        if (s != null && s.AllowCarryWhileInjured) return false;
        try
        {
            return GameManager.GetSprainedAnkleComponent().HasSprainedAnkle()
                || GameManager.GetSprainedWristComponent().HasSprainedWrist()
                || GameManager.GetBrokenRibComponent().HasBrokenRib();
        }
        catch { return false; }
    }

    internal static bool KindEnabled(CarryKind kind)
    {
        var s = ModMain.Settings;
        if (s == null) return false;
        return kind switch
        {
            CarryKind.Radio => s.EnableRadio,
            CarryKind.ExchangeBox => s.EnableExchangeBox,
            _ => false,
        };
    }

    private static float WeightFor(CarryKind kind)
    {
        var s = ModMain.Settings;
        if (s == null) return 0f;
        return kind switch
        {
            CarryKind.Radio => s.RadioWeight,
            CarryKind.ExchangeBox => s.BoxWeight,
            _ => 0f,
        };
    }

    // ── 抱起 / 放下 ────────────────────────────────────────

    internal static bool TryPickUp(GameObject obj, CarryKind kind)
    {
        if (IsCarrying || obj == null || kind == CarryKind.None) return false;
        if (!KindEnabled(kind)) return false;

        // 风险 A 的守卫:交易进行中不许搬(会吞装备)
        if (!TradeGuard.CanStartCarry()) return false;

        if (HasInjuryPreventing())
        {
            GameAudioManager.PlayGUIError();
            HUDMessage.AddMessage("受伤时无法搬运", false, false);
            return false;
        }

        CarriedObj = obj;
        Kind = kind;
        Weight = WeightFor(kind);
        IsCarrying = true;
        PickUpTime = Time.time;
        OriginalScene = GameManager.m_ActiveScene;

        if (CarriedObj.GetComponent<CarryBehaviour>() == null)
            CarriedObj.AddComponent<CarryBehaviour>();

        try { GameManager.GetPlayerManagerComponent().UnequipItemInHands(); } catch { }

        SetVisible(false);
        try
        {
            GameAudioManager.PlaySound("Play_RopeGetOn", InterfaceManager.GetSoundEmitter());
            GameAudioManager.PlaySound(Il2CppAK.EVENTS.PLAY_EXERTIONLOW, InterfaceManager.GetSoundEmitter());
        }
        catch { }

        ModMain.Log?.Msg($"[TraderMoving] 抱起 {Kind} @ {OriginalScene},重量 {Weight}kg");
        return true;
    }

    internal static void Drop()
    {
        if (!IsCarrying) return;
        var obj = CarriedObj;
        var kind = Kind;

        IsCarrying = false;

        if (obj == null)
        {
            // 对象在搬运途中被销毁(异常路径),清干净状态别留残留
            ModMain.Log?.Warning("[TraderMoving] Drop 时对象已不存在,重置状态");
            Reset();
            return;
        }

        try
        {
            DropInFrontOfPlayer();
            SetVisible(true);

            // 跨场景:把对象移交给当前活动场景,否则它还挂在旧场景上,
            // 旧场景卸载时会被连带销毁
            var activeScene = SceneManager.GetActiveScene();
            var root = ((Component)obj.transform.root).gameObject;
            if (root.scene != activeScene)
                SceneManager.MoveGameObjectToScene(root, activeScene);

            try { GameAudioManager.PlaySound(Il2CppAK.EVENTS.PLAY_BODYFALLLARGE, InterfaceManager.GetSoundEmitter()); } catch { }

            var cb = obj.GetComponent<CarryBehaviour>();
            if (cb != null) UnityEngine.Object.Destroy(cb);

            ModMain.Log?.Msg($"[TraderMoving] 放下 {kind} @ {GameManager.m_ActiveScene}");
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[TraderMoving] Drop 异常: {ex}");
        }

        CarriedObj = null;
        Kind = CarryKind.None;
        Weight = 0f;
        SaveTrigger = true;   // 放下后触发一次存档,把新位置落盘
    }

    // 状态整体清零(场景切换异常、对象丢失时用)
    internal static void Reset()
    {
        IsCarrying = false;
        CarriedObj = null;
        Kind = CarryKind.None;
        Weight = 0f;
        _enabledColliders = null;
    }

    // ── 位置 ──────────────────────────────────────────────

    internal static void MoveToPlayer()
    {
        if (CarriedObj == null) return;
        var pt = GameManager.GetPlayerTransform();
        CarriedObj.transform.position = pt.position;
        CarriedObj.transform.rotation = pt.rotation;
    }

    internal static void DropInFrontOfPlayer()
    {
        if (CarriedObj == null) return;
        var pt = GameManager.GetPlayerTransform();
        var fwd = pt.forward;
        fwd.y = 0f;
        if (fwd.sqrMagnitude < 0.01f) fwd = Vector3.forward;
        else fwd.Normalize();
        CarriedObj.transform.position = pt.position + fwd * 1.2f;
        // 让物体正面朝向玩家,方便直接交互
        CarriedObj.transform.rotation = Quaternion.LookRotation(-fwd, Vector3.up);
    }

    // ── 可见性(collider 精确恢复是关键) ──────────────────

    internal static void SetVisible(bool visible)
    {
        if (CarriedObj == null) return;

        if (!visible)
        {
            _enabledColliders = new HashSet<int>();
            foreach (var c in CarriedObj.GetComponentsInChildren<Collider>(true))
            {
                if (c.enabled) _enabledColliders.Add(c.GetInstanceID());
                c.enabled = false;
            }
        }
        else
        {
            foreach (var c in CarriedObj.GetComponentsInChildren<Collider>(true))
                c.enabled = _enabledColliders != null && _enabledColliders.Contains(c.GetInstanceID());
            _enabledColliders = null;
        }

        foreach (var r in CarriedObj.GetComponentsInChildren<Renderer>(true))
            r.enabled = visible;
    }

    // ── 提示 ──────────────────────────────────────────────

    internal static void DisplayDropHint()
    {
        if (Time.time - _lastHintTime < 5f) return;
        _lastHintTime = Time.time;
        var key = ModMain.Settings != null ? ModMain.Settings.CarryKey.ToString() : "G";
        HUDMessage.AddMessage($"右键或按 {key} 放下", false, false);
    }
}
