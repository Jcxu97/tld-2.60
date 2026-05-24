using Cpp2ILInjected;
using UnityEngine;

namespace TLD.WeatherParticle;

[Token(Token = "0x2001350")]
public struct ParticleSystemVars
{
	[Token(Token = "0x4008E4B")]
	[FieldOffset(Offset = "0x0")]
	public bool m_EmitEnabled;

	[Token(Token = "0x4008E4C")]
	[FieldOffset(Offset = "0x4")]
	public float m_EnforceLifetimeLimit;

	[Token(Token = "0x4008E4D")]
	[FieldOffset(Offset = "0x8")]
	public float m_TurbulenceScalar;

	[Token(Token = "0x4008E4E")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 m_WindVecCopy;

	[Token(Token = "0x4008E4F")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4008E50")]
	[FieldOffset(Offset = "0x24")]
	public float m_TransverseScalar;

	[Token(Token = "0x4008E51")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_HeightTestOffset;

	[Token(Token = "0x4008E52")]
	[FieldOffset(Offset = "0x34")]
	public float m_NoiseScaleByWind;

	[Token(Token = "0x4008E53")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 m_Fragment1;

	[Token(Token = "0x4008E54")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 m_Wind56;

	[Token(Token = "0x4008E55")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 m_Wind44;

	[Token(Token = "0x4008E56")]
	[FieldOffset(Offset = "0x5C")]
	public float m_GustScalar;

	[Token(Token = "0x4008E57")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 m_NoiseOffset1;

	[Token(Token = "0x4008E58")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 m_NoiseOffset2;

	[Token(Token = "0x4008E59")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 m_WindBase;
}
