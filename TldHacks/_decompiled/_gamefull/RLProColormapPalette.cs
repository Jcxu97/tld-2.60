using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_ColormapPaletteRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Colormap Palette", false)]
[Token(Token = "0x2000AB2")]
public sealed class RLProColormapPalette : PostProcessEffectSettings
{
	[Token(Token = "0x400689C")]
	[FieldOffset(Offset = "0x30")]
	public resModeParameter resolutionMode;

	[Range(1f, 255f)]
	[Tooltip("Change pixel size if using resolutionModeIndex - 1, in this case resolution calculates automatically. ")]
	[Token(Token = "0x400689D")]
	[FieldOffset(Offset = "0x38")]
	public IntParameter pixelSize;

	[Tooltip("Change Resolution manually if using resolutionModeIndex - 0.")]
	[Token(Token = "0x400689E")]
	[FieldOffset(Offset = "0x40")]
	public Vector2IntParameter resolution;

	[Range(0f, 1f)]
	[Tooltip("Opacity.")]
	[Token(Token = "0x400689F")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter opacity;

	[Range(0f, 1f)]
	[Tooltip("Dithering effect.")]
	[Token(Token = "0x40068A0")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter dither;

	[Token(Token = "0x40068A1")]
	[FieldOffset(Offset = "0x58")]
	public preLParameter presetsList;

	[Token(Token = "0x40068A2")]
	[FieldOffset(Offset = "0x60")]
	public IntParameter presetIndex;

	[Token(Token = "0x40068A3")]
	[FieldOffset(Offset = "0x68")]
	public TextureParameter bluenoise;

	[Token(Token = "0x6005C6E")]
	[Address(RVA = "0xF42650", Offset = "0xF41450", Length = "0x554")]
	public RLProColormapPalette()
	{
	}
}
