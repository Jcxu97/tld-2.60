using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x200039B")]
public class SnowImprintDef
{
	[Token(Token = "0x4002041")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4002042")]
	[FieldOffset(Offset = "0x18")]
	public int m_MaxFootstepGroupsPerTrail;

	[Token(Token = "0x4002043")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 m_GroupMaxBoundsSize;

	[Token(Token = "0x4002044")]
	[FieldOffset(Offset = "0x28")]
	public float m_ImprintBoundsSize;

	[Token(Token = "0x4002045")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 m_StandardDepthRange;

	[Token(Token = "0x4002046")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 m_DeepDepthRange;

	[Range(0f, 10f)]
	[Token(Token = "0x4002047")]
	[FieldOffset(Offset = "0x3C")]
	public float m_EndFadeRadius;

	[Token(Token = "0x4002048")]
	[FieldOffset(Offset = "0x40")]
	public bool m_ChooseVariantByDepth;

	[Token(Token = "0x4002049")]
	[FieldOffset(Offset = "0x48")]
	public SnowImprintQualitySettings m_LowQualitySettings;

	[Token(Token = "0x400204A")]
	[FieldOffset(Offset = "0x50")]
	public SnowImprintQualitySettings m_MediumQualitySettings;

	[Token(Token = "0x400204B")]
	[FieldOffset(Offset = "0x58")]
	public SnowImprintQualitySettings m_HighQualitySettings;

	[Token(Token = "0x400204C")]
	[FieldOffset(Offset = "0x60")]
	public SnowImprintQualitySettings m_UltraQualitySettings;

	[Token(Token = "0x400204D")]
	[FieldOffset(Offset = "0x68")]
	public SnowImprintQualitySettings m_XboxQualitySettings;

	[Token(Token = "0x400204E")]
	[FieldOffset(Offset = "0x70")]
	public SnowImprintQualitySettings m_PS4QualitySettings;

	[Token(Token = "0x400204F")]
	[FieldOffset(Offset = "0x78")]
	public SnowImprintVariant[] m_ImprintVariants;

	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SnowImprintDef()
	{
	}
}
