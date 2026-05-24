using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000809")]
public class SpeedForPathfinding : StateMachineBehaviour
{
	[Token(Token = "0x400552E")]
	[FieldOffset(Offset = "0x18")]
	public float m_Speed;

	[Token(Token = "0x6004B32")]
	[Address(RVA = "0xD4F5F0", Offset = "0xD4E3F0", Length = "0x129")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B33")]
	[Address(RVA = "0xD4F720", Offset = "0xD4E520", Length = "0x108")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B34")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public SpeedForPathfinding()
	{
	}
}
