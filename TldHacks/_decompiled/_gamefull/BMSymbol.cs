using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20000AE")]
public class BMSymbol
{
	[Token(Token = "0x40005B8")]
	private const string BUTTON_LEGEND_ATLAS_KEY = "ConsoleButtonLegendAtlas";

	[Token(Token = "0x40005B9")]
	private static ButtonLegendAtlas s_ButtonLegendAtlas;

	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x10")]
	public string sequence;

	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x18")]
	public string spriteName;

	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x20")]
	private UISpriteData mSprite;

	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x28")]
	private bool mIsValid;

	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x2C")]
	private int mLength;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x30")]
	private int mOffsetX;

	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x34")]
	private int mOffsetY;

	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x38")]
	private int mWidth;

	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x3C")]
	private int mHeight;

	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x40")]
	private int mAdvance;

	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x44")]
	private Rect mUV;

	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x54")]
	public int charIndex;

	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x58")]
	public Color spriteColor;

	[Token(Token = "0x17000076")]
	public int length
	{
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xDE2D10", Offset = "0xDE1B10", Length = "0x26")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000077")]
	public int offsetX
	{
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000078")]
	public int offsetY
	{
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x5025B0", Offset = "0x5013B0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000079")]
	public int width
	{
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700007A")]
	public int height
	{
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E2E0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700007B")]
	public int advance
	{
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x507940", Offset = "0x506740", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700007C")]
	public Rect uvRect
	{
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xDE2D40", Offset = "0xDE1B40", Length = "0xB")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0xDE2D50", Offset = "0xDE1B50", Length = "0x5")]
	public void MarkAsChanged()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0xDE2D60", Offset = "0xDE1B60", Length = "0x3FF")]
	public bool Validate(UIAtlas atlas)
	{
		return false;
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0xDE3160", Offset = "0xDE1F60", Length = "0x1C")]
	public void SetUpBlankSymbol(int width, int height)
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0xDE3180", Offset = "0xDE1F80", Length = "0xC")]
	public void SetIndexAndColor(int index, Color color)
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0xDE3190", Offset = "0xDE1F90", Length = "0xF9C")]
	public void SetSpriteLocation(UILabel label, Vector3 offsetPosition)
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BMSymbol()
	{
	}
}
