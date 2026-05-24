using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_TVEffect_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/TV Effect", false)]
[Token(Token = "0x2000AD3")]
public sealed class RLProTVEffect : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip("Dark areas adjustment.")]
	[Token(Token = "0x4006916")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter fade;

	[Range(0f, 2f)]
	[Tooltip("Dark areas adjustment.")]
	[Token(Token = "0x4006917")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter maskDark;

	[Range(0f, 2f)]
	[Tooltip("Light areas adjustment.")]
	[Token(Token = "0x4006918")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter maskLight;

	[Range(-8f, -16f)]
	[Tooltip("Dark areas fine tune.")]
	[Token(Token = "0x4006919")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter hardScan;

	[Range(1f, 16f)]
	[Tooltip("Effect resolution.")]
	[Token(Token = "0x400691A")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter resScale;

	[Range(-3f, 1f)]
	[Tooltip("pixels sharpness.")]
	[Token(Token = "0x400691B")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter hardPix;

	[Tooltip("Warp mode.")]
	[Token(Token = "0x400691C")]
	[FieldOffset(Offset = "0x60")]
	public WarpModeParameter warpMode;

	[Tooltip("Warp picture.")]
	[Token(Token = "0x400691D")]
	[FieldOffset(Offset = "0x68")]
	public Vector2Parameter warp;

	[Token(Token = "0x400691E")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter scale;

	[Token(Token = "0x6005CA9")]
	[Address(RVA = "0xF4FD10", Offset = "0xF4EB10", Length = "0x584")]
	public RLProTVEffect()
	{
	}
}
