using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000435")]
public class PassTime : MonoBehaviour
{
	[Token(Token = "0x40025D7")]
	[FieldOffset(Offset = "0x20")]
	public float m_PassTimeRealtimeSecondsPerHour;

	[SerializeField]
	[Token(Token = "0x40025D8")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_PassTimeAudio;

	[Token(Token = "0x40025D9")]
	[FieldOffset(Offset = "0x30")]
	private readonly HighResolutionTimer m_Timer;

	[Token(Token = "0x40025DA")]
	[FieldOffset(Offset = "0x38")]
	private float m_LastTimerHours;

	[Token(Token = "0x40025DB")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_PassTimeDurationMilliseconds;

	[Token(Token = "0x40025DC")]
	[FieldOffset(Offset = "0x48")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x40025DD")]
	[FieldOffset(Offset = "0x4C")]
	private float m_DayLengthScaleOriginal;

	[Token(Token = "0x40025DE")]
	[FieldOffset(Offset = "0x50")]
	private uint m_PassTimeAudioInstance;

	[Token(Token = "0x40025DF")]
	[FieldOffset(Offset = "0x58")]
	private Bed m_Bed;

	[Token(Token = "0x40025E0")]
	[FieldOffset(Offset = "0x60")]
	private bool m_SkipSave;

	[Token(Token = "0x40025E1")]
	[FieldOffset(Offset = "0x61")]
	private bool m_SuppressAudio;

	[Token(Token = "0x6001FA5")]
	[Address(RVA = "0x7DEEA0", Offset = "0x7DDCA0", Length = "0xF3")]
	public void Update()
	{
	}

	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0x7DEFA0", Offset = "0x7DDDA0", Length = "0x96")]
	private bool HasFearOrAnxiety()
	{
		return false;
	}

	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x7DF040", Offset = "0x7DDE40", Length = "0x1BC")]
	private void UpdatePassingTime()
	{
	}

	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0x7DF200", Offset = "0x7DE000", Length = "0x320")]
	public void Begin(float hours, Bed bed)
	{
	}

	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x7DF530", Offset = "0x7DE330", Length = "0x219")]
	public void End()
	{
	}

	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0x7DF750", Offset = "0x7DE550", Length = "0x4")]
	public void SetSuppressAudio(bool shouldSuppress)
	{
	}

	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0x7DF760", Offset = "0x7DE560", Length = "0x5")]
	public void SetSkipSaveFlag()
	{
	}

	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0x7DF770", Offset = "0x7DE570", Length = "0x1E")]
	public bool IsPassingTime()
	{
		return false;
	}

	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x7DF790", Offset = "0x7DE590", Length = "0x9A")]
	public float GetNumHoursRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x7DF830", Offset = "0x7DE630", Length = "0xEC")]
	public float GetBedWarmthBonusCelsius()
	{
		return 0f;
	}

	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x7DF920", Offset = "0x7DE720", Length = "0x6E")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x7DF990", Offset = "0x7DE790", Length = "0x131")]
	private void AccelerateTimeOfDay(float hours)
	{
	}

	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x7DFAD0", Offset = "0x7DE8D0", Length = "0xC2")]
	public PassTime()
	{
	}
}
