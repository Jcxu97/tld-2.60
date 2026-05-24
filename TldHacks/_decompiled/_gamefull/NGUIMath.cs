using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B5")]
public static class NGUIMath
{
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600061A")]
	[Address(RVA = "0xDEC160", Offset = "0xDEAF60", Length = "0x1C")]
	public static float Lerp(float from, float to, float factor)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600061B")]
	[Address(RVA = "0xDEC180", Offset = "0xDEAF80", Length = "0x11")]
	public static int ClampIndex(int val, int max)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600061C")]
	[Address(RVA = "0xDEC1A0", Offset = "0xDEAFA0", Length = "0x24")]
	public static int RepeatIndex(int val, int max)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600061D")]
	[Address(RVA = "0xDEC1D0", Offset = "0xDEAFD0", Length = "0x3D")]
	public static float WrapAngle(float angle)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600061E")]
	[Address(RVA = "0xDEC210", Offset = "0xDEB010", Length = "0x29")]
	public static float Wrap01(float val)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600061F")]
	[Address(RVA = "0xDEC240", Offset = "0xDEB040", Length = "0x18")]
	public static int HexToDecimal(char ch)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000620")]
	[Address(RVA = "0xDEC350", Offset = "0xDEB150", Length = "0x18")]
	public static char DecimalToHexChar(int num)
	{
		return '\0';
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000621")]
	[Address(RVA = "0xDEC370", Offset = "0xDEB170", Length = "0xE2")]
	public static string DecimalToHex8(int num)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000622")]
	[Address(RVA = "0xDEC460", Offset = "0xDEB260", Length = "0xE5")]
	public static string DecimalToHex24(int num)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000623")]
	[Address(RVA = "0xDEC550", Offset = "0xDEB350", Length = "0xDF")]
	public static string DecimalToHex32(int num)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000624")]
	[Address(RVA = "0xDEC630", Offset = "0xDEB430", Length = "0x182")]
	public static int ColorToInt(Color c)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000625")]
	[Address(RVA = "0xDEC7C0", Offset = "0xDEB5C0", Length = "0x68")]
	public static Color IntToColor(int val)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000626")]
	[Address(RVA = "0xDEC830", Offset = "0xDEB630", Length = "0x11C")]
	public static string IntToBinary(int val, int bits)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000627")]
	[Address(RVA = "0xDEC950", Offset = "0xDEB750", Length = "0x7A")]
	public static Color HexToColor(uint val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0xDEC9D0", Offset = "0xDEB7D0", Length = "0x82")]
	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0xDECA60", Offset = "0xDEB860", Length = "0x296")]
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		return default(Rect);
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0xDECD00", Offset = "0xDEBB00", Length = "0x1C7")]
	public static Rect MakePixelPerfect(Rect rect)
	{
		return default(Rect);
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0xDECED0", Offset = "0xDEBCD0", Length = "0x2AE")]
	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		return default(Rect);
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0xDED180", Offset = "0xDEBF80", Length = "0x15F")]
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0xDED2E0", Offset = "0xDEC0E0", Length = "0x691")]
	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0xDED980", Offset = "0xDEC780", Length = "0x40")]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0xDED9C0", Offset = "0xDEC7C0", Length = "0x41")]
	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0xDEDA10", Offset = "0xDEC810", Length = "0x3D")]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0xDEDA50", Offset = "0xDEC850", Length = "0x488")]
	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerParents = true)
	{
		return default(Bounds);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000632")]
	[Address(RVA = "0xDEDEE0", Offset = "0xDECCE0", Length = "0x929")]
	private static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerParents)
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0xDEE810", Offset = "0xDED610", Length = "0x176")]
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0xDEE990", Offset = "0xDED790", Length = "0x11F")]
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0xDEEAB0", Offset = "0xDED8B0", Length = "0x242")]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return 0f;
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0xDEED00", Offset = "0xDEDB00", Length = "0x26A")]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return 0f;
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0xDEEF70", Offset = "0xDEDD70", Length = "0x46")]
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0xDEEFC0", Offset = "0xDEDDC0", Length = "0xBD")]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0xDEF080", Offset = "0xDEDE80", Length = "0xA2")]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0xDEF130", Offset = "0xDEDF30", Length = "0x9D")]
	public static float RotateTowards(float from, float to, float maxAngle)
	{
		return 0f;
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0xDEF1D0", Offset = "0xDEDFD0", Length = "0x1CB")]
	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		return 0f;
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0xDEF3A0", Offset = "0xDEE1A0", Length = "0x1CF")]
	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		return 0f;
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0xDEF570", Offset = "0xDEE370", Length = "0x191")]
	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		return 0f;
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0xDEF710", Offset = "0xDEE510", Length = "0xB3")]
	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0xDEF7D0", Offset = "0xDEE5D0", Length = "0x96")]
	public static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		return default(UIWidget.Pivot);
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0xDEF870", Offset = "0xDEE670", Length = "0x8")]
	public static void MoveWidget(UIRect w, float x, float y)
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0xDEF880", Offset = "0xDEE680", Length = "0x516")]
	public static void MoveRect(UIRect rect, float x, float y)
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0xDEFDA0", Offset = "0xDEEBA0", Length = "0x37")]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0xDEFDE0", Offset = "0xDEEBE0", Length = "0x494")]
	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0xDF02A0", Offset = "0xDEF0A0", Length = "0x46")]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0xDF02F0", Offset = "0xDEF0F0", Length = "0x4C")]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0xDF0340", Offset = "0xDEF140", Length = "0xEA3")]
	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0xDF11F0", Offset = "0xDEFFF0", Length = "0x164")]
	public static int AdjustByDPI(float height)
	{
		return 0;
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0xDF1360", Offset = "0xDF0160", Length = "0x444")]
	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0xDF17B0", Offset = "0xDF05B0", Length = "0x58A")]
	public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0xDF1D40", Offset = "0xDF0B40", Length = "0x3C2")]
	public static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0xDF2110", Offset = "0xDF0F10", Length = "0x3B5")]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0xDF24D0", Offset = "0xDF12D0", Length = "0x1EF")]
	public static void OverlayPosition(this Transform trans, Vector3 worldPos, Camera worldCam)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0xDF26C0", Offset = "0xDF14C0", Length = "0x3C0")]
	public static void OverlayPosition(this Transform trans, Transform target)
	{
	}
}
