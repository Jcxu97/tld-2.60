using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x200145A")]
public class BeachcombingSpawnerSaveData
{
	[Token(Token = "0x40093CE")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40093CF")]
	[FieldOffset(Offset = "0x18")]
	public int m_LastActiveBlizzardID;

	[Token(Token = "0x40093D0")]
	[FieldOffset(Offset = "0x20")]
	public List<BeachcombingBigItemSaveData> m_BigItems;

	[Token(Token = "0x40093D1")]
	[FieldOffset(Offset = "0x28")]
	public int m_BigItemsToSpawn;

	[Token(Token = "0x600818E")]
	[Address(RVA = "0x121EBB0", Offset = "0x121D9B0", Length = "0xAD")]
	public BeachcombingSpawnerSaveData()
	{
	}
}
