using System.Text;
using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using RarityRework.Affixes;

namespace RarityRework.Patches;

// TldHacks shows same-prefab items as one inventory cell, grouped by the key from Dedupe.MakeKey.
// Items with different affixes must keep their own cell, so the roll is added to that key.
internal static class TldHacksCompat
{
	internal static void Apply(HarmonyLib.Harmony harmony)
	{
		var type = AccessTools.TypeByName("TldHacks.Dedupe");
		var target = type == null ? null : AccessTools.Method(type, "MakeKey");
		if (target == null)
		{
			return;
		}
		harmony.Patch(target, postfix: new HarmonyMethod(typeof(TldHacksCompat), nameof(MakeKeyPostfix)));
		MelonLogger.Msg("[RarityRework] TldHacks stacking: items with different affixes keep separate cells");
	}

	private static void MakeKeyPostfix(GearItem gi, ref string __result)
	{
		ItemRoll roll = AffixStore.Get(gi);
		if (roll == null)
		{
			return;
		}
		var sb = new StringBuilder(__result).Append('|').Append(roll.t).Append(roll.m);
		foreach (var kv in roll.a)
		{
			sb.Append(kv.Key).Append(kv.Value.ToString("0.00"));
		}
		__result = sb.ToString();
	}
}
