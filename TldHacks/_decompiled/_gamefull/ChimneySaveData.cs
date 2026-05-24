using Cpp2ILInjected;

[Token(Token = "0x2000375")]
public class ChimneySaveData
{
	[Token(Token = "0x4001EB1")]
	[FieldOffset(Offset = "0x10")]
	public float m_LifetimeGameMinues;

	[Token(Token = "0x4001EB2")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursPlayed;

	[Token(Token = "0x4001EB3")]
	[FieldOffset(Offset = "0x18")]
	public string m_Guid;

	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ChimneySaveData()
	{
	}
}
