using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Event Listener")]
[Token(Token = "0x20000CA")]
public class UIEventListener : MonoBehaviour
{
	[Token(Token = "0x20000CB")]
	public delegate void VoidDelegate(GameObject go);

	[Token(Token = "0x20000CC")]
	public delegate void BoolDelegate(GameObject go, bool state);

	[Token(Token = "0x20000CD")]
	public delegate void FloatDelegate(GameObject go, float delta);

	[Token(Token = "0x20000CE")]
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	[Token(Token = "0x20000CF")]
	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	[Token(Token = "0x20000D0")]
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x20")]
	public object parameter;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x28")]
	public VoidDelegate onSubmit;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x30")]
	public VoidDelegate onClick;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x38")]
	public VoidDelegate onDoubleClick;

	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x40")]
	public BoolDelegate onHover;

	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x48")]
	public BoolDelegate onPress;

	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x50")]
	public BoolDelegate onSelect;

	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x58")]
	public FloatDelegate onScroll;

	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x60")]
	public VoidDelegate onDragStart;

	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x68")]
	public VectorDelegate onDrag;

	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x70")]
	public VoidDelegate onDragOver;

	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x78")]
	public VoidDelegate onDragOut;

	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x80")]
	public VoidDelegate onDragEnd;

	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x88")]
	public ObjectDelegate onDrop;

	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x90")]
	public KeyCodeDelegate onKey;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x98")]
	public BoolDelegate onTooltip;

	[Token(Token = "0x6000740")]
	[Address(RVA = "0xFA1410", Offset = "0xFA0210", Length = "0x33")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0xFA1450", Offset = "0xFA0250", Length = "0x33")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0xFA1490", Offset = "0xFA0290", Length = "0x33")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0xFA14D0", Offset = "0xFA02D0", Length = "0x3A")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0xFA1510", Offset = "0xFA0310", Length = "0x3A")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0xFA1550", Offset = "0xFA0350", Length = "0x3A")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0xFA1590", Offset = "0xFA0390", Length = "0x3A")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0xFA15D0", Offset = "0xFA03D0", Length = "0x33")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0xFA1610", Offset = "0xFA0410", Length = "0x3E")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0xFA1650", Offset = "0xFA0450", Length = "0x33")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0xFA1690", Offset = "0xFA0490", Length = "0x33")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0xFA16D0", Offset = "0xFA04D0", Length = "0x36")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0xFA1710", Offset = "0xFA0510", Length = "0x3C")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0xFA1750", Offset = "0xFA0550", Length = "0x3B")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0xFA1790", Offset = "0xFA0590", Length = "0x3D")]
	private void OnTooltip(bool show)
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0xFA17D0", Offset = "0xFA05D0", Length = "0x11E")]
	public static UIEventListener Get(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIEventListener()
	{
	}
}
