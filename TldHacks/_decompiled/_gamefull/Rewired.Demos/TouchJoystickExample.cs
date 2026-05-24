using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(Image))]
[Token(Token = "0x2000C47")]
public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[Token(Token = "0x4007CD1")]
	[FieldOffset(Offset = "0x20")]
	public bool allowMouseControl;

	[Token(Token = "0x4007CD2")]
	[FieldOffset(Offset = "0x24")]
	public int radius;

	[Token(Token = "0x4007CD3")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 origAnchoredPosition;

	[Token(Token = "0x4007CD4")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 origWorldPosition;

	[Token(Token = "0x4007CD5")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 origScreenResolution;

	[Token(Token = "0x4007CD6")]
	[FieldOffset(Offset = "0x44")]
	private ScreenOrientation origScreenOrientation;

	[NonSerialized]
	[Token(Token = "0x4007CD7")]
	[FieldOffset(Offset = "0x48")]
	private bool hasFinger;

	[NonSerialized]
	[Token(Token = "0x4007CD8")]
	[FieldOffset(Offset = "0x4C")]
	private int lastFingerId;

	[Token(Token = "0x170006AA")]
	[field: Token(Token = "0x4007CD9")]
	[field: FieldOffset(Offset = "0x50")]
	public Vector2 position
	{
		[Token(Token = "0x600637D")]
		[Address(RVA = "0xFCEFF0", Offset = "0xFCDDF0", Length = "0x13")]
		get;
		[Token(Token = "0x600637E")]
		[Address(RVA = "0xFCF010", Offset = "0xFCDE10", Length = "0x5")]
		private set;
	}

	[Token(Token = "0x600637F")]
	[Address(RVA = "0xFCF020", Offset = "0xFCDE20", Length = "0x5D")]
	private void Start()
	{
	}

	[Token(Token = "0x6006380")]
	[Address(RVA = "0xFCF080", Offset = "0xFCDE80", Length = "0x105")]
	private void Update()
	{
	}

	[Token(Token = "0x6006381")]
	[Address(RVA = "0xFCF190", Offset = "0xFCDF90", Length = "0xC2")]
	private void Restart()
	{
	}

	[Token(Token = "0x6006382")]
	[Address(RVA = "0xFCF260", Offset = "0xFCE060", Length = "0x232")]
	private void StoreOrigValues()
	{
	}

	[Token(Token = "0x6006383")]
	[Address(RVA = "0xFCF4A0", Offset = "0xFCE2A0", Length = "0x4E")]
	private void UpdateValue(Vector3 value)
	{
	}

	[Token(Token = "0x6006384")]
	[Address(RVA = "0xFCF4F0", Offset = "0xFCE2F0", Length = "0x47")]
	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6006385")]
	[Address(RVA = "0xFCF540", Offset = "0xFCE340", Length = "0x3C")]
	void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6006386")]
	[Address(RVA = "0xFCF580", Offset = "0xFCE380", Length = "0x205")]
	void IDragHandler.OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6006387")]
	[Address(RVA = "0xFCEFD0", Offset = "0xFCDDD0", Length = "0x12")]
	private static bool IsMousePointerId(int id)
	{
		return false;
	}

	[Token(Token = "0x6006388")]
	[Address(RVA = "0xFCF790", Offset = "0xFCE590", Length = "0x4E")]
	public TouchJoystickExample()
	{
	}
}
