using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000807")]
public class ShowHands : StateMachineBehaviour
{
	[Token(Token = "0x2000808")]
	public enum Action
	{
		[Token(Token = "0x400552B")]
		Show,
		[Token(Token = "0x400552C")]
		Hide,
		[Token(Token = "0x400552D")]
		DoNothing
	}

	[Token(Token = "0x4005528")]
	[FieldOffset(Offset = "0x18")]
	public Action m_ActionOnEnter;

	[Token(Token = "0x4005529")]
	[FieldOffset(Offset = "0x1C")]
	public Action m_ActionOnExit;

	[Token(Token = "0x6004B2C")]
	[Address(RVA = "0xD4F530", Offset = "0xD4E330", Length = "0xB")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B2D")]
	[Address(RVA = "0xD4F530", Offset = "0xD4E330", Length = "0xB")]
	public override void OnStateMachineEnter(Animator animator, int layerIndex)
	{
	}

	[Token(Token = "0x6004B2E")]
	[Address(RVA = "0xD4F540", Offset = "0xD4E340", Length = "0xB")]
	public override void OnStateMachineExit(Animator animator, int layerIndex)
	{
	}

	[Token(Token = "0x6004B2F")]
	[Address(RVA = "0xD4F540", Offset = "0xD4E340", Length = "0xB")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B30")]
	[Address(RVA = "0xD4F550", Offset = "0xD4E350", Length = "0x99")]
	private void DoAction(Action action)
	{
	}

	[Token(Token = "0x6004B31")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ShowHands()
	{
	}
}
