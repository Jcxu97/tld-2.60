using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20000AD")]
public class BMGlyph
{
	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[Token(Token = "0x40005AF")]
	[FieldOffset(Offset = "0x14")]
	public int x;

	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x18")]
	public int y;

	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x1C")]
	public int width;

	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x20")]
	public int height;

	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x24")]
	public int offsetX;

	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x28")]
	public int offsetY;

	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x2C")]
	public int advance;

	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x30")]
	public int channel;

	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x38")]
	public List<int> kerning;

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0xDE2980", Offset = "0xDE1780", Length = "0xB8")]
	public int GetKerning(int previousChar)
	{
		return 0;
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0xDE2A40", Offset = "0xDE1840", Length = "0x232")]
	public void SetKerning(int previousChar, int amount)
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0xDE2C80", Offset = "0xDE1A80", Length = "0x84")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BMGlyph()
	{
	}
}
