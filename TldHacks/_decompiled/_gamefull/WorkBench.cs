using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005C3")]
public class WorkBench : MonoBehaviour, CraftingLocationInterface
{
	[Token(Token = "0x400352E")]
	[FieldOffset(Offset = "0x20")]
	public float m_CraftingAndRepairSkillModifier;

	[Token(Token = "0x400352F")]
	[FieldOffset(Offset = "0x24")]
	public float m_CraftingAndRepairTimeModifier;

	[Token(Token = "0x4003530")]
	[FieldOffset(Offset = "0x28")]
	public PanelReference<Panel_Crafting> m_CraftingPanel;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003531")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[Token(Token = "0x4003532")]
	[FieldOffset(Offset = "0x38")]
	protected readonly List<ActionPickerItemData> m_Actions;

	[Token(Token = "0x6002C8E")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[Token(Token = "0x6002C8F")]
	[Address(RVA = "0x938070", Offset = "0x936E70", Length = "0x47")]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyForBlueprint(BlueprintData _)
	{
		return false;
	}

	[Token(Token = "0x6002C91")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ReadyToCraft()
	{
		return false;
	}

	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x9380C0", Offset = "0x936EC0", Length = "0x26E")]
	public void InitializeWorkbenchInteraction()
	{
	}

	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x938330", Offset = "0x937130", Length = "0x87")]
	public void InteractWithWorkbench()
	{
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x9383C0", Offset = "0x9371C0", Length = "0x6C")]
	public void OnCrafting()
	{
	}

	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x938430", Offset = "0x937230", Length = "0x9F")]
	public void OnBreakDown()
	{
	}

	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool HoldsCraftingResult()
	{
		return false;
	}

	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public Container GetContainer()
	{
		return null;
	}

	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x9384D0", Offset = "0x9372D0", Length = "0xE3")]
	public WorkBench()
	{
	}
}
