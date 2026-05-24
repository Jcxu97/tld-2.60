using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000189")]
public class TimberwolfReplenishTrigger : MonoBehaviour
{
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_targetGameObject;

	[Token(Token = "0x6000F0F")]
	[Address(RVA = "0x609970", Offset = "0x608770", Length = "0x14F")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TimberwolfReplenishTrigger()
	{
	}
}
