using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(ScreenSpaceReflectionsRenderer), "Unity/Screen-space reflections", true)]
[Token(Token = "0x2000CAF")]
public sealed class ScreenSpaceReflections : PostProcessEffectSettings
{
	[Tooltip("Choose a quality preset, or use \"Custom\" to create your own custom preset. Don't use a preset higher than \"Medium\" if you desire good performance on consoles.")]
	[Token(Token = "0x4007EEC")]
	[FieldOffset(Offset = "0x30")]
	public ScreenSpaceReflectionPresetParameter preset;

	[Range(0f, 256f)]
	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	[Token(Token = "0x4007EED")]
	[FieldOffset(Offset = "0x38")]
	public IntParameter maximumIterationCount;

	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	[Token(Token = "0x4007EEE")]
	[FieldOffset(Offset = "0x40")]
	public ScreenSpaceReflectionResolutionParameter resolution;

	[Range(1f, 64f)]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	[Token(Token = "0x4007EEF")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter thickness;

	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	[Token(Token = "0x4007EF0")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter maximumMarchDistance;

	[Range(0f, 1f)]
	[Tooltip("Fades reflections close to the near planes.")]
	[Token(Token = "0x4007EF1")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter distanceFade;

	[Range(0f, 1f)]
	[Tooltip("Fades reflections close to the screen edges.")]
	[Token(Token = "0x4007EF2")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter vignette;

	[Token(Token = "0x6006503")]
	[Address(RVA = "0x10084A0", Offset = "0x10072A0", Length = "0x1A4")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6006504")]
	[Address(RVA = "0x1008650", Offset = "0x1007450", Length = "0x474")]
	public ScreenSpaceReflections()
	{
	}
}
