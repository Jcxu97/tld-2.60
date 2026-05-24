using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009F8")]
internal struct ColorXYZ
{
	[Token(Token = "0x4006551")]
	[FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4006552")]
	[FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4006553")]
	[FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4006554")]
	[FieldOffset(Offset = "0xC")]
	public float a;

	[Token(Token = "0x60057BC")]
	[Address(RVA = "0x8CFD00", Offset = "0x8CEB00", Length = "0x1A")]
	public ColorXYZ(float _x, float _y, float _z, float _a)
	{
		x = 0f;
		y = 0f;
		z = 0f;
		a = 0f;
	}

	[Token(Token = "0x60057BD")]
	[Address(RVA = "0xED8B70", Offset = "0xED7970", Length = "0x187")]
	public static implicit operator ColorXYZ(Color rgba)
	{
		return default(ColorXYZ);
	}

	[Token(Token = "0x60057BE")]
	[Address(RVA = "0xED8D00", Offset = "0xED7B00", Length = "0x145")]
	public static implicit operator ColorXYZ(ColorCIELab lab)
	{
		return default(ColorXYZ);
	}

	[Token(Token = "0x60057BF")]
	[Address(RVA = "0xED8E50", Offset = "0xED7C50", Length = "0x1A6")]
	public static implicit operator Color(ColorXYZ xyz)
	{
		return default(Color);
	}

	[Token(Token = "0x60057C0")]
	[Address(RVA = "0xED9000", Offset = "0xED7E00", Length = "0x194")]
	private static ColorXYZ FromRGBA(Color rgba)
	{
		return default(ColorXYZ);
	}

	[Token(Token = "0x60057C1")]
	[Address(RVA = "0xED91A0", Offset = "0xED7FA0", Length = "0x138")]
	private static ColorXYZ FromLAB(ColorCIELab lab)
	{
		return default(ColorXYZ);
	}

	[Token(Token = "0x60057C2")]
	[Address(RVA = "0xED92E0", Offset = "0xED80E0", Length = "0x193")]
	private static Color ToRGBA(ColorXYZ xyz)
	{
		return default(Color);
	}

	[Token(Token = "0x60057C3")]
	[Address(RVA = "0xED9480", Offset = "0xED8280", Length = "0x163")]
	public override string ToString()
	{
		return null;
	}
}
