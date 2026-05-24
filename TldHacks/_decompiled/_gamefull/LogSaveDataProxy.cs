using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Stats;

[Token(Token = "0x2000431")]
public class LogSaveDataProxy
{
	[Token(Token = "0x40025AC")]
	[FieldOffset(Offset = "0x10")]
	public string m_GeneralNotes;

	[Token(Token = "0x40025AD")]
	[FieldOffset(Offset = "0x18")]
	public List<LogDayInfo> m_LogDayInfoList;

	[Token(Token = "0x40025AE")]
	[FieldOffset(Offset = "0x20")]
	public LogDayInfo m_TodayLogDayInfo;

	[Token(Token = "0x40025AF")]
	[FieldOffset(Offset = "0x28")]
	public int m_DayToLogEndOfDayInfo;

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LogSaveDataProxy()
	{
	}
}
