using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ACD")]
public sealed class RLPRO_SRP_Phosphor_Renderer : PostProcessEffectRenderer<RLProPhosphor>
{
	[Token(Token = "0x4006909")]
	[FieldOffset(Offset = "0x20")]
	private RenderTexture texTape;

	[Token(Token = "0x400690A")]
	[FieldOffset(Offset = "0x28")]
	private bool stop;

	[Token(Token = "0x400690B")]
	[FieldOffset(Offset = "0x2C")]
	private float T;

	[Token(Token = "0x6005CA0")]
	[Address(RVA = "0xF4E180", Offset = "0xF4CF80", Length = "0x89B")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CA1")]
	[Address(RVA = "0xF4EA20", Offset = "0xF4D820", Length = "0x3E")]
	public RLPRO_SRP_Phosphor_Renderer()
	{
	}
}
