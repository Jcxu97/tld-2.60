using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(Image))]
[Token(Token = "0x2000C46")]
public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[Token(Token = "0x4007CCF")]
	[FieldOffset(Offset = "0x20")]
	public bool allowMouseControl;

	[Token(Token = "0x170006A9")]
	[field: Token(Token = "0x4007CD0")]
	[field: FieldOffset(Offset = "0x21")]
	public bool isPressed
	{
		[Token(Token = "0x6006375")]
		[Address(RVA = "0x5327B0", Offset = "0x5315B0", Length = "0x5")]
		get;
		[Token(Token = "0x6006376")]
		[Address(RVA = "0x5D13B0", Offset = "0x5D01B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6006377")]
	[Address(RVA = "0xFCEEE0", Offset = "0xFCDCE0", Length = "0x54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006378")]
	[Address(RVA = "0xFCEF40", Offset = "0xFCDD40", Length = "0x5")]
	private void Restart()
	{
	}

	[Token(Token = "0x6006379")]
	[Address(RVA = "0xFCEF50", Offset = "0xFCDD50", Length = "0x33")]
	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600637A")]
	[Address(RVA = "0xFCEF90", Offset = "0xFCDD90", Length = "0x33")]
	void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600637B")]
	[Address(RVA = "0xFCEFD0", Offset = "0xFCDDD0", Length = "0x12")]
	private static bool IsMousePointerId(int id)
	{
		return false;
	}

	[Token(Token = "0x600637C")]
	[Address(RVA = "0x6A2880", Offset = "0x6A1680", Length = "0x47")]
	public TouchButtonExample()
	{
	}
}
