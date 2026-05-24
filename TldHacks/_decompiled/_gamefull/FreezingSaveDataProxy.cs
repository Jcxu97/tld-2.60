using Cpp2ILInjected;

[Token(Token = "0x20001E8")]
public class FreezingSaveDataProxy
{
	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentFreezingProxy;

	[Token(Token = "0x40010FA")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x40010FB")]
	[FieldOffset(Offset = "0x18")]
	public bool m_FreezingInLog;

	[Token(Token = "0x40010FC")]
	[FieldOffset(Offset = "0x1C")]
	public FreezingLevel m_FreezingLevelForPreviousVoiceOver;

	[Token(Token = "0x40010FD")]
	[FieldOffset(Offset = "0x20")]
	public float m_TemperatureBonusFromRunning;

	[Token(Token = "0x40010FE")]
	[FieldOffset(Offset = "0x24")]
	public bool m_SuppressVoiceOver;

	[Token(Token = "0x600114F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FreezingSaveDataProxy()
	{
	}
}
