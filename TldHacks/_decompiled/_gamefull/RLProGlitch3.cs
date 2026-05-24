using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(Glitch3Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Glitch3", false)]
[Token(Token = "0x2000AC0")]
public sealed class RLProGlitch3 : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip("Speed")]
	[Token(Token = "0x40068D0")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter speed;

	[Range(0f, 5f)]
	[Tooltip("block size (higher value = smaller blocks).")]
	[Token(Token = "0x40068D1")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter density;

	[Range(0f, 5f)]
	[Tooltip("glitch offset.(color shift)")]
	[Token(Token = "0x40068D2")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter maxDisplace;

	[Space]
	[Token(Token = "0x40068D3")]
	[FieldOffset(Offset = "0x48")]
	public BoolParameter mask;

	[Token(Token = "0x40068D4")]
	[FieldOffset(Offset = "0x50")]
	public TextureParameter maskTexture;

	[Token(Token = "0x6005C8B")]
	[Address(RVA = "0xF486E0", Offset = "0xF474E0", Length = "0x369")]
	public RLProGlitch3()
	{
	}
}
