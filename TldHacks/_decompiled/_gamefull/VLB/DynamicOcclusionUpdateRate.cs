using System;
using Cpp2ILInjected;

namespace VLB;

[Flags]
[Token(Token = "0x2000BD0")]
public enum DynamicOcclusionUpdateRate
{
	[Token(Token = "0x400791E")]
	Never = 1,
	[Token(Token = "0x400791F")]
	OnEnable = 2,
	[Token(Token = "0x4007920")]
	OnBeamMove = 4,
	[Token(Token = "0x4007921")]
	EveryXFrames = 8,
	[Token(Token = "0x4007922")]
	OnBeamMoveAndEveryXFrames = 0xC
}
