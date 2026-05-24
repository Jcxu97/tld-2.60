using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000D01")]
public static class TextureFormatUtilities
{
	[Token(Token = "0x4008106")]
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

	[Token(Token = "0x4008107")]
	private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

	[Token(Token = "0x4008108")]
	private static Dictionary<int, bool> s_SupportedTextureFormats;

	[Token(Token = "0x60066EC")]
	[Address(RVA = "0x1034190", Offset = "0x1032F90", Length = "0x1154")]
	static TextureFormatUtilities()
	{
	}

	[Token(Token = "0x60066ED")]
	[Address(RVA = "0x10352F0", Offset = "0x10340F0", Length = "0x158")]
	private static bool IsObsolete(object value)
	{
		return false;
	}

	[Token(Token = "0x60066EE")]
	[Address(RVA = "0x1035450", Offset = "0x1034250", Length = "0x1ED")]
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x60066EF")]
	[Address(RVA = "0x1035640", Offset = "0x1034440", Length = "0xCF")]
	internal static bool IsSupported(this RenderTextureFormat format)
	{
		return false;
	}

	[Token(Token = "0x60066F0")]
	[Address(RVA = "0x1035710", Offset = "0x1034510", Length = "0xCF")]
	internal static bool IsSupported(this TextureFormat format)
	{
		return false;
	}
}
