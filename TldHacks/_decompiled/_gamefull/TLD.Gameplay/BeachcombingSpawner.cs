using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x200145C")]
public class BeachcombingSpawner : MonoBehaviour
{
	[Header("Loot Config")]
	[SerializeField]
	[Token(Token = "0x40093D5")]
	[FieldOffset(Offset = "0x20")]
	private float m_ActiveTimeAfterBlizzard;

	[SerializeField]
	[Token(Token = "0x40093D6")]
	[FieldOffset(Offset = "0x28")]
	private LootTableData m_BlizzardLootTable;

	[Header("Big Items")]
	[SerializeField]
	[Token(Token = "0x40093D7")]
	[FieldOffset(Offset = "0x30")]
	private int m_MinBigItemsToSpawn;

	[SerializeField]
	[Token(Token = "0x40093D8")]
	[FieldOffset(Offset = "0x34")]
	private int m_MaxBigItemsToSpawn;

	[SerializeField]
	[Token(Token = "0x40093D9")]
	[FieldOffset(Offset = "0x38")]
	private bool m_SpawnUniqueItems;

	[SerializeField]
	[Token(Token = "0x40093DA")]
	[FieldOffset(Offset = "0x3C")]
	private float m_BigItemTimeToDespawn;

	[SerializeField]
	[Token(Token = "0x40093DB")]
	[FieldOffset(Offset = "0x40")]
	private BeachcombingBigItemTableData m_BigItemTable;

	[Token(Token = "0x40093DC")]
	[FieldOffset(Offset = "0x48")]
	private bool m_BlizzardTableActive;

	[Token(Token = "0x40093DD")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<RadialObjectSpawner> m_ChildSpawners;

	[Token(Token = "0x40093DE")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<BeachcombingBigItemLocation> m_BigItemLocations;

	[Token(Token = "0x40093DF")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<CustomSpawnedItem> m_OldBigItems;

	[Token(Token = "0x40093E0")]
	[FieldOffset(Offset = "0x68")]
	private bool m_LastLocationCheckResult;

	[Token(Token = "0x40093E1")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_LastLocationCheckPlayerPosition;

	[Token(Token = "0x40093E3")]
	private static readonly List<BeachcombingSpawner> s_Instances;

	[Token(Token = "0x17000B35")]
	private bool IsActive
	{
		[Token(Token = "0x6008190")]
		[Address(RVA = "0x121EC60", Offset = "0x121DA60", Length = "0x57")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B36")]
	private bool HasBigItemsExpired
	{
		[Token(Token = "0x6008191")]
		[Address(RVA = "0x121ECC0", Offset = "0x121DAC0", Length = "0x53")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B37")]
	[field: Token(Token = "0x40093E2")]
	[field: FieldOffset(Offset = "0x78")]
	public BeachcombingSpawnerSaveData CurrentState
	{
		[Token(Token = "0x6008192")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get;
		[Token(Token = "0x6008193")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6008194")]
	[Address(RVA = "0x121ED20", Offset = "0x121DB20", Length = "0x23")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6008195")]
	[Address(RVA = "0x121ED50", Offset = "0x121DB50", Length = "0x373")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008196")]
	[Address(RVA = "0x121F0D0", Offset = "0x121DED0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6008197")]
	[Address(RVA = "0x121F160", Offset = "0x121DF60", Length = "0xDA")]
	private void Update()
	{
	}

	[Token(Token = "0x6008198")]
	[Address(RVA = "0x121F240", Offset = "0x121E040", Length = "0x87")]
	private void UpdateBeachcombing()
	{
	}

	[Token(Token = "0x6008199")]
	[Address(RVA = "0x121F2D0", Offset = "0x121E0D0", Length = "0x218")]
	private void SetBlizzardTable()
	{
	}

	[Token(Token = "0x600819A")]
	[Address(RVA = "0x121F4F0", Offset = "0x121E2F0", Length = "0x15E")]
	private void SetStandardTable()
	{
	}

	[Token(Token = "0x600819B")]
	[Address(RVA = "0x121F650", Offset = "0x121E450", Length = "0x39F")]
	private void CheckForNewBlizzard()
	{
	}

	[Token(Token = "0x600819C")]
	[Address(RVA = "0x121F9F0", Offset = "0x121E7F0", Length = "0x301")]
	private void UpdateBigItems()
	{
	}

	[Token(Token = "0x600819D")]
	[Address(RVA = "0x121FD00", Offset = "0x121EB00", Length = "0x458")]
	private bool IsPlayerCloseToAnyBigItemSpawnLocations()
	{
		return false;
	}

	[Token(Token = "0x600819E")]
	[Address(RVA = "0x1220160", Offset = "0x121EF60", Length = "0x291")]
	private void ExpireBigItems()
	{
	}

	[Token(Token = "0x600819F")]
	[Address(RVA = "0x1220400", Offset = "0x121F200", Length = "0xAB7")]
	private void DrawAndPlaceBigItems()
	{
	}

	[Token(Token = "0x60081A0")]
	[Address(RVA = "0x1220EC0", Offset = "0x121FCC0", Length = "0x3E8")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x60081A1")]
	[Address(RVA = "0x12212B0", Offset = "0x12200B0", Length = "0x2E0")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x60081A2")]
	[Address(RVA = "0x12215A0", Offset = "0x12203A0", Length = "0x151")]
	public void Deserialize(BeachcombingSpawnerSaveData saveData)
	{
	}

	[Token(Token = "0x60081A3")]
	[Address(RVA = "0x1221700", Offset = "0x1220500", Length = "0x57B")]
	private void DeserializeBigItems()
	{
	}

	[Token(Token = "0x60081A4")]
	[Address(RVA = "0x1221C80", Offset = "0x1220A80", Length = "0x356")]
	public BeachcombingSpawner()
	{
	}
}
