using Cpp2ILInjected;

[Token(Token = "0x20001EE")]
public class HeadacheParamsSaveDataProxy
{
	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x10")]
	public float m_TimeSpentIndoor;

	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x14")]
	public float m_TimeSpentOutdoor;

	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0x18")]
	public float m_StartTimeInGameHours;

	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x1C")]
	public float m_LastHeadachePulseTime;

	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x20")]
	public HeadacheStatus m_HeadacheStatus;

	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x24")]
	public float m_HeadacheDurationHours;

	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x28")]
	public float m_HeadachePulseFrequencyStart;

	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HeadachePulseFrequencyEnd;

	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x30")]
	public string m_HeadachePulseEvent;

	[Token(Token = "0x4001143")]
	[FieldOffset(Offset = "0x38")]
	public string m_HeadacheStartAudio;

	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x40")]
	public string m_HeadacheAfflictionIcoName;

	[Token(Token = "0x4001145")]
	[FieldOffset(Offset = "0x48")]
	public float m_HoursRequiredOutdoorToGetAffliction;

	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x4C")]
	public float m_HoursRequiredIndoorToExitAffliction;

	[Token(Token = "0x4001147")]
	[FieldOffset(Offset = "0x50")]
	public HeadacheCause m_Cause;

	[Token(Token = "0x4001148")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_HeadacheLocalizedId;

	[Token(Token = "0x4001149")]
	[FieldOffset(Offset = "0x60")]
	public LocalizedString m_CausedByLocalizedId;

	[Token(Token = "0x400114A")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_HealedAfflictionLocalizedId;

	[Token(Token = "0x400114B")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_HeadacheDescription;

	[Token(Token = "0x400114C")]
	[FieldOffset(Offset = "0x78")]
	public LocalizedString m_TreatmentRequiredDescription;

	[Token(Token = "0x600117E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HeadacheParamsSaveDataProxy()
	{
	}
}
