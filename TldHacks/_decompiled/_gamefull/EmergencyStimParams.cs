using Cpp2ILInjected;

[Token(Token = "0x20001D9")]
public class EmergencyStimParams
{
	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursStimulatedWhenInjected;

	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x14")]
	public float m_MinHoursBetweenUsage;

	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x18")]
	public float m_StimPulseFrequencyStart;

	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x1C")]
	public float m_StimPulseFrequencyEnd;

	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x20")]
	public float m_LastUsageTimeInGameHours;

	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x24")]
	public float m_FatigueIncreaseWhenComplete;

	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x28")]
	public float m_StaminaDecreaseWhenComplete;

	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x2C")]
	public float m_PlayCatchBreathSecondsAfterBegin;

	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x30")]
	public uint m_AudioIDEmergencyStim;

	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x634A20", Offset = "0x633820", Length = "0xF")]
	public EmergencyStimParams()
	{
	}

	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x634A30", Offset = "0x633830", Length = "0x57")]
	public EmergencyStimParams(EmergencyStimParams rhs)
	{
	}
}
