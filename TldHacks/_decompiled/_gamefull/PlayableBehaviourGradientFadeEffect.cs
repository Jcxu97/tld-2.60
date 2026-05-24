using System;
using Cpp2ILInjected;
using UnityEngine.Playables;

[Serializable]
[Token(Token = "0x2000986")]
public class PlayableBehaviourGradientFadeEffect : PlayableBehaviour
{
	[Token(Token = "0x4006231")]
	[FieldOffset(Offset = "0x10")]
	public GradientFadeEffect m_EffectSettings;

	[Token(Token = "0x4006232")]
	[FieldOffset(Offset = "0x18")]
	public float m_Intensity;

	[Token(Token = "0x4006233")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Position;

	[Token(Token = "0x4006234")]
	[FieldOffset(Offset = "0x20")]
	public float m_Direction;

	[Token(Token = "0x6005553")]
	[Address(RVA = "0xE9A100", Offset = "0xE98F00", Length = "0x1D0")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005554")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourGradientFadeEffect()
	{
	}
}
