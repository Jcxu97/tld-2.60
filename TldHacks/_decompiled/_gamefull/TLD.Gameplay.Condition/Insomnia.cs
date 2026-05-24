using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay.Condition;

[Token(Token = "0x20014CA")]
public class Insomnia
{
	[Token(Token = "0x4009622")]
	[FieldOffset(Offset = "0x10")]
	public InsomniaCause m_Cause;

	[Token(Token = "0x4009623")]
	[FieldOffset(Offset = "0x14")]
	public InsomniaStatus m_InsomniaStatus;

	[Token(Token = "0x4009624")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_InsomniaCausedByLocalizedId;

	[Token(Token = "0x4009625")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_InsomniaRiskLocalizedId;

	[Token(Token = "0x4009626")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_InsomniaRiskDescription;

	[Token(Token = "0x4009627")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_InsomniaRiskTreatmentRequiredDescription;

	[Token(Token = "0x4009628")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_InsomniaRiskHealedLocalizedId;

	[Token(Token = "0x4009629")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_InsomniaAfflictionLocalizedId;

	[Token(Token = "0x400962A")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_InsomniaAfflictionDescription;

	[Token(Token = "0x400962B")]
	[FieldOffset(Offset = "0x50")]
	public LocalizedString m_InsomniaAfflictionTreatmentRequiredDescription;

	[Token(Token = "0x400962C")]
	[FieldOffset(Offset = "0x58")]
	public int m_HoursRequiredToExitAffliction;

	[Token(Token = "0x400962D")]
	[FieldOffset(Offset = "0x60")]
	private string m_InsomniaRiskIcoName;

	[Token(Token = "0x400962E")]
	[FieldOffset(Offset = "0x68")]
	private float m_HoursRequiredToTurnRiskToAffliction;

	[Token(Token = "0x400962F")]
	[FieldOffset(Offset = "0x6C")]
	private float m_OutdoorRiskIncreaseSpeedModifier;

	[Token(Token = "0x4009630")]
	[FieldOffset(Offset = "0x70")]
	private float m_InsideRiskIncreaseSpeedModifier;

	[Token(Token = "0x4009631")]
	[FieldOffset(Offset = "0x74")]
	private float m_SafePlaceRiskDecreaseSpeedModifier;

	[Token(Token = "0x4009632")]
	[FieldOffset(Offset = "0x78")]
	private LocalizedString m_InsomniaAfflictionHealedLocalizedId;

	[Token(Token = "0x4009633")]
	[FieldOffset(Offset = "0x80")]
	private string m_InsomniaAfflictionIcoName;

	[Token(Token = "0x4009634")]
	[FieldOffset(Offset = "0x88")]
	private int m_MinHoursRequiredToRemoveAffliction;

	[Token(Token = "0x4009635")]
	[FieldOffset(Offset = "0x8C")]
	private int m_MaxHoursRequiredToRemoveAffliction;

	[Token(Token = "0x4009636")]
	[FieldOffset(Offset = "0x90")]
	private float m_StartTimeInGameHours;

	[Token(Token = "0x4009637")]
	[FieldOffset(Offset = "0x94")]
	private float m_RiskProgress;

	[Token(Token = "0x4009638")]
	[FieldOffset(Offset = "0x98")]
	private bool m_CanPassAffliction;

	[Token(Token = "0x4009639")]
	[FieldOffset(Offset = "0xA0")]
	private string m_InsomniaStartAudio;

	[Token(Token = "0x400963A")]
	[FieldOffset(Offset = "0xA8")]
	private float m_RemainingHours;

	[Token(Token = "0x400963B")]
	[FieldOffset(Offset = "0xAC")]
	private float m_TimeSpentIndoor;

	[Token(Token = "0x400963C")]
	[FieldOffset(Offset = "0xB0")]
	private float m_TimeSpentInsideSafePlace;

	[Token(Token = "0x400963D")]
	[FieldOffset(Offset = "0xB4")]
	private float m_ChaneOfGettingInterruptedSleep;

	[Token(Token = "0x400963E")]
	[FieldOffset(Offset = "0xB8")]
	private float m_MinChanceHowBadlySleepInterrupted;

	[Token(Token = "0x400963F")]
	[FieldOffset(Offset = "0xBC")]
	private float m_MaxChanceHowBadlySleepInterrupted;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4009640")]
	[FieldOffset(Offset = "0xC0")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4009641")]
	[FieldOffset(Offset = "0xC8")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[Token(Token = "0x600830E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Insomnia()
	{
	}

	[Token(Token = "0x600830F")]
	[Address(RVA = "0x12410A0", Offset = "0x123FEA0", Length = "0x496")]
	public Insomnia(InsomniaData data)
	{
	}

	[Token(Token = "0x6008310")]
	[Address(RVA = "0x1241540", Offset = "0x1240340", Length = "0x4DA")]
	public InsomniaParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008311")]
	[Address(RVA = "0x1241A20", Offset = "0x1240820", Length = "0x622")]
	public void Deserialize(InsomniaParamsSaveDataProxy saveDataProxy)
	{
	}

	[Token(Token = "0x6008312")]
	[Address(RVA = "0x1242050", Offset = "0x1240E50", Length = "0x1F")]
	public void UpdateInsomnia()
	{
	}

	[Token(Token = "0x6008313")]
	[Address(RVA = "0x40E0C0", Offset = "0x40CEC0", Length = "0x4")]
	public void SetStatus(InsomniaStatus status)
	{
	}

	[Token(Token = "0x6008314")]
	[Address(RVA = "0x1242070", Offset = "0x1240E70", Length = "0xA1")]
	public float GetAfflictionHoursRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x6008315")]
	[Address(RVA = "0xA59A60", Offset = "0xA58860", Length = "0x9")]
	public float GetRiskProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6008316")]
	[Address(RVA = "0x1242120", Offset = "0x1240F20", Length = "0x188")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6008317")]
	[Address(RVA = "0x12422B0", Offset = "0x12410B0", Length = "0x71")]
	public bool ShouldInterruptSleep(float chanceMultiplier)
	{
		return false;
	}

	[Token(Token = "0x6008318")]
	[Address(RVA = "0x1242330", Offset = "0x1241130", Length = "0x42")]
	public float GetChanceOfHowBadlySleepIsInterrupted(float chanceMultiplier)
	{
		return 0f;
	}

	[Token(Token = "0x6008319")]
	[Address(RVA = "0x1242380", Offset = "0x1241180", Length = "0xD")]
	public bool AfflictionIsActive()
	{
		return false;
	}

	[Token(Token = "0x600831A")]
	[Address(RVA = "0x1242390", Offset = "0x1241190", Length = "0xC")]
	public bool RiskIsActive()
	{
		return false;
	}

	[Token(Token = "0x600831B")]
	[Address(RVA = "0x12423A0", Offset = "0x12411A0", Length = "0x39A")]
	public void StartRisk()
	{
	}

	[Token(Token = "0x600831C")]
	[Address(RVA = "0x1242740", Offset = "0x1241540", Length = "0x1B9")]
	private void ShowRiskNotification()
	{
	}

	[Token(Token = "0x600831D")]
	[Address(RVA = "0x1242900", Offset = "0x1241700", Length = "0x28D")]
	private void MaybeUpdateRisk()
	{
	}

	[Token(Token = "0x600831E")]
	[Address(RVA = "0x1242B90", Offset = "0x1241990", Length = "0x2FA")]
	private void HealRisk()
	{
	}

	[Token(Token = "0x600831F")]
	[Address(RVA = "0x1242E90", Offset = "0x1241C90", Length = "0x2E3")]
	public void StartAffliction()
	{
	}

	[Token(Token = "0x6008320")]
	[Address(RVA = "0x1243180", Offset = "0x1241F80", Length = "0x252")]
	private void ShowAfflictionNotification()
	{
	}

	[Token(Token = "0x6008321")]
	[Address(RVA = "0x12433E0", Offset = "0x12421E0", Length = "0x1FC")]
	private void MaybeUpdateAffliction()
	{
	}

	[Token(Token = "0x6008322")]
	[Address(RVA = "0x12435E0", Offset = "0x12423E0", Length = "0x325")]
	private void HealAffliction()
	{
	}

	[Token(Token = "0x6008323")]
	[Address(RVA = "0x1243910", Offset = "0x1242710", Length = "0x84")]
	private void ApplyInsomniaExitEffects()
	{
	}

	[Token(Token = "0x6008324")]
	[Address(RVA = "0x12439A0", Offset = "0x12427A0", Length = "0x34")]
	private void OnWeatherStageChanged(WeatherSetStage current)
	{
	}

	[Token(Token = "0x6008325")]
	[Address(RVA = "0x5023C0", Offset = "0x5011C0", Length = "0x9")]
	private float GetRemainingHours()
	{
		return 0f;
	}
}
