using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A55")]
public class BoundingSphereFromPoints
{
	[Token(Token = "0x4006743")]
	public static float m_Radius;

	[Token(Token = "0x4006744")]
	public static Vector3 m_Center;

	[Token(Token = "0x4006745")]
	private static float m_RadiusEpsilon;

	[Token(Token = "0x6005A8D")]
	[Address(RVA = "0xF192E0", Offset = "0xF180E0", Length = "0x536")]
	public static void Calculate(Vector3[] points, int length, int supportCount, int index)
	{
	}

	[Token(Token = "0x6005A8E")]
	[Address(RVA = "0xF19820", Offset = "0xF18620", Length = "0x1D9")]
	private static void SetSphere(Vector3 O, Vector3 A)
	{
	}

	[Token(Token = "0x6005A8F")]
	[Address(RVA = "0xF19A00", Offset = "0xF18800", Length = "0x34E")]
	private static void SetSphere(Vector3 O, Vector3 A, Vector3 B)
	{
	}

	[Token(Token = "0x6005A90")]
	[Address(RVA = "0xF19D50", Offset = "0xF18B50", Length = "0x3ED")]
	private static void SetSphere(Vector3 O, Vector3 A, Vector3 B, Vector3 C)
	{
	}

	[Token(Token = "0x6005A91")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BoundingSphereFromPoints()
	{
	}
}
