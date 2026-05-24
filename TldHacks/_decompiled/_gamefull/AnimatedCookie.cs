using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000353")]
public class AnimatedCookie : MonoBehaviour
{
	[Token(Token = "0x4001D5B")]
	[FieldOffset(Offset = "0x20")]
	public float m_FPS;

	[Token(Token = "0x4001D5C")]
	[FieldOffset(Offset = "0x24")]
	public bool m_RandomStartFrame;

	[Token(Token = "0x4001D5D")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D[] m_Frames;

	[Token(Token = "0x4001D5E")]
	[FieldOffset(Offset = "0x30")]
	private int m_CurrentFrame;

	[Token(Token = "0x4001D5F")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurrentAnimationTime;

	[Token(Token = "0x4001D60")]
	[FieldOffset(Offset = "0x38")]
	private Light m_Light;

	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x759620", Offset = "0x758420", Length = "0xE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x759710", Offset = "0x758510", Length = "0xC5")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x7597E0", Offset = "0x7585E0", Length = "0x57")]
	private void NextFrame()
	{
	}

	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x759840", Offset = "0x758640", Length = "0x4E")]
	public AnimatedCookie()
	{
	}
}
