using Cpp2ILInjected;

[Token(Token = "0x2000313")]
public class TimeOfDaySaveDataProxy
{
	[Token(Token = "0x4001B05")]
	[FieldOffset(Offset = "0x10")]
	public float m_TimeProxy;

	[Token(Token = "0x4001B06")]
	[FieldOffset(Offset = "0x14")]
	public float m_HoursPlayedNotPausedProxy;

	[Token(Token = "0x4001B07")]
	[FieldOffset(Offset = "0x18")]
	public int m_UniStormDayCounterProxy;

	[Token(Token = "0x4001B08")]
	[FieldOffset(Offset = "0x1C")]
	public int m_UniStormMoonPhaseIndexProxy;

	[Token(Token = "0x4001B09")]
	[FieldOffset(Offset = "0x20")]
	public int m_UniStormDayNumberProxy;

	[Token(Token = "0x4001B0A")]
	[FieldOffset(Offset = "0x24")]
	public int m_DayLastDawnStingerAudioPlayed;

	[Token(Token = "0x4001B0B")]
	[FieldOffset(Offset = "0x28")]
	public int m_DayLastNightStingerAudioPlayed;

	[Token(Token = "0x4001B0C")]
	[FieldOffset(Offset = "0x2C")]
	public int m_DayLastDawnVoiceOverPlayed;

	[Token(Token = "0x4001B0D")]
	[FieldOffset(Offset = "0x30")]
	public int m_DayLastNightVoiceOverPlayed;

	[Token(Token = "0x4001B0E")]
	[FieldOffset(Offset = "0x34")]
	public int m_4DONCurrentDay;

	[Token(Token = "0x4001B0F")]
	[FieldOffset(Offset = "0x38")]
	public bool m_LockedTOD;

	[Token(Token = "0x4001B10")]
	[FieldOffset(Offset = "0x40")]
	public string m_CurrentScene;

	[Token(Token = "0x4001B11")]
	[FieldOffset(Offset = "0x48")]
	public int m_DayEntered;

	[Token(Token = "0x4001B12")]
	[FieldOffset(Offset = "0x4C")]
	public int m_HourEntered;

	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TimeOfDaySaveDataProxy()
	{
	}
}
