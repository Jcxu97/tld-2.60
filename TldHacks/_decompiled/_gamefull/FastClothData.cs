using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200038B")]
public class FastClothData : ScriptableObject
{
	[Token(Token = "0x4001FA7")]
	[FieldOffset(Offset = "0x18")]
	public Mesh m_Mesh;

	[Token(Token = "0x4001FA8")]
	[FieldOffset(Offset = "0x20")]
	public Vector4[] m_BlendShapeMidVertexDeltas;

	[Token(Token = "0x4001FA9")]
	[FieldOffset(Offset = "0x28")]
	public Vector4[] m_BlendShapeMidNormalDeltas;

	[Token(Token = "0x4001FAA")]
	[FieldOffset(Offset = "0x30")]
	public Vector4[] m_BlendShapeEndVertexDeltas;

	[Token(Token = "0x4001FAB")]
	[FieldOffset(Offset = "0x38")]
	public Vector4[] m_BlendShapeEndNormalDeltas;

	[Token(Token = "0x4001FAC")]
	private const int BLENDSHAPE_INDEX = 0;

	[Token(Token = "0x4001FAD")]
	private const int MAX_SUPPORTED_VERTICES = 256;

	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x77E7A0", Offset = "0x77D5A0", Length = "0x188")]
	public bool IsValid()
	{
		return false;
	}

	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateBlendShapeDeltas()
	{
	}

	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x77E930", Offset = "0x77D730", Length = "0x12B")]
	private bool IsMeshValid()
	{
		return false;
	}

	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public FastClothData()
	{
	}
}
