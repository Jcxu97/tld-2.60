using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Rotation")]
[Token(Token = "0x2000069")]
public class UIButtonRotation : MonoBehaviour
{
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x20")]
	public Transform tweenTarget;

	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 hover;

	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 pressed;

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion mRot;

	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x54")]
	private bool mStarted;

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xA29700", Offset = "0xA28500", Length = "0x1DA")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xA298E0", Offset = "0xA286E0", Length = "0x7A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xA29960", Offset = "0xA28760", Length = "0x1C2")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xA29B30", Offset = "0xA28930", Length = "0x29D")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xA29DD0", Offset = "0xA28BD0", Length = "0x1FE")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xA29FD0", Offset = "0xA28DD0", Length = "0x104")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xA2A0E0", Offset = "0xA28EE0", Length = "0xD0")]
	public UIButtonRotation()
	{
	}
}
