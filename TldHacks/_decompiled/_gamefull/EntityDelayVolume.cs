using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000417")]
public class EntityDelayVolume : MonoBehaviour
{
	[Tooltip("Percentage amount to affect the speed by. 0.5 will make it move at half speed, 2 will double the speed. A value of 0 will stop the entity entirely.")]
	[Range(0f, 2f)]
	[Token(Token = "0x40024E6")]
	[FieldOffset(Offset = "0x20")]
	public float m_EntityDelayFactor;

	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x7CF410", Offset = "0x7CE210", Length = "0x10D")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x7CF520", Offset = "0x7CE320", Length = "0x11E")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EntityDelayVolume()
	{
	}
}
