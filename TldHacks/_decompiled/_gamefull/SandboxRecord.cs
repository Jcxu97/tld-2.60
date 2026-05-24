using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Scenes;
using TLD.Stats;
using UnityEngine;

[Serializable]
[Token(Token = "0x200083F")]
public class SandboxRecord
{
	[Token(Token = "0x4005647")]
	[FieldOffset(Offset = "0x10")]
	public string m_SandboxName;

	[Token(Token = "0x4005648")]
	[FieldOffset(Offset = "0x18")]
	public float m_ElapsedHours;

	[Token(Token = "0x4005649")]
	[FieldOffset(Offset = "0x20")]
	public DateTime m_EndDate;

	[Token(Token = "0x400564A")]
	[FieldOffset(Offset = "0x28")]
	public string m_StartRegion;

	[Token(Token = "0x400564B")]
	[FieldOffset(Offset = "0x30")]
	public string m_EndRegion;

	[Token(Token = "0x400564C")]
	[FieldOffset(Offset = "0x38")]
	public string m_ExperienceModeType;

	[Token(Token = "0x400564D")]
	[FieldOffset(Offset = "0x40")]
	public VoicePersona m_VoicePersona;

	[Token(Token = "0x400564E")]
	[FieldOffset(Offset = "0x48")]
	public string m_CauseOfDeathLocId;

	[Token(Token = "0x400564F")]
	[FieldOffset(Offset = "0x50")]
	public string m_GeneralNotes;

	[Token(Token = "0x4005650")]
	[FieldOffset(Offset = "0x58")]
	public List<LogDayInfo> m_LogDayInfoList;

	[Token(Token = "0x4005651")]
	[FieldOffset(Offset = "0x60")]
	public List<LogListItem> m_CollectibleList;

	[Token(Token = "0x4005652")]
	[FieldOffset(Offset = "0x68")]
	public List<string> m_CollectibleNotesList;

	[Token(Token = "0x4005653")]
	[FieldOffset(Offset = "0x70")]
	public List<CairnInfo> m_CollectibleCairnInfoList;

	[Token(Token = "0x4005654")]
	[FieldOffset(Offset = "0x78")]
	public List<AuroraScreenInfo> m_CollectibleAuroraScreenInfoList;

	[Token(Token = "0x4005655")]
	[FieldOffset(Offset = "0x80")]
	public StatContainer m_Stats;

	[NonSerialized]
	[Token(Token = "0x4005656")]
	[FieldOffset(Offset = "0x88")]
	private RegionSpecification m_StartRegionSpecification;

	[Token(Token = "0x17000355")]
	public GameModeConfig GameMode
	{
		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0xD71010", Offset = "0xD6FE10", Length = "0x8B")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0xD710A0", Offset = "0xD6FEA0", Length = "0x141")]
		set
		{
		}
	}

	[Token(Token = "0x17000356")]
	public RegionSpecification StartRegion
	{
		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0xD711F0", Offset = "0xD6FFF0", Length = "0x138")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0xD71330", Offset = "0xD70130", Length = "0x1C3")]
		set
		{
		}
	}

	[Token(Token = "0x6004C81")]
	[Address(RVA = "0xD71500", Offset = "0xD70300", Length = "0xB5D")]
	public static SandboxRecord CreateFromSandbox(List<LogListItem> collectibleList)
	{
		return null;
	}

	[Token(Token = "0x6004C82")]
	[Address(RVA = "0xD72060", Offset = "0xD70E60", Length = "0x3AC")]
	public string GetSurvivalRecordSummaryText(Color boldColor)
	{
		return null;
	}

	[Token(Token = "0x6004C83")]
	[Address(RVA = "0xD72410", Offset = "0xD71210", Length = "0xE5")]
	public string GetExperienceModeSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6004C84")]
	[Address(RVA = "0xD72500", Offset = "0xD71300", Length = "0xB0")]
	public string GetEndDate()
	{
		return null;
	}

	[Token(Token = "0x6004C85")]
	[Address(RVA = "0xD725B0", Offset = "0xD713B0", Length = "0x33C")]
	private static void StoreNoteCollectibles(SandboxRecord record)
	{
	}

	[Token(Token = "0x6004C86")]
	[Address(RVA = "0xD728F0", Offset = "0xD716F0", Length = "0x5ED")]
	private static void StoreCairnCollectibles(SandboxRecord record)
	{
	}

	[Token(Token = "0x6004C87")]
	[Address(RVA = "0xD72EE0", Offset = "0xD71CE0", Length = "0x4FC")]
	private static void StoreAuroraScreenCollectibles(SandboxRecord record)
	{
	}

	[Token(Token = "0x6004C88")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SandboxRecord()
	{
	}
}
