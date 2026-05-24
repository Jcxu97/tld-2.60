using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(Glitch2Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Glitch2", false)]
[Token(Token = "0x2000ABE")]
public sealed class RLProGlitch2 : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip(null)]
	[Token(Token = "0x40068C8")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter intencity;

	[Range(1f, 2f)]
	[Tooltip(".")]
	[Token(Token = "0x40068C9")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter resolutionMultiplier;

	[Range(0f, 1f)]
	[Tooltip(".")]
	[Token(Token = "0x40068CA")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter stretchMultiplier;

	[Token(Token = "0x6005C85")]
	[Address(RVA = "0xF470F0", Offset = "0xF45EF0", Length = "0x204")]
	public RLProGlitch2()
	{
	}
}
