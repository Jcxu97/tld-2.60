using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_Warp_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/Warp", false)]
[Token(Token = "0x2000ADD")]
public sealed class RLProWarp : PostProcessEffectSettings
{
	[Range(0f, 1f)]
	[Tooltip("Dark areas adjustment.")]
	[Token(Token = "0x4006944")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter fade;

	[Tooltip("Warp mode.")]
	[Token(Token = "0x4006945")]
	[FieldOffset(Offset = "0x38")]
	public WarpModeParameter warpMode;

	[Tooltip("Warp picture.")]
	[Token(Token = "0x4006946")]
	[FieldOffset(Offset = "0x40")]
	public Vector2Parameter warp;

	[Token(Token = "0x4006947")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter scale;

	[Token(Token = "0x6005CB7")]
	[Address(RVA = "0xF54230", Offset = "0xF53030", Length = "0x2B4")]
	public RLProWarp()
	{
	}
}
