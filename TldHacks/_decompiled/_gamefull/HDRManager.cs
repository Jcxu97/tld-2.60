using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000754")]
public static class HDRManager
{
	[Token(Token = "0x4004E40")]
	public const float PAPER_WHITE_DEFAULT = 160f;

	[Token(Token = "0x4004E41")]
	public const float PEAK_BRIGHTNESS_DEFAULT = 1000f;

	[Token(Token = "0x4004E42")]
	public const float PAPER_WHITE_MIN = 0f;

	[Token(Token = "0x4004E43")]
	public const float PAPER_WHITE_MAX = 1000f;

	[Token(Token = "0x4004E44")]
	public const float PEAK_BRIGHTNESS_MIN = 300f;

	[Token(Token = "0x4004E45")]
	public const float PEAK_BRIGHTNESS_MAX = 6000f;

	[Token(Token = "0x4004E46")]
	private static IHDRHandler m_HDRHandler;

	[Token(Token = "0x6004375")]
	[Address(RVA = "0xC57E80", Offset = "0xC56C80", Length = "0x10F")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6004376")]
	[Address(RVA = "0xC57F90", Offset = "0xC56D90", Length = "0x6F")]
	public static void SetPaperWhiteNits(float value)
	{
	}

	[Token(Token = "0x6004377")]
	[Address(RVA = "0xC58000", Offset = "0xC56E00", Length = "0x10")]
	public static float GetPaperWhiteAsRange(float value)
	{
		return 0f;
	}

	[Token(Token = "0x6004378")]
	[Address(RVA = "0xC58010", Offset = "0xC56E10", Length = "0x35")]
	public static float GetPaperWhiteFromRange(float value)
	{
		return 0f;
	}

	[Token(Token = "0x6004379")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public static string GetDebugDisplayText()
	{
		return null;
	}

	[Token(Token = "0x600437A")]
	[Address(RVA = "0xC58050", Offset = "0xC56E50", Length = "0x30")]
	public static void SetPaperWhiteFromRange(float value)
	{
	}

	[Token(Token = "0x600437B")]
	[Address(RVA = "0xC58080", Offset = "0xC56E80", Length = "0x72")]
	public static void SetPeakBrightnessNits(float value)
	{
	}

	[Token(Token = "0x600437C")]
	[Address(RVA = "0xC58100", Offset = "0xC56F00", Length = "0x11")]
	public static float GetPeakBrightnessNitsAsRange(float value)
	{
		return 0f;
	}

	[Token(Token = "0x600437D")]
	[Address(RVA = "0xC58120", Offset = "0xC56F20", Length = "0x3D")]
	public static float GetPeakBrightnessNitsFromRange(float value)
	{
		return 0f;
	}

	[Token(Token = "0x600437E")]
	[Address(RVA = "0xC58160", Offset = "0xC56F60", Length = "0x34")]
	public static void SetPeakBrightnessFromRange(float value)
	{
	}

	[Token(Token = "0x600437F")]
	[Address(RVA = "0xC581A0", Offset = "0xC56FA0", Length = "0x68")]
	public static bool IsOutputtingHDR()
	{
		return false;
	}

	[Token(Token = "0x6004380")]
	[Address(RVA = "0xC58210", Offset = "0xC57010", Length = "0x165")]
	public static void Render(RenderTexture source, RenderTexture destination)
	{
	}
}
