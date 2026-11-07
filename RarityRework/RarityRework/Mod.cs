using Il2Cpp;
using RarityRework.Managers;
using RarityRework.Properties;
using RarityRework.Utilities;
using LocalizationUtilities;
using MelonLoader;

namespace RarityRework;

internal sealed class Mod : MelonMod
{
	public override void OnInitializeMelon()
	{
		LoadLocalizations();
		Settings.OnLoad();
	}

	public override void OnLateInitializeMelon()
	{
		Patches.TldHacksCompat.Apply(HarmonyInstance);
	}

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{
		if (!RarityManager.isInitialized && GameManager.IsMainMenuActive())
		{
			MelonCoroutines.Start(RarityManager.InitializeRarities());
		}
	}

	public override void OnSceneWasInitialized(int buildIndex, string sceneName)
	{
		Patches.AffixPatches.OnSceneInitialized();
	}

	private static void LoadLocalizations()
	{
		ParsingUtilities.ReadJSON("RarityRework.Resources.Localization.json", out string jsonText);
		LocalizationManager.LoadJsonLocalization(jsonText);
	}
}
