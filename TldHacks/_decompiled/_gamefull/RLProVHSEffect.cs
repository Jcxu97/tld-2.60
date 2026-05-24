using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_VHSEffect_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/VHS Effect", false)]
[Token(Token = "0x2000AD9")]
public sealed class RLProVHSEffect : PostProcessEffectSettings
{
	[Range(0f, 50f)]
	[Tooltip("Color Offset.")]
	[Token(Token = "0x4006928")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter colorOffset;

	[Range(-3f, 3f)]
	[Tooltip("Color Offset Angle.")]
	[Token(Token = "0x4006929")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter colorOffsetAngle;

	[Space]
	[Range(0f, 100f)]
	[Tooltip("Vertical twitch frequency.")]
	[Token(Token = "0x400692A")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter verticalOffsetFrequency;

	[Range(0f, 1f)]
	[Tooltip("Amount of vertical twitch. ")]
	[Token(Token = "0x400692B")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter verticalOffset;

	[Range(3500f, 1f)]
	[Tooltip("Amount of horizontal distortion.")]
	[Token(Token = "0x400692C")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter offsetDistortion;

	[Space]
	[Tooltip("Noise texture.")]
	[Token(Token = "0x400692D")]
	[FieldOffset(Offset = "0x58")]
	public TextureParameter noiseTexture;

	[Token(Token = "0x400692E")]
	[FieldOffset(Offset = "0x60")]
	public BlendModeParameter blendMode;

	[Token(Token = "0x400692F")]
	[FieldOffset(Offset = "0x68")]
	public Vector2Parameter tile;

	[Space]
	[Range(0f, 1f)]
	[Tooltip("Intensity of noise texture.")]
	[Token(Token = "0x4006930")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter _textureIntensity;

	[Space]
	[Token(Token = "0x4006931")]
	[FieldOffset(Offset = "0x78")]
	public BoolParameter smoothCut;

	[Range(0f, 30f)]
	[Tooltip(" blur iterations.")]
	[Token(Token = "0x4006932")]
	[FieldOffset(Offset = "0x80")]
	public IntParameter iterations;

	[Range(0f, 0.5f)]
	[Tooltip("smooth Size.")]
	[Token(Token = "0x4006933")]
	[FieldOffset(Offset = "0x88")]
	public FloatParameter smoothSize;

	[Range(0f, 0.5f)]
	[Tooltip("deviation.")]
	[Token(Token = "0x4006934")]
	[FieldOffset(Offset = "0x90")]
	public FloatParameter deviation;

	[Space]
	[Range(-1f, 1f)]
	[Tooltip("Cut off.")]
	[Token(Token = "0x4006935")]
	[FieldOffset(Offset = "0x98")]
	public FloatParameter _textureCutOff;

	[Space]
	[Range(0.5f, 0.01f)]
	[Tooltip("black bars")]
	[Token(Token = "0x4006936")]
	[FieldOffset(Offset = "0xA0")]
	public FloatParameter stripes;

	[Space]
	[Token(Token = "0x4006937")]
	[FieldOffset(Offset = "0xA8")]
	public BoolParameter unscaledTime;

	[Token(Token = "0x6005CB1")]
	[Address(RVA = "0xF51800", Offset = "0xF50600", Length = "0x974")]
	public RLProVHSEffect()
	{
	}
}
