using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
[Token(Token = "0x2000074")]
public class UIDraggableCamera : MonoBehaviour
{
	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x20")]
	public Transform rootForBounds;

	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 scale;

	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x30")]
	public float scrollWheelFactor;

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x34")]
	public UIDragObject.DragEffect dragEffect;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x38")]
	public bool smoothDragStart;

	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x3C")]
	public float momentumAmount;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x40")]
	private Camera mCam;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x48")]
	private Transform mTrans;

	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x50")]
	private bool mPressed;

	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 mMomentum;

	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x5C")]
	private Bounds mBounds;

	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x74")]
	private float mScroll;

	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x78")]
	private UIRoot mRoot;

	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x80")]
	private bool mDragStarted;

	[Token(Token = "0x1700003B")]
	public Vector2 currentMomentum
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xA30700", Offset = "0xA2F500", Length = "0x13")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xA30720", Offset = "0xA2F520", Length = "0x5")]
		set
		{
		}
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xA30730", Offset = "0xA2F530", Length = "0x2F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xA30A20", Offset = "0xA2F820", Length = "0x74F")]
	private Vector3 CalculateConstrainOffset()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xA31170", Offset = "0xA2FF70", Length = "0x370")]
	public bool ConstrainToBounds(bool immediate)
	{
		return false;
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xA314F0", Offset = "0xA302F0", Length = "0x242")]
	public void Press(bool isPressed)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xA31740", Offset = "0xA30540", Length = "0x3DD")]
	public void Drag(Vector2 delta)
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xA31B20", Offset = "0xA30920", Length = "0x150")]
	public void Scroll(float delta)
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xA31C80", Offset = "0xA30A80", Length = "0x496")]
	private void Update()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xA32120", Offset = "0xA30F20", Length = "0xE1")]
	public UIDraggableCamera()
	{
	}
}
