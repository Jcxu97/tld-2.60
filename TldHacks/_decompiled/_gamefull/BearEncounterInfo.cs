using Cpp2ILInjected;

[Token(Token = "0x20001CF")]
public class BearEncounterInfo
{
	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x10")]
	public BearEncounter.BearSpawnEncounterResult m_LatestEncounterResult;

	[Token(Token = "0x4000FAF")]
	[FieldOffset(Offset = "0x14")]
	public bool m_IsActivated;

	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x15")]
	public bool m_IsLastEncounter;

	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x18")]
	public BearEncounter.PostStruggleBehavior m_PostStruggleBehavior;

	[Token(Token = "0x4000FB2")]
	[FieldOffset(Offset = "0x20")]
	public string m_MissionObjectId;

	[Token(Token = "0x6001082")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BearEncounterInfo()
	{
	}
}
