using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007E2")]
public class SpawnRegionManager : MonoBehaviour
{
	[Range(0f, 168f)]
	[Token(Token = "0x4005473")]
	[FieldOffset(Offset = "0x20")]
	public float m_NoPredatorSpawningInVoyageurHoursMin;

	[Range(0f, 168f)]
	[Token(Token = "0x4005474")]
	[FieldOffset(Offset = "0x24")]
	public float m_NoPredatorSpawningInVoyageurHoursMax;

	[Range(0f, 1f)]
	[Token(Token = "0x4005475")]
	[FieldOffset(Offset = "0x28")]
	public float m_RandomizeRestoredSpawnsAfterHoursInside;

	[Range(0f, 300f)]
	[Token(Token = "0x4005476")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SpawnRegionDisableDistance;

	[Range(0f, 200f)]
	[Token(Token = "0x4005477")]
	[FieldOffset(Offset = "0x30")]
	public float m_DisallowDespawnBelowDistance;

	[Range(0f, 100f)]
	[Token(Token = "0x4005478")]
	[FieldOffset(Offset = "0x34")]
	public float m_ClosestSpawnDistanceToPlayer;

	[Range(0f, 100f)]
	[Token(Token = "0x4005479")]
	[FieldOffset(Offset = "0x38")]
	public float m_ClosestSpawnDistanceToPlayerAfterSceneTransition;

	[Range(0f, 500f)]
	[Token(Token = "0x400547A")]
	[FieldOffset(Offset = "0x3C")]
	public float m_AllowSpawnOnscreenDistance;

	[Range(0f, 500f)]
	[Token(Token = "0x400547B")]
	[FieldOffset(Offset = "0x40")]
	public float m_AllowDespawnOnscreenDistance;

	[HideInInspector]
	[Token(Token = "0x400547C")]
	[FieldOffset(Offset = "0x48")]
	public List<SpawnRegion> m_SpawnRegions;

	[HideInInspector]
	[Token(Token = "0x400547D")]
	[FieldOffset(Offset = "0x50")]
	public List<NoSpawnRegion> m_NoSpawnRegions;

	[Token(Token = "0x400547E")]
	public static float m_NoPredatorSpawningInVoyageurHours;

	[Token(Token = "0x400547F")]
	[FieldOffset(Offset = "0x58")]
	private int m_NextSpawnRegionIndexToUpdate;

	[Token(Token = "0x6004A5E")]
	[Address(RVA = "0xD366D0", Offset = "0xD354D0", Length = "0x5B")]
	public void Start()
	{
	}

	[Token(Token = "0x6004A5F")]
	[Address(RVA = "0xD36730", Offset = "0xD35530", Length = "0x4D6")]
	public void OnAuroraEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6004A60")]
	[Address(RVA = "0xD36C10", Offset = "0xD35A10", Length = "0x204")]
	public void MaybeEnableSpawnRegionsInRange(SpawnRegion otherSpawnRegion, float range, bool enable)
	{
	}

	[Token(Token = "0x6004A61")]
	[Address(RVA = "0xD36E20", Offset = "0xD35C20", Length = "0x3DB")]
	public void Update()
	{
	}

	[Token(Token = "0x6004A62")]
	[Address(RVA = "0xD37200", Offset = "0xD36000", Length = "0x685")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004A63")]
	[Address(RVA = "0xD37890", Offset = "0xD36690", Length = "0x3DE")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004A64")]
	[Address(RVA = "0xD37C70", Offset = "0xD36A70", Length = "0xBF")]
	public void Add(SpawnRegion sr)
	{
	}

	[Token(Token = "0x6004A65")]
	[Address(RVA = "0xD37D30", Offset = "0xD36B30", Length = "0x7F")]
	public void Remove(SpawnRegion sr)
	{
	}

	[Token(Token = "0x6004A66")]
	[Address(RVA = "0xD37DB0", Offset = "0xD36BB0", Length = "0x98")]
	public void Add(NoSpawnRegion nsr)
	{
	}

	[Token(Token = "0x6004A67")]
	[Address(RVA = "0xD37E50", Offset = "0xD36C50", Length = "0x130")]
	public GameObject GetClosestActiveSpawn(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[Token(Token = "0x6004A68")]
	[Address(RVA = "0xD37F80", Offset = "0xD36D80", Length = "0x274")]
	public SpawnRegion PointInsideSpawnRegion(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[Token(Token = "0x6004A69")]
	[Address(RVA = "0xD38200", Offset = "0xD37000", Length = "0x2AE")]
	public SpawnRegion PointInsideActiveSpawnRegion(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[Token(Token = "0x6004A6A")]
	[Address(RVA = "0xD384B0", Offset = "0xD372B0", Length = "0x298")]
	public bool PointInsideNoSpawnRegion(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6004A6B")]
	[Address(RVA = "0xD38750", Offset = "0xD37550", Length = "0x2E0")]
	private static SpawnRegion FindSpawnRegionByPosition(SpawnRegionSaveData saveData)
	{
		return null;
	}

	[Token(Token = "0x6004A6C")]
	[Address(RVA = "0xD38A40", Offset = "0xD37840", Length = "0x117")]
	private static SpawnRegion FindSpawnRegionByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004A6D")]
	[Address(RVA = "0xD38B60", Offset = "0xD37960", Length = "0x18F")]
	public SpawnRegionManager()
	{
	}
}
