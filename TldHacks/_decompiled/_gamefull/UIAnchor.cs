using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Anchor")]
[Token(Token = "0x20000F1")]
public class UIAnchor : MonoBehaviour
{
	[Token(Token = "0x20000F2")]
	public enum Side
	{
		[Token(Token = "0x4000787")]
		BottomLeft,
		[Token(Token = "0x4000788")]
		Left,
		[Token(Token = "0x4000789")]
		TopLeft,
		[Token(Token = "0x400078A")]
		Top,
		[Token(Token = "0x400078B")]
		TopRight,
		[Token(Token = "0x400078C")]
		Right,
		[Token(Token = "0x400078D")]
		BottomRight,
		[Token(Token = "0x400078E")]
		Bottom,
		[Token(Token = "0x400078F")]
		Center
	}

	[Token(Token = "0x4000773")]
	public static float m_UI_Height;

	[Token(Token = "0x4000774")]
	public static float m_UI_Width;

	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x20")]
	public Camera uiCamera;

	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x28")]
	public GameObject container;

	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x30")]
	public Side side;

	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 relativeOffset;

	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 pixelOffset;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x48")]
	private UIWidget widgetContainer;

	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x50")]
	private Transform mTrans;

	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x58")]
	private Animation mAnim;

	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x60")]
	private Rect mRect;

	[Token(Token = "0x400077E")]
	[FieldOffset(Offset = "0x70")]
	private UIRoot mRoot;

	[Token(Token = "0x400077F")]
	[FieldOffset(Offset = "0x78")]
	private bool mStarted;

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x79")]
	private bool hasStretchComponent;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x80")]
	private UIWidget m_UIWidget;

	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x88")]
	private UIPanel m_UIPanel;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_PreviousLossyScale;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 m_PreviousPosition;

	[Token(Token = "0x4000785")]
	[FieldOffset(Offset = "0xA8")]
	private Quaternion m_PreviousRotation;

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x112FC80", Offset = "0x112EA80", Length = "0x348")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x112FFD0", Offset = "0x112EDD0", Length = "0x188")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x1130160", Offset = "0x112EF60", Length = "0xE")]
	private void ScreenSizeChanged()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x1130170", Offset = "0x112EF70", Length = "0x79D")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x1130910", Offset = "0x112F710", Length = "0x312")]
	private bool HasPositionChanged()
	{
		return false;
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x1130C30", Offset = "0x112FA30", Length = "0x242")]
	private void UpdatePreviousPosition()
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x1130E80", Offset = "0x112FC80", Length = "0x10F")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x1130F90", Offset = "0x112FD90", Length = "0xF36")]
	private void ApplyUpdatedPosition()
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x1131ED0", Offset = "0x1130CD0", Length = "0x192")]
	public UIAnchor()
	{
	}
}
