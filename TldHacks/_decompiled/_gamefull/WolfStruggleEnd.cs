using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200080E")]
public class WolfStruggleEnd : StateMachineBehaviour
{
	[Token(Token = "0x4005542")]
	[FieldOffset(Offset = "0x18")]
	public float m_StruggleEndSeconds;

	[Token(Token = "0x4005543")]
	[FieldOffset(Offset = "0x1C")]
	private float m_StruggleEndTime;

	[Token(Token = "0x4005544")]
	[FieldOffset(Offset = "0x20")]
	private bool m_Update;

	[Token(Token = "0x6004B3F")]
	[Address(RVA = "0xD50430", Offset = "0xD4F230", Length = "0x59")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6004B40")]
	[Address(RVA = "0xD50490", Offset = "0xD4F290", Length = "0x15F")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B41")]
	[Address(RVA = "0xD505F0", Offset = "0xD4F3F0", Length = "0x10A")]
	private void EndStruggle(Animator animator)
	{
	}

	[Token(Token = "0x6004B42")]
	[Address(RVA = "0xD50700", Offset = "0xD4F500", Length = "0x12")]
	public WolfStruggleEnd()
	{
	}
}
