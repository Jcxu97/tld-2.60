using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D2D")]
public static class SplineUtils
{
	[Token(Token = "0x400823E")]
	private static List<Vector2> segmentRanges;

	[Token(Token = "0x60067B1")]
	[Address(RVA = "0x10509F0", Offset = "0x104F7F0", Length = "0x637")]
	public static List<SplineStamp.SplinePoint> GetSplinePoints(List<SplineStamp.SplinePoint> points, bool closed, float maxDistanceBetweenPoints = 1f, int maxPoints = 1000)
	{
		return null;
	}

	[Token(Token = "0x60067B2")]
	[Address(RVA = "0x1051030", Offset = "0x104FE30", Length = "0x13D")]
	public static Vector3[] GetPoints(List<SplineStamp.SplinePoint> points, bool closed, float maxDistanceBetweenPoints = 1f, int maxPoints = 1000)
	{
		return null;
	}

	[Token(Token = "0x60067B3")]
	[Address(RVA = "0x1051170", Offset = "0x104FF70", Length = "0xBA2")]
	public static SplineStamp.SplinePoint GetSplinePoint(List<SplineStamp.SplinePoint> points, bool closed, float f)
	{
		return default(SplineStamp.SplinePoint);
	}

	[Token(Token = "0x60067B4")]
	[Address(RVA = "0x1051D20", Offset = "0x1050B20", Length = "0x9A")]
	public static Vector3 GetPoint(List<SplineStamp.SplinePoint> points, bool closed, float f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60067B5")]
	[Address(RVA = "0x1051DC0", Offset = "0x1050BC0", Length = "0x448")]
	public static Vector3 GetForward(List<SplineStamp.SplinePoint> points, bool closed, float f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60067B6")]
	[Address(RVA = "0x1052210", Offset = "0x1051010", Length = "0x577")]
	public static void GetSides(List<SplineStamp.SplinePoint> points, float width, bool closed, Vector3 up, out List<Vector3> leftRail, out List<Vector3> rightRail)
	{
		leftRail = null;
		rightRail = null;
	}

	[Token(Token = "0x60067B7")]
	[Address(RVA = "0x1052790", Offset = "0x1051590", Length = "0x30D")]
	public static float GetLength(List<SplineStamp.SplinePoint> points, bool closed)
	{
		return 0f;
	}

	[Token(Token = "0x60067B8")]
	[Address(RVA = "0x1052AA0", Offset = "0x10518A0", Length = "0x402")]
	public static string ToCSV(List<SplineStamp.SplinePoint> points, string positionXFieldName = "x", string positionYFieldName = "y", string positionZFieldName = "z", string scaleFieldName = "s", char lineSeperator = '\n', char itemSeperator = ',')
	{
		return null;
	}

	[Token(Token = "0x60067B9")]
	[Address(RVA = "0x1052EB0", Offset = "0x1051CB0", Length = "0x79A")]
	public static List<SplineStamp.SplinePoint> FromCSV(string text, string positionXFieldName = "x", string positionYFieldName = "y", string positionZFieldName = "z", string scaleFieldName = "s", char lineSeperator = '\n', char itemSeperator = ',')
	{
		return null;
	}

	[Token(Token = "0x60067BA")]
	[Address(RVA = "0x1053650", Offset = "0x1052450", Length = "0x40D")]
	private static Vector3 GetSplineForward(List<SplineStamp.SplinePoint> points, int index, bool closed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60067BB")]
	[Address(RVA = "0x1053A60", Offset = "0x1052860", Length = "0x2D0")]
	private static Vector3 LerpBezier(Vector3 p0, Vector3 f0, Vector3 f1, Vector3 p1, float f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60067BC")]
	[Address(RVA = "0x4FD580", Offset = "0x4FC380", Length = "0x82")]
	private static float LerpBezierScale(float s0, float s1, float f)
	{
		return 0f;
	}
}
