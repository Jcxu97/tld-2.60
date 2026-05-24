using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_NegativeRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Negative Filter", false)]
[Token(Token = "0x2000AC6")]
public sealed class RLProNegative : PostProcessEffectSettings
{
	[Range(0f, 2f)]
	[Tooltip("Brightness.")]
	[Token(Token = "0x40068E7")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter luminosity;

	[Range(0f, 1f)]
	[Tooltip("Vignette amount.")]
	[Token(Token = "0x40068E8")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter vignette;

	[Range(0f, 1f)]
	[Tooltip("Negative amount.")]
	[Token(Token = "0x40068E9")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter negative;

	[Token(Token = "0x6005C95")]
	[Address(RVA = "0xF4AB90", Offset = "0xF49990", Length = "0x204")]
	public RLProNegative()
	{
	}
}
