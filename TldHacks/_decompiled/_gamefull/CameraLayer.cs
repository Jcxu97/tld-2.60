using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019A")]
public class CameraLayer : StateMachineBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x18")]
	private PlayerAnimation.CameraLayer m_Layer;

	[Token(Token = "0x6000F52")]
	[Address(RVA = "0x60FA00", Offset = "0x60E800", Length = "0x91")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000F53")]
	[Address(RVA = "0x60FAA0", Offset = "0x60E8A0", Length = "0x91")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public CameraLayer()
	{
	}
}
