using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001442")]
public class SpawnGearVariant : MonoBehaviour
{
	[Token(Token = "0x2001443")]
	public class SaveData
	{
		[Token(Token = "0x4009390")]
		[FieldOffset(Offset = "0x10")]
		public string m_SpawnerGUID;

		[Token(Token = "0x6008132")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveData()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x400938B")]
	[FieldOffset(Offset = "0x20")]
	private List<AssetReferenceGearItem> m_PrioritySpawnList;

	[Token(Token = "0x400938C")]
	[FieldOffset(Offset = "0x28")]
	private GearItem m_SpawnedItem;

	[Token(Token = "0x400938D")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasSaveData;

	[Token(Token = "0x400938E")]
	private static readonly List<SpawnGearVariant> s_ActiveSpawners;

	[Token(Token = "0x400938F")]
	private static readonly List<SaveData> s_SaveData;

	[Token(Token = "0x6008127")]
	[Address(RVA = "0x12174D0", Offset = "0x12162D0", Length = "0x473")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008128")]
	[Address(RVA = "0x1217950", Offset = "0x1216750", Length = "0x294")]
	public static void Deserialize(string jsonText)
	{
	}

	[Token(Token = "0x6008129")]
	[Address(RVA = "0x1217BF0", Offset = "0x12169F0", Length = "0xBD")]
	private void Awake()
	{
	}

	[Token(Token = "0x600812A")]
	[Address(RVA = "0x1217CB0", Offset = "0x1216AB0", Length = "0x5D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600812B")]
	[Address(RVA = "0x1218290", Offset = "0x1217090", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600812C")]
	[Address(RVA = "0x1218320", Offset = "0x1217120", Length = "0xB4")]
	private SaveData GetSaveData()
	{
		return null;
	}

	[Token(Token = "0x600812D")]
	[Address(RVA = "0x12183E0", Offset = "0x12171E0", Length = "0x19C")]
	private void MarkAsDeserialized()
	{
	}

	[Token(Token = "0x600812E")]
	[Address(RVA = "0x1218580", Offset = "0x1217380", Length = "0x193")]
	private void DeleteSpawnedItem()
	{
	}

	[Token(Token = "0x600812F")]
	[Address(RVA = "0x1218720", Offset = "0x1217520", Length = "0x1E4")]
	private static SpawnGearVariant FindSpawner(string spawnerGuid)
	{
		return null;
	}

	[Token(Token = "0x6008130")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SpawnGearVariant()
	{
	}
}
