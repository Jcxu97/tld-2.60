using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001335")]
public static class PlayAudioSimpleManager
{
	[Token(Token = "0x2001336")]
	private class Counters
	{
		[Token(Token = "0x4008DCB")]
		[FieldOffset(Offset = "0x10")]
		public float activeLoops;

		[Token(Token = "0x4008DCC")]
		[FieldOffset(Offset = "0x14")]
		public float akGameObjs;

		[Token(Token = "0x4008DCD")]
		[FieldOffset(Offset = "0x18")]
		public float[] activeGroups;

		[Token(Token = "0x4008DCE")]
		[FieldOffset(Offset = "0x20")]
		public float[] emitterGroups;

		[Token(Token = "0x6007B2A")]
		[Address(RVA = "0x119D5C0", Offset = "0x119C3C0", Length = "0x20F")]
		public void Add(BaseTracker tracker)
		{
		}

		[Token(Token = "0x6007B2B")]
		[Address(RVA = "0x119D7D0", Offset = "0x119C5D0", Length = "0xB0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6007B2C")]
		[Address(RVA = "0x119D890", Offset = "0x119C690", Length = "0x149")]
		public Counters()
		{
		}
	}

	[Token(Token = "0x4008DC1")]
	public static bool s_Debug;

	[Token(Token = "0x4008DC2")]
	private static List<BaseTracker> m_Trackers;

	[Token(Token = "0x4008DC3")]
	private static int m_CurrentIndex;

	[Token(Token = "0x4008DC4")]
	private static int m_NumProcessPerFrame;

	[Token(Token = "0x4008DC5")]
	private static bool m_FirstUpdate;

	[Token(Token = "0x4008DC6")]
	private static int s_MaxStartOrStopPerFrame;

	[Token(Token = "0x4008DC7")]
	private static readonly int NUM_BUCKETS;

	[Token(Token = "0x4008DC8")]
	private static float[] m_BucketRanges;

	[Token(Token = "0x4008DC9")]
	private static Counters m_CurrentCounters;

	[Token(Token = "0x4008DCA")]
	private static Counters m_NextCounters;

	[Token(Token = "0x6007B21")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void SwapCounters()
	{
	}

	[Token(Token = "0x6007B22")]
	[Address(RVA = "0x119C310", Offset = "0x119B110", Length = "0x3E1")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6007B23")]
	[Address(RVA = "0x119C700", Offset = "0x119B500", Length = "0x35A")]
	public static void Update()
	{
	}

	[Token(Token = "0x6007B24")]
	[Address(RVA = "0x119CA60", Offset = "0x119B860", Length = "0x214")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6007B25")]
	[Address(RVA = "0x119CC80", Offset = "0x119BA80", Length = "0x138")]
	public static void Add(GameObject go, AK.Wwise.Event eventReference, float radius, bool stopWhenDisabled, bool position)
	{
	}

	[Token(Token = "0x6007B26")]
	[Address(RVA = "0x119CDC0", Offset = "0x119BBC0", Length = "0x138")]
	public static void AddAmbient(GameObject go, AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, float radius, bool stopWhenDisabled)
	{
	}

	[Token(Token = "0x6007B27")]
	[Address(RVA = "0x119CF00", Offset = "0x119BD00", Length = "0x14A")]
	public static void AddVoice(GameObject go, string eventID, float radius, bool stopWhenDisabled, bool position, bool useDurationForSubtitle)
	{
	}

	[Token(Token = "0x6007B28")]
	[Address(RVA = "0x119D050", Offset = "0x119BE50", Length = "0x251")]
	public static void Remove(GameObject go, AK.Wwise.Event akEvent)
	{
	}
}
