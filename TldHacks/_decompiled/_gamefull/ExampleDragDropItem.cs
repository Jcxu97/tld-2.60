using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Drag and Drop Item (Example)")]
[Token(Token = "0x200004D")]
public class ExampleDragDropItem : UIDragDropItem
{
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject prefab;

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xA1D0D0", Offset = "0xA1BED0", Length = "0x5D3")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xA1D6B0", Offset = "0xA1C4B0", Length = "0x4E")]
	public ExampleDragDropItem()
	{
	}
}
