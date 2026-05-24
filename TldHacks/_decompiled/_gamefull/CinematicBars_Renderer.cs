using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AAE")]
public sealed class CinematicBars_Renderer : PostProcessEffectRenderer<RLProCinematicBars>
{
	[Token(Token = "0x6005C69")]
	[Address(RVA = "0xF42120", Offset = "0xF40F20", Length = "0x3CF")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C6A")]
	[Address(RVA = "0xF424F0", Offset = "0xF412F0", Length = "0x3E")]
	public CinematicBars_Renderer()
	{
	}
}
