using System;
using Cpp2ILInjected;

[Flags]
[Token(Token = "0x20001D7")]
public enum AfflictionOptions
{
	[Token(Token = "0x400100E")]
	None = 0,
	[Token(Token = "0x400100F")]
	PlayFX = 1,
	[Token(Token = "0x4001010")]
	DoAutoSave = 2,
	[Token(Token = "0x4001011")]
	DisplayIcon = 4,
	[Token(Token = "0x4001012")]
	Stumble = 8
}
