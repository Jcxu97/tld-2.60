using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[RequireComponent(typeof(RockCache), typeof(Container))]
[Token(Token = "0x2000572")]
public class RockCacheInteraction : TimedHoldInteraction
{
	[SerializeField]
	[Token(Token = "0x4003228")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[Token(Token = "0x4003229")]
	[FieldOffset(Offset = "0x70")]
	private RockCache m_RockCache;

	[Token(Token = "0x400322A")]
	[FieldOffset(Offset = "0x78")]
	private Container m_Container;

	[Token(Token = "0x400322B")]
	[FieldOffset(Offset = "0x80")]
	private List<ActionPickerItemData> m_ItemData;

	[Token(Token = "0x400322C")]
	[FieldOffset(Offset = "0x88")]
	private ActionPickerItemData m_OpenActionData;

	[Token(Token = "0x400322D")]
	[FieldOffset(Offset = "0x90")]
	private ActionPickerItemData m_LabelActionData;

	[Token(Token = "0x400322E")]
	[FieldOffset(Offset = "0x98")]
	private ActionPickerItemData m_DismantleData;

	[Token(Token = "0x400322F")]
	[FieldOffset(Offset = "0xA0")]
	private ActionPickerItemData m_DismantleDisableData;

	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x8F6330", Offset = "0x8F5130", Length = "0x47D")]
	private void Awake()
	{
	}

	[Token(Token = "0x60029F4")]
	[Address(RVA = "0x8F67B0", Offset = "0x8F55B0", Length = "0x276")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x60029F5")]
	[Address(RVA = "0x8F6A30", Offset = "0x8F5830", Length = "0x177")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x60029F6")]
	[Address(RVA = "0x8F6BB0", Offset = "0x8F59B0", Length = "0x23")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60029F7")]
	[Address(RVA = "0x8F6BE0", Offset = "0x8F59E0", Length = "0x148")]
	private void ShowActionPanel()
	{
	}

	[Token(Token = "0x60029F8")]
	[Address(RVA = "0x8F6D30", Offset = "0x8F5B30", Length = "0x296")]
	private string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x8F6FD0", Offset = "0x8F5DD0", Length = "0x142")]
	public RockCacheInteraction()
	{
	}
}
