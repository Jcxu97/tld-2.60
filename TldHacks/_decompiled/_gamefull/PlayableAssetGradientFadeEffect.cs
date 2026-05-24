using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000971")]
public class PlayableAssetGradientFadeEffect : PlayableAsset
{
	[Token(Token = "0x40061F8")]
	[FieldOffset(Offset = "0x18")]
	public PlayableBehaviourGradientFadeEffect m_Settings;

	[Token(Token = "0x6005517")]
	[Address(RVA = "0xE95120", Offset = "0xE93F20", Length = "0x113")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005518")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetGradientFadeEffect()
	{
	}
}
