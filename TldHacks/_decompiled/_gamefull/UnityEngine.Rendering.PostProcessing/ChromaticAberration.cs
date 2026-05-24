using System;
using Cpp2ILInjected;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(ChromaticAberrationRenderer), "Unity/Chromatic Aberration", true)]
[Token(Token = "0x2000C8D")]
public sealed class ChromaticAberration : PostProcessEffectSettings
{
	[Tooltip("Shifts the hue of chromatic aberrations.")]
	[Token(Token = "0x4007E06")]
	[FieldOffset(Offset = "0x30")]
	public TextureParameter spectralLut;

	[Range(0f, 1f)]
	[Tooltip("Amount of tangential distortion.")]
	[Token(Token = "0x4007E07")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter intensity;

	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	[Token(Token = "0x4007E08")]
	[FieldOffset(Offset = "0x40")]
	public BoolParameter fastMode;

	[Token(Token = "0x60064A2")]
	[Address(RVA = "0xFED3A0", Offset = "0xFEC1A0", Length = "0x3B")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064A3")]
	[Address(RVA = "0xFED3E0", Offset = "0xFEC1E0", Length = "0x24A")]
	public ChromaticAberration()
	{
	}
}
