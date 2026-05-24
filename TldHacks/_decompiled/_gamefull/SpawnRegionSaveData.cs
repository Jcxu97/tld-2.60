using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007E0")]
public class SpawnRegionSaveData
{
	[Token(Token = "0x400546E")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x400546F")]
	[FieldOffset(Offset = "0x20")]
	public string m_SearializedSpawnRegion;

	[Token(Token = "0x4005470")]
	[FieldOffset(Offset = "0x28")]
	public string m_Guid;

	[Token(Token = "0x6004A5C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SpawnRegionSaveData()
	{
	}
}
