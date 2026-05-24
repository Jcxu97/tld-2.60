using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005B3")]
public class SpecialContainerTag : MonoBehaviour
{
	[Token(Token = "0x40034BE")]
	[FieldOffset(Offset = "0x20")]
	public bool m_CanStickToGroundOnBreakdown;

	[Token(Token = "0x6002C24")]
	[Address(RVA = "0x6A2880", Offset = "0x6A1680", Length = "0x47")]
	public SpecialContainerTag()
	{
	}
}
