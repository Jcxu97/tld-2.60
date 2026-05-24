using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009CA")]
public class InteriorTemperatureTrigger : MonoBehaviour
{
	[Token(Token = "0x4006396")]
	[FieldOffset(Offset = "0x20")]
	public float m_Temperature;

	[Token(Token = "0x4006397")]
	[FieldOffset(Offset = "0x24")]
	private float m_RestoreTemperature;

	[Token(Token = "0x4006398")]
	public static bool m_PlayerInside;

	[Token(Token = "0x600568F")]
	[Address(RVA = "0xEBB490", Offset = "0xEBA290", Length = "0x3B")]
	private void Start()
	{
	}

	[Token(Token = "0x6005690")]
	[Address(RVA = "0xEBB4D0", Offset = "0xEBA2D0", Length = "0xD3")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6005691")]
	[Address(RVA = "0xEBB5B0", Offset = "0xEBA3B0", Length = "0xC3")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6005692")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InteriorTemperatureTrigger()
	{
	}
}
