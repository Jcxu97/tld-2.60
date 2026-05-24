using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000756")]
public struct HeightFogSettings
{
	[Token(Token = "0x4004E48")]
	[FieldOffset(Offset = "0x0")]
	public float m_AmbientLightImpact;

	[Token(Token = "0x4004E49")]
	[FieldOffset(Offset = "0x4")]
	public float m_PlayerLightColorImpact;

	[Token(Token = "0x4004E4A")]
	[FieldOffset(Offset = "0x8")]
	public float m_PlayerLightIntensityImpact;

	[Token(Token = "0x4004E4B")]
	[FieldOffset(Offset = "0xC")]
	public Color m_FogColor;

	[Token(Token = "0x4004E4C")]
	[FieldOffset(Offset = "0x1C")]
	public float m_FogDensity;

	[Token(Token = "0x4004E4D")]
	[FieldOffset(Offset = "0x20")]
	public float m_FogPower;

	[Token(Token = "0x4004E4E")]
	[FieldOffset(Offset = "0x24")]
	public float m_FogDistanceStart;

	[Token(Token = "0x4004E4F")]
	[FieldOffset(Offset = "0x28")]
	public float m_FogDistanceEnd;

	[Token(Token = "0x4004E50")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FogDistanceFalloff;

	[Token(Token = "0x4004E51")]
	[FieldOffset(Offset = "0x30")]
	public float m_FogHeightStart;

	[Token(Token = "0x4004E52")]
	[FieldOffset(Offset = "0x34")]
	public float m_FogHeightEnd;

	[Token(Token = "0x4004E53")]
	[FieldOffset(Offset = "0x38")]
	public float m_FogHeightFalloff;

	[Token(Token = "0x4004E54")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NoiseStrength;

	[Token(Token = "0x4004E55")]
	[FieldOffset(Offset = "0x40")]
	public float m_NoiseScale;

	[Token(Token = "0x4004E56")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 m_NoiseSpeed;

	[Token(Token = "0x6004387")]
	[Address(RVA = "0xC58B80", Offset = "0xC57980", Length = "0xB9")]
	public bool IsFogVisible()
	{
		return false;
	}

	[Token(Token = "0x6004388")]
	[Address(RVA = "0xC58C40", Offset = "0xC57A40", Length = "0x96")]
	public void Clear()
	{
	}

	[Token(Token = "0x6004389")]
	[Address(RVA = "0xC58CE0", Offset = "0xC57AE0", Length = "0x3E7")]
	public void Blend(HeightFogSettings other, float blendAmount)
	{
	}

	[Token(Token = "0x600438A")]
	[Address(RVA = "0xC590D0", Offset = "0xC57ED0", Length = "0x24B")]
	public void ApplyLightSources()
	{
	}
}
