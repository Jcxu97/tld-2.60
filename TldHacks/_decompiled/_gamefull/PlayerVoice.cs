using System;
using System.Collections.Generic;
using System.Diagnostics;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;
using Voice;

[Token(Token = "0x20008D1")]
public class PlayerVoice : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x20008D2")]
	public enum Options : uint
	{
		[Token(Token = "0x4005C5F")]
		None = 0u,
		[Token(Token = "0x4005C60")]
		AllowDuringCinematic = 1u,
		[Token(Token = "0x4005C61")]
		AllowEqualPriorityOverride = 2u,
		[Token(Token = "0x4005C62")]
		AllowHeavyBreathing = 4u,
		[Token(Token = "0x4005C63")]
		AllowWhenAiming = 8u,
		[Token(Token = "0x4005C64")]
		AllowWhenClimbing = 0x10u,
		[Token(Token = "0x4005C65")]
		AllowWhenHeavingBreathing = 0x20u,
		[Token(Token = "0x4005C66")]
		IgnoreNonCriticalDelay = 0x40u,
		[Token(Token = "0x4005C67")]
		AllowWhenAllSpeechDisable = 0x80u
	}

	[Token(Token = "0x20008D3")]
	public enum Reason
	{
		[Token(Token = "0x4005C69")]
		Failed,
		[Token(Token = "0x4005C6A")]
		Finished,
		[Token(Token = "0x4005C6B")]
		Ignored,
		[Token(Token = "0x4005C6C")]
		Interrupted,
		[Token(Token = "0x4005C6D")]
		Queued,
		[Token(Token = "0x4005C6E")]
		Start
	}

	[Token(Token = "0x20008D4")]
	public delegate void RequestEventDelegate(Request request, Reason reason);

	[Token(Token = "0x20008D5")]
	public delegate void VoicePersonaChangedDelegate(VoicePersona persona);

	[Token(Token = "0x4005C4B")]
	private static readonly LogFilter s_logFilter;

	[HideInInspector]
	[Token(Token = "0x4005C4C")]
	[FieldOffset(Offset = "0x20")]
	public RequestEventDelegate m_EventTrigger;

	[HideInInspector]
	[Token(Token = "0x4005C4D")]
	[FieldOffset(Offset = "0x28")]
	public VoicePersonaChangedDelegate m_VoicePersonaChanged;

	[Tooltip("Delay between each non-critical voice line playback. Time is in seconds.")]
	[Token(Token = "0x4005C4E")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinSecondsBetweenNonCriticalLines;

	[Tooltip("How long to keep non-critical voice lines in queue before dropping them. Time in seconds")]
	[Token(Token = "0x4005C4F")]
	[FieldOffset(Offset = "0x34")]
	public float m_NonCriticalVoiceQueueTimeout;

	[Tooltip("How long to leave subtitles active on-screen when player voice events are disabled")]
	[Range(0f, 60f)]
	[Token(Token = "0x4005C50")]
	[FieldOffset(Offset = "0x38")]
	public float m_ForcedSubtitleDelayTime;

	[Token(Token = "0x4005C51")]
	[FieldOffset(Offset = "0x3C")]
	public float m_TimeoutBufferDuration;

	[SerializeField]
	[Token(Token = "0x4005C52")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[HideInInspector]
	[Token(Token = "0x4005C53")]
	[FieldOffset(Offset = "0x48")]
	public float m_LastPlayTime;

	[Token(Token = "0x4005C54")]
	public static bool s_DebugVerbose;

	[Token(Token = "0x4005C55")]
	[FieldOffset(Offset = "0x4C")]
	private float m_BlockNonCriticalLineTime;

	[Token(Token = "0x4005C56")]
	[FieldOffset(Offset = "0x50")]
	private float m_NextNonCriticalLineTime;

	[Token(Token = "0x4005C57")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasUpdatedFirstFrame;

	[Token(Token = "0x4005C58")]
	[FieldOffset(Offset = "0x58")]
	private Priority m_RestrictedPriority;

	[Token(Token = "0x4005C59")]
	[FieldOffset(Offset = "0x5C")]
	private float m_SubtitleEventDelay;

	[Token(Token = "0x4005C5A")]
	[FieldOffset(Offset = "0x60")]
	private bool m_WasCinematicActive;

	[Token(Token = "0x4005C5B")]
	[FieldOffset(Offset = "0x68")]
	private readonly ActiveRequest m_ActiveRequest;

	[Token(Token = "0x4005C5C")]
	[FieldOffset(Offset = "0x70")]
	private readonly Request m_NextRequest;

	[Token(Token = "0x4005C5D")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<Request> m_Queue;

	[Token(Token = "0x6005115")]
	[Address(RVA = "0xE1E860", Offset = "0xE1D660", Length = "0x61")]
	public void BlockNonCriticalVoiceForDuration(float duration)
	{
	}

	[Token(Token = "0x6005116")]
	[Address(RVA = "0xE1E8D0", Offset = "0xE1D6D0", Length = "0x20")]
	public ActiveRequest GetActiveRequest()
	{
		return null;
	}

	[Token(Token = "0x6005117")]
	[Address(RVA = "0x4B4350", Offset = "0x4B3150", Length = "0x6")]
	public float GetNonCriticalDelayTime()
	{
		return 0f;
	}

	[Token(Token = "0x6005118")]
	[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
	public List<Request> GetQueue()
	{
		return null;
	}

	[Token(Token = "0x6005119")]
	[Address(RVA = "0xE1E900", Offset = "0xE1D700", Length = "0x4")]
	public Priority GetRestrictedPriority()
	{
		return default(Priority);
	}

	[Token(Token = "0x600511A")]
	[Address(RVA = "0xE1E910", Offset = "0xE1D710", Length = "0x2B")]
	public bool IsSpeaking()
	{
		return false;
	}

	[Token(Token = "0x600511B")]
	[Address(RVA = "0xE1E940", Offset = "0xE1D740", Length = "0xBE")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[Token(Token = "0x600511C")]
	[Address(RVA = "0xE1EA00", Offset = "0xE1D800", Length = "0x149")]
	public uint Play(uint eventID, Priority priority, Options options = Options.None, Action completionCallback = null, string eventName = null)
	{
		return 0u;
	}

	[Token(Token = "0x600511D")]
	[Address(RVA = "0xE1EB50", Offset = "0xE1D950", Length = "0xC9")]
	public uint Play(AK.Wwise.Event audioEvent, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[Token(Token = "0x600511E")]
	[Address(RVA = "0xE1EC20", Offset = "0xE1DA20", Length = "0x2B2")]
	public bool Queue(AK.Wwise.Event audioEvent, Priority priority, Action completionCallback = null)
	{
		return false;
	}

	[Token(Token = "0x600511F")]
	[Address(RVA = "0xE1EEE0", Offset = "0xE1DCE0", Length = "0x291")]
	public bool Queue(string eventName, Priority priority, Action completionCallback = null)
	{
		return false;
	}

	[Token(Token = "0x6005120")]
	[Address(RVA = "0xE1F180", Offset = "0xE1DF80", Length = "0x4")]
	public void RestrictBelowPriority(Priority priority)
	{
	}

	[Token(Token = "0x6005121")]
	[Address(RVA = "0xE1F190", Offset = "0xE1DF90", Length = "0x133")]
	public void SetPlayerVoicePersona()
	{
	}

	[Token(Token = "0x6005122")]
	[Address(RVA = "0xE1F2D0", Offset = "0xE1E0D0", Length = "0x33")]
	public void Stop(uint playingID)
	{
	}

	[Token(Token = "0x6005123")]
	[Address(RVA = "0xE1F310", Offset = "0xE1E110", Length = "0x2D")]
	public void StopBelowPriority(Priority priority)
	{
	}

	[Token(Token = "0x6005124")]
	[Address(RVA = "0xE1F340", Offset = "0xE1E140", Length = "0x37F")]
	public void Update()
	{
	}

	[Token(Token = "0x6005125")]
	[Address(RVA = "0xE1F6C0", Offset = "0xE1E4C0", Length = "0x15D")]
	private void CompleteActiveRequest()
	{
	}

	[Token(Token = "0x6005126")]
	[Address(RVA = "0xE1F820", Offset = "0xE1E620", Length = "0xA2")]
	private bool CanPlayNextRequest()
	{
		return false;
	}

	[Token(Token = "0x6005127")]
	[Address(RVA = "0xE1F8D0", Offset = "0xE1E6D0", Length = "0x19F")]
	private bool CanPlayNonCriticalVoiceLine()
	{
		return false;
	}

	[Token(Token = "0x6005128")]
	[Address(RVA = "0xE1FA70", Offset = "0xE1E870", Length = "0x3DA")]
	private bool CanPlayPlayerVoiceEvents()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005129")]
	[Address(RVA = "0xE1FE50", Offset = "0xE1EC50", Length = "0x16")]
	private void EventTrigger(Request request, Reason reason)
	{
	}

	[Token(Token = "0x600512A")]
	[Address(RVA = "0xE1FE70", Offset = "0xE1EC70", Length = "0x2CD")]
	private bool HandleNextRequest()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600512B")]
	[Address(RVA = "0xE20140", Offset = "0xE1EF40", Length = "0x43")]
	private void LogRequestIgnored(string reason)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600512C")]
	[Address(RVA = "0xE20190", Offset = "0xE1EF90", Length = "0x43")]
	private void LogRequestPreempted(string reason)
	{
	}

	[Token(Token = "0x600512D")]
	[Address(RVA = "0xE201E0", Offset = "0xE1EFE0", Length = "0xA1")]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[Token(Token = "0x600512E")]
	[Address(RVA = "0xE20290", Offset = "0xE1F090", Length = "0x190")]
	private void MaybeHandleNextQueuedRequest()
	{
	}

	[Token(Token = "0x600512F")]
	[Address(RVA = "0xE20430", Offset = "0xE1F230", Length = "0x1EA")]
	private void MaybeShowInitialSubtitle(string eventName)
	{
	}

	[Token(Token = "0x6005130")]
	[Address(RVA = "0xE20620", Offset = "0xE1F420", Length = "0x280")]
	private bool StartNextRequest()
	{
		return false;
	}

	[Token(Token = "0x6005131")]
	[Address(RVA = "0xE208B0", Offset = "0xE1F6B0", Length = "0x1B7")]
	private void UpdateActive()
	{
	}

	[Token(Token = "0x6005132")]
	[Address(RVA = "0xE20A70", Offset = "0xE1F870", Length = "0x148")]
	private void UpdateQueued()
	{
	}

	[Token(Token = "0x6005133")]
	[Address(RVA = "0xE20BC0", Offset = "0xE1F9C0", Length = "0x1DB")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6005134")]
	[Address(RVA = "0xE20DA0", Offset = "0xE1FBA0", Length = "0x1DF")]
	public PlayerVoice()
	{
	}
}
