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
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: MelonInfo(typeof(DlcUnlock.Mod), "DlcUnlock", "2.0", "TldHacks")]
[assembly: MelonGame("Hinterland", "TheLongDark")]

namespace DlcUnlock;

public class Mod : MelonMod
{
    internal static readonly Dictionary<string, string> DlcContentPaths = new()
    {
        { "4922630", "tld_dlc/IronRoad" },
        { "2095000", "tld_dlc/TFTFT" },
        { "2091330", "tld_dlc/episode5" },
    };

    // ponytail: bundle-based DLCs only; episode5 is a standalone build, different load mechanism
    internal static readonly Dictionary<string, string> InjectContent = new()
    {
        { "4922630", "DLC02" },
        { "2095000", "DLC01" },
    };

    internal static string GameRoot;

    public override void OnInitializeMelon()
    {
        GameRoot = Path.GetDirectoryName(MelonEnvironment.GameExecutablePath);
        LoggerInstance.Msg($"DLC unlock v2.0 active, game root: {GameRoot}");
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
                string contentId = kv.Key;

                bool alreadyOwned = false;
                if (owned != null)
                {
                    for (int i = 0; i < owned.Count; i++)
                    {
                        if (owned[i] == contentId) { alreadyOwned = true; break; }
                    }
                }
                if (alreadyOwned)
                {
                    Melon<Mod>.Logger.Msg($"Skipping {contentId}, already owned (legit purchase)");
                    continue;
                }

                if (!DlcContentPaths.TryGetValue(contentId, out string relPath)) continue;

                string fullPath = Path.Combine(GameRoot, relPath);
                if (!Directory.Exists(fullPath))
                {
                    Melon<Mod>.Logger.Warning($"Content folder missing: {fullPath}");
                    continue;
                }

                try
                {
                    Melon<Mod>.Logger.Msg($"Injecting content-ready for {contentId} (Prefix, before state transition)");
                    __instance.OnContentReadyToUseCallback(contentId);
                    Melon<Mod>.Logger.Msg($"Content-ready callback completed for {contentId}");
                }
                catch (Exception e)
                {
                    Melon<Mod>.Logger.Error($"Failed to inject {contentId}: {e}");
                }
            }
        }
    }
}
