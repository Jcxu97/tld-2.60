using Cpp2ILInjected;

namespace TLD.BigCarry;

[Token(Token = "0x20014D1")]
public enum CarryDisplayError
{
	[Token(Token = "0x4009674")]
	None = -1,
	[Token(Token = "0x4009675")]
	InteractionBlocked = 0,
	[Token(Token = "0x4009676")]
	CrouchCannotInteract = 1,
	[Token(Token = "0x4009677")]
	InvalidPlacement = 2,
	[Token(Token = "0x4009678")]
	LeavingNPCBehind = 20,
	[Token(Token = "0x4009679")]
	IncorrectRescueOrder = 21,
	[Token(Token = "0x400967A")]
	NPCCannotLeave = 22,
	[Token(Token = "0x400967B")]
	NoGround = 30,
	[Token(Token = "0x400967C")]
	BlockedArea = 31,
	[Token(Token = "0x400967D")]
	SteepSlope = 32,
	[Token(Token = "0x400967E")]
	NoSpace = 33
}
