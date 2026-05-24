using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ADE")]
public sealed class RLPRO_SRP_Warp_Renderer : PostProcessEffectRenderer<RLProWarp>
{
	[Token(Token = "0x6005CB8")]
	[Address(RVA = "0xF544F0", Offset = "0xF532F0", Length = "0x503")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CB9")]
	[Address(RVA = "0xF54A00", Offset = "0xF53800", Length = "0x3E")]
	public RLPRO_SRP_Warp_Renderer()
	{
	}
}
