using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_NTSC_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/NTSC", false)]
[Token(Token = "0x2000ADF")]
public sealed class RLPro_NTSC : PostProcessEffectSettings
{
	[Range(1f, 40f)]
	[Tooltip("Brightness.")]
	[Token(Token = "0x4006948")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter brightness;

	[Range(0.01f, 2f)]
	[Tooltip("Blur size.")]
	[Token(Token = "0x4006949")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter blur;

	[Range(0f, 10f)]
	[Tooltip("Floating lines speed")]
	[Token(Token = "0x400694A")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter lineSpeed;

	[Token(Token = "0x6005CBA")]
	[Address(RVA = "0xF54A40", Offset = "0xF53840", Length = "0x204")]
	public RLPro_NTSC()
	{
	}
}
