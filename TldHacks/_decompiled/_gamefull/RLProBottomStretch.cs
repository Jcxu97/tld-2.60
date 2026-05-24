using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_BottomStretch_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Bottom Stretch Effect", false)]
[Token(Token = "0x2000AAB")]
public sealed class RLProBottomStretch : PostProcessEffectSettings
{
	[Range(0.01f, 0.5f)]
	[Tooltip("Height of Noise.")]
	[Token(Token = "0x4006894")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter height;

	[Space]
	[Tooltip("distort stretched area.")]
	[Token(Token = "0x4006895")]
	[FieldOffset(Offset = "0x38")]
	public BoolParameter distort;

	[Range(100f, 0.1f)]
	[Tooltip("Distortion frequency.")]
	[Token(Token = "0x4006896")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter frequency;

	[Range(0.01f, 200f)]
	[Tooltip("Distortion amplitude.")]
	[Token(Token = "0x4006897")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter amplitude;

	[Tooltip("enable random amplitude and frequency.")]
	[Token(Token = "0x4006898")]
	[FieldOffset(Offset = "0x50")]
	public BoolParameter distortRandomly;

	[Token(Token = "0x6005C65")]
	[Address(RVA = "0xF41560", Offset = "0xF40360", Length = "0x315")]
	public RLProBottomStretch()
	{
	}
}
