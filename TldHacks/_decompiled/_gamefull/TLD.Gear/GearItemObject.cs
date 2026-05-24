using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x200141D")]
public struct GearItemObject
{
	[Token(Token = "0x40092E3")]
	[FieldOffset(Offset = "0x0")]
	public readonly GearItem m_GearItem;

	[Token(Token = "0x40092E4")]
	[FieldOffset(Offset = "0x8")]
	public readonly string m_GearItemName;

	[Token(Token = "0x6008032")]
	[Address(RVA = "0x1202D50", Offset = "0x1201B50", Length = "0x1CE")]
	public GearItemObject(GearItem gearItem)
	{
		m_GearItem = null;
		m_GearItemName = null;
	}

	[Token(Token = "0x6008033")]
	[Address(RVA = "0x1202F20", Offset = "0x1201D20", Length = "0xD1")]
	public static implicit operator GameObject(GearItemObject gearItemObject)
	{
		return null;
	}

	[Token(Token = "0x6008034")]
	[Address(RVA = "0xD14570", Offset = "0xD13370", Length = "0x4")]
	public static implicit operator GearItem(GearItemObject gearItemObject)
	{
		return null;
	}
}
