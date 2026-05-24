using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000175")]
public class RampRange
{
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x10")]
	public float m_MinGoalSpeed;

	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x14")]
	public float m_MaxGoalSpeed;

	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x18")]
	public float m_Acceleration;

	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x5ECBF0", Offset = "0x5EB9F0", Length = "0x8")]
	public RampRange()
	{
	}
}
