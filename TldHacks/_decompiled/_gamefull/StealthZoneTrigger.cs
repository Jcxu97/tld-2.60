using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009D5")]
public class StealthZoneTrigger : MonoBehaviour
{
	[Token(Token = "0x40063D5")]
	[FieldOffset(Offset = "0x20")]
	public bool m_RequirePlayerCrouch;

	[Token(Token = "0x60056C9")]
	[Address(RVA = "0xEC0CA0", Offset = "0xEBFAA0", Length = "0x10F")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60056CA")]
	[Address(RVA = "0xEC0DB0", Offset = "0xEBFBB0", Length = "0xC7")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x60056CB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StealthZoneTrigger()
	{
	}
}
