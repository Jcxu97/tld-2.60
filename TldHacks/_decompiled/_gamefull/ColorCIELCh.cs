using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009FA")]
internal struct ColorCIELCh
{
	[Token(Token = "0x4006559")]
	[FieldOffset(Offset = "0x0")]
	public float l;

	[Token(Token = "0x400655A")]
	[FieldOffset(Offset = "0x4")]
	public float c;

	[Token(Token = "0x400655B")]
	[FieldOffset(Offset = "0x8")]
	public float h;

	[Token(Token = "0x400655C")]
	[FieldOffset(Offset = "0xC")]
	public float a;

	[Token(Token = "0x60057CA")]
	[Address(RVA = "0x8CFD00", Offset = "0x8CEB00", Length = "0x1A")]
	public ColorCIELCh(float _l, float _c, float _h, float _a)
	{
		l = 0f;
		c = 0f;
		h = 0f;
		a = 0f;
	}

	[Token(Token = "0x60057CB")]
	[Address(RVA = "0xED9B30", Offset = "0xED8930", Length = "0x32")]
	public static implicit operator ColorCIELCh(Color rgba)
	{
		return default(ColorCIELCh);
	}

	[Token(Token = "0x60057CC")]
	[Address(RVA = "0xED9B70", Offset = "0xED8970", Length = "0x120")]
	public static implicit operator ColorCIELCh(ColorCIELab lab)
	{
		return default(ColorCIELCh);
	}

	[Token(Token = "0x60057CD")]
	[Address(RVA = "0xED9C90", Offset = "0xED8A90", Length = "0x32")]
	public static implicit operator Color(ColorCIELCh lch)
	{
		return default(Color);
	}

	[Token(Token = "0x60057CE")]
	[Address(RVA = "0xED9CD0", Offset = "0xED8AD0", Length = "0x341")]
	private static ColorCIELCh FromRGBA(Color rgba)
	{
		return default(ColorCIELCh);
	}

	[Token(Token = "0x60057CF")]
	[Address(RVA = "0xEDA020", Offset = "0xED8E20", Length = "0xF3")]
	private static ColorCIELCh FromLAB(ColorCIELab lab)
	{
		return default(ColorCIELCh);
	}

	[Token(Token = "0x60057D0")]
	[Address(RVA = "0xEDA120", Offset = "0xED8F20", Length = "0x2D9")]
	private static Color ToRGBA(ColorCIELCh lch)
	{
		return default(Color);
	}

	[Token(Token = "0x60057D1")]
	[Address(RVA = "0xED8920", Offset = "0xED7720", Length = "0xDF")]
	public static ColorCIELCh Lerp(ColorCIELCh a, ColorCIELCh b, float blend)
	{
		return default(ColorCIELCh);
	}

	[Token(Token = "0x60057D2")]
	[Address(RVA = "0xEDA400", Offset = "0xED9200", Length = "0x163")]
	public override string ToString()
	{
		return null;
	}
}
