using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000266")]
public class NPCAfflictionButton : MonoBehaviour
{
	[Token(Token = "0x40015E1")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_SpriteEffect;

	[Token(Token = "0x40015E2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_SpriteRiskFill;

	[Token(Token = "0x40015E3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_LabelEffect;

	[Token(Token = "0x40015E4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_LabelCause;

	[Token(Token = "0x40015E5")]
	[FieldOffset(Offset = "0x40")]
	public Color m_NegativeColor;

	[Token(Token = "0x40015E6")]
	[FieldOffset(Offset = "0x50")]
	public Color m_NegativeColorHover;

	[Token(Token = "0x40015E7")]
	[FieldOffset(Offset = "0x60")]
	public Color m_RiskColor;

	[Token(Token = "0x40015E8")]
	[FieldOffset(Offset = "0x70")]
	public Color m_RiskColorHover;

	[Token(Token = "0x40015E9")]
	[FieldOffset(Offset = "0x80")]
	public Color m_BeneficialColor;

	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0x90")]
	public Color m_BeneficialColorHover;

	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_CauseColor;

	[Token(Token = "0x40015EC")]
	[FieldOffset(Offset = "0xB0")]
	public Color m_CauseColorHover;

	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0xC0")]
	public float m_BGAlphaWhenSelected;

	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0xC4")]
	public AfflictionType m_AfflictionType;

	[Token(Token = "0x40015EF")]
	[FieldOffset(Offset = "0xC8")]
	public AfflictionBodyArea m_AfflictionLocation;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0xD0")]
	public Animator m_AnimatorBuffBar;

	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite m_FillSpriteBuffBar;

	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0xE0")]
	public Transform m_SizeModifierBuffBar;

	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0xE8")]
	public Animator m_AnimatorAfflictionBar;

	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite m_FillSpriteAfflictionBar;

	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0xF8")]
	public Transform m_SizeModifierAfflictionBar;

	[Tooltip("Fill Sprite modifier value for sprites with a lot of empty space. For example, setting this to 0.2 will make a fill sprite go from 0.2 to 0.8 instead of 0 to 1")]
	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0x100")]
	public float m_FillSpriteOffset;

	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x104")]
	private bool m_Selected;

	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x108")]
	private int m_Index;

	[Token(Token = "0x40015F9")]
	[FieldOffset(Offset = "0x110")]
	private Action<NPCAfflictionButton> m_OnClickAction;

	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0x118")]
	private NPCAffliction m_Affliction;

	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x698BC0", Offset = "0x6979C0", Length = "0x8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60014F4")]
	[Address(RVA = "0x698BD0", Offset = "0x6979D0", Length = "0x87")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x698C60", Offset = "0x697A60", Length = "0xFE")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x698D60", Offset = "0x697B60", Length = "0x4F6")]
	public void SetupAffliction(NPCAffliction affliction, Action<NPCAfflictionButton> onClickAction)
	{
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x699260", Offset = "0x698060", Length = "0x8")]
	public NPCAffliction GetAffliction()
	{
		return null;
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x699270", Offset = "0x698070", Length = "0x130")]
	public Color GetColorBasedOnAffliction(AfflictionType afflictionType, bool isHovering)
	{
		return default(Color);
	}

	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x6993A0", Offset = "0x6981A0", Length = "0x2DC")]
	private void SetColor(bool isSelected)
	{
	}

	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NPCAfflictionButton()
	{
	}
}
