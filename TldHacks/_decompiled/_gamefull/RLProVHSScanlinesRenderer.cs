using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ADC")]
public sealed class RLProVHSScanlinesRenderer : PostProcessEffectRenderer<RLProVHSScanlines>
{
	[Token(Token = "0x4006942")]
	[FieldOffset(Offset = "0x20")]
	private int pass;

	[Token(Token = "0x4006943")]
	[FieldOffset(Offset = "0x24")]
	private float T;

	[Token(Token = "0x6005CB5")]
	[Address(RVA = "0xF53880", Offset = "0xF52680", Length = "0x96F")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CB6")]
	[Address(RVA = "0xF541F0", Offset = "0xF52FF0", Length = "0x3E")]
	public RLProVHSScanlinesRenderer()
	{
	}
}
