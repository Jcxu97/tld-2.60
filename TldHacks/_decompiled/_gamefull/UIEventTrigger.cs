using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Event Trigger")]
[Token(Token = "0x2000079")]
public class UIEventTrigger : MonoBehaviour
{
	[Token(Token = "0x4000438")]
	public static UIEventTrigger current;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x20")]
	public List<EventDelegate> onHoverOver;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x28")]
	public List<EventDelegate> onHoverOut;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x30")]
	public List<EventDelegate> onPress;

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x38")]
	public List<EventDelegate> onRelease;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x40")]
	public List<EventDelegate> onSelect;

	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x48")]
	public List<EventDelegate> onDeselect;

	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x50")]
	public List<EventDelegate> onClick;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x58")]
	public List<EventDelegate> onDoubleClick;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x60")]
	public List<EventDelegate> onDragStart;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x68")]
	public List<EventDelegate> onDragEnd;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x70")]
	public List<EventDelegate> onDragOver;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x78")]
	public List<EventDelegate> onDragOut;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x80")]
	public List<EventDelegate> onDrag;

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xA367A0", Offset = "0xA355A0", Length = "0x22E")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0xA369D0", Offset = "0xA357D0", Length = "0x22E")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xA36C00", Offset = "0xA35A00", Length = "0x22E")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xA36E30", Offset = "0xA35C30", Length = "0x209")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xA37040", Offset = "0xA35E40", Length = "0x209")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xA37250", Offset = "0xA36050", Length = "0x209")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xA37460", Offset = "0xA36260", Length = "0x209")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xA37670", Offset = "0xA36470", Length = "0x209")]
	private void OnDragOver(GameObject go)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xA37880", Offset = "0xA36680", Length = "0x209")]
	private void OnDragOut(GameObject go)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xA37A90", Offset = "0xA36890", Length = "0x209")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xA37CA0", Offset = "0xA36AA0", Length = "0x63F")]
	public UIEventTrigger()
	{
	}
}
