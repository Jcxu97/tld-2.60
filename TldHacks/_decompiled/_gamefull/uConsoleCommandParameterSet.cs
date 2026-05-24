using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000A95")]
public class uConsoleCommandParameterSet
{
	[Token(Token = "0x400683F")]
	[FieldOffset(Offset = "0x10")]
	public List<string> m_Commands;

	[Token(Token = "0x4006840")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_AllowedParameters;

	[Token(Token = "0x6005BEA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public uConsoleCommandParameterSet()
	{
	}
}
