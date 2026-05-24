using Cpp2ILInjected;

namespace TLD.Gear;

[Token(Token = "0x200140B")]
public struct FoodMaxStatBuffEffect
{
	[Token(Token = "0x4009271")]
	[FieldOffset(Offset = "0x0")]
	public FoodMaxStatBuff.StatType m_Stat;

	[Token(Token = "0x4009272")]
	[FieldOffset(Offset = "0x4")]
	public float m_BuffValue;

	[Token(Token = "0x4009273")]
	[FieldOffset(Offset = "0x8")]
	public float m_StartingHoursLeft;

	[Token(Token = "0x4009274")]
	[FieldOffset(Offset = "0xC")]
	public float m_HoursLeft;
}
