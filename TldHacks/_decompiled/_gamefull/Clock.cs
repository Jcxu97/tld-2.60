using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000215")]
public class Clock : MonoBehaviour
{
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x20")]
	public Transform m_MinuteHand;

	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_HourHand;

	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x657830", Offset = "0x656630", Length = "0xAB")]
	private void Update()
	{
	}

	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Clock()
	{
	}
}
