using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.LowLevel;

[Token(Token = "0x2000A27")]
public class PlayerLoopScript
{
	[Token(Token = "0x2000A28")]
	public class EarlyUpdateTimer
	{
		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public EarlyUpdateTimer()
		{
		}
	}

	[Token(Token = "0x2000A29")]
	public class PostLateUpdateTimer
	{
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PostLateUpdateTimer()
		{
		}
	}

	[Token(Token = "0x4006664")]
	private static Stopwatch s_Stopwatch;

	[Token(Token = "0x4006665")]
	private static Queue<double> s_CPUTimeMsQueue;

	[Token(Token = "0x4006666")]
	public static float s_CPU_loopTimeMs;

	[Token(Token = "0x4006667")]
	public static float s_CPU_loopTimeAvgMs;

	[Token(Token = "0x4006668")]
	public const uint MAX_FRAME_TIMINGS = 60u;

	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x60058EE")]
	[Address(RVA = "0xEEDE00", Offset = "0xEECC00", Length = "0x74D")]
	private static void Init()
	{
	}

	[Token(Token = "0x60058EF")]
	[Address(RVA = "0xEEE550", Offset = "0xEED350", Length = "0x28B")]
	private static bool InsertSystem(ref PlayerLoopSystem system, Type insertUnder, PlayerLoopSystem toInsert, bool insertAtStart = true)
	{
		return false;
	}

	[Token(Token = "0x60058F0")]
	[Address(RVA = "0xEEE7E0", Offset = "0xEED5E0", Length = "0x45")]
	private static void EarlyUpdate_Internal()
	{
	}

	[Token(Token = "0x60058F1")]
	[Address(RVA = "0xEEE830", Offset = "0xEED630", Length = "0xD4")]
	private static void PostLateUpdate_Internal()
	{
	}

	[Token(Token = "0x60058F2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerLoopScript()
	{
	}
}
