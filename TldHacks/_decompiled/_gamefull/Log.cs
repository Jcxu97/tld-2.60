using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Stats;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000432")]
public class Log : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40025B0")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Log> m_Log;

	[Token(Token = "0x40025B1")]
	[FieldOffset(Offset = "0x28")]
	public string m_GeneralNotes;

	[Token(Token = "0x40025B2")]
	[FieldOffset(Offset = "0x30")]
	public List<LogDayInfo> m_LogDayInfoList;

	[Token(Token = "0x40025B3")]
	[FieldOffset(Offset = "0x38")]
	public LogDayInfo m_TodayLogDayInfo;

	[Token(Token = "0x40025B4")]
	[FieldOffset(Offset = "0x40")]
	private int m_DayToLogEndOfDayInfo;

	[Token(Token = "0x40025B5")]
	[FieldOffset(Offset = "0x44")]
	private bool m_AddedCurrentRegion;

	[Token(Token = "0x40025B6")]
	[FieldOffset(Offset = "0x45")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40025B7")]
	private static LogSaveDataProxy m_LogSaveDataProxy;

	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x7DC3F0", Offset = "0x7DB1F0", Length = "0x19E")]
	public void Update()
	{
	}

	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x7DC590", Offset = "0x7DB390", Length = "0x235")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x7DC7D0", Offset = "0x7DB5D0", Length = "0x335")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x7DCB10", Offset = "0x7DB910", Length = "0x172")]
	public LogDayInfo GetInfoForDay(int dayNumber)
	{
		return null;
	}

	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x7DCC90", Offset = "0x7DBA90", Length = "0x184")]
	public void EnterNotesForDay(string notes, int dayNumber)
	{
	}

	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x7DCE20", Offset = "0x7DBC20", Length = "0x193")]
	public void AddAffliction(AfflictionType affType, string causeLocId)
	{
	}

	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x7DCFC0", Offset = "0x7DBDC0", Length = "0x3F8")]
	public void AddLocation(string locationName)
	{
	}

	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void AddItem(string text)
	{
	}

	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void WriteLogToFile()
	{
	}

	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x7DD3C0", Offset = "0x7DC1C0", Length = "0x22C")]
	public void LockInTodaysValues()
	{
	}

	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x7DD5F0", Offset = "0x7DC3F0", Length = "0x325")]
	private void AddCurrentRegion()
	{
	}

	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x7DD920", Offset = "0x7DC720", Length = "0xCD")]
	private void TrackCondition()
	{
	}

	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x7DD9F0", Offset = "0x7DC7F0", Length = "0x79")]
	private void MaybeLogEndOfDayInfo()
	{
	}

	[Token(Token = "0x6001F90")]
	[Address(RVA = "0x7DDA70", Offset = "0x7DC870", Length = "0x3B0")]
	private void LogEndOfDayInfo(int day)
	{
	}

	[Token(Token = "0x6001F91")]
	[Address(RVA = "0x7DDE30", Offset = "0x7DCC30", Length = "0xD9")]
	public Log()
	{
	}
}
