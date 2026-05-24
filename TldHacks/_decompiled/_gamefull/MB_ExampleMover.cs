using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AE8")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400695C")]
	[FieldOffset(Offset = "0x20")]
	public int axis;

	[Token(Token = "0x6005CD7")]
	[Address(RVA = "0xF57550", Offset = "0xF56350", Length = "0x14A")]
	private void Update()
	{
	}

	[Token(Token = "0x6005CD8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MB_ExampleMover()
	{
	}
}
