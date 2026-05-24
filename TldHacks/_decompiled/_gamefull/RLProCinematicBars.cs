using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(CinematicBars_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Cinematic Bars", false)]
[Token(Token = "0x2000AAD")]
public sealed class RLProCinematicBars : PostProcessEffectSettings
{
	[Range(0.5f, 0.01f)]
	[Tooltip(null)]
	[Token(Token = "0x400689A")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter amount;

	[Range(0f, 1f)]
	[Tooltip("Intensity of noise texture.")]
	[Token(Token = "0x400689B")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter fade;

	[Token(Token = "0x6005C68")]
	[Address(RVA = "0xF41FA0", Offset = "0xF40DA0", Length = "0x174")]
	public RLProCinematicBars()
	{
	}
}
