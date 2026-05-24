using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000725")]
public class StaticDecal
{
	[Token(Token = "0x4004BC1")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Pos;

	[Token(Token = "0x4004BC2")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 m_Scale;

	[Token(Token = "0x4004BC3")]
	[FieldOffset(Offset = "0x28")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4004BC4")]
	[FieldOffset(Offset = "0x38")]
	public Material m_Material;

	[Token(Token = "0x4004BC5")]
	[FieldOffset(Offset = "0x40")]
	public Material m_CameraClippedMaterial;

	[Token(Token = "0x4004BC6")]
	[FieldOffset(Offset = "0x48")]
	public Vector4 m_Uvs;

	[Token(Token = "0x4004BC7")]
	[FieldOffset(Offset = "0x58")]
	public bool m_UseZTestProperty;

	[Token(Token = "0x4004BC8")]
	[FieldOffset(Offset = "0x5C")]
	public int m_Layer;

	[Token(Token = "0x4004BC9")]
	[FieldOffset(Offset = "0x60")]
	public float m_ClipAngleCos;

	[Token(Token = "0x4004BCA")]
	[FieldOffset(Offset = "0x64")]
	public bool m_IgnoreDirectionalCulling;

	[Token(Token = "0x4004BCB")]
	[FieldOffset(Offset = "0x68")]
	public Action<CommandBuffer> m_OnProcessCommandBuffer;

	[Token(Token = "0x60040B4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public StaticDecal()
	{
	}
}
