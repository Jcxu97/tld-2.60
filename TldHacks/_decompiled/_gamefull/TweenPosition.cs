using System;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Position")]
[Token(Token = "0x20000E6")]
public class TweenPosition : UITweener
{
	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 from;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 to;

	[HideInInspector]
	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x98")]
	public bool worldSpace;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0xA0")]
	private Transform mTrans;

	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0xA8")]
	private UIRect mRect;

	[Token(Token = "0x170000E2")]
	public Transform cachedTransform
	{
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1127C00", Offset = "0x1126A00", Length = "0x138")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000E3")]
	public Vector3 position
	{
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1127D40", Offset = "0x1126B40", Length = "0x2D")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1127D70", Offset = "0x1126B70", Length = "0x27")]
		set
		{
		}
	}

	[Token(Token = "0x170000E4")]
	public Vector3 value
	{
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1127DA0", Offset = "0x1126BA0", Length = "0x182")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1127F30", Offset = "0x1126D30", Length = "0x39A")]
		set
		{
		}
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x11282D0", Offset = "0x11270D0", Length = "0x8D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0x1128360", Offset = "0x1127160", Length = "0xBD")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0x1128420", Offset = "0x1127220", Length = "0xD0")]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x1128500", Offset = "0x1127300", Length = "0xE9")]
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x11285F0", Offset = "0x11273F0", Length = "0x34")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x1128630", Offset = "0x1127430", Length = "0x34")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x1128670", Offset = "0x1127470", Length = "0x2E")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x11286A0", Offset = "0x11274A0", Length = "0x2E")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x11286D0", Offset = "0x11274D0", Length = "0x7")]
	public TweenPosition()
	{
	}
}
