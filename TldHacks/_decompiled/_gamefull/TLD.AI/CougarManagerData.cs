using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;

namespace TLD.AI;

[Token(Token = "0x2001500")]
public class CougarManagerData
{
	[Token(Token = "0x40097BC")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsEnabled;

	[Token(Token = "0x40097BD")]
	[FieldOffset(Offset = "0x14")]
	public int m_Version;

	[DefaultValue(-1f)]
	[Token(Token = "0x40097BE")]
	[FieldOffset(Offset = "0x18")]
	public float m_DaysPlayedNotPausedAtStart;

	[Token(Token = "0x40097BF")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_CougarSettingsOverride;

	[Token(Token = "0x40097C0")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_TerritoryLocIDs;

	[Token(Token = "0x40097C1")]
	[FieldOffset(Offset = "0x28")]
	public List<int> m_CougarStates;

	[Token(Token = "0x40097C2")]
	[FieldOffset(Offset = "0x30")]
	public List<string> m_RegionThreatLevelNames;

	[Token(Token = "0x40097C3")]
	[FieldOffset(Offset = "0x38")]
	public List<int> m_RegionThreatLevels;

	[Token(Token = "0x40097C4")]
	[FieldOffset(Offset = "0x40")]
	public List<bool> m_HasPlayedCinematics;

	[Token(Token = "0x40097C5")]
	[FieldOffset(Offset = "0x48")]
	public List<float> m_ThreatCooldownDays;

	[Token(Token = "0x40097C6")]
	[FieldOffset(Offset = "0x50")]
	public List<float> m_NextDaysPlayedCheck;

	[Token(Token = "0x40097C7")]
	[FieldOffset(Offset = "0x58")]
	public List<float> m_CurrentNearbyCougarAudioByRegion;

	[Token(Token = "0x40097C8")]
	[FieldOffset(Offset = "0x60")]
	public string m_PreviousRegionName;

	[Token(Token = "0x60084B4")]
	[Address(RVA = "0x1266490", Offset = "0x1265290", Length = "0x44B")]
	public CougarManagerData()
	{
	}
}
