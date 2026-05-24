using System;
using Cpp2ILInjected;

namespace TLD.Placement;

[Flags]
[Token(Token = "0x200137C")]
public enum PlaceMeshRules
{
	[Token(Token = "0x4008F3D")]
	None = 0,
	[Token(Token = "0x4008F3E")]
	Default = 1,
	[Token(Token = "0x4008F3F")]
	IgnoreCloseObjects = 2,
	[Token(Token = "0x4008F40")]
	PreventGearOverlaps = 4,
	[Token(Token = "0x4008F41")]
	AllowWallPlacement = 8,
	[Token(Token = "0x4008F42")]
	AllowFloorPlacement = 0x10,
	[Token(Token = "0x4008F43")]
	AllowStacking = 0x20,
	[Token(Token = "0x4008F44")]
	UseCollisionForCloseObjects = 0x40
}
