using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004B9")]
public class LootTable : MonoBehaviour
{
	[Token(Token = "0x4002B7C")]
	[FieldOffset(Offset = "0x20")]
	public LootTableData m_LootData;

	[HideInInspector]
	[Token(Token = "0x4002B7D")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> m_Prefabs;

	[HideInInspector]
	[Token(Token = "0x4002B7E")]
	[FieldOffset(Offset = "0x30")]
	public List<int> m_Weights;

	[Token(Token = "0x4002B7F")]
	private const int MAX_FILTERED_LOOT_TABLE_ITEMS = 256;

	[Token(Token = "0x4002B80")]
	private static readonly string EXCEEDED_LIMIT_LOG_MESSAGE;

	[Token(Token = "0x4002B81")]
	private static LootTableItem[] m_FilteredLootTableItems;

	[Token(Token = "0x6002418")]
	[Address(RVA = "0x861400", Offset = "0x860200", Length = "0x458")]
	public GameObject GetRandomGearPrefab()
	{
		return null;
	}

	[Token(Token = "0x6002419")]
	[Address(RVA = "0x861860", Offset = "0x860660", Length = "0x1A5")]
	private int PopulateFilteredLootTable_Legacy()
	{
		return 0;
	}

	[Token(Token = "0x600241A")]
	[Address(RVA = "0x861A10", Offset = "0x860810", Length = "0x20A")]
	public GameObject GetPrefab(string name)
	{
		return null;
	}

	[Token(Token = "0x600241B")]
	[Address(RVA = "0x861C20", Offset = "0x860A20", Length = "0x130")]
	public GameObject GetPrefab_Legacy(string name)
	{
		return null;
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0x861D60", Offset = "0x860B60", Length = "0x18D")]
	private bool DisableForXPMode(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x600241D")]
	[Address(RVA = "0x861EF0", Offset = "0x860CF0", Length = "0x18F")]
	public LootTable()
	{
	}
}
