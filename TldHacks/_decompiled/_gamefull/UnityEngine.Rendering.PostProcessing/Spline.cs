using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CFF")]
public sealed class Spline
{
	[Token(Token = "0x40080FB")]
	public const int k_Precision = 128;

	[Token(Token = "0x40080FC")]
	public const float k_Step = 1f / 128f;

	[Token(Token = "0x40080FD")]
	[FieldOffset(Offset = "0x10")]
	public AnimationCurve curve;

	[SerializeField]
	[Token(Token = "0x40080FE")]
	[FieldOffset(Offset = "0x18")]
	private bool m_Loop;

	[SerializeField]
	[Token(Token = "0x40080FF")]
	[FieldOffset(Offset = "0x1C")]
	private float m_ZeroValue;

	[SerializeField]
	[Token(Token = "0x4008100")]
	[FieldOffset(Offset = "0x20")]
	private float m_Range;

	[Token(Token = "0x4008101")]
	[FieldOffset(Offset = "0x28")]
	private AnimationCurve m_InternalLoopingCurve;

	[Token(Token = "0x4008102")]
	[FieldOffset(Offset = "0x30")]
	private int frameCount;

	[Token(Token = "0x4008103")]
	[FieldOffset(Offset = "0x38")]
	public float[] cachedData;

	[Token(Token = "0x60066E3")]
	[Address(RVA = "0x10337E0", Offset = "0x10325E0", Length = "0x120")]
	public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
	{
	}

	[Token(Token = "0x60066E4")]
	[Address(RVA = "0x1033900", Offset = "0x1032700", Length = "0x417")]
	public void Cache(int frame)
	{
	}

	[Token(Token = "0x60066E5")]
	[Address(RVA = "0x1033D20", Offset = "0x1032B20", Length = "0xC0")]
	public float Evaluate(float t, int length)
	{
		return 0f;
	}

	[Token(Token = "0x60066E6")]
	[Address(RVA = "0x1033DF0", Offset = "0x1032BF0", Length = "0x95")]
	public float Evaluate(float t)
	{
		return 0f;
	}

	[Token(Token = "0x60066E7")]
	[Address(RVA = "0x1033E90", Offset = "0x1032C90", Length = "0x2F")]
	public override int GetHashCode()
	{
		return 0;
	}
}
