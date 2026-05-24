using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200095C")]
public class ThreeDaysOfNight : MonoBehaviour
{
	[Token(Token = "0x400614C")]
	public const int NUM_DAYS_HALF_BADGE = 2;

	[Token(Token = "0x400614D")]
	public const int NUM_DAYS_FULL_BADGE = 4;

	[Token(Token = "0x400614E")]
	[FieldOffset(Offset = "0x20")]
	public float m_FlashlightDurationMultiplier;

	[Token(Token = "0x400614F")]
	[FieldOffset(Offset = "0x24")]
	public float m_FlashlightEffectivenessMultiplier;

	[Token(Token = "0x4006150")]
	[FieldOffset(Offset = "0x28")]
	public float m_DayFourColdRateMultiplier;

	[Token(Token = "0x4006151")]
	[FieldOffset(Offset = "0x2C")]
	public float m_DayFourBaselineAirTempIndoors;

	[Token(Token = "0x4006152")]
	[FieldOffset(Offset = "0x30")]
	public float m_HoursNoWolfGracePeriod;

	[Token(Token = "0x4006153")]
	[FieldOffset(Offset = "0x34")]
	public int m_NumReduceMaxSpawnWolf;

	[Token(Token = "0x4006154")]
	public static bool m_ForcedOn;

	[Token(Token = "0x4006155")]
	public static int m_CurrentDay;

	[Token(Token = "0x4006156")]
	private static DateTime m_StartEventTime;

	[Token(Token = "0x4006157")]
	private static DateTime m_DayTwoStartTime;

	[Token(Token = "0x4006158")]
	private static DateTime m_DayThreeStartTime;

	[Token(Token = "0x4006159")]
	private static DateTime m_DayFourStartTime;

	[Token(Token = "0x400615A")]
	private static DateTime m_EndEventTime;

	[Token(Token = "0x400615B")]
	private static int m_OverrideSetDay;

	[Token(Token = "0x400615C")]
	private static ThreeDaysOfNight m_Instance;

	[Token(Token = "0x400615D")]
	private static int s_LastMinutesRemaining;

	[Token(Token = "0x400615E")]
	private static string s_MinutesRemainingString;

	[Token(Token = "0x600549E")]
	[Address(RVA = "0xE8B310", Offset = "0xE8A110", Length = "0xB7")]
	private void Awake()
	{
	}

	[Token(Token = "0x600549F")]
	[Address(RVA = "0xE8B3D0", Offset = "0xE8A1D0", Length = "0x1DB")]
	public static void Init()
	{
	}

	[Token(Token = "0x60054A0")]
	[Address(RVA = "0xE8B5B0", Offset = "0xE8A3B0", Length = "0x92")]
	public static void SetCurrentDay(int dayNumber)
	{
	}

	[Token(Token = "0x60054A1")]
	[Address(RVA = "0xE8B650", Offset = "0xE8A450", Length = "0x494")]
	public static void SetTransitionToDay(int dayNumber)
	{
	}

	[Token(Token = "0x60054A2")]
	[Address(RVA = "0xE8BAF0", Offset = "0xE8A8F0", Length = "0x57")]
	public static void ClearDailyTimerLabels()
	{
	}

	[Token(Token = "0x60054A3")]
	[Address(RVA = "0xE8BB50", Offset = "0xE8A950", Length = "0x50F")]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[Token(Token = "0x60054A4")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool CanManuallyUnlock()
	{
		return false;
	}

	[Token(Token = "0x60054A5")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x60054A6")]
	[Address(RVA = "0xE8C060", Offset = "0xE8AE60", Length = "0xBF")]
	public static bool NoWolfGracePeriodActive()
	{
		return false;
	}

	[Token(Token = "0x60054A7")]
	[Address(RVA = "0xE8C120", Offset = "0xE8AF20", Length = "0x29B")]
	public static int GetCurrentDayNumber()
	{
		return 0;
	}

	[Token(Token = "0x60054A8")]
	[Address(RVA = "0xE8C3C0", Offset = "0xE8B1C0", Length = "0x63")]
	public static float GetFlashlightDurationMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x60054A9")]
	[Address(RVA = "0xE8C430", Offset = "0xE8B230", Length = "0x63")]
	public static float GetFlashlightEffectivenessMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x60054AA")]
	[Address(RVA = "0xE8C4A0", Offset = "0xE8B2A0", Length = "0x63")]
	public static float GetColdRateMultiplier()
	{
		return 0f;
	}

	[Token(Token = "0x60054AB")]
	[Address(RVA = "0xE8C510", Offset = "0xE8B310", Length = "0x63")]
	public static float GetBaselineAirTempIndoors()
	{
		return 0f;
	}

	[Token(Token = "0x60054AC")]
	[Address(RVA = "0xE8C580", Offset = "0xE8B380", Length = "0x61")]
	public static int GetNumReduceMaxSpawnWolf()
	{
		return 0;
	}

	[Token(Token = "0x60054AD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ThreeDaysOfNight()
	{
	}
}
