using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[AddComponentMenu("NGUI/Tween/Tween Volume")]
[Token(Token = "0x20000EA")]
public class TweenVolume : UITweener
{
	[Range(0f, 1f)]
	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x80")]
	public float from;

	[Range(0f, 1f)]
	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x84")]
	public float to;

	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x88")]
	private AudioSource mSource;

	[Token(Token = "0x170000EB")]
	public AudioSource audioSource
	{
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x112ACA0", Offset = "0x1129AA0", Length = "0x355")]
		get
		{
			return null;
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000EC")]
	public float volume
	{
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x112B000", Offset = "0x1129E00", Length = "0x7")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x112B010", Offset = "0x1129E10", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x170000ED")]
	public float value
	{
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x112B020", Offset = "0x1129E20", Length = "0xF8")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x112B120", Offset = "0x1129F20", Length = "0xFC")]
		set
		{
		}
	}

	[Token(Token = "0x600086F")]
	[Address(RVA = "0x112B220", Offset = "0x112A020", Length = "0xDD")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0x112B300", Offset = "0x112A100", Length = "0x86")]
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	[Token(Token = "0x6000871")]
	[Address(RVA = "0x112B390", Offset = "0x112A190", Length = "0x1E")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0x112B3B0", Offset = "0x112A1B0", Length = "0x1E")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0x1125E00", Offset = "0x1124C00", Length = "0x1B")]
	public TweenVolume()
	{
	}
}
