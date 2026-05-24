using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.WeatherParticle;

[Serializable]
[Token(Token = "0x2001352")]
public struct WeatherParticleManagerConfiguration
{
	[Token(Token = "0x4008E5F")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 m_SnowBoxDimensions;

	[Token(Token = "0x4008E60")]
	[FieldOffset(Offset = "0xC")]
	public float m_SnowBoxNearThreshold;

	[Token(Token = "0x4008E61")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_SnowBoxBias;

	[Token(Token = "0x4008E62")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_CalcBoxXY;

	[Token(Token = "0x4008E63")]
	[FieldOffset(Offset = "0x1D")]
	public bool m_EnableTurbulence;

	[Token(Token = "0x4008E64")]
	[FieldOffset(Offset = "0x1E")]
	public bool m_EnableTerrainHeightTests;

	[Token(Token = "0x4008E65")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 m_WindTurbulenceInputScalars;

	[Token(Token = "0x4008E66")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_WindTurbulenceOutputScalars;

	[Token(Token = "0x4008E67")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_WindTurbulenceSineScalarsMin;

	[Token(Token = "0x4008E68")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_WindTurbulenceSineScalarsMax;

	[Token(Token = "0x4008E69")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 m_WindTurbulenceGustScalar;

	[Token(Token = "0x4008E6A")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 m_WindTurbulenceGustOffsets;

	[Token(Token = "0x4008E6B")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 m_WindTransverseScalars;

	[Token(Token = "0x4008E6C")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 m_NoiseWindSpeeds;

	[Token(Token = "0x4008E6D")]
	[FieldOffset(Offset = "0x6C")]
	public Vector4 m_NoiseScalars;

	[Token(Token = "0x4008E6E")]
	[FieldOffset(Offset = "0x7C")]
	public Vector2 m_GrassPhaseConstantStepScalars;

	[Token(Token = "0x4008E6F")]
	[FieldOffset(Offset = "0x84")]
	public Vector2 m_GrassPhaseNoiseStepScalars;

	[Token(Token = "0x4008E70")]
	[FieldOffset(Offset = "0x8C")]
	public float m_BranchPhaseFrequencyScalar;

	[NonSerialized]
	[Token(Token = "0x4008E71")]
	[FieldOffset(Offset = "0x90")]
	public bool m_UseNoise;
}
