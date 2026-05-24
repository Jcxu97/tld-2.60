using System;
using Cpp2ILInjected;
using UnityEngine;

[DisallowMultipleComponent]
[Token(Token = "0x2000190")]
public class AnimateMaterialPropertyFromBone : MonoBehaviour
{
	[Token(Token = "0x2000191")]
	private enum MaterialPropertyType
	{
		[Token(Token = "0x4000E94")]
		Float,
		[Token(Token = "0x4000E95")]
		Vector
	}

	[Serializable]
	[Token(Token = "0x2000192")]
	private class AnimatedPropertyData
	{
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x10")]
		public TransformAxis m_AnimatedAxis;

		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x18")]
		public string m_MaterialPropertyName;

		[NonSerialized]
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x20")]
		public int m_MaterialPropertyID;

		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public AnimatedPropertyData()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_Bone;

	[SerializeField]
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x28")]
	private TransformAxis m_AnimatedAxis;

	[SerializeField]
	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x2C")]
	private MaterialPropertyType m_MaterialPropertyType;

	[SerializeField]
	[Range(0f, 3f)]
	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x30")]
	private int m_VectorPropertyIndex;

	[SerializeField]
	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x34")]
	private Vector4 m_VectorPropertyDefaultValue;

	[SerializeField]
	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x48")]
	private string m_MaterialPropertyName;

	[SerializeField]
	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x50")]
	private AnimatedPropertyData[] m_MultiPropertyData;

	[SerializeField]
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x58")]
	private Renderer[] m_AffectedRenderers;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock m_MaterialPropertyBlock;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x68")]
	private int m_MaterialPropertyID;

	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x60CE50", Offset = "0x60BC50", Length = "0x126")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x60CF80", Offset = "0x60BD80", Length = "0x363")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x60D2F0", Offset = "0x60C0F0", Length = "0x80")]
	public AnimateMaterialPropertyFromBone()
	{
	}
}
