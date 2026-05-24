using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009F7")]
public struct ColorHSV
{
	[Token(Token = "0x400654D")]
	[FieldOffset(Offset = "0x0")]
	public float h;

	[Token(Token = "0x400654E")]
	[FieldOffset(Offset = "0x4")]
	public float s;

	[Token(Token = "0x400654F")]
	[FieldOffset(Offset = "0x8")]
	public float v;

	[Token(Token = "0x4006550")]
	[FieldOffset(Offset = "0xC")]
	public float a;

	[Token(Token = "0x60057B2")]
	[Address(RVA = "0x8CFD00", Offset = "0x8CEB00", Length = "0x1A")]
	public ColorHSV(float _h, float _s, float _v, float _a)
	{
		h = 0f;
		s = 0f;
		v = 0f;
		a = 0f;
	}

	[Token(Token = "0x60057B3")]
	[Address(RVA = "0xED8310", Offset = "0xED7110", Length = "0xE3")]
	public ColorHSV(Color rgba)
	{
		h = 0f;
		s = 0f;
		v = 0f;
		a = 0f;
	}

	[Token(Token = "0x60057B4")]
	[Address(RVA = "0xED8400", Offset = "0xED7200", Length = "0x25")]
	public void MakeCompliment()
	{
	}

	[Token(Token = "0x60057B5")]
	[Address(RVA = "0xED8430", Offset = "0xED7230", Length = "0x64")]
	public void InvertShade()
	{
	}

	[Token(Token = "0x60057B6")]
	[Address(RVA = "0xED84A0", Offset = "0xED72A0", Length = "0xE3")]
	public static implicit operator ColorHSV(Color rgba)
	{
		return default(ColorHSV);
	}

	[Token(Token = "0x60057B7")]
	[Address(RVA = "0xED8590", Offset = "0xED7390", Length = "0x17D")]
	public static implicit operator Color(ColorHSV hsv)
	{
		return default(Color);
	}

	[Token(Token = "0x60057B8")]
	[Address(RVA = "0xED8710", Offset = "0xED7510", Length = "0xBF")]
	private static ColorHSV FromRGBA(Color rgba)
	{
		return default(ColorHSV);
	}

	[Token(Token = "0x60057B9")]
	[Address(RVA = "0xED87D0", Offset = "0xED75D0", Length = "0x14C")]
	private static Color ToRGBA(ColorHSV hsv)
	{
		return default(Color);
	}

	[Token(Token = "0x60057BA")]
	[Address(RVA = "0xED8920", Offset = "0xED7720", Length = "0xDF")]
	public static ColorHSV Lerp(ColorHSV a, ColorHSV b, float blend)
	{
		return default(ColorHSV);
	}

	[Token(Token = "0x60057BB")]
	[Address(RVA = "0xED8A00", Offset = "0xED7800", Length = "0x163")]
	public override string ToString()
	{
		return null;
	}
}
