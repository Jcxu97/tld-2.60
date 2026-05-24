using Cpp2ILInjected;

[Token(Token = "0x200051C")]
public class HypothermiaSaveDataProxy
{
	[Token(Token = "0x4002EE4")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Active;

	[Token(Token = "0x4002EE5")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHours;

	[Token(Token = "0x4002EE6")]
	[FieldOffset(Offset = "0x18")]
	public float m_ElapsedWarmTime;

	[Token(Token = "0x4002EE7")]
	[FieldOffset(Offset = "0x20")]
	public string m_CauseLocID;

	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HypothermiaSaveDataProxy()
	{
	}
}
