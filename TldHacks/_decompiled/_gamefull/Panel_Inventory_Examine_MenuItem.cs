using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000672")]
public class Panel_Inventory_Examine_MenuItem : MonoBehaviour
{
	[Token(Token = "0x4004186")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_LabelTitle;

	[Token(Token = "0x4004187")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_SpriteBackground;

	[Token(Token = "0x4004188")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_SpriteX;

	[Token(Token = "0x4004189")]
	[FieldOffset(Offset = "0x38")]
	public Color m_TextColor_Normal;

	[Token(Token = "0x400418A")]
	[FieldOffset(Offset = "0x48")]
	public Color m_TextColor_NormalHover;

	[Token(Token = "0x400418B")]
	[FieldOffset(Offset = "0x58")]
	public Color m_TextColor_NormalSelected;

	[Token(Token = "0x400418C")]
	[FieldOffset(Offset = "0x68")]
	public Color m_TextColor_Disabled;

	[Token(Token = "0x400418D")]
	[FieldOffset(Offset = "0x78")]
	public Color m_TextColor_DisabledHover;

	[Token(Token = "0x400418E")]
	[FieldOffset(Offset = "0x88")]
	public Color m_TextColor_DisabledSelected;

	[Token(Token = "0x400418F")]
	[FieldOffset(Offset = "0x98")]
	public Color m_SpriteColorSelected;

	[Token(Token = "0x4004190")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_SpriteColorSelectedHover;

	[Token(Token = "0x4004191")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_SpriteColorUnselected;

	[Token(Token = "0x4004192")]
	[FieldOffset(Offset = "0xC8")]
	public Color m_SpriteColorUnselectedHover;

	[Token(Token = "0x4004193")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton m_ButtonSpriteRef;

	[Token(Token = "0x4004194")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_Selected;

	[Token(Token = "0x4004195")]
	[FieldOffset(Offset = "0xE1")]
	private bool m_Hover;

	[Token(Token = "0x4004196")]
	[FieldOffset(Offset = "0xE2")]
	private bool m_Disabled;

	[Token(Token = "0x6003636")]
	[Address(RVA = "0xAD5A40", Offset = "0xAD4840", Length = "0x2FB")]
	public void Update()
	{
	}

	[Token(Token = "0x6003637")]
	[Address(RVA = "0xAD5D40", Offset = "0xAD4B40", Length = "0xC2")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6003638")]
	[Address(RVA = "0xAD5E10", Offset = "0xAD4C10", Length = "0x7")]
	public void OnHover(bool hover)
	{
	}

	[Token(Token = "0x6003639")]
	[Address(RVA = "0xAD5E20", Offset = "0xAD4C20", Length = "0x7")]
	public void SetDisabled(bool disabled)
	{
	}

	[Token(Token = "0x600363A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Inventory_Examine_MenuItem()
	{
	}
}
