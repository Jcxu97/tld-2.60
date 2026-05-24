using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Forward Events (Legacy)")]
[Token(Token = "0x200007A")]
public class UIForwardEvents : MonoBehaviour
{
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x28")]
	public bool onHover;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x29")]
	public bool onPress;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x2A")]
	public bool onClick;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x2B")]
	public bool onDoubleClick;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x2C")]
	public bool onSelect;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x2D")]
	public bool onDrag;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x2E")]
	public bool onDrop;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x2F")]
	public bool onSubmit;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x30")]
	public bool onScroll;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xA382E0", Offset = "0xA370E0", Length = "0x137")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xA38420", Offset = "0xA37220", Length = "0x137")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xA38560", Offset = "0xA37360", Length = "0x112")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xA38680", Offset = "0xA37480", Length = "0x112")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xA387A0", Offset = "0xA375A0", Length = "0x137")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xA388E0", Offset = "0xA376E0", Length = "0x14C")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0xA38A30", Offset = "0xA37830", Length = "0x11E")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0xA38B50", Offset = "0xA37950", Length = "0x112")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xA38C70", Offset = "0xA37A70", Length = "0x139")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIForwardEvents()
	{
	}
}
