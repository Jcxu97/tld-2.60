using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Tween Field of View")]
[Token(Token = "0x20000E3")]
public class TweenFOV : UITweener
{
	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x80")]
	public float from;

	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x84")]
	public float to;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x88")]
	private Camera mCam;

	[Token(Token = "0x170000D9")]
	public Camera cachedCamera
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1126D80", Offset = "0x1125B80", Length = "0x158")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000DA")]
	public float fov
	{
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1126EE0", Offset = "0x1125CE0", Length = "0x7")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1126EF0", Offset = "0x1125CF0", Length = "0x34")]
		set
		{
		}
	}

	[Token(Token = "0x170000DB")]
	public float value
	{
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1126F30", Offset = "0x1125D30", Length = "0x9F")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1126EF0", Offset = "0x1125CF0", Length = "0x34")]
		set
		{
		}
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x1126FD0", Offset = "0x1125DD0", Length = "0x5E")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0x1127030", Offset = "0x1125E30", Length = "0xB1")]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x11270F0", Offset = "0x1125EF0", Length = "0x1E")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x1127110", Offset = "0x1125F10", Length = "0x1E")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x1127130", Offset = "0x1125F30", Length = "0x39")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x1127170", Offset = "0x1125F70", Length = "0x39")]
	private void SetCurrentValueToEnd()
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x11271B0", Offset = "0x1125FB0", Length = "0x1B")]
	public TweenFOV()
	{
	}
}
