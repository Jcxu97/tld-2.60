using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_PulsatingVignetteRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Pulsating Vignette", false)]
[Token(Token = "0x2000AD0")]
public sealed class RLProPulsatingVignette : PostProcessEffectSettings
{
	[Range(0.001f, 50f)]
	[Tooltip("Vignette shake speed.")]
	[Token(Token = "0x4006913")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter speed;

	[Range(0.001f, 50f)]
	[Tooltip("Vignette amount.")]
	[Token(Token = "0x4006914")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter amount;

	[Token(Token = "0x6005CA5")]
	[Address(RVA = "0xF4F640", Offset = "0xF4E440", Length = "0x174")]
	public RLProPulsatingVignette()
	{
	}
}
