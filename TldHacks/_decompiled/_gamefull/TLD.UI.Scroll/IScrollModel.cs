using Cpp2ILInjected;

namespace TLD.UI.Scroll;

[Token(Token = "0x2001394")]
public interface IScrollModel
{
	[Token(Token = "0x6007D05")]
	void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index);

	[Token(Token = "0x6007D06")]
	void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex);
}
