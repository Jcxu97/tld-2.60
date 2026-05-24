using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_AnalogTVNoise_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Analog TV Noise", false)]
[Token(Token = "0x2000AA1")]
public sealed class RLProAnalogTVNoise : PostProcessEffectSettings
{
	[Tooltip("Option enables static noise (without movement).")]
	[Token(Token = "0x400686B")]
	[FieldOffset(Offset = "0x30")]
	public BoolParameter staticNoise;

	[Tooltip("Horizontal/Vertical Noise lines.")]
	[Token(Token = "0x400686C")]
	[FieldOffset(Offset = "0x38")]
	public BoolParameter Horizontal;

	[Range(0f, 1f)]
	[Tooltip("Effect Fade.")]
	[Token(Token = "0x400686D")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter Fade;

	[Range(0f, 60f)]
	[Tooltip("Noise bar width.")]
	[Token(Token = "0x400686E")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter barHeight;

	[Range(0f, 60f)]
	[Tooltip("Noise tiling.")]
	[Token(Token = "0x400686F")]
	[FieldOffset(Offset = "0x50")]
	public Vector2Parameter tile;

	[Range(0f, 1f)]
	[Tooltip("Noise texture angle.")]
	[Token(Token = "0x4006870")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter textureAngle;

	[Range(0f, 100f)]
	[Tooltip("Noise bar edges cutoff.")]
	[Token(Token = "0x4006871")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter edgeCutOff;

	[Range(-1f, 1f)]
	[Tooltip("Noise cutoff.")]
	[Token(Token = "0x4006872")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter CutOff;

	[Range(-10f, 100f)]
	[Tooltip("Noise bars speed.")]
	[Token(Token = "0x4006873")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter barSpeed;

	[Tooltip("Noise texture.")]
	[Token(Token = "0x4006874")]
	[FieldOffset(Offset = "0x78")]
	public TextureParameter texture;

	[Token(Token = "0x6005C54")]
	[Address(RVA = "0xF3CBE0", Offset = "0xF3B9E0", Length = "0x5F4")]
	public RLProAnalogTVNoise()
	{
	}
}
