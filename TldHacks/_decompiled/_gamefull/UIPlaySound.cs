using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Play Sound")]
[Token(Token = "0x2000086")]
public class UIPlaySound : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	public enum Trigger
	{
		[Token(Token = "0x40004AF")]
		OnClick,
		[Token(Token = "0x40004B0")]
		OnMouseOver,
		[Token(Token = "0x40004B1")]
		OnMouseOut,
		[Token(Token = "0x40004B2")]
		OnPress,
		[Token(Token = "0x40004B3")]
		OnRelease,
		[Token(Token = "0x40004B4")]
		Custom,
		[Token(Token = "0x40004B5")]
		OnEnable,
		[Token(Token = "0x40004B6")]
		OnDisable
	}

	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip audioClip;

	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x28")]
	public Trigger trigger;

	[Range(0f, 1f)]
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x2C")]
	public float volume;

	[Range(0f, 2f)]
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x30")]
	public float pitch;

	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x34")]
	private bool mIsOver;

	[Token(Token = "0x17000040")]
	private bool canPlay
	{
		[Token(Token = "0x6000494")]
		[Address(RVA = "0xBDB790", Offset = "0xBDA590", Length = "0x1AD")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xBDB940", Offset = "0xBDA740", Length = "0x88")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xBDB9D0", Offset = "0xBDA7D0", Length = "0x88")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xBDBA60", Offset = "0xBDA860", Length = "0xBF")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xBDBB20", Offset = "0xBDA920", Length = "0xBF")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xBDBBE0", Offset = "0xBDA9E0", Length = "0x96")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xBDBC80", Offset = "0xBDAA80", Length = "0x11A")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0xBDBDA0", Offset = "0xBDABA0", Length = "0x80")]
	public void Play()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x8B5350", Offset = "0x8B4150", Length = "0x51")]
	public UIPlaySound()
	{
	}
}
