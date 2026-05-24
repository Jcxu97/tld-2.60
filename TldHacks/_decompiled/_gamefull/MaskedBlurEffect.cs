using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(MaskedBlurEffectRenderer), PostProcessEvent.BeforeStack, "Hinterland/Masked Blur", true)]
[Token(Token = "0x20003D4")]
public sealed class MaskedBlurEffect : PostProcessEffectSettings
{
	[Token(Token = "0x4002291")]
	[FieldOffset(Offset = "0x30")]
	public TextureParameter depthTexture;

	[Range(0.01f, 1f)]
	[Token(Token = "0x4002292")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter depthBlendAmount;

	[UnityEngine.Rendering.PostProcessing.Min(0.1f)]
	[Tooltip("Distance to the point of focus.")]
	[Token(Token = "0x4002293")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter focusDistance;

	[Range(0.05f, 32f)]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	[Token(Token = "0x4002294")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter aperture;

	[Range(1f, 300f)]
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	[Token(Token = "0x4002295")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter focalLength;

	[DisplayName("Max Blur Size")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	[Token(Token = "0x4002296")]
	[FieldOffset(Offset = "0x58")]
	public KernelSizeParameter kernelSize;

	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x7ABC40", Offset = "0x7AAA40", Length = "0x67")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x7ABCB0", Offset = "0x7AAAB0", Length = "0x409")]
	public MaskedBlurEffect()
	{
	}
}
