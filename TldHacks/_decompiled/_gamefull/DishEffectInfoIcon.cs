using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000232")]
public class DishEffectInfoIcon : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0x20")]
	private UISprite m_Sprite;

	[SerializeField]
	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_Label;

	[SerializeField]
	[Token(Token = "0x400136D")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] m_BenefitArrows;

	[SerializeField]
	[Token(Token = "0x400136E")]
	[FieldOffset(Offset = "0x38")]
	private GameObject[] m_DetrimentArrows;

	[SerializeField]
	[Token(Token = "0x400136F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_Tooltip;

	[SerializeField]
	[Token(Token = "0x4001370")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_TooltipLabel;

	[SerializeField]
	[Token(Token = "0x4001371")]
	[FieldOffset(Offset = "0x50")]
	private Color m_BenefitColor;

	[SerializeField]
	[Token(Token = "0x4001372")]
	[FieldOffset(Offset = "0x60")]
	private Color m_DetrimentColor;

	[Token(Token = "0x600137B")]
	[Address(RVA = "0x66B3C0", Offset = "0x66A1C0", Length = "0x527")]
	public void ShowDishEffect(DishEffectInfoUI.DishEffectUIMapping dishEffectUIMapping, IFoodEffect.Effect effect)
	{
	}

	[Token(Token = "0x600137C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DishEffectInfoIcon()
	{
	}
}
