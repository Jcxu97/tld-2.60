using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion;

[Token(Token = "0x2000D67")]
public static class CurveUtils
{
	[Token(Token = "0x40083CB")]
	private const float POS_CHECK_RES = 100f;

	[Token(Token = "0x40083CC")]
	private const float POS_CHECK_DISTANCE = 10f;

	[Token(Token = "0x60068A5")]
	[Address(RVA = "0x106B750", Offset = "0x106A550", Length = "0x137")]
	public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60068A6")]
	[Address(RVA = "0x106B890", Offset = "0x106A690", Length = "0x39")]
	public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition)
	{
		return false;
	}

	[Token(Token = "0x60068A7")]
	[Address(RVA = "0x106B8D0", Offset = "0x106A6D0", Length = "0x371")]
	public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm)
	{
		norm = default(float);
		return false;
	}

	[Token(Token = "0x60068A8")]
	[Address(RVA = "0x106BC50", Offset = "0x106AA50", Length = "0xD1")]
	public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
	{
		fromTangent = default(Vector2);
		toTangent = default(Vector2);
	}

	[Token(Token = "0x60068A9")]
	[Address(RVA = "0x106BD30", Offset = "0x106AB30", Length = "0x21A")]
	public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
	{
		fromTangent = default(Vector2);
		toTangent = default(Vector2);
	}
}
