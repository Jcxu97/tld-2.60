using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000CBB")]
internal sealed class VignetteRenderer : PostProcessEffectRenderer<Vignette>
{
	[Token(Token = "0x6006522")]
	[Address(RVA = "0x100D9D0", Offset = "0x100C7D0", Length = "0x5CE")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006523")]
	[Address(RVA = "0x100DFA0", Offset = "0x100CDA0", Length = "0x3E")]
	public VignetteRenderer()
	{
	}
}
