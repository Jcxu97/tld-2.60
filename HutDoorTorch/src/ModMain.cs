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
    private static float _rescanAt = -1f;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;
        Settings = new Settings();
        Settings.AddToModSettings("钓鱼小屋门和壁挂火把");
        TldHacksCompat.Install(HarmonyInstance);
        Log.Msg("HutDoorTorch v1.0.0 已加载");
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != null && sceneName.Contains("MainMenu"))
        {
            _inGame = false;
            _rescanAt = -1f;
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
                Patch_Localization.Inject();
                Store.LoadIfNewSession();
                Huts.ScanScene();
                try { Recipes.AddTo(Recipes.Manager); } catch (Exception ex) { Log.Error("加配方失败: " + ex); }
                _rescanAt = Time.realtimeSinceStartup + 10f;
            }
            else if (_rescanAt > 0f && Time.realtimeSinceStartup >= _rescanAt)
            {
                // 远处的小屋进场景时可能还没激活,隔一阵再找一遍
                _rescanAt = Time.realtimeSinceStartup + 10f;
                Huts.ScanScene();
            }
#if HDT_TEST
            if (Input.GetKeyDown(KeyCode.F8))
            {
                Gear.GiveOne(Gear.Door);
                var di = Torches.GiveOne();
                Log.Msg($"测试:给了门和火把 {(di != null ? di.name : "null")}");
                HUDMessage.AddMessage("测试:给了门和壁挂火把", false, false);
            }
#endif
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
