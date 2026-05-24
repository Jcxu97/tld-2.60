using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_FisheyeRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Fisheye Vignette Effect", false)]
[Token(Token = "0x2000ABA")]
public sealed class RLProFisheye : PostProcessEffectSettings
{
	[Token(Token = "0x40068B4")]
	[FieldOffset(Offset = "0x30")]
	public FisheyeTypeParameter fisheyeType;

	[Range(0f, 50f)]
	[Tooltip("Bend Amount.")]
	[Token(Token = "0x40068B5")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter bend;

	[Range(0f, 50f)]
	[Tooltip("Cutoff on X axes.")]
	[Token(Token = "0x40068B6")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter cutOffX;

	[Range(0f, 50f)]
	[Tooltip("Cutoff on Y axes.")]
	[Token(Token = "0x40068B7")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter cutOffY;

	[Range(0f, 50f)]
	[Tooltip("Fade on X axes.")]
	[Token(Token = "0x40068B8")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter fadeX;

	[Range(0f, 50f)]
	[Tooltip("Fade on Y axes.")]
	[Token(Token = "0x40068B9")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter fadeY;

	[Range(0.001f, 50f)]
	[Tooltip("Fisheye size.")]
	[Token(Token = "0x40068BA")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter size;

	[Token(Token = "0x6005C7E")]
	[Address(RVA = "0xF450B0", Offset = "0xF43EB0", Length = "0x454")]
	public RLProFisheye()
	{
	}
}
