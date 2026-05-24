using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x20014A5")]
public interface IShouldDisableForCurrentMode
{
	[Token(Token = "0x60082E2")]
	bool ShouldDisableForCurrentMode();

	[Token(Token = "0x60082E3")]
	void Update();
}
