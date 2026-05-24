using Cpp2ILInjected;

[Token(Token = "0x2000504")]
public class BurnsElectricSaveDataProxy
{
	[Token(Token = "0x4002DFD")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002DFE")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002DFF")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002E00")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_PainKillersTaken;

	[Token(Token = "0x4002E01")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_BandageApplied;

	[Token(Token = "0x4002E02")]
	[FieldOffset(Offset = "0x20")]
	public int m_NumBurnRemindersPlayed;

	[Token(Token = "0x4002E03")]
	[FieldOffset(Offset = "0x24")]
	public float m_SecondsUntilNextBurnReminder;

	[Token(Token = "0x600260E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BurnsElectricSaveDataProxy()
	{
	}
}
