using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200096A")]
public class PlayableAssetActivateSpawnedObject : PlayableAsset
{
	[Token(Token = "0x40061E9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_PrefabObject;

	[Token(Token = "0x600550C")]
	[Address(RVA = "0xE944A0", Offset = "0xE932A0", Length = "0x403")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600550D")]
	[Address(RVA = "0xE948B0", Offset = "0xE936B0", Length = "0x163")]
	private bool IsTrackMatching(TLD_SpawnedAnimationTrack track)
	{
		return false;
	}

	[Token(Token = "0x600550E")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetActivateSpawnedObject()
	{
	}
}
