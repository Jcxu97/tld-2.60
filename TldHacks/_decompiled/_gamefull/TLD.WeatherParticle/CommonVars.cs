using Cpp2ILInjected;
using UnityEngine;

namespace TLD.WeatherParticle;

[Token(Token = "0x200134F")]
public struct CommonVars
{
	[Token(Token = "0x4008E3F")]
	[FieldOffset(Offset = "0x0")]
	public Matrix4x4 m_CameraMat;

	[Token(Token = "0x4008E40")]
	[FieldOffset(Offset = "0x40")]
	public Matrix4x4 m_CameraInvMat;

	[Token(Token = "0x4008E41")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 m_CamPos;

	[Token(Token = "0x4008E42")]
	[FieldOffset(Offset = "0x8C")]
	public Bounds m_CameraBounds;

	[Token(Token = "0x4008E43")]
	[FieldOffset(Offset = "0xA4")]
	public Bounds m_CameraBoundsNear;

	[Token(Token = "0x4008E44")]
	[FieldOffset(Offset = "0xBC")]
	public float m_WindStrength;

	[Token(Token = "0x4008E45")]
	[FieldOffset(Offset = "0xC0")]
	public Vector3 m_SineScalar;

	[Token(Token = "0x4008E46")]
	[FieldOffset(Offset = "0xCC")]
	public Vector3 m_WindVec;

	[Token(Token = "0x4008E47")]
	[FieldOffset(Offset = "0xD8")]
	public Vector3 m_WindTransverseVec;

	[Token(Token = "0x4008E48")]
	[FieldOffset(Offset = "0xE4")]
	public float m_TurbulenceTimer;

	[Token(Token = "0x4008E49")]
	[FieldOffset(Offset = "0xE8")]
	public float m_GustScalar;

	[Token(Token = "0x4008E4A")]
	[FieldOffset(Offset = "0xEC")]
	public float m_Time;
}
