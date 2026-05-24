using Cpp2ILInjected;

[Token(Token = "0x20001F1")]
public class HungerSaveDataProxy
{
	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x10")]
	public float m_CurrentReserveCaloriesProxy;

	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x18")]
	public bool m_StarvingInLog;

	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x1C")]
	public float m_NumHoursStarving;

	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0x20")]
	public float m_FatiguePenalty;

	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x24")]
	public HungerLevel m_HungerLevelForPreviousVoiceOver;

	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x28")]
	public bool m_SuppressVoiceOver;

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HungerSaveDataProxy()
	{
	}
}
