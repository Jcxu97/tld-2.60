using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200020C")]
public class ButtonLegendConfigure : MonoBehaviour
{
	[Token(Token = "0x4001286")]
	[FieldOffset(Offset = "0x20")]
	public string m_ActionName;

	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0x28")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_ButtonSprite;

	[Token(Token = "0x6001285")]
	[Address(RVA = "0x653BE0", Offset = "0x6529E0", Length = "0x7")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001286")]
	[Address(RVA = "0x653BF0", Offset = "0x6529F0", Length = "0x2BD")]
	public void ConfigureButton()
	{
	}

	[Token(Token = "0x6001287")]
	[Address(RVA = "0x653EB0", Offset = "0x652CB0", Length = "0x7")]
	public void Update()
	{
	}

	[Token(Token = "0x6001288")]
	[Address(RVA = "0x653EC0", Offset = "0x652CC0", Length = "0x2DE")]
	private void RefreshReferences()
	{
	}

	[Token(Token = "0x6001289")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ButtonLegendConfigure()
	{
	}
}
