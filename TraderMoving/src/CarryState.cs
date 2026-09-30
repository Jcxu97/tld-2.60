using System;
using Il2Cpp;
using UnityEngine;

namespace TraderMoving;

// 抱着走。手上不带实物:拿起时把场景里那件藏起来或删掉,放下时再按位置摆出来。
// 这样换场景、存读档都只是记录里的一个标记,不用跨场景搬 GameObject。
internal static class CarryState
{
    internal static CarryKind Kind = CarryKind.None;
    internal static bool IsCarrying => Kind != CarryKind.None;
    internal static float PickUpTime;
    private static float _lastHintTime;
    private static int _hintsLeft;
    private static float _dropRetryAt;
    internal static bool RopeDropPending;

    internal static float Weight
    {
        get
        {
            var s = ModMain.Settings;
            if (s == null) return 0f;
            return Kind == CarryKind.Radio ? s.RadioWeight : Kind == CarryKind.ExchangeBox ? s.BoxWeight : 0f;
        }
    }

    internal static string Label(CarryKind k) => k == CarryKind.Radio ? "无线电" : "交易箱";

    internal static bool KindEnabled(CarryKind kind)
    {
        var s = ModMain.Settings;
        if (s == null) return false;
        return kind == CarryKind.Radio ? s.EnableRadio : kind == CarryKind.ExchangeBox && s.EnableExchangeBox;
    }

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

    // ── 拿起 ──────────────────────────────────────────────

    // 抱不了就提示原因并返回 true,不改任何状态
    internal static bool PickUpBlocked(GameObject target, TargetType type)
    {
        var kind = CarryTarget.KindOf(type);
        if (IsCarrying || target == null || kind == CarryKind.None) return true;
        if (!KindEnabled(kind)) return true;

        if (HasInjuryPreventing())
        {
            Refuse("受伤时搬不动");
            return true;
        }
        if (kind == CarryKind.ExchangeBox && (BoxInUse(target) || !TradeGuard.CanMoveBox())) return true;

        if (type == TargetType.VanillaRadio || type == TargetType.VanillaBox)
        {
            // 只搬一件。原件拿走以后能再拿的只有放回原屋子的那台原版无线电
            var rec = SaveData.Of(kind);
            bool again = type == TargetType.VanillaRadio && rec.taken && rec.placed && rec.asReal
                      && rec.originObjScene == target.scene.name;
            if (rec.taken && !again)
            {
                Refuse(rec.placed
                    ? $"已经搬过一个{Label(kind)}了(在 {rec.scene}),先把它拿回来或者放回原处"
                    : $"已经搬过一个{Label(kind)}了");
                return true;
            }
        }
        return false;
    }

    internal static bool TryPickUp(GameObject target, TargetType type)
    {
        if (PickUpBlocked(target, type)) return false;
        var kind = CarryTarget.KindOf(type);

        var rec = SaveData.Of(kind);
        switch (type)
        {
            case TargetType.VanillaRadio:
            case TargetType.VanillaBox:
                if (!rec.taken)
                {
                    rec.taken = true;
                    rec.originObjScene = target.scene.name;
                    rec.originActiveScene = GameManager.m_ActiveScene;
                    rec.SetOrigin(target.transform.position, target.transform.rotation);
                }
                if (type == TargetType.VanillaRadio) RadioClone.MakeTemplate(target, rec.originObjScene);
                World.HideVanilla(target);
                break;

            case TargetType.PortableRadio:
                World.RemovePortableRadio();
                break;

            case TargetType.MovedBox:
                World.RemoveMovedBox();
                break;
        }

        rec.carrying = true;
        rec.placed = false;
        rec.asReal = false;
        rec.carriedFrom = GameManager.m_ActiveScene;
        Kind = kind;
        PickUpTime = Time.time;
        _hintsLeft = 3;
        CarryPatches.Enable();

        try { GameManager.GetPlayerManagerComponent().UnequipItemInHands(); } catch { }
        try
        {
            GameAudioManager.PlaySound("Play_RopeGetOn", InterfaceManager.GetSoundEmitter());
            GameAudioManager.PlaySound(Il2CppAK.EVENTS.PLAY_EXERTIONLOW, InterfaceManager.GetSoundEmitter());
        }
        catch { }
        HUDMessage.AddMessage($"抱起{Label(kind)},看着要放的地方按 {KeyName()} 或右键放下", false, false);
        ModMain.Log?.Msg($"[TraderMoving] 抱起 {kind}({type}) @ {GameManager.m_ActiveScene},原件场景 {rec.originObjScene}");
        return true;
    }

    private static bool BoxInUse(GameObject target)
    {
        try
        {
            var ex = target.GetComponentInChildren<Il2CppTLD.Trader.ExchangeBox>(true);
            var panel = InterfaceManager.GetPanel<Panel_ExchangeBox>();
            bool busy = (ex != null && (ex.m_ShowingPanel || ex.m_IsOpening))
                     || (panel != null && ((Panel_Base)panel).IsEnabled());
            if (busy) Refuse("交易箱开着,关上再搬");
            return busy;
        }
        catch { return false; }
    }

    // ── 放下 ──────────────────────────────────────────────

    internal static void Drop()
    {
        if (!IsCarrying || Time.time < _dropRetryAt) return;
        FindDropSpot(out var pos, out float yaw);
        DropAt(pos, yaw);
    }

