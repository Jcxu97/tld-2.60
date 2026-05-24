using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ACB")]
public sealed class RLPRO_SRP_OldFilmRenderer : PostProcessEffectRenderer<RLProOldFilm>
{
	[Token(Token = "0x4006905")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005C9D")]
	[Address(RVA = "0xF4D840", Offset = "0xF4C640", Length = "0x6E0")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C9E")]
	[Address(RVA = "0xF4DF30", Offset = "0xF4CD30", Length = "0x3E")]
	public RLPRO_SRP_OldFilmRenderer()
	{
	}
}
