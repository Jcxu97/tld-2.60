using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Container")]
[Token(Token = "0x200006F")]
public class UIDragDropContainer : MonoBehaviour
{
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x20")]
	public Transform reparentTarget;

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xA2D810", Offset = "0xA2C610", Length = "0x121")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIDragDropContainer()
	{
	}
}
