using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(Glitch1Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Glitch1", false)]
[Token(Token = "0x2000ABC")]
public sealed class RLProGlitch1 : PostProcessEffectSettings
{
	[Range(0f, 2f)]
	[Tooltip("Effect amount.")]
	[Token(Token = "0x40068BB")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter amount;

	[Space]
	[Range(0f, 4f)]
	[Tooltip("Effect stretch.")]
	[Token(Token = "0x40068BC")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter stretch;

	[Range(0f, 1f)]
	[Tooltip("Effect speed.")]
	[Token(Token = "0x40068BD")]
	[FieldOffset(Offset = "0x40")]
	public FloatParameter speed;

	[Range(0f, 1f)]
	[Tooltip("Effect Fade.")]
	[Token(Token = "0x40068BE")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter fade;

	[Space]
	[Range(-1f, 2f)]
	[Tooltip("Red color offset  muliplier.")]
	[Token(Token = "0x40068BF")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter rMultiplier;

	[Range(-1f, 2f)]
	[Tooltip("Green color offset  muliplier.")]
	[Token(Token = "0x40068C0")]
	[FieldOffset(Offset = "0x58")]
	public FloatParameter gMultiplier;

	[Range(-1f, 2f)]
	[Tooltip("Blue color offset  muliplier.")]
	[Token(Token = "0x40068C1")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter bMultiplier;

	[Space]
	[Range(-2f, 200f)]
	[Tooltip("X parameter of random value on noise texture.")]
	[Token(Token = "0x40068C2")]
	[FieldOffset(Offset = "0x68")]
	public FloatParameter x;

	[Range(-2f, 10002f)]
	[Tooltip("Y parameter of random value on noise texture.")]
	[Token(Token = "0x40068C3")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter y;

	[Range(-2f, 200f)]
	[Tooltip("Angle Y parameter of random value on noise texture.")]
	[Token(Token = "0x40068C4")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter angleY;

	[Space]
	[Token(Token = "0x40068C5")]
	[FieldOffset(Offset = "0x80")]
	public BoolParameter mask;

	[Token(Token = "0x40068C6")]
	[FieldOffset(Offset = "0x88")]
	public TextureParameter maskTexture;

	[Token(Token = "0x6005C82")]
	[Address(RVA = "0xF45C80", Offset = "0xF44A80", Length = "0x769")]
	public RLProGlitch1()
	{
	}
}
