using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[CreateAssetMenu(menuName = "The Long Dark/SpawnRegionAnimalTable")]
[Token(Token = "0x2001509")]
public class SpawnRegionAnimalTableSO : ScriptableObject
{
	[Token(Token = "0x400983C")]
	[FieldOffset(Offset = "0x18")]
	public List<SpawnAnimalTableEntry> m_SpawnAnimalsList;

	[Token(Token = "0x400983D")]
	[FieldOffset(Offset = "0x20")]
	private float m_TotalOdds;

	[Token(Token = "0x6008502")]
	[Address(RVA = "0x126ECA0", Offset = "0x126DAA0", Length = "0x272")]
	public AssetReferenceAnimalPrefab FindAnimalPrefab(string assetReferenceGUID)
	{
		return null;
	}

	[Token(Token = "0x6008503")]
	[Address(RVA = "0x126EF20", Offset = "0x126DD20", Length = "0x42B")]
	public AssetReferenceAnimalPrefab PickSpawnAnimal(WildlifeMode mode)
	{
		return null;
	}

	[Token(Token = "0x6008504")]
	[Address(RVA = "0x126F350", Offset = "0x126E150", Length = "0x40")]
	private AssetReferenceAnimalPrefab GetEntryAnimalFromMode(SpawnAnimalTableEntry entry, WildlifeMode mode)
	{
		return null;
	}

	[Token(Token = "0x6008505")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public SpawnRegionAnimalTableSO()
	{
	}
}
