using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;

[Token(Token = "0x2000993")]
public class PlayableBehaviourUpdatePlacementDecalReveal : PlayableBehaviour
{
	[Token(Token = "0x400627D")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsErasing;

	[Token(Token = "0x400627E")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 m_ValueRange;

	[Token(Token = "0x600558A")]
	[Address(RVA = "0xE9EF70", Offset = "0xE9DD70", Length = "0x138")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600558B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourUpdatePlacementDecalReveal()
	{
	}
}
