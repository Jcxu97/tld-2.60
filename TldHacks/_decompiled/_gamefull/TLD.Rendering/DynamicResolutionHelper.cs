using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

namespace TLD.Rendering;

[Token(Token = "0x2001371")]
public static class DynamicResolutionHelper
{
	[Token(Token = "0x4008F07")]
	private const string CONFIG_NAME = "DynamicResolutionConfig";

	[Token(Token = "0x4008F08")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4008F09")]
	private static DynamicResolutionConfig s_Config;

	[Token(Token = "0x4008F0A")]
	private static DynamicResolutionPlatformConfig s_ActivePlatformConfig;

	[Token(Token = "0x4008F0B")]
	public static bool CanMeasureFrameTimings;

	[Token(Token = "0x4008F13")]
	private static int s_TargetFrameRate;

	[Token(Token = "0x4008F14")]
	private static double s_TargetFrameTime;

	[Token(Token = "0x4008F15")]
	private static uint s_FrameCount;

	[Token(Token = "0x4008F16")]
	private static FrameTiming[] s_FrameTimings;

	[Token(Token = "0x4008F17")]
	private static double s_GPUFrameTimeDelta;

	[Token(Token = "0x4008F18")]
	private static uint s_ScaleRaiseCounter;

	[Token(Token = "0x4008F19")]
	private static float s_CurrentScaleFactor;

	[Token(Token = "0x4008F1A")]
	private static float s_CurrentRenderScale;

	[Token(Token = "0x4008F1B")]
	private static bool s_AllowDynamicResolutionScaling;

	[Token(Token = "0x4008F1C")]
	private static bool s_Initialized;

	[Token(Token = "0x17000A83")]
	public static bool IsDynamicResolutionEnabled
	{
		[Token(Token = "0x6007C2C")]
		[Address(RVA = "0x11AFCF0", Offset = "0x11AEAF0", Length = "0x58")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A84")]
	public static float StaticScalingMin
	{
		[Token(Token = "0x6007C2D")]
		[Address(RVA = "0x11AFD50", Offset = "0x11AEB50", Length = "0x136")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000A85")]
	public static float StaticScalingMax
	{
		[Token(Token = "0x6007C2E")]
		[Address(RVA = "0x11AFE90", Offset = "0x11AEC90", Length = "0x136")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000A86")]
	[field: Token(Token = "0x4008F0C")]
	public static int MaxWidth
	{
		[Token(Token = "0x6007C2F")]
		[Address(RVA = "0x11AFFD0", Offset = "0x11AEDD0", Length = "0x53")]
		get;
		[Token(Token = "0x6007C30")]
		[Address(RVA = "0x11B0030", Offset = "0x11AEE30", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x17000A87")]
	[field: Token(Token = "0x4008F0D")]
	public static int MaxHeight
	{
		[Token(Token = "0x6007C31")]
		[Address(RVA = "0x11B0090", Offset = "0x11AEE90", Length = "0x53")]
		get;
		[Token(Token = "0x6007C32")]
		[Address(RVA = "0x11B00F0", Offset = "0x11AEEF0", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x17000A88")]
	[field: Token(Token = "0x4008F0E")]
	public static int RenderWidth
	{
		[Token(Token = "0x6007C33")]
		[Address(RVA = "0x11B0150", Offset = "0x11AEF50", Length = "0x53")]
		get;
		[Token(Token = "0x6007C34")]
		[Address(RVA = "0x11B01B0", Offset = "0x11AEFB0", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x17000A89")]
	[field: Token(Token = "0x4008F0F")]
	public static int RenderHeight
	{
		[Token(Token = "0x6007C35")]
		[Address(RVA = "0x11B0210", Offset = "0x11AF010", Length = "0x53")]
		get;
		[Token(Token = "0x6007C36")]
		[Address(RVA = "0x11B0270", Offset = "0x11AF070", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x17000A8A")]
	[field: Token(Token = "0x4008F10")]
	public static double GPUFrameTime
	{
		[Token(Token = "0x6007C37")]
		[Address(RVA = "0x11B02D0", Offset = "0x11AF0D0", Length = "0x55")]
		get;
		[Token(Token = "0x6007C38")]
		[Address(RVA = "0x11B0330", Offset = "0x11AF130", Length = "0x62")]
		private set;
	}

	[Token(Token = "0x17000A8B")]
	[field: Token(Token = "0x4008F11")]
	public static double CPUFrameTime
	{
		[Token(Token = "0x6007C39")]
		[Address(RVA = "0x11B03A0", Offset = "0x11AF1A0", Length = "0x55")]
		get;
		[Token(Token = "0x6007C3A")]
		[Address(RVA = "0x11B0400", Offset = "0x11AF200", Length = "0x62")]
		private set;
	}

	[Token(Token = "0x17000A8C")]
	[field: Token(Token = "0x4008F12")]
	public static List<int> ValidFramerateTargets
	{
		[Token(Token = "0x6007C3B")]
		[Address(RVA = "0x11B0470", Offset = "0x11AF270", Length = "0x54")]
		get;
		[Token(Token = "0x6007C3C")]
		[Address(RVA = "0x11B04D0", Offset = "0x11AF2D0", Length = "0xB7")]
		private set;
	}

	[Token(Token = "0x6007C3D")]
	[Address(RVA = "0x11B0590", Offset = "0x11AF390", Length = "0x539")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6007C3E")]
	[Address(RVA = "0x11B0AD0", Offset = "0x11AF8D0", Length = "0xAF")]
	private static bool MaybeUpdatePlatformConfig()
	{
		return false;
	}

	[Token(Token = "0x6007C3F")]
	[Address(RVA = "0x11B0B80", Offset = "0x11AF980", Length = "0x2D4")]
	private static void UpdatePlatformConfig(DynamicResolutionPlatformConfig newConfig)
	{
	}

	[Token(Token = "0x6007C40")]
	[Address(RVA = "0x11B0E60", Offset = "0x11AFC60", Length = "0x294")]
	private static void RefreshMaxWidthAndHeight()
	{
	}

	[Token(Token = "0x6007C41")]
	[Address(RVA = "0x11B1100", Offset = "0x11AFF00", Length = "0x1DE")]
	public static int DetermineMaxRefreshRate()
	{
		return 0;
	}

	[Token(Token = "0x6007C42")]
	[Address(RVA = "0x11B12E0", Offset = "0x11B00E0", Length = "0x46E")]
	private static void UpdateValidFramerates()
	{
	}

	[Token(Token = "0x6007C43")]
	[Address(RVA = "0x11B1750", Offset = "0x11B0550", Length = "0x1C4")]
	private static void UpdateScreenResolution()
	{
	}

	[Token(Token = "0x6007C44")]
	[Address(RVA = "0x11B1920", Offset = "0x11B0720", Length = "0x1BC")]
	public static void TrySetFramerateTarget(int framerateTarget)
	{
	}

	[Token(Token = "0x6007C45")]
	[Address(RVA = "0x11B1AE0", Offset = "0x11B08E0", Length = "0x1C2")]
	public static void ResetDynamicResolution()
	{
	}

	[Token(Token = "0x6007C46")]
	[Address(RVA = "0x11B1CB0", Offset = "0x11B0AB0", Length = "0x3CF")]
	public static void SetForcedResolutionScale(float resolutionScale)
	{
	}

	[Token(Token = "0x6007C47")]
	[Address(RVA = "0x11B2080", Offset = "0x11B0E80", Length = "0x519")]
	public static void UpdateDynamicResolution()
	{
	}

	[Token(Token = "0x6007C48")]
	[Address(RVA = "0x11B25A0", Offset = "0x11B13A0", Length = "0x39E")]
	private static void UpdateFrameStats()
	{
	}

	[Token(Token = "0x6007C49")]
	[Address(RVA = "0x11B2940", Offset = "0x11B1740", Length = "0x300")]
	private static void UpdateResolutionScale()
	{
	}
}
