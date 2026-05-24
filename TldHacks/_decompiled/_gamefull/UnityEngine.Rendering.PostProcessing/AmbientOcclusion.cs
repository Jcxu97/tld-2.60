using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(AmbientOcclusionRenderer), "Unity/Ambient Occlusion", true)]
[Token(Token = "0x2000C82")]
public sealed class AmbientOcclusion : PostProcessEffectSettings
{
	[Tooltip("The ambient occlusion method to use. \"Multi Scale Volumetric Obscurance\" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	[Token(Token = "0x4007DD2")]
	[FieldOffset(Offset = "0x30")]
	public AmbientOcclusionModeParameter mode;

	[Range(0f, 4f)]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	[Token(Token = "0x4007DD3")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter intensity;

	[ColorUsage(false)]
	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	[Token(Token = "0x4007DD4")]
	[FieldOffset(Offset = "0x40")]
	public ColorParameter color;

	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	[Token(Token = "0x4007DD5")]
	[FieldOffset(Offset = "0x48")]
	public BoolParameter ambientOnly;

	[Range(-8f, 0f)]
	[Token(Token = "0x4007DD6")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter noiseFilterTolerance;

	[Range(-8f, -1f)]
	[Token(Token = "0x4007DD7")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter blurTolerance;

	[Range(-12f, -1f)]
	[Token(Token = "0x4007DD8")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter upsampleTolerance;

	[Range(0f, 10f)]
	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	[Token(Token = "0x4007DD9")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter thicknessModifier;

	[Range(0f, 0.001f)]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	[Token(Token = "0x4007DDA")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter zBias;

	[Range(0f, 1f)]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	[Token(Token = "0x4007DDB")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter directLightingStrength;

	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	[Token(Token = "0x4007DDC")]
	[FieldOffset(Offset = "0x80")]
	public FloatParameter radius;

	[Tooltip("The number of sample points. This affects both quality and performance. For \"Lowest\", \"Low\", and \"Medium\", passes are downsampled. For \"High\" and \"Ultra\", they are not and therefore you should only \"High\" and \"Ultra\" on high-end hardware.")]
	[Token(Token = "0x4007DDD")]
	[FieldOffset(Offset = "0x88")]
	public AmbientOcclusionQualityParameter quality;

	[Token(Token = "0x6006486")]
	[Address(RVA = "0xFE8530", Offset = "0xFE7330", Length = "0x3C0")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6006487")]
	[Address(RVA = "0xFE8900", Offset = "0xFE7700", Length = "0x744")]
	public AmbientOcclusion()
	{
	}
}
