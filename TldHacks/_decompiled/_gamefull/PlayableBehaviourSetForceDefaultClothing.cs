using System;
using Cpp2ILInjected;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x200098B")]
public class PlayableBehaviourSetForceDefaultClothing : PlayableBehaviour
{
	[Token(Token = "0x4006258")]
	[FieldOffset(Offset = "0x10")]
	public bool m_ForceDefaultArms;

	[Token(Token = "0x4006259")]
	[FieldOffset(Offset = "0x11")]
	public bool m_ForceDefaultHands;

	[Token(Token = "0x600556D")]
	[Address(RVA = "0xE9C300", Offset = "0xE9B100", Length = "0x12F")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600556E")]
	[Address(RVA = "0xE9C430", Offset = "0xE9B230", Length = "0x274")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600556F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourSetForceDefaultClothing()
	{
	}
}
