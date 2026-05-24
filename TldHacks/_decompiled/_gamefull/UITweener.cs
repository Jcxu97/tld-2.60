using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000EC")]
public abstract class UITweener : MonoBehaviour
{
	[Token(Token = "0x20000ED")]
	public enum Method
	{
		[Token(Token = "0x4000759")]
		Linear,
		[Token(Token = "0x400075A")]
		EaseIn,
		[Token(Token = "0x400075B")]
		EaseOut,
		[Token(Token = "0x400075C")]
		EaseInOut,
		[Token(Token = "0x400075D")]
		BounceIn,
		[Token(Token = "0x400075E")]
		BounceOut
	}

	[Token(Token = "0x20000EE")]
	public enum Style
	{
		[Token(Token = "0x4000760")]
		Once,
		[Token(Token = "0x4000761")]
		Loop,
		[Token(Token = "0x4000762")]
		PingPong
	}

	[Token(Token = "0x4000745")]
	public static UITweener current;

	[HideInInspector]
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x20")]
	public Method method;

	[HideInInspector]
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x24")]
	public Style style;

	[HideInInspector]
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve animationCurve;

	[HideInInspector]
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x30")]
	public bool ignoreTimeScale;

	[HideInInspector]
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x34")]
	public float delay;

	[HideInInspector]
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x38")]
	public float duration;

	[HideInInspector]
	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x3C")]
	public bool steeperCurves;

	[HideInInspector]
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x40")]
	public int tweenGroup;

	[HideInInspector]
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x44")]
	public bool doNotResetOnDisable;

	[HideInInspector]
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x48")]
	public List<EventDelegate> onFinished;

	[HideInInspector]
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x50")]
	public GameObject eventReceiver;

	[HideInInspector]
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x58")]
	public string callWhenFinished;

	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x60")]
	private bool mStarted;

	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x64")]
	private float mStartTime;

	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x68")]
	private float mDuration;

	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x6C")]
	private float mAmountPerDelta;

	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x70")]
	private float mFactor;

	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x78")]
	private List<EventDelegate> mTemp;

	[Token(Token = "0x170000F1")]
	public float amountPerDelta
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x112BA30", Offset = "0x112A830", Length = "0x63")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170000F2")]
	public float tweenFactor
	{
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x561BD0", Offset = "0x5609D0", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x112BAA0", Offset = "0x112A8A0", Length = "0x21")]
		set
		{
		}
	}

	[Token(Token = "0x170000F3")]
	public Direction direction
	{
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x112BAD0", Offset = "0x112A8D0", Length = "0x6B")]
		get
		{
			return default(Direction);
		}
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0x112BB40", Offset = "0x112A940", Length = "0x3E")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0x112BB80", Offset = "0x112A980", Length = "0x7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0x112BB90", Offset = "0x112A990", Length = "0x77C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0x112C310", Offset = "0x112B110", Length = "0xF0")]
	public void SetOnFinished(EventDelegate.Callback del)
	{
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0x112C400", Offset = "0x112B200", Length = "0xB8")]
	public void SetOnFinished(EventDelegate del)
	{
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0x112C4C0", Offset = "0x112B2C0", Length = "0x9B")]
	public void AddOnFinished(EventDelegate.Callback del)
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0x112C560", Offset = "0x112B360", Length = "0xB4")]
	public void AddOnFinished(EventDelegate del)
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x112C620", Offset = "0x112B420", Length = "0x6C")]
	public void RemoveOnFinished(EventDelegate del)
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0x112C690", Offset = "0x112B490", Length = "0xB")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x112C6A0", Offset = "0x112B4A0", Length = "0x208")]
	public void Sample(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0xD144D0", Offset = "0xD132D0", Length = "0x9A")]
	private float BounceLogic(float val)
	{
		return 0f;
	}

	[Obsolete("Use PlayForward() instead")]
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x112C8B0", Offset = "0x112B6B0", Length = "0x8C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x112C8B0", Offset = "0x112B6B0", Length = "0x8C")]
	public void PlayForward()
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x112C940", Offset = "0x112B740", Length = "0x93")]
	public void PlayReverse()
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x112C9E0", Offset = "0x112B7E0", Length = "0x9C")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x112CA80", Offset = "0x112B880", Length = "0x7E")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x112CB00", Offset = "0x112B900", Length = "0x49")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6000895")]
	protected abstract void OnUpdate(float factor, bool isFinished);

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x1A436E0", Offset = "0x1A424E0", Length = "0x8A2")]
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return null;
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SetStartToCurrentValue()
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SetEndToCurrentValue()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x112CB50", Offset = "0x112B950", Length = "0x22E")]
	protected UITweener()
	{
	}
}
