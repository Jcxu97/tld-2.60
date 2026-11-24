using System;
using System.Text;
using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using RarityRework.Affixes;

namespace RarityRework.Patches;

internal static class AffixPatches
{
	private static readonly Random misfireRng = new Random();

	internal static void OnSceneInitialized()
	{
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

	private static float DurationFactor(GearItem tool, string id)
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

	// Fired receives each projectile after the shooter sets its base damage, before it resolves the hit.
	[HarmonyPatch(typeof(GunItem), nameof(GunItem.Fired))]
	private static class GunDamage
	{
		[HarmonyPriority(Priority.Last)]
		private static void Postfix(GunItem __instance, UnityEngine.GameObject projectile)
		{
			float bonus = AffixStore.Get(__instance.m_GearItem)?.Get("damage") ?? 0f;
			if (bonus > 0f && projectile != null)
			{
				vp_Bullet bullet = projectile.GetComponent<vp_Bullet>();
				if (bullet != null)
				{
					bullet.Damage *= 1f + bonus;
				}
			}
		}
	}

	// The shooter can inline RollForMisfire. The chance table is called in both paths.
	[HarmonyPatch(typeof(MisfireTable), nameof(MisfireTable.DoesMisfire))]
	private static class GunMisfire
	{
		private static void Postfix(MisfireTable __instance, ref bool __result)
		{
			if (!__result || !AffixStore.Enabled)
			{
				return;
			}
			GearItem gear = GameManager.GetPlayerManagerComponent()?.m_ItemInHands;
			if (gear == null || gear.m_GunItem?.m_MisfireTable != __instance)
			{
				return;
			}
			float reduction = AffixStore.Get(gear)?.Get("reliable") ?? 0f;
			if (reduction > 0f && misfireRng.NextDouble() < reduction)
			{
				__result = false;
			}
		}
	}

	[HarmonyPatch(typeof(PlayerAnimation), "UpdateAnimatorSpeed")]
	private static class GunReloadSpeed
	{
		private static void Postfix(PlayerAnimation __instance)
		{
			if (!AffixStore.Enabled || __instance.m_State != PlayerAnimation.State.Reloading)
			{
				return;
			}
			float factor = DurationFactor(GameManager.GetPlayerManagerComponent()?.m_ItemInHands, "reload");
			if (factor < 1f && __instance.m_Animator != null)
			{
				__instance.m_Animator.speed /= factor;
			}
		}
	}

	[HarmonyPatch(typeof(FireManager), nameof(FireManager.PlayerCalculateFireStartTime))]
	private static class FireStartTime
	{
		private static void Postfix(FireStarterItem starter, ref float __result)
		{
			if (starter != null && __result > 0f)
			{
				__result *= DurationFactor(starter.GetComponent<GearItem>(), "firefast");
			}
		}
	}

	[HarmonyPatch(typeof(Panel_BodyHarvest), "GetHarvestDurationMinutes")]
	private static class HarvestDuration
	{
		private static void Postfix(Panel_BodyHarvest __instance, ref float __result)
		{
			__result *= DurationFactor(__instance.GetSelectedTool(), "harvest");
		}
	}

	// Refresh reads the carcass field directly and caches the minutes used by both the panel and OnQuarter.
	[HarmonyPatch(typeof(Panel_BodyHarvest), "Refresh")]
	private static class QuarterDuration
	{
		private static void Prefix(Panel_BodyHarvest __instance, out (BodyHarvest Body, float Minutes) __state)
		{
			__state = default;
			if (!__instance.IsTabQuarterSelected() || __instance.m_BodyHarvest == null)
			{
				return;
			}
			float factor = DurationFactor(__instance.GetSelectedTool(), "harvest");
			if (factor < 1f)
			{
				BodyHarvest body = __instance.m_BodyHarvest;
				__state = (body, body.m_QuarterDurationMinutes);
				body.m_QuarterDurationMinutes = __state.Minutes * factor;
			}
		}

		private static void Finalizer((BodyHarvest Body, float Minutes) __state)
		{
			if (__state.Body != null)
			{
				__state.Body.m_QuarterDurationMinutes = __state.Minutes;
			}
		}
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
