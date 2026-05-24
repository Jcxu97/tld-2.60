using Cpp2ILInjected;

[Token(Token = "0x2000508")]
public class CheatDeathAfflictionState
{
	[Token(Token = "0x4002E37")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsPermanent;

	[Token(Token = "0x4002E38")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursRemaining;

	[Token(Token = "0x4002E39")]
	[FieldOffset(Offset = "0x18")]
	public float m_MaxConditionModifier;

	[Token(Token = "0x6002638")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CheatDeathAfflictionState()
	{
	}
}
