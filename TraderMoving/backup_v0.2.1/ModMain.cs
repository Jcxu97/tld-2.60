using System;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(TraderMoving.ModMain), "TraderMoving", "0.2.1", "user")]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonAdditionalDependencies("ModSettings")]
[assembly: MelonOptionalDependencies("ModData", "SafehouseCustomizationPlus")]

namespace TraderMoving;

public class ModMain : MelonMod
{
    internal static MelonLogger.Instance Log;
    internal static Settings Settings;

    // SCPlus 在场时它会在进出装修模式时 enable/disable TraderRadio 组件
    // (SCPMain.DisableNormalInteraction / RestoreNormalInteraction)。
    // 我们不去动那个组件的 enabled,避免两边互相覆盖。
    internal static bool ScPlusPresent;

    private bool _inGame;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;

        Settings = new Settings();
        Settings.AddToModSettings("TraderMoving");

        ScPlusPresent = DetectScPlus();
        SelfCheck.Run();

        Log.Msg($"TraderMoving v0.2.1 已加载 — 按 {Settings.CarryKey} 选中,右键收进背包"
              + $" | 无线电 {(Settings.EnableRadio ? "开" : "关")}"
              + $",交易箱 {(Settings.EnableExchangeBox ? "开" : "关")}"
              + $" | SCPlus {(ScPlusPresent ? "在场" : "未装")}");
    }

    // 桥接层必须等 SCPlus 加载完。OnInitializeMelon 的 mod 间时序不保证,
    // OnLateInitializeMelon 在所有 mod 的 OnInitializeMelon 之后跑,这里才安全。
    public override void OnLateInitializeMelon()
    {
        if (ScPlusPresent)
        {
            ScPlusBridge.Init();
            if (ScPlusBridge.Available)
                Log.Msg($"[TraderMoving] 背包收纳可用(SCPlus {ScPlusBridge.DetectedVersion})");
            else
                Log.Warning($"[TraderMoving] 背包收纳不可用({ScPlusBridge.FailReason}),将使用抱着走");
        }
        else
        {
            Log.Msg("[TraderMoving] 未检测到 SCPlus,使用抱着走模式");
        }
    }

    private static bool DetectScPlus()
    {
        try
        {
            foreach (var m in MelonMod.RegisteredMelons)
                if (m?.Info?.Name != null && m.Info.Name.Contains("SafehouseCustomization"))
                    return true;
        }
        catch (Exception ex) { Log?.Warning($"[TraderMoving] SCPlus 探测失败: {ex.Message}"); }
        return false;
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != null && sceneName.Contains("MainMenu"))
        {
            _inGame = false;
            // 回主菜单:清状态,别把搬运态带进下一个存档
            CarryState.Reset();
            StowMode.Disarm(silent: true);
            StowRecord.Reset();
            return;
        }
        _inGame = true;
    }

    public override void OnUpdate()
    {
        if (!_inGame) return;

        try
        {
            var s = Settings;
            if (s == null) return;

            // 诊断键优先,任何状态下都能按
            if (s.DiagnoseKey != KeyCode.None && Input.GetKeyDown(s.DiagnoseKey))
            {
                Diagnose.Dump();
                return;
            }

            if (s.CarryKey == KeyCode.None) return;
            if (GameManager.m_IsPaused) return;

            // 抱着东西时的放下逻辑在 CarryBehaviour.Update 里
            if (CarryState.IsCarrying) return;

            if (!s.EnableRadio && !s.EnableExchangeBox) return;

            // 待收纳态:等右键确认
            if (StowMode.Armed) { StowMode.Tick(); return; }

            // 按 Y 锁定准星上的目标
            if (Input.GetKeyDown(s.CarryKey))
                TryArmUnderCrosshair();
        }
        catch (Exception ex) { Log?.Warning($"[TraderMoving] OnUpdate: {ex.Message}"); }
    }

    // 只在按下热键的那一帧做射线检测,不每帧扫
    private static void TryArmUnderCrosshair()
    {
        var hit = CarryTarget.UnderCrosshair();
        if (hit == null) return;
        if (!CarryTarget.Resolve(hit, out var root, out var kind)) return;
        StowMode.TryArm(root, kind);
    }
}
