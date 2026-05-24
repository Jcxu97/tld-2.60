using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AD7")]
public sealed class RLProUltimateVignetteRenderer : PostProcessEffectRenderer<RLProUltimateVignette>
{
	[Token(Token = "0x4006927")]
	[FieldOffset(Offset = "0x20")]
	private float m_Horizontal;

	[Token(Token = "0x6005CAE")]
	[Address(RVA = "0xF510C0", Offset = "0xF4FEC0", Length = "0x6AD")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CAF")]
	[Address(RVA = "0xF51770", Offset = "0xF50570", Length = "0x3E")]
	public RLProUltimateVignetteRenderer()
	{
	}
}
