using System.Collections;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using ItemRarities.Components;
using ItemRarities.Enums;
using ItemRarities.Properties;
using ItemRarities.Utilities;
using UnityEngine;

namespace ItemRarities.Managers;

internal static class RarityUIManager
{
	private static bool isRaritySortDescending = true;

	internal static UILabel? m_RarityLabel;

	internal static UILabel? m_RarityLabelInspect;

	internal static void CompareGearByRarity(Panel_Inventory panelInventory)
	{
		System.Collections.Generic.List<InventoryGridDataItem> list = new System.Collections.Generic.List<InventoryGridDataItem>();
		for (int i = 0; i < panelInventory.m_FilteredInventoryList.Count; i++)
		{
			list.Add(panelInventory.m_FilteredInventoryList[i]);
		}
		list.Sort(delegate(InventoryGridDataItem a, InventoryGridDataItem b)
		{
			Rarities rarities = (((Object)(object)((a != null) ? a.m_GearItem : null) != (Object)null) ? RarityManager.GetRarity(((Object)a.m_GearItem).name) : Rarities.None);
			Rarities rarities2 = (((Object)(object)((b != null) ? b.m_GearItem : null) != (Object)null) ? RarityManager.GetRarity(((Object)b.m_GearItem).name) : Rarities.None);
			return (!isRaritySortDescending) ? rarities.CompareTo(rarities2) : rarities2.CompareTo(rarities);
		});
		panelInventory.m_FilteredInventoryList.Clear();
		foreach (InventoryGridDataItem item in list)
		{
			panelInventory.m_FilteredInventoryList.Add(item);
		}
	}

	internal static void CompareGearByRarity(Panel_Container panelContainer)
	{
		System.Collections.Generic.List<InventoryGridDataItem> list = new System.Collections.Generic.List<InventoryGridDataItem>();
		for (int i = 0; i < panelContainer.m_FilteredContainerList.Count; i++)
		{
			list.Add(panelContainer.m_FilteredContainerList[i]);
		}
		list.Sort(delegate(InventoryGridDataItem a, InventoryGridDataItem b)
		{
			Rarities rarities = (((Object)(object)((a != null) ? a.m_GearItem : null) != (Object)null) ? RarityManager.GetRarity(((Object)a.m_GearItem).name) : Rarities.None);
			Rarities rarities2 = (((Object)(object)((b != null) ? b.m_GearItem : null) != (Object)null) ? RarityManager.GetRarity(((Object)b.m_GearItem).name) : Rarities.None);
			return (!isRaritySortDescending) ? rarities.CompareTo(rarities2) : rarities2.CompareTo(rarities);
		});
		panelContainer.m_FilteredContainerList.Clear();
		foreach (InventoryGridDataItem item in list)
		{
			panelContainer.m_FilteredContainerList.Add(item);
		}
	}

	internal static void CompareGearByRarityInventory(Panel_Container panelContainer)
	{
		System.Collections.Generic.List<InventoryGridDataItem> list = new System.Collections.Generic.List<InventoryGridDataItem>();
		for (int i = 0; i < panelContainer.m_FilteredInventoryList.Count; i++)
		{
			list.Add(panelContainer.m_FilteredInventoryList[i]);
		}
		list.Sort(delegate(InventoryGridDataItem a, InventoryGridDataItem b)
		{
			Rarities rarities = (((Object)(object)((a != null) ? a.m_GearItem : null) != (Object)null) ? RarityManager.GetRarity(((Object)a.m_GearItem).name) : Rarities.None);
			Rarities rarities2 = (((Object)(object)((b != null) ? b.m_GearItem : null) != (Object)null) ? RarityManager.GetRarity(((Object)b.m_GearItem).name) : Rarities.None);
			return (!isRaritySortDescending) ? rarities.CompareTo(rarities2) : rarities2.CompareTo(rarities);
		});
		panelContainer.m_FilteredInventoryList.Clear();
		foreach (InventoryGridDataItem item in list)
		{
			panelContainer.m_FilteredInventoryList.Add(item);
		}
	}

	internal static IEnumerator DelayedUpdateAllSlots(Panel_Clothing panel)
	{
		yield return (object)new WaitForEndOfFrame();
		Il2CppSystem.Collections.Generic.List<ClothingSlot>.Enumerator enumerator = panel.m_ClothingSlots.GetEnumerator();
		while (enumerator.MoveNext())
		{
			UpdateClothingSlotColors(enumerator.Current);
		}
	}

