using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000CA2")]
internal sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion>
{
	[Token(Token = "0x60064D9")]
	[Address(RVA = "0xFFD7F0", Offset = "0xFFC5F0", Length = "0x3EE")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064DA")]
	[Address(RVA = "0xFFDBE0", Offset = "0xFFC9E0", Length = "0x3E")]
	public LensDistortionRenderer()
	{
	}
}
