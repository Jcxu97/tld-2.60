using Cpp2ILInjected;

[Token(Token = "0x200048A")]
public class FlareItemSaveDataProxy
{
	[Token(Token = "0x4002947")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4002948")]
	[FieldOffset(Offset = "0x14")]
	public FlareState m_StateProxy;

	[Token(Token = "0x4002949")]
	[FieldOffset(Offset = "0x18")]
	public float m_ElapsedBurnMinutesProxy;

	[Token(Token = "0x600222D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FlareItemSaveDataProxy()
	{
	}
}
