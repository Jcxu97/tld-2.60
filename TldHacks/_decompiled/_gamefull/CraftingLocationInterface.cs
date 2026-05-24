using Cpp2ILInjected;
using TLD.Gear;

[Token(Token = "0x2000566")]
public interface CraftingLocationInterface
{
	[Token(Token = "0x600297C")]
	CraftingLocation GetLocation();

	[Token(Token = "0x600297D")]
	int ModifyCraftingTime(int minutes);

	[Token(Token = "0x600297E")]
	bool ReadyForBlueprint(BlueprintData bp);

	[Token(Token = "0x600297F")]
	bool ReadyToCraft();

	[Token(Token = "0x6002980")]
	void ShowError(CraftingLocationError error);

	[Token(Token = "0x6002981")]
	bool HoldsCraftingResult();

	[Token(Token = "0x6002982")]
	Container GetContainer();
}
