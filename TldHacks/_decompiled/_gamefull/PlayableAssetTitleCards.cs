using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200097E")]
public class PlayableAssetTitleCards : PlayableAsset
{
	[Token(Token = "0x4006217")]
	[FieldOffset(Offset = "0x18")]
	public PlayableBehaviourTitleCards template;

	[Token(Token = "0x6005538")]
	[Address(RVA = "0xE97CC0", Offset = "0xE96AC0", Length = "0x113")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005539")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetTitleCards()
	{
	}
}
