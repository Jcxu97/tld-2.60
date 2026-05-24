using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200024D")]
public class HoldButtonClick : MonoBehaviour
{
	[Token(Token = "0x4001472")]
	[FieldOffset(Offset = "0x20")]
	public float m_DelayValueStart;

	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x24")]
	public float m_DelayValueMax;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x28")]
	public int m_NumClicksUntilMax;

	[Token(Token = "0x4001475")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsDown;

	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0x30")]
	private float m_Timer;

	[Token(Token = "0x4001477")]
	[FieldOffset(Offset = "0x34")]
	private int m_ClickCounter;

	[Token(Token = "0x600143F")]
	[Address(RVA = "0x680F10", Offset = "0x67FD10", Length = "0x15")]
	private void OnPress(bool isDown)
	{
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0x680F30", Offset = "0x67FD30", Length = "0x123")]
	private void Update()
	{
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0x681060", Offset = "0x67FE60", Length = "0x5")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0x681070", Offset = "0x67FE70", Length = "0x58")]
	public HoldButtonClick()
	{
	}
}
