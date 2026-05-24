using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Toggle")]
[Token(Token = "0x20000A1")]
public class UIToggle : UIWidgetContainer
{
	[Token(Token = "0x20000A2")]
	public delegate bool Validate(bool choice);

	[Token(Token = "0x400056F")]
	public static BetterList<UIToggle> list;

	[Token(Token = "0x4000570")]
	public static UIToggle current;

	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x20")]
	public int group;

	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget activeSprite;

	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget inactiveSprite;

	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0x38")]
	public Animation activeAnimation;

	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x40")]
	public Animator animator;

	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x48")]
	public bool startsActive;

	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x49")]
	public bool instantTween;

	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x4A")]
	public bool optionCanBeNone;

	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x50")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x58")]
	public Validate validator;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x60")]
	private UISprite checkSprite;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x68")]
	private Animation checkAnimation;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x70")]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x78")]
	private string functionName;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x80")]
	private bool startsChecked;

	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x81")]
	private bool mIsActive;

	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x82")]
	private bool mStarted;

	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x84")]
	private float activeSpriteAlpha;

	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x88")]
	private float inactiveSpriteAlpha;

	[Token(Token = "0x17000067")]
	public bool value
	{
		[Token(Token = "0x600055C")]
		[Address(RVA = "0xBF1500", Offset = "0xBF0300", Length = "0x16")]
		get
		{
			return false;
		}
		[Token(Token = "0x600055D")]
		[Address(RVA = "0xBF1520", Offset = "0xBF0320", Length = "0x2F")]
		set
		{
		}
	}

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x17000068")]
	public bool isChecked
	{
		[Token(Token = "0x600055E")]
		[Address(RVA = "0xBF1500", Offset = "0xBF0300", Length = "0x16")]
		get
		{
			return false;
		}
		[Token(Token = "0x600055F")]
		[Address(RVA = "0xBF1520", Offset = "0xBF0320", Length = "0x2F")]
		set
		{
		}
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0xBF1550", Offset = "0xBF0350", Length = "0x1B0")]
	public static UIToggle GetActiveToggle(int group)
	{
		return null;
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0xBF1710", Offset = "0xBF0510", Length = "0x82")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0xBF17A0", Offset = "0xBF05A0", Length = "0x82")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0xBF1830", Offset = "0xBF0630", Length = "0x1AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0xBF19E0", Offset = "0xBF07E0", Length = "0x6CA")]
	private void Start()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0xBF20B0", Offset = "0xBF0EB0", Length = "0xEF")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0xBF21A0", Offset = "0xBF0FA0", Length = "0xBE5")]
	public void Set(bool state)
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0xBF2D90", Offset = "0xBF1B90", Length = "0x163")]
	public UIToggle()
	{
	}
}
