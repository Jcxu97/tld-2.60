using System;
using Cpp2ILInjected;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(BloomRenderer), "Unity/Bloom", true)]
[Token(Token = "0x2000C89")]
public sealed class Bloom : PostProcessEffectSettings
{
	[Min(0f)]
	[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
	[Token(Token = "0x4007DEE")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter intensity;

	[Min(0f)]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	[Token(Token = "0x4007DEF")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter threshold;

	[Range(0f, 1f)]
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	[Token(Token = "0x4007DF0")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter softKnee;

	[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
	[Token(Token = "0x4007DF1")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter clamp;

	[Range(1f, 10f)]
	[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
	[Token(Token = "0x4007DF2")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter diffusion;

	[Range(-1f, 1f)]
	[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
	[Token(Token = "0x4007DF3")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter anamorphicRatio;

	[ColorUsage(false, true)]
	[Tooltip("Global tint of the bloom filter.")]
	[Token(Token = "0x4007DF4")]
	[FieldOffset(Offset = "0x60")]
	public ColorParameter color;

	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	[Token(Token = "0x4007DF5")]
	[FieldOffset(Offset = "0x68")]
	public BoolParameter fastMode;

	[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
	[DisplayName("Texture")]
	[Token(Token = "0x4007DF6")]
	[FieldOffset(Offset = "0x70")]
	public TextureParameter dirtTexture;

	[Min(0f)]
	[Tooltip("The intensity of the lens dirtiness.")]
	[DisplayName("Intensity")]
	[Token(Token = "0x4007DF7")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter dirtIntensity;

	[Token(Token = "0x600649D")]
	[Address(RVA = "0xFEB4A0", Offset = "0xFEA2A0", Length = "0x3B")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x600649E")]
	[Address(RVA = "0xFEB4E0", Offset = "0xFEA2E0", Length = "0x62E")]
	public Bloom()
	{
	}
}
