using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(GradientFadeEffectRenderer), PostProcessEvent.AfterStack, "Hinterland/Gradient Fade Effect", false)]
[CreateAssetMenu(menuName = "The Long Dark/Vfx/Post Process/Gradient Fade Effect Settings")]
[Token(Token = "0x20003AB")]
public sealed class GradientFadeEffect : PostProcessEffectSettings
{
	[Token(Token = "0x40020BD")]
	[FieldOffset(Offset = "0x30")]
	public ColorParameter m_Color;

	[Range(0f, 1f)]
	[Token(Token = "0x40020BE")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter m_Intensity;

	[Range(-1f, 1f)]
	[Token(Token = "0x40020BF")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter m_Position;

	[Token(Token = "0x40020C0")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter m_Direction;

	[Token(Token = "0x40020C1")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter m_GradientPower;

	[Token(Token = "0x40020C2")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter m_CurvatureStrength;

	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x791F40", Offset = "0x790D40", Length = "0x3C4")]
	public GradientFadeEffect()
	{
	}
}
