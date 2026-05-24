using System;
using Cpp2ILInjected;

namespace TLD.BigCarry;

[Flags]
[Token(Token = "0x20014D2")]
public enum CarryDropOptions
{
	[Token(Token = "0x4009680")]
	None = 0,
	[Token(Token = "0x4009681")]
	DropAtPlayersFeet = 1,
	[Token(Token = "0x4009682")]
	CancelPlaceMesh = 2,
	[Token(Token = "0x4009683")]
	PlayAnimation = 4,
	[Token(Token = "0x4009684")]
	ClearPreviousEquippedItem = 8,
	[Token(Token = "0x4009685")]
	PlayAudio = 0x10
}
