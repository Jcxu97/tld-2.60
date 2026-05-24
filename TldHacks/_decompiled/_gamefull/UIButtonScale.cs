using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Scale")]
[Token(Token = "0x200006A")]
public class UIButtonScale : MonoBehaviour
{
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x20")]
	public Transform tweenTarget;

	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 hover;

	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 pressed;

	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 mScale;

	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x50")]
	private bool mStarted;

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xA2A1B0", Offset = "0xA28FB0", Length = "0x1EA")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xA2A3A0", Offset = "0xA291A0", Length = "0x7A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xA2A420", Offset = "0xA29220", Length = "0x1CB")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xA2A5F0", Offset = "0xA293F0", Length = "0x211")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xA2A810", Offset = "0xA29610", Length = "0x164")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xA2A980", Offset = "0xA29780", Length = "0x104")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xA2AA90", Offset = "0xA29890", Length = "0x9A")]
	public UIButtonScale()
	{
	}
}
