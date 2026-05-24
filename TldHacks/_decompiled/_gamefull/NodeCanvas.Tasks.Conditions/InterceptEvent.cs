using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.EventSystems;

namespace NodeCanvas.Tasks.Conditions;

[Category("UGUI")]
[Description("Returns true when the selected event is triggered on the selected agent.\nYou can use this for both GUI and 3D objects.\nPlease make sure that Unity Event Systems are setup correctly")]
[Token(Token = "0x2001198")]
public class InterceptEvent : ConditionTask<Transform>
{
	[Token(Token = "0x4008887")]
	[FieldOffset(Offset = "0x68")]
	public EventTriggerType eventType;

	[Token(Token = "0x17000952")]
	protected override string info
	{
		[Token(Token = "0x6007599")]
		[Address(RVA = "0x1110490", Offset = "0x110F290", Length = "0x111")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600759A")]
	[Address(RVA = "0x11105B0", Offset = "0x110F3B0", Length = "0xED")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x600759B")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600759C")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600759D")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600759E")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600759F")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60075A0")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60075A1")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60075A2")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnDrop(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60075A3")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60075A4")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60075A5")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60075A6")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60075A7")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnMove(AxisEventData eventData)
	{
	}

	[Token(Token = "0x60075A8")]
	[Address(RVA = "0x110A470", Offset = "0x1109270", Length = "0xA")]
	private void OnSubmit(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60075A9")]
	[Address(RVA = "0x11106A0", Offset = "0x110F4A0", Length = "0x44")]
	public InterceptEvent()
	{
	}
}
