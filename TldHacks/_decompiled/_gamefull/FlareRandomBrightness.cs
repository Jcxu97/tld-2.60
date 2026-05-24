using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000394")]
public class FlareRandomBrightness : MonoBehaviour
{
	[Token(Token = "0x400201F")]
	[FieldOffset(Offset = "0x20")]
	public float m_IntervalSeconds;

	[Token(Token = "0x4002020")]
	[FieldOffset(Offset = "0x24")]
	public float m_Min;

	[Token(Token = "0x4002021")]
	[FieldOffset(Offset = "0x28")]
	public float m_Max;

	[Token(Token = "0x4002022")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CurrentTime;

	[Token(Token = "0x4002023")]
	[FieldOffset(Offset = "0x30")]
	private float m_Destination;

	[Token(Token = "0x4002024")]
	[FieldOffset(Offset = "0x34")]
	private float m_FlareBrightnessStart;

	[Token(Token = "0x4002025")]
	[FieldOffset(Offset = "0x38")]
	private LensFlare m_LensFlare;

	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x786E80", Offset = "0x785C80", Length = "0xBD")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x786F40", Offset = "0x785D40", Length = "0x10B")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x787050", Offset = "0x785E50", Length = "0x51")]
	public FlareRandomBrightness()
	{
	}
}
