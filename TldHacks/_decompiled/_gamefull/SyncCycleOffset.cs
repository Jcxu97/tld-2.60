using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A8")]
public class SyncCycleOffset : StateMachineBehaviour
{
	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x18")]
	public string m_ParameterName;

	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x618020", Offset = "0x616E20", Length = "0x5E")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x618080", Offset = "0x616E80", Length = "0x90")]
	public SyncCycleOffset()
	{
	}
}
