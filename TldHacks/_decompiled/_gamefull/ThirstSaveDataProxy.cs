using Cpp2ILInjected;

[Token(Token = "0x20001F7")]
public class ThirstSaveDataProxy
{
	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentThirstProxy;

	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x40011C5")]
	[FieldOffset(Offset = "0x18")]
	public bool m_DehydratedInLog;

	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x1C")]
	public ThirstLevel m_ThirstLevelForPreviousVoiceOver;

	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x20")]
	public bool m_SuppressVoiceOver;

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ThirstSaveDataProxy()
	{
	}
}
