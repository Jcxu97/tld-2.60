using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200096F")]
public class PlayableAssetFadeLight : PlayableAsset
{
	[Token(Token = "0x2000970")]
	public enum FadeType
	{
		[Token(Token = "0x40061F6")]
		FadeIn,
		[Token(Token = "0x40061F7")]
		FadeOut
	}

	[Token(Token = "0x40061F1")]
	[FieldOffset(Offset = "0x18")]
	public string m_MissionObjectId;

	[Range(0f, 1f)]
	[Token(Token = "0x40061F2")]
	[FieldOffset(Offset = "0x20")]
	public float m_FadedInPercent;

	[Range(0f, 1f)]
	[Token(Token = "0x40061F3")]
	[FieldOffset(Offset = "0x24")]
	public float m_FadedOutPercent;

	[Token(Token = "0x40061F4")]
	[FieldOffset(Offset = "0x28")]
	public FadeType m_FadeType;

	[Token(Token = "0x6005515")]
	[Address(RVA = "0xE94E10", Offset = "0xE93C10", Length = "0x2F2")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005516")]
	[Address(RVA = "0xE95110", Offset = "0xE93F10", Length = "0xE")]
	public PlayableAssetFadeLight()
	{
	}
}
