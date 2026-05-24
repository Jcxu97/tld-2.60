using Cpp2ILInjected;

namespace Interface.PanelRequest;

[Token(Token = "0x200131B")]
public class LoadPanelRequest : BaseLoadPanelRequest
{
	[Token(Token = "0x6007A81")]
	[Address(RVA = "0x1193C70", Offset = "0x1192A70", Length = "0x298")]
	public LoadPanelRequest(string panelName, string panelVariantName)
		: base(null)
	{
	}

	[Token(Token = "0x6007A82")]
	[Address(RVA = "0x1193F10", Offset = "0x1192D10", Length = "0x13")]
	public override float GetProgress()
	{
		return 0f;
	}
}
