using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_BleedRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Bleed Effect", false)]
[Token(Token = "0x2000AA7")]
public sealed class RLProBleed : PostProcessEffectSettings
{
	[Token(Token = "0x4006880")]
	[FieldOffset(Offset = "0x30")]
	public bleedModeParameter bleedMode;

	[Token(Token = "0x4006881")]
	[FieldOffset(Offset = "0x38")]
	public int bleedModeIndex;

	[Range(0f, 15f)]
	[Tooltip("Bleed Stretch amount.")]
	[Token(Token = "0x4006882")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter bleedAmount;

	[Range(0f, 50f)]
	[Tooltip("Bleed Length.")]
	[Token(Token = "0x4006883")]
	[FieldOffset(Offset = "0x48")]
	public IntParameter bleedLength;

	[Token(Token = "0x4006884")]
	[FieldOffset(Offset = "0x50")]
	public BoolParameter bleedDebug;

	[Token(Token = "0x4006885")]
	[FieldOffset(Offset = "0x58")]
	public BoolParameter editCurves;

	[Token(Token = "0x4006886")]
	[FieldOffset(Offset = "0x60")]
	public BoolParameter syncYQ;

	[Token(Token = "0x4006887")]
	[FieldOffset(Offset = "0x68")]
	public SplineParameter curveY;

	[Token(Token = "0x4006888")]
	[FieldOffset(Offset = "0x70")]
	public SplineParameter curveI;

	[Token(Token = "0x4006889")]
	[FieldOffset(Offset = "0x78")]
	public SplineParameter curveQ;

	[Token(Token = "0x6005C5C")]
	[Address(RVA = "0xF3F290", Offset = "0xF3E090", Length = "0x797")]
	public RLProBleed()
	{
	}
}
