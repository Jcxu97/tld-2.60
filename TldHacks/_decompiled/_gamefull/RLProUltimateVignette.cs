using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLProUltimateVignetteRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Ultimate Vignette", false)]
[Token(Token = "0x2000AD6")]
public sealed class RLProUltimateVignette : PostProcessEffectSettings
{
	[Token(Token = "0x400691F")]
	[FieldOffset(Offset = "0x30")]
	public VignetteModeParameter vignetteShape;

	[Tooltip("Circle center(parameter for vignetteShape = 0).")]
	[Token(Token = "0x4006920")]
	[FieldOffset(Offset = "0x38")]
	public Vector2Parameter center;

	[Range(0f, 100f)]
	[Tooltip(".")]
	[Token(Token = "0x4006921")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter vignetteAmount;

	[Range(-1f, -100f)]
	[Tooltip(".")]
	[Token(Token = "0x4006922")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter vignetteFineTune;

	[Range(0f, 100f)]
	[Tooltip("Scanlines width.")]
	[Token(Token = "0x4006923")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter edgeSoftness;

	[Range(200f, 0f)]
	[Tooltip("Horizontal/Vertical scanlines.")]
	[Token(Token = "0x4006924")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter edgeBlend;

	[Range(0f, 200f)]
	[Tooltip(".")]
	[Token(Token = "0x4006925")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter innerColorAlpha;

	[Token(Token = "0x4006926")]
	[FieldOffset(Offset = "0x68")]
	public ColorParameter innerColor;

	[Token(Token = "0x6005CAD")]
	[Address(RVA = "0xF50BB0", Offset = "0xF4F9B0", Length = "0x504")]
	public RLProUltimateVignette()
	{
	}
}
