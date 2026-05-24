using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200016E")]
public class DarkWalker : MonoBehaviour
{
	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_LookAtRotator;

	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_LeftFoot;

	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x30")]
	public Transform m_RightFoot;

	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DarkWalker()
	{
	}
}
