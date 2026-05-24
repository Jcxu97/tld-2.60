using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x200098F")]
public class PlayableBehaviourSpeakerName : PlayableBehaviour
{
	[Token(Token = "0x4006266")]
	[FieldOffset(Offset = "0x10")]
	public string m_LocID;

	[Token(Token = "0x4006267")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsUnknownSpeaker;

	[Token(Token = "0x4006268")]
	[FieldOffset(Offset = "0x1C")]
	public PlayableAssetSpeakerName.SourceType m_SourceType;

	[SerializeField]
	[Token(Token = "0x4006269")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x600557B")]
	[Address(RVA = "0xE9D860", Offset = "0xE9C660", Length = "0x1F1")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600557C")]
	[Address(RVA = "0xE9DA60", Offset = "0xE9C860", Length = "0x6C")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600557D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourSpeakerName()
	{
	}
}
