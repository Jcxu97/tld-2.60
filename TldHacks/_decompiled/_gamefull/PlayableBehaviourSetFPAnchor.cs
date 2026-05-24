using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x200098C")]
public class PlayableBehaviourSetFPAnchor : PlayableBehaviour
{
	[Token(Token = "0x400625A")]
	[FieldOffset(Offset = "0x10")]
	public string m_ObjectName;

	[Token(Token = "0x400625B")]
	[FieldOffset(Offset = "0x18")]
	public bool m_AttemptToFindObjectInChildren;

	[Token(Token = "0x400625C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Anchor;

	[Token(Token = "0x400625D")]
	[FieldOffset(Offset = "0x28")]
	public List<TLD_IFPAnchoredTrack> m_Tracks;

	[Token(Token = "0x400625E")]
	[FieldOffset(Offset = "0x30")]
	public string m_SyncNodeInfoId;

	[Token(Token = "0x400625F")]
	[FieldOffset(Offset = "0x38")]
	public PlayableDirector m_Director;

	[Token(Token = "0x6005570")]
	[Address(RVA = "0xE9C6B0", Offset = "0xE9B4B0", Length = "0xA")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005571")]
	[Address(RVA = "0xE9C6C0", Offset = "0xE9B4C0", Length = "0x57")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005572")]
	[Address(RVA = "0xE9C720", Offset = "0xE9B520", Length = "0x52")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005573")]
	[Address(RVA = "0xE9C780", Offset = "0xE9B580", Length = "0x357")]
	private void MaybeSetAnchor(TLD_TimelineDirector timelineDirector)
	{
	}

	[Token(Token = "0x6005574")]
	[Address(RVA = "0xE9CAE0", Offset = "0xE9B8E0", Length = "0x397")]
	private GameObject FindAnchor(TLD_TimelineDirector timelineDirector)
	{
		return null;
	}

	[Token(Token = "0x6005575")]
	[Address(RVA = "0xE9CE80", Offset = "0xE9BC80", Length = "0xAD")]
	public PlayableBehaviourSetFPAnchor()
	{
	}
}
