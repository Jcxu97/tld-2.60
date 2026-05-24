using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ProCore.Decals;

[Token(Token = "0x200150C")]
public static class qdUtil
{
	[Token(Token = "0x6008511")]
	[Address(RVA = "0x1271270", Offset = "0x1270070", Length = "0x232")]
	public static GameObject[] FindDecalsWithTexture(Texture2D img)
	{
		return null;
	}

	[Token(Token = "0x6008512")]
	[Address(RVA = "0x12714B0", Offset = "0x12702B0", Length = "0x379")]
	public static void RefreshSceneDecals(DecalGroup dg)
	{
	}

	[Token(Token = "0x6008513")]
	[Address(RVA = "0x1271830", Offset = "0x1270630", Length = "0x23B")]
	public static void SortDecalsUsingView(ref List<Decal> decals, DecalView decalView)
	{
	}

	[Token(Token = "0x6008514")]
	[Address(RVA = "0x1271A70", Offset = "0x1270870", Length = "0xD3")]
	public static bool Contains(this Dictionary<int, List<int>> dic, int key, int val)
	{
		return false;
	}

	[Token(Token = "0x6008515")]
	[Address(RVA = "0x1271B50", Offset = "0x1270950", Length = "0x1B7")]
	public static void Add(this Dictionary<int, List<int>> dic, int key, int val)
	{
	}

	[Token(Token = "0x6008516")]
	[Address(RVA = "0x1271D10", Offset = "0x1270B10", Length = "0x67B")]
	public static string ToFormattedString(this Dictionary<int, List<int>> dic)
	{
		return null;
	}

	[Token(Token = "0x6008517")]
	[Address(RVA = "0x1A63F90", Offset = "0x1A62D90", Length = "0x15B")]
	public static string ToFormattedString<T>(this T[] t, string _delimiter)
	{
		return null;
	}

	[Token(Token = "0x6008518")]
	[Address(RVA = "0x1A63E10", Offset = "0x1A62C10", Length = "0x17B")]
	public static string ToFormattedString<T>(this List<T> t, string _delimiter)
	{
		return null;
	}
}
