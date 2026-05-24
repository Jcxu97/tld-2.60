using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_JitterRenderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Jitter Effect", false)]
[Token(Token = "0x2000AC2")]
public sealed class RLProJitter : PostProcessEffectSettings
{
	[Tooltip("Enable Twitch on X axes.")]
	[Token(Token = "0x40068D6")]
	[FieldOffset(Offset = "0x30")]
	public BoolParameter twitchHorizontal;

	[Range(0f, 5f)]
	[Tooltip("Twitch frequency on X axes.")]
	[Token(Token = "0x40068D7")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter horizontalFreq;

	[Space]
	[Tooltip("Enable Twitch on Y axes.")]
	[Token(Token = "0x40068D8")]
	[FieldOffset(Offset = "0x40")]
	public BoolParameter twitchVertical;

	[Range(0f, 5f)]
	[Tooltip("Twitch frequency on Y axes.")]
	[Token(Token = "0x40068D9")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter verticalFreq;

	[Range(0f, 25f)]
	[Tooltip("Twitch interval on Y axes.")]
	[Token(Token = "0x40068DA")]
	[FieldOffset(Offset = "0x50")]
	public FloatParameter twitchVerticalInterval;

	[Space]
	[Tooltip("enable stretch.")]
	[Token(Token = "0x40068DB")]
	[FieldOffset(Offset = "0x58")]
	public BoolParameter stretch;

	[Tooltip("Stretch resolution.")]
	[Token(Token = "0x40068DC")]
	[FieldOffset(Offset = "0x60")]
	public FloatParameter stretchResolution;

	[Space]
	[Tooltip("Enable Horizontal Interlacing.")]
	[Token(Token = "0x40068DD")]
	[FieldOffset(Offset = "0x68")]
	public BoolParameter jitterHorizontal;

	[Range(0f, 5f)]
	[Tooltip("Amount of horizontal interlacing.")]
	[Token(Token = "0x40068DE")]
	[FieldOffset(Offset = "0x70")]
	public FloatParameter jitterHorizontalAmount;

	[Space]
	[Tooltip("Shake Vertical.")]
	[Token(Token = "0x40068DF")]
	[FieldOffset(Offset = "0x78")]
	public BoolParameter jitterVertical;

	[Range(0f, 15f)]
	[Tooltip("Amount of shake.")]
	[Token(Token = "0x40068E0")]
	[FieldOffset(Offset = "0x80")]
	public FloatParameter jitterVerticalAmount;

	[Range(0f, 15f)]
	[Tooltip("Speed of vertical shake. ")]
	[Token(Token = "0x40068E1")]
	[FieldOffset(Offset = "0x88")]
	public FloatParameter jitterVerticalSpeed;

	[Space]
	[Tooltip("Time.unscaledTime .")]
	[Token(Token = "0x40068E2")]
	[FieldOffset(Offset = "0x90")]
	public BoolParameter unscaledTime;

	[Token(Token = "0x6005C8E")]
	[Address(RVA = "0xF49260", Offset = "0xF48060", Length = "0x764")]
	public RLProJitter()
	{
	}
}
