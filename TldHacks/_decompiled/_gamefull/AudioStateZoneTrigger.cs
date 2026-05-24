using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009BD")]
public class AudioStateZoneTrigger : MonoBehaviour
{
	[Token(Token = "0x400635D")]
	[FieldOffset(Offset = "0x20")]
	public AudioOcclusionLevel m_OcclusionLevel;

	[Token(Token = "0x400635E")]
	[FieldOffset(Offset = "0x28")]
	public OpenClose m_Door;

	[Token(Token = "0x400635F")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Occluded;

	[Token(Token = "0x600564D")]
	[Address(RVA = "0xEADDC0", Offset = "0xEACBC0", Length = "0x5")]
	public void Start()
	{
	}

	[Token(Token = "0x600564E")]
	[Address(RVA = "0xEB6720", Offset = "0xEB5520", Length = "0x206")]
	public void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x600564F")]
	[Address(RVA = "0xEB6930", Offset = "0xEB5730", Length = "0xB3")]
	public void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6005650")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AudioStateZoneTrigger()
	{
	}
}
