using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Button Color")]
[Token(Token = "0x2000063")]
public class UIButtonColor : UIWidgetContainer
{
	[Token(Token = "0x2000064")]
	public enum State
	{
		[Token(Token = "0x40003B7")]
		Normal,
		[Token(Token = "0x40003B8")]
		Hover,
		[Token(Token = "0x40003B9")]
		Pressed,
		[Token(Token = "0x40003BA")]
		Disabled
	}

	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject tweenTarget;

	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x28")]
	public Color hover;

	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x38")]
	public Color pressed;

	[Token(Token = "0x40003AF")]
	[FieldOffset(Offset = "0x48")]
	public Color disabledColor;

	[Token(Token = "0x40003B0")]
	[FieldOffset(Offset = "0x58")]
	public float duration;

	[NonSerialized]
	[Token(Token = "0x40003B1")]
	[FieldOffset(Offset = "0x5C")]
	protected Color mStartingColor;

	[NonSerialized]
	[Token(Token = "0x40003B2")]
	[FieldOffset(Offset = "0x6C")]
	protected Color mDefaultColor;

	[NonSerialized]
	[Token(Token = "0x40003B3")]
	[FieldOffset(Offset = "0x7C")]
	protected bool mInitDone;

	[NonSerialized]
	[Token(Token = "0x40003B4")]
	[FieldOffset(Offset = "0x80")]
	protected UIWidget mWidget;

	[NonSerialized]
	[Token(Token = "0x40003B5")]
	[FieldOffset(Offset = "0x88")]
	protected State mState;

	[Token(Token = "0x17000035")]
	public State state
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xA25F50", Offset = "0xA24D50", Length = "0x7")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xA25F60", Offset = "0xA24D60", Length = "0x14")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public Color defaultColor
	{
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xA25F80", Offset = "0xA24D80", Length = "0x3E")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xA25FC0", Offset = "0xA24DC0", Length = "0x5E")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public virtual bool isEnabled
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x8EC8D0", Offset = "0x8EB6D0", Length = "0x98")]
		get
		{
			return false;
		}
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA26020", Offset = "0xA24E20", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xA26030", Offset = "0xA24E30", Length = "0x5D")]
	public void ResetDefaultColor()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xA26090", Offset = "0xA24E90", Length = "0x60")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xA260F0", Offset = "0xA24EF0", Length = "0x5B5")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xA266B0", Offset = "0xA254B0", Length = "0x344")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xA26A00", Offset = "0xA25800", Length = "0x1DA")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xA26BE0", Offset = "0xA259E0", Length = "0x126")]
	protected virtual void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xA26D10", Offset = "0xA25B10", Length = "0x3EA")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xA27100", Offset = "0xA25F00", Length = "0x11C")]
	protected virtual void OnDragOver()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xA27220", Offset = "0xA26020", Length = "0x11A")]
	protected virtual void OnDragOut()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xA27340", Offset = "0xA26140", Length = "0x166")]
	protected virtual void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xA274B0", Offset = "0xA262B0", Length = "0x5F")]
	public virtual void SetState(State state, bool instant)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xA27510", Offset = "0xA26310", Length = "0x20A")]
	public void UpdateColor(bool instant)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xA27720", Offset = "0xA26520", Length = "0x7A")]
	public UIButtonColor()
	{
	}
}
