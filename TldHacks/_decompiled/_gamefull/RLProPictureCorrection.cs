using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_PictureCorrectionRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Picture Correction", false)]
[Token(Token = "0x2000ACE")]
public sealed class RLProPictureCorrection : PostProcessEffectSettings
{
	[Range(-0.25f, 0.25f)]
	[Tooltip(" Y permanent adjustment..")]
	[Token(Token = "0x400690C")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter signalAdjustY;

	[Range(-0.25f, 0.25f)]
	[Tooltip("I permanent adjustment..")]
	[Token(Token = "0x400690D")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter signalAdjustI;

	[Range(-0.25f, 0.25f)]
	[Tooltip("Q permanent adjustment..")]
	[Token(Token = "0x400690E")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter signalAdjustQ;

	[Range(-2f, 2f)]
	[Tooltip("tweak/shift Y values..")]
	[Token(Token = "0x400690F")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter signalShiftY;

	[Range(-2f, 2f)]
	[Tooltip("tweak/shift I values..")]
	[Token(Token = "0x4006910")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter signalShiftI;

	[Range(-2f, 2f)]
	[Tooltip("tweak/shift Q values..")]
	[Token(Token = "0x4006911")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter signalShiftQ;

	[Range(0f, 2f)]
	[Tooltip("use this to balance the gamma(brightness) of the signal.")]
	[Token(Token = "0x4006912")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter gammaCorection;

	[Token(Token = "0x6005CA2")]
	[Address(RVA = "0xF4EA60", Offset = "0xF4D860", Length = "0x444")]
	public RLProPictureCorrection()
	{
	}
}
