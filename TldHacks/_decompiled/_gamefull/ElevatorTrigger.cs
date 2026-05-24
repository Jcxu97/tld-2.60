using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000579")]
public class ElevatorTrigger : MonoBehaviour
{
	[Token(Token = "0x4003262")]
	[FieldOffset(Offset = "0x20")]
	public ElevatorPrototypeController m_ElevatorController;

	[Token(Token = "0x6002A22")]
	[Address(RVA = "0x8FB920", Offset = "0x8FA720", Length = "0x96")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002A23")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ElevatorTrigger()
	{
	}
}
