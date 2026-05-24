using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ABD")]
public sealed class Glitch1Renderer : PostProcessEffectRenderer<RLProGlitch1>
{
	[Token(Token = "0x40068C7")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005C83")]
	[Address(RVA = "0xF463F0", Offset = "0xF451F0", Length = "0xCB7")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C84")]
	[Address(RVA = "0xF470B0", Offset = "0xF45EB0", Length = "0x3E")]
	public Glitch1Renderer()
	{
	}
}
