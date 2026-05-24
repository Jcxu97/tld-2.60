using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(ChemicalPoisoningScreenEffectRenderer), PostProcessEvent.BeforeStack, "Hinterland/Chemical Poisoning Screen Effect", false)]
[Token(Token = "0x2000373")]
public sealed class ChemicalPoisoningScreenEffect : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Token(Token = "0x4001E9E")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter m_Intensity;

	[Range(0f, 1f)]
	[Token(Token = "0x4001E9F")]
	[FieldOffset(Offset = "0x38")]
	public ColorParameter m_Color;

	[Token(Token = "0x4001EA0")]
	[FieldOffset(Offset = "0x40")]
	public TextureParameter m_PoisonMask;

	[Token(Token = "0x4001EA1")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter m_MaskTiling;

	[Range(0f, 1f)]
	[Token(Token = "0x4001EA2")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter m_SceneBrightnessAdjustment;

	[Token(Token = "0x4001EA3")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter m_GradientIncrement;

	[Token(Token = "0x4001EA4")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter m_VignettePower;

	[Token(Token = "0x4001EA5")]
	[FieldOffset(Offset = "0x68")]
	public Vector2Parameter m_IntensityRange;

	[Token(Token = "0x4001EA6")]
	[FieldOffset(Offset = "0x70")]
	public Vector3Parameter m_AnimationControl;

	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x76E210", Offset = "0x76D010", Length = "0x5A4")]
	public ChemicalPoisoningScreenEffect()
	{
	}
}
