using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(SuffocationScreenEffectRenderer), PostProcessEvent.BeforeStack, "Hinterland/Suffocation Screen Effect", false)]
[Token(Token = "0x20003FE")]
public sealed class SuffocationScreenEffect : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Token(Token = "0x40023F7")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter m_Intensity;

	[Range(0f, 1f)]
	[Token(Token = "0x40023F8")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter m_RadialBlurAmount;

	[Range(0f, 1f)]
	[Token(Token = "0x40023F9")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter m_RadialBlurCenterOffset;

	[Token(Token = "0x40023FA")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter m_RadialBlurPower;

	[Range(0f, 1f)]
	[Token(Token = "0x40023FB")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter m_VignetteStrength;

	[Token(Token = "0x40023FC")]
	[FieldOffset(Offset = "0x58")]
	public Vector4Parameter m_NoiseScaleAndSpeed;

	[Token(Token = "0x40023FD")]
	[FieldOffset(Offset = "0x60")]
	public TextureParameter m_NoiseTexture;

	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x7C1700", Offset = "0x7C0500", Length = "0x42A")]
	public SuffocationScreenEffect()
	{
	}
}
