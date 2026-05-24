using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003C3")]
public class LightFlickering : MonoBehaviour
{
	[Token(Token = "0x40021E8")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40021E9")]
	[FieldOffset(Offset = "0x24")]
	public Color color0;

	[Token(Token = "0x40021EA")]
	[FieldOffset(Offset = "0x34")]
	public Color color1;

	[Token(Token = "0x40021EB")]
	[FieldOffset(Offset = "0x48")]
	private Light m_Light;

	[Token(Token = "0x40021EC")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurrentTime;

	[Token(Token = "0x40021ED")]
	[FieldOffset(Offset = "0x54")]
	private float m_StartingValue;

	[Token(Token = "0x40021EE")]
	[FieldOffset(Offset = "0x58")]
	private float m_Destination;

	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x7A4E20", Offset = "0x7A3C20", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D81")]
	[Address(RVA = "0x7A4EB0", Offset = "0x7A3CB0", Length = "0x21F")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x7A50D0", Offset = "0x7A3ED0", Length = "0x71")]
	public LightFlickering()
	{
	}
}
