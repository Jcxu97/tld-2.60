using System;
using Cpp2ILInjected;

namespace TLD.AI;

[Serializable]
[Token(Token = "0x2001508")]
public class SpawnAnimalTableEntry
{
	[Token(Token = "0x4009839")]
	[FieldOffset(Offset = "0x10")]
	public AssetReferenceAnimalPrefab m_AnimalPrefab;

	[Token(Token = "0x400983A")]
	[FieldOffset(Offset = "0x18")]
	public AssetReferenceAnimalPrefab m_AuroraAnimalPrefab;

	[Token(Token = "0x400983B")]
	[FieldOffset(Offset = "0x20")]
	public float m_Odds;

	[Token(Token = "0x6008501")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SpawnAnimalTableEntry()
	{
	}
}
