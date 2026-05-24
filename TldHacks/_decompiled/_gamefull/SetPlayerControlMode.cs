using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000806")]
public class SetPlayerControlMode : StateMachineBehaviour
{
	[Token(Token = "0x4005522")]
	[FieldOffset(Offset = "0x18")]
	public bool m_SetModeOnEnter;

	[Token(Token = "0x4005523")]
	[FieldOffset(Offset = "0x19")]
	public bool m_SetModeOnExit;

	[Token(Token = "0x4005524")]
	[FieldOffset(Offset = "0x1A")]
	public bool m_RestoreModeOnExit;

	[Token(Token = "0x4005525")]
	[FieldOffset(Offset = "0x1C")]
	public PlayerControlMode m_ModeOnEnter;

	[Token(Token = "0x4005526")]
	[FieldOffset(Offset = "0x20")]
	public PlayerControlMode m_ModeOnExit;

	[Token(Token = "0x4005527")]
	[FieldOffset(Offset = "0x24")]
	private PlayerControlMode m_RestoreMode;

	[Token(Token = "0x6004B29")]
	[Address(RVA = "0xD4F3E0", Offset = "0xD4E1E0", Length = "0x99")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B2A")]
	[Address(RVA = "0xD4F480", Offset = "0xD4E280", Length = "0xA5")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B2B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public SetPlayerControlMode()
	{
	}
}
