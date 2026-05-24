using System;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Scale")]
[Token(Token = "0x20000E8")]
public class TweenScale : UITweener
{
	[Token(Token = "0x4000731")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 from;

	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 to;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x98")]
	public bool updateTable;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0xA0")]
	private Transform mTrans;

	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0xA8")]
	private UITable mTable;

	[Token(Token = "0x170000E8")]
	public Transform cachedTransform
	{
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1129050", Offset = "0x1127E50", Length = "0x138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E9")]
	public Vector3 value
	{
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1129190", Offset = "0x1127F90", Length = "0xD9")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1129270", Offset = "0x1128070", Length = "0xB7")]
		set
		{
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000EA")]
	public Vector3 scale
	{
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1129330", Offset = "0x1128130", Length = "0x2D")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1129360", Offset = "0x1128160", Length = "0x27")]
		set
		{
		}
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x1129390", Offset = "0x1128190", Length = "0x30D")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x11296A0", Offset = "0x11284A0", Length = "0xD0")]
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x1129780", Offset = "0x1128580", Length = "0x34")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x11297C0", Offset = "0x11285C0", Length = "0x34")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x1129800", Offset = "0x1128600", Length = "0x2E")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x1129830", Offset = "0x1128630", Length = "0x2E")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x1129860", Offset = "0x1128660", Length = "0xA5")]
	public TweenScale()
	{
	}
}
