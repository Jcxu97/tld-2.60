using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x20005A1")]
public class RadialObjectSpawnerSaveData
{
	[Token(Token = "0x40033F2")]
	[FieldOffset(Offset = "0x10")]
	public float m_GameHourTimeToRespawn;

	[Token(Token = "0x40033F3")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 m_Position;

	[Token(Token = "0x40033F4")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x40033F5")]
	[FieldOffset(Offset = "0x28")]
	public bool m_HasSpawned;

	[FormerlySerializedAs("m_NonGearObjectPositions")]
	[Token(Token = "0x40033F6")]
	[FieldOffset(Offset = "0x30")]
	public Vector3[] m_SpawnedObjectPositions;

	[FormerlySerializedAs("m_NonGearObjectRotations")]
	[Token(Token = "0x40033F7")]
	[FieldOffset(Offset = "0x38")]
	public Quaternion[] m_SpawnedObjectRotations;

	[FormerlySerializedAs("m_GearPrefabNames")]
	[Token(Token = "0x40033F8")]
	[FieldOffset(Offset = "0x40")]
	public string[] m_SpawnedPrefabNames;

	[Token(Token = "0x40033F9")]
	[FieldOffset(Offset = "0x48")]
	public bool[] m_SpawnedObjectUnlockForDetailMapStates;

	[Token(Token = "0x6002B8A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RadialObjectSpawnerSaveData()
	{
	}
}
