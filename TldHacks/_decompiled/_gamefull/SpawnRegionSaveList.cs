using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x20007E1")]
public class SpawnRegionSaveList
{
	[Token(Token = "0x4005471")]
	[FieldOffset(Offset = "0x10")]
	public List<SpawnRegionSaveData> m_SerializedSpawnRegions;

	[Token(Token = "0x4005472")]
	[FieldOffset(Offset = "0x18")]
	public float m_NoPredatorSpawningInVoyageurHours;

	[Token(Token = "0x6004A5D")]
	[Address(RVA = "0xD36620", Offset = "0xD35420", Length = "0xAD")]
	public SpawnRegionSaveList()
	{
	}
}
