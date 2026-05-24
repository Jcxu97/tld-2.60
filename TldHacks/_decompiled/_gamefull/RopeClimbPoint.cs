using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005AE")]
public class RopeClimbPoint : MonoBehaviour
{
	[Token(Token = "0x400348B")]
	[FieldOffset(Offset = "0x20")]
	public Rope m_Rope;

	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x92B4A0", Offset = "0x92A2A0", Length = "0x43D")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x92B8E0", Offset = "0x92A6E0", Length = "0x117")]
	public void OnRopeTransition(bool playerOnRope)
	{
	}

	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RopeClimbPoint()
	{
	}
}
