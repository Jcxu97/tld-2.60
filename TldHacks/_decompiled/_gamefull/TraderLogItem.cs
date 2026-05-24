using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000449")]
public class TraderLogItem : MonoBehaviour
{
	[Header("Active Trade")]
	[SerializeField]
	[Token(Token = "0x40026E5")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_ActiveTradeRoot;

	[SerializeField]
	[Token(Token = "0x40026E6")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_TradeProgressText;

	[SerializeField]
	[Token(Token = "0x40026E7")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_TradeProgressBar;

	[Header("Special Request")]
	[SerializeField]
	[Token(Token = "0x40026E8")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_SpecialRequestRoot;

	[SerializeField]
	[Token(Token = "0x40026E9")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_SpecialRequestHeader;

	[Header("Selection")]
	[SerializeField]
	[Token(Token = "0x40026EA")]
	[FieldOffset(Offset = "0x48")]
	private UIButton m_Button;

	[SerializeField]
	[Token(Token = "0x40026EB")]
	[FieldOffset(Offset = "0x50")]
	private UISprite m_Background;

	[SerializeField]
	[Token(Token = "0x40026EC")]
	[FieldOffset(Offset = "0x58")]
	private Color m_Selected;

	[SerializeField]
	[Token(Token = "0x40026ED")]
	[FieldOffset(Offset = "0x68")]
	private Color m_Normal;

	[Token(Token = "0x40026EE")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsSelected;

	[Token(Token = "0x600205B")]
	[Address(RVA = "0x7F71C0", Offset = "0x7F5FC0", Length = "0x21F")]
	public void ShowAsActiveTrade()
	{
	}

	[Token(Token = "0x600205C")]
	[Address(RVA = "0x7F73E0", Offset = "0x7F61E0", Length = "0x12B")]
	public void ShowAsSpecialRequest()
	{
	}

	[Token(Token = "0x600205D")]
	[Address(RVA = "0x7F7510", Offset = "0x7F6310", Length = "0x131")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TraderLogItem()
	{
	}
}
