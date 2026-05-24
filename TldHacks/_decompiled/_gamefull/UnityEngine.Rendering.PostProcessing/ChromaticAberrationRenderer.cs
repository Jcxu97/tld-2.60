using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000C8E")]
internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
{
	[Token(Token = "0x4007E09")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D m_InternalSpectralLut;

	[Token(Token = "0x60064A4")]
	[Address(RVA = "0xFED630", Offset = "0xFEC430", Length = "0x545")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064A5")]
	[Address(RVA = "0xFEDB80", Offset = "0xFEC980", Length = "0xAC")]
	public override void Release()
	{
	}

	[Token(Token = "0x60064A6")]
	[Address(RVA = "0xFEDC30", Offset = "0xFECA30", Length = "0x3E")]
	public ChromaticAberrationRenderer()
	{
	}
}
