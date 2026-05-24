using Cpp2ILInjected;

[Token(Token = "0x200043D")]
public class Tumbler
{
	[Token(Token = "0x400261A")]
	[FieldOffset(Offset = "0x10")]
	public int m_DialNumber;

	[Token(Token = "0x400261B")]
	[FieldOffset(Offset = "0x14")]
	public TumblerState m_State;

	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Tumbler()
	{
	}
}
