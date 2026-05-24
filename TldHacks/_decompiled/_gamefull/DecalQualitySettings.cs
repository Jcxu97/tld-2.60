using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000729")]
public class DecalQualitySettings
{
	[Tooltip("Distance that decals begin fading out")]
	[Range(0f, 120f)]
	[Token(Token = "0x4004BD7")]
	[FieldOffset(Offset = "0x10")]
	public float m_FadeDistance;

	[Tooltip("Distance that decals stop rendering. Set to 0 to disable decals altogether")]
	[Range(0f, 120f)]
	[Token(Token = "0x4004BD8")]
	[FieldOffset(Offset = "0x14")]
	public float m_VisibleDistance;

	[Tooltip("Screen size in pixels at 1080p that decals begin fading out")]
	[Range(0f, 120f)]
	[Token(Token = "0x4004BD9")]
	[FieldOffset(Offset = "0x18")]
	public float m_FadeScreenSize;

	[Tooltip("Screen size in pixels at 1080p that decals stop rendering. Set to 0 to disable decals altogether")]
	[Range(0f, 120f)]
	[Token(Token = "0x4004BDA")]
	[FieldOffset(Offset = "0x1C")]
	public float m_VisibleScreenSize;

	[Token(Token = "0x60040B8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DecalQualitySettings()
	{
	}
}
