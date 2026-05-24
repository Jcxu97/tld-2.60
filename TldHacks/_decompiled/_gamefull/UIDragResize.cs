using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag-Resize Widget")]
[Token(Token = "0x2000077")]
public class UIDragResize : MonoBehaviour
{
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget target;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x2C")]
	public int minWidth;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x30")]
	public int minHeight;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x34")]
	public int maxWidth;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x38")]
	public int maxHeight;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x3C")]
	private Plane mPlane;

	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 mRayPos;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 mLocalPos;

	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x64")]
	private int mWidth;

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x68")]
	private int mHeight;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x6C")]
	private bool mDragging;

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xA35090", Offset = "0xA33E90", Length = "0x338")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0xA353D0", Offset = "0xA341D0", Length = "0x6DE")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xA35AB0", Offset = "0xA348B0", Length = "0x5")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xA35AC0", Offset = "0xA348C0", Length = "0x66")]
	public UIDragResize()
	{
	}
}
