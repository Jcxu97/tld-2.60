using System.IO;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D9A")]
public static class fsJsonPrinter
{
	[Token(Token = "0x6006A05")]
	[Address(RVA = "0x107E1F0", Offset = "0x107CFF0", Length = "0x7A")]
	private static void InsertSpacing(TextWriter stream, int count)
	{
	}

	[Token(Token = "0x6006A06")]
	[Address(RVA = "0x107E270", Offset = "0x107D070", Length = "0x3A0")]
	private static string EscapeString(string str)
	{
		return null;
	}

	[Token(Token = "0x6006A07")]
	[Address(RVA = "0x107E650", Offset = "0x107D450", Length = "0x604")]
	private static void BuildCompressedString(fsData data, TextWriter stream)
	{
	}

	[Token(Token = "0x6006A08")]
	[Address(RVA = "0x107EC70", Offset = "0x107DA70", Length = "0x850")]
	private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
	{
	}

	[Token(Token = "0x6006A09")]
	[Address(RVA = "0x107F4E0", Offset = "0x107E2E0", Length = "0x12")]
	public static string ToJson(fsData data, bool pretty)
	{
		return null;
	}

	[Token(Token = "0x6006A0A")]
	[Address(RVA = "0x107F500", Offset = "0x107E300", Length = "0xB")]
	public static void PrettyJson(fsData data, TextWriter outputStream)
	{
	}

	[Token(Token = "0x6006A0B")]
	[Address(RVA = "0x107F510", Offset = "0x107E310", Length = "0x141")]
	public static string PrettyJson(fsData data)
	{
		return null;
	}

	[Token(Token = "0x6006A0C")]
	[Address(RVA = "0x107F660", Offset = "0x107E460", Length = "0x8")]
	public static void CompressedJson(fsData data, StreamWriter outputStream)
	{
	}

	[Token(Token = "0x6006A0D")]
	[Address(RVA = "0x107F670", Offset = "0x107E470", Length = "0x13E")]
	public static string CompressedJson(fsData data)
	{
		return null;
	}

	[Token(Token = "0x6006A0E")]
	[Address(RVA = "0x107F7B0", Offset = "0x107E5B0", Length = "0x21D")]
	private static string ConvertDoubleToString(double d)
	{
		return null;
	}
}
