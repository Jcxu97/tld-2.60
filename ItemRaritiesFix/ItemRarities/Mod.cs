using Il2Cpp;
using ItemRarities.Managers;
using ItemRarities.Properties;
using ItemRarities.Utilities;
using LocalizationUtilities;
using MelonLoader;

namespace ItemRarities;

internal sealed class Mod : MelonMod
{
	public override void OnInitializeMelon()
	{
		LoadLocalizations();
		Settings.OnLoad();
	}

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{
		if (!RarityManager.isInitialized && GameManager.IsMainMenuActive())
		{
			MelonCoroutines.Start(RarityManager.InitializeRarities());
		}
	}

	private static void LoadLocalizations()
	{
		ParsingUtilities.ReadJSON("ItemRarities.Resources.Localization.json", out string jsonText);
		LocalizationManager.LoadJsonLocalization(jsonText);
	}
}
