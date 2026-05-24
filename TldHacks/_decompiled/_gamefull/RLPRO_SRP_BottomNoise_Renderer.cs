using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AAA")]
public sealed class RLPRO_SRP_BottomNoise_Renderer : PostProcessEffectRenderer<RLProBottomNoise>
{
	[Token(Token = "0x4006893")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005C63")]
	[Address(RVA = "0xF40C70", Offset = "0xF3FA70", Length = "0x8A5")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C64")]
	[Address(RVA = "0xF41520", Offset = "0xF40320", Length = "0x3E")]
	public RLPRO_SRP_BottomNoise_Renderer()
	{
	}
}
