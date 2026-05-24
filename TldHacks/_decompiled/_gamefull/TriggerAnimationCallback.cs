using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200080B")]
public class TriggerAnimationCallback : StateMachineBehaviour
{
	[Token(Token = "0x4005533")]
	[FieldOffset(Offset = "0x18")]
	public string m_AnimationEventEnterString;

	[Token(Token = "0x4005534")]
	[FieldOffset(Offset = "0x20")]
	public float m_NormalizedTime;

	[Token(Token = "0x4005535")]
	[FieldOffset(Offset = "0x28")]
	public string m_AnimationEventNormalizedTimeString;

	[Token(Token = "0x4005536")]
	[FieldOffset(Offset = "0x30")]
	public bool m_TriggerNormalizedTimeCallbackOnExit;

	[Token(Token = "0x4005537")]
	[FieldOffset(Offset = "0x38")]
	public string m_AnimationEventExitString;

	[Token(Token = "0x4005538")]
	[FieldOffset(Offset = "0x40")]
	private float m_LastFrameNormalizedTime;

	[Token(Token = "0x4005539")]
	[FieldOffset(Offset = "0x44")]
	private bool m_HasTriggeredNormalizedTimeCallback;

	[Token(Token = "0x6004B39")]
	[Address(RVA = "0xD4FCD0", Offset = "0xD4EAD0", Length = "0x1A5")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B3A")]
	[Address(RVA = "0xD4FE80", Offset = "0xD4EC80", Length = "0x2ED")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B3B")]
	[Address(RVA = "0xD50170", Offset = "0xD4EF70", Length = "0x1D8")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B3C")]
	[Address(RVA = "0xD50350", Offset = "0xD4F150", Length = "0xB")]
	public TriggerAnimationCallback()
	{
	}
}
