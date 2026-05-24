using Cpp2ILInjected;

[Token(Token = "0x2000502")]
public class BurnsSaveDataProxy
{
	[Token(Token = "0x4002DD9")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002DDA")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002DDB")]
	[FieldOffset(Offset = "0x18")]
	public float m_DurationHours;

	[Token(Token = "0x4002DDC")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_PainKillersTaken;

	[Token(Token = "0x4002DDD")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_BandageApplied;

	[Token(Token = "0x4002DDE")]
	[FieldOffset(Offset = "0x20")]
	public int m_NumBurnRemindersPlayed;

	[Token(Token = "0x4002DDF")]
	[FieldOffset(Offset = "0x24")]
	public float m_SecondsUntilNextBurnReminder;

	[Token(Token = "0x4002DE0")]
	[FieldOffset(Offset = "0x28")]
	public string m_CauseLocID;

	[Token(Token = "0x60025FB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BurnsSaveDataProxy()
	{
	}
}
