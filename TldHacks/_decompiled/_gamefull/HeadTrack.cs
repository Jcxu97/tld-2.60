using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000801")]
public class HeadTrack : StateMachineBehaviour
{
	[Token(Token = "0x2000802")]
	public enum TargetType
	{
		[Token(Token = "0x4005517")]
		AiMarker,
		[Token(Token = "0x4005518")]
		Target
	}

	[Token(Token = "0x400550E")]
	[FieldOffset(Offset = "0x18")]
	public TargetType m_TargetType;

	[Token(Token = "0x400550F")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_CanRunWhileInTransition;

	[Token(Token = "0x4005510")]
	[FieldOffset(Offset = "0x20")]
	public float m_LookWeightHead;

	[Token(Token = "0x4005511")]
	[FieldOffset(Offset = "0x24")]
	public float m_LookWeightEyes;

	[Token(Token = "0x4005512")]
	[FieldOffset(Offset = "0x28")]
	public float m_LookWeightBody;

	[Token(Token = "0x4005513")]
	[FieldOffset(Offset = "0x2C")]
	public float m_LookWeightClamp;

	[Token(Token = "0x4005514")]
	[FieldOffset(Offset = "0x30")]
	public float m_LookAtDistance;

	[Token(Token = "0x4005515")]
	[FieldOffset(Offset = "0x34")]
	private float m_LookWeightMaster;

	[Token(Token = "0x6004B20")]
	[Address(RVA = "0xD4E1D0", Offset = "0xD4CFD0", Length = "0x685")]
	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004B21")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public HeadTrack()
	{
	}
}
