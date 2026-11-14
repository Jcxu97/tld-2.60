using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using RarityRework.Affixes;

namespace RarityRework.Patches;

internal static class AffixPatches
{
	private static readonly Dictionary<IntPtr, float> breakDownBaseHours = new Dictionary<IntPtr, float>();

	private static readonly Random misfireRng = new Random();

	internal static void OnSceneInitialized()
	{
		breakDownBaseHours.Clear();
		AffixStore.ClearKeyCache();
		if (!AffixStore.Enabled || GameManager.IsMainMenuActive())
		{
			return;
		}
		Inventory inv = GameManager.GetInventoryComponent();
		if (inv == null || inv.m_Items == null)
		{
			return;
		}
		for (int i = 0; i < inv.m_Items.Count; i++)
		{
			GearItem gi = inv.m_Items[i]?.m_GearItem;
			AffixApplier.Apply(gi, AffixStore.GetOrRoll(gi));
		}
	}

	private static float ToolFactor(GearItem tool, string id)
	{
		ItemRoll r = AffixStore.Get(tool);
		return r == null ? 1f : 1f - r.Get(id);
	}

	[HarmonyPatch(typeof(Inventory), "AddGear")]
	private static class InventoryAddGear
	{
		private static void Postfix(GearItem gi)
		{
			AffixApplier.Apply(gi, AffixStore.GetOrRoll(gi));
		}
	}

	[HarmonyPatch(typeof(StackableItem), "CanStackItems")]
	private static class CanStackItems
	{
		private static void Postfix(GearItem gearStack, GearItem gearToAdd, ref bool __result)
		{
			if (!__result || !AffixStore.Enabled)
			{
				return;
			}
			ItemRoll a = AffixStore.Get(gearStack);
			ItemRoll b = AffixStore.Get(gearToAdd);
			// Inventory.AddGear tries to stack before our AddGear Postfix rolls the new item, so roll it here.
			if (b == null && a != null)
			{
				b = AffixStore.GetOrRoll(gearToAdd);
			}
			if ((a?.t ?? 0) != (b?.t ?? 0))
			{
				__result = false;
			}
		}
	}

	[HarmonyPatch(typeof(GearItem), "InstantiateStackable")]
	private static class SplitStack
	{
		private static void Postfix(GearItem __instance, GearItem __result)
		{
			AffixStore.CopyRoll(__instance, __result);
			AffixApplier.Apply(__result, AffixStore.Get(__result));
		}
	}

	[HarmonyPatch(typeof(GearItem), "Deserialize")]
	private static class GearItemDeserialize
	{
		private static void Postfix(GearItem __instance)
		{
			ItemRoll r = AffixStore.Get(__instance);
			if (r != null)
			{
				MelonLoader.MelonLogger.Msg($"[RarityRework] applied {__instance.name} guid {ObjectGuid.MaybeGetGuidFromGameObject(__instance.gameObject)}: tier {r.t}");
				AffixApplier.Apply(__instance, r);
			}
		}
	}

	[HarmonyPatch(typeof(SaveGameSlots), "WriteSlotToDisk", new Type[] { typeof(SlotData), typeof(SaveGameSlots.Timestamp) })]
	private static class WriteSlotToDisk
	{
		// ModData writes its cache in a Postfix of this method, so the entry must be handed over before that.
		private static void Prefix()
		{
			AffixStore.Save();
		}
	}

	[HarmonyPatch(typeof(GameManager), "LoadMainMenu")]
	private static class LoadMainMenu
	{
		private static void Postfix()
		{
			AffixStore.Reset();
		}
	}

	[HarmonyPatch(typeof(GearItem), "Degrade")]
	private static class GearItemDegrade
	{
		private static void Prefix(GearItem __instance, ref float hp)
		{
			ItemRoll r = AffixStore.Get(__instance);
			if (r != null)
			{
				hp *= 1f - r.Get(__instance.m_ClothingItem != null ? "wear" : "durable");
			}
		}
	}

