using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AC7")]
public sealed class RLPRO_SRP_NegativeRenderer : PostProcessEffectRenderer<RLProNegative>
{
	[Token(Token = "0x40068EA")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x6005C96")]
	[Address(RVA = "0xF4ADA0", Offset = "0xF49BA0", Length = "0x58F")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C97")]
	[Address(RVA = "0xF4B330", Offset = "0xF4A130", Length = "0x3E")]
	public RLPRO_SRP_NegativeRenderer()
	{
	}
}
