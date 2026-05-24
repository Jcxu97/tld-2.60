using Cpp2ILInjected;

namespace TLD.Gameplay.Condition;

[Token(Token = "0x20014C9")]
public class InsomniaParamsSaveDataProxy
{
	[Token(Token = "0x4009606")]
	[FieldOffset(Offset = "0x10")]
	public InsomniaCause m_Cause;

	[Token(Token = "0x4009607")]
	[FieldOffset(Offset = "0x14")]
	public InsomniaStatus m_InsomniaStatus;

	[Token(Token = "0x4009608")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_InsomniaCausedByLocalizedId;

	[Token(Token = "0x4009609")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_InsomniaRiskLocalizedId;

	[Token(Token = "0x400960A")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_InsomniaRiskDescription;

	[Token(Token = "0x400960B")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_InsomniaRiskTreatmentRequiredDescription;

	[Token(Token = "0x400960C")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_InsomniaRiskHealedLocalizedId;

	[Token(Token = "0x400960D")]
	[FieldOffset(Offset = "0x40")]
	public string m_InsomniaRiskIcoName;

	[Token(Token = "0x400960E")]
	[FieldOffset(Offset = "0x48")]
	public float m_HoursRequiredToTurnRiskToAffliction;

	[Token(Token = "0x400960F")]
	[FieldOffset(Offset = "0x4C")]
	public float m_OutdoorRiskIncreaseSpeedModifier;

	[Token(Token = "0x4009610")]
	[FieldOffset(Offset = "0x50")]
	public float m_InsideRiskDecreaseSpeedModifier;

	[Token(Token = "0x4009611")]
	[FieldOffset(Offset = "0x54")]
	public float m_SafePlaceRiskDecreaseSpeedModifier;

	[Token(Token = "0x4009612")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_InsomniaAfflictionLocalizedId;

	[Token(Token = "0x4009613")]
	[FieldOffset(Offset = "0x60")]
	public LocalizedString m_InsomniaAfflictionDescription;

	[Token(Token = "0x4009614")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_InsomniaAfflictionTreatmentRequiredDescription;

	[Token(Token = "0x4009615")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_InsomniaAfflictionHealedLocalizedId;

	[Token(Token = "0x4009616")]
	[FieldOffset(Offset = "0x78")]
	public string m_InsomniaAfflictionIcoName;

	[Token(Token = "0x4009617")]
	[FieldOffset(Offset = "0x80")]
	public int m_MinHoursRequiredToRemoveAffliction;

	[Token(Token = "0x4009618")]
	[FieldOffset(Offset = "0x84")]
	public int m_MaxHoursRequiredToRemoveAffliction;

	[Token(Token = "0x4009619")]
	[FieldOffset(Offset = "0x88")]
	public float m_StartTimeInGameHours;

	[Token(Token = "0x400961A")]
	[FieldOffset(Offset = "0x8C")]
	public int m_HoursRequiredToExitAffliction;

	[Token(Token = "0x400961B")]
	[FieldOffset(Offset = "0x90")]
	public float m_RiskProgress;

	[Token(Token = "0x400961C")]
	[FieldOffset(Offset = "0x94")]
	public bool m_CanUpdateAffliction;

	[Token(Token = "0x400961D")]
	[FieldOffset(Offset = "0x98")]
	public string m_InsomniaStartAudio;

	[Token(Token = "0x400961E")]
	[FieldOffset(Offset = "0xA0")]
	public float m_RemainingHours;

	[Token(Token = "0x400961F")]
	[FieldOffset(Offset = "0xA4")]
	public float m_TimeSpentIndoor;

	[Token(Token = "0x4009620")]
	[FieldOffset(Offset = "0xA8")]
	public float m_TimeSpentInsideSafePlace;

	[Token(Token = "0x4009621")]
	[FieldOffset(Offset = "0xAC")]
	public float m_ChaneOfGettingInterruptedSleep;

	[Token(Token = "0x600830D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InsomniaParamsSaveDataProxy()
	{
	}
}
