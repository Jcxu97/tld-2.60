using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AA2")]
public sealed class RLPRO_SRP_AnalogTVNoise_Renderer : PostProcessEffectRenderer<RLProAnalogTVNoise>
{
	[Token(Token = "0x4006875")]
	[FieldOffset(Offset = "0x20")]
	private float TimeX;

	[Token(Token = "0x6005C55")]
	[Address(RVA = "0xF3D1E0", Offset = "0xF3BFE0", Length = "0xB82")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C56")]
	[Address(RVA = "0xF3DD70", Offset = "0xF3CB70", Length = "0x3E")]
	public RLPRO_SRP_AnalogTVNoise_Renderer()
	{
	}
}
