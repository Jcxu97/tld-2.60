using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000442")]
public class SpawnWildlife_TriggerSaveData
{
	[Token(Token = "0x400264A")]
	[FieldOffset(Offset = "0x10")]
	public bool m_PlayerHasEnteredTrigger;

	[Token(Token = "0x400264B")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x400264C")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsSpawnActive;

	[Token(Token = "0x400264D")]
	[FieldOffset(Offset = "0x21")]
	public bool m_IsSpawnAuroraActive;

	[Token(Token = "0x400264E")]
	[FieldOffset(Offset = "0x28")]
	public List<string> m_RemovedBaseAiGuids;

	[Token(Token = "0x6002001")]
	[Address(RVA = "0x7E8060", Offset = "0x7E6E60", Length = "0xAD")]
	public SpawnWildlife_TriggerSaveData()
	{
	}
}
