using System;
using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[PostProcess(typeof(UnsharpMaskRenderer), PostProcessEvent.BeforeStack, "Hinterland/Unsharp Mask", true)]
[Token(Token = "0x200040A")]
public sealed class UnsharpMask : PostProcessEffectSettings
{
	[Token(Token = "0x40024AD")]
	[FieldOffset(Offset = "0x30")]
	public FloatParameter intensity;

	[Token(Token = "0x40024AE")]
	[FieldOffset(Offset = "0x38")]
	public FloatParameter blurSpread;

	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0x7CB390", Offset = "0x7CA190", Length = "0x174")]
	public UnsharpMask()
	{
	}
}
