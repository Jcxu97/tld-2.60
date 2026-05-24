using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200096B")]
public class PlayableAssetCameraEffects : PlayableAsset
{
	[Token(Token = "0x40061EA")]
	[FieldOffset(Offset = "0x18")]
	public PlayableBehaviourCameraEffects template;

	[Token(Token = "0x600550F")]
	[Address(RVA = "0xE94A20", Offset = "0xE93820", Length = "0x113")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005510")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetCameraEffects()
	{
	}
}
