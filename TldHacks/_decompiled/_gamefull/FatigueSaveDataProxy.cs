using Cpp2ILInjected;

[Token(Token = "0x20001E2")]
public class FatigueSaveDataProxy
{
	[Token(Token = "0x40010AF")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentFatigueProxy;

	[Token(Token = "0x40010B0")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x40010B1")]
	[FieldOffset(Offset = "0x18")]
	public bool m_ExhaustedInLog;

	[Token(Token = "0x40010B2")]
	[FieldOffset(Offset = "0x1C")]
	public FatigueLevel m_FatigueLevelForPreviousVoiceOver;

	[Token(Token = "0x40010B3")]
	[FieldOffset(Offset = "0x20")]
	public bool m_SuppressVoiceOver;

	[Token(Token = "0x6001124")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FatigueSaveDataProxy()
	{
	}
}
