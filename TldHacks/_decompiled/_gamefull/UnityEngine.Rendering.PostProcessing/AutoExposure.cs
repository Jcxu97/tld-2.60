using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(AutoExposureRenderer), "Unity/Auto Exposure", true)]
[Token(Token = "0x2000C87")]
public sealed class AutoExposure : PostProcessEffectSettings
{
	[MinMax(1f, 99f)]
	[DisplayName("Filtering (%)")]
	[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
	[Token(Token = "0x4007DE2")]
	[FieldOffset(Offset = "0x30")]
	public Vector2Parameter filtering;

	[Range(-9f, 9f)]
	[DisplayName("Minimum (EV)")]
	[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
	[Token(Token = "0x4007DE3")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter minLuminance;

	[Range(-9f, 9f)]
	[DisplayName("Maximum (EV)")]
	[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
	[Token(Token = "0x4007DE4")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter maxLuminance;

	[Min(0f)]
	[DisplayName("Exposure Compensation")]
	[Tooltip("Use this to scale the global exposure of the scene.")]
	[Token(Token = "0x4007DE5")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter keyValue;

	[DisplayName("Type")]
	[Tooltip("Use \"Progressive\" if you want auto exposure to be animated. Use \"Fixed\" otherwise.")]
	[Token(Token = "0x4007DE6")]
	[FieldOffset(Offset = "0x50")]
	public EyeAdaptationParameter eyeAdaptation;

	[Min(0f)]
	[Tooltip("Adaptation speed from a dark to a light environment.")]
	[Token(Token = "0x4007DE7")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter speedUp;

	[Min(0f)]
	[Tooltip("Adaptation speed from a light to a dark environment.")]
	[Token(Token = "0x4007DE8")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter speedDown;

	[Token(Token = "0x6006497")]
	[Address(RVA = "0xFE9650", Offset = "0xFE8450", Length = "0x1B5")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6006498")]
	[Address(RVA = "0xFE9810", Offset = "0xFE8610", Length = "0x464")]
	public AutoExposure()
	{
	}
}
