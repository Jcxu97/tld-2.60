using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004FF")]
public class SprainProtection : MonoBehaviour
{
	[Token(Token = "0x4002DCA")]
	[FieldOffset(Offset = "0x20")]
	private bool m_HasSprainProtection;

	[Token(Token = "0x4002DCB")]
	[FieldOffset(Offset = "0x21")]
	private bool m_UpdateBuffNotification;

	[Token(Token = "0x4002DCC")]
	[FieldOffset(Offset = "0x22")]
	private bool m_ShownSprainProtectionState;

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x899C00", Offset = "0x898A00", Length = "0x8E")]
	public void UpdateSprainProtection()
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
	public bool HasSprainProtection()
	{
		return false;
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x899C90", Offset = "0x898A90", Length = "0x175")]
	private void Update()
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x899E10", Offset = "0x898C10", Length = "0x5E")]
	private bool ShouldUpdateBuffNotification()
	{
		return false;
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SprainProtection()
	{
	}
}
