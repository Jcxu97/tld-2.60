using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Stretch")]
[Token(Token = "0x2000126")]
public class UIStretch : MonoBehaviour
{
	[Token(Token = "0x2000127")]
	public enum Style
	{
		[Token(Token = "0x400092D")]
		None,
		[Token(Token = "0x400092E")]
		Horizontal,
		[Token(Token = "0x400092F")]
		Vertical,
		[Token(Token = "0x4000930")]
		Both,
		[Token(Token = "0x4000931")]
		BasedOnHeight,
		[Token(Token = "0x4000932")]
		FillKeepingRatio,
		[Token(Token = "0x4000933")]
		FitInternalKeepingRatio
	}

	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x20")]
	public Camera uiCamera;

	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject container;

	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x30")]
	public Style style;

	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 relativeSize;

	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 initialSize;

	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 borderPadding;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x50")]
	private UIWidget widgetContainer;

	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x58")]
	private Transform mTrans;

	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0x60")]
	private UIWidget mWidget;

	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x68")]
	private UISprite mSprite;

	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x70")]
	private UIPanel mPanel;

	[Token(Token = "0x4000928")]
	[FieldOffset(Offset = "0x78")]
	private UIRoot mRoot;

	[Token(Token = "0x4000929")]
	[FieldOffset(Offset = "0x80")]
	private Animation mAnim;

	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x88")]
	private Rect mRect;

	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x98")]
	private bool mStarted;

	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x5C7EC0", Offset = "0x5C6CC0", Length = "0x3D5")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x5C82A0", Offset = "0x5C70A0", Length = "0x188")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x5C8430", Offset = "0x5C7230", Length = "0x11")]
	private void ScreenSizeChanged()
	{
	}

	[Token(Token = "0x6000AD4")]
	[Address(RVA = "0x5C8450", Offset = "0x5C7250", Length = "0x41A")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AD5")]
	[Address(RVA = "0x5C8870", Offset = "0x5C7670", Length = "0xF81")]
	private void Update()
	{
	}

	[Token(Token = "0x6000AD6")]
	[Address(RVA = "0x5C9800", Offset = "0x5C8600", Length = "0x110")]
	public UIStretch()
	{
	}
}
