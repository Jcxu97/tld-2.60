using Cpp2ILInjected;

[Token(Token = "0x200015E")]
public class BearEncounterSaveData
{
	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentTimerSpawnSeconds;

	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursPlayed;

	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x20")]
	public BearEncounter.BearSpawnState m_BearSpawnState;

	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0x24")]
	public BearEncounter.BearSpawnEncounterResult m_LatestEncounterResult;

	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x28")]
	public bool m_LastEncounter;

	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x2C")]
	public BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x30")]
	public bool m_IsEncounterEnabled;

	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BearEncounterSaveData()
	{
	}
}
