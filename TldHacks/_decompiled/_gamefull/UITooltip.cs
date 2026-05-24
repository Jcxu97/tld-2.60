using System;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Tooltip")]
[Token(Token = "0x200012C")]
public class UITooltip : MonoBehaviour
{
	[Token(Token = "0x400094A")]
	protected static UITooltip mInstance;

	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x20")]
	public Camera uiCamera;

	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel text;

	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite background;

	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x38")]
	public float appearSpeed;

	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x3C")]
	public bool scalingTransitions;

	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x40")]
	protected GameObject mHover;

	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x48")]
	protected Transform mTrans;

	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x50")]
	protected float mTarget;

	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x54")]
	protected float mCurrent;

	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 mPos;

	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x64")]
	protected Vector3 mSize;

	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x70")]
	protected UIWidget[] mWidgets;

	[Token(Token = "0x1700019F")]
	public static bool isVisible
	{
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x5CCCC0", Offset = "0x5CBAC0", Length = "0x111")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x5CCDE0", Offset = "0x5CBBE0", Length = "0x97")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x5CCE80", Offset = "0x5CBC80", Length = "0x96")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x5CCF20", Offset = "0x5CBD20", Length = "0x30E")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x5CD230", Offset = "0x5CC030", Length = "0x577")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x5CD7B0", Offset = "0x5CC5B0", Length = "0x158")]
	protected virtual void SetAlpha(float val)
	{
	}

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x5CD910", Offset = "0x5CC710", Length = "0xB57")]
	protected virtual void SetText(string tooltipText)
	{
	}

	[Obsolete("Use UITooltip.Show instead")]
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x5CE470", Offset = "0x5CD270", Length = "0x116")]
	public static void ShowText(string text)
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x5CE590", Offset = "0x5CD390", Length = "0x116")]
	public static void Show(string text)
	{
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x5CE6B0", Offset = "0x5CD4B0", Length = "0x15D")]
	public static void Hide()
	{
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x5CE810", Offset = "0x5CD610", Length = "0x93")]
	public UITooltip()
	{
	}
}
