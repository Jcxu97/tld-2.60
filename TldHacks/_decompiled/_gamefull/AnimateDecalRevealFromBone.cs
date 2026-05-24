using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200018F")]
public class AnimateDecalRevealFromBone : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_RevealBone;

	[SerializeField]
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x28")]
	private TransformAxis m_RevealAnimatedAxis;

	[SerializeField]
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_EraseBone;

	[SerializeField]
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x38")]
	private TransformAxis m_EraseAnimatedAxis;

	[SerializeField]
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x3C")]
	private float m_EraseThreshold;

	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x60CBC0", Offset = "0x60B9C0", Length = "0x224")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x60CDF0", Offset = "0x60BBF0", Length = "0x51")]
	public AnimateDecalRevealFromBone()
	{
	}
}
