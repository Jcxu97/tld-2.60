using System;
using Il2Cpp;
using Il2CppTLD.Trader;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(TraderMoving.ModMain), "TraderMoving", "1.0.2", "user")]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonAdditionalDependencies("ModSettings", "ModData")]

namespace TraderMoving;

public class ModMain : MelonMod
{
    internal static MelonLogger.Instance Log;
    internal static Settings Settings;

    private static bool _inGame;
    private static float _applyAt = -1f;

    // 选中状态:看着目标按一下选中,右键拿起;随身无线电再按一下是呼叫商人
    private static GameObject _armed;
    private static TargetType _armedType;
    private static float _armedTime;
    private static float _lastArmHint;
    private const float ArmTimeout = 8f;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;
        Settings = new Settings();
        Settings.AddToModSettings("TraderMoving");
        SelfCheck.Run();
        ScPlusPickup.Install(HarmonyInstance);
        Log.Msg($"TraderMoving v1.0.0 已加载:看着无线电或交易箱按 {Settings.CarryKey} 选中,右键抱起"
              + $" | 无线电 {(Settings.EnableRadio ? "开" : "关")},交易箱 {(Settings.EnableExchangeBox ? "开" : "关")}");
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != null && sceneName.Contains("MainMenu"))
        {
            _inGame = false;
            Disarm();
            ScPlusPickup.Reset();
            Placement.Reset();
            CarryState.Reset();
            SaveData.ForgetSession();
            World.OnSceneUnloading();
            RadioClone.CancelPending();
            RadioClone.Forget();
            return;
        }
        _inGame = true;
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        if (!_inGame) return;
        if (sceneName != null && sceneName.EndsWith("_DLC01")) World.Apply();
        ScheduleApply();
    }

    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        Disarm();
    }

    // 进场景后隔一会儿再摆一次,等别的 mod(SCPlus 等)挪完东西
    internal static void ScheduleApply() => _applyAt = Time.realtimeSinceStartup + 1.5f;

    public override void OnUpdate()
    {
        if (!_inGame) return;
        try
        {
            if (_applyAt > 0f && Time.realtimeSinceStartup >= _applyAt)
            {
                _applyAt = -1f;
                World.Apply();
            }

            RemoteTrade.Tick();
            RadioClone.Tick();

            var s = Settings;
            if (s == null) return;

            if (s.DiagnoseKey != KeyCode.None && Input.GetKeyDown(s.DiagnoseKey))
            {
                Diagnose.Dump();
                return;
            }

            if (GameManager.m_IsPaused || RemoteTrade.Active) return;
            ScPlusPickup.Tick();

            if (CarryState.IsCarrying) { CarryState.Tick(); return; }

            if (_armed != null) { TickArmed(s); return; }

            if (s.CarryKey != KeyCode.None && Input.GetKeyDown(s.CarryKey) && !BusyElsewhere())
                TryArm();
        }
        catch (Exception ex) { Log?.Warning($"[TraderMoving] OnUpdate: {ex.Message}"); }
    }

    internal static bool BusyElsewhere()
    {
        try
        {
            if (TraderRadio.s_IsOnRadio) return true;
            var pm = GameManager.GetPlayerManagerComponent();
            return pm == null || pm.GetControlMode() != PlayerControlMode.Normal;
        }
        catch { return false; }
    }

    // 只在按下键的那一帧做射线检测
    private static void TryArm()
    {
        if (!CarryTarget.UnderCrosshair(out var root, out var type))
        {
            Log?.Msg($"[TraderMoving] 按了选中键,准星下没有无线电或交易箱({CarryTarget.DescribeCrosshair()})");
            return;
        }
        var kind = CarryTarget.KindOf(type);
        if (!CarryState.KindEnabled(kind))
        {
            HUDMessage.AddMessage(kind == CarryKind.Radio ? "设置里没开搬运无线电" : "设置里没开搬运交易箱", false, false);
            return;
        }
        Log?.Msg($"[TraderMoving] 选中 {type}:{root.name}");

        _armed = root;
        _armedType = type;
        _armedTime = Time.time;
        _lastArmHint = Time.time;
        HUDMessage.AddMessage(HintFor(type), false, false);
    }

    private static string HintFor(TargetType t) => t switch
    {
        TargetType.PortableRadio when !World.RadioIsClone => $"随身无线电:再按 {CarryState.KeyName()} 呼叫商人,右键抱起",
        TargetType.PortableRadio => "已选中无线电:点右键抱起",
        TargetType.VanillaRadio => "已选中无线电:点右键抱起",
        _ => "已选中交易箱:点右键抱起",
    };

    private static void TickArmed(Settings s)
    {
        if (_armed == null || Time.time - _armedTime > ArmTimeout || BusyElsewhere()) { Disarm(); return; }

        // 视线移开就取消
        if (!CarryTarget.UnderCrosshair(out var root, out var type) || root == null || root.Pointer != _armed.Pointer)
        {
            Disarm();
            return;
        }

        if (InCustomizing())
        {
            HUDMessage.AddMessage("装修模式下不能抱起", false, false);
            Disarm();
            return;
        }

        if (Time.time - _lastArmHint > 2.5f)
        {
            _lastArmHint = Time.time;
            HUDMessage.AddMessage(HintFor(_armedType), false, false);
        }

        if (_armedType == TargetType.PortableRadio && !World.RadioIsClone && s.CarryKey != KeyCode.None && Input.GetKeyDown(s.CarryKey))
        {
            Disarm();
            RemoteTrade.Use();
            return;
        }

        if (Input.GetMouseButtonDown(1))
        {
            var target = _armed;
            var t = _armedType;
            Disarm();
            CarryState.TryPickUp(target, t);
        }
    }

    private static void Disarm()
    {
        _armed = null;
        _armedType = TargetType.None;
    }

    // 装修模式下右键归 SCPlus 的拆解,不抢
    internal static bool InCustomizing()
    {
        try
        {
            var sm = GameManager.GetSafehouseManager();
            return sm != null && sm.IsCustomizing();
        }
        catch { return false; }
    }
}
