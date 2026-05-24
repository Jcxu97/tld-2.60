using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay.Condition;

[CreateAssetMenu(menuName = "The Long Dark/Afflictions/Insomnia/Create a new insomnia data")]
[Token(Token = "0x20014CB")]
public class InsomniaData : ScriptableObject
{
	[Token(Token = "0x4009642")]
	[FieldOffset(Offset = "0x18")]
	public InsomniaCause m_Cause;

	[Token(Token = "0x4009643")]
	[FieldOffset(Offset = "0x20")]
	public string m_InsomniaStartAudio;

	[Token(Token = "0x4009644")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_InsomniaCausedByLocalizedId;

	[Header("Insomnia Risk Setting")]
	[Token(Token = "0x4009645")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_InsomniaRiskLocalizedId;

	[Token(Token = "0x4009646")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_InsomniaRiskDescription;

	[Token(Token = "0x4009647")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_InsomniaRiskTreatmentRequiredDescription;

	[Token(Token = "0x4009648")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_InsomniaRiskHealedLocalizedId;

	[Token(Token = "0x4009649")]
	[FieldOffset(Offset = "0x50")]
	public string m_InsomniaRiskIcoName;

	[Token(Token = "0x400964A")]
	[FieldOffset(Offset = "0x58")]
	public float m_HoursRequiredToTurnRiskToAffliction;

	[Token(Token = "0x400964B")]
	[FieldOffset(Offset = "0x5C")]
	public float m_OutdoorRiskIncreaseSpeedModifier;

	[Token(Token = "0x400964C")]
	[FieldOffset(Offset = "0x60")]
	public float m_IndoorRiskIncreaseSpeedModifier;

	[Token(Token = "0x400964D")]
	[FieldOffset(Offset = "0x64")]
	public float m_SafePlaceRiskDecreaseSpeedModifier;

	[Header("Insomnia Affliction Setting")]
	[Token(Token = "0x400964E")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_InsomniaAfflictionLocalizedId;

	[Token(Token = "0x400964F")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_InsomniaAfflictionDescription;

	[Token(Token = "0x4009650")]
	[FieldOffset(Offset = "0x78")]
	public LocalizedString m_InsomniaAfflictionTreatmentRequiredDescription;

	[Token(Token = "0x4009651")]
	[FieldOffset(Offset = "0x80")]
	public LocalizedString m_InsomniaAfflictionHealedLocalizedId;

	[Token(Token = "0x4009652")]
	[FieldOffset(Offset = "0x88")]
	public string m_InsomniaAfflictionIcoName;

	[Token(Token = "0x4009653")]
	[FieldOffset(Offset = "0x90")]
	public int m_MinHoursRequiredToRemoveAffliction;

	[Token(Token = "0x4009654")]
	[FieldOffset(Offset = "0x94")]
	public int m_MaxHoursRequiredToRemoveAffliction;

	[Token(Token = "0x4009655")]
	[FieldOffset(Offset = "0x98")]
	public float m_ChaneOfGettingInterruptedSleep;

	[Token(Token = "0x4009656")]
	[FieldOffset(Offset = "0x9C")]
	public float m_MinChanceHowBadlySleepInterrupted;

	[Token(Token = "0x4009657")]
	[FieldOffset(Offset = "0xA0")]
	public float m_MaxChanceHowBadlySleepInterrupted;

	[Token(Token = "0x6008326")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public InsomniaData()
	{
	}
}
