using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000230")]
public class TextureCreditElement : CreditElement
{
	[SerializeField]
	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x28")]
	private UITexture m_Texture;

	[Token(Token = "0x4001365")]
	private const int TEXTURE_ID_INDEX = 0;

	[Token(Token = "0x4001366")]
	private const int TEXTURE_SCALE_INDEX = 2;

	[Token(Token = "0x6001373")]
	[Address(RVA = "0x66A560", Offset = "0x669360", Length = "0x1A2")]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0x66A710", Offset = "0x669510", Length = "0x2B1")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[Token(Token = "0x6001375")]
	[Address(RVA = "0x66A9D0", Offset = "0x6697D0", Length = "0x137")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001376")]
	[Address(RVA = "0x66A360", Offset = "0x669160", Length = "0x107")]
	public override void SetPosition(float yOffset)
	{
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0x66AB10", Offset = "0x669910", Length = "0xE1")]
	private Texture2D GetTextureFromContent(string[] content, Panel_Credits panel)
	{
		return null;
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TextureCreditElement()
	{
	}
}
