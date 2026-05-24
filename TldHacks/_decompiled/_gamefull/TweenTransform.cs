using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Transform")]
[Token(Token = "0x20000E9")]
public class TweenTransform : UITweener
{
	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x80")]
	public Transform from;

	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x88")]
	public Transform to;

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x90")]
	public bool parentWhenFinished;

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x98")]
	private Transform mTrans;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 mPos;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0xAC")]
	private Quaternion mRot;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 mScale;

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x1129910", Offset = "0x1128710", Length = "0x10DB")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x112A9F0", Offset = "0x11297F0", Length = "0x14E")]
	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x112AB40", Offset = "0x1129940", Length = "0x153")]
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x11286D0", Offset = "0x11274D0", Length = "0x7")]
	public TweenTransform()
	{
	}
}
