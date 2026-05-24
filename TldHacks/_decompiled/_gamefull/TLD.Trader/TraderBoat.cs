using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013B2")]
public class TraderBoat : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009044")]
	[FieldOffset(Offset = "0x20")]
	private float m_VisibleHoursAfterTradeComplete;

	[Token(Token = "0x6007DD9")]
	[Address(RVA = "0x11D1310", Offset = "0x11D0110", Length = "0x1D9")]
	private void Update()
	{
	}

	[Token(Token = "0x6007DDA")]
	[Address(RVA = "0x11D14F0", Offset = "0x11D02F0", Length = "0x4A")]
	public TraderBoat()
	{
	}
}
