using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLProVHSScanlinesRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/VHS Scanlines", false)]
[Token(Token = "0x2000ADB")]
public sealed class RLProVHSScanlines : PostProcessEffectSettings
{
	[Tooltip(".")]
	[Token(Token = "0x4006939")]
	[FieldOffset(Offset = "0x30")]
	public ColorParameter scanLinesColor;

	[Token(Token = "0x400693A")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter scanLines;

	[Token(Token = "0x400693B")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter speed;

	[Range(0f, 1f)]
	[Token(Token = "0x400693C")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter fade;

	[Token(Token = "0x400693D")]
	[FieldOffset(Offset = "0x50")]
	public BoolParameter horizontal;

	[Range(3500f, 1f)]
	[Tooltip(".")]
	[Token(Token = "0x400693E")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter distortion;

	[Token(Token = "0x400693F")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter distortion1;

	[Token(Token = "0x4006940")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter distortion2;

	[Token(Token = "0x4006941")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter scale;

	[Token(Token = "0x6005CB4")]
	[Address(RVA = "0xF53350", Offset = "0xF52150", Length = "0x529")]
	public RLProVHSScanlines()
	{
	}
}
