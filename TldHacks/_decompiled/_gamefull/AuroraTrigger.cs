using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000362")]
public class AuroraTrigger : MonoBehaviour
{
	[Token(Token = "0x4001DD7")]
	[FieldOffset(Offset = "0x20")]
	public AuroraBand[] m_AuroraList;

	[Token(Token = "0x4001DD8")]
	[FieldOffset(Offset = "0x28")]
	public bool m_TriggerOn;

	[Token(Token = "0x4001DD9")]
	[FieldOffset(Offset = "0x2C")]
	public Color m_CustomColour;

	[Token(Token = "0x4001DDA")]
	[FieldOffset(Offset = "0x3C")]
	public float m_TransitionTime;

	[Token(Token = "0x6001B85")]
	[Address(RVA = "0x761BD0", Offset = "0x7609D0", Length = "0x165")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001B86")]
	[Address(RVA = "0x761D40", Offset = "0x760B40", Length = "0x5A")]
	public AuroraTrigger()
	{
	}
}
