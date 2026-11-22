using System;
using HarmonyLib;
using Il2Cpp;
using ItemRarities.Managers;
using ItemRarities.Utilities;
using UnityEngine;

namespace ItemRarities.Patches;

internal static class InventoryPatches
{
	[HarmonyPatch(typeof(InventoryGridItem), "OnHover")]
	private static class InventoryGridItemHoverPatch
	{
		private static void Postfix(InventoryGridItem __instance, bool isOver)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			if (!((UnityEngine.Object)(object)__instance.m_Button == (UnityEngine.Object)null))
			{
				((UIButtonColor)__instance.m_Button).hover = RarityUIManager.GetRarityAndColour(__instance.m_GearItem, 0.5f);
				((UIButtonColor)__instance.m_Button).pressed = RarityUIManager.GetRarityAndColour(__instance.m_GearItem, 0.5f, 0.5f);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Inventory), "Initialize")]
	private static class PanelInventoryInitializePatch
	{
		private static void Postfix(Panel_Inventory __instance)
		{
			UIButtonExtensions.NewSortButton(__instance.m_SortButtons, "Button_SortRarity", "ico_Star", (Action<UIButton>)__instance.OnSortChange, 85f, 1.8f, 0f);
			__instance.m_SortFlipDictionary.Add("GAMEPLAY_SortRarity", false);
		}
	}

	[HarmonyPatch(typeof(Panel_Inventory), "OnSortChange")]
	private static class PanelInventorySortPatch
	{
		private static void Prefix(Panel_Inventory __instance, UIButton sortButtonClicked)
		{
			if (((UnityEngine.Object)sortButtonClicked).name == "Button_SortRarity" && __instance.m_SortName == "GAMEPLAY_SortRarity")
			{
				RarityUIManager.ToggleRaritySort();
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Inventory), "UpdateFilteredInventoryList")]
	private static class PanelInventorySortRarityPatch
	{
		private static void Postfix(Panel_Inventory __instance)
		{
			if (__instance.m_SortName == "GAMEPLAY_SortRarity")
			{
				RarityUIManager.CompareGearByRarity(__instance);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Inventory), "UpdateGearStatsBlock")]
	private static class PanelInventoryUpdateGearPatch
	{
		private static void Postfix(Panel_Inventory __instance)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			if ((UnityEngine.Object)(object)__instance.m_SelectedSpriteObj == (UnityEngine.Object)null || (UnityEngine.Object)(object)__instance.m_SelectedSpriteTweenScale == (UnityEngine.Object)null || __instance.GetCurrentlySelectedItem() == null)
			{
				return;
			}
			if ((UnityEngine.Object)(object)__instance.GetCurrentlySelectedItem().m_GearItem == (UnityEngine.Object)null)
			{
				UILabel? rarityLabel = RarityUIManager.m_RarityLabel;
				if (rarityLabel != null)
				{
					((Component)rarityLabel).gameObject.SetActive(false);
				}
			}
			((UIWidget)__instance.m_SelectedSpriteObj.GetComponentInChildren<UISprite>()).color = RarityUIManager.GetRarityAndColour(__instance.GetCurrentlySelectedItem().m_GearItem, 1f, 0.5f);
			((UIWidget)((Component)__instance.m_SelectedSpriteTweenScale).GetComponent<UISprite>()).color = RarityUIManager.GetRarityAndColour(__instance.GetCurrentlySelectedItem().m_GearItem, 1f, 1f);
		}
	}
}
