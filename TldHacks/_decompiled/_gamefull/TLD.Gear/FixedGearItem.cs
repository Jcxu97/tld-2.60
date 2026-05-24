using System;
using Cpp2ILInjected;

namespace TLD.Gear;

[Serializable]
[Token(Token = "0x2001446")]
public class FixedGearItem
{
	[Token(Token = "0x4009398")]
	[FieldOffset(Offset = "0x10")]
	public AssetReferenceGearItem m_GearItem;

	[Token(Token = "0x4009399")]
	[FieldOffset(Offset = "0x18")]
	public int m_Count;

	[Token(Token = "0x6008135")]
	[Address(RVA = "0x1195710", Offset = "0x1194510", Length = "0x8")]
	public FixedGearItem()
	{
	}
}
