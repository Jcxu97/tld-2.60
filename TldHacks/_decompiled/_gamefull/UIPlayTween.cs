using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Tween")]
[Token(Token = "0x2000088")]
public class UIPlayTween : MonoBehaviour
{
	[Token(Token = "0x40004B7")]
	public static UIPlayTween current;

	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject tweenTarget;

	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x28")]
	public int tweenGroup;

	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x2C")]
	public Trigger trigger;

	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x30")]
	public Direction playDirection;

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x34")]
	public bool resetOnPlay;

	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x35")]
	public bool resetIfDisabled;

	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x38")]
	public EnableCondition ifDisabledOnPlay;

	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x3C")]
	public DisableCondition disableWhenFinished;

	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x40")]
	public bool includeChildren;

	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x48")]
	public List<EventDelegate> onFinished;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x50")]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x58")]
	private string callWhenFinished;

	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x60")]
	private UITweener[] mTweens;

	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x68")]
	private bool mStarted;

	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x6C")]
	private int mActive;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x70")]
	private bool mActivated;

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xBDBE20", Offset = "0xBDAC20", Length = "0x1B9")]
	private void Awake()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xBDBFE0", Offset = "0xBDADE0", Length = "0x131")]
	private void Start()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xBDC120", Offset = "0xBDAF20", Length = "0x45F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xBDC580", Offset = "0xBDB380", Length = "0x171")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xBDC700", Offset = "0xBDB500", Length = "0xBE")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xBDC7C0", Offset = "0xBDB5C0", Length = "0x101")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xBDC8D0", Offset = "0xBDB6D0", Length = "0xB3")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xBDC990", Offset = "0xBDB790", Length = "0x101")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xBDCAA0", Offset = "0xBDB8A0", Length = "0xAF")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xBDCB50", Offset = "0xBDB950", Length = "0xAF")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xBDCC00", Offset = "0xBDBA00", Length = "0x101")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xBDCD10", Offset = "0xBDBB10", Length = "0x292")]
	private void OnToggle()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xBDCFB0", Offset = "0xBDBDB0", Length = "0x131")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xBDD0F0", Offset = "0xBDBEF0", Length = "0x442")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xBDD540", Offset = "0xBDC340", Length = "0x333")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xBDD880", Offset = "0xBDC680", Length = "0xF2")]
	public UIPlayTween()
	{
	}
}
