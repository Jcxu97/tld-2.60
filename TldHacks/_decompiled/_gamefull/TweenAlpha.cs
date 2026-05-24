using System;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Alpha")]
[Token(Token = "0x20000E1")]
public class TweenAlpha : UITweener
{
	[Range(0f, 1f)]
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x80")]
	public float from;

	[Range(0f, 1f)]
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x84")]
	public float to;

	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x88")]
	private bool mCached;

	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x90")]
	private UIRect mRect;

	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x98")]
	private Material mMat;

	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0xA0")]
	private SpriteRenderer mSr;

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x170000D5")]
	public float alpha
	{
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1125130", Offset = "0x1123F30", Length = "0x7")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1125140", Offset = "0x1123F40", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x170000D6")]
	public float value
	{
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1125560", Offset = "0x1124360", Length = "0x31F")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1125880", Offset = "0x1124680", Length = "0x425")]
		set
		{
		}
	}

	[Token(Token = "0x600080A")]
	[Address(RVA = "0x1125150", Offset = "0x1123F50", Length = "0x403")]
	private void Cache()
	{
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0x1125CB0", Offset = "0x1124AB0", Length = "0x44")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x1125D00", Offset = "0x1124B00", Length = "0xB1")]
	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		return null;
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x1125DC0", Offset = "0x1124BC0", Length = "0x1E")]
	public override void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x1125DE0", Offset = "0x1124BE0", Length = "0x1E")]
	public override void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x1125E00", Offset = "0x1124C00", Length = "0x1B")]
	public TweenAlpha()
	{
	}
}
