using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Il2CppSteamworks;
using Il2CppTLD.OptionalContent;
using Il2CppTLD.Platform;
using MelonLoader;
using MelonLoader.Utils;

[assembly: AssemblyTitle("DlcUnlock")]
[assembly: AssemblyVersion("2.4.0.0")]
[assembly: MelonInfo(typeof(DlcUnlock.Mod), "DlcUnlock", "2.4", "TldHacks")]
[assembly: MelonGame("Hinterland", "TheLongDark")]

namespace DlcUnlock;

public class Mod : MelonMod
{
    internal static readonly Dictionary<string, string> DlcContentPaths = new()
    {
        { "4922630", "tld_dlc/IronRoad" },
        { "2091330", "tld_dlc/TFTFT" },
        { "2095000", "tld_dlc/wintermute" },
    };

    // ponytail: the game checks ownership through a direct native BIsDlcInstalled call, so Patch_BIsDlcInstalled
    // does not reach it; injecting the ID into OwnedContent does. Wintermute has m_HasContent = 0, so owning it is enough
    // and the story menu then starts tld_dlc/wintermute/tld.exe or tld_dlc/episode5/tld.exe.
    // Values are the game's internal content names (from DLC01.json / DLC02.json m_LocatorId), NOT Steam AppIDs.
    internal static readonly Dictionary<string, string> InjectContent = new()
    {
        { "4922630", "DLC02" },
        { "2091330", "DLC01" },
        { "2095000", "WintermuteDLC" },
    };

    internal static bool ContentFolderExists(string contentId, string fullPath) =>
        Directory.Exists(fullPath) ||
        (contentId == "2095000" && Directory.Exists(Path.Combine(GameRoot, "tld_dlc/episode5")));

    internal static string GameRoot;

    public override void OnInitializeMelon()
    {
        GameRoot = Path.GetDirectoryName(MelonEnvironment.GameExecutablePath);
        LoggerInstance.Msg($"DLC unlock v2.4 active, game root: {GameRoot}");
        foreach (var kv in DlcContentPaths)
        {
            string full = Path.Combine(GameRoot, kv.Value);
            LoggerInstance.Msg($"  [{kv.Key}] {kv.Value} exists={Directory.Exists(full)}");
        }
    }

    [HarmonyPatch(typeof(SteamApps), nameof(SteamApps.BIsDlcInstalled))]
    private static class Patch_BIsDlcInstalled
    {
        private static bool Prefix(AppId_t appID, ref bool __result)
        {
            string id = appID.m_AppId.ToString();
            if (DlcContentPaths.ContainsKey(id))
            {
                __result = true;
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(SteamPlatformProvider), nameof(SteamPlatformProvider.GetPathForContent))]
    private static class Patch_GetPathForContent
    {
        private static bool Prefix(string contentID, string overridePath,
            ref string path, ref OptionalContentProviderResult __result)
        {
            if (GameRoot == null || contentID == null) return true;
            if (!InjectContent.ContainsKey(contentID)) return true;
            if (!DlcContentPaths.TryGetValue(contentID, out string relPath)) return true;

            string fullPath = Path.Combine(GameRoot, relPath);
            if (Directory.Exists(fullPath))
            {
                path = fullPath;
                __result = OptionalContentProviderResult.Success;
                Melon<Mod>.Logger.Msg($"GetPathForContent({contentID}) -> {fullPath}");
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(OptionalContentManager), "OnInitializedCallback")]
    private static class Patch_OnInitializedCallback
    {
        // ponytail: Prefix not Postfix. OnContentReadyToUseCallback checks State == Initializing;
        // after the real OnInitializedCallback runs, State changes and the callback becomes a no-op.
        private static void Prefix(OptionalContentManager __instance, OptionalContentProviderResult __0)
        {
            if (__0 != OptionalContentProviderResult.Success) return;

            var owned = __instance.OwnedContent;

            foreach (var kv in InjectContent)
            {
                string appId = kv.Key;
                string contentName = kv.Value;

                bool alreadyOwned = false;
                if (owned != null)
                {
                    for (int i = 0; i < owned.Count; i++)
                    {
                        if (owned[i] == appId || owned[i] == contentName) { alreadyOwned = true; break; }
                    }
                }
                if (alreadyOwned)
                {
                    Melon<Mod>.Logger.Msg($"Skipping {contentName} ({appId}), already owned");
                    continue;
                }

                if (!DlcContentPaths.TryGetValue(appId, out string relPath)) continue;

                string fullPath = Path.Combine(GameRoot, relPath);
                if (!ContentFolderExists(appId, fullPath))
                {
                    Melon<Mod>.Logger.Warning($"Content folder missing: {fullPath}");
                    continue;
                }

                try
                {
                    Melon<Mod>.Logger.Msg($"Injecting {contentName} ({appId})");
                    __instance.OnContentReadyToUseCallback(contentName);
                    __instance.OnContentReadyToUseCallback(appId);
                    Melon<Mod>.Logger.Msg($"Inject OK for {contentName}");
                }
                catch (Exception e)
                {
                    Melon<Mod>.Logger.Error($"Failed to inject {contentName}: {e}");
                }
            }
        }
    }
}
