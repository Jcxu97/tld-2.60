using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000980")]
public class PlayableAssetWaitUserInput : PlayableAsset
{
	[Token(Token = "0x400621A")]
	[FieldOffset(Offset = "0x18")]
	public LocalizedString m_LocalizationId;

	[Token(Token = "0x600553C")]
	[Address(RVA = "0xE97FC0", Offset = "0xE96DC0", Length = "0x270")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600553D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetWaitUserInput()
	{
	}
}
