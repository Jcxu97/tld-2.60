using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Tween/Tween Height")]
[Token(Token = "0x20000E4")]
public class TweenHeight : UITweener
{
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x80")]
	public int from;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x84")]
	public int to;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x88")]
	public bool updateTable;

	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x90")]
	private UIWidget mWidget;

	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x98")]
	private UITable mTable;

	[Token(Token = "0x170000DC")]
	public UIWidget cachedWidget
	{
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x11271D0", Offset = "0x1125FD0", Length = "0x158")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000DD")]
	public int height
	{
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1127330", Offset = "0x1126130", Length = "0x20")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1127360", Offset = "0x1126160", Length = "0x2B")]
		set
		{
		}
	}

	[Token(Token = "0x170000DE")]
	public int value
	{
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1127330", Offset = "0x1126130", Length = "0x20")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1127360", Offset = "0x1126160", Length = "0x2B")]
		set
		{
		}
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x1127390", Offset = "0x1126190", Length = "0x30D")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x11276A0", Offset = "0x11264A0", Length = "0xC1")]
	public static TweenHeight Begin(UIWidget widget, float duration, int height)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x1127770", Offset = "0x1126570", Length = "0x2C")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x11277A0", Offset = "0x11265A0", Length = "0x2C")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x11277D0", Offset = "0x11265D0", Length = "0x2F")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x1127800", Offset = "0x1126600", Length = "0x2F")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x1127830", Offset = "0x1126630", Length = "0x1B")]
	public TweenHeight()
	{
	}
}
