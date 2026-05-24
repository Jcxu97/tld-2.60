using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag Scroll View")]
[Token(Token = "0x2000078")]
public class UIDragScrollView : MonoBehaviour
{
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView scrollView;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x28")]
	private UIScrollView draggablePanel;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x30")]
	private Transform mTrans;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x38")]
	private UIScrollView mScroll;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x40")]
	private bool mAutoFind;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x41")]
	private bool mStarted;

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xA35B30", Offset = "0xA34930", Length = "0x332")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0xA35E70", Offset = "0xA34C70", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0xA35E80", Offset = "0xA34C80", Length = "0x3C9")]
	private void FindScrollView()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0xA36250", Offset = "0xA35050", Length = "0x2F5")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0xA36550", Offset = "0xA35350", Length = "0x113")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xA36670", Offset = "0xA35470", Length = "0x124")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIDragScrollView()
	{
	}
}
