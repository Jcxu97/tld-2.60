using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ACF")]
public sealed class RLPRO_SRP_PictureCorrectionRenderer : PostProcessEffectRenderer<RLProPictureCorrection>
{
	[Token(Token = "0x6005CA3")]
	[Address(RVA = "0xF4EEB0", Offset = "0xF4DCB0", Length = "0x745")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005CA4")]
	[Address(RVA = "0xF4F600", Offset = "0xF4E400", Length = "0x3E")]
	public RLPRO_SRP_PictureCorrectionRenderer()
	{
	}
}
