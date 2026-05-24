using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AD1")]
public sealed class RLPRO_SRP_PulsatingVignetteRenderer : PostProcessEffectRenderer<RLProPulsatingVignette>
{
	[Token(Token = "0x4006915")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005CA6")]
	[Address(RVA = "0xF4F7C0", Offset = "0xF4E5C0", Length = "0x4B4")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CA7")]
	[Address(RVA = "0xF4FC80", Offset = "0xF4EA80", Length = "0x3E")]
	public RLPRO_SRP_PulsatingVignetteRenderer()
	{
	}
}
