using Cpp2ILInjected;

[Token(Token = "0x20004D4")]
public class SnareItemSaveDataProxy
{
	[Token(Token = "0x4002C32")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4002C33")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursAtLastRoll;

	[Token(Token = "0x4002C34")]
	[FieldOffset(Offset = "0x18")]
	public SnareState m_State;

	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SnareItemSaveDataProxy()
	{
	}
}
