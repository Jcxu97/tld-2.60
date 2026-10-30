using System;
using HarmonyLib;
using Il2Cpp;
using ItemRarities.Managers;
using ItemRarities.Utilities;
using UnityEngine;

namespace ItemRarities.Patches;

internal static class ContainerPatches
{
	[HarmonyPatch(typeof(InventoryGridItem), "OnClick")]
	private static class InventoryGridItemClickPatch
	{
		private static void Postfix(InventoryGridItem __instance)
		{
			Panel_Container panel = InterfaceManager.GetPanel<Panel_Container>();
			if (!((UnityEngine.Object)(object)panel == (UnityEngine.Object)null))
			{
				RarityUIManager.UpdateContainerColours(panel);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "Initialize")]
	private static class PanelContainerInitializePatch
	{
		private static void Postfix(Panel_Container __instance)
		{
			UIButtonExtensions.NewSortButton(__instance.m_SortButtons, "Button_SortRarity", "ico_Star", (Action<UIButton>)__instance.OnSortInventoryChange, 100f, 1.8f, 0f);
			__instance.m_SortFlipDictionary.Add("GAMEPLAY_SortRarity", false);
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "OnSortInventoryChange")]
	private static class PanelContainerInventorySortedPatch
	{
		private static void Prefix(Panel_Container __instance, UIButton sortButtonClicked)
		{
			if (((UnityEngine.Object)sortButtonClicked).name == "Button_SortRarity" && __instance.m_InventorySortName == "GAMEPLAY_SortRarity")
			{
				RarityUIManager.ToggleRaritySort();
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "UpdateFilteredContainerList")]
	private static class PanelContainerContainerListPatch
	{
		private static void Postfix(Panel_Container __instance)
		{
			if (__instance.m_InventorySortName == "GAMEPLAY_SortRarity")
			{
				RarityUIManager.CompareGearByRarity(__instance);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "UpdateFilteredInventoryList")]
	private static class PanelContainerInventoryListPatch
	{
		private static void Postfix(Panel_Container __instance)
		{
			if (__instance.m_InventorySortName == "GAMEPLAY_SortRarity")
			{
				RarityUIManager.CompareGearByRarityInventory(__instance);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Container), "Update")]
	private static class PanelContainerUpdatePatch
	{
		private static void Postfix(Panel_Container __instance)
		{
			if (__instance.m_FilteredContainerList.Count != 0 && __instance.m_FilteredInventoryList.Count != 0)
			{
				RarityUIManager.UpdateContainerColours(__instance);
			}
		}
	}
}
