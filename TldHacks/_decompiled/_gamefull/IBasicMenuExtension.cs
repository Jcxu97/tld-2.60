using Cpp2ILInjected;

[Token(Token = "0x20001FE")]
public interface IBasicMenuExtension
{
	[Token(Token = "0x6001213")]
	void Init(BasicMenu menu);

	[Token(Token = "0x6001214")]
	void ItemAdded(BasicMenu.BasicMenuItemModel item);

	[Token(Token = "0x6001215")]
	void Update();

	[Token(Token = "0x6001216")]
	void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority);
}
