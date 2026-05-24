using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200080A")]
public class TargetPlayer : StateMachineBehaviour
{
	[Token(Token = "0x400552F")]
	[FieldOffset(Offset = "0x18")]
	public float m_StartTime;

	[Token(Token = "0x4005530")]
	[FieldOffset(Offset = "0x1C")]
	public float m_EndTime;

	[Token(Token = "0x4005531")]
	[FieldOffset(Offset = "0x20")]
	public bool m_CanRunWhileInTransition;

	[Token(Token = "0x4005532")]
	[FieldOffset(Offset = "0x28")]
	private AiTarget m_PreviousTarget;

	[Token(Token = "0x6004B35")]
	[Address(RVA = "0xD4F830", Offset = "0xD4E630", Length = "0x161")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B36")]
	[Address(RVA = "0xD4F9A0", Offset = "0xD4E7A0", Length = "0x1B6")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B37")]
	[Address(RVA = "0xD4FB60", Offset = "0xD4E960", Length = "0x161")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B38")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public TargetPlayer()
	{
	}
}
