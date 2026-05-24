using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000278")]
public class ScrollListButton : MonoBehaviour
{
	[Token(Token = "0x400169D")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_CallbackObject;

	[Token(Token = "0x400169E")]
	[FieldOffset(Offset = "0x28")]
	private string m_CallbackString;

	[Token(Token = "0x400169F")]
	[FieldOffset(Offset = "0x30")]
	private int m_Index;

	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x6A67A0", Offset = "0x6A55A0", Length = "0xC8")]
	public void SetCallback(GameObject callbackObject, string callbackString, int index)
	{
	}

	[Token(Token = "0x60015A3")]
	[Address(RVA = "0x6A6870", Offset = "0x6A5670", Length = "0x118")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ScrollListButton()
	{
	}
}
