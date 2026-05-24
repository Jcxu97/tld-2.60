using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Stats;
using UnityEngine;

[Serializable]
[Token(Token = "0x20006D6")]
public class SummaryStatsView : StatsView
{
	[Token(Token = "0x40048CB")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_GameObject;

	[Token(Token = "0x40048CC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_SummaryStatPrefab;

	[Token(Token = "0x40048CD")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid m_Grid;

	[Token(Token = "0x40048CE")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label_DaysSurvivedValue;

	[Token(Token = "0x40048CF")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_Label_HoursSurvivedValue;

	[Token(Token = "0x40048D0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Label_MinutesSurvivedValue;

	[Token(Token = "0x40048D1")]
	[FieldOffset(Offset = "0x40")]
	private List<StatID> m_VisibleStatIDs;

	[Token(Token = "0x40048D2")]
	[FieldOffset(Offset = "0x48")]
	private List<StatID> m_RandomStatIDs;

	[Token(Token = "0x40048D3")]
	[FieldOffset(Offset = "0x50")]
	private List<Panel_Stats_SummaryEntry> m_VisibleStatsPrefabs;

	[Token(Token = "0x6003C1F")]
	[Address(RVA = "0xB74460", Offset = "0xB73260", Length = "0x145")]
	public void Start()
	{
	}

	[Token(Token = "0x6003C20")]
	[Address(RVA = "0xB745B0", Offset = "0xB733B0", Length = "0x9D")]
	public void AddStat(StatID statName)
	{
	}

	[Token(Token = "0x6003C21")]
	[Address(RVA = "0xB74650", Offset = "0xB73450", Length = "0x9D")]
	public void AddRandomStat(StatID statName)
	{
	}

	[Token(Token = "0x6003C22")]
	[Address(RVA = "0xB746F0", Offset = "0xB734F0", Length = "0xD22")]
	public void Populate()
	{
	}

	[Token(Token = "0x6003C23")]
	[Address(RVA = "0xB75420", Offset = "0xB74220", Length = "0x1C9")]
	public SummaryStatsView()
	{
	}
}
