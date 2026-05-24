using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000800")]
public class GetRandomInt : StateMachineBehaviour
{
	[Token(Token = "0x400550D")]
	[FieldOffset(Offset = "0x18")]
	public int m_RangeMax;

	[Token(Token = "0x6004B1E")]
	[Address(RVA = "0xD4E130", Offset = "0xD4CF30", Length = "0x9E")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B1F")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public GetRandomInt()
	{
	}
}
