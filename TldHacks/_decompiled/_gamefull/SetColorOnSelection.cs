using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Examples/Set Color on Selection")]
[Token(Token = "0x2000056")]
public class SetColorOnSelection : MonoBehaviour
{
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget mWidget;

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xA1FF30", Offset = "0xA1ED30", Length = "0x542")]
	public void SetSpriteBySelection()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SetColorOnSelection()
	{
	}
}
