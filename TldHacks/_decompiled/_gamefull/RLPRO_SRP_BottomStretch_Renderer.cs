using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AAC")]
public sealed class RLPRO_SRP_BottomStretch_Renderer : PostProcessEffectRenderer<RLProBottomStretch>
{
	[Token(Token = "0x4006899")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005C66")]
	[Address(RVA = "0xF41880", Offset = "0xF40680", Length = "0x6D6")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C67")]
	[Address(RVA = "0xF41F60", Offset = "0xF40D60", Length = "0x3E")]
	public RLPRO_SRP_BottomStretch_Renderer()
	{
	}
}
