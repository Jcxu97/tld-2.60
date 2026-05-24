using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BDF")]
public static class Noise3D
{
	[Token(Token = "0x4007957")]
	private static bool ms_IsSupportedChecked;

	[Token(Token = "0x4007958")]
	private static bool ms_IsSupported;

	[Token(Token = "0x4007959")]
	private static Texture3D ms_NoiseTexture;

	[Token(Token = "0x400795A")]
	private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

	[Token(Token = "0x400795B")]
	private const int kMinShaderLevel = 35;

	[Token(Token = "0x170003E3")]
	public static bool isSupported
	{
		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0xF68550", Offset = "0xF67350", Length = "0x1FA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003E4")]
	public static bool isProperlyLoaded
	{
		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0xF68750", Offset = "0xF67550", Length = "0xE6")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003E5")]
	public static string isNotSupportedString
	{
		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0xF68840", Offset = "0xF67640", Length = "0xFC")]
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6005DA5")]
	[Address(RVA = "0xF68940", Offset = "0xF67740", Length = "0x7")]
	private static void OnStartUp()
	{
	}

	[Token(Token = "0x6005DA6")]
	[Address(RVA = "0xF68950", Offset = "0xF67750", Length = "0x26B")]
	public static void LoadIfNeeded()
	{
	}

	[Token(Token = "0x6005DA7")]
	[Address(RVA = "0xF68BC0", Offset = "0xF679C0", Length = "0x3B8")]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