	internal static Color GetRarityAndColour(GearItem gearItem, float alpha = 1f, float secondAlpha = 0f)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)gearItem == (Object)null))
		{
			return GetRarityColour(RarityManager.GetRarity(((Object)gearItem).name), alpha, secondAlpha);
		}
		return GetRarityColour(Rarities.None, alpha, secondAlpha);
	}

	private static Color GetRarityColour(Rarities rarity, float alpha = 1f, float secondAlpha = 0f)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (Settings.Instance.customColours)
		{
			return (Color)(rarity switch
			{
				Rarities.Common => new Color(Settings.Instance.commonRed, Settings.Instance.commonGreen, Settings.Instance.commonBlue, alpha), 
				Rarities.Uncommon => new Color(Settings.Instance.uncommonRed, Settings.Instance.uncommonGreen, Settings.Instance.uncommonBlue, alpha), 
				Rarities.Rare => new Color(Settings.Instance.rareRed, Settings.Instance.rareGreen, Settings.Instance.rareBlue, alpha), 
				Rarities.Epic => new Color(Settings.Instance.epicRed, Settings.Instance.epicGreen, Settings.Instance.epicBlue, alpha), 
				Rarities.Legendary => new Color(Settings.Instance.legendaryRed, Settings.Instance.legendaryGreen, Settings.Instance.legendaryBlue, alpha), 
				Rarities.Mythic => new Color(Settings.Instance.mythicRed, Settings.Instance.mythicGreen, Settings.Instance.mythicBlue, alpha), 
				_ => new Color(1f, 1f, 1f, secondAlpha), 
			});
		}
		return (Color)(rarity switch
		{
			Rarities.Common => new Color(0.6f, 0.6f, 0.6f, alpha), 
			Rarities.Uncommon => new Color(0.3f, 0.7f, 0f, alpha), 
			Rarities.Rare => new Color(0f, 0.6f, 0.9f, alpha), 
			Rarities.Epic => new Color(0.7f, 0.3f, 0.9f, alpha), 
			Rarities.Legendary => new Color(0.9f, 0.5f, 0.2f, alpha), 
			Rarities.Mythic => new Color(0.8f, 0.7f, 0.3f, alpha), 
			_ => new Color(1f, 1f, 1f, secondAlpha), 
		});
	}

	private static string GetRarityLocalizationKey(Rarities rarity)
	{
		return rarity switch
		{
			Rarities.Common => Localization.Get("GAMEPLAY_RarityCommon"), 
			Rarities.Uncommon => Localization.Get("GAMEPLAY_RarityUncommon"), 
			Rarities.Rare => Localization.Get("GAMEPLAY_RarityRare"), 
			Rarities.Epic => Localization.Get("GAMEPLAY_RarityEpic"), 
			Rarities.Legendary => Localization.Get("GAMEPLAY_RarityLegendary"), 
			Rarities.Mythic => Localization.Get("GAMEPLAY_RarityMythic"), 
			_ => string.Empty, 
		};
	}

	internal static void InstantiateInspectRarityLabel(Transform transform)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("RarityLabelInspectGameObject");
		val.transform.SetParent(transform, false);
		val.transform.localPosition = new Vector3(0f, 0f, 0f);
		m_RarityLabelInspect = UILabelExtensions.SetupGameObjectWithUILabel("RarityLabelInspect", val.transform, worldPositionStays: false, inspectLabel: true, 40f);
		((Component)m_RarityLabelInspect).transform.SetSiblingIndex(0);
	}

	internal static void InstantiateOrMoveRarityLabel(Transform transform, float posX, float posY, float posZ)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)m_RarityLabel == (Object)null)
		{
			m_RarityLabel = UILabelExtensions.SetupGameObjectWithUILabel("RarityLabel", transform, worldPositionStays: false, inspectLabel: false, posX, posY, posZ);
			return;
		}
		((Component)m_RarityLabel).transform.SetParent(transform, false);
		((Component)m_RarityLabel).transform.localPosition = new Vector3(posX, posY, posZ);
	}

	internal static void ToggleRaritySort()
	{
		isRaritySortDescending = !isRaritySortDescending;
	}

	internal static void UpdateClothingSlotColors(ClothingSlot slot)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)(((Object)(object)slot.m_GearItem != (Object)null) ? GetRarityAndColour(slot.m_GearItem, 1f, 0.5f) : new Color(1f, 1f, 1f, 0.5f));
		Color val2 = default(Color);
		val2 = new Color(val.r, val.g, val.b, 0.5f);
		Color pressed = default(Color);
		pressed = new Color(val.r, val.g, val.b, 0.6f);
		if ((Object)(object)slot.m_Selected != (Object)null)
		{
			Il2CppSystem.Collections.Generic.List<Transform> val3 = new Il2CppSystem.Collections.Generic.List<Transform>();
			slot.m_Selected.GetComponentsInChildren<Transform>(true, val3);
			for (int i = 0; i < val3.Count; i++)
			{
				Transform val4 = val3[i];
				string name = ((Object)((Component)val4).gameObject).name;
				if ((name == "InnerGlow" || name == "TweenedContent") ? true : false)
				{
					((UIWidget)((Component)val4).GetComponent<UISprite>()).color = val;
				}
			}
		}
		if ((Object)(object)slot.m_SpriteBoxHover != (Object)null)
		{
			((UIWidget)slot.m_SpriteBoxHover.GetComponent<UISprite>()).color = val2;
		}
		Il2CppSystem.Collections.Generic.List<Transform> val5 = new Il2CppSystem.Collections.Generic.List<Transform>();
		((Component)slot).GetComponentsInChildren<Transform>(true, val5);
		for (int j = 0; j < val5.Count; j++)
		{
			Transform val6 = val5[j];
			if (!(((Object)((Component)val6).gameObject).name != "Button"))
			{
				UIWidget component = ((Component)val6).GetComponent<UIWidget>();
				if ((Object)(object)component != (Object)null)
				{
					component.color = val;
				}
				UIButton component2 = ((Component)val6).GetComponent<UIButton>();
				if (!((Object)(object)component2 == (Object)null))
				{
					((UIButtonColor)component2).hover = val2;
					((UIButtonColor)component2).pressed = pressed;
				}
			}
		}
	}

	internal static void UpdateContainerColours(Panel_Container panelContainer)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		InventoryGridDataItem currentlySelectedItem = panelContainer.GetCurrentlySelectedItem();
		if ((Object)(object)panelContainer.m_SelectedSpriteObj == (Object)null || currentlySelectedItem == null)
		{
			return;
		}
		((UIWidget)panelContainer.m_SelectedSpriteObj.GetComponentInChildren<UISprite>()).color = GetRarityAndColour(currentlySelectedItem.m_GearItem, 1f, 0.5f);
		Il2CppSystem.Collections.Generic.List<Transform> val = new Il2CppSystem.Collections.Generic.List<Transform>();
		panelContainer.m_SelectedSpriteObj.GetComponentsInChildren<Transform>(true, val);
		for (int i = 0; i < val.Count; i++)
		{
			Transform val2 = val[i];
			if (((Object)((Component)val2).gameObject).name == "TweenedContent")
			{
				((UIWidget)((Component)val2).GetComponent<UISprite>()).color = GetRarityAndColour(currentlySelectedItem.m_GearItem, 1f, 1f);
			}
		}
	}

	internal static void UpdateRarityLabelProperties(GearItem gearItem, bool inspectLabel = false)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)gearItem == (Object)null)
		{
			return;
		}
		UILabel val = (inspectLabel ? m_RarityLabelInspect : m_RarityLabel);
		Rarities rarity = RarityManager.GetRarity(((Object)gearItem).name);
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		if (rarity == Rarities.None)
		{
			val.text = GetRarityLocalizationKey(rarity);
			((Component)val).gameObject.SetActive(false);
			return;
		}
		val.text = GetRarityLocalizationKey(rarity);
		((Component)val).gameObject.SetActive(true);
		MythicGlowEffect component = ((Component)val).GetComponent<MythicGlowEffect>();
		if ((Object)(object)component != (Object)null)
		{
			Object.Destroy((Object)(object)component);
		}
		if (rarity == Rarities.Mythic)
		{
			((Component)val).gameObject.AddComponent<MythicGlowEffect>();
		}
		((UIWidget)val).color = GetRarityColour(rarity);
	}
}
