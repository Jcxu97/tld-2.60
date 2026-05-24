using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200097A")]
public class PlayableAssetSpeakerName : PlayableAsset
{
	[Token(Token = "0x200097B")]
	public enum SourceType
	{
		[Token(Token = "0x4006210")]
		Phone,
		[Token(Token = "0x4006211")]
		CommunitySpeaker
	}

	[Token(Token = "0x400620C")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsUnkownSpeaker;

	[Header("Localization Id sample for speaker")]
	[Token(Token = "0x400620D")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizationId;

	[Token(Token = "0x400620E")]
	[FieldOffset(Offset = "0x28")]
	public SourceType m_SourceType;

	[Token(Token = "0x600552E")]
	[Address(RVA = "0xE97090", Offset = "0xE95E90", Length = "0x213")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600552F")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSpeakerName()
	{
	}
}
