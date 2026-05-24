using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x20000DC")]
public class AnimatedAlpha : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x40006FC")]
	[FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x40006FD")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget mWidget;

	[Token(Token = "0x40006FE")]
	[FieldOffset(Offset = "0x30")]
	private UIPanel mPanel;

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x1123730", Offset = "0x1122530", Length = "0x122")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x1123860", Offset = "0x1122660", Length = "0x1A0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x1123A10", Offset = "0x1122810", Length = "0x4A")]
	public AnimatedAlpha()
	{
	}
}
