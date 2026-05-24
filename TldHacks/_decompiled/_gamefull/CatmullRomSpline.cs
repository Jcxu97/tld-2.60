using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A56")]
public class CatmullRomSpline
{
	[Token(Token = "0x4006746")]
	[FieldOffset(Offset = "0x10")]
	public Vector3[] m_Waypoints;

	[Token(Token = "0x4006747")]
	[FieldOffset(Offset = "0x18")]
	private Vector3[] cps;

	[Token(Token = "0x170003AF")]
	private float MaxT
	{
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0xF1A180", Offset = "0xF18F80", Length = "0x1F")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6005A94")]
	[Address(RVA = "0xF1A1A0", Offset = "0xF18FA0", Length = "0xF9")]
	public CatmullRomSpline(Vector3[] waypoints)
	{
	}

	[Token(Token = "0x6005A95")]
	[Address(RVA = "0xF1A2A0", Offset = "0xF190A0", Length = "0x51")]
	public Vector3 Evaluate(float t, bool isLooping)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005A96")]
	[Address(RVA = "0xF1A300", Offset = "0xF19100", Length = "0x51")]
	public Vector3 EvaluateTangent(float t, bool isLooping)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005A97")]
	[Address(RVA = "0xF1A360", Offset = "0xF19160", Length = "0x84")]
	public Vector3 EvaluateWithTangent(float t, bool isLooping, out Vector3 tangent)
	{
		tangent = default(Vector3);
		return default(Vector3);
	}

	[Token(Token = "0x6005A98")]
	[Address(RVA = "0xF1A3F0", Offset = "0xF191F0", Length = "0x353")]
	public float SelectCps(float t, bool isLooping)
	{
		return 0f;
	}

	[Token(Token = "0x6005A99")]
	[Address(RVA = "0xF1A750", Offset = "0xF19550", Length = "0x241")]
	private Vector3 CalcPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005A9A")]
	[Address(RVA = "0xF1A9A0", Offset = "0xF197A0", Length = "0x3AE")]
	private Vector3 CalcTangent(float t)
	{
		return default(Vector3);
	}
}
