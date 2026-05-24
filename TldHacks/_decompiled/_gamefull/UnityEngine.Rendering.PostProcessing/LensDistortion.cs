using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(LensDistortionRenderer), "Unity/Lens Distortion", true)]
[Token(Token = "0x2000CA1")]
public sealed class LensDistortion : PostProcessEffectSettings
{
	[Range(-100f, 100f)]
	[Tooltip("Total distortion amount.")]
	[Token(Token = "0x4007EA6")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter intensity;

	[Range(0f, 1f)]
	[DisplayName("X Multiplier")]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	[Token(Token = "0x4007EA7")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter intensityX;

	[Range(0f, 1f)]
	[DisplayName("Y Multiplier")]
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	[Token(Token = "0x4007EA8")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter intensityY;

	[Space]
	[Range(-1f, 1f)]
	[Tooltip("Distortion center point (x-axis).")]
	[Token(Token = "0x4007EA9")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter centerX;

	[Range(-1f, 1f)]
	[Tooltip("Distortion center point (y-axis).")]
	[Token(Token = "0x4007EAA")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter centerY;

	[Space]
	[Range(0.01f, 5f)]
	[Tooltip("Global screen scaling.")]
	[Token(Token = "0x4007EAB")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter scale;

	[Token(Token = "0x60064D7")]
	[Address(RVA = "0xFFD370", Offset = "0xFFC170", Length = "0xBE")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064D8")]
	[Address(RVA = "0xFFD430", Offset = "0xFFC230", Length = "0x3B4")]
	public LensDistortion()
	{
	}
}
