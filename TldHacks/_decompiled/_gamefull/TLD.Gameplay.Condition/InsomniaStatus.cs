using Cpp2ILInjected;

namespace TLD.Gameplay.Condition;

[Token(Token = "0x20014C7")]
public enum InsomniaStatus
{
	[Token(Token = "0x40095FB")]
	Unknown,
	[Token(Token = "0x40095FC")]
	RiskStarted,
	[Token(Token = "0x40095FD")]
	RiskIsHealing,
	[Token(Token = "0x40095FE")]
	RiskHealed,
	[Token(Token = "0x40095FF")]
	AfflictionStarted,
	[Token(Token = "0x4009600")]
	AfflictionIsHealing,
	[Token(Token = "0x4009601")]
	AfflictionHealed
}
