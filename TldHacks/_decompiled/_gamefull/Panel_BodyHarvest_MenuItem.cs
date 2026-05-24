using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x2000612")]
public class Panel_BodyHarvest_MenuItem : Panel_Base
{
	[Token(Token = "0x2000613")]
	public enum AmountType
	{
		[Token(Token = "0x40038FC")]
		Weight,
		[Token(Token = "0x40038FD")]
		Unit
	}

	[Token(Token = "0x40038EF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label;

	[Token(Token = "0x40038F0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_Button_Increase;

	[Token(Token = "0x40038F1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Button_Decrease;

	[Token(Token = "0x40038F2")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_Background;

	[Token(Token = "0x40038F3")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_LabelItemAmount;

	[Token(Token = "0x40038F4")]
	[FieldOffset(Offset = "0x50")]
	public UITexture m_MeatTexture;

	[SerializeField]
	[Token(Token = "0x40038F5")]
	[FieldOffset(Offset = "0x58")]
	private ItemWeight m_HarvestWeightIncrements;

	[Token(Token = "0x40038F6")]
	[FieldOffset(Offset = "0x60")]
	public AmountType m_AmountType;

	[Token(Token = "0x170002DE")]
	[field: Token(Token = "0x40038F7")]
	[field: FieldOffset(Offset = "0x68")]
	public ItemWeight HarvestAmount
	{
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get;
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x99B080", Offset = "0x999E80", Length = "0x5")]
		set;
	}

	[Token(Token = "0x170002DF")]
	[field: Token(Token = "0x40038F8")]
	[field: FieldOffset(Offset = "0x70")]
	public ItemWeight HarvestAmountAvailable
	{
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get;
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x99B090", Offset = "0x999E90", Length = "0x5")]
		set;
	}

	[Token(Token = "0x170002E0")]
	[field: Token(Token = "0x40038F9")]
	[field: FieldOffset(Offset = "0x78")]
	public int HarvestUnits
	{
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x657EE0", Offset = "0x656CE0", Length = "0x4")]
		get;
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x99B0A0", Offset = "0x999EA0", Length = "0x4")]
		set;
	}

	[Token(Token = "0x170002E1")]
	[field: Token(Token = "0x40038FA")]
	[field: FieldOffset(Offset = "0x7C")]
	public int HarvestUnitsAvailable
	{
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x658F10", Offset = "0x657D10", Length = "0x4")]
		get;
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x99B0B0", Offset = "0x999EB0", Length = "0x4")]
		set;
	}

	[Token(Token = "0x6002FEA")]
	[Address(RVA = "0x99B0C0", Offset = "0x999EC0", Length = "0xBF")]
	private void RefreshWeightLabel()
	{
	}

	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x99B180", Offset = "0x999F80", Length = "0x147")]
	private void RefreshUnitLabel()
	{
	}

	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x99B2D0", Offset = "0x99A0D0", Length = "0x2BE")]
	public void RefreshLabel()
	{
	}

	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x99B590", Offset = "0x99A390", Length = "0x1D2")]
	public void MaybeRefreshTexture(GearItem gearItem, float carcassCondition)
	{
	}

	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x99B770", Offset = "0x99A570", Length = "0x187")]
	private void OnChangeHarvestAmount(ItemWeight increment)
	{
	}

	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x99B900", Offset = "0x99A700", Length = "0xB3")]
	private void OnChangeHarvestUnits(int increment)
	{
	}

	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x99B9C0", Offset = "0x99A7C0", Length = "0xAD")]
	public void OnIncreaseHarvestAmount()
	{
	}

	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x99BA70", Offset = "0x99A870", Length = "0xF6")]
	public void OnDecreaseHarvestAmount()
	{
	}

	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_BodyHarvest_MenuItem()
	{
	}
}
