using System;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(HutDoorTorch.ModMain), "HutDoorTorch", "1.0.0", "user")]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonAdditionalDependencies("ModSettings", "ModData")]

namespace HutDoorTorch;

public class ModMain : MelonMod
{
    internal static MelonLogger.Instance Log;
    internal static Settings Settings;

    private static bool _inGame;
    private static float _scanAt = -1f;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;
        Settings = new Settings();
        Settings.AddToModSettings("钓鱼小屋门和壁挂火把");
        Log.Msg("HutDoorTorch v1.0.0 已加载");
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != null && sceneName.Contains("MainMenu"))
        {
            _inGame = false;
            Huts.Clear();
            Interact.Reset();
            Store.Forget();
            return;
        }
        _inGame = true;
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        if (!_inGame) return;
        _scanAt = Time.realtimeSinceStartup + 1.5f;
    }

    public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
    {
        Interact.Reset();
    }

    public override void OnUpdate()
    {
        if (!_inGame) return;
        try
        {
            if (_scanAt > 0f && Time.realtimeSinceStartup >= _scanAt)
            {
                _scanAt = -1f;
                Gear.EnsureTemplates();
                Torches.EnsureTemplate();
                Store.LoadIfNewSession();
                Huts.ScanScene();
            }
            Huts.Tick(Time.deltaTime);
            Torches.TickFlicker();
            Interact.Tick();
        }
        catch (Exception ex) { Log.Error("OnUpdate: " + ex); }
    }

    public override void OnLateUpdate()
    {
        if (_inGame) Interact.LateTick();
    }
}
