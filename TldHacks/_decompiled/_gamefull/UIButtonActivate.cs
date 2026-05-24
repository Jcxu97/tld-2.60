using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Activate")]
[Token(Token = "0x2000062")]
public class UIButtonActivate : MonoBehaviour
{
	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x28")]
	public bool state;

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xA25E40", Offset = "0xA24C40", Length = "0x106")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x80BB20", Offset = "0x80A920", Length = "0x47")]
	public UIButtonActivate()
	{
	}
}
