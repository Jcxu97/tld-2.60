using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Loot Table Modification")]
[Token(Token = "0x20004BB")]
public class LootTableModData : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4002B82")]
	[FieldOffset(Offset = "0x18")]
	private List<RandomTableDataEntry<AssetReferenceGearItem>> m_AddLoot;

	[SerializeField]
	[Token(Token = "0x4002B83")]
	[FieldOffset(Offset = "0x20")]
	private List<AssetReferenceGearItem> m_RemoveLoot;

	[Token(Token = "0x17000247")]
	public IEnumerable<RandomTableDataEntry<AssetReferenceGearItem>> LootToAdd
	{
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000248")]
	public IEnumerable<AssetReferenceGearItem> LootToRemove
	{
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002426")]
	[Address(RVA = "0x862AA0", Offset = "0x8618A0", Length = "0x162")]
	public LootTableModData()
	{
	}
}
