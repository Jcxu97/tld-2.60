using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001FB")]
public class AfflictionButton : MonoBehaviour
{
	[Token(Token = "0x40011EC")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_SpriteEffect;

	[Token(Token = "0x40011ED")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_SpriteRiskFill;

	[Token(Token = "0x40011EE")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_LabelEffect;

	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_LabelCause;

	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x40")]
	public Color m_NegativeColor;

	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x50")]
	public Color m_NegativeColorHover;

	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x60")]
	public Color m_RiskColor;

	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x70")]
	public Color m_RiskColorHover;

	[Token(Token = "0x40011F4")]
	[FieldOffset(Offset = "0x80")]
	public Color m_BeneficialColor;

	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0x90")]
	public Color m_BeneficialColorHover;

	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_CauseColor;

	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0xB0")]
	public Color m_CauseColorHover;

	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0xC0")]
	public float m_BGAlphaWhenSelected;

	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0xC4")]
	public AfflictionType m_AfflictionType;

	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0xC8")]
	public AfflictionBodyArea m_AfflictionLocation;

	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0xD0")]
	public Animator m_AnimatorBuffBar;

	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite m_FillSpriteBuffBar;

	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0xE0")]
	public Transform m_SizeModifierBuffBar;

	[Token(Token = "0x40011FE")]
	[FieldOffset(Offset = "0xE8")]
	public Animator m_AnimatorAfflictionBar;

	[Token(Token = "0x40011FF")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite m_FillSpriteAfflictionBar;

	[Token(Token = "0x4001200")]
	[FieldOffset(Offset = "0xF8")]
	public Transform m_SizeModifierAfflictionBar;

	[Tooltip("Fill Sprite modifier value for sprites with a lot of empty space. For example, setting this to 0.2 will make a fill sprite go from 0.2 to 0.8 instead of 0 to 1")]
	[Token(Token = "0x4001201")]
	[FieldOffset(Offset = "0x100")]
	public float m_FillSpriteOffset;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0x108")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x110")]
	private bool m_Selected;

	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0x114")]
	private int m_Index;

	[Token(Token = "0x6001200")]
	[Address(RVA = "0x646490", Offset = "0x645290", Length = "0x7")]
	private void Update()
	{
	}

	[Token(Token = "0x6001201")]
	[Address(RVA = "0x6464A0", Offset = "0x6452A0", Length = "0x8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001202")]
	[Address(RVA = "0x6464B0", Offset = "0x6452B0", Length = "0xB8")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6001203")]
	[Address(RVA = "0x646570", Offset = "0x645370", Length = "0x2DC")]
	private void SetColor(bool isSelected)
	{
	}

	[Token(Token = "0x6001204")]
	[Address(RVA = "0x646850", Offset = "0x645650", Length = "0x157")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001205")]
	[Address(RVA = "0x6469B0", Offset = "0x6457B0", Length = "0x3B8")]
	public void SetCauseAndEffect(string causeStr, AfflictionType affType, AfflictionBodyArea location, int index, string effectName, string spriteName)
	{
	}

	[Token(Token = "0x6001206")]
	[Address(RVA = "0x646D70", Offset = "0x645B70", Length = "0x7")]
	public int GetIndex()
	{
		return 0;
	}

	[Token(Token = "0x6001207")]
	[Address(RVA = "0x646D80", Offset = "0x645B80", Length = "0x121")]
	public Color GetColorBasedOnAffliction(AfflictionType m_AfflictionType, bool isHovering)
	{
		return default(Color);
	}

	[Token(Token = "0x6001208")]
	[Address(RVA = "0x646EB0", Offset = "0x645CB0", Length = "0xB89")]
	private void UpdateFillBar()
	{
	}

	[Token(Token = "0x6001209")]
	[Address(RVA = "0x646D70", Offset = "0x645B70", Length = "0x7")]
	public int GetAfflictionIndex()
	{
		return 0;
	}

	[Token(Token = "0x600120A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AfflictionButton()
	{
	}
}
