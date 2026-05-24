using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000A15")]
public class LocalizedString
{
	[Token(Token = "0x4006620")]
	[FieldOffset(Offset = "0x10")]
	public string m_LocalizationID;

	[Token(Token = "0x6005877")]
	[Address(RVA = "0xEEA240", Offset = "0xEE9040", Length = "0x52")]
	public string Text()
	{
		return null;
	}

	[Token(Token = "0x6005878")]
	[Address(RVA = "0xEEA2A0", Offset = "0xEE90A0", Length = "0x15")]
	public bool IsSet()
	{
		return false;
	}

	[Token(Token = "0x6005879")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LocalizedString()
	{
	}
}
