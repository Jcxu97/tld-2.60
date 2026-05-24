using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007FF")]
public class ChanceEndWanderPause : StateMachineBehaviour
{
	[Tooltip("Delay before starting to evaluate Percent Chance.")]
	[Token(Token = "0x4005505")]
	[FieldOffset(Offset = "0x18")]
	public float m_DelayStartSeconds;

	[Tooltip("Maximum duration to allow WanderPause to continue even if Percent Chance hasn't happened.")]
	[Token(Token = "0x4005506")]
	[FieldOffset(Offset = "0x1C")]
	public float m_MaxSecondsBeforeEnd;

	[Tooltip("How often to evaluate Percent Chance after DelayStartSeconds.")]
	[Token(Token = "0x4005507")]
	[FieldOffset(Offset = "0x20")]
	public float m_TestFrequencySeconds;

	[Range(1f, 100f)]
	[Token(Token = "0x4005508")]
	[FieldOffset(Offset = "0x24")]
	public float m_PercentChance;

	[Token(Token = "0x4005509")]
	[FieldOffset(Offset = "0x28")]
	private float m_NextTestTime;

	[Token(Token = "0x400550A")]
	[FieldOffset(Offset = "0x2C")]
	private float m_MaxEndTime;

	[Token(Token = "0x400550B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Update;

	[HideInInspector]
	[Token(Token = "0x400550C")]
	[FieldOffset(Offset = "0x34")]
	public int m_AnimParameter_AiState;

	[Token(Token = "0x6004B19")]
	[Address(RVA = "0xD4DC70", Offset = "0xD4CA70", Length = "0x172")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B1A")]
	[Address(RVA = "0xD4DDF0", Offset = "0xD4CBF0", Length = "0x33")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B1B")]
	[Address(RVA = "0xD4DE30", Offset = "0xD4CC30", Length = "0x167")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B1C")]
	[Address(RVA = "0xD4DFA0", Offset = "0xD4CDA0", Length = "0x11B")]
	private void EndWanderPause(Animator animator)
	{
	}

	[Token(Token = "0x6004B1D")]
	[Address(RVA = "0xD4E0C0", Offset = "0xD4CEC0", Length = "0x66")]
	public ChanceEndWanderPause()
	{
	}
}
