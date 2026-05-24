using Cpp2ILInjected;

namespace TLD.UI;

[Token(Token = "0x200138C")]
public interface IMiniTopNav
{
	[Token(Token = "0x6007CDE")]
	bool CanShowMiniTopNav();

	[Token(Token = "0x6007CDF")]
	bool OnMiniTopNavButtonClick(Panel_Base owner);
}
