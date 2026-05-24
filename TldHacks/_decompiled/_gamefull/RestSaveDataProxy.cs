using Cpp2ILInjected;

[Token(Token = "0x2000437")]
public class RestSaveDataProxy
{
	[Token(Token = "0x40025E3")]
	[FieldOffset(Offset = "0x10")]
	public int m_LastDisplayedDayNumberOnAwake;

	[Token(Token = "0x40025E4")]
	[FieldOffset(Offset = "0x18")]
	public int[] m_LastTwentyFourHoursOfSleep;

	[Token(Token = "0x40025E5")]
	[FieldOffset(Offset = "0x20")]
	public bool m_PassTimeIsLocked;

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RestSaveDataProxy()
	{
	}
}
