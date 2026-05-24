using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013C8")]
public class TraderHUD : MonoBehaviour
{
	[Header("Items")]
	[SerializeField]
	[Token(Token = "0x40090F4")]
	[FieldOffset(Offset = "0x20")]
	private List<TraderHUDExchange> m_ExchangesItems;

	[SerializeField]
	[Token(Token = "0x40090F5")]
	[FieldOffset(Offset = "0x28")]
	private int m_ItemSpacing;

	[Token(Token = "0x6007E5F")]
	[Address(RVA = "0x11DE0A0", Offset = "0x11DCEA0", Length = "0x45B")]
	public int UpdateTraderHUD()
	{
		return 0;
	}

	[Token(Token = "0x6007E60")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TraderHUD()
	{
	}
}
