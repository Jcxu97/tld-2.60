using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009C2")]
public class HeldItemRestrictionTrigger : MonoBehaviour
{
	[Token(Token = "0x4006370")]
	[FieldOffset(Offset = "0x20")]
	public HeldItemRestriction m_Restriction;

	[Token(Token = "0x600565E")]
	[Address(RVA = "0xEB78A0", Offset = "0xEB66A0", Length = "0xAA")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x600565F")]
	[Address(RVA = "0xEB7950", Offset = "0xEB6750", Length = "0xEC")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6005660")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HeldItemRestrictionTrigger()
	{
	}
}
