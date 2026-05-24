using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000977")]
public class PlayableAssetSetForceDefaultClothing : PlayableAsset
{
	[Token(Token = "0x4006208")]
	[FieldOffset(Offset = "0x18")]
	public PlayableBehaviourSetForceDefaultClothing m_Settings;

	[Token(Token = "0x6005528")]
	[Address(RVA = "0xE960B0", Offset = "0xE94EB0", Length = "0x113")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005529")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSetForceDefaultClothing()
	{
	}
}
