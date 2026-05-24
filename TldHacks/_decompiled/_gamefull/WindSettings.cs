using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000332")]
public class WindSettings
{
	[Token(Token = "0x4001C84")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4001C85")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 m_VelocityRange;

	[Token(Token = "0x4001C86")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 m_GustinessRange;

	[Token(Token = "0x4001C87")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_LateralBlusterRange;

	[Token(Token = "0x4001C88")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_VerticalBlusterRange;

	[Token(Token = "0x4001C89")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 m_RTPC_Range;

	[Token(Token = "0x4001C8A")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_ClothRandomRange;

	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WindSettings()
	{
	}
}
