using System;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x200145B")]
public class BeachcombingBigItemSaveData
{
	[Token(Token = "0x40093D2")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40093D3")]
	[FieldOffset(Offset = "0x18")]
	public string m_LocationGuid;

	[NonSerialized]
	[Token(Token = "0x40093D4")]
	[FieldOffset(Offset = "0x20")]
	public CustomSpawnedItem m_BigSpawnedItem;

	[Token(Token = "0x600818F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BeachcombingBigItemSaveData()
	{
	}
}
