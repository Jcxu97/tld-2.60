using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200096C")]
public class PlayableAssetChangeTOD : PlayableAsset
{
	[Token(Token = "0x40061EB")]
	[FieldOffset(Offset = "0x18")]
	public PlayableBehaviourChangeTOD m_Settings;

	[Token(Token = "0x6005511")]
	[Address(RVA = "0xE94B40", Offset = "0xE93940", Length = "0x113")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005512")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetChangeTOD()
	{
	}
}
