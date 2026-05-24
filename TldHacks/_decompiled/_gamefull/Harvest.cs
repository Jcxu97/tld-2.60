using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004AC")]
public class Harvest : HarvestBase
{
	[HideInInspector]
	[Token(Token = "0x4002B42")]
	[FieldOffset(Offset = "0x48")]
	public GearItem[] m_YieldGear;

	[HideInInspector]
	[Token(Token = "0x4002B43")]
	[FieldOffset(Offset = "0x50")]
	public int[] m_YieldGearUnits;

	[Token(Token = "0x17000239")]
	public override int YieldCount
	{
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x85E3E0", Offset = "0x85D1E0", Length = "0x1A")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x4C3B00", Offset = "0x4C2900", Length = "0x2B")]
	public override GearItem GetPrefab(int index)
	{
		return null;
	}

	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x85E400", Offset = "0x85D200", Length = "0x2B")]
	public override int GetAmount(int index)
	{
		return 0;
	}

	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x85E430", Offset = "0x85D230", Length = "0x4A")]
	public Harvest()
	{
	}
}
