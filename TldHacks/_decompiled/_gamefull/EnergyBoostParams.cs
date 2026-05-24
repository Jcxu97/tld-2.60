using Cpp2ILInjected;

[Token(Token = "0x20001DE")]
public class EnergyBoostParams
{
	[Token(Token = "0x400109B")]
	[FieldOffset(Offset = "0x10")]
	public float m_BoostDurationHours;

	[Token(Token = "0x400109C")]
	[FieldOffset(Offset = "0x14")]
	public float m_BoostPulseFrequencyStart;

	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x18")]
	public float m_BoostPulseFrequencyEnd;

	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x1C")]
	public float m_LastUsageTimeInGameHours;

	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x20")]
	public float m_FatigueIncreaseWhenComplete;

	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x24")]
	public float m_StaminaDecreaseWhenComplete;

	[Token(Token = "0x6001117")]
	[Address(RVA = "0x637CE0", Offset = "0x636AE0", Length = "0x8")]
	public EnergyBoostParams()
	{
	}
}
