using System;
using Cpp2ILInjected;

namespace TLD.Gear;

[Serializable]
[Token(Token = "0x2001447")]
public class RandomGearItem
{
	[Token(Token = "0x400939A")]
	[FieldOffset(Offset = "0x10")]
	public LootTableData m_LootTable;

	[Token(Token = "0x400939B")]
	[FieldOffset(Offset = "0x18")]
	public int m_MinCount;

	[Token(Token = "0x400939C")]
	[FieldOffset(Offset = "0x1C")]
	public int m_MaxCount;

	[Token(Token = "0x6008136")]
	[Address(RVA = "0x1218E20", Offset = "0x1217C20", Length = "0x8")]
	public RandomGearItem()
	{
	}
}
