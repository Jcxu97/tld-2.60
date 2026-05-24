using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200097C")]
public class PlayableAssetSubtitle : PlayableAsset
{
	[Token(Token = "0x4006212")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsUnkownSpeaker;

	[Token(Token = "0x4006213")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizationId;

	[Token(Token = "0x4006214")]
	[FieldOffset(Offset = "0x28")]
	private TLD_SubtitleTrack m_Track;

	[Token(Token = "0x6005530")]
	[Address(RVA = "0xE972B0", Offset = "0xE960B0", Length = "0x20C")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005531")]
	[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
	public void SetTrack(TLD_SubtitleTrack tldSubtitleTrack)
	{
	}

	[Token(Token = "0x6005532")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public TLD_SubtitleTrack GetTrack()
	{
		return null;
	}

	[Token(Token = "0x6005533")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSubtitle()
	{
	}
}
