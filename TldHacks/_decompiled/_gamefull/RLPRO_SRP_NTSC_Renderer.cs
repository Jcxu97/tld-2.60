using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AE0")]
public sealed class RLPRO_SRP_NTSC_Renderer : PostProcessEffectRenderer<RLPro_NTSC>
{
	[Token(Token = "0x400694B")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005CBB")]
	[Address(RVA = "0xF54C50", Offset = "0xF53A50", Length = "0x559")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CBC")]
	[Address(RVA = "0xF551B0", Offset = "0xF53FB0", Length = "0x3E")]
	public RLPRO_SRP_NTSC_Renderer()
	{
	}
}
