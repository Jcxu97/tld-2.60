using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000239")]
public class FirstAidKitButton : MonoBehaviour
{
	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x20")]
	public string m_ClickAudio;

	[Token(Token = "0x40013B0")]
	[FieldOffset(Offset = "0x28")]
	public GearItem m_GearItem;

	[Token(Token = "0x40013B1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_LabelAmount;

	[Token(Token = "0x40013B2")]
	[FieldOffset(Offset = "0x38")]
	public Color m_GlowColorHasItem;

	[Token(Token = "0x40013B3")]
	[FieldOffset(Offset = "0x48")]
	public Color m_GlowColorNotHaveItem;

	[Token(Token = "0x40013B4")]
	[FieldOffset(Offset = "0x58")]
	public Color m_SpriteColorHasItem;

	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x68")]
	public Color m_SpriteColorNotHaveItem;

	[Token(Token = "0x40013B6")]
	[FieldOffset(Offset = "0x78")]
	public FirstAidKitButton[] m_ShareHasItemStatusButtons;

	[Token(Token = "0x40013B7")]
	[FieldOffset(Offset = "0x80")]
	public bool m_IsWater;

	[Token(Token = "0x40013B8")]
	[FieldOffset(Offset = "0x88")]
	public UISprite m_GlowSprite;

	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x90")]
	public UITexture m_ItemTexture;

	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x98")]
	private bool m_Enabled;

	[Token(Token = "0x60013AD")]
	[Address(RVA = "0x6742C0", Offset = "0x6730C0", Length = "0x6CC")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60013AE")]
	[Address(RVA = "0x674990", Offset = "0x673790", Length = "0x7")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60013AF")]
	[Address(RVA = "0x6749A0", Offset = "0x6737A0", Length = "0xB7")]
	public void SetNeeded(bool needed)
	{
	}

	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x5023A0", Offset = "0x5011A0", Length = "0x8")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x674A60", Offset = "0x673860", Length = "0x83")]
	public FirstAidKitButton()
	{
	}
}
