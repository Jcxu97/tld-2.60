using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20004F2")]
public class AfflictionRemedies
{
	[Token(Token = "0x4002D59")]
	[FieldOffset(Offset = "0x10")]
	public AfflictionRemedy m_Remedy1;

	[Token(Token = "0x4002D5A")]
	[FieldOffset(Offset = "0x18")]
	public AfflictionRemedy m_Remedy2;

	[Token(Token = "0x600257A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AfflictionRemedies()
	{
	}
}
