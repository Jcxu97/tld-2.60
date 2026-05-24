using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200022F")]
public class SpriteCreditElement : CreditElement
{
	[SerializeField]
	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x28")]
	private UISprite m_Sprite;

	[Token(Token = "0x4001361")]
	private const int ALTAS_ID_INDEX = 0;

	[Token(Token = "0x4001362")]
	private const int SPRITE_NAME_INDEX = 1;

	[Token(Token = "0x4001363")]
	private const int SPRITE_SCALE_INDEX = 2;

	[Token(Token = "0x600136D")]
	[Address(RVA = "0x669E70", Offset = "0x668C70", Length = "0x1A2")]
	public override bool IsContentValid(string[] content, Panel_Credits panel)
	{
		return false;
	}

	[Token(Token = "0x600136E")]
	[Address(RVA = "0x66A020", Offset = "0x668E20", Length = "0x1FF")]
	public override void Populate(string[] content, Panel_Credits panel)
	{
	}

	[Token(Token = "0x600136F")]
	[Address(RVA = "0x66A220", Offset = "0x669020", Length = "0x137")]
	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x66A360", Offset = "0x669160", Length = "0x107")]
	public override void SetPosition(float yOffset)
	{
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0x66A470", Offset = "0x669270", Length = "0xEB")]
	private UIAtlas GetAtlasFromContent(string[] content, Panel_Credits panel)
	{
		return null;
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SpriteCreditElement()
	{
	}
}
