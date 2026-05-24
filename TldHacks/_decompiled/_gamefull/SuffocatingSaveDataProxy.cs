using Cpp2ILInjected;

[Token(Token = "0x20001F3")]
public class SuffocatingSaveDataProxy
{
	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsSuffocating;

	[Token(Token = "0x400119F")]
	[FieldOffset(Offset = "0x11")]
	public bool m_HasSuffocatingRisk;

	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x12")]
	public bool m_SuffocatingTimerIsPaused;

	[Token(Token = "0x40011A1")]
	[FieldOffset(Offset = "0x14")]
	public int m_SuffocatingTriggerCounter;

	[Token(Token = "0x40011A2")]
	[FieldOffset(Offset = "0x18")]
	public float m_TimeRemaining;

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SuffocatingSaveDataProxy()
	{
	}
}
