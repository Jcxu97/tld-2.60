using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Drag and Drop Surface (Example)")]
[Token(Token = "0x200004E")]
public class ExampleDragDropSurface : MonoBehaviour
{
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x20")]
	public bool rotatePlacedObject;

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExampleDragDropSurface()
	{
	}
}
