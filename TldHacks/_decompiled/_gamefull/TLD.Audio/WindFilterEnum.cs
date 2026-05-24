using Cpp2ILInjected;

namespace TLD.Audio;

[Token(Token = "0x20014E5")]
public enum WindFilterEnum
{
	[Token(Token = "0x4009720")]
	Always,
	[Token(Token = "0x4009721")]
	Calm,
	[Token(Token = "0x4009722")]
	SlightlyWindy,
	[Token(Token = "0x4009723")]
	Windy,
	[Token(Token = "0x4009724")]
	VeryWindy,
	[Token(Token = "0x4009725")]
	Blizzard,
	[Token(Token = "0x4009726")]
	NotCalmAndNotSlightlyWindy
}
