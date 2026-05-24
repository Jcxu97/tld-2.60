using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000A19")]
public class MinMax
{
	[Token(Token = "0x4006625")]
	[FieldOffset(Offset = "0x10")]
	public float m_Min;

	[Token(Token = "0x4006626")]
	[FieldOffset(Offset = "0x14")]
	public float m_Max;

	[Token(Token = "0x6005882")]
	[Address(RVA = "0xEEC470", Offset = "0xEEB270", Length = "0xF")]
	public MinMax()
	{
	}

	[Token(Token = "0x6005883")]
	[Address(RVA = "0xEEC480", Offset = "0xEEB280", Length = "0xB")]
	public MinMax(float min, float max)
	{
	}

	[Token(Token = "0x6005884")]
	[Address(RVA = "0x4A7A20", Offset = "0x4A6820", Length = "0x6")]
	public float GetMin()
	{
		return 0f;
	}

	[Token(Token = "0x6005885")]
	[Address(RVA = "0x4A7A40", Offset = "0x4A6840", Length = "0x6")]
	public float GetMax()
	{
		return 0f;
	}

	[Token(Token = "0x6005886")]
	[Address(RVA = "0xEEC490", Offset = "0xEEB290", Length = "0x13")]
	public float GetMiddle()
	{
		return 0f;
	}
}
