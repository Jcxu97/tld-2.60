using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", false)]
[Token(Token = "0x2000CA3")]
public sealed class MotionBlur : PostProcessEffectSettings
{
	[Range(0f, 360f)]
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	[Token(Token = "0x4007EAC")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter shutterAngle;

	[Range(4f, 32f)]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	[Token(Token = "0x4007EAD")]
	[FieldOffset(Offset = "0x38")]
	public IntParameter sampleCount;

	[Token(Token = "0x60064DB")]
	[Address(RVA = "0xFFDC20", Offset = "0xFFCA20", Length = "0xF2")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064DC")]
	[Address(RVA = "0xFFDD20", Offset = "0xFFCB20", Length = "0x184")]
	public MotionBlur()
	{
	}
}
