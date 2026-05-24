using Cpp2ILInjected;
using UnityEngine;

namespace TLD.WeatherParticle;

[Token(Token = "0x2001351")]
public struct ParticleCollisionHeightMapInfo
{
	[Token(Token = "0x4008E5A")]
	[FieldOffset(Offset = "0x0")]
	public Bounds m_Bounds;

	[Token(Token = "0x4008E5B")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_ActiveMinBounds;

	[Token(Token = "0x4008E5C")]
	[FieldOffset(Offset = "0x24")]
	public float m_SpacingScalar;

	[Token(Token = "0x4008E5D")]
	[FieldOffset(Offset = "0x28")]
	public int m_Stride;

	[Token(Token = "0x4008E5E")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 m_MinBounds;
}
