using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIWidget))]
[Token(Token = "0x20000DD")]
public class AnimatedColor : MonoBehaviour
{
	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x20")]
	public Color color;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x30")]
	private UIWidget mWidget;

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x1123A60", Offset = "0x1122860", Length = "0x187")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x1123BF0", Offset = "0x11229F0", Length = "0xFB")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xFDE540", Offset = "0xFDD340", Length = "0x53")]
	public AnimatedColor()
	{
	}
}
