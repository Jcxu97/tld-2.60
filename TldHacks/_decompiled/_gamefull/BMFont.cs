using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20000AC")]
public class BMFont
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x10")]
	private int mSize;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x14")]
	private int mBase;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x18")]
	private int mWidth;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x1C")]
	private int mHeight;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x20")]
	private string mSpriteName;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0x28")]
	private List<BMGlyph> mSaved;

	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, BMGlyph> mDict;

	[Token(Token = "0x1700006E")]
	public bool isValid
	{
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xDE2290", Offset = "0xDE1090", Length = "0x45")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700006F")]
	public int charSize
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public int baseOffset
	{
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x40E0B0", Offset = "0x40CEB0", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public int texWidth
	{
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x40E0D0", Offset = "0x40CED0", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x40E0E0", Offset = "0x40CEE0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public int texHeight
	{
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x40E0F0", Offset = "0x40CEF0", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x40E100", Offset = "0x40CF00", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000073")]
	public int glyphCount
	{
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xDE22E0", Offset = "0xDE10E0", Length = "0x70")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000074")]
	public string spriteName
	{
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public List<BMGlyph> glyphs
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0xDE2360", Offset = "0xDE1160", Length = "0x2EC")]
	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		return null;
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0xDE2650", Offset = "0xDE1450", Length = "0xB")]
	public BMGlyph GetGlyph(int index)
	{
		return null;
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0xDE2660", Offset = "0xDE1460", Length = "0x8A")]
	public void Clear()
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0xDE26F0", Offset = "0xDE14F0", Length = "0x119")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0xDE2810", Offset = "0xDE1610", Length = "0x169")]
	public BMFont()
	{
	}
}
