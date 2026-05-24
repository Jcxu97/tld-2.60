using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000399")]
public class SnowImprintVariant
{
	[Token(Token = "0x400203A")]
	[FieldOffset(Offset = "0x10")]
	public SnowImprintRenderType m_RenderType;

	[Token(Token = "0x400203B")]
	[FieldOffset(Offset = "0x18")]
	public string m_HeightMapTexId;

	[Token(Token = "0x400203C")]
	[FieldOffset(Offset = "0x20")]
	public float m_HeightMapRenderScalar;

	[Token(Token = "0x400203D")]
	[FieldOffset(Offset = "0x28")]
	public string m_BumpDecalTexId;

	[Token(Token = "0x400203E")]
	[FieldOffset(Offset = "0x30")]
	public float m_BumpDecalRenderScalar;

	[Token(Token = "0x400203F")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 m_DepthSelectionRange;

	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SnowImprintVariant()
	{
	}
}
