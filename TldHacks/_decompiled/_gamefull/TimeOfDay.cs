using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000314")]
public class TimeOfDay : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000315")]
	private sealed class _003CAccelerateCo_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B40")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B41")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B42")]
		[FieldOffset(Offset = "0x20")]
		public TimeOfDay _003C_003E4__this;

		[Token(Token = "0x4001B43")]
		[FieldOffset(Offset = "0x28")]
		public float realtimeDurationSeconds;

		[Token(Token = "0x4001B44")]
		[FieldOffset(Offset = "0x2C")]
		public float minutes;

		[Token(Token = "0x4001B45")]
		[FieldOffset(Offset = "0x30")]
		private float _003CdayLengthScaleBeforeAccelerate_003E5__2;

		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x34")]
		private float _003Ctimer_003E5__3;

		[Token(Token = "0x170001FA")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FB")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6001947")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CAccelerateCo_003Ed__105(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6001944")]
		[Address(RVA = "0x730D70", Offset = "0x72FB70", Length = "0x185")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x730F00", Offset = "0x72FD00", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4001B14")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_UniStormPrefab;

	[HideInInspector]
	[Token(Token = "0x4001B15")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_UniStorm;

	[HideInInspector]
	[Token(Token = "0x4001B16")]
	[FieldOffset(Offset = "0x30")]
	public int m_DebugTimeSpeedupCounter;

	[Token(Token = "0x4001B17")]
	[FieldOffset(Offset = "0x34")]
	public int m_StartTimeHour;

	[Token(Token = "0x4001B18")]
	[FieldOffset(Offset = "0x38")]
	public int m_StartTimeMinutes;

	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0x3C")]
	public int m_DayDurationInMinutes;

	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0x40")]
	public int m_NightDurationInMinutes;

	[Token(Token = "0x4001B1B")]
	[FieldOffset(Offset = "0x44")]
	public int m_DawnStingerHourStart;

	[Token(Token = "0x4001B1C")]
	[FieldOffset(Offset = "0x48")]
	public int m_DawnStingerMinutesStart;

	[Token(Token = "0x4001B1D")]
	[FieldOffset(Offset = "0x4C")]
	public int m_NightStingerHourStart;

	[Token(Token = "0x4001B1E")]
	[FieldOffset(Offset = "0x50")]
	public int m_NightStingerMinutesStart;

	[Token(Token = "0x4001B1F")]
	[FieldOffset(Offset = "0x58")]
	public AK.Wwise.Event m_DawnStingerEvent;

	[Token(Token = "0x4001B20")]
	[FieldOffset(Offset = "0x60")]
	public AK.Wwise.Event m_NightStingerEvent;

	[Token(Token = "0x4001B21")]
	[FieldOffset(Offset = "0x68")]
	public AK.Wwise.Event m_DawnVoiceOverEvent;

	[Token(Token = "0x4001B22")]
	[FieldOffset(Offset = "0x70")]
	public float m_DawnVoiceOverDelaySeconds;

	[Token(Token = "0x4001B23")]
	[FieldOffset(Offset = "0x78")]
	public AK.Wwise.Event m_NightVoiceOverEvent;

	[Token(Token = "0x4001B24")]
	[FieldOffset(Offset = "0x80")]
	public float m_NightVoiceOverDelaySeconds;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001B25")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUDReference;

	[HideInInspector]
	[Token(Token = "0x4001B26")]
	[FieldOffset(Offset = "0x90")]
	public UniStormWeatherSystem m_WeatherSystem;

	[Token(Token = "0x4001B27")]
	[FieldOffset(Offset = "0x98")]
	private float m_DayLengthScale;

	[Token(Token = "0x4001B28")]
	[FieldOffset(Offset = "0x9C")]
	private float m_DayLengthScaleDebug;

	[Token(Token = "0x4001B29")]
	[FieldOffset(Offset = "0xA0")]
	private int m_DayLastDawnStingerAudioPlayed;

	[Token(Token = "0x4001B2A")]
	[FieldOffset(Offset = "0xA4")]
	private int m_DayLastNightStingerAudioPlayed;

	[Token(Token = "0x4001B2B")]
	[FieldOffset(Offset = "0xA8")]
	private int m_DayLastDawnVoiceOverPlayed;

	[Token(Token = "0x4001B2C")]
	[FieldOffset(Offset = "0xAC")]
	private int m_DayLastNightVoiceOverPlayed;

	[Token(Token = "0x4001B2D")]
	[FieldOffset(Offset = "0xB0")]
	private AK.Wwise.Event m_NextVoiceOver;

	[Token(Token = "0x4001B2E")]
	[FieldOffset(Offset = "0xB8")]
	private float m_TimeToPlayNextVoiceOver;

	[Token(Token = "0x4001B2F")]
	[FieldOffset(Offset = "0xC0")]
	private StringBuilder m_StringBuilder;

	[Token(Token = "0x4001B30")]
	[FieldOffset(Offset = "0xC8")]
	private int m_HoursSurvivedLastFrame;

	[Token(Token = "0x4001B31")]
	[FieldOffset(Offset = "0xCC")]
	private int m_DaysSurvivedLastFrame;

	[Token(Token = "0x4001B32")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_WasNightLastFrame;

	[Token(Token = "0x4001B33")]
	[FieldOffset(Offset = "0xD4")]
	private int m_SkipUpdateCount;

	[Token(Token = "0x4001B34")]
	[FieldOffset(Offset = "0xD8")]
	private int m_LastHourSentToWise;

	[Token(Token = "0x4001B35")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4001B36")]
	[FieldOffset(Offset = "0xDD")]
	private bool m_WeatherInitializedForScene;

	[Token(Token = "0x4001B37")]
	[FieldOffset(Offset = "0xDE")]
	private bool m_WeatherInitializedAfterSceneLoad;

	[Token(Token = "0x4001B38")]
	[FieldOffset(Offset = "0xE0")]
	private int m_IsTimeLapseActiveCounter;

	[Token(Token = "0x4001B39")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_LockedTOD;

	[Token(Token = "0x4001B3A")]
	private static TimeOfDaySaveDataProxy m_TimeOfDaySaveDataProxy;

	[Token(Token = "0x4001B3B")]
	[FieldOffset(Offset = "0xE8")]
	private string m_CurrentScene;

	[Token(Token = "0x4001B3C")]
	[FieldOffset(Offset = "0xF0")]
	private int m_DayEntered;

	[Token(Token = "0x4001B3D")]
	[FieldOffset(Offset = "0xF4")]
	private int m_HourEntered;

	[Token(Token = "0x4001B3E")]
	[FieldOffset(Offset = "0xF8")]
	private Panel_Loading m_Loading;

	[Token(Token = "0x4001B3F")]
	[FieldOffset(Offset = "0x100")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x170001F9")]
	[field: Token(Token = "0x4001B13")]
	public static TimeOfDay Instance
	{
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x6FAE10", Offset = "0x6F9C10", Length = "0x53")]
		get;
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x6FAE70", Offset = "0x6F9C70", Length = "0xA7")]
		private set;
	}

	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9D20", Length = "0xCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001900")]
	[Address(RVA = "0x6FAFF0", Offset = "0x6F9DF0", Length = "0x45")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001901")]
	[Address(RVA = "0x6FB040", Offset = "0x6F9E40", Length = "0x183")]
	public void Start()
	{
	}

	[Token(Token = "0x6001902")]
	[Address(RVA = "0x6FB1D0", Offset = "0x6F9FD0", Length = "0x4B8")]
	public void Update()
	{
	}

	[Token(Token = "0x6001903")]
	[Address(RVA = "0x6FB690", Offset = "0x6FA490", Length = "0x378")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001904")]
	[Address(RVA = "0x6FBA10", Offset = "0x6FA810", Length = "0x3CD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001905")]
	[Address(RVA = "0x6FBDE0", Offset = "0x6FABE0", Length = "0x7")]
	public void SetTODLocked(bool isLocked)
	{
	}

	[Token(Token = "0x6001906")]
	[Address(RVA = "0x6FBDF0", Offset = "0x6FABF0", Length = "0x8")]
	public bool IsTODLocked()
	{
		return false;
	}

	[Token(Token = "0x6001907")]
	[Address(RVA = "0x602C90", Offset = "0x601A90", Length = "0x7")]
	public void TimeLapseBegin()
	{
	}

	[Token(Token = "0x6001908")]
	[Address(RVA = "0x6FBE00", Offset = "0x6FAC00", Length = "0x7")]
	public void TimeLapseEnd()
	{
	}

	[Token(Token = "0x6001909")]
	[Address(RVA = "0x6FBE10", Offset = "0x6FAC10", Length = "0x2A")]
	public float GetDayLengthSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x600190A")]
	[Address(RVA = "0x6FBE40", Offset = "0x6FAC40", Length = "0x22")]
	public float GetDayLengthSecondsUnscaled()
	{
		return 0f;
	}

	[Token(Token = "0x600190B")]
	[Address(RVA = "0x6FBE70", Offset = "0x6FAC70", Length = "0x278")]
	public void SetDayLengthScale(float scale)
	{
	}

	[Token(Token = "0x600190C")]
	[Address(RVA = "0x6FC0F0", Offset = "0x6FAEF0", Length = "0x22")]
	public float GetDayLengthScale()
	{
		return 0f;
	}

	[Token(Token = "0x600190D")]
	[Address(RVA = "0x6FC120", Offset = "0x6FAF20", Length = "0x131")]
	public bool IsTimeLapseActive()
	{
		return false;
	}

	[Token(Token = "0x600190E")]
	[Address(RVA = "0x6FC260", Offset = "0x6FB060", Length = "0x5E")]
	public bool IsDay()
	{
		return false;
	}

	[Token(Token = "0x600190F")]
	[Address(RVA = "0x6FC2C0", Offset = "0x6FB0C0", Length = "0x5B")]
	public bool IsMorning()
	{
		return false;
	}

	[Token(Token = "0x6001910")]
	[Address(RVA = "0x6FC320", Offset = "0x6FB120", Length = "0x5B")]
	public bool IsAfternoon()
	{
		return false;
	}

	[Token(Token = "0x6001911")]
	[Address(RVA = "0x6FC380", Offset = "0x6FB180", Length = "0x5E")]
	public bool IsNight()
	{
		return false;
	}

	[Token(Token = "0x6001912")]
	[Address(RVA = "0x6FC3E0", Offset = "0x6FB1E0", Length = "0x66")]
	public bool IsNightWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[Token(Token = "0x6001913")]
	[Address(RVA = "0x6FC450", Offset = "0x6FB250", Length = "0x66")]
	public bool IsDayWithExtendedHours(float extendedHours)
	{
		return false;
	}

	[Token(Token = "0x6001914")]
	[Address(RVA = "0x6FC4C0", Offset = "0x6FB2C0", Length = "0x46")]
	public bool IsNightPreMidnight()
	{
		return false;
	}

	[Token(Token = "0x6001915")]
	[Address(RVA = "0x6FC510", Offset = "0x6FB310", Length = "0x4A")]
	public bool IsNightPostMidnight()
	{
		return false;
	}

	[Token(Token = "0x6001916")]
	[Address(RVA = "0x6FC560", Offset = "0x6FB360", Length = "0x5E")]
	public bool IsDusk()
	{
		return false;
	}

	[Token(Token = "0x6001917")]
	[Address(RVA = "0x6FC5C0", Offset = "0x6FB3C0", Length = "0x5E")]
	public bool IsDawn()
	{
		return false;
	}

	[Token(Token = "0x6001918")]
	[Address(RVA = "0x6FC620", Offset = "0x6FB420", Length = "0x20")]
	public float GetProgressDusk()
	{
		return 0f;
	}

	[Token(Token = "0x6001919")]
	[Address(RVA = "0x6FC650", Offset = "0x6FB450", Length = "0x37")]
	public float GetDawnHourTime()
	{
		return 0f;
	}

	[Token(Token = "0x600191A")]
	[Address(RVA = "0x6FC690", Offset = "0x6FB490", Length = "0x20")]
	public float GetProgressDawn()
	{
		return 0f;
	}

	[Token(Token = "0x600191B")]
	[Address(RVA = "0x6FC6C0", Offset = "0x6FB4C0", Length = "0x20")]
	public int GetDayNumber()
	{
		return 0;
	}

	[Token(Token = "0x600191C")]
	[Address(RVA = "0x6FC6F0", Offset = "0x6FB4F0", Length = "0x2E")]
	public int GetHour()
	{
		return 0;
	}

	[Token(Token = "0x600191D")]
	[Address(RVA = "0x6FC720", Offset = "0x6FB520", Length = "0x55")]
	public int GetMinutes()
	{
		return 0;
	}

	[Token(Token = "0x600191E")]
	[Address(RVA = "0x6FC780", Offset = "0x6FB580", Length = "0x22")]
	public float GetNormalizedTime()
	{
		return 0f;
	}

	[Token(Token = "0x600191F")]
	[Address(RVA = "0x6FC7B0", Offset = "0x6FB5B0", Length = "0xCC")]
	public void SetNormalizedTime(float time)
	{
	}

	[Token(Token = "0x6001920")]
	[Address(RVA = "0x6FC880", Offset = "0x6FB680", Length = "0x16D")]
	public void SetNormalizedTime(float time, bool forceUpdate)
	{
	}

	[Token(Token = "0x6001921")]
	[Address(RVA = "0x6FC9F0", Offset = "0x6FB7F0", Length = "0x22")]
	public void SetUniStormAuroraAlpha(float alpha)
	{
	}

	[Token(Token = "0x6001922")]
	[Address(RVA = "0x6FCA20", Offset = "0x6FB820", Length = "0x286")]
	public string FormatTime(int hours, int minutes)
	{
		return null;
	}

	[Token(Token = "0x6001923")]
	[Address(RVA = "0x6FCCB0", Offset = "0x6FBAB0", Length = "0x187")]
	public void Accelerate(float realTimeSeconds, float gameTimeHours, bool doFadeToBlack = true)
	{
	}

	[Token(Token = "0x6001924")]
	[Address(RVA = "0x6FCE40", Offset = "0x6FBC40", Length = "0x3A")]
	public float GetTODSeconds(float realTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6001925")]
	[Address(RVA = "0x6FCE80", Offset = "0x6FBC80", Length = "0x2E")]
	public float GetTODSecondsUnscaled(float realTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6001926")]
	[Address(RVA = "0x6FCEB0", Offset = "0x6FBCB0", Length = "0x3A")]
	public float GetTODMinutes(float realTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6001927")]
	[Address(RVA = "0x6FCEF0", Offset = "0x6FBCF0", Length = "0x2E")]
	public float GetTODMinutesUnscaled(float realTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6001928")]
	[Address(RVA = "0x6FCF20", Offset = "0x6FBD20", Length = "0x3A")]
	public float GetTODHours(float realTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6001929")]
	[Address(RVA = "0x6FCF60", Offset = "0x6FBD60", Length = "0x2E")]
	public float GetTODHoursUnscaled(float realTimeSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x600192A")]
	[Address(RVA = "0x6FCF90", Offset = "0x6FBD90", Length = "0x3D")]
	public float GetRealTimeSeconds(float todHours)
	{
		return 0f;
	}

	[Token(Token = "0x600192B")]
	[Address(RVA = "0x6FCFD0", Offset = "0x6FBDD0", Length = "0x31")]
	public float GetRealTimeSecondsUnscaled(float todHours)
	{
		return 0f;
	}

	[Token(Token = "0x600192C")]
	[Address(RVA = "0x6FD010", Offset = "0x6FBE10", Length = "0x3E")]
	public float GetSecondsPlayedUnscaled()
	{
		return 0f;
	}

	[Token(Token = "0x600192D")]
	[Address(RVA = "0x6FD050", Offset = "0x6FBE50", Length = "0x2A")]
	public float GetHoursPlayedNotPaused()
	{
		return 0f;
	}

	[Token(Token = "0x600192E")]
	[Address(RVA = "0x6FD080", Offset = "0x6FBE80", Length = "0x8")]
	public bool IsInitializedForScene()
	{
		return false;
	}

	[Token(Token = "0x600192F")]
	[Address(RVA = "0x6FD090", Offset = "0x6FBE90", Length = "0x21")]
	public void SetHoursPlayedNotPaused(float hours)
	{
	}

	[Token(Token = "0x6001930")]
	[Address(RVA = "0x6FD0C0", Offset = "0x6FBEC0", Length = "0x45")]
	public void ForceUpdateTodObjects()
	{
	}

	[Token(Token = "0x6001931")]
	[Address(RVA = "0x6FD110", Offset = "0x6FBF10", Length = "0xCA")]
	public void SetCameraVignettingIndoors()
	{
	}

	[Token(Token = "0x6001932")]
	[Address(RVA = "0x6FD1E0", Offset = "0x6FBFE0", Length = "0x20")]
	public TODBlendState GetTODBlendState()
	{
		return default(TODBlendState);
	}

	[Token(Token = "0x6001933")]
	[Address(RVA = "0x6FD210", Offset = "0x6FC010", Length = "0x21")]
	public float GetTODBlendPercent(TODBlendState blendState)
	{
		return 0f;
	}

	[Token(Token = "0x6001934")]
	[Address(RVA = "0x6FD240", Offset = "0x6FC040", Length = "0x497")]
	public string GetHoursDaylightString()
	{
		return null;
	}

	[Token(Token = "0x6001935")]
	[Address(RVA = "0x6FD6E0", Offset = "0x6FC4E0", Length = "0x188")]
	public string GetGenericTODString()
	{
		return null;
	}

	[Token(Token = "0x6001936")]
	[Address(RVA = "0x6FD870", Offset = "0x6FC670", Length = "0x3C1")]
	public void InstantiateUniStorm(Camera mainCamera)
	{
	}

	[Token(Token = "0x6001937")]
	[Address(RVA = "0x6FDC40", Offset = "0x6FCA40", Length = "0xBF")]
	public void AccelerateTime(float minutes, float realtimeDurationSeconds)
	{
	}

	[IteratorStateMachine(typeof(_003CAccelerateCo_003Ed__105))]
	[Token(Token = "0x6001938")]
	[Address(RVA = "0x6FDD00", Offset = "0x6FCB00", Length = "0xB5")]
	public IEnumerator AccelerateCo(float minutes, float realtimeDurationSeconds)
	{
		return null;
	}

	[Token(Token = "0x6001939")]
	[Address(RVA = "0x6FDDC0", Offset = "0x6FCBC0", Length = "0x496")]
	private void CheckAchievements()
	{
	}

	[Token(Token = "0x600193A")]
	[Address(RVA = "0x6FE260", Offset = "0x6FD060", Length = "0xD9")]
	private void UpdateUniStormDayLength()
	{
	}

	[Token(Token = "0x600193B")]
	[Address(RVA = "0x6FE340", Offset = "0x6FD140", Length = "0x8D")]
	private void UpdateUniStormTimeScollBarDisplay()
	{
	}

	[Token(Token = "0x600193C")]
	[Address(RVA = "0x6FE3D0", Offset = "0x6FD1D0", Length = "0x2A6")]
	private void DebugOnly_UpdateTimeOfDayScale()
	{
	}

	[Token(Token = "0x600193D")]
	[Address(RVA = "0x6FE680", Offset = "0x6FD480", Length = "0x497")]
	private void MaybePlayTimeOfDayStingers()
	{
	}

	[Token(Token = "0x600193E")]
	[Address(RVA = "0x6FEB20", Offset = "0x6FD920", Length = "0x106")]
	private void PlayDelayedVoiceOver()
	{
	}

	[Token(Token = "0x600193F")]
	[Address(RVA = "0x6FEC30", Offset = "0x6FDA30", Length = "0x99")]
	private void MaybeUpdateWiseWithCurrentHour()
	{
	}

	[Token(Token = "0x6001940")]
	[Address(RVA = "0x6FECD0", Offset = "0x6FDAD0", Length = "0x4D")]
	public TimeOfDay()
	{
	}
}
