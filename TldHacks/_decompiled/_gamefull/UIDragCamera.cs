using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Drag Camera")]
[Token(Token = "0x200006E")]
public class UIDragCamera : MonoBehaviour
{
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x20")]
	public UIDraggableCamera draggableCamera;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xA2D000", Offset = "0xA2BE00", Length = "0x171")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xA2D180", Offset = "0xA2BF80", Length = "0x1C4")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xA2D350", Offset = "0xA2C150", Length = "0x1C8")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xA2D520", Offset = "0xA2C320", Length = "0x2E1")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIDragCamera()
	{
	}
}
