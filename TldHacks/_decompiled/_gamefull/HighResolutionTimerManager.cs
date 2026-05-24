using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000302")]
public class HighResolutionTimerManager : MonoBehaviour
{
	[Token(Token = "0x2000303")]
	public class HighResolutionTimerManagerSaveDataProxy
	{
		[Token(Token = "0x4001A8C")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_Elapsed;

		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public HighResolutionTimerManagerSaveDataProxy()
		{
		}
	}

	[Token(Token = "0x4001A84")]
	private const double DAY_IN_SECONDS = 86400.0;

	[Token(Token = "0x4001A85")]
	[FieldOffset(Offset = "0x20")]
	private Stopwatch m_StopWatch;

	[Token(Token = "0x4001A86")]
	[FieldOffset(Offset = "0x28")]
	private ulong m_Elapsed;

	[Token(Token = "0x4001A87")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasCalculatedBaseScale;

	[Token(Token = "0x4001A88")]
	[FieldOffset(Offset = "0x38")]
	private double m_BaseScale;

	[Token(Token = "0x4001A89")]
	[FieldOffset(Offset = "0x40")]
	private double m_CurrentTimeScale;

	[Token(Token = "0x4001A8A")]
	private static HighResolutionTimerManagerSaveDataProxy s_TimerManagerSaveDataProxy;

	[Token(Token = "0x4001A8B")]
	public static bool s_TimeAccumulationDebug;

	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x6F67A0", Offset = "0x6F55A0", Length = "0x42")]
	private void OnApplicationPause(bool pauseState)
	{
	}

	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x6F67F0", Offset = "0x6F55F0", Length = "0x93")]
	private void Update()
	{
	}

	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x6F67A0", Offset = "0x6F55A0", Length = "0x42")]
	private void SetTimerPaused(bool shouldPause)
	{
	}

	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x6F6890", Offset = "0x6F5690", Length = "0xF0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x6F6990", Offset = "0x6F5790", Length = "0x1CA")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x6F6B60", Offset = "0x6F5960", Length = "0x91")]
	public ulong GetElapsedMilliseconds()
	{
		return 0uL;
	}

	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x6F6C00", Offset = "0x6F5A00", Length = "0x8A")]
	public double GetElapsedSeconds()
	{
		return 0.0;
	}

	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x6F6C90", Offset = "0x6F5A90", Length = "0x8A")]
	public double GetElapsedMinutes()
	{
		return 0.0;
	}

	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x6F6D20", Offset = "0x6F5B20", Length = "0x8A")]
	public double GetElapsedHours()
	{
		return 0.0;
	}

	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x6F6DB0", Offset = "0x6F5BB0", Length = "0x8A")]
	public double GetElapsedDays()
	{
		return 0.0;
	}

	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x6F6E40", Offset = "0x6F5C40", Length = "0x79")]
	private ulong CalculateElapsedMillisecondsSinceLastBank()
	{
		return 0uL;
	}

	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x6F6EC0", Offset = "0x6F5CC0", Length = "0x19E")]
	public void UpdateTimeScale(double timeScale)
	{
	}

	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x6F7060", Offset = "0x6F5E60", Length = "0xC2")]
	public HighResolutionTimerManager()
	{
	}
}
