using System;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Color")]
[Token(Token = "0x20000E2")]
public class TweenColor : UITweener
{
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x80")]
	public Color from;

	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x90")]
	public Color to;

	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0xA0")]
	private bool mCached;

	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0xA8")]
	private UIWidget mWidget;

	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0xB0")]
	private Material mMat;

	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0xB8")]
	private Light mLight;

	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0xC0")]
	private SpriteRenderer mSr;

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000D7")]
	public Color color
	{
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1126270", Offset = "0x1125070", Length = "0x25")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x11262A0", Offset = "0x11250A0", Length = "0x1E")]
		set
		{
		}
	}

	[Token(Token = "0x170000D8")]
	public Color value
	{
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x11262C0", Offset = "0x11250C0", Length = "0x3C6")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1126690", Offset = "0x1125490", Length = "0x47E")]
		set
		{
		}
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x1125E20", Offset = "0x1124C20", Length = "0x44B")]
	private void Cache()
	{
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x1126B10", Offset = "0x1125910", Length = "0xCC")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0x1126BE0", Offset = "0x11259E0", Length = "0xBA")]
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x6000819")]
	[Address(RVA = "0x1126CA0", Offset = "0x1125AA0", Length = "0x29")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x600081A")]
	[Address(RVA = "0x1126CD0", Offset = "0x1125AD0", Length = "0x29")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x1126D00", Offset = "0x1125B00", Length = "0x22")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x1126D30", Offset = "0x1125B30", Length = "0x22")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0x1126D60", Offset = "0x1125B60", Length = "0x1F")]
	public TweenColor()
	{
	}
}
