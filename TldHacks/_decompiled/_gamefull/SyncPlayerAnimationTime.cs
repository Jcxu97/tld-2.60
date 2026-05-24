using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001AA")]
public class SyncPlayerAnimationTime : StateMachineBehaviour
{
	[Token(Token = "0x4000F06")]
	private const int PLAYER_ANIMATOR_LAYER = 0;

	[SerializeField]
	[Token(Token = "0x4000F07")]
	[FieldOffset(Offset = "0x18")]
	private string m_SyncStateName;

	[SerializeField]
	[Token(Token = "0x4000F08")]
	[FieldOffset(Offset = "0x20")]
	private string m_SyncParameter;

	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x28")]
	private Animator m_PlayerAnimator;

	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x30")]
	private int m_SyncStateNameHash;

	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x34")]
	private int m_SyncParameterHash;

	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x618570", Offset = "0x617370", Length = "0x186")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x618700", Offset = "0x617500", Length = "0x134")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public SyncPlayerAnimationTime()
	{
	}
}
