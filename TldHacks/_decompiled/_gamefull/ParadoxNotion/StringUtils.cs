using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion;

[Token(Token = "0x2000D6A")]
public static class StringUtils
{
	[Token(Token = "0x40083CD")]
	private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	[Token(Token = "0x40083CE")]
	private static readonly char[] CHAR_EMPTY_ARRAY;

	[Token(Token = "0x40083CF")]
	private static Dictionary<string, string> splitCaseCache;

	[Token(Token = "0x60068B8")]
	[Address(RVA = "0x106C8A0", Offset = "0x106B6A0", Length = "0x21B")]
	public static string SplitCamelCase(this string s)
	{
		return null;
	}

	[Token(Token = "0x60068B9")]
	[Address(RVA = "0x106CAC0", Offset = "0x106B8C0", Length = "0xDA")]
	public static string CapitalizeFirst(this string s)
	{
		return null;
	}

	[Token(Token = "0x60068BA")]
	[Address(RVA = "0x106CBA0", Offset = "0x106B9A0", Length = "0x80")]
	public static string CapLength(this string s, int max)
	{
		return null;
	}

	[Token(Token = "0x60068BB")]
	[Address(RVA = "0x106CC20", Offset = "0x106BA20", Length = "0x14A")]
	public static string GetCapitals(this string s)
	{
		return null;
	}

	[Token(Token = "0x60068BC")]
	[Address(RVA = "0x106CD70", Offset = "0x106BB70", Length = "0xD7")]
	public static string GetAlphabetLetter(int index)
	{
		return null;
	}

	[Token(Token = "0x60068BD")]
	[Address(RVA = "0x106CE50", Offset = "0x106BC50", Length = "0x1B7")]
	public static string GetStringWithin(this string input, string from, string to)
	{
		return null;
	}

	[Token(Token = "0x60068BE")]
	[Address(RVA = "0x106D010", Offset = "0x106BE10", Length = "0x2A4")]
	public static float ScoreSearchMatch(string input, string leafName, string categoryName = "")
	{
		return 0f;
	}

	[Token(Token = "0x60068BF")]
	[Address(RVA = "0x106D2C0", Offset = "0x106C0C0", Length = "0x396")]
	public static bool SearchMatch(string input, string leafName, string categoryName = "")
	{
		return false;
	}

	[Token(Token = "0x60068C0")]
	[Address(RVA = "0x106D660", Offset = "0x106C460", Length = "0x11F")]
	public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process)
	{
		return null;
	}

	[Token(Token = "0x60068C1")]
	[Address(RVA = "0x106D780", Offset = "0x106C580", Length = "0x553")]
	public static string ToStringAdvanced(this object o)
	{
		return null;
	}
}
