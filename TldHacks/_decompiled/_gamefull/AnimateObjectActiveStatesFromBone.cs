using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000193")]
public class AnimateObjectActiveStatesFromBone : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000194")]
	private class ObjectParams
	{
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Object;

		[Tooltip("Min [inclusive] and Max [exclusive]")]
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x18")]
		public MinMax m_ValueRange;

		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ObjectParams()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_Bone;

	[SerializeField]
	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x28")]
	private TransformAxis m_AnimatedAxis;

	[SerializeField]
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x30")]
	private ObjectParams[] m_Objects;

	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x60D370", Offset = "0x60C170", Length = "0x229")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AnimateObjectActiveStatesFromBone()
	{
	}
}
