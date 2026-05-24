using System.Diagnostics;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B6")]
public static class NGUIText
{
	[Token(Token = "0x20000B7")]
	public enum Alignment
	{
		[Token(Token = "0x4000611")]
		Automatic,
		[Token(Token = "0x4000612")]
		Left,
		[Token(Token = "0x4000613")]
		Center,
		[Token(Token = "0x4000614")]
		Right,
		[Token(Token = "0x4000615")]
		Justified
	}

	[Token(Token = "0x20000B8")]
	public enum SymbolStyle
	{
		[Token(Token = "0x4000617")]
		None,
		[Token(Token = "0x4000618")]
		Normal,
		[Token(Token = "0x4000619")]
		Colored
	}

	[Token(Token = "0x20000B9")]
	public class GlyphInfo
	{
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 v0;

		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 v1;

		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 u0;

		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 u1;

		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 u2;

		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 u3;

		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x40")]
		public float advance;

		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x44")]
		public int channel;

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public GlyphInfo()
		{
		}
	}

	[Token(Token = "0x40005E8")]
	public static UIFont bitmapFont;

	[Token(Token = "0x40005E9")]
	public static Font dynamicFont;

	[Token(Token = "0x40005EA")]
	public static GlyphInfo glyph;

	[Token(Token = "0x40005EB")]
	public static int fontSize;

	[Token(Token = "0x40005EC")]
	public static float fontScale;

	[Token(Token = "0x40005ED")]
	public static float pixelDensity;

	[Token(Token = "0x40005EE")]
	public static FontStyle fontStyle;

	[Token(Token = "0x40005EF")]
	public static Alignment alignment;

	[Token(Token = "0x40005F0")]
	public static Color tint;

	[Token(Token = "0x40005F1")]
	public static int rectWidth;

	[Token(Token = "0x40005F2")]
	public static int rectHeight;

	[Token(Token = "0x40005F3")]
	public static int regionWidth;

	[Token(Token = "0x40005F4")]
	public static int regionHeight;

	[Token(Token = "0x40005F5")]
	public static int maxLines;

	[Token(Token = "0x40005F6")]
	public static bool gradient;

	[Token(Token = "0x40005F7")]
	public static Color gradientBottom;

	[Token(Token = "0x40005F8")]
	public static Color gradientTop;

	[Token(Token = "0x40005F9")]
	public static bool encoding;

	[Token(Token = "0x40005FA")]
	public static float spacingX;

	[Token(Token = "0x40005FB")]
	public static float spacingY;

	[Token(Token = "0x40005FC")]
	public static bool premultiply;

	[Token(Token = "0x40005FD")]
	public static SymbolStyle symbolStyle;

	[Token(Token = "0x40005FE")]
	public static int finalSize;

	[Token(Token = "0x40005FF")]
	public static float finalSpacingX;

	[Token(Token = "0x4000600")]
	public static float finalLineHeight;

	[Token(Token = "0x4000601")]
	public static float baseline;

	[Token(Token = "0x4000602")]
	public static bool useSymbols;

	[Token(Token = "0x4000603")]
	public static BetterList<string> m_DynamicSymbolNames;

	[Token(Token = "0x4000604")]
	private static string m_DynamicSymbolKeyphrase;

	[Token(Token = "0x4000605")]
	private static string m_DynamicSymbolKeyphraseUpper;

	[Token(Token = "0x4000606")]
	private static string m_DynamicSymbolNameUpper;

	[Token(Token = "0x4000607")]
	private static BetterList<BMSymbol> s_DynamicSymbols;

	[Token(Token = "0x4000608")]
	private static Color mInvisible;

	[Token(Token = "0x4000609")]
	private static BetterList<Color> mColors;

	[Token(Token = "0x400060A")]
	private static float mAlpha;

	[Token(Token = "0x400060B")]
	private static CharacterInfo mTempChar;

	[Token(Token = "0x400060C")]
	private static BetterList<float> mSizes;

	[Token(Token = "0x400060D")]
	private static Color32 s_c0;

	[Token(Token = "0x400060E")]
	private static Color32 s_c1;

	[Token(Token = "0x400060F")]
	private static float[] mBoldOffset;

