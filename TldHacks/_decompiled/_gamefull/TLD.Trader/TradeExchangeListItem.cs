using Cpp2ILInjected;
using TLD.UI.Scroll;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013C6")]
public class TradeExchangeListItem : ScrollBehaviourItem
{
	[Header("List Item")]
	[SerializeField]
	[Token(Token = "0x40090EA")]
	[FieldOffset(Offset = "0x38")]
	private UITexture m_ItemIcon;

	[SerializeField]
	[Token(Token = "0x40090EB")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_SpecialRequestIcon;

	[SerializeField]
	[Token(Token = "0x40090EC")]
	[FieldOffset(Offset = "0x48")]
	private UILabel m_ItemName;

	[SerializeField]
	[Token(Token = "0x40090ED")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_ItemSelectedIcon;

	[SerializeField]
	[Token(Token = "0x40090EE")]
	[FieldOffset(Offset = "0x58")]
	private UISprite m_Background;

	[SerializeField]
	[Token(Token = "0x40090EF")]
	[FieldOffset(Offset = "0x60")]
	private UIButton m_Button;

	[SerializeField]
	[Token(Token = "0x40090F0")]
	[FieldOffset(Offset = "0x68")]
	private Color m_Normal;

	[SerializeField]
	[Token(Token = "0x40090F1")]
	[FieldOffset(Offset = "0x78")]
	private Color m_Selected;

	[Token(Token = "0x6007E5A")]
	[Address(RVA = "0x11DDC20", Offset = "0x11DCA20", Length = "0x2A8")]
	public void SetTradeExchangeData(TradeExchangeData tradeExchangeData, int multiplier)
	{
	}

	[Token(Token = "0x6007E5B")]
	[Address(RVA = "0x11DDED0", Offset = "0x11DCCD0", Length = "0x13D")]
	public override void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6007E5C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TradeExchangeListItem()
	{
	}
}
