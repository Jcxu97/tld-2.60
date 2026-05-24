using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000972")]
public class PlayableAssetJumpToTime : PlayableAsset
{
	[Token(Token = "0x40061F9")]
	[FieldOffset(Offset = "0x18")]
	public bool m_allowSkipIfNotSeen;

	[Token(Token = "0x6005519")]
	[Address(RVA = "0xE95240", Offset = "0xE94040", Length = "0x3A5")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600551A")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetJumpToTime()
	{
	}
}
