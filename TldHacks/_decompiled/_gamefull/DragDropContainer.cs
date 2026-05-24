using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000236")]
public class DragDropContainer : MonoBehaviour
{
	[Tooltip("Leave empty if you don't want a hover sprite")]
	[Token(Token = "0x400137A")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_HoverSprite;

	[Token(Token = "0x400137B")]
	[FieldOffset(Offset = "0x28")]
	public float m_HoverScale;

	[Token(Token = "0x400137C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HoverFadeTime;

	[Token(Token = "0x400137D")]
	[FieldOffset(Offset = "0x30")]
	public EventDelegate m_Action;

	[Token(Token = "0x6001381")]
	[Address(RVA = "0x66BC00", Offset = "0x66AA00", Length = "0x1D8")]
	public void DroppedItem(DragDropItem droppedItem)
	{
	}

	[Token(Token = "0x6001382")]
	[Address(RVA = "0x66BDE0", Offset = "0x66ABE0", Length = "0x1A3")]
	protected void OnDragOver(GameObject draggedObject)
	{
	}

	[Token(Token = "0x6001383")]
	[Address(RVA = "0x66BF90", Offset = "0x66AD90", Length = "0x1A6")]
	protected void OnDragOut(GameObject draggedObject)
	{
	}

	[Token(Token = "0x6001384")]
	[Address(RVA = "0x66C140", Offset = "0x66AF40", Length = "0x2B1")]
	protected void SetSpriteScale(float newScale)
	{
	}

	[Token(Token = "0x6001385")]
	[Address(RVA = "0x66C400", Offset = "0x66B200", Length = "0x51")]
	public DragDropContainer()
	{
	}
}
