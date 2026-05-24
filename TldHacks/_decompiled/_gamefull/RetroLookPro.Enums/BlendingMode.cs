using Cpp2ILInjected;

namespace RetroLookPro.Enums;

[Token(Token = "0x2000D03")]
public enum BlendingMode
{
	[Token(Token = "0x4008110")]
	Normal,
	[Token(Token = "0x4008111")]
	Darken,
	[Token(Token = "0x4008112")]
	Multiply,
	[Token(Token = "0x4008113")]
	ColorBurn,
	[Token(Token = "0x4008114")]
	LinearBurn,
	[Token(Token = "0x4008115")]
	DarkerColor,
	[Token(Token = "0x4008116")]
	Lighten,
	[Token(Token = "0x4008117")]
	Screen,
	[Token(Token = "0x4008118")]
	ColorDodge,
	[Token(Token = "0x4008119")]
	LinearDodge,
	[Token(Token = "0x400811A")]
	LighterColor,
	[Token(Token = "0x400811B")]
	Overlay,
	[Token(Token = "0x400811C")]
	SoftLight,
	[Token(Token = "0x400811D")]
	HardLight,
	[Token(Token = "0x400811E")]
	VividLight,
	[Token(Token = "0x400811F")]
	LinearLight,
	[Token(Token = "0x4008120")]
	PinLight,
	[Token(Token = "0x4008121")]
	HardMix,
	[Token(Token = "0x4008122")]
	Difference,
	[Token(Token = "0x4008123")]
	Exclusion,
	[Token(Token = "0x4008124")]
	Subtract,
	[Token(Token = "0x4008125")]
	Divide
}
