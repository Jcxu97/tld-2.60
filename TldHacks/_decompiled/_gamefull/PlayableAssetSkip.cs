using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000979")]
public class PlayableAssetSkip : PlayableAsset
{
	[Token(Token = "0x600552C")]
	[Address(RVA = "0xE96880", Offset = "0xE95680", Length = "0x807")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600552D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSkip()
	{
	}
}
