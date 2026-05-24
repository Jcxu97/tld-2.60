using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(RLPRO_SRP_LowRes_Renderer), PostProcessEvent.BeforeStack, "Retro Look Pro/LowRes", false)]
[Token(Token = "0x2000AC4")]
public sealed class RLProLowRes : PostProcessEffectSettings
{
	[Range(1f, 20f)]
	[Tooltip("Dark areas adjustment.")]
	[Token(Token = "0x40068E6")]
	[FieldOffset(Offset = "0x30")]
	public IntParameter pixelSize;

	[Token(Token = "0x6005C92")]
	[Address(RVA = "0xF4A5E0", Offset = "0xF493E0", Length = "0xC5")]
	public RLProLowRes()
	{
	}
}