	[Token(Token = "0x600064E")]
	[Address(RVA = "0xDF2A90", Offset = "0xDF1890", Length = "0x47")]
	public static void Update()
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0xDF2AE0", Offset = "0xDF18E0", Length = "0x433")]
	public static void Update(bool request)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0xDF2F20", Offset = "0xDF1D20", Length = "0x15B")]
	public static string Prepare(string text)
	{
		return null;
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0xDF3080", Offset = "0xDF1E80", Length = "0x243")]
	public static BMSymbol GetSymbol(string text, int index, int textLength)
	{
		return null;
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0xDF32D0", Offset = "0xDF20D0", Length = "0x379")]
	public static float GetGlyphWidth(int ch, int prev)
	{
		return 0f;
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0xDF3650", Offset = "0xDF2450", Length = "0xA71")]
	public static GlyphInfo GetGlyph(int ch, int prev)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000654")]
	[Address(RVA = "0xDF40D0", Offset = "0xDF2ED0", Length = "0xA1")]
	public static float ParseAlpha(string text, int index)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000655")]
	[Address(RVA = "0xDF4180", Offset = "0xDF2F80", Length = "0x7A")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000656")]
	[Address(RVA = "0xDF4200", Offset = "0xDF3000", Length = "0x13C")]
	public static Color ParseColor24(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000657")]
	[Address(RVA = "0xDF4340", Offset = "0xDF3140", Length = "0x184")]
	public static Color ParseColor32(string text, int offset)
	{
		return default(Color);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000658")]
	[Address(RVA = "0xDF44D0", Offset = "0xDF32D0", Length = "0x59")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000659")]
	[Address(RVA = "0xDF4530", Offset = "0xDF3330", Length = "0x137")]
	public static string EncodeColor(string text, Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600065A")]
	[Address(RVA = "0xDF4670", Offset = "0xDF3470", Length = "0x146")]
	public static string EncodeAlpha(float a)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600065B")]
	[Address(RVA = "0xDF47C0", Offset = "0xDF35C0", Length = "0xFC")]
	public static string EncodeColor24(Color c)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600065C")]
	[Address(RVA = "0xDF48C0", Offset = "0xDF36C0", Length = "0xF3")]
	public static string EncodeColor32(Color c)
	{
		return null;
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0xDF49C0", Offset = "0xDF37C0", Length = "0xDD")]
	public static bool ParseSymbol(string text, ref int index)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600065E")]
	[Address(RVA = "0xDF4AA0", Offset = "0xDF38A0", Length = "0x26")]
	public static bool IsHex(char ch)
	{
		return false;
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0xDF4AD0", Offset = "0xDF38D0", Length = "0x10B5")]
	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
	{
		return false;
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0xDF5B90", Offset = "0xDF4990", Length = "0x1A8")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0xDF5D40", Offset = "0xDF4B40", Length = "0x60B")]
	public static void Align(BetterList<Vector3> verts, int indexOffset, float printedWidth)
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0xDF6350", Offset = "0xDF5150", Length = "0x12E")]
	public static int GetExactCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return 0;
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0xDF6480", Offset = "0xDF5280", Length = "0x137")]
	public static int GetApproximateCharacterIndex(BetterList<Vector3> verts, BetterList<int> indices, Vector2 pos)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000664")]
	[Address(RVA = "0xDF65C0", Offset = "0xDF53C0", Length = "0x1D")]
	private static bool IsSpace(int ch)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000665")]
	[Address(RVA = "0xDF65E0", Offset = "0xDF53E0", Length = "0x117")]
	public static void EndLine(ref StringBuilder s)
	{
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x6000666")]
	[Address(RVA = "0xDF6700", Offset = "0xDF5500", Length = "0xB1")]
	private static void ReplaceSpaceWithNewline(ref StringBuilder s)
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0xDF67C0", Offset = "0xDF55C0", Length = "0x4C1")]
	public static Vector2 CalculatePrintedSize(string text)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0xDF6C90", Offset = "0xDF5A90", Length = "0x3DD")]
	public static int CalculateOffsetToFit(string text)
	{
		return 0;
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0xDF7070", Offset = "0xDF5E70", Length = "0x77")]
	public static string GetEndOfLineThatFits(string text)
	{
		return null;
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0xDF70F0", Offset = "0xDF5EF0", Length = "0x6D")]
	public static bool WrapText(string text, out string finalText)
	{
		finalText = null;
		return false;
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0xDF7160", Offset = "0xDF5F60", Length = "0xA5E")]
	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool bulleted, int bulletSpacing)
	{
		finalText = null;
		return false;
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0xDF7BC0", Offset = "0xDF69C0", Length = "0x28A0")]
	public static void Print(string text, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, UILabel printedLabel)
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0xDFA470", Offset = "0xDF9270", Length = "0x76C")]
	public static void PrintApproximateCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0xDFABE0", Offset = "0xDF99E0", Length = "0x6A9")]
	public static void PrintExactCharacterPositions(string text, BetterList<Vector3> verts, BetterList<int> indices)
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0xDFB290", Offset = "0xDFA090", Length = "0x104A")]
	public static void PrintCaretAndSelection(string text, int start, int end, BetterList<Vector3> caret, BetterList<Vector3> highlight)
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0xDFC2E0", Offset = "0xDFB0E0", Length = "0xA15")]
	private static BMSymbol GetDynamicSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0xDFCD00", Offset = "0xDFBB00", Length = "0x370")]
	private static string MaybeReplaceSymbolWithKeycode(string text, ref BMSymbol symbol)
	{
		return null;
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0xDFD080", Offset = "0xDFBE80", Length = "0x1FC")]
	private static string MaybeReplaceSymbolsWithKeycodes(string text)
	{
		return null;
	}
}
