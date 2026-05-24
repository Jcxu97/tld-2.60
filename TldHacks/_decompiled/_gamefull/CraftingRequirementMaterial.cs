using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x2000221")]
public class CraftingRequirementMaterial : MonoBehaviour
{
	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_Display;

	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0x28")]
	public UITexture m_Icon;

	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0x30")]
	private Color m_DisplayTint;

	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x40")]
	private Color m_IconTint;

	[Token(Token = "0x600130C")]
	[Address(RVA = "0x663440", Offset = "0x662240", Length = "0x36")]
	public void Awake()
	{
	}

	[Token(Token = "0x600130D")]
	[Address(RVA = "0x663480", Offset = "0x662280", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0x663520", Offset = "0x662320", Length = "0x356")]
	public void Enable(Panel_Crafting panel, BlueprintData bp, InProgressCraftItem wip, int requiredIndex, int quantity)
	{
	}

	[Token(Token = "0x600130F")]
	[Address(RVA = "0x663880", Offset = "0x662680", Length = "0x4A2")]
	public void EnableForLiquid(Panel_Crafting panel, BlueprintData bp, InProgressCraftItem wip, int liquidIndex, int quantity)
	{
	}

	[Token(Token = "0x6001310")]
	[Address(RVA = "0x663D30", Offset = "0x662B30", Length = "0x485")]
	public void EnableForPowder(Panel_Crafting panel, BlueprintData bp, InProgressCraftItem wip, int powderIndex, int quantity)
	{
	}

	[Token(Token = "0x6001311")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001312")]
	[Address(RVA = "0x6641C0", Offset = "0x662FC0", Length = "0x208")]
	private void ApplyTints(bool requirementsMet, Color requirementsNotMetTint)
	{
	}

	[Token(Token = "0x6001313")]
	[Address(RVA = "0x6643D0", Offset = "0x6631D0", Length = "0x1BA")]
	private bool ShowRequiredCountLabel(BlueprintData bp, InProgressCraftItem wip, int requiredIndex, int quantity, GearItem requiredGearItem)
	{
		return false;
	}

	[Token(Token = "0x6001314")]
	[Address(RVA = "0x664590", Offset = "0x663390", Length = "0x238")]
	private bool ShowRequiredAmountLabel(BlueprintData bp, InProgressCraftItem wip, int requiredIndex, int quantity, GearItem requiredGearItem)
	{
		return false;
	}

	[Token(Token = "0x6001315")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CraftingRequirementMaterial()
	{
	}
}
