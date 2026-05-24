using Cpp2ILInjected;

namespace VLB;

[Token(Token = "0x2000BCD")]
public enum RenderQueue
{
	[Token(Token = "0x4007910")]
	Custom = 0,
	[Token(Token = "0x4007911")]
	Background = 1000,
	[Token(Token = "0x4007912")]
	Geometry = 2000,
	[Token(Token = "0x4007913")]
	AlphaTest = 2450,
	[Token(Token = "0x4007914")]
	GeometryLast = 2500,
	[Token(Token = "0x4007915")]
	Transparent = 3000,
	[Token(Token = "0x4007916")]
	Overlay = 4000
}
