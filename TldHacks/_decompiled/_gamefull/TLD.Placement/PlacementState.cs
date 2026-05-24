using Cpp2ILInjected;

namespace TLD.Placement;

[Token(Token = "0x2001376")]
public enum PlacementState
{
	[Token(Token = "0x4008F2A")]
	Active,
	[Token(Token = "0x4008F2B")]
	Removed,
	[Token(Token = "0x4008F2C")]
	OnPlayer,
	[Token(Token = "0x4008F2D")]
	Inactive,
	[Token(Token = "0x4008F2E")]
	Unregistered
}
