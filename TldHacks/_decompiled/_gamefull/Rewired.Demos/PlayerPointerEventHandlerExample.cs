using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C4E")]
public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	[Token(Token = "0x4007D04")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x4007D05")]
	private const int logLength = 10;

	[Token(Token = "0x4007D06")]
	[FieldOffset(Offset = "0x28")]
	private List<string> log;

	[Token(Token = "0x60063AD")]
	[Address(RVA = "0xFD4410", Offset = "0xFD3210", Length = "0x11A")]
	private void Log(string o)
	{
	}

	[Token(Token = "0x60063AE")]
	[Address(RVA = "0xFD4530", Offset = "0xFD3330", Length = "0x29B")]
	private void Update()
	{
	}

	[Token(Token = "0x60063AF")]
	[Address(RVA = "0xFD47D0", Offset = "0xFD35D0", Length = "0x35C")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B0")]
	[Address(RVA = "0xFD4B30", Offset = "0xFD3930", Length = "0x35C")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B1")]
	[Address(RVA = "0xFD4E90", Offset = "0xFD3C90", Length = "0x419")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B2")]
	[Address(RVA = "0xFD52B0", Offset = "0xFD40B0", Length = "0x419")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B3")]
	[Address(RVA = "0xFD56D0", Offset = "0xFD44D0", Length = "0x419")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B4")]
	[Address(RVA = "0xFD5AF0", Offset = "0xFD48F0", Length = "0x35C")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B5")]
	[Address(RVA = "0xFD5E50", Offset = "0xFD4C50", Length = "0x419")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B6")]
	[Address(RVA = "0xFD6270", Offset = "0xFD5070", Length = "0x419")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B7")]
	[Address(RVA = "0xFD6690", Offset = "0xFD5490", Length = "0x419")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60063B8")]
	[Address(RVA = "0xFD6AB0", Offset = "0xFD58B0", Length = "0xB0")]
	private static string GetSourceName(PlayerPointerEventData playerEventData)
	{
		return null;
	}

	[Token(Token = "0x60063B9")]
	[Address(RVA = "0xFD6B70", Offset = "0xFD5970", Length = "0xE3")]
	public PlayerPointerEventHandlerExample()
	{
	}
}
