using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ADA")]
public sealed class RLPRO_SRP_VHSEffect_Renderer : PostProcessEffectRenderer<RLProVHSEffect>
{
	[Token(Token = "0x4006938")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005CB2")]
	[Address(RVA = "0xF52180", Offset = "0xF50F80", Length = "0x1188")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CB3")]
	[Address(RVA = "0xF53310", Offset = "0xF52110", Length = "0x3E")]
	public RLPRO_SRP_VHSEffect_Renderer()
	{
	}
}
