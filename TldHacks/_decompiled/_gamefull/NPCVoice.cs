using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using Voice;

[Token(Token = "0x200086E")]
public class NPCVoice : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x200086F")]
	public enum Options : uint
	{
		[Token(Token = "0x400573B")]
		None = 0u,
		[Token(Token = "0x400573C")]
		AllowEqualPriorityOverride = 1u,
		[Token(Token = "0x400573D")]
		EnableSourcePlayPosition = 2u
	}

	[SerializeField]
	[Token(Token = "0x4005731")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Tooltip("How long to leave subtitles active on-screen when NPC voice events are disabled")]
	[Range(0f, 60f)]
	[Token(Token = "0x4005732")]
	[FieldOffset(Offset = "0x28")]
	public float m_ForcedSubtitleDelayTime;

	[Token(Token = "0x4005733")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_EmitterPositionOverride;

	[NonSerialized]
	[Token(Token = "0x4005734")]
	[FieldOffset(Offset = "0x38")]
	public NPC m_NPC;

	[Token(Token = "0x4005735")]
	[FieldOffset(Offset = "0x40")]
	private ActiveRequest m_ActiveRequest;

	[Token(Token = "0x4005736")]
	[FieldOffset(Offset = "0x48")]
	private Request m_NextRequest;

	[Token(Token = "0x4005737")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_Emitter;

	[Token(Token = "0x4005738")]
	[FieldOffset(Offset = "0x58")]
	private bool m_WasIndoors;

	[Token(Token = "0x4005739")]
	private static List<NPCVoice> s_NPCVoiceList;

	[Token(Token = "0x6004D51")]
	[Address(RVA = "0xD86B60", Offset = "0xD85960", Length = "0x291")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004D52")]
	[Address(RVA = "0xD86E00", Offset = "0xD85C00", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6004D53")]
	[Address(RVA = "0xD86E90", Offset = "0xD85C90", Length = "0x439")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004D54")]
	[Address(RVA = "0xD872D0", Offset = "0xD860D0", Length = "0x7")]
	public void DoUpdate()
	{
	}

	[Token(Token = "0x6004D55")]
	[Address(RVA = "0xD872E0", Offset = "0xD860E0", Length = "0xA7")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[Token(Token = "0x6004D56")]
	[Address(RVA = "0xD87390", Offset = "0xD86190", Length = "0xFD")]
	public uint Play(uint eventId, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[Token(Token = "0x6004D57")]
	[Address(RVA = "0xD87490", Offset = "0xD86290", Length = "0x27")]
	public void Stop(uint playingID)
	{
	}

	[Token(Token = "0x6004D58")]
	[Address(RVA = "0xD874C0", Offset = "0xD862C0", Length = "0x2B")]
	public bool IsSpeaking()
	{
		return false;
	}

	[Token(Token = "0x6004D59")]
	[Address(RVA = "0xD874F0", Offset = "0xD862F0", Length = "0x16F")]
	private void CompleteActiveRequest()
	{
	}

	[Token(Token = "0x6004D5A")]
	[Address(RVA = "0xD87660", Offset = "0xD86460", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004D5B")]
	[Address(RVA = "0xD87700", Offset = "0xD86500", Length = "0x23D")]
	public static bool AnySpeaking()
	{
		return false;
	}

	[Token(Token = "0x6004D5C")]
	[Address(RVA = "0xD87940", Offset = "0xD86740", Length = "0x2F8")]
	private bool AnyOtherSpeaking()
	{
		return false;
	}

	[Token(Token = "0x6004D5D")]
	[Address(RVA = "0xD87C40", Offset = "0xD86A40", Length = "0x264")]
	private bool HandleNextRequest()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6004D5E")]
	[Address(RVA = "0xD87EB0", Offset = "0xD86CB0", Length = "0x9E")]
	private void LogRequestIgnored(string reason)
	{
	}

	[Token(Token = "0x6004D5F")]
	[Address(RVA = "0xD87F50", Offset = "0xD86D50", Length = "0xF2")]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[Token(Token = "0x6004D60")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	private bool CanPlayNextRequest()
	{
		return false;
	}

	[Token(Token = "0x6004D61")]
	[Address(RVA = "0xD88050", Offset = "0xD86E50", Length = "0x33E")]
	private bool StartNextRequest()
	{
		return false;
	}

	[Token(Token = "0x6004D62")]
	[Address(RVA = "0xD88390", Offset = "0xD87190", Length = "0x1B4")]
	private void UpdateAudioEmitterPosition()
	{
	}

	[Token(Token = "0x6004D63")]
	[Address(RVA = "0xD88550", Offset = "0xD87350", Length = "0x1FC")]
	private void UpdateIndoorOutdoorSwitch(bool forced)
	{
	}

	[Token(Token = "0x6004D64")]
	[Address(RVA = "0xD88750", Offset = "0xD87550", Length = "0x1A6")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6004D65")]
	[Address(RVA = "0xD88900", Offset = "0xD87700", Length = "0x14F")]
	public NPCVoice()
	{
	}
}
