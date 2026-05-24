using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000695")]
public class MapSaveData
{
	[Token(Token = "0x4004497")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, string> m_MapSaveDataDict;

	[Token(Token = "0x4004498")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<string, string> m_DetailSurveyPositions;

	[Token(Token = "0x4004499")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<string, float> m_DetailSurveyLastUpdateTimes;

	[Token(Token = "0x400449A")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<string, string> m_SurveyedVistaLocations;

	[Token(Token = "0x400449B")]
	[FieldOffset(Offset = "0x30")]
	public List<string> m_DelayedMapElementRemovals;

	[Token(Token = "0x400449C")]
	[FieldOffset(Offset = "0x38")]
	public List<string> m_UnlockedRegionNames;

	[Token(Token = "0x400449D")]
	[FieldOffset(Offset = "0x40")]
	public bool m_HasBeenUpdated;

	[Token(Token = "0x400449E")]
	[FieldOffset(Offset = "0x44")]
	public Guid m_Guid;

	[Token(Token = "0x6003821")]
	[Address(RVA = "0xAEB9C0", Offset = "0xAEA7C0", Length = "0x239")]
	public MapSaveData()
	{
	}
}
