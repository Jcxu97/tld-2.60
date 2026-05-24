using Cpp2ILInjected;
using UnityEngine.Playables;

[Token(Token = "0x2000987")]
public class PlayableBehaviourJumpToTime : PlayableBehaviour
{
	[Token(Token = "0x4006235")]
	[FieldOffset(Offset = "0x10")]
	public bool m_CanSkip;

	[Token(Token = "0x6005555")]
	[Address(RVA = "0xE9A2D0", Offset = "0xE990D0", Length = "0x180")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005556")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourJumpToTime()
	{
	}
}
