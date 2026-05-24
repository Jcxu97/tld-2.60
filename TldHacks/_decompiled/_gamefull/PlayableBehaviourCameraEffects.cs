using System;
using Cpp2ILInjected;
using UnityEngine.Playables;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000982")]
public class PlayableBehaviourCameraEffects : PlayableBehaviour
{
	[Token(Token = "0x400621C")]
	[FieldOffset(Offset = "0x10")]
	public float m_FadeIntensity;

	[Token(Token = "0x400621D")]
	[FieldOffset(Offset = "0x14")]
	public float m_BlurIntensity;

	[Token(Token = "0x400621E")]
	[FieldOffset(Offset = "0x18")]
	public float m_PostProcessWeigth;

	[Token(Token = "0x400621F")]
	[FieldOffset(Offset = "0x20")]
	public string m_PostProcessVolumeName;

	[Token(Token = "0x4006220")]
	[FieldOffset(Offset = "0x28")]
	private PostProcessVolume m_PostProcessVolume;

	[Token(Token = "0x6005542")]
	[Address(RVA = "0xE98510", Offset = "0xE97310", Length = "0x421")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6005543")]
	[Address(RVA = "0xE98940", Offset = "0xE97740", Length = "0x155")]
	private void MaybeSetPostProcessVolume()
	{
	}

	[Token(Token = "0x6005544")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayableBehaviourCameraEffects()
	{
	}
}
