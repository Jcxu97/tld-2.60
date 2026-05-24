using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion;

[Token(Token = "0x2000D66")]
public static class ColorUtils
{
	[Token(Token = "0x40083C9")]
	private static Dictionary<Color32, string> colorHexCache;

	[Token(Token = "0x40083CA")]
	private static Dictionary<string, Color> hexColorCache;

	[Token(Token = "0x60068A1")]
	[Address(RVA = "0x106AC70", Offset = "0x1069A70", Length = "0x16")]
	public static Color WithAlpha(this Color color, float alpha)
	{
		return default(Color);
	}

	[Token(Token = "0x60068A2")]
	[Address(RVA = "0x106AC90", Offset = "0x1069A90", Length = "0x249")]
	public static string ColorToHex(Color32 color)
	{
		return null;
	}

	[Token(Token = "0x60068A3")]
	[Address(RVA = "0x106AEE0", Offset = "0x1069CE0", Length = "0x57F")]
	public static Color HexToColor(string hex)
	{
		return default(Color);
	}
}
