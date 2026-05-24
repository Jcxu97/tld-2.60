using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_NoiseRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Noise", false)]
[Token(Token = "0x2000AC8")]
public sealed class RLProNoise : PostProcessEffectSettings
{
	[DisplayName("Resolution")]
	[Tooltip(".")]
	[Token(Token = "0x40068EB")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter stretchResolution;

	[DisplayName("Vertical Resolution")]
	[Tooltip(".")]
	[Token(Token = "0x40068EC")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter n_NoiseLinesAmountY;

	[Space]
	[Space]
	[DisplayName("Granularity")]
	[Tooltip(".")]
	[Token(Token = "0x40068ED")]
	[FieldOffset(Offset = "0x40")]
	public BoolParameter f_Granularity;

	[DisplayName("Granularity Amount")]
	[Range(0f, 0.5f)]
	[Tooltip(null)]
	[Token(Token = "0x40068EE")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter f_GranularityAmount;

	[Space]
	[DisplayName("Tape Noise")]
	[Tooltip(".")]
	[Token(Token = "0x40068EF")]
	[FieldOffset(Offset = "0x50")]
	public BoolParameter f_TapeNoise;

	[DisplayName("Tape Noise processing value")]
	[Range(0f, 15f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F0")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter n_NoiseSignalProcessing;

	[DisplayName("Tape Noise Fade")]
	[Range(0f, 1.5f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F1")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter f_TapeNoiseAmount;

	[DisplayName("Tape Lines Amount")]
	[Range(0f, 1f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F2")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter tapeLinesAmount;

	[DisplayName("Tape Noise Amount")]
	[Range(0f, 1.5f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F3")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter f_TapeNoiseTH;

	[DisplayName("Tape Noise Speed")]
	[Range(-1.5f, 1.5f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F4")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter f_TapeNoiseSpeed;

	[Space]
	[DisplayName("Line Noise")]
	[Tooltip(" .")]
	[Token(Token = "0x40068F5")]
	[FieldOffset(Offset = "0x80")]
	public BoolParameter f_LineNoise;

	[DisplayName("Line Noise Amount")]
	[Range(0f, 15f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F6")]
	[FieldOffset(Offset = "0x88")]
	public FloatParameter f_LineNoiseAmount;

	[DisplayName("Line Noise Speed")]
	[Range(0f, 10f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F7")]
	[FieldOffset(Offset = "0x90")]
	public FloatParameter f_LineNoiseSpeed;

	[Space]
	[DisplayName("Signal Noise")]
	[Tooltip(" .")]
	[Token(Token = "0x40068F8")]
	[FieldOffset(Offset = "0x98")]
	public BoolParameter f_SignalNoise;

	[DisplayName("Signal Noise Power")]
	[Range(0.5f, 0.97f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068F9")]
	[FieldOffset(Offset = "0xA0")]
	public FloatParameter f_SignalNoisePower;

	[DisplayName("Signal Noise Amount")]
	[Range(0f, 2f)]
	[Tooltip(" .")]
	[Token(Token = "0x40068FA")]
	[FieldOffset(Offset = "0xA8")]
	public FloatParameter f_SignalNoiseAmount;

	[Space]
	[Token(Token = "0x40068FB")]
	[FieldOffset(Offset = "0xB0")]
	public BoolParameter mask;

	[Token(Token = "0x40068FC")]
	[FieldOffset(Offset = "0xB8")]
	public TextureParameter maskTexture;

	[Space]
	[Tooltip("Time.unscaledTime.")]
	[Token(Token = "0x40068FD")]
	[FieldOffset(Offset = "0xC0")]
	public BoolParameter unscaledTime;

	[Token(Token = "0x6005C98")]
	[Address(RVA = "0xF4B370", Offset = "0xF4A170", Length = "0xB39")]
	public RLProNoise()
	{
	}
}
