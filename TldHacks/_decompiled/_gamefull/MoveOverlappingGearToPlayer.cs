using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004C2")]
public class MoveOverlappingGearToPlayer : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002BB6")]
	[FieldOffset(Offset = "0x20")]
	private Bounds m_Bounds;

	[Token(Token = "0x4002BB7")]
	private static Collider[] s_Results;

	[Token(Token = "0x600244A")]
	[Address(RVA = "0x8654A0", Offset = "0x8642A0", Length = "0x589")]
	private void Start()
	{
	}

	[Token(Token = "0x600244B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MoveOverlappingGearToPlayer()
	{
	}
}
