using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(GrainRenderer), "Unity/Grain", true)]
[Token(Token = "0x2000C9F")]
public sealed class Grain : PostProcessEffectSettings
{
	[Tooltip("Enable the use of colored grain.")]
	[Token(Token = "0x4007E9F")]
	[FieldOffset(Offset = "0x30")]
	public BoolParameter colored;

	[Range(0f, 1f)]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	[Token(Token = "0x4007EA0")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter intensity;

	[Range(0.3f, 3f)]
	[Tooltip("Grain particle size.")]
	[Token(Token = "0x4007EA1")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter size;

	[Range(0f, 1f)]
	[DisplayName("Luminance Contribution")]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	[Token(Token = "0x4007EA2")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter lumContrib;

	[Token(Token = "0x60064D1")]
	[Address(RVA = "0xFED3A0", Offset = "0xFEC1A0", Length = "0x3B")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064D2")]
	[Address(RVA = "0xFFC4C0", Offset = "0xFFB2C0", Length = "0x294")]
	public Grain()
	{
	}
}
