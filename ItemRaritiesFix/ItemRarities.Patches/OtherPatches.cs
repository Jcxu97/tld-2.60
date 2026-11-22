using System;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppTLD.Cooking;
using ItemRarities.Managers;
using UnityEngine;

namespace ItemRarities.Patches;

internal static class OtherPatches
{
	[HarmonyPatch(typeof(ItemDescriptionPage), "UpdateGearItemDescription")]
	private static class UpdateItemDescriptionPageRarity
	{
		private static void Postfix(ItemDescriptionPage __instance, GearItem gi)
		{
			RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_ItemNameLabel).gameObject.transform, 0f, 35f, 0f);
			RarityUIManager.UpdateRarityLabelProperties(gi);
		}
	}

	[HarmonyPatch(typeof(Panel_ActionsRadial), "UpdateDisplayText")]
	private static class UpdatePanelActionsRadialRarity
	{
		private static void Postfix(Panel_ActionsRadial __instance)
		{
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			if ((UnityEngine.Object)(object)RarityUIManager.m_RarityLabel == (UnityEngine.Object)null)
			{
				RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_SegmentLabel).gameObject.transform, 0f, 35f, 0f);
			}
			foreach (RadialMenuArm item in (Il2CppArrayBase<RadialMenuArm>)(object)__instance.m_RadialArms)
			{
				if (item.IsHoveredOver())
				{
					RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_SegmentLabel).gameObject.transform, 0f, 35f, 0f);
					RarityUIManager.UpdateRarityLabelProperties(item.m_GearItem);
					if (!((UnityEngine.Object)(object)item.m_GearItem == (UnityEngine.Object)null))
					{
						((UIWidget)item.m_BG).color = RarityUIManager.GetRarityAndColour(item.m_GearItem, 1f, 0.3f);
					}
					break;
				}
				UILabel? rarityLabel = RarityUIManager.m_RarityLabel;
				if (rarityLabel != null)
				{
					((Component)rarityLabel).gameObject.SetActive(false);
				}
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Cooking), "GetSelectedCookableItem")]
	private static class UpdatePanelCookingRarity
	{
		private static void Postfix(Panel_Cooking __instance, ref CookableItem __result)
		{
			RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_Label_CookedItemName).gameObject.transform, 0f, 35f, 0f);
			RarityUIManager.UpdateRarityLabelProperties(__result.m_GearItem);
		}
	}

	[HarmonyPatch(typeof(Panel_Crafting), "RefreshSelectedBlueprint")]
	private static class UpdatePanelCraftingRarity
	{
		private static void Postfix(Panel_Crafting __instance)
		{
			if ((UnityEngine.Object)(object)__instance.SelectedBPI == (UnityEngine.Object)null)
			{
				return;
			}
			if (__instance.SelectedBPI.m_CraftedResultDecoration != null)
			{
				UILabel? rarityLabel = RarityUIManager.m_RarityLabel;
				if (rarityLabel != null)
				{
					((Component)rarityLabel).gameObject.SetActive(false);
				}
			}
			else
			{
				RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_SelectedName).gameObject.transform, 0f, 35f, 0f);
				RarityUIManager.UpdateRarityLabelProperties(__instance.SelectedBPI.m_CraftedResultGear);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_HUD), "SetHoverText")]
	private static class UpdateHoverLabelRarity
	{
		private static void Postfix(Panel_HUD __instance, string hoverText, GameObject itemUnderCrosshairs, HoverTextState textState)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!((UnityEngine.Object)(object)itemUnderCrosshairs == (UnityEngine.Object)null) && (UnityEngine.Object)(object)itemUnderCrosshairs.GetComponent<GearItem>() != (UnityEngine.Object)null)
			{
				((UIWidget)__instance.m_Label_ObjectName).color = RarityUIManager.GetRarityAndColour(itemUnderCrosshairs.GetComponent<GearItem>(), 1f, 1f);
			}
		}
	}

	[HarmonyPatch(typeof(Panel_Inventory_Examine), "RefreshMainWindow")]
	private static class UpdatePanelInventoryExamineRarity
	{
		private static void Postfix(Panel_Inventory_Examine __instance)
		{
			RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_Item_Label).gameObject.transform, 0f, 35f, 0f);
			RarityUIManager.UpdateRarityLabelProperties(__instance.m_GearItem);
		}
	}

	[HarmonyPatch(typeof(Panel_Milling), "GetSelected")]
	private static class UpdatePanelMillingRarity
	{
		private static void Postfix(Panel_Milling __instance, ref GearItem __result)
		{
			RarityUIManager.InstantiateOrMoveRarityLabel(((Component)__instance.m_NameLabel).gameObject.transform, 0f, 35f, 0f);
			RarityUIManager.UpdateRarityLabelProperties(__result);
		}
	}

	[HarmonyPatch(typeof(PlayerManager), "InitLabelsForGear")]
	private static class UpdatePlayerManagerInspectModeRarity
	{
		private static void Prefix(PlayerManager __instance)
		{
			Panel_HUD panel = InterfaceManager.GetPanel<Panel_HUD>();
			if ((UnityEngine.Object)(object)RarityUIManager.m_RarityLabelInspect == (UnityEngine.Object)null)
			{
				RarityUIManager.InstantiateInspectRarityLabel(((Component)panel.m_InspectModeDetailsGrid).gameObject.transform);
			}
			RarityUIManager.UpdateRarityLabelProperties(__instance.m_Gear, inspectLabel: true);
			UIWidget label = RarityUIManager.m_RarityLabelInspect;
			if (label == null)
			{
				return;
			}
			Panel_HUD.InspectFade val = ((Il2CppArrayBase<Panel_HUD.InspectFade>)(object)panel.m_InspectFadeSequence)[1];
			Il2CppReferenceArray<UIWidget> elems = val.m_FadeElements;
			// 原版每次进检查画面都复制数组再追加一份,数组越拼越长,2026-10-28 读到失效指针把 .NET 运行时打崩;改成只追加一次
			for (int i = 0; i < elems.Length; i++)
			{
				UIWidget w = elems[i];
				if (w != null && w.Pointer == label.Pointer)
				{
					return;
				}
			}
			UIWidget[] array = new UIWidget[elems.Length + 1];
			for (int i = 0; i < elems.Length; i++)
			{
				array[i] = elems[i];
			}
			array[elems.Length] = label;
			val.m_FadeElements = new Il2CppReferenceArray<UIWidget>(array);
		}
	}
}
