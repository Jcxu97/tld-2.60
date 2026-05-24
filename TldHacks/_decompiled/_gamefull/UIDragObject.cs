using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Drag Object")]
[Token(Token = "0x2000075")]
public class UIDragObject : MonoBehaviour
{
	[Token(Token = "0x2000076")]
	public enum DragEffect
	{
		[Token(Token = "0x4000423")]
		None,
		[Token(Token = "0x4000424")]
		Momentum,
		[Token(Token = "0x4000425")]
		MomentumAndSpring
	}

	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x28")]
	public UIPanel panelRegion;

	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 scrollMomentum;

	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x3C")]
	public bool restrictWithinPanel;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x40")]
	public UIRect contentRect;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x48")]
	public DragEffect dragEffect;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x4C")]
	public float momentumAmount;

	[SerializeField]
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x50")]
	protected Vector3 scale;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x5C")]
	private float scrollWheelFactor;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x60")]
	private Plane mPlane;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 mTargetPos;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 mLastPos;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 mMomentum;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 mScroll;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0xA0")]
	private Bounds mBounds;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0xB8")]
	private int mTouchID;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0xBC")]
	private bool mStarted;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0xBD")]
	private bool mPressed;

	[Token(Token = "0x1700003C")]
	public Vector3 dragMovement
	{
		[Token(Token = "0x600041E")]
		[Address(RVA = "0xA32210", Offset = "0xA31010", Length = "0x13")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600041F")]
		[Address(RVA = "0xA32230", Offset = "0xA31030", Length = "0x10")]
		set
		{
		}
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0xA32240", Offset = "0xA31040", Length = "0x480")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xA326D0", Offset = "0xA314D0", Length = "0x8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xA326E0", Offset = "0xA314E0", Length = "0x256")]
	private void FindPanel()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xA32940", Offset = "0xA31740", Length = "0x614")]
	private void UpdateBounds()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xA32F60", Offset = "0xA31D60", Length = "0x5DC")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0xA33540", Offset = "0xA32340", Length = "0x788")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0xA33CD0", Offset = "0xA32AD0", Length = "0x587")]
	private void Move(Vector3 worldDelta)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0xA34260", Offset = "0xA33060", Length = "0x4E2")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0xA34750", Offset = "0xA33550", Length = "0x546")]
	public void CancelMovement()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0xA34CA0", Offset = "0xA33AA0", Length = "0x101")]
	public void CancelSpring()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0xA34DB0", Offset = "0xA33BB0", Length = "0x181")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xA34F40", Offset = "0xA33D40", Length = "0x149")]
	public UIDragObject()
	{
	}
}
