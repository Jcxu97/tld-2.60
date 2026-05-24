using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x2000991")]
public class PlayableBehaviourSyncTransform : PlayableBehaviour
{
	[Header("Sync Source")]
	[Token(Token = "0x400626E")]
	[FieldOffset(Offset = "0x10")]
	public string m_SourceName;

	[Token(Token = "0x400626F")]
	[FieldOffset(Offset = "0x18")]
	public string m_SourceMissionObjectID;

	[Token(Token = "0x4006270")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_SourcePrefab;

	[Header("Sync Target")]
	[Token(Token = "0x4006271")]
	[FieldOffset(Offset = "0x28")]
	public string m_TargetName;

	[Token(Token = "0x4006272")]
	[FieldOffset(Offset = "0x30")]
	public string m_TargetMissionObjectID;

	[Token(Token = "0x4006273")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_TargetPrefab;

	[Header("Sync Options")]
	[Token(Token = "0x4006274")]
	[FieldOffset(Offset = "0x40")]
	public bool m_SyncInLocalSpace;

	[Token(Token = "0x4006275")]
	[FieldOffset(Offset = "0x41")]
	public bool m_SyncPosition;

	[Token(Token = "0x4006276")]
	[FieldOffset(Offset = "0x42")]
	public bool m_SyncRotation;

	[Token(Token = "0x4006277")]
	[FieldOffset(Offset = "0x43")]
	public bool m_SyncScale;

	[HideInInspector]
	[Token(Token = "0x4006278")]
	[FieldOffset(Offset = "0x48")]
	public TLD_SpawnedAnimationTrack m_SourceSpawnedAnimationTrack;

	[HideInInspector]
	[Token(Token = "0x4006279")]
	[FieldOffset(Offset = "0x50")]
	public TLD_SpawnedAnimationTrack m_TargetSpawnedAnimationTrack;

	[Token(Token = "0x400627A")]
	[FieldOffset(Offset = "0x58")]
	private Transform m_SourceTransform;

	[Token(Token = "0x400627B")]
	[FieldOffset(Offset = "0x60")]
	private Transform m_TargetTransform;

	[Token(Token = "0x6005581")]
	[Address(RVA = "0xE9DBE0", Offset = "0xE9C9E0", Length = "0x12B")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005582")]
	[Address(RVA = "0xE9DD10", Offset = "0xE9CB10", Length = "0x3AC")]
	private Transform GetParent(string missionObjectIdentifier, GameObject prefab, TLD_SpawnedAnimationTrack spawnedAnimationTrack)
	{
		return null;
	}

	[Token(Token = "0x6005583")]
	[Address(RVA = "0xE9E0C0", Offset = "0xE9CEC0", Length = "0x2BE")]
	private Transform FindTransform(Transform parent, string transformName)
	{
		return null;
	}

	[Token(Token = "0x6005584")]
	[Address(RVA = "0xE9E380", Offset = "0xE9D180", Length = "0x5DC")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005585")]
	[Address(RVA = "0xE9E960", Offset = "0xE9D760", Length = "0x7")]
	public PlayableBehaviourSyncTransform()
	{
	}
}
