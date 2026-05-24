using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013C9")]
public class TraderHUDExchange : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40090F6")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_Exchange;

	[SerializeField]
	[Token(Token = "0x40090F7")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget m_Widget;

	[SerializeField]
	[Token(Token = "0x40090F8")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_TradeText;

	[SerializeField]
	[Token(Token = "0x40090F9")]
	[FieldOffset(Offset = "0x38")]
	private int m_TradeTextOffset;

	[Header("Progress Items")]
	[SerializeField]
	[Token(Token = "0x40090FA")]
	[FieldOffset(Offset = "0x40")]
	private List<ExchangeBoxProgressListItem> m_ProgressItems;

	[SerializeField]
	[Token(Token = "0x40090FB")]
	[FieldOffset(Offset = "0x48")]
	private int m_LineHeight;

	[Token(Token = "0x6007E61")]
	[Address(RVA = "0x11DE500", Offset = "0x11DD300", Length = "0x5D9")]
	public int Refresh(TradeExchangeData exchangeData, int exchangeCount)
	{
		return 0;
	}

	[Token(Token = "0x6007E62")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TraderHUDExchange()
	{
	}
}
