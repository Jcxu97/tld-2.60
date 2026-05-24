using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000727")]
public class DecalRenderBatch
{
	[Token(Token = "0x4004BCD")]
	public const int MAX_INSTANCES = 500;

	[Token(Token = "0x4004BCE")]
	[FieldOffset(Offset = "0x10")]
	public MaterialPropertyBlock m_Block;

	[Token(Token = "0x4004BCF")]
	[FieldOffset(Offset = "0x18")]
	public Matrix4x4[] m_Transforms;

	[Token(Token = "0x4004BD0")]
	[FieldOffset(Offset = "0x20")]
	public float[] m_FadeProperties;

	[Token(Token = "0x4004BD1")]
	[FieldOffset(Offset = "0x28")]
	public Vector4[] m_MainTexUVProperties;

	[Token(Token = "0x4004BD2")]
	[FieldOffset(Offset = "0x30")]
	public float[] m_ClipAngles;

	[Token(Token = "0x4004BD3")]
	[FieldOffset(Offset = "0x38")]
	public Material m_Material;

	[Token(Token = "0x4004BD4")]
	[FieldOffset(Offset = "0x40")]
	public int m_Count;

	[Token(Token = "0x60040B6")]
	[Address(RVA = "0xC0C3E0", Offset = "0xC0B1E0", Length = "0x29F")]
	public DecalRenderBatch()
	{
	}
}
