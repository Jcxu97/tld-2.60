using Cpp2ILInjected;
using UnityEngine.Playables;

[Token(Token = "0x2000992")]
public class PlayableBehaviourTitleCards : PlayableBehaviour
{
	[Token(Token = "0x400627C")]
	[FieldOffset(Offset = "0x10")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x6005586")]
	[Address(RVA = "0xE9E970", Offset = "0xE9D770", Length = "0x1FB")]
	private bool HasHUD()
	{
		return false;
	}

	[Token(Token = "0x6005587")]
	[Address(RVA = "0xE9EB70", Offset = "0xE9D970", Length = "0x3AA")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005588")]
	[Address(RVA = "0xE9EF20", Offset = "0xE9DD20", Length = "0x43")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6005589")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourTitleCards()
	{
	}
}
