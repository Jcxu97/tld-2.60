using System;
using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BED")]
public static class Utils
{
	[Token(Token = "0x2000BEE")]
	public enum FloatPackingPrecision
	{
		[Token(Token = "0x40079A4")]
		High = 64,
		[Token(Token = "0x40079A5")]
		Low = 8,
		[Token(Token = "0x40079A6")]
		Undef = 0
	}

	[Token(Token = "0x40079A1")]
	private static FloatPackingPrecision ms_FloatPackingPrecision;

	[Token(Token = "0x40079A2")]
	private const int kFloatPackingHighMinShaderLevel = 35;

	[Token(Token = "0x6005DD2")]
	[Address(RVA = "0xF6C170", Offset = "0xF6AF70", Length = "0x32")]
	public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
	{
		return 0f;
	}

	[Token(Token = "0x6005DD3")]
	[Address(RVA = "0x1A4CDD0", Offset = "0x1A4BBD0", Length = "0xD")]
	public static void Swap<T>(ref T a, ref T b)
	{
	}

	[Token(Token = "0x6005DD4")]
	[Address(RVA = "0xF6C1B0", Offset = "0xF6AFB0", Length = "0x14E")]
	public static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x6005DD5")]
	[Address(RVA = "0x1A4CC90", Offset = "0x1A4BA90", Length = "0x13B")]
	public static T NewWithComponent<T>(string name) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6005DD6")]
	[Address(RVA = "0x1957B80", Offset = "0x1956980", Length = "0x10F")]
	public static T GetOrAddComponent<T>(this GameObject self) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6005DD7")]
	[Address(RVA = "0x1A4CC40", Offset = "0x1A4BA40", Length = "0x4C")]
	public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6005DD8")]
	[Address(RVA = "0xF6C300", Offset = "0xF6B100", Length = "0x59")]
	public static bool HasFlag(this Enum mask, Enum flags)
	{
		return false;
	}

	[Token(Token = "0x6005DD9")]
	[Address(RVA = "0xF6C360", Offset = "0xF6B160", Length = "0x12")]
	public static Vector2 xy(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005DDA")]
	[Address(RVA = "0xF6C380", Offset = "0xF6B180", Length = "0x12")]
	public static Vector2 xz(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005DDB")]
	[Address(RVA = "0xF6C3A0", Offset = "0xF6B1A0", Length = "0x13")]
	public static Vector2 yz(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005DDC")]
	[Address(RVA = "0xF6C3C0", Offset = "0xF6B1C0", Length = "0x12")]
	public static Vector2 yx(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005DDD")]
	[Address(RVA = "0xF6C3E0", Offset = "0xF6B1E0", Length = "0x12")]
	public static Vector2 zx(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005DDE")]
	[Address(RVA = "0xF6C400", Offset = "0xF6B200", Length = "0x13")]
	public static Vector2 zy(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005DDF")]
	[Address(RVA = "0xF6C420", Offset = "0xF6B220", Length = "0x3B")]
	public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
	{
		return false;
	}

	[Token(Token = "0x6005DE0")]
	[Address(RVA = "0xF6C460", Offset = "0xF6B260", Length = "0x5C")]
	public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
	{
		return false;
	}

	[Token(Token = "0x6005DE1")]
	[Address(RVA = "0xF6C4C0", Offset = "0xF6B2C0", Length = "0x73")]
	public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
	{
		return false;
	}

	[Token(Token = "0x6005DE2")]
	[Address(RVA = "0xF6C540", Offset = "0xF6B340", Length = "0x19")]
	public static Vector4 AsVector4(this Vector3 vec3, float w)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6005DE3")]
	[Address(RVA = "0xF6C560", Offset = "0xF6B360", Length = "0x92")]
	public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6005DE4")]
	[Address(RVA = "0xF6C600", Offset = "0xF6B400", Length = "0x4B")]
	public static float GetVolumeCubic(this Bounds self)
	{
		return 0f;
	}

	[Token(Token = "0x6005DE5")]
	[Address(RVA = "0xF6C650", Offset = "0xF6B450", Length = "0x96")]
	public static float GetMaxArea2D(this Bounds self)
	{
		return 0f;
	}

	[Token(Token = "0x6005DE6")]
	[Address(RVA = "0xF6C6F0", Offset = "0xF6B4F0", Length = "0x1B")]
	public static Color Opaque(this Color self)
	{
		return default(Color);
	}

	[Token(Token = "0x6005DE7")]
	[Address(RVA = "0xF6C710", Offset = "0xF6B510", Length = "0xB4")]
	public static Plane TranslateCustom(this Plane plane, Vector3 translation)
	{
		return default(Plane);
	}

	[Token(Token = "0x6005DE8")]
	[Address(RVA = "0xF6C7D0", Offset = "0xF6B5D0", Length = "0xAF")]
	public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005DE9")]
	[Address(RVA = "0xF6C880", Offset = "0xF6B680", Length = "0x16")]
	public static bool IsAlmostZero(float f)
	{
		return false;
	}

	[Token(Token = "0x6005DEA")]
	[Address(RVA = "0xF6C8A0", Offset = "0xF6B6A0", Length = "0x49")]
	public static bool IsValid(this Plane plane)
	{
		return false;
	}

	[Token(Token = "0x6005DEB")]
	[Address(RVA = "0xF6C8F0", Offset = "0xF6B6F0", Length = "0x2B")]
	public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
	{
	}

	[Token(Token = "0x6005DEC")]
	[Address(RVA = "0xF6C920", Offset = "0xF6B720", Length = "0x12")]
	public static void SetShaderKeywordEnabled(string name, bool enabled)
	{
	}

	[Token(Token = "0x6005DED")]
	[Address(RVA = "0xF6C940", Offset = "0xF6B740", Length = "0x209")]
	public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6005DEE")]
	[Address(RVA = "0xF6CB50", Offset = "0xF6B950", Length = "0x18C")]
	public static Color[] SampleInArray(this Gradient self, int samplesCount)
	{
		return null;
	}

	[Token(Token = "0x6005DEF")]
	[Address(RVA = "0xF6CCE0", Offset = "0xF6BAE0", Length = "0x58")]
	private static Vector4 Vector4_Floor(Vector4 vec)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6005DF0")]
	[Address(RVA = "0xF6CD40", Offset = "0xF6BB40", Length = "0xDA")]
	public static float PackToFloat(this Color color, int floatPackingPrecision)
	{
		return 0f;
	}

	[Token(Token = "0x6005DF1")]
	[Address(RVA = "0xF6CE20", Offset = "0xF6BC20", Length = "0xA9")]
	public static FloatPackingPrecision GetFloatPackingPrecision()
	{
		return default(FloatPackingPrecision);
	}

	[Token(Token = "0x6005DF2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void MarkCurrentSceneDirty()
	{
	}

	[Token(Token = "0x6005DF3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void MarkObjectDirty(UnityEngine.Object obj)
	{
	}
}
