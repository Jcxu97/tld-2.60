using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_Phosphor_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Phosphor", false)]
[Token(Token = "0x2000ACC")]
public sealed class RLProPhosphor : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip("fade.")]
	[Token(Token = "0x4006906")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter fade;

	[Range(0f, 20f)]
	[Tooltip("width.")]
	[Token(Token = "0x4006907")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter width;

	[Range(0f, 1f)]
	[Tooltip("amount.")]
	[Token(Token = "0x4006908")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter amount;

	[Token(Token = "0x6005C9F")]
	[Address(RVA = "0xF4DF70", Offset = "0xF4CD70", Length = "0x204")]
	public RLProPhosphor()
	{
	}
}
