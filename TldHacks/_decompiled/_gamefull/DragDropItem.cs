using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000237")]
public class DragDropItem : MonoBehaviour
{
	[Token(Token = "0x400137E")]
	[FieldOffset(Offset = "0x20")]
	public GearItem m_GearItem;

	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x28")]
	public DecorationItem m_DecorationItem;

	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0x30")]
	public bool m_ForceClickOnStartDrag;

	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x38")]
	protected Transform mTrans;

	[Token(Token = "0x4001382")]
	[FieldOffset(Offset = "0x40")]
	protected Transform mParent;

	[Token(Token = "0x4001383")]
	[FieldOffset(Offset = "0x48")]
	protected Collider mCollider;

	[Token(Token = "0x4001384")]
	[FieldOffset(Offset = "0x50")]
	protected UIButton mButton;

	[Token(Token = "0x4001385")]
	[FieldOffset(Offset = "0x58")]
	protected UIRoot mRoot;

	[Token(Token = "0x4001386")]
	[FieldOffset(Offset = "0x60")]
	protected UIGrid mGrid;

	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x68")]
	protected UITable mTable;

	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x70")]
	protected int mTouchID;

	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x74")]
	protected float mPressTime;

	[Token(Token = "0x400138A")]
	[FieldOffset(Offset = "0x78")]
	protected UIDragScrollView mDragScrollView;

	[Token(Token = "0x400138B")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_OriginalPosition;

	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_IsDragging;

	[Token(Token = "0x6001386")]
	[Address(RVA = "0x66C460", Offset = "0x66B260", Length = "0x1E9")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x66C650", Offset = "0x66B450", Length = "0x53")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6001388")]
	[Address(RVA = "0x66C6B0", Offset = "0x66B4B0", Length = "0x184")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x66C840", Offset = "0x66B640", Length = "0x161")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x66C9B0", Offset = "0x66B7B0", Length = "0x11D")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x600138B")]
	[Address(RVA = "0x66CAD0", Offset = "0x66B8D0", Length = "0xA31")]
	protected virtual void OnDragDropStart()
	{
	}

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x66D510", Offset = "0x66C310", Length = "0x20C")]
	protected virtual void OnDragDropMove(Vector3 delta)
	{
	}

	[Token(Token = "0x600138D")]
	[Address(RVA = "0x66D720", Offset = "0x66C520", Length = "0x78A")]
	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x600138E")]
	[Address(RVA = "0x66DEB0", Offset = "0x66CCB0", Length = "0x8")]
	public bool IsDragging()
	{
		return false;
	}

	[Token(Token = "0x600138F")]
	[Address(RVA = "0x66DEC0", Offset = "0x66CCC0", Length = "0x113")]
	public void TryForceDrop(bool dropOnHovered)
	{
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0x66DFE0", Offset = "0x66CDE0", Length = "0x199")]
	private void MoveWidgetDepth(int amountToMove)
	{
	}

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x66E180", Offset = "0x66CF80", Length = "0x110")]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0x66E2A0", Offset = "0x66D0A0", Length = "0x4A")]
	public DragDropItem()
	{
	}
}
