using Cpp2ILInjected;

[Token(Token = "0x20009F9")]
internal struct ColorCIELab
{
	[Token(Token = "0x4006555")]
	[FieldOffset(Offset = "0x0")]
	public float l;

	[Token(Token = "0x4006556")]
	[FieldOffset(Offset = "0x4")]
	public float a;

	[Token(Token = "0x4006557")]
	[FieldOffset(Offset = "0x8")]
	public float b;

	[Token(Token = "0x4006558")]
	[FieldOffset(Offset = "0xC")]
	public float alpha;

	[Token(Token = "0x60057C4")]
	[Address(RVA = "0x8CFD00", Offset = "0x8CEB00", Length = "0x1A")]
	public ColorCIELab(float _l, float _a, float _b, float _alpha)
	{
		l = 0f;
		a = 0f;
		b = 0f;
		alpha = 0f;
	}

	[Token(Token = "0x60057C5")]
	[Address(RVA = "0xED95F0", Offset = "0xED83F0", Length = "0x15F")]
	public static implicit operator ColorCIELab(ColorXYZ xyz)
	{
		return default(ColorCIELab);
	}

	[Token(Token = "0x60057C6")]
	[Address(RVA = "0xED9750", Offset = "0xED8550", Length = "0xA9")]
	public static implicit operator ColorCIELab(ColorCIELCh lch)
	{
		return default(ColorCIELab);
	}

	[Token(Token = "0x60057C7")]
	[Address(RVA = "0xED9800", Offset = "0xED8600", Length = "0x150")]
	private static ColorCIELab FromXYZ(ColorXYZ xyz)
	{
		return default(ColorCIELab);
	}

	[Token(Token = "0x60057C8")]
	[Address(RVA = "0xED9950", Offset = "0xED8750", Length = "0x63")]
	private static ColorCIELab FromCIELCh(ColorCIELCh lch)
	{
		return default(ColorCIELab);
	}

	[Token(Token = "0x60057C9")]
	[Address(RVA = "0xED99C0", Offset = "0xED87C0", Length = "0x163")]
	public override string ToString()
	{
		return null;
	}
}
