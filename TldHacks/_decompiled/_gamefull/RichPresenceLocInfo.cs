using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000906")]
public class RichPresenceLocInfo
{
	[Token(Token = "0x4005E6A")]
	[FieldOffset(Offset = "0x10")]
	public PresenceType PresenceType;

	[Token(Token = "0x4005E6B")]
	[FieldOffset(Offset = "0x18")]
	public string LocKey;

	[Token(Token = "0x600526C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RichPresenceLocInfo()
	{
	}
}
