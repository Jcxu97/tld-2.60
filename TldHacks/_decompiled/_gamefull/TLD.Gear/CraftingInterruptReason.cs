using Cpp2ILInjected;

namespace TLD.Gear;

[Token(Token = "0x2001444")]
public enum CraftingInterruptReason
{
	[Token(Token = "0x4009392")]
	Cancelled,
	[Token(Token = "0x4009393")]
	Interaction,
	[Token(Token = "0x4009394")]
	LocationError,
	[Token(Token = "0x4009395")]
	NotEnoughLight,
	[Token(Token = "0x4009396")]
	ToolRuined
}
