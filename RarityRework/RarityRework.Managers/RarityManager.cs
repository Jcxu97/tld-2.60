using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using RarityRework.Enums;
using RarityRework.Utilities;

namespace RarityRework.Managers;

public static class RarityManager
{
	internal static bool isInitialized;

	internal static Dictionary<string, Rarities> raritiesLookup = new Dictionary<string, Rarities>();

	public static void AddGearItemAndRarity(string gearItem, Rarities rarity)
	{
		raritiesLookup[gearItem] = rarity;
	}

	internal static Rarities GetRarity(string itemName)
	{
		return raritiesLookup.GetValueOrDefault(itemName, Rarities.None);
	}

	internal static Rarities GetRarity(Il2Cpp.GearItem gearItem)
	{
		if (gearItem == null)
		{
			return Rarities.None;
		}
		// In random mode only rolled items carry a tier; everything else shows none.
		if (Affixes.AffixStore.Enabled)
		{
			Affixes.ItemRoll roll = Affixes.AffixStore.Get(gearItem);
			return roll != null ? (Rarities)roll.t : Rarities.None;
		}
		return GetRarity(gearItem.name);
	}

	internal static bool IsUnidentified(Il2Cpp.GearItem gearItem)
	{
		return Affixes.AffixStore.Enabled && Affixes.AffixStore.Get(gearItem) == null && Affixes.AffixCatalog.KindOf(gearItem) != Affixes.GearKind.None;
	}

	internal static IEnumerator InitializeRarities()
	{
		// The built-in table is re-tiered by survival value, so it must win over rarities.ir shipped in .modcomponent files.
		LoadRaritiesFromModComponents();
		yield return LoadRaritiesFromLocalFile();
		isInitialized = true;
	}

	private static IEnumerator LoadRaritiesFromLocalFile()
	{
		ParsingUtilities.ReadJSON("RarityRework.Resources.RarityRework.json", out string jsonText);
		ParsingUtilities.LoadRaritiesFromJson(jsonText);
		yield break;
	}

	private static void LoadRaritiesFromModComponents()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		if (directoryName == null)
		{
			return;
		}
		string[] files = Directory.GetFiles(directoryName, "*.modcomponent");
		for (int i = 0; i < files.Length; i++)
		{
			using ZipArchive zipArchive = ZipFile.OpenRead(files[i]);
			ZipArchiveEntry entry = zipArchive.GetEntry("rarities.ir");
			if (entry != null)
			{
				using StreamReader reader = new StreamReader(entry.Open());
				ParsingUtilities.LoadRaritiesFromIR(reader);
			}
		}
	}
}
