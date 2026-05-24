using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A18")]
public class MainCameraFrustrum
{
	[Token(Token = "0x4006624")]
	public static Plane[] m_CapturePlanes;

	[Token(Token = "0x600587D")]
	[Address(RVA = "0xEEA580", Offset = "0xEE9380", Length = "0x969")]
	public static void RecalculateFrustumPlanes(Camera c)
	{
	}

	[Token(Token = "0x600587E")]
	[Address(RVA = "0xEEAEF0", Offset = "0xEE9CF0", Length = "0xAFD")]
	public static void RecalculateFrustumPlanes(Camera c, ref Plane[] planes, float expandFovPercent = 0f)
	{
	}

	[Token(Token = "0x600587F")]
	[Address(RVA = "0xEEB9F0", Offset = "0xEEA7F0", Length = "0x9BF")]
	public static void RecalculateFrustumCorners(Camera c, ref Vector3[] corners, float expandFovPercent = 0f)
	{
	}

	[Token(Token = "0x6005880")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MainCameraFrustrum()
	{
	}
}
