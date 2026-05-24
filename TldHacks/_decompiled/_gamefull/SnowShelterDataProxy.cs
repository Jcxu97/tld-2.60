using Cpp2ILInjected;

[Token(Token = "0x20005B1")]
public class SnowShelterDataProxy
{
	[Token(Token = "0x400349D")]
	[FieldOffset(Offset = "0x10")]
	public float m_NormalizedCondition;

	[Token(Token = "0x400349E")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursPlayed;

	[Token(Token = "0x400349F")]
	[FieldOffset(Offset = "0x18")]
	public float m_HoursRuined;

	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SnowShelterDataProxy()
	{
	}
}
