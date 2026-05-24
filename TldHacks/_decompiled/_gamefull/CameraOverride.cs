using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007FD")]
public class CameraOverride : StateMachineBehaviour
{
	[Token(Token = "0x20007FE")]
	public enum Action
	{
		[Token(Token = "0x4005503")]
		DoNothing,
		[Token(Token = "0x4005504")]
		BlendToPitch
	}

	[Token(Token = "0x40054FE")]
	[FieldOffset(Offset = "0x18")]
	public float m_SecondsToDamp;

	[Token(Token = "0x40054FF")]
	[FieldOffset(Offset = "0x1C")]
	public float m_TargetPitch;

	[Token(Token = "0x4005500")]
	[FieldOffset(Offset = "0x20")]
	private float m_StartTime;

	[Token(Token = "0x4005501")]
	[FieldOffset(Offset = "0x24")]
	private float m_StartPitch;

	[Token(Token = "0x6004B15")]
	[Address(RVA = "0xD4D920", Offset = "0xD4C720", Length = "0x16D")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B16")]
	[Address(RVA = "0xD4DA90", Offset = "0xD4C890", Length = "0x7")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B17")]
	[Address(RVA = "0xD4DAA0", Offset = "0xD4C8A0", Length = "0x1C2")]
	private void UpdateCamera()
	{
	}

	[Token(Token = "0x6004B18")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public CameraOverride()
	{
	}
}
