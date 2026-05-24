using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013C5")]
public class ExchangeButton : GenericGearGridButton
{
	[SerializeField]
	[Token(Token = "0x40090E8")]
	[FieldOffset(Offset = "0x30")]
	private UITexture m_GearTexture;

	[SerializeField]
	[Token(Token = "0x40090E9")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_SpecialRequestIcon;

	[Token(Token = "0x6007E58")]
	[Address(RVA = "0x11DDB90", Offset = "0x11DC990", Length = "0x86")]
	public void SetExchangeData(TradeExchangeData exchange)
	{
	}

	[Token(Token = "0x6007E59")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExchangeButton()
	{
	}
}
