using Cpp2ILInjected;

namespace TLD.Interactions;

[Token(Token = "0x20013A2")]
public enum InteractionEventType
{
	[Token(Token = "0x4008FED")]
	InitializeInteraction = 0,
	[Token(Token = "0x4008FEE")]
	UpdateInteraction = 1,
	[Token(Token = "0x4008FEF")]
	PerformInteraction = 2,
	[Token(Token = "0x4008FF0")]
	HideInteraction = 3,
	[Token(Token = "0x4008FF1")]
	HoldBegin = 10,
	[Token(Token = "0x4008FF2")]
	HoldCancelled = 11,
	[Token(Token = "0x4008FF3")]
	HoldEnd = 12,
	[Token(Token = "0x4008FF4")]
	OpenBegin = 20,
	[Token(Token = "0x4008FF5")]
	OpenEnd = 21,
	[Token(Token = "0x4008FF6")]
	CloseBegin = 22,
	[Token(Token = "0x4008FF7")]
	CloseEnd = 23
}
