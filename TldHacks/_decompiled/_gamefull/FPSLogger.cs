using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A0C")]
public class FPSLogger : MonoBehaviour
{
	[Token(Token = "0x2000A0D")]
	private class LogData
	{
		[Token(Token = "0x40065E8")]
		[FieldOffset(Offset = "0x10")]
		private float m_WorstFPS;

		[Token(Token = "0x40065E9")]
		[FieldOffset(Offset = "0x18")]
		private double m_CumulativeFPS;

		[Token(Token = "0x40065EA")]
		[FieldOffset(Offset = "0x20")]
		private long m_SampleCount;

		[Token(Token = "0x40065EB")]
		[FieldOffset(Offset = "0x28")]
		private long m_ValidCPUTimingCount;

		[Token(Token = "0x40065EC")]
		[FieldOffset(Offset = "0x30")]
		private long m_ValidGPUTimingCount;

		[Token(Token = "0x40065ED")]
		[FieldOffset(Offset = "0x38")]
		private long m_PeakAllocatedMemory;

		[Token(Token = "0x40065EE")]
		[FieldOffset(Offset = "0x40")]
		private long m_PeakReservedMemory;

		[Token(Token = "0x40065EF")]
		[FieldOffset(Offset = "0x48")]
		private long m_PeakGraphicsMemory;

		[Token(Token = "0x40065F0")]
		[FieldOffset(Offset = "0x50")]
		private long m_CumulativeResolution;

		[Token(Token = "0x40065F1")]
		[FieldOffset(Offset = "0x58")]
		private ulong m_PeakTextureMemory;

		[Token(Token = "0x40065F2")]
		[FieldOffset(Offset = "0x60")]
		private double m_CumulativeCPUTimeMs;

		[Token(Token = "0x40065F3")]
		[FieldOffset(Offset = "0x68")]
		private double m_CumulativeGPUTimeMs;

		[Token(Token = "0x40065F4")]
		[FieldOffset(Offset = "0x70")]
		private double m_WorstCPUTimeMs;

		[Token(Token = "0x40065F5")]
		[FieldOffset(Offset = "0x78")]
		private double m_WorstGPUTime;

		[Token(Token = "0x600584A")]
		[Address(RVA = "0xEE3E80", Offset = "0xEE2C80", Length = "0x270")]
		public void AddSample(FPSCounterEvent eventData)
		{
		}

		[Token(Token = "0x600584B")]
		[Address(RVA = "0xEE40F0", Offset = "0xEE2EF0", Length = "0x5DC")]
		public string FormatForWrite()
		{
			return null;
		}

		[Token(Token = "0x600584C")]
		[Address(RVA = "0xEE46D0", Offset = "0xEE34D0", Length = "0x8")]
		public LogData()
		{
		}
	}

	[Token(Token = "0x40065E1")]
	private const string DEBUG_LOG_FORMAT = "FPSLogger: {0}";

	[Token(Token = "0x40065E2")]
	private const string OUTPUT_FILENAME_FORMAT = "fps_{0:d-M-yyyy_HH-mm-ss}.csv";

	[Token(Token = "0x40065E3")]
	private const string OUTPUT_CONTENT_HEADER = "Scene,Weather,Average,Worst,Peak Allocated,Peak Reserved,Peak Textures,Peak Graphics,Cpu avg,Cpu max,Gpu avg,Gpu max,Resolution";

	[Token(Token = "0x40065E4")]
	private static bool s_IsRecording;

	[Token(Token = "0x40065E5")]
	private static Dictionary<string, LogData> s_Logs;

	[Token(Token = "0x40065E6")]
	private static string s_OutputFile;

	[Token(Token = "0x40065E7")]
	[FieldOffset(Offset = "0x20")]
	private FPSCounter m_Counter;

	[Token(Token = "0x600583F")]
	[Address(RVA = "0xEE28C0", Offset = "0xEE16C0", Length = "0x53")]
	public static bool IsRecording()
	{
		return false;
	}

	[Token(Token = "0x6005840")]
	[Address(RVA = "0xEE2920", Offset = "0xEE1720", Length = "0x291")]
	public static void StartRecording(string newExtension)
	{
	}

	[Token(Token = "0x6005841")]
	[Address(RVA = "0xEE2BC0", Offset = "0xEE19C0", Length = "0x8E")]
	public static void StopRecording()
	{
	}

	[Token(Token = "0x6005842")]
	[Address(RVA = "0xEE2C50", Offset = "0xEE1A50", Length = "0x693")]
	private static void WriteToFile(string outputPath)
	{
	}

	[Token(Token = "0x6005843")]
	[Address(RVA = "0xEE32F0", Offset = "0xEE20F0", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005844")]
	[Address(RVA = "0xEE3380", Offset = "0xEE2180", Length = "0x290")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005845")]
	[Address(RVA = "0xEE3620", Offset = "0xEE2420", Length = "0x2EF")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005846")]
	[Address(RVA = "0xEE3910", Offset = "0xEE2710", Length = "0x35D")]
	private void OnFPSChanged(FPSCounterEvent eventData)
	{
	}

	[Token(Token = "0x6005847")]
	[Address(RVA = "0xEE3C70", Offset = "0xEE2A70", Length = "0x126")]
	private string GetCurrentLogKey()
	{
		return null;
	}

	[Token(Token = "0x6005848")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FPSLogger()
	{
	}
}
