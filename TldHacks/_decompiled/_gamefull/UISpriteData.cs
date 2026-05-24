using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000125")]
public class UISpriteData
{
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x18")]
	public int x;

	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x1C")]
	public int y;

	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x20")]
	public int width;

	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x24")]
	public int height;

	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x28")]
	public int borderLeft;

	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x2C")]
	public int borderRight;

	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x30")]
	public int borderTop;

	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x34")]
	public int borderBottom;

	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x38")]
	public int paddingLeft;

	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x3C")]
	public int paddingRight;

	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x40")]
	public int paddingTop;

	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x44")]
	public int paddingBottom;

	[Token(Token = "0x17000191")]
	public bool hasBorder
	{
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x5C7820", Offset = "0x5C6620", Length = "0x10")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000192")]
	public bool hasPadding
	{
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x5C7830", Offset = "0x5C6630", Length = "0x10")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x5C7840", Offset = "0x5C6640", Length = "0x13")]
	public void SetRect(int x, int y, int width, int height)
	{
	}

	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x5C7860", Offset = "0x5C6660", Length = "0x13")]
	public void SetPadding(int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x5C7880", Offset = "0x5C6680", Length = "0x13")]
	public void SetBorder(int left, int bottom, int right, int top)
	{
	}

	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x5C78A0", Offset = "0x5C66A0", Length = "0xCB")]
	public void CopyFrom(UISpriteData sd)
	{
	}

	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6770", Length = "0x486")]
	public void CopyFromReduced(UISpriteData sd, float reductionFactor)
	{
	}

	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x5C7E00", Offset = "0x5C6C00", Length = "0x2B")]
	public void CopyBorderFrom(UISpriteData sd)
	{
	}

	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x5C7E30", Offset = "0x5C6C30", Length = "0x87")]
	public UISpriteData()
	{
	}
}
