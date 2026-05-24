using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000715")]
public class BodyHarvestSaveData
{
	[Token(Token = "0x4004B66")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4004B67")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4004B68")]
	[FieldOffset(Offset = "0x30")]
	public string m_PrefabName;

	[Token(Token = "0x4004B69")]
	[FieldOffset(Offset = "0x38")]
	public string m_SerializedBodyHarvest;

	[Token(Token = "0x4004B6A")]
	[FieldOffset(Offset = "0x40")]
	public string m_Guid;

	[Token(Token = "0x4004B6B")]
	[FieldOffset(Offset = "0x48")]
	public string m_MissionId;

	[Token(Token = "0x4004B6C")]
	[FieldOffset(Offset = "0x50")]
	public bool m_PreventSpawning;

	[Token(Token = "0x6003E41")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BodyHarvestSaveData()
	{
	}
}
