using Cpp2ILInjected;
using TLD.IntBackedUnit;

[Token(Token = "0x2000251")]
public class InventoryGridDataItem
{
	[Token(Token = "0x4001487")]
	[FieldOffset(Offset = "0x10")]
	public GearItem m_GearItem;

	[Token(Token = "0x4001488")]
	[FieldOffset(Offset = "0x18")]
	public DecorationItem m_DecorationItem;

	[Token(Token = "0x170001CC")]
	public string DisplayName
	{
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x681E70", Offset = "0x680C70", Length = "0x207")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001CD")]
	public float NormalizedCondition
	{
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x682080", Offset = "0x680E80", Length = "0x1CB")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6001451")]
	[Address(RVA = "0x682250", Offset = "0x681050", Length = "0x1FB")]
	public ItemWeight GetItemWeight(bool ignoreClothingBonus = false)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x6001452")]
	[Address(RVA = "0x682450", Offset = "0x681250", Length = "0x25A")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Token(Token = "0x6001453")]
	[Address(RVA = "0x6826B0", Offset = "0x6814B0", Length = "0x78")]
	public override int GetHashCode()
	{
		return 0;
	}

	[Token(Token = "0x6001454")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InventoryGridDataItem()
	{
	}
}
