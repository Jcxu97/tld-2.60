using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_OldFilmRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Old Film", false)]
[Token(Token = "0x2000ACA")]
public sealed class RLProOldFilm : PostProcessEffectSettings
{
	[Range(0f, 60f)]
	[Tooltip("Frames per second.")]
	[Token(Token = "0x4006900")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter fps;

	[Range(0f, 5f)]
	[Tooltip(".")]
	[Token(Token = "0x4006901")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter contrast;

	[Range(-2f, 4f)]
	[Tooltip("Image burn.")]
	[Token(Token = "0x4006902")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter burn;

	[Range(0f, 16f)]
	[Tooltip("Scene cut off.")]
	[Token(Token = "0x4006903")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter sceneCut;

	[Range(0f, 1f)]
	[Tooltip(".")]
	[Token(Token = "0x4006904")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter fade;

	[Token(Token = "0x6005C9C")]
	[Address(RVA = "0xF4D510", Offset = "0xF4C310", Length = "0x324")]
	public RLProOldFilm()
	{
	}
}
