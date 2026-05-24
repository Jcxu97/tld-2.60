using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013C4")]
public class ExchangeBoxProgressListItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40090E5")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget m_Widget;

	[SerializeField]
	[Token(Token = "0x40090E6")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_NameLabel;

	[SerializeField]
	[Token(Token = "0x40090E7")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_ProgressLabel;

	[Token(Token = "0x6007E56")]
	[Address(RVA = "0x11DDAD0", Offset = "0x11DC8D0", Length = "0xB1")]
	public void Refresh(ExchangeItem exchangeItem)
	{
	}

	[Token(Token = "0x6007E57")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExchangeBoxProgressListItem()
	{
	}
}
