using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000988")]
public class PlayableBehaviourPlayAudio : PlayableBehaviour
{
	[Token(Token = "0x4006236")]
	[FieldOffset(Offset = "0x10")]
	public string m_AudioEventStart;

	[Token(Token = "0x4006237")]
	[FieldOffset(Offset = "0x18")]
	public string m_AudioEventStop;

	[Token(Token = "0x4006238")]
	[FieldOffset(Offset = "0x20")]
	public bool m_AudioDrivesDirectorTime;

	[Token(Token = "0x4006239")]
	[FieldOffset(Offset = "0x28")]
	public TLD_TimelineDirector m_TLD_Director;

	[Token(Token = "0x400623A")]
	[FieldOffset(Offset = "0x30")]
	public double m_StartTime;

	[Token(Token = "0x400623B")]
	[FieldOffset(Offset = "0x38")]
	public double m_ClipDuration;

	[Token(Token = "0x400623C")]
	[FieldOffset(Offset = "0x40")]
	public string m_AssetName;

	[Token(Token = "0x400623D")]
	[FieldOffset(Offset = "0x48")]
	private uint m_AudioID;

	[Token(Token = "0x400623E")]
	[FieldOffset(Offset = "0x4C")]
	private float m_AudioDuration;

	[Token(Token = "0x400623F")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasStarted;

	[Token(Token = "0x4006240")]
	[FieldOffset(Offset = "0x51")]
	private bool m_HasFailed;

	[Token(Token = "0x4006241")]
	[FieldOffset(Offset = "0x52")]
	private bool m_HasLoggedLengthWarning;

	[Token(Token = "0x4006242")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_AudioEmitterNode;

	[Token(Token = "0x4006243")]
	[FieldOffset(Offset = "0x60")]
	private bool m_SeekRequested;

	[Token(Token = "0x4006244")]
	[FieldOffset(Offset = "0x64")]
	private float m_SeekTimeRequested;

	[Token(Token = "0x4006245")]
	[FieldOffset(Offset = "0x68")]
	private bool m_PlayRequested;

	[Token(Token = "0x4006246")]
	[FieldOffset(Offset = "0x69")]
	internal bool m_SeekAudioEnabled;

	[Token(Token = "0x6005557")]
	[Address(RVA = "0xE9A460", Offset = "0xE99260", Length = "0xE")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005558")]
	[Address(RVA = "0xE9A470", Offset = "0xE99270", Length = "0x7E8")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005559")]
	[Address(RVA = "0xE9A460", Offset = "0xE99260", Length = "0xE")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600555A")]
	[Address(RVA = "0xE9AC60", Offset = "0xE99A60", Length = "0x218")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600555B")]
	[Address(RVA = "0xE9AE80", Offset = "0xE99C80", Length = "0x1C7")]
	private void PlayAudio(float seekTime)
	{
	}

	[Token(Token = "0x600555C")]
	[Address(RVA = "0xE9B050", Offset = "0xE99E50", Length = "0x15F")]
	private void StopAudio()
	{
	}

	[Token(Token = "0x600555D")]
	[Address(RVA = "0xE9B1B0", Offset = "0xE99FB0", Length = "0xC8")]
	private uint PostStopAudioEvent()
	{
		return 0u;
	}

	[Token(Token = "0x600555E")]
	[Address(RVA = "0xE9B280", Offset = "0xE9A080", Length = "0x1A4")]
	private bool TryToSeekAudio()
	{
		return false;
	}

	[Token(Token = "0x600555F")]
	[Address(RVA = "0xE9B430", Offset = "0xE9A230", Length = "0x9F")]
	private void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6005560")]
	[Address(RVA = "0xE9B4D0", Offset = "0xE9A2D0", Length = "0x89")]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[Token(Token = "0x6005561")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourPlayAudio()
	{
	}
}
