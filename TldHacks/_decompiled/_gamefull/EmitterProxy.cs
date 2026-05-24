using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001BA")]
public class EmitterProxy : MonoBehaviour
{
	[Token(Token = "0x4000F38")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Proxy;

	[Token(Token = "0x4000F39")]
	[FieldOffset(Offset = "0x28")]
	public AkGameObj m_AkGameObj;

	[Token(Token = "0x6001006")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EmitterProxy()
	{
	}
}
