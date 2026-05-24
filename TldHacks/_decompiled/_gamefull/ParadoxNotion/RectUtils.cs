using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion;

[Token(Token = "0x2000D69")]
public static class RectUtils
{
	[Token(Token = "0x60068B0")]
	[Address(RVA = "0x106C2B0", Offset = "0x106B0B0", Length = "0xCB")]
	public static Rect GetBoundRect(params Rect[] rects)
	{
		return default(Rect);
	}

	[Token(Token = "0x60068B1")]
	[Address(RVA = "0x106C380", Offset = "0x106B180", Length = "0xAC")]
	public static Rect GetBoundRect(params Vector2[] positions)
	{
		return default(Rect);
	}

	[Token(Token = "0x60068B2")]
	[Address(RVA = "0x106C430", Offset = "0x106B230", Length = "0x41")]
	public static bool Encapsulates(this Rect a, Rect b)
	{
		return false;
	}

	[Token(Token = "0x60068B3")]
	[Address(RVA = "0x106C480", Offset = "0x106B280", Length = "0x66")]
	public static Rect ExpandBy(this Rect rect, float margin)
	{
		return default(Rect);
	}

	[Token(Token = "0x60068B4")]
	[Address(RVA = "0x106C4F0", Offset = "0x106B2F0", Length = "0x73")]
	public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin)
	{
		return default(Rect);
	}

	[Token(Token = "0x60068B5")]
	[Address(RVA = "0x106C570", Offset = "0x106B370", Length = "0x60")]
	public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom)
	{
		return default(Rect);
	}

	[Token(Token = "0x60068B6")]
	[Address(RVA = "0x106C5D0", Offset = "0x106B3D0", Length = "0x1CE")]
	public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer)
	{
		return default(Rect);
	}

	[Token(Token = "0x60068B7")]
	[Address(RVA = "0x106C7A0", Offset = "0x106B5A0", Length = "0xF8")]
	public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer)
	{
		return default(Vector2);
	}
}
