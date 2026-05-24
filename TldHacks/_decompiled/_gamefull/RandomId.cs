using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000158")]
public class RandomId
{
	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x10")]
	public AiMode m_AiMode;

	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x14")]
	public int m_NumAnims;

	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x18")]
	public float m_MinSecondsDelay;

	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x1C")]
	public float m_MaxSecondsDelay;

	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x5DCA60", Offset = "0x5DB860", Length = "0xF")]
	public RandomId()
	{
	}
}
