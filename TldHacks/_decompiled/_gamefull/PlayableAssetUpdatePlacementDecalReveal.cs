using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200097F")]
public class PlayableAssetUpdatePlacementDecalReveal : PlayableAsset
{
	[Token(Token = "0x4006218")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsErasing;

	[Token(Token = "0x4006219")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 m_ValueRange;

	[Token(Token = "0x600553A")]
	[Address(RVA = "0xE97DE0", Offset = "0xE96BE0", Length = "0x1BD")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600553B")]
	[Address(RVA = "0xE97FA0", Offset = "0xE96DA0", Length = "0x15")]
	public PlayableAssetUpdatePlacementDecalReveal()
	{
	}
}
