using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Active Animation")]
[Token(Token = "0x20000A8")]
public class ActiveAnimation : MonoBehaviour
{
	[Token(Token = "0x4000597")]
	public static ActiveAnimation current;

	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x20")]
	public List<EventDelegate> onFinished;

	[HideInInspector]
	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x28")]
	public GameObject eventReceiver;

	[HideInInspector]
	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x30")]
	public string callWhenFinished;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x38")]
	private Animation mAnim;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x40")]
	private Direction mLastDirection;

	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x44")]
	private Direction mDisableDirection;

	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x48")]
	private bool mNotify;

	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x50")]
	private Animator mAnimator;

	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x58")]
	private string mClip;

	[Token(Token = "0x17000069")]
	private float playbackTime
	{
		[Token(Token = "0x6000583")]
		[Address(RVA = "0xDDEE70", Offset = "0xDDDC70", Length = "0x51")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700006A")]
	public bool isPlaying
	{
		[Token(Token = "0x6000584")]
		[Address(RVA = "0xDDEED0", Offset = "0xDDDCD0", Length = "0x52D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0xDDF400", Offset = "0xDDE200", Length = "0x588")]
	public void Finish()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0xDDF990", Offset = "0xDDE790", Length = "0x4F9")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0xDDFE90", Offset = "0xDDEC90", Length = "0x1B9")]
	private void Start()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0xDE0050", Offset = "0xDDEE50", Length = "0xA9D")]
	private void Update()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0xDE0AF0", Offset = "0xDDF8F0", Length = "0xA11")]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0xDE1510", Offset = "0xDE0310", Length = "0x5EF")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0xDE1B00", Offset = "0xDE0900", Length = "0x1C")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return null;
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0xDE1B20", Offset = "0xDE0920", Length = "0x21")]
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return null;
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0xDE1B50", Offset = "0xDE0950", Length = "0x5DF")]
	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0xDE2130", Offset = "0xDE0F30", Length = "0x15C")]
	public ActiveAnimation()
	{
	}
}
