using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001E3")]
public class Fatigue : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x40010B4")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentFatigueBurnPerHour;

	[Token(Token = "0x40010B5")]
	[FieldOffset(Offset = "0x24")]
	public float m_CurrentFatigue;

	[Token(Token = "0x40010B6")]
	[FieldOffset(Offset = "0x28")]
	public float m_MaxFatigue;

	[Range(0f, 100f)]
	[Token(Token = "0x40010B7")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FatigueIncreasePerHourStanding;

	[Range(0f, 100f)]
	[Token(Token = "0x40010B8")]
	[FieldOffset(Offset = "0x30")]
	public float m_FatigueIncreasePerHourWalking;

	[Token(Token = "0x40010B9")]
	[FieldOffset(Offset = "0x34")]
	public float m_FatigueIncreasePerHourSprintingMin;

	[Token(Token = "0x40010BA")]
	[FieldOffset(Offset = "0x38")]
	public float m_FatigueIncreasePerHourSprintingMax;

	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x3C")]
	public float m_SecondsSprintingForMaxFatigueIncrease;

	[Tooltip("When running, scale the fatigue increase per hour based on how full player backpack is.")]
	[Range(1f, 10f)]
	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x40")]
	public float m_FullBackPackScaleFactor;

	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x44")]
	public float m_RestedThreshold;

	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x48")]
	public float m_SlightlyTiredThreshold;

	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x4C")]
	public float m_TiredThreshold;

	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x50")]
	public float m_VeryTiredThreshold;

	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x54")]
	public float m_ExhaustedThreshold;

	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x58")]
	public string m_SlightlyTiredVoiceOver;

	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x60")]
	public string m_TiredVoiceOver;

	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x68")]
	public string m_VeryTiredVoiceOver;

	[Token(Token = "0x40010C5")]
	[FieldOffset(Offset = "0x70")]
	public string m_ExhaustedVoiceOver;

	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x78")]
	public float m_MinSecondsBetweenVoiceOverVariations;

	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x7C")]
	public float m_TimeToDisplayFatigueWhenChanged;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40010C8")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x88")]
	private FatigueLevel m_FatigueLevelForPreviousVoiceOver;

	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x8C")]
	private float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x40010CB")]
	[FieldOffset(Offset = "0x90")]
	private float m_TimeDisableFatigueOnHUD;

	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x94")]
	private int m_FatigueLevelLastStatusChange;

	[Token(Token = "0x40010CD")]
	[FieldOffset(Offset = "0x98")]
	private bool m_ExhaustedInLog;

	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x99")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_SuppressVoiceOver;

	[Token(Token = "0x40010D0")]
	[FieldOffset(Offset = "0x9C")]
	private float m_TotalFatigueBurnPerHour;

	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0xA0")]
	private float m_FatigueValueLastFrame;

	[Token(Token = "0x40010D2")]
	private static FatigueSaveDataProxy m_FatigueSaveDataProxy;

	[Header("Breathing States")]
	[Range(0f, 10f)]
	[Token(Token = "0x40010D3")]
	[FieldOffset(Offset = "0xA4")]
	public float m_PauseBreathingAfterSpeech;

	[Range(0f, 60f)]
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0xA8")]
	public float m_SuppressVOAfterRopeExertionSeconds;

	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0xAC")]
	public HeavyBreathingLevels m_MinSecondsPerState;

	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0xB8")]
	public HeavyBreathingLevels m_GeneralBreathThresholds;

	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0xC4")]
	public HeavyBreathingLevels m_RopeClimbBreathThresholds;

	[Range(0f, 1f)]
	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0xD0")]
	public float m_NormalizedCriticalHealth;

	[Range(0f, 1f)]
	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0xD4")]
	public float m_NormalizedSeriousHealth;

	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0xD8")]
	public HeavyBreathingState m_InclineMinState;

	[Range(0f, 10f)]
	[Token(Token = "0x40010DB")]
	[FieldOffset(Offset = "0xDC")]
	public float m_InclineBreathingStartDelay;

	[Range(0f, 90f)]
	[Token(Token = "0x40010DC")]
	[FieldOffset(Offset = "0xE0")]
	public float m_InclineAngle;

	[Token(Token = "0x40010DD")]
	[FieldOffset(Offset = "0xE4")]
	public HeavyBreathingState m_SprintDisabledState;

	[Header("Catch Breath")]
	[Token(Token = "0x40010DE")]
	[FieldOffset(Offset = "0xE8")]
	public bool m_EnableCatchBreath;

	[Range(0f, 100f)]
	[Token(Token = "0x40010DF")]
	[FieldOffset(Offset = "0xEC")]
	public float m_StaminaLevelForRecovery;

	[Token(Token = "0x40010E0")]
	[FieldOffset(Offset = "0xF0")]
	private HeavyBreathingState m_HeavyBreathingState;

	[Token(Token = "0x40010E1")]
	[FieldOffset(Offset = "0xF4")]
	private float m_SecondsInCurrentState;

	[Token(Token = "0x40010E2")]
	[FieldOffset(Offset = "0xF8")]
	private float m_SecondsOnIncline;

	[Token(Token = "0x40010E3")]
	[FieldOffset(Offset = "0xFC")]
	private bool m_SuppressCatchBreathAudio;

	[Token(Token = "0x40010E4")]
	[FieldOffset(Offset = "0xFD")]
	private bool m_SuppressHeavyBreathing;

	[Token(Token = "0x40010E5")]
	[FieldOffset(Offset = "0xFE")]
	private bool m_StaminaWasBelowLevelForRecovery;

	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x100")]
	private float m_RopeActivitySpeechSuppressionTime;

	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x104")]
	private float m_LastBreathLevelRTPCSent;

	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x108")]
	private float m_LastInclineAngle;

	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x10C")]
	private float m_SinInclineAngle;

	[Token(Token = "0x6001125")]
	[Address(RVA = "0x638A10", Offset = "0x637810", Length = "0x117")]
	public void Start()
	{
	}

	[Token(Token = "0x6001126")]
	[Address(RVA = "0x638B30", Offset = "0x637930", Length = "0x25D")]
	public void Update()
	{
	}

	[Token(Token = "0x6001127")]
	[Address(RVA = "0x638D90", Offset = "0x637B90", Length = "0xF5")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001128")]
	[Address(RVA = "0x638E90", Offset = "0x637C90", Length = "0x16D")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001129")]
	[Address(RVA = "0x639000", Offset = "0x637E00", Length = "0x1CF")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600112A")]
	[Address(RVA = "0x6391D0", Offset = "0x637FD0", Length = "0x15D")]
	public string GetFatigueStateString()
	{
		return null;
	}

	[Token(Token = "0x600112B")]
	[Address(RVA = "0x639330", Offset = "0x638130", Length = "0x26")]
	public float GetNormalizedFatigue()
	{
		return 0f;
	}

	[Token(Token = "0x600112C")]
	[Address(RVA = "0x639360", Offset = "0x638160", Length = "0xB")]
	public void AddFatigue(float fatigueValue)
	{
	}

	[Token(Token = "0x600112D")]
	[Address(RVA = "0x639370", Offset = "0x638170", Length = "0x30E")]
	public void AddFatigue(float fatigueValue, FatigueFlags flags)
	{
	}

	[Token(Token = "0x600112E")]
	[Address(RVA = "0x639680", Offset = "0x638480", Length = "0xD")]
	public bool IsExhausted()
	{
		return false;
	}

	[Token(Token = "0x600112F")]
	[Address(RVA = "0x507980", Offset = "0x506780", Length = "0x9")]
	public float GetCurrentTotalFatigueBurnPerHour()
	{
		return 0f;
	}

	[Token(Token = "0x6001130")]
	[Address(RVA = "0x639690", Offset = "0x638490", Length = "0x7")]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[Token(Token = "0x6001131")]
	[Address(RVA = "0x638D90", Offset = "0x637B90", Length = "0xF5")]
	private void CalculateTotalFatigueBurnPerHour()
	{
	}

	[Token(Token = "0x6001132")]
	[Address(RVA = "0x6396A0", Offset = "0x6384A0", Length = "0x33")]
	private FatigueLevel GetFatigueLevel()
	{
		return default(FatigueLevel);
	}

	[Token(Token = "0x6001133")]
	[Address(RVA = "0x6396E0", Offset = "0x6384E0", Length = "0xBD")]
	private void DisplayFatigueOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x6001134")]
	[Address(RVA = "0x6397A0", Offset = "0x6385A0", Length = "0xD8")]
	private string GetFatigueTextForHud()
	{
		return null;
	}

	[Token(Token = "0x6001135")]
	[Address(RVA = "0x639880", Offset = "0x638680", Length = "0x29C")]
	private void MaybeUpdateFatigueStatusLabel()
	{
	}

	[Token(Token = "0x6001136")]
	[Address(RVA = "0x639B20", Offset = "0x638920", Length = "0x393")]
	private void UpdateFatigueStatusOnHUD()
	{
	}

	[Token(Token = "0x6001137")]
	[Address(RVA = "0x639EC0", Offset = "0x638CC0", Length = "0xC4")]
	private bool ShouldPlayFatigueVoiceOver()
	{
		return false;
	}

	[Token(Token = "0x6001138")]
	[Address(RVA = "0x639F90", Offset = "0x638D90", Length = "0x1E8")]
	private void MaybePlayFatigueVoiceOver()
	{
	}

	[Token(Token = "0x6001139")]
	[Address(RVA = "0x63A180", Offset = "0x638F80", Length = "0x132")]
	private void MaybeUpdateExhaustedStatusInLog()
	{
	}

	[Token(Token = "0x600113A")]
	[Address(RVA = "0x63A2C0", Offset = "0x6390C0", Length = "0x4DC")]
	private float CalculateFatigueIncrease(float realtimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x600113B")]
	[Address(RVA = "0x63A7A0", Offset = "0x6395A0", Length = "0x7")]
	public void SuppressHeavyBreathing(bool suppress)
	{
	}

	[Token(Token = "0x600113C")]
	[Address(RVA = "0x63A7B0", Offset = "0x6395B0", Length = "0x207")]
	public static void EndSuppressHeavyBreathingCallback()
	{
	}

	[Token(Token = "0x600113D")]
	[Address(RVA = "0x63A9C0", Offset = "0x6397C0", Length = "0xA")]
	public void ResetMovementTimers()
	{
	}

	[Token(Token = "0x600113E")]
	[Address(RVA = "0x63A9D0", Offset = "0x6397D0", Length = "0x20")]
	public void HeavyBreathingInit()
	{
	}

	[Token(Token = "0x600113F")]
	[Address(RVA = "0x63A9F0", Offset = "0x6397F0", Length = "0x13C")]
	private bool MovingUpIncline()
	{
		return false;
	}

	[Token(Token = "0x6001140")]
	[Address(RVA = "0x63AB30", Offset = "0x639930", Length = "0x367")]
	private void UpdateHeavyBreathing()
	{
	}

	[Token(Token = "0x6001141")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void UpdateDebugText(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6001142")]
	[Address(RVA = "0x5025F0", Offset = "0x5013F0", Length = "0x7")]
	public HeavyBreathingState GetHeavyBreathingState()
	{
		return default(HeavyBreathingState);
	}

	[Token(Token = "0x6001143")]
	[Address(RVA = "0x63AEA0", Offset = "0x639CA0", Length = "0xB1")]
	private void CatchBreath()
	{
	}

	[Token(Token = "0x6001144")]
	[Address(RVA = "0x63AF60", Offset = "0x639D60", Length = "0x15D")]
	private void MaybeCatchBreath()
	{
	}

	[Token(Token = "0x6001145")]
	[Address(RVA = "0x63B0C0", Offset = "0x639EC0", Length = "0x10C")]
	private void UpdateHeavyBreathingLoopRTPC()
	{
	}

	[Token(Token = "0x6001146")]
	[Address(RVA = "0x63B1D0", Offset = "0x639FD0", Length = "0x60")]
	private void SetHeavyBreathingState(HeavyBreathingState state)
	{
	}

	[Token(Token = "0x6001147")]
	[Address(RVA = "0x63B230", Offset = "0x63A030", Length = "0x348")]
	private void MaybePlayHeavyBreathingLoop()
	{
	}

	[Token(Token = "0x6001148")]
	[Address(RVA = "0x63B580", Offset = "0x63A380", Length = "0x140")]
	private HeavyBreathingState ComputeHeavyBreathingState(HeavyBreathingLevels thresholds)
	{
		return default(HeavyBreathingState);
	}

	[Token(Token = "0x6001149")]
	[Address(RVA = "0x63B6D0", Offset = "0x63A4D0", Length = "0x61")]
	public bool HeavyBreathingShouldSuppressVO()
	{
		return false;
	}

	[Token(Token = "0x600114A")]
	[Address(RVA = "0x63B740", Offset = "0x63A540", Length = "0x7F")]
	public Fatigue()
	{
	}
}
