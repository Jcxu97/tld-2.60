using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000785")]
public struct MapDetailUnlockParameters
{
	[Token(Token = "0x400508D")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 m_Position;

	[Token(Token = "0x400508E")]
	[FieldOffset(Offset = "0xC")]
	public float m_Radius;

	[Token(Token = "0x400508F")]
	[FieldOffset(Offset = "0x10")]
	public bool m_RequiresLineOfSight;

	[Token(Token = "0x4005090")]
	[FieldOffset(Offset = "0x11")]
	public bool m_IgnoreHeight;

	[Token(Token = "0x4005091")]
	[FieldOffset(Offset = "0x12")]
	public bool m_IgnoreLogged;

	[Token(Token = "0x4005092")]
	[FieldOffset(Offset = "0x14")]
	public float m_RangeBoostMinHeight;

	[Token(Token = "0x4005093")]
	[FieldOffset(Offset = "0x18")]
	public float m_RangeBoostMaxHeight;

	[Token(Token = "0x4005094")]
	[FieldOffset(Offset = "0x1C")]
	public float m_RangeBoostAmount;

	[Token(Token = "0x6004679")]
	[Address(RVA = "0xCA7240", Offset = "0xCA6040", Length = "0x5B")]
	public float GetRangeBoostFromHeightDelta(float heightDelta)
	{
		return 0f;
	}
}
