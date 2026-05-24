using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(VignetteRenderer), "Unity/Vignette", true)]
[Token(Token = "0x2000CBA")]
public sealed class Vignette : PostProcessEffectSettings
{
	[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
	[Token(Token = "0x4007F1C")]
	[FieldOffset(Offset = "0x30")]
	public VignetteModeParameter mode;

	[Tooltip("Vignette color.")]
	[Token(Token = "0x4007F1D")]
	[FieldOffset(Offset = "0x38")]
	public ColorParameter color;

	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	[Token(Token = "0x4007F1E")]
	[FieldOffset(Offset = "0x40")]
	public Vector2Parameter center;

	[Range(0f, 1f)]
	[Tooltip("Amount of vignetting on screen.")]
	[Token(Token = "0x4007F1F")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter intensity;

	[Range(0.01f, 1f)]
	[Tooltip("Smoothness of the vignette borders.")]
	[Token(Token = "0x4007F20")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter smoothness;

	[Range(0f, 1f)]
	[Tooltip("Lower values will make a square-ish vignette.")]
	[Token(Token = "0x4007F21")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter roundness;

	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	[Token(Token = "0x4007F22")]
	[FieldOffset(Offset = "0x60")]
	public BoolParameter rounded;

	[Tooltip("A black and white mask to use as a vignette.")]
	[Token(Token = "0x4007F23")]
	[FieldOffset(Offset = "0x68")]
	public TextureParameter mask;

	[Range(0f, 1f)]
	[Tooltip("Mask opacity.")]
	[Token(Token = "0x4007F24")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter opacity;

	[Token(Token = "0x6006520")]
	[Address(RVA = "0x100D290", Offset = "0x100C090", Length = "0x154")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6006521")]
	[Address(RVA = "0x100D3F0", Offset = "0x100C1F0", Length = "0x5D9")]
	public Vignette()
	{
	}
}