	[HarmonyPatch(typeof(GearItem), "GetItemWeightKG", new Type[] { typeof(float), typeof(bool) })]
	private static class GearItemWeight
	{
		private static void Postfix(GearItem __instance, ref ItemWeight __result)
		{
			ItemRoll r = AffixStore.Get(__instance);
			if (r != null && r.a.ContainsKey("weight"))
			{
				__result = __result * (1f - r.Get("weight"));
			}
		}
	}

	[HarmonyPatch(typeof(GunItem), "RollForMisfire")]
	private static class GunMisfire
	{
		private static void Postfix(GunItem __instance, ref bool __result)
		{
			if (!__result)
			{
				return;
			}
			ItemRoll r = AffixStore.Get(__instance.m_GearItem);
			if (r != null && misfireRng.NextDouble() < r.Get("reliable"))
			{
				__result = false;
			}
		}
	}

	[HarmonyPatch(typeof(Panel_BodyHarvest), "GetHarvestDurationMinutes")]
	private static class HarvestDuration
	{
		private static void Postfix(Panel_BodyHarvest __instance, ref float __result)
		{
			__result *= ToolFactor(__instance.GetSelectedTool(), "harvest");
		}
	}

	[HarmonyPatch(typeof(Panel_BodyHarvest), "GetQuarterDurationMinutes")]
	private static class QuarterDuration
	{
		private static void Postfix(Panel_BodyHarvest __instance, ref float __result)
		{
			__result *= ToolFactor(__instance.GetSelectedTool(), "harvest");
		}
	}

	// Breakdown time has no getter to patch. Scale the target's hours from its scene value each time the
	// label or the action reads it, so switching tools never compounds.
	[HarmonyPatch(typeof(Panel_BreakDown), "UpdateDurationLabel")]
	private static class BreakDownLabel
	{
		private static void Prefix(Panel_BreakDown __instance)
		{
			ScaleBreakDown(__instance);
		}
	}

	[HarmonyPatch(typeof(Panel_BreakDown), "OnBreakDown")]
	private static class BreakDownStart
	{
		private static void Prefix(Panel_BreakDown __instance)
		{
			ScaleBreakDown(__instance);
		}
	}

	private static void ScaleBreakDown(Panel_BreakDown panel)
	{
		BreakDown bd = panel.m_BreakDown;
		if (bd == null)
		{
			return;
		}
		if (!breakDownBaseHours.TryGetValue(bd.Pointer, out float hours))
		{
			hours = bd.m_TimeCostHours;
			breakDownBaseHours[bd.Pointer] = hours;
		}
		bd.m_TimeCostHours = hours * ToolFactor(panel.GetSelectedTool(), "breakdown");
	}

	[HarmonyPatch(typeof(GearItem), "DisplayName", MethodType.Getter)]
	private static class GearItemDisplayName
	{
		private static void Postfix(GearItem __instance, ref string __result)
		{
			ItemRoll r = AffixStore.Get(__instance);
			if (r != null && !string.IsNullOrEmpty(r.m))
			{
				__result = r.m + " " + __result;
			}
		}
	}

	// GetDescriptionToDisplayOnInventoryScreen has no native callers (CallerCount 0); the panels read Description.
	[HarmonyPatch(typeof(GearItem), "Description", MethodType.Getter)]
	private static class GearItemDescription
	{
		private static void Postfix(GearItem __instance, ref string __result)
		{
			ItemRoll r = AffixStore.Get(__instance);
			if (r == null || r.a.Count == 0)
			{
				return;
			}
			StringBuilder sb = new StringBuilder(__result);
			sb.Append("\n");
			foreach (string id in r.a.Keys)
			{
				string line = AffixApplier.Describe(__instance, id, r.Get(id));
				if (line != null)
				{
					sb.Append("\n").Append(line);
				}
			}
			__result = sb.ToString();
		}
	}
}
