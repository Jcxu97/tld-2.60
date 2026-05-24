using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200039A")]
public class SnowImprintQualitySettings
{
	[Token(Token = "0x4002040")]
	[FieldOffset(Offset = "0x10")]
	public bool m_Show;

	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SnowImprintQualitySettings()
	{
	}
}
