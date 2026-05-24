using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000CA0")]
internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
{
	[Token(Token = "0x4007EA3")]
	[FieldOffset(Offset = "0x20")]
	private RenderTexture m_GrainLookupRT;

	[Token(Token = "0x4007EA4")]
	private const int k_SampleCount = 1024;

	[Token(Token = "0x4007EA5")]
	[FieldOffset(Offset = "0x28")]
	private int m_SampleIndex;

	[Token(Token = "0x60064D3")]
	[Address(RVA = "0xFFC760", Offset = "0xFFB560", Length = "0xABA")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064D4")]
	[Address(RVA = "0xFFD220", Offset = "0xFFC020", Length = "0x50")]
	private RenderTextureFormat GetLookupFormat()
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x60064D5")]
	[Address(RVA = "0xFFD270", Offset = "0xFFC070", Length = "0xB5")]
	public override void Release()
	{
	}

	[Token(Token = "0x60064D6")]
	[Address(RVA = "0xFFD330", Offset = "0xFFC130", Length = "0x3E")]
	public GrainRenderer()
	{
	}
}
