using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x20000DE")]
public class AnimatedWidget : MonoBehaviour
{
	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x20")]
	public float width;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x24")]
	public float height;

	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget mWidget;

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x1123CF0", Offset = "0x1122AF0", Length = "0x217")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x1123F10", Offset = "0x1122D10", Length = "0x197")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x11240B0", Offset = "0x1122EB0", Length = "0x51")]
	public AnimatedWidget()
	{
	}
}
