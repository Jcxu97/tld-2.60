using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AD4")]
public sealed class RLPRO_SRP_TVEffect_Renderer : PostProcessEffectRenderer<RLProTVEffect>
{
	[Token(Token = "0x6005CAA")]
	[Address(RVA = "0xF502A0", Offset = "0xF4F0A0", Length = "0x873")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CAB")]
	[Address(RVA = "0xF50B20", Offset = "0xF4F920", Length = "0x3E")]
	public RLPRO_SRP_TVEffect_Renderer()
	{
	}
}
