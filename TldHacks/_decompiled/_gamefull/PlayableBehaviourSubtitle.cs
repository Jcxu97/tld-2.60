using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000990")]
public class PlayableBehaviourSubtitle : PlayableBehaviour
{
	[Token(Token = "0x400626A")]
	[FieldOffset(Offset = "0x10")]
	public string m_LocID;

	[Token(Token = "0x400626B")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsUnknownSpeaker;

	[SerializeField]
	[Token(Token = "0x400626C")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x400626D")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsShowingSubtitles;

	[Token(Token = "0x600557E")]
	[Address(RVA = "0xE9DAD0", Offset = "0xE9C8D0", Length = "0x8F")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600557F")]
	[Address(RVA = "0xE9DB60", Offset = "0xE9C960", Length = "0x76")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005580")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourSubtitle()
	{
	}
}
