using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Tween/Tween Width")]
[Token(Token = "0x20000EB")]
public class TweenWidth : UITweener
{
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x80")]
	public int from;

	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x84")]
	public int to;

	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x88")]
	public bool updateTable;

	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x90")]
	private UIWidget mWidget;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x98")]
	private UITable mTable;

	[Token(Token = "0x170000EE")]
	public UIWidget cachedWidget
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x112B3D0", Offset = "0x112A1D0", Length = "0x158")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000EF")]
	public int width
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x112B530", Offset = "0x112A330", Length = "0x20")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x112B560", Offset = "0x112A360", Length = "0x2B")]
		set
		{
		}
	}

	[Token(Token = "0x170000F0")]
	public int value
	{
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x112B530", Offset = "0x112A330", Length = "0x20")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x112B560", Offset = "0x112A360", Length = "0x2B")]
		set
		{
		}
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0x112B590", Offset = "0x112A390", Length = "0x30D")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0x112B8A0", Offset = "0x112A6A0", Length = "0xC1")]
	public static TweenWidth Begin(UIWidget widget, float duration, int width)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x600087B")]
	[Address(RVA = "0x112B970", Offset = "0x112A770", Length = "0x2C")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x600087C")]
	[Address(RVA = "0x112B9A0", Offset = "0x112A7A0", Length = "0x2C")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x112B9D0", Offset = "0x112A7D0", Length = "0x2F")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x600087E")]
	[Address(RVA = "0x112BA00", Offset = "0x112A800", Length = "0x2F")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0x1127830", Offset = "0x1126630", Length = "0x1B")]
	public TweenWidth()
	{
	}
}
