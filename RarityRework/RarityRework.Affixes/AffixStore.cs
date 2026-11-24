using System.Collections.Generic;
using Il2Cpp;
using MelonLoader;
using ModData;
using Newtonsoft.Json;
using RarityRework.Properties;
using UnityEngine;

namespace RarityRework.Affixes;

internal static class AffixStore
{
	private static readonly ModDataManager Data = new ModDataManager("RarityRework", false);

	private static Dictionary<string, ItemRoll> rolls = new Dictionary<string, ItemRoll>();

	private static readonly Dictionary<System.IntPtr, (int id, string guid)> keyCache = new Dictionary<System.IntPtr, (int, string)>();

	private static bool loaded;

	// How many rolls each seed source got since the save was loaded. Spawned items share one position,
	// so without this two in a row roll the same; after a reload the count starts again at 0.
	private static readonly Dictionary<string, int> seedUses = new Dictionary<string, int>();

	private static bool dirty;

	internal static bool Enabled => Settings.Instance.randomAffixes;

	internal static void Reset()
	{
		rolls.Clear();
		keyCache.Clear();
		seedUses.Clear();
		loaded = false;
		dirty = false;
	}

	private static void EnsureLoaded()
	{
		if (loaded)
		{
			return;
		}
		// ModData only has the slot cache after GameManager.LoadSaveGameSlot or SaveGameSlots.CreateSlot.
		// Reading earlier gives null, and marking that as loaded would overwrite real data on the next save.
		if (GameManager.IsMainMenuActive() || string.IsNullOrEmpty(SaveGameSystem.GetCurrentSaveName()))
		{
			return;
		}
		string json = Data.Load("items");
		loaded = true;
		if (!string.IsNullOrEmpty(json))
		{
			rolls = JsonConvert.DeserializeObject<Dictionary<string, ItemRoll>>(json) ?? new Dictionary<string, ItemRoll>();
		}
		MelonLogger.Msg($"[RarityRework] loaded {rolls.Count} rolled items for save {SaveGameSystem.GetCurrentSaveName()}");
	}

	internal static void Save()
	{
		if (loaded && dirty)
		{
			Data.Save(JsonConvert.SerializeObject(rolls), "items");
			dirty = false;
		}
	}

	internal static void ClearKeyCache()
	{
		keyCache.Clear();
	}

	// m_InstanceID is reassigned on every load (runtime objects get negative ids), so rolls are keyed by the
	// ObjectGuid that the game writes into m_ObjectGuidSerialized. Items without one get a new guid at roll time.
	private static string KeyOf(GearItem gi, bool create)
	{
		int id = gi.m_InstanceID;
		if (keyCache.TryGetValue(gi.Pointer, out var hit) && hit.id == id && (hit.guid != null || !create))
		{
			return hit.guid;
		}
		// Items that no longer qualify (for example food rolled by an older build) are treated as unrolled.
		if (AffixCatalog.KindOf(gi) == GearKind.None)
		{
			keyCache[gi.Pointer] = (id, null);
			return null;
		}
		string guid = ObjectGuid.MaybeGetGuidFromGameObject(gi.gameObject);
		if (string.IsNullOrEmpty(guid) && create)
		{
			ObjectGuid.MaybeAttachObjectGuidAndRegister(gi.gameObject, System.Guid.NewGuid().ToString());
			guid = ObjectGuid.MaybeGetGuidFromGameObject(gi.gameObject);
			if (gi.m_ObjectGuid == null)
			{
				gi.m_ObjectGuid = ObjectGuid.GetObjectGuidFromGO(gi.gameObject);
			}
		}
		if (string.IsNullOrEmpty(guid))
		{
			// A gear item can be inspected before the game restores its guid during deserialization.
			return null;
		}
		keyCache[gi.Pointer] = (id, guid);
		return guid;
	}

	internal static ItemRoll Get(GearItem gi)
	{
		if (gi == null || !Enabled)
		{
			return null;
		}
		EnsureLoaded();
		if (!loaded || rolls.Count == 0)
		{
			return null;
		}
		string key = KeyOf(gi, false);
		return GetSaved(gi, key);
	}

	private static ItemRoll GetSaved(GearItem gi, string key)
	{
		if (key == null || !rolls.TryGetValue(key, out ItemRoll roll))
		{
			return null;
		}
		if (!roll.ApplicabilityChecked)
		{
			dirty |= AffixCatalog.RemoveInapplicable(gi, AffixCatalog.KindOf(gi), roll);
			roll.ApplicabilityChecked = true;
		}
		return roll;
	}

	internal static ItemRoll GetOrRoll(GearItem gi)
	{
		if (gi == null || !Enabled)
		{
			return null;
		}
		EnsureLoaded();
		GearKind kind = AffixCatalog.KindOf(gi);
		if (kind == GearKind.None || !loaded)
		{
			return null;
		}
		string oldGuid = KeyOf(gi, false);
		ItemRoll roll = GetSaved(gi, oldGuid);
		if (roll != null)
		{
			return roll;
		}
		// Seed from what survives a reload before the item is first saved: its scene guid if it has one,
		// otherwise name and position. Reloading and picking the same item up again gives the same roll.
		Vector3 p = gi.transform.position;
		string seedSource = oldGuid ?? $"{gi.name}@{Mathf.RoundToInt(p.x * 10f)},{Mathf.RoundToInt(p.y * 10f)},{Mathf.RoundToInt(p.z * 10f)}";
		string key = KeyOf(gi, true);
		if (key == null)
		{
			MelonLogger.Warning($"[RarityRework] {gi.name}: could not attach ObjectGuid, not rolled");
			return null;
		}
		seedUses.TryGetValue(seedSource, out int uses);
		seedUses[seedSource] = uses + 1;
		roll = AffixCatalog.Roll(gi, kind, Fnv($"{SaveGameSystem.GetCurrentSaveName()}:{seedSource}#{uses}"));
		rolls[key] = roll;
		dirty = true;
		MelonLogger.Msg($"[RarityRework] rolled {gi.name} guid {key}: tier {roll.t} {roll.m} {JsonConvert.SerializeObject(roll.a)}");
		return roll;
	}

	// A stack split off another stack keeps the tier of the stack it came from.
	internal static void CopyRoll(GearItem from, GearItem to)
	{
		ItemRoll roll = Get(from);
		if (roll == null || to == null)
		{
			return;
		}
		string key = KeyOf(to, true);
		if (key != null && !rolls.ContainsKey(key))
		{
			rolls[key] = roll;
			dirty = true;
		}
	}

	// string.GetHashCode is randomized per process in .NET 6, so the seed uses a fixed hash.
	private static uint Fnv(string s)
	{
		uint h = 2166136261u;
		foreach (char c in s)
		{
			h = (h ^ c) * 16777619u;
		}
		return h;
	}
}
