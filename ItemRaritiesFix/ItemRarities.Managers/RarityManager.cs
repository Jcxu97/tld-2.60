using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using ItemRarities.Enums;
using ItemRarities.Utilities;

namespace ItemRarities.Managers;

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

	internal static IEnumerator InitializeRarities()
	{
		yield return LoadRaritiesFromLocalFile();
		LoadRaritiesFromModComponents();
		isInitialized = true;
	}

	private static IEnumerator LoadRaritiesFromLocalFile()
	{
		ParsingUtilities.ReadJSON("ItemRarities.Resources.ItemRarities.json", out string jsonText);
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
