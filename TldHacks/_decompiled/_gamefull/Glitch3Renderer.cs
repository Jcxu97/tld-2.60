using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AC1")]
public sealed class Glitch3Renderer : PostProcessEffectRenderer<RLProGlitch3>
{
	[Token(Token = "0x40068D5")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005C8C")]
	[Address(RVA = "0xF48A50", Offset = "0xF47850", Length = "0x7C7")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C8D")]
	[Address(RVA = "0xF49220", Offset = "0xF48020", Length = "0x3E")]
	public Glitch3Renderer()
	{
	}
}
