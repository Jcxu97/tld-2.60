using System;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Rotation")]
[Token(Token = "0x20000E7")]
public class TweenRotation : UITweener
{
	[Token(Token = "0x400072D")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 from;

	[Token(Token = "0x400072E")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 to;

	[Token(Token = "0x400072F")]
	[FieldOffset(Offset = "0x98")]
	public bool quaternionLerp;

	[Token(Token = "0x4000730")]
	[FieldOffset(Offset = "0xA0")]
	private Transform mTrans;

	[Token(Token = "0x170000E5")]
	public Transform cachedTransform
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x11286E0", Offset = "0x11274E0", Length = "0x138")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000E6")]
	public Quaternion rotation
	{
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1128820", Offset = "0x1127620", Length = "0x25")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1128850", Offset = "0x1127650", Length = "0x1E")]
		set
		{
		}
	}

	[Token(Token = "0x170000E7")]
	public Quaternion value
	{
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1128870", Offset = "0x1127670", Length = "0xCD")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1128940", Offset = "0x1127740", Length = "0xAE")]
		set
		{
		}
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x11289F0", Offset = "0x11277F0", Length = "0x318")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x1128D10", Offset = "0x1127B10", Length = "0xF8")]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x1128E10", Offset = "0x1127C10", Length = "0x4B")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1128E60", Offset = "0x1127C60", Length = "0x4B")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1128EB0", Offset = "0x1127CB0", Length = "0xCD")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x1128F80", Offset = "0x1127D80", Length = "0xCD")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x11286D0", Offset = "0x11274D0", Length = "0x7")]
	public TweenRotation()
	{
	}
}
