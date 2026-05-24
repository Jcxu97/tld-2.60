using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AA4")]
public sealed class RLProArtefactsRenderer : PostProcessEffectRenderer<RLProArtefacts>
{
	[Token(Token = "0x6005C58")]
	[Address(RVA = "0xF3E0F0", Offset = "0xF3CEF0", Length = "0x10CD")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C59")]
	[Address(RVA = "0xF3F1C0", Offset = "0xF3DFC0", Length = "0x3F")]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[Token(Token = "0x6005C5A")]
	[Address(RVA = "0xF3F200", Offset = "0xF3E000", Length = "0x3E")]
	public RLProArtefactsRenderer()
	{
	}
}
