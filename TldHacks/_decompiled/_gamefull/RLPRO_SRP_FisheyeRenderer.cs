using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ABB")]
public sealed class RLPRO_SRP_FisheyeRenderer : PostProcessEffectRenderer<RLProFisheye>
{
	[Token(Token = "0x6005C7F")]
	[Address(RVA = "0xF45510", Offset = "0xF44310", Length = "0x722")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C80")]
	[Address(RVA = "0xF3F1C0", Offset = "0xF3DFC0", Length = "0x3F")]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[Token(Token = "0x6005C81")]
	[Address(RVA = "0xF45C40", Offset = "0xF44A40", Length = "0x3E")]
	public RLPRO_SRP_FisheyeRenderer()
	{
	}
}
