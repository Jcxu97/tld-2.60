using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009D4")]
public class ScriptActionsTrigger : MonoBehaviour
{
	[Token(Token = "0x40063D4")]
	[FieldOffset(Offset = "0x20")]
	public bool m_SupressNonCriticalSpeech;

	[Token(Token = "0x60056C6")]
	[Address(RVA = "0xEC0B40", Offset = "0xEBF940", Length = "0xA8")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60056C7")]
	[Address(RVA = "0xEC0BF0", Offset = "0xEBF9F0", Length = "0xA8")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x60056C8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ScriptActionsTrigger()
	{
	}
}
