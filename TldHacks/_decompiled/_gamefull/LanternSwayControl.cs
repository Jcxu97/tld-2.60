using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000803")]
public class LanternSwayControl : StateMachineBehaviour
{
	[Token(Token = "0x4005519")]
	[FieldOffset(Offset = "0x18")]
	public float m_SecondsToDamp;

	[Token(Token = "0x400551A")]
	[FieldOffset(Offset = "0x1C")]
	private SoftJointLimit m_AngularLimitY;

	[Token(Token = "0x400551B")]
	[FieldOffset(Offset = "0x28")]
	private SoftJointLimit m_AngularLimitZ;

	[Token(Token = "0x400551C")]
	[FieldOffset(Offset = "0x38")]
	private ConfigurableJoint m_ConfigurableJoint;

	[Token(Token = "0x400551D")]
	[FieldOffset(Offset = "0x40")]
	private float m_StartTime;

	[Token(Token = "0x400551E")]
	[FieldOffset(Offset = "0x44")]
	private float m_StartAngularLimitY;

	[Token(Token = "0x400551F")]
	[FieldOffset(Offset = "0x48")]
	private float m_StartAngularLimitZ;

	[Token(Token = "0x4005520")]
	[FieldOffset(Offset = "0x4C")]
	public float m_TargetAngularLimitY;

	[Token(Token = "0x4005521")]
	[FieldOffset(Offset = "0x50")]
	public float m_TargetAngularLimitZ;

	[Token(Token = "0x6004B22")]
	[Address(RVA = "0xD4E860", Offset = "0xD4D660", Length = "0x5BD")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B23")]
	[Address(RVA = "0xD4EE20", Offset = "0xD4DC20", Length = "0x341")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B24")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public LanternSwayControl()
	{
	}
}
