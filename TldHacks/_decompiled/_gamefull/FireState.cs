using Cpp2ILInjected;

[Token(Token = "0x200041C")]
public enum FireState
{
	[Token(Token = "0x40024FA")]
	Off,
	[Token(Token = "0x40024FB")]
	Starting_FireStarterUse,
	[Token(Token = "0x40024FC")]
	Starting_TinderSmolder,
	[Token(Token = "0x40024FD")]
	Starting_TinderSmallFlame,
	[Token(Token = "0x40024FE")]
	Starting_MediumBurn,
	[Token(Token = "0x40024FF")]
	Starting_FullBurn,
	[Token(Token = "0x4002500")]
	FullBurn,
	[Token(Token = "0x4002501")]
	Blownout
}
