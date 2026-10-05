using System;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(MoreBunkers.ModMain), "MoreBunkers", "1.2.0", "user")]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonAdditionalDependencies("ModSettings", "ModData")]

namespace MoreBunkers;

public class ModMain : MelonMod
{
    internal static MelonLogger.Instance Log;
    internal static Settings Settings;

    private static bool _inGame;
    private static string _fixExitScene;
    private static float _fixExitAt = -1f;
    private static int _fixExitTries;

    public override void OnInitializeMelon()
    {
        Log = LoggerInstance;
        Settings = new Settings();
        Settings.AddToModSettings("更多地堡");
        Log.Msg($"MoreBunkers 1.2.0 loaded | enabled {Settings.Enabled} | hard modes {Settings.OnHardModes} | info key {Settings.InfoKey}");
    }

    // 在户外改了"启用":打开马上摆出这张图上的舱口,关掉马上拿走
    internal static void OnSettingsChanged()
    {
        if (!_inGame) return;
        try
        {
            string scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name ?? "";
            if (!scene.EndsWith("Region")) return;
            if (Bunkers.Active()) Bunkers.OnRegionLoaded(scene);
            else Bunkers.RemoveAll();
        }
        catch (Exception ex) { Log.Warning($"[MoreBunkers] settings {ex.Message}"); }
    }

    // ModSettings 开始建设置页时置上(SettingsEn.cs)
    internal static bool LangReady;

    // 只看游戏的语言设置。游戏把它存在 PlayerPrefs 的 "Language" 里(如 "Simplified Chinese"),什么时候读都安全;
    // 不能在启动时读 Localization.Language,它会提前加载语言表,游戏自己的语言表就加载失败,整个游戏进不去
    internal static bool En
    {
        get
        {
            string l = null;
            try { l = PlayerPrefs.GetString("Language", ""); } catch { }
            if (string.IsNullOrEmpty(l) && LangReady) { try { l = Localization.Language; } catch { } }
            return !string.IsNullOrEmpty(l) && !l.ToLowerInvariant().Contains("chinese");
        }
    }

    internal static string T(string zh, string en) => En ? en : zh;

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != null && sceneName.Contains("MainMenu"))
        {
            _inGame = false;
            SaveData.ForgetSession();
            Bunkers.Forget();
            Stock.Cancel();
            return;
        }
        _inGame = true;
    }

    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        if (!_inGame || string.IsNullOrEmpty(sceneName)) return;
        try
        {
            SaveData.LoadIfNewSession();
            var std = GameManager.m_SceneTransitionData;
            if (std != null)
                Log.Msg($"[MoreBunkers] scene {sceneName} | save now {std.m_SceneSaveFilenameCurrent} | next {std.m_SceneSaveFilenameNextLoad} | spawn {std.m_SpawnPointName} | outdoor {std.m_LastOutdoorScene}");

            // 在新地堡里读档:记下来,出去的时候才知道回哪
            var b = Bunkers.ByGuid(std?.m_SceneSaveFilenameNextLoad) ?? Bunkers.ByGuid(std?.m_SceneSaveFilenameCurrent);
            if (sceneName.StartsWith("PrepperCache") && b == null && Bunkers.Entered(sceneName) != null)
            {
                b = Bunkers.Entered(sceneName);
                string save = std?.m_SceneSaveFilenameCurrent;
                if (!string.IsNullOrEmpty(save) && save.StartsWith("PrepperCache"))
                {
                    SaveData.Current.interior[b.Id] = save;
                    SaveData.Save();
                    Log.Msg($"[MoreBunkers] {b.Id} interior save is {save}");
                }
            }
            if (sceneName.EndsWith("Region") || b != null) Bunkers.JustEntered = null;
            if (sceneName.StartsWith("PrepperCache") && !sceneName.Contains("_"))
            {
                // 进的是原版地堡:之前记的"人在哪个新地堡里"作废,不然从这里出去会被送到别的图
                Bunkers.Inside = b;
                if (b != null && Bunkers.Active()) Stock.Begin(b);
            }

            if (sceneName.EndsWith("Region"))
            {
                Bunkers.OnRegionLoaded(sceneName);
                // 只有从地堡舱口出来才挪到新地堡门口;传送、读档、死后重来到这张图的,不挪
                bool hatch = Bunkers.LeftAt >= 0f && Time.realtimeSinceStartup - Bunkers.LeftAt < 60f;
                Bunkers.LeftAt = -1f;
                if (Bunkers.Inside != null && hatch)
                {
                    _fixExitScene = sceneName;
                    _fixExitAt = Time.realtimeSinceStartup + 1.0f;
                    _fixExitTries = 2;
                }
                else Bunkers.Inside = null;
            }
        }
        catch (Exception ex) { Log.Warning($"[MoreBunkers] scene init {ex.Message}"); }
    }

    public override void OnUpdate()
    {
        if (!_inGame) return;
        try
        {
            if (_fixExitAt > 0f && Time.realtimeSinceStartup >= _fixExitAt)
            {
                _fixExitTries--;
                _fixExitAt = _fixExitTries > 0 ? Time.realtimeSinceStartup + 2.0f : -1f;
                Bunkers.FixExit(_fixExitScene, _fixExitTries <= 0);
            }
            if (Settings.InfoKey != KeyCode.None && Input.GetKeyDown(Settings.InfoKey) && GameManager.GetPlayerManagerComponent() != null)
            {
                string msg = Bunkers.Active() ? Bunkers.Describe() : T("更多地堡没有开启", "More Bunkers is off");
                HUDMessage.AddMessage(msg, 12f, true, false);
                Log.Msg("[MoreBunkers] " + msg.Replace("\n", " | "));
            }
        }
        catch (Exception ex) { Log.Warning($"[MoreBunkers] update {ex.Message}"); }
    }
}
