using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLProArtefactsRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Artefacts Effect", false)]
[Token(Token = "0x2000AA3")]
public sealed class RLProArtefacts : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip("Brightness threshold of input.")]
	[Token(Token = "0x4006876")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter cutOff;

	[Range(0f, 3f)]
	[Tooltip("Amplifies the input amount after cutoff.")]
	[Token(Token = "0x4006877")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter amount;

	[Range(0f, 1f)]
	[Tooltip("Value represents how fast trail fades.")]
	[Token(Token = "0x4006878")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter fade;

	[Tooltip("Artefacts color.")]
	[Token(Token = "0x4006879")]
	[FieldOffset(Offset = "0x48")]
	public ColorParameter color;

	[Tooltip("Render Artefacts only.")]
	[Token(Token = "0x400687A")]
	[FieldOffset(Offset = "0x50")]
	public BoolParameter debugArtefacts;

	[Token(Token = "0x6005C57")]
	[Address(RVA = "0xF3DDB0", Offset = "0xF3CBB0", Length = "0x335")]
	public RLProArtefacts()
	{
	}
}
