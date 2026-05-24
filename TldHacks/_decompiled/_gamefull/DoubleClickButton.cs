using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000235")]
public class DoubleClickButton : MonoBehaviour
{
	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x20")]
	public List<EventDelegate> m_OnClick;

	[Token(Token = "0x4001378")]
	[FieldOffset(Offset = "0x28")]
	public List<EventDelegate> m_OnDoubleClick;

	[Token(Token = "0x4001379")]
	[FieldOffset(Offset = "0x30")]
	private float m_DoubleClickTimer;

	[Token(Token = "0x600137E")]
	[Address(RVA = "0x66B8F0", Offset = "0x66A6F0", Length = "0x63")]
	private void Update()
	{
	}

	[Token(Token = "0x600137F")]
	[Address(RVA = "0x66B960", Offset = "0x66A760", Length = "0x127")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6001380")]
	[Address(RVA = "0x66BA90", Offset = "0x66A890", Length = "0x16F")]
	public DoubleClickButton()
	{
	}
}
