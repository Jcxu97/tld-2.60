using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UILabel))]
[AddComponentMenu("NGUI/Interaction/Typewriter Effect")]
[Token(Token = "0x200005F")]
public class TypewriterEffect : MonoBehaviour
{
	[Token(Token = "0x2000060")]
	private struct FadeEntry
	{
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x8")]
		public string text;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x10")]
		public float alpha;
	}

	[Token(Token = "0x400038A")]
	public static TypewriterEffect current;

	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x20")]
	public int charsPerSecond;

	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x24")]
	public float fadeInTime;

	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x28")]
	public float delayOnPeriod;

	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x2C")]
	public float delayOnNewLine;

	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView scrollView;

	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x38")]
	public bool keepFullDimensions;

	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x40")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x48")]
	private UILabel mLabel;

	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x50")]
	private string mFullText;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x58")]
	private int mCurrentOffset;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x5C")]
	private float mNextChar;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x60")]
	private bool mReset;

	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x61")]
	private bool mActive;

	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x68")]
	private BetterList<FadeEntry> mFade;

	[Token(Token = "0x17000031")]
	public bool isActive
	{
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7E0420", Offset = "0x7DF220", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xA229B0", Offset = "0xA217B0", Length = "0x2B")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xA229E0", Offset = "0xA217E0", Length = "0x279")]
	public void Finish()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xA22C60", Offset = "0xA21A60", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xA22C70", Offset = "0xA21A70", Length = "0xE57")]
	private void Update()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xA23AD0", Offset = "0xA228D0", Length = "0x1EF")]
	public TypewriterEffect()
	{
	}
}
