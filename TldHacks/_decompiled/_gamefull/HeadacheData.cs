using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Afflictions/Headache/Create a new headache data")]
[Token(Token = "0x200051B")]
public class HeadacheData : ScriptableObject
{
	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x18")]
	public float m_HeadacheDurationHours;

	[Token(Token = "0x4002ED7")]
	[FieldOffset(Offset = "0x1C")]
	public float m_HeadachePulseFrequencyStart;

	[Token(Token = "0x4002ED8")]
	[FieldOffset(Offset = "0x20")]
	public float m_HeadachePulseFrequencyEnd;

	[Token(Token = "0x4002ED9")]
	[FieldOffset(Offset = "0x24")]
	public HeadacheCause m_Cause;

	[Header("Time - Optional")]
	[Token(Token = "0x4002EDA")]
	[FieldOffset(Offset = "0x28")]
	public float m_HoursRequiredOutdoorToGetAffliction;

	[Token(Token = "0x4002EDB")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HoursRequiredIndoorToExitAffliction;

	[Token(Token = "0x4002EDC")]
	[FieldOffset(Offset = "0x30")]
	public string m_HeadachePulseEvent;

	[Token(Token = "0x4002EDD")]
	[FieldOffset(Offset = "0x38")]
	public string m_HeadacheStartAudio;

	[Token(Token = "0x4002EDE")]
	[FieldOffset(Offset = "0x40")]
	public string m_HeadacheAfflictionIcoName;

	[Tooltip("Shown as caused by in the status panel")]
	[Token(Token = "0x4002EDF")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_CausedByLocalizedId;

	[Tooltip("Shown by the UI Kicker")]
	[Token(Token = "0x4002EE0")]
	[FieldOffset(Offset = "0x50")]
	public LocalizedString m_HeadacheLocalizedId;

	[Token(Token = "0x4002EE1")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_HealedAfflictionLocalizedId;

	[Token(Token = "0x4002EE2")]
	[FieldOffset(Offset = "0x60")]
	public LocalizedString m_HeadacheDescription;

	[Token(Token = "0x4002EE3")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_TreatmentRequiredDescription;

	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public HeadacheData()
	{
	}
}
