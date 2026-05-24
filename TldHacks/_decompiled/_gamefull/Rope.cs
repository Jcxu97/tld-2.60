using Cpp2ILInjected;
using SuperSplines;
using UnityEngine;

[Token(Token = "0x20005AA")]
public class Rope : MonoBehaviour
{
	[Header("Rope Parameters")]
	[Token(Token = "0x400346B")]
	[FieldOffset(Offset = "0x20")]
	public Spline m_Spline;

	[Range(0f, 25f)]
	[Token(Token = "0x400346C")]
	[FieldOffset(Offset = "0x28")]
	public float m_UnusedLengthAtTop;

	[Range(0f, 25f)]
	[Token(Token = "0x400346D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_UnusedLengthAtBottom;

	[Range(0f, 25f)]
	[Token(Token = "0x400346E")]
	[FieldOffset(Offset = "0x30")]
	public float m_TopDistanceToEdge;

	[Header("Rope Break")]
	[Range(0f, 1f)]
	[Token(Token = "0x400346F")]
	[FieldOffset(Offset = "0x34")]
	public float m_BreakRopeThreshold;

	[Range(0f, 100f)]
	[Token(Token = "0x4003470")]
	[FieldOffset(Offset = "0x38")]
	public float m_BreakRopePlayerDamagePercent;

	[Header("Time Lapse")]
	[Token(Token = "0x4003471")]
	[FieldOffset(Offset = "0x3C")]
	public float m_DeployDurationMinutes;

	[Token(Token = "0x4003472")]
	[FieldOffset(Offset = "0x40")]
	public float m_RetreiveDurationMinutes;

	[Token(Token = "0x4003473")]
	[FieldOffset(Offset = "0x44")]
	private float m_SplineParameter;

	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x9291D0", Offset = "0x927FD0", Length = "0x15C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x929330", Offset = "0x928130", Length = "0x19E")]
	private void Start()
	{
	}

	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Rope()
	{
	}
}
