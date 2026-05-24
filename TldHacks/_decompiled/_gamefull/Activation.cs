using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20003F7")]
public class Activation
{
	[Token(Token = "0x400238B")]
	[FieldOffset(Offset = "0x10")]
	public float m_StartTime;

	[Token(Token = "0x400238C")]
	[FieldOffset(Offset = "0x14")]
	public float m_Duration;

	[Token(Token = "0x6001E66")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Activation()
	{
	}
}
