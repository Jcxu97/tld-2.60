using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000165")]
public class DamageRegion : IComparable
{
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x10")]
	public BodyPart m_bodyPart;

	[Range(0f, 10f)]
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x14")]
	public float m_DamageScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x18")]
	public float m_DamageScaleForRevolver;

	[Range(0f, 10f)]
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x1C")]
	public float m_DamageScaleForHardenedArrow;

	[Range(0f, 480f)]
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x20")]
	public int m_BleedOutMinutes;

	[Range(0f, 480f)]
	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x24")]
	public int m_BleedOutMinutesForArrow;

	[Range(0f, 480f)]
	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x28")]
	public int m_BleedOutMinutesForFlareGunRound;

	[Range(0f, 480f)]
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x2C")]
	public int m_BleedOutMinutesForRevolver;

	[Range(0f, 100f)]
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x30")]
	public int m_ChanceKill;

	[Range(0f, 100f)]
	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x34")]
	public int m_ChanceKillForRevolver;

	[Range(0f, 100f)]
	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0x38")]
	public int m_ChanceKillForHardenedArrow;

	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_DoNotBleedOut;

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x5E21F0", Offset = "0x5E0FF0", Length = "0x105")]
	public int CompareTo(object obj)
	{
		return 0;
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DamageRegion()
	{
	}
}
