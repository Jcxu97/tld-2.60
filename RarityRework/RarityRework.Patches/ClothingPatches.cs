using HarmonyLib;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using RarityRework.Managers;
using MelonLoader;

namespace RarityRework.Patches;

internal static class ClothingPatches
{
	[HarmonyPatch(typeof(ClothingSlot), "ActivateMouseHoverHighlight")]
	private static class ClothingSlotHoverPatch
	{
		private static void Postfix(ClothingSlot __instance)
		{
			RarityUIManager.UpdateClothingSlotColors(__instance);
		}
	}

	[HarmonyPatch(typeof(ClothingSlot), "SetSelected")]
	private static class ClothingSlotSelectedPatch
	{
		private static void Postfix(ClothingSlot __instance, bool isSelected)
		{
			RarityUIManager.UpdateClothingSlotColors(__instance);
		}
	}

	[HarmonyPatch(typeof(Panel_Clothing), "Enable")]
	private static class ClothingSlotEnabledPatch
	{
		private static void Postfix(Panel_Clothing __instance)
		{
			Il2CppSystem.Collections.Generic.List<ClothingSlot>.Enumerator enumerator = __instance.m_ClothingSlots.GetEnumerator();
			while (enumerator.MoveNext())
			{
				RarityUIManager.UpdateClothingSlotColors(enumerator.Current);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Clothing), "OnUseClothingItem")]
	private static class ClothingSlotUsePatch
	{
		private static void Postfix(Panel_Clothing __instance)
		{
			MelonCoroutines.Start(RarityUIManager.DelayedUpdateAllSlots(__instance));
		}
	}
}
