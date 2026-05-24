using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000975")]
public class PlayableAssetSay : PlayableAsset
{
	[Token(Token = "0x4006202")]
	[FieldOffset(Offset = "0x18")]
	public VoiceOverItem m_VoiceOver;

	[Token(Token = "0x4006203")]
	[FieldOffset(Offset = "0x20")]
	private TLD_SayTrack m_Track;

	[Token(Token = "0x4006204")]
	[FieldOffset(Offset = "0x28")]
	private PlayableBehaviourSay m_PlayableBehaviour;

	[Token(Token = "0x600551F")]
	[Address(RVA = "0xE959E0", Offset = "0xE947E0", Length = "0x3F7")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005520")]
	[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
	public void SetTrack(TLD_SayTrack sayTrack)
	{
	}

	[Token(Token = "0x6005521")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public TLD_SayTrack GetTrack()
	{
		return null;
	}

	[Token(Token = "0x6005522")]
	[Address(RVA = "0xE95DE0", Offset = "0xE94BE0", Length = "0xCD")]
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		currentTime = default(float);
		return false;
	}

	[Token(Token = "0x6005523")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSay()
	{
	}
}
