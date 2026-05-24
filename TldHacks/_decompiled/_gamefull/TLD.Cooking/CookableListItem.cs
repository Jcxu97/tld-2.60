using Cpp2ILInjected;
using TLD.UI.Scroll;
using UnityEngine;

namespace TLD.Cooking;

[Token(Token = "0x20013F8")]
public class CookableListItem : ScrollBehaviourItem
{
	[Token(Token = "0x4009205")]
	private static readonly string[] s_SkillLevelLabelText;

	[SerializeField]
	[Token(Token = "0x4009206")]
	[FieldOffset(Offset = "0x38")]
	private UIWidget m_Root;

	[SerializeField]
	[Token(Token = "0x4009207")]
	[FieldOffset(Offset = "0x40")]
	private UITexture m_ItemIcon;

	[SerializeField]
	[Token(Token = "0x4009208")]
	[FieldOffset(Offset = "0x48")]
	private UITexture m_SpecialIcon;

	[SerializeField]
	[Token(Token = "0x4009209")]
	[FieldOffset(Offset = "0x50")]
	private UILabel m_ItemName;

	[SerializeField]
	[Token(Token = "0x400920A")]
	[FieldOffset(Offset = "0x58")]
	private UILabel m_SkillLevelNumber;

	[SerializeField]
	[Token(Token = "0x400920B")]
	[FieldOffset(Offset = "0x60")]
	private UISprite m_Background;

	[SerializeField]
	[Token(Token = "0x400920C")]
	[FieldOffset(Offset = "0x68")]
	private UISprite m_AvailableIcon;

	[SerializeField]
	[Token(Token = "0x400920D")]
	[FieldOffset(Offset = "0x70")]
	private UISprite m_UnavailableIcon;

	[SerializeField]
	[Token(Token = "0x400920E")]
	[FieldOffset(Offset = "0x78")]
	private UIButton m_Button;

	[SerializeField]
	[Token(Token = "0x400920F")]
	[FieldOffset(Offset = "0x80")]
	private Color m_Disabled;

	[SerializeField]
	[Token(Token = "0x4009210")]
	[FieldOffset(Offset = "0x90")]
	private Color m_Normal;

	[SerializeField]
	[Token(Token = "0x4009211")]
	[FieldOffset(Offset = "0xA0")]
	private Color m_Selected;

	[Token(Token = "0x4009212")]
	[FieldOffset(Offset = "0xB0")]
	private CookableItem m_Cookable;

	[Token(Token = "0x4009213")]
	[FieldOffset(Offset = "0xC0")]
	private CookingPotItem m_CookingPot;

	[Token(Token = "0x6007F53")]
	[Address(RVA = "0x11F24D0", Offset = "0x11F12D0", Length = "0x276")]
	public override void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6007F54")]
	[Address(RVA = "0x11F2750", Offset = "0x11F1550", Length = "0x70F")]
	public void SetCookable(CookableItem cookableItem, CookingPotItem cookingPot)
	{
	}

	[Token(Token = "0x6007F55")]
	[Address(RVA = "0x11F2E60", Offset = "0x11F1C60", Length = "0x47")]
	private void SetAvailability(bool canCook)
	{
	}

	[Token(Token = "0x6007F56")]
	[Address(RVA = "0x11F2EB0", Offset = "0x11F1CB0", Length = "0x71")]
	private bool CanCookItem()
	{
		return false;
	}

	[Token(Token = "0x6007F57")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CookableListItem()
	{
	}
}
