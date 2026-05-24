using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

namespace TLD.Cooking;

[Token(Token = "0x20013FA")]
public class RecipeIngredientListItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009219")]
	[FieldOffset(Offset = "0x20")]
	private UIButton m_Button;

	[SerializeField]
	[Token(Token = "0x400921A")]
	[FieldOffset(Offset = "0x28")]
	private TweenScale m_TweenScale;

	[SerializeField]
	[Token(Token = "0x400921B")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_ItemElements;

	[SerializeField]
	[Token(Token = "0x400921C")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_Selected;

	[SerializeField]
	[Token(Token = "0x400921D")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_RuinedState;

	[SerializeField]
	[Token(Token = "0x400921E")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_NameLabel;

	[SerializeField]
	[Token(Token = "0x400921F")]
	[FieldOffset(Offset = "0x50")]
	private UITexture m_Icon;

	[SerializeField]
	[Token(Token = "0x4009220")]
	[FieldOffset(Offset = "0x58")]
	private UILabel m_RequirementLabel;

	[SerializeField]
	[Token(Token = "0x4009221")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_RequirementsMetIndicator;

	[SerializeField]
	[Token(Token = "0x4009222")]
	[FieldOffset(Offset = "0x68")]
	private Color m_HasIngredientColor;

	[SerializeField]
	[Token(Token = "0x4009223")]
	[FieldOffset(Offset = "0x78")]
	private Color m_MissingIngredientColor;

	[Token(Token = "0x6007F62")]
	[Address(RVA = "0x11F4240", Offset = "0x11F3040", Length = "0xF1")]
	public void SetSelected(bool isSelected)
	{
	}

	[Token(Token = "0x6007F63")]
	[Address(RVA = "0x11F4340", Offset = "0x11F3140", Length = "0x1F2")]
	public void SetRecipeRequirement(BlueprintData.RequiredGearItem requiredGear, Inventory inventory)
	{
	}

	[Token(Token = "0x6007F64")]
	[Address(RVA = "0x11F4540", Offset = "0x11F3340", Length = "0x1E1")]
	public void SetRecipeRequirement(BlueprintData.RequiredPowder requiredPowder, Inventory inventory)
	{
	}

	[Token(Token = "0x6007F65")]
	[Address(RVA = "0x11F4730", Offset = "0x11F3530", Length = "0x1E1")]
	public void SetRecipeRequirement(BlueprintData.RequiredLiquid requiredLiquid, Inventory inventory)
	{
	}

	[Token(Token = "0x6007F66")]
	[Address(RVA = "0x11F4920", Offset = "0x11F3720", Length = "0x1E4")]
	public void SetRecipeRequirement(ItemLiquidVolume cookableRequiredWater, Inventory inventory)
	{
	}

	[Token(Token = "0x6007F67")]
	[Address(RVA = "0x11F4B10", Offset = "0x11F3910", Length = "0x327")]
	private void SetRequirementMet(bool isMet)
	{
	}

	[Token(Token = "0x6007F68")]
	[Address(RVA = "0x11F4E40", Offset = "0x11F3C40", Length = "0xF0")]
	private void SetName(string ingredientName)
	{
	}

	[Token(Token = "0x6007F69")]
	[Address(RVA = "0x11F4F40", Offset = "0x11F3D40", Length = "0x16D")]
	private void SetLabels(ItemWeight inventoryAmount, ItemWeight requiredAmount)
	{
	}

	[Token(Token = "0x6007F6A")]
	[Address(RVA = "0x11F50B0", Offset = "0x11F3EB0", Length = "0x16D")]
	private void SetLabels(ItemLiquidVolume inventoryAmount, ItemLiquidVolume requiredAmount)
	{
	}

	[Token(Token = "0x6007F6B")]
	[Address(RVA = "0x11F5220", Offset = "0x11F4020", Length = "0x1A5")]
	private void SetLabels(int inventoryCount, int requirementCount)
	{
	}

	[Token(Token = "0x6007F6C")]
	[Address(RVA = "0x11F53D0", Offset = "0x11F41D0", Length = "0x135")]
	private void SetIconFromGearItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x6007F6D")]
	[Address(RVA = "0x11F5510", Offset = "0x11F4310", Length = "0x4AD")]
	private void SetIconFromGearItemData(GearItemData gearItemData)
	{
	}

	[Token(Token = "0x6007F6E")]
	[Address(RVA = "0x11F59C0", Offset = "0x11F47C0", Length = "0x710")]
	private int SetRequirementByCount(GearItem item, int count, Inventory inventory)
	{
		return 0;
	}

	[Token(Token = "0x6007F6F")]
	[Address(RVA = "0x11F60E0", Offset = "0x11F4EE0", Length = "0x38E")]
	private ItemWeight SetRequirementByQuantity(GearItem item, ItemWeight quantity, Inventory inventory)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6007F70")]
	[Address(RVA = "0x11F6470", Offset = "0x11F5270", Length = "0x5F")]
	public RecipeIngredientListItem()
	{
	}
}
