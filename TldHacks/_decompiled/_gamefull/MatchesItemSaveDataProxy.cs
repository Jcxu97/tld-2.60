using Cpp2ILInjected;

[Token(Token = "0x20004BC")]
public class MatchesItemSaveDataProxy
{
	[Token(Token = "0x4002B84")]
	[FieldOffset(Offset = "0x10")]
	public float m_BurnTimeGametimeSeconds;

	[Token(Token = "0x4002B85")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedBurnGametimeSeconds;

	[Token(Token = "0x4002B86")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Ignited;

	[Token(Token = "0x4002B87")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IsFresh;

	[Token(Token = "0x6002427")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MatchesItemSaveDataProxy()
	{
	}
}
