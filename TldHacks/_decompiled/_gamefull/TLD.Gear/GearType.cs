using System;
using Cpp2ILInjected;

namespace TLD.Gear;

[Flags]
[Token(Token = "0x2001417")]
public enum GearType
{
	[Token(Token = "0x40092AF")]
	Food = 1,
	[Token(Token = "0x40092B0")]
	Clothing = 2,
	[Token(Token = "0x40092B1")]
	Material = 4,
	[Token(Token = "0x40092B2")]
	Tool = 8,
	[Token(Token = "0x40092B3")]
	FirstAid = 0x10,
	[Token(Token = "0x40092B4")]
	Firestarting = 0x20,
	[Token(Token = "0x40092B5")]
	Other = 0x40
}
