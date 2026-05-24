using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x200024B")]
public class HarvestRepairMaterial : MonoBehaviour
{
	[Token(Token = "0x4001465")]
	[FieldOffset(Offset = "0x20")]
	public UITexture m_GearSprite;

	[Token(Token = "0x4001466")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_GearLabel;

	[Token(Token = "0x4001467")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_StackLabel;

	[Token(Token = "0x4001468")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_DontHaveSprite;

	[Token(Token = "0x4001469")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_LiquidLabel;

	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x48")]
	public Color m_RedColorToUse;

	[Token(Token = "0x400146B")]
	[FieldOffset(Offset = "0x58")]
	private Color m_GearLabelOrigColor;

	[Token(Token = "0x400146C")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasGottenOrigColor;

	[Token(Token = "0x6001437")]
	[Address(RVA = "0x680010", Offset = "0x67EE10", Length = "0x1A")]
	public void ShowItem(GearItem gearItem, int stackNum)
	{
	}

	[Token(Token = "0x6001438")]
	[Address(RVA = "0x680030", Offset = "0x67EE30", Length = "0x450")]
	public void ShowItem(GearItem gearItem, int stackNum, bool hasItem)
	{
	}

	[Token(Token = "0x6001439")]
	[Address(RVA = "0x680490", Offset = "0x67F290", Length = "0x566")]
	public void ShowPowder(PowderType powderType, ItemWeight amount)
	{
	}

	[Token(Token = "0x600143A")]
	[Address(RVA = "0x680A00", Offset = "0x67F800", Length = "0x26")]
	public void Hide()
	{
	}

	[Token(Token = "0x600143B")]
	[Address(RVA = "0x680A30", Offset = "0x67F830", Length = "0x2C")]
	private void GetOrigColor()
	{
	}

	[Token(Token = "0x600143C")]
	[Address(RVA = "0x680A60", Offset = "0x67F860", Length = "0x53")]
	public HarvestRepairMaterial()
	{
	}
}
