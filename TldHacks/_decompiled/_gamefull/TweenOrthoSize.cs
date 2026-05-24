using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Tween Orthographic Size")]
[Token(Token = "0x20000E5")]
public class TweenOrthoSize : UITweener
{
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x80")]
	public float from;

	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x84")]
	public float to;

	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x88")]
	private Camera mCam;

	[Token(Token = "0x170000DF")]
	public Camera cachedCamera
	{
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x1127850", Offset = "0x1126650", Length = "0x158")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000E0")]
	public float orthoSize
	{
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x11279B0", Offset = "0x11267B0", Length = "0x7")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x11279C0", Offset = "0x11267C0", Length = "0x34")]
		set
		{
		}
	}

	[Token(Token = "0x170000E1")]
	public float value
	{
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1127A00", Offset = "0x1126800", Length = "0x9F")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x11279C0", Offset = "0x11267C0", Length = "0x34")]
		set
		{
		}
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x1127AA0", Offset = "0x11268A0", Length = "0x5E")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x1127B00", Offset = "0x1126900", Length = "0xB1")]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0x1127BC0", Offset = "0x11269C0", Length = "0x1E")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0x1127BE0", Offset = "0x11269E0", Length = "0x1E")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x1125E00", Offset = "0x1124C00", Length = "0x1B")]
	public TweenOrthoSize()
	{
	}
}