    internal static void DropAt(Vector3 pos, float yaw)
    {
        if (!IsCarrying || Time.time < _dropRetryAt) return;
        var kind = Kind;
        var rec = SaveData.Of(kind);
        string scene = GameManager.m_ActiveScene;

        try
        {
            if (kind == CarryKind.Radio)
            {
                var real = World.FindVanillaRadio(rec);
                if (real != null)
                {
                    // 回到原来的屋子:直接用原版无线电,对话什么的都在
                    real.SetActive(true);
                    rec.yaw = yaw;
                    real.transform.SetPositionAndRotation(pos, rec.RadioRot);
                    rec.asReal = true;
                }
                else
                {
                    rec.yaw = yaw;
                    if (!World.PlaceRadio(pos, rec.RadioRot, rec.originObjScene))
                    {
                        _dropRetryAt = Time.time + 2f;
                        Refuse("无线电模型加载失败,先别放");
                        return;
                    }
                    rec.asReal = false;
                }
            }
            else
            {
                if (World.EnsureBox(pos, Quaternion.Euler(0f, yaw, 0f)) == null)
                {
                    _dropRetryAt = Time.time + 2f;
                    Refuse("交易箱模型加载失败,先别放");
                    return;
                }
                TradeGuard.RetargetActiveTrade(scene, rec.carriedFrom);
            }
        }
        catch (Exception ex)
        {
            ModMain.Log?.Error($"[TraderMoving] 放下异常: {ex}");
            _dropRetryAt = Time.time + 2f;
            Refuse("放不下,详情见日志");
            return;
        }

        rec.carrying = false;
        rec.placed = true;
        rec.SetPlace(scene, pos, yaw);
        rec.carriedFrom = "";
        Kind = CarryKind.None;
        CarryPatches.Disable();
        World.Apply();   // 同场景的原版箱这时就收起来,别等下次进场景

        try { GameAudioManager.PlaySound(Il2CppAK.EVENTS.PLAY_BODYFALLLARGE, InterfaceManager.GetSoundEmitter()); } catch { }
        HUDMessage.AddMessage($"{Label(kind)}已放下", false, false);
        ModMain.Log?.Msg($"[TraderMoving] 放下 {kind} @ {scene} {pos}{(rec.asReal ? " (原版无线电)" : "")}");
    }

    // 看着的平面够近就放在那里,否则放在脚前的地上;正面朝着玩家
    private static void FindDropSpot(out Vector3 pos, out float yaw)
    {
        var pt = GameManager.GetPlayerTransform();
        var fwd = pt.forward;
        fwd.y = 0f;
        fwd = fwd.sqrMagnitude < 0.01f ? Vector3.forward : fwd.normalized;
        yaw = Quaternion.LookRotation(-fwd, Vector3.up).eulerAngles.y;

        try
        {
            var cam = GameManager.GetMainCamera();
            var ray = new Ray(cam.transform.position, cam.transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, 2.5f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Ignore)
                && hit.normal.y > 0.6f)
            {
                pos = hit.point;
                return;
            }
        }
        catch { }

        var start = pt.position + fwd * 1.0f + Vector3.up * 1.2f;
        pos = Physics.Raycast(start, Vector3.down, out RaycastHit ground, 3f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.Ignore)
            ? ground.point
            : pt.position + fwd * 1.0f;
    }

    // ── 每帧(只在抱着时) ─────────────────────────────────

    internal static void Tick()
    {
        if (!IsCarrying) return;

        if (!KindEnabled(Kind) || RopeDropPending)
        {
            RopeDropPending = false;
            Placement.Abort();
            Drop();
            return;
        }

        if (_hintsLeft > 0 && Time.time - _lastHintTime > 6f)
        {
            _hintsLeft--;
            _lastHintTime = Time.time;
            HUDMessage.AddMessage($"抱着{Label(Kind)}:按 {KeyName()} 或右键放下", false, false);
        }

        if (Time.time - PickUpTime < 0.5f) return;

        bool forced = false;
        try { forced = HasInjuryPreventing() || GameManager.GetPlayerStruggleComponent().InStruggle(); } catch { }
        if (forced) { Placement.Abort(); Drop(); return; }

        // 摆放中游戏的控制模式不是 Normal,要放在下面那个判断前面
        if (Placement.Busy) { Placement.Tick(); return; }

        // 背包、地图、装修模式里按键不算
        if (ModMain.BusyElsewhere() || ModMain.InCustomizing()) return;
        var s = ModMain.Settings;
        bool key = s != null && s.CarryKey != KeyCode.None && Input.GetKeyDown(s.CarryKey);
        if (key || Input.GetMouseButtonDown(1)) Placement.Begin();
    }

    // 读档后接着抱
    internal static void RestoreFromRecord()
    {
        var r = SaveData.Current;
        var k = r.radio.carrying ? CarryKind.Radio : r.box.carrying ? CarryKind.ExchangeBox : CarryKind.None;
        Placement.Reset();
        // 抱着无线电读档:先在后台备好模板,放下时虚影和摆出来的才是同一个模型
        if (k == CarryKind.Radio && !RadioClone.HasTemplate(r.radio.originObjScene))
            RadioClone.StartHarvest(r.radio.originObjScene);
        if (k == Kind) return;
        Kind = k;
        PickUpTime = Time.time;
        if (IsCarrying) CarryPatches.Enable(); else CarryPatches.Disable();
    }

    internal static void Reset()
    {
        Placement.Reset();
        Kind = CarryKind.None;
        CarryPatches.Disable();
    }

    internal static string KeyName() => ModMain.Settings != null ? ModMain.Settings.CarryKey.ToString() : "Y";

    internal static void Refuse(string msg)
    {
        try { GameAudioManager.PlayGUIError(); } catch { }
        HUDMessage.AddMessage(msg, false, false);
    }
}
