using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200078F")]
public class NotificationFlagManager : MonoBehaviour
{
	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40050E2")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x40050E3")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Clothing> m_ClothingPanel;

	[SerializeField]
	[Token(Token = "0x40050E4")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_Crafting> m_CraftingPanel;

	[SerializeField]
	[Token(Token = "0x40050E5")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_FirstAid> m_FirstAidPanel;

	[SerializeField]
	[Token(Token = "0x40050E6")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Inventory> m_InventoryPanel;

	[SerializeField]
	[Token(Token = "0x40050E7")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_Log> m_LogPanel;

	[SerializeField]
	[Token(Token = "0x40050E8")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_Map> m_MapPanel;

	[SerializeField]
	[Token(Token = "0x40050E9")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_MissionsStory> m_MissionsStoryPanel;

	[Token(Token = "0x40050EA")]
	[FieldOffset(Offset = "0x78")]
	public List<Panel_Base> m_Panels;

	[Token(Token = "0x40050EB")]
	private static Dictionary<string, NotificationFlagInfo> m_NotificationData;

	[Token(Token = "0x40050EC")]
	[FieldOffset(Offset = "0x80")]
	private NotificationSaveData m_NotificationSaveData;

	[Token(Token = "0x14000010")]
	public event Action<NotificationFlagInfo> m_NotificationAdded
	{
		[CompilerGenerated]
		[Token(Token = "0x6004697")]
		[Address(RVA = "0xCAB860", Offset = "0xCAA660", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004698")]
		[Address(RVA = "0xCAB9D0", Offset = "0xCAA7D0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event Action<NotificationFlagInfo> m_SubcategoryNotificationRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x6004699")]
		[Address(RVA = "0xCABB40", Offset = "0xCAA940", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600469A")]
		[Address(RVA = "0xCABCB0", Offset = "0xCAAAB0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public event Action<NotificationFlagInfo> m_MaincategoryNotificationRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x600469B")]
		[Address(RVA = "0xCABE20", Offset = "0xCAAC20", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600469C")]
		[Address(RVA = "0xCABF90", Offset = "0xCAAD90", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x600469D")]
	[Address(RVA = "0xCAC100", Offset = "0xCAAF00", Length = "0x93")]
	private void Start()
	{
	}

	[Token(Token = "0x600469E")]
	[Address(RVA = "0xCAC1A0", Offset = "0xCAAFA0", Length = "0x76")]
	public void AddNotification(PanelType panelType, MainCategory mainCategory, SubCategory subCategory, string nameId, GearItem gearItem = null)
	{
	}

	[Token(Token = "0x600469F")]
	[Address(RVA = "0xCAC220", Offset = "0xCAB020", Length = "0xDA")]
	public void OnNewNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x60046A0")]
	[Address(RVA = "0xCAC300", Offset = "0xCAB100", Length = "0x359")]
	public void HandleOnNotificationSelected(string key, NotificationFlagInfo nfi)
	{
	}

	[Token(Token = "0x60046A1")]
	[Address(RVA = "0xCAC660", Offset = "0xCAB460", Length = "0x4A6")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60046A2")]
	[Address(RVA = "0xCACB10", Offset = "0xCAB910", Length = "0x216")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60046A3")]
	[Address(RVA = "0xCACD30", Offset = "0xCABB30", Length = "0x2C4")]
	private void ShowNotificationFlagsOnMiniTopNavNar(PanelType panelType, bool enable)
	{
	}

	[Token(Token = "0x60046A4")]
	[Address(RVA = "0xCAD000", Offset = "0xCABE00", Length = "0x1AF")]
	private void AddPanels()
	{
	}

	[Token(Token = "0x60046A5")]
	[Address(RVA = "0xCAD1B0", Offset = "0xCABFB0", Length = "0x137")]
	private void AddPanelIfNotNull(Panel_Base panel)
	{
	}

	[Token(Token = "0x60046A6")]
	[Address(RVA = "0xCAD2F0", Offset = "0xCAC0F0", Length = "0xB09")]
	private void SubscribeToEvents()
	{
	}

	[Token(Token = "0x60046A7")]
	[Address(RVA = "0xCADE00", Offset = "0xCACC00", Length = "0xB09")]
	private void UnsubscribeEvents()
	{
	}

	[Token(Token = "0x60046A8")]
	[Address(RVA = "0xCAE910", Offset = "0xCAD710", Length = "0x17F")]
	public NotificationFlagManager()
	{
	}
}
