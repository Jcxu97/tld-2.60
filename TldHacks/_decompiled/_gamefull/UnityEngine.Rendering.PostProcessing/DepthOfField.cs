using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(DepthOfFieldRenderer), "Unity/Depth of Field", false)]
[Token(Token = "0x2000C99")]
public sealed class DepthOfField : PostProcessEffectSettings
{
	[Min(0.1f)]
	[Tooltip("Distance to the point of focus.")]
	[Token(Token = "0x4007E85")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter focusDistance;

	[Range(0.05f, 32f)]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	[Token(Token = "0x4007E86")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter aperture;

	[Range(1f, 300f)]
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	[Token(Token = "0x4007E87")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter focalLength;

	[DisplayName("Max Blur Size")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	[Token(Token = "0x4007E88")]
	[FieldOffset(Offset = "0x48")]
	public KernelSizeParameter kernelSize;

	[Token(Token = "0x60064C1")]
	[Address(RVA = "0x7ABC40", Offset = "0x7AAA40", Length = "0x67")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064C2")]
	[Address(RVA = "0xFF98D0", Offset = "0xFF86D0", Length = "0x2A4")]
	public DepthOfField()
	{
	}
}
