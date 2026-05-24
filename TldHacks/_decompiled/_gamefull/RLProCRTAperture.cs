using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLProCRTAperture_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/CRT Aperture", false)]
[Token(Token = "0x2000AB4")]
public sealed class RLProCRTAperture : PostProcessEffectSettings
{
	[Range(0f, 5f)]
	[Tooltip(".")]
	[Token(Token = "0x40068A8")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter GlowHalation;

	[Range(0f, 2f)]
	[Tooltip(".")]
	[Token(Token = "0x40068A9")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter GlowDifusion;

	[Range(0f, 2f)]
	[Tooltip(".")]
	[Token(Token = "0x40068AA")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter MaskColors;

	[Range(0f, 1f)]
	[Tooltip(".")]
	[Token(Token = "0x40068AB")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter MaskStrength;

	[Range(0f, 5f)]
	[Tooltip(".")]
	[Token(Token = "0x40068AC")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter GammaInput;

	[Range(0f, 5f)]
	[Tooltip(".")]
	[Token(Token = "0x40068AD")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter GammaOutput;

	[Range(0f, 2.5f)]
	[Tooltip(".")]
	[Token(Token = "0x40068AE")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter Brightness;

	[Token(Token = "0x6005C77")]
	[Address(RVA = "0xF43EB0", Offset = "0xF42CB0", Length = "0x444")]
	public RLProCRTAperture()
	{
	}
}
