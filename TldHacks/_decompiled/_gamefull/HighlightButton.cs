using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200024C")]
public class HighlightButton
{
	[Token(Token = "0x400146D")]
	[FieldOffset(Offset = "0x10")]
	private readonly UIButton m_Button;

	[Token(Token = "0x400146E")]
	[FieldOffset(Offset = "0x18")]
	private readonly string m_DisabledSprite;

	[Token(Token = "0x400146F")]
	[FieldOffset(Offset = "0x20")]
	private readonly string m_NormalSprite;

	[Token(Token = "0x4001470")]
	[FieldOffset(Offset = "0x28")]
	private readonly UISprite m_TweenSprite;

	[Token(Token = "0x4001471")]
	[FieldOffset(Offset = "0x30")]
	private Color m_DisabledColour;

	[Token(Token = "0x600143D")]
	[Address(RVA = "0x680AC0", Offset = "0x67F8C0", Length = "0x207")]
	public HighlightButton(UIButton button)
	{
	}

	[Token(Token = "0x600143E")]
	[Address(RVA = "0x680CD0", Offset = "0x67FAD0", Length = "0x23D")]
	public void SetHighlighted(bool highlighted)
	{
	}
}
