using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000989")]
public class PlayableBehaviourSay : PlayableBehaviour
{
	[Token(Token = "0x4006247")]
	[FieldOffset(Offset = "0x10")]
	public VoiceOverItem m_VoiceOver;

	[Token(Token = "0x4006248")]
	[FieldOffset(Offset = "0x18")]
	public VoiceInstigatorType m_InstigatorType;

	[Token(Token = "0x4006249")]
	[FieldOffset(Offset = "0x1C")]
	public float m_StartTime;

	[Token(Token = "0x400624A")]
	[FieldOffset(Offset = "0x20")]
	public float m_PlayTime;

	[SerializeField]
	[Token(Token = "0x400624B")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x400624C")]
	[FieldOffset(Offset = "0x30")]
	private bool m_PlayRequested;

	[Token(Token = "0x400624D")]
	[FieldOffset(Offset = "0x31")]
	private bool m_HasStarted;

	[Token(Token = "0x400624E")]
	[FieldOffset(Offset = "0x32")]
	private bool m_ReturnToStartPending;

	[Token(Token = "0x400624F")]
	[FieldOffset(Offset = "0x33")]
	private bool m_ReturnToStartRequested;

	[Token(Token = "0x4006250")]
	[FieldOffset(Offset = "0x34")]
	private uint m_AudioId;

	[Token(Token = "0x4006251")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_NPCObject;

	[Token(Token = "0x4006252")]
	[FieldOffset(Offset = "0x40")]
	private NPCVoice m_NPCVoice;

	[Token(Token = "0x4006253")]
	private const PlayerVoice.Options PLAYER_VOICE_OPTIONS = PlayerVoice.Options.AllowDuringCinematic | PlayerVoice.Options.AllowEqualPriorityOverride | PlayerVoice.Options.AllowWhenAllSpeechDisable;

	[Token(Token = "0x4006254")]
	private const NPCVoice.Options NPC_VOICE_OPTIONS = NPCVoice.Options.AllowEqualPriorityOverride | NPCVoice.Options.EnableSourcePlayPosition;

	[Token(Token = "0x6005562")]
	[Address(RVA = "0xE9B560", Offset = "0xE9A360", Length = "0xB0")]
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		currentTime = default(float);
		return false;
	}

	[Token(Token = "0x6005563")]
	[Address(RVA = "0xE9B610", Offset = "0xE9A410", Length = "0xE")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005564")]
	[Address(RVA = "0xE9B620", Offset = "0xE9A420", Length = "0x4DA")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005565")]
	[Address(RVA = "0xE9B610", Offset = "0xE9A410", Length = "0xE")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005566")]
	[Address(RVA = "0xE9BB00", Offset = "0xE9A900", Length = "0x142")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005567")]
	[Address(RVA = "0xE9BC50", Offset = "0xE9AA50", Length = "0x1AA")]
	private void PlayVoice(float playTime)
	{
	}

	[Token(Token = "0x6005568")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourSay()
	{
	}
}
