using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000722")]
public class DecalProjectorMaskData
{
	[Token(Token = "0x4004B96")]
	[FieldOffset(Offset = "0x10")]
	public Transform m_ParentTransform;

	[Token(Token = "0x4004B97")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_OffsetPosition;

	[Token(Token = "0x4004B98")]
	[FieldOffset(Offset = "0x24")]
	public Quaternion m_OffsetRotation;

	[Token(Token = "0x4004B99")]
	[FieldOffset(Offset = "0x34")]
	public int m_MaskTextureIndex;

	[Token(Token = "0x4004B9A")]
	[FieldOffset(Offset = "0x38")]
	public DecalMaskMode m_MaskMode;

	[Token(Token = "0x60040B0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DecalProjectorMaskData()
	{
	}
}
