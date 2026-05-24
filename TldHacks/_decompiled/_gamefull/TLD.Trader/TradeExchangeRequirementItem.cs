using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013C7")]
public class TradeExchangeRequirementItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40090F2")]
	[FieldOffset(Offset = "0x20")]
	private UITexture m_ExchangeItemIcon;

	[SerializeField]
	[Token(Token = "0x40090F3")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_ExchangeItemLabel;

	[Token(Token = "0x6007E5D")]
	[Address(RVA = "0x11DE010", Offset = "0x11DCE10", Length = "0x89")]
	public void Refresh(ExchangeItem exchangeItem, int multiplier)
	{
	}

	[Token(Token = "0x6007E5E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TradeExchangeRequirementItem()
	{
	}
}
