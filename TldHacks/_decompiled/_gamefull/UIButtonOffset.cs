using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Offset")]
[Token(Token = "0x2000068")]
public class UIButtonOffset : MonoBehaviour
{
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x20")]
	public Transform tweenTarget;

	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 hover;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 pressed;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 mPos;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x50")]
	private bool mStarted;

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xA28AE0", Offset = "0xA278E0", Length = "0x1EA")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xA28CD0", Offset = "0xA27AD0", Length = "0x7A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xA28D50", Offset = "0xA27B50", Length = "0x1CB")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xA28F20", Offset = "0xA27D20", Length = "0x211")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xA29140", Offset = "0xA27F40", Length = "0x164")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xA292B0", Offset = "0xA280B0", Length = "0x104")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xA293C0", Offset = "0xA281C0", Length = "0x271")]
	public void RefreshPosition()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xA29640", Offset = "0xA28440", Length = "0xBD")]
	public UIButtonOffset()
	{
	}
}
