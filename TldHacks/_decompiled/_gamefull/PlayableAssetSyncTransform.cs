using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200097D")]
public class PlayableAssetSyncTransform : PlayableAsset
{
	[Token(Token = "0x4006215")]
	[FieldOffset(Offset = "0x18")]
	public PlayableBehaviourSyncTransform m_Settings;

	[Token(Token = "0x4006216")]
	[FieldOffset(Offset = "0x20")]
	private string m_CurrentPrefabName;

	[Token(Token = "0x6005534")]
	[Address(RVA = "0xE974C0", Offset = "0xE962C0", Length = "0x421")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6005535")]
	[Address(RVA = "0xE978F0", Offset = "0xE966F0", Length = "0x26F")]
	private TLD_SpawnedAnimationTrack FindAnimationTrackForPrefab(PlayableDirector director, GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6005536")]
	[Address(RVA = "0xE97B60", Offset = "0xE96960", Length = "0x154")]
	private bool IsTrackMatching(TLD_SpawnedAnimationTrack track)
	{
		return false;
	}

	[Token(Token = "0x6005537")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlayableAssetSyncTransform()
	{
	}
}
