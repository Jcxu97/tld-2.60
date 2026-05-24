using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_BottomNoise_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Bottom Noise Effect", false)]
[Token(Token = "0x2000AA9")]
public sealed class RLProBottomNoise : PostProcessEffectSettings
{
	[Range(0.01f, 0.5f)]
	[Tooltip("Height of Noise.")]
	[Token(Token = "0x400688F")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter height;

	[Range(0f, 3f)]
	[Tooltip("Noise intensity.")]
	[Token(Token = "0x4006890")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter intencity;

	[Tooltip("Noise texture.")]
	[Token(Token = "0x4006891")]
	[FieldOffset(Offset = "0x40")]
	public TextureParameter noiseTexture;

	[Tooltip("Noise tiling.")]
	[Token(Token = "0x4006892")]
	[FieldOffset(Offset = "0x48")]
	public Vector2Parameter tile;

	[Token(Token = "0x6005C62")]
	[Address(RVA = "0xF40980", Offset = "0xF3F780", Length = "0x2E9")]
	public RLProBottomNoise()
	{
	}
}
