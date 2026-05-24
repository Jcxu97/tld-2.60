using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000279")]
public class SetState : MonoBehaviour
{
	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ActiveOnState;

	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x28")]
	public string m_State;

	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x6A6990", Offset = "0x6A5790", Length = "0x88")]
	public void OnSetState(string state, bool active)
	{
	}

	[Token(Token = "0x60015A6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SetState()
	{
	}
}
