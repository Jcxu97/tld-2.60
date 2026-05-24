using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007FC")]
public class CameraBasedHandPositioningMode : StateMachineBehaviour
{
	[Token(Token = "0x40054FA")]
	[FieldOffset(Offset = "0x18")]
	public PlayerAnimation.CameraBasedHandPositioningMode m_OnEnter;

	[Token(Token = "0x40054FB")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_RestoreOnExit;

	[Token(Token = "0x40054FC")]
	[FieldOffset(Offset = "0x20")]
	public PlayerAnimation.CameraBasedHandPositioningMode m_OnExit;

	[Token(Token = "0x40054FD")]
	[FieldOffset(Offset = "0x24")]
	private PlayerAnimation.CameraBasedHandPositioningMode m_RestoreMode;

	[Token(Token = "0x6004B12")]
	[Address(RVA = "0xD4D830", Offset = "0xD4C630", Length = "0x74")]
	public override void OnStateMachineEnter(Animator animator, int layerIndex)
	{
	}

	[Token(Token = "0x6004B13")]
	[Address(RVA = "0xD4D8B0", Offset = "0xD4C6B0", Length = "0x6E")]
	public override void OnStateMachineExit(Animator animator, int layerIndex)
	{
	}

	[Token(Token = "0x6004B14")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public CameraBasedHandPositioningMode()
	{
	}
}
