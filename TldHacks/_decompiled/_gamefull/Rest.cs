using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000438")]
public class Rest : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x2000439")]
	public enum PassTimeOptions
	{
		[Token(Token = "0x4002608")]
		None = 0,
		[Token(Token = "0x4002609")]
		DoFade = 2,
		[Token(Token = "0x400260A")]
		DisplayCancelButton = 4
	}

	[Token(Token = "0x200043A")]
	public class PassTimeHelper
	{
		[Token(Token = "0x400260B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_PreviousFrostbiteState;

		[Token(Token = "0x400260C")]
		[FieldOffset(Offset = "0x11")]
		private bool m_PreviousHypothermiaState;

		[Token(Token = "0x400260D")]
		[FieldOffset(Offset = "0x12")]
		private bool m_PreviousPassTimeUISuppressedState;

		[Token(Token = "0x400260E")]
		[FieldOffset(Offset = "0x13")]
		private bool m_PreviousLabelMessageState;

		[Token(Token = "0x400260F")]
		[FieldOffset(Offset = "0x18")]
		private Panel_HUD m_HUD;

		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0x20")]
		private Panel_FeedFire m_FeedFire;

		[Token(Token = "0x4002611")]
		[FieldOffset(Offset = "0x28")]
		private Panel_Cooking m_Cooking;

		[Token(Token = "0x4002612")]
		[FieldOffset(Offset = "0x30")]
		private Panel_CookWater m_CookWater;

		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x1A6C9F0", Offset = "0x1A6B7F0", Length = "0x269")]
		private static bool TryGetPanel<T>(out T panel, ref T cache) where T : Panel_Base
		{
			panel = null;
			return false;
		}

		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x7E5080", Offset = "0x7E3E80", Length = "0x49B")]
		public void PassTime(int hours)
		{
		}

		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x7E5520", Offset = "0x7E4320", Length = "0x229")]
		private void OnSleepEnd()
		{
		}

		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PassTimeHelper()
		{
		}
	}

	[Header("General")]
	[Token(Token = "0x40025E6")]
	[FieldOffset(Offset = "0x20")]
	public float m_ReduceFatiguePerHourRest;

	[Token(Token = "0x40025E7")]
	[FieldOffset(Offset = "0x24")]
	public int m_MaxHoursSleepPerDay;

	[Token(Token = "0x40025E8")]
	[FieldOffset(Offset = "0x28")]
	public float m_SleepFadeOutSeconds;

	[Header("Interruption")]
	[Token(Token = "0x40025E9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_WolfPrefab;

	[Token(Token = "0x40025EA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BearPrefab;

	[Range(0f, 100f)]
	[Token(Token = "0x40025EB")]
	[FieldOffset(Offset = "0x40")]
	public float m_ChancePredatorInterruptionInsideSpawnRegion;

	[Range(0f, 100f)]
	[Token(Token = "0x40025EC")]
	[FieldOffset(Offset = "0x44")]
	public float m_ChancePredatorInterruptionInsideSpawnRegionWhenInSnowShelter;

	[Range(0f, 100f)]
	[Token(Token = "0x40025ED")]
	[FieldOffset(Offset = "0x48")]
	public float m_DistanceFireProtectsFromPredatorInterruption;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40025EE")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_HUD> m_HUDReference;

	[SerializeField]
	[Token(Token = "0x40025EF")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_Rest> m_RestPanel;

	[HideInInspector]
	[Token(Token = "0x40025F0")]
	[FieldOffset(Offset = "0x60")]
	public bool m_WakeUpAtFullRest;

	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0x61")]
	private bool m_Sleeping;

	[Token(Token = "0x40025F2")]
	[FieldOffset(Offset = "0x64")]
	private float m_NumSecondsSleeping;

	[Token(Token = "0x40025F3")]
	[FieldOffset(Offset = "0x68")]
	private float m_SleepDurationSeconds;

	[Token(Token = "0x40025F4")]
	[FieldOffset(Offset = "0x6C")]
	private float m_SleepDurationHours;

	[Token(Token = "0x40025F5")]
	[FieldOffset(Offset = "0x70")]
	private float m_DayLengthScaleBeforeSleeping;

	[Token(Token = "0x40025F6")]
	[FieldOffset(Offset = "0x74")]
	private int m_InterruptionAfterSecondsSleeping;

	[Token(Token = "0x40025F7")]
	[FieldOffset(Offset = "0x78")]
	private bool m_PredatorInterruption;

	[Token(Token = "0x40025F8")]
	[FieldOffset(Offset = "0x80")]
	private Bed m_Bed;

	[Token(Token = "0x40025F9")]
	[FieldOffset(Offset = "0x88")]
	private int[] m_LastTwentyFourHoursOfSleep;

	[Token(Token = "0x40025FA")]
	[FieldOffset(Offset = "0x90")]
	private int m_HourLastFrame;

	[Token(Token = "0x40025FB")]
	[FieldOffset(Offset = "0x94")]
	private int m_LastDisplayedDayNumberOnAwake;

	[Token(Token = "0x40025FC")]
	[FieldOffset(Offset = "0x98")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x40025FD")]
	[FieldOffset(Offset = "0x99")]
	private bool m_ShouldInterruptWhenFreezing;

	[Token(Token = "0x40025FE")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40025FF")]
	[FieldOffset(Offset = "0x9B")]
	private bool m_ForceSleepLength;

	[Token(Token = "0x4002600")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_ForceSleepWakeTime;

	[Token(Token = "0x4002601")]
	[FieldOffset(Offset = "0xA0")]
	private float m_ForcedWakeTime;

	[Token(Token = "0x4002602")]
	[FieldOffset(Offset = "0xA4")]
	private int m_ForcedSleepLength;

	[Token(Token = "0x4002603")]
	[FieldOffset(Offset = "0xA8")]
	private PassTimeOptions m_PassTimeOptions;

	[Token(Token = "0x4002604")]
	private static RestSaveDataProxy m_RestSaveDataProxy;

	[Token(Token = "0x4002605")]
	[FieldOffset(Offset = "0xB0")]
	private Action m_OnSleepEnd;

	[Token(Token = "0x4002606")]
	[FieldOffset(Offset = "0xB8")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x7DFBA0", Offset = "0x7DE9A0", Length = "0xF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x7DFCA0", Offset = "0x7DEAA0", Length = "0x8A")]
	public void Start()
	{
	}

	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x7DFD30", Offset = "0x7DEB30", Length = "0x195")]
	public void Update()
	{
	}

	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x7DFED0", Offset = "0x7DECD0", Length = "0x221")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x7E0100", Offset = "0x7DEF00", Length = "0x1B7")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x7E02C0", Offset = "0x7DF0C0", Length = "0x12D")]
	private void MaybeTriggerAchievement(Bed bed)
	{
	}

	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x7E03F0", Offset = "0x7DF1F0", Length = "0x2D")]
	public void BeginSleeping(Bed b, int durationHours, int maxHours)
	{
	}

	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x7E0420", Offset = "0x7DF220", Length = "0x5")]
	public bool IsSleeping()
	{
		return false;
	}

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x7E0430", Offset = "0x7DF230", Length = "0x4CB")]
	public void EndSleeping(bool interrupted)
	{
	}

	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x7E0900", Offset = "0x7DF700", Length = "0x4C")]
	public int GetNumHoursSleptInLastTwentyFour()
	{
		return 0;
	}

	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x7E0950", Offset = "0x7DF750", Length = "0xB0")]
	public int GetNumHoursSleptSinceMidnight()
	{
		return 0;
	}

	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x7E0A10", Offset = "0x7DF810", Length = "0x51")]
	public bool AllowedToSleepAmount(int amount)
	{
		return false;
	}

	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x7E0A70", Offset = "0x7DF870", Length = "0xF2")]
	public float GetBedWarmthBonusCelsius()
	{
		return 0f;
	}

	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x7E0B70", Offset = "0x7DF970", Length = "0x33D")]
	public bool RestNeededForAffliction()
	{
		return false;
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x7E0EB0", Offset = "0x7DFCB0", Length = "0xE")]
	public void SetForceSleepLength(int hours)
	{
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x7E0EC0", Offset = "0x7DFCC0", Length = "0x18")]
	public void SetForceSleepWakeTime(float wakeTime)
	{
	}

	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x7E0EE0", Offset = "0x7DFCE0", Length = "0x12")]
	public void ClearForceSleepLength()
	{
	}

	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0x7E0F00", Offset = "0x7DFD00", Length = "0x12")]
	public void ClearForceSleepWakeTime()
	{
	}

	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x7E0F20", Offset = "0x7DFD20", Length = "0x8")]
	public bool IsForcedSleep()
	{
		return false;
	}

	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x7E0F30", Offset = "0x7DFD30", Length = "0x97")]
	public bool AllowUnlimitedSleep()
	{
		return false;
	}

	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x7E0FD0", Offset = "0x7DFDD0", Length = "0xC7")]
	private void UpdateFatigue(float todSeconds)
	{
	}

	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x7E10A0", Offset = "0x7DFEA0", Length = "0x3A5")]
	private void UpdateCondition(float todSeconds)
	{
	}

	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x7E1450", Offset = "0x7E0250", Length = "0x679")]
	private void UpdateRestForCures(float todSeconds)
	{
	}

	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x7E1AD0", Offset = "0x7E08D0", Length = "0xAF")]
	private bool IsFearOrAnxietyPreventingSleep()
	{
		return false;
	}

	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x7E1B80", Offset = "0x7E0980", Length = "0xE3")]
	private bool ShouldInterruptSleepWithInsomnia()
	{
		return false;
	}

	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x7E1C70", Offset = "0x7E0A70", Length = "0x9E")]
	private float GetChanceOfHowBadlySleepIsIntnerrupted()
	{
		return 0f;
	}

	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x7E1D10", Offset = "0x7E0B10", Length = "0xA7")]
	private bool ShouldInterruptSleep()
	{
		return false;
	}

	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x7E1DC0", Offset = "0x7E0BC0", Length = "0x745")]
	private void UpdateWhenSleeping()
	{
	}

	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x7E2510", Offset = "0x7E1310", Length = "0x11B")]
	private void UpdateLogWithPredatorInterruption()
	{
	}

	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x7E2630", Offset = "0x7E1430", Length = "0x11B")]
	private void UpdateLogWithHoursSlept()
	{
	}

	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0x7E2750", Offset = "0x7E1550", Length = "0x224")]
	private void DisplayDayNumber()
	{
	}

	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0x7E2980", Offset = "0x7E1780", Length = "0x254")]
	private void RollForRestInterruption()
	{
	}

	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0x7E2BE0", Offset = "0x7E19E0", Length = "0x392")]
	private bool CanSpawnPredator()
	{
		return false;
	}

	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0x7E2F80", Offset = "0x7E1D80", Length = "0x82A")]
	private void SpawnPredator()
	{
	}

	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0x7E37B0", Offset = "0x7E25B0", Length = "0x8F4")]
	private bool ShouldInterruptWithPredator()
	{
		return false;
	}

	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0x7E40B0", Offset = "0x7E2EB0", Length = "0x74")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0x7E4130", Offset = "0x7E2F30", Length = "0xBD")]
	private void AccelerateTimeOfDay(int minutes, float fadeOutSeconds, bool useFade)
	{
	}

	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x7E41F0", Offset = "0x7E2FF0", Length = "0xF1")]
	private void TrackHoursOfSleep()
	{
	}

	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x7E42F0", Offset = "0x7E30F0", Length = "0x40E")]
	private Fire GetNearbyBuringFire()
	{
		return null;
	}

	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0x7E4700", Offset = "0x7E3500", Length = "0x2ED")]
	private bool ShouldInterruptIfFreezingStartsWhileSleeping()
	{
		return false;
	}

	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x7E49F0", Offset = "0x7E37F0", Length = "0xB")]
	public bool CanUseFade()
	{
		return false;
	}

	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x7E4A00", Offset = "0x7E3800", Length = "0xB")]
	public bool CanDisplayCancelButton()
	{
		return false;
	}

	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x7E4A10", Offset = "0x7E3810", Length = "0x40F")]
	public void BeginSleeping(Bed b, int durationHours, int maxHours, float fadeOutDuration, PassTimeOptions options, Action onSleepEnd)
	{
	}

	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0x7E4E20", Offset = "0x7E3C20", Length = "0x158")]
	private Panel_HUD GetHUD()
	{
		return null;
	}

	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x7E4F80", Offset = "0x7E3D80", Length = "0x4A")]
	public Rest()
	{
	}
}
