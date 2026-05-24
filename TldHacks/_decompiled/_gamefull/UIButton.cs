using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button")]
[Token(Token = "0x2000061")]
public class UIButton : UIButtonColor
{
	[Token(Token = "0x400039C")]
	public static UIButton current;

	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x90")]
	public bool dragHighlight;

	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x98")]
	public string hoverSprite;

	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0xA0")]
	public string pressedSprite;

	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0xA8")]
	public string disabledSprite;

	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0xB0")]
	public Sprite hoverSprite2D;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0xB8")]
	public Sprite pressedSprite2D;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0xC0")]
	public Sprite disabledSprite2D;

	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0xC8")]
	public bool pixelSnap;

	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0xD0")]
	public List<EventDelegate> onClick;

	[NonSerialized]
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0xD8")]
	private UISprite mSprite;

	[NonSerialized]
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0xE0")]
	private UI2DSprite mSprite2D;

	[NonSerialized]
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0xE8")]
	private string mNormalSprite;

	[NonSerialized]
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0xF0")]
	private Sprite mNormalSprite2D;

	[Token(Token = "0x17000032")]
	public override bool isEnabled
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA23CC0", Offset = "0xA22AC0", Length = "0x20C")]
		get
		{
			return false;
		}
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA23ED0", Offset = "0xA22CD0", Length = "0x2E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public string normalSprite
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA241C0", Offset = "0xA22FC0", Length = "0x39")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA24200", Offset = "0xA23000", Length = "0x21D")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public Sprite normalSprite2D
	{
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA24420", Offset = "0xA23220", Length = "0x39")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA24460", Offset = "0xA23260", Length = "0x300")]
		set
		{
		}
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xA24770", Offset = "0xA23570", Length = "0x3E9")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xA24B60", Offset = "0xA23960", Length = "0x302")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xA24E70", Offset = "0xA23C70", Length = "0x2AC")]
	protected override void OnDragOver()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xA25120", Offset = "0xA23F20", Length = "0x2AA")]
	protected override void OnDragOut()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xA253D0", Offset = "0xA241D0", Length = "0x214")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xA255F0", Offset = "0xA243F0", Length = "0x34E")]
	public override void SetState(State state, bool immediate)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xA25940", Offset = "0xA24740", Length = "0x161")]
	protected void SetSprite(string sp)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xA25AB0", Offset = "0xA248B0", Length = "0x266")]
	protected void SetSprite(Sprite sp)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xA25D20", Offset = "0xA24B20", Length = "0x11D")]
	public UIButton()
	{
	}
}
