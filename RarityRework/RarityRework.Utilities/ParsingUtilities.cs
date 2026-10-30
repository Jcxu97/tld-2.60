using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RarityRework.Enums;
using RarityRework.Managers;
using Newtonsoft.Json.Linq;

namespace RarityRework.Utilities;

internal static class ParsingUtilities
{
	internal static void LoadRaritiesFromIR(StreamReader reader)
	{
		Rarities rarities = Rarities.None;
		while (true)
		{
			string text = reader.ReadLine();
			if (text == null)
			{
				break;
			}
			text = text.Trim();
			if (string.IsNullOrEmpty(text) || text.StartsWith("#"))
			{
				continue;
			}
			if (text.StartsWith("[") && text.EndsWith("]"))
			{
				if (Enum.TryParse<Rarities>(text.Trim('[', ']'), out var result))
				{
					rarities = result;
				}
			}
			else if (rarities != Rarities.None)
			{
				RarityManager.raritiesLookup[text] = rarities;
			}
		}
	}

	internal static void LoadRaritiesFromJson(string jsonText)
	{
		foreach (KeyValuePair<string, JToken> item in JObject.Parse(jsonText))
		{
			if (!Enum.TryParse<Rarities>(item.Key, out var result) || item.Value == null)
			{
				continue;
			}
			foreach (JToken item2 in (IEnumerable<JToken>)item.Value)
			{
				RarityManager.raritiesLookup[((object)item2).ToString()] = result;
			}
		}
	}

	internal static void ReadJSON(string jsonFilePath, out string jsonText)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(jsonFilePath);
		if (stream == null)
		{
			jsonText = string.Empty;
			return;
		}
		using StreamReader streamReader = new StreamReader(stream);
		jsonText = streamReader.ReadToEnd();
	}
}
