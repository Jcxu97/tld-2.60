using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000017")]
public class vp_SmoothRandom
{
	[Token(Token = "0x40001E5")]
	private static vp_FractalNoise s_Noise;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x575D50", Offset = "0x574B50", Length = "0xF8")]
	public static Vector3 GetVector3Slow(float time, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x575E50", Offset = "0x574C50", Length = "0x1DF")]
	public static Vector3 GetVector3CenteredSlow(float time, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x576030", Offset = "0x574E30", Length = "0x6C")]
	public static float GetSlow(float time, float speed)
	{
		return 0f;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x5760A0", Offset = "0x574EA0", Length = "0x109")]
	private static vp_FractalNoise Get()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public vp_SmoothRandom()
	{
	}
}
