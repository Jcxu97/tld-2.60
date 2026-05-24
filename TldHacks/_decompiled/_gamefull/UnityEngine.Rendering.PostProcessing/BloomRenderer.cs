using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000C8A")]
internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
{
	[Token(Token = "0x2000C8B")]
	private enum Pass
	{
		[Token(Token = "0x4007DFB")]
		Prefilter13,
		[Token(Token = "0x4007DFC")]
		Prefilter4,
		[Token(Token = "0x4007DFD")]
		Downsample13,
		[Token(Token = "0x4007DFE")]
		Downsample4,
		[Token(Token = "0x4007DFF")]
		UpsampleTent,
		[Token(Token = "0x4007E00")]
		UpsampleBox,
		[Token(Token = "0x4007E01")]
		DebugOverlayThreshold,
		[Token(Token = "0x4007E02")]
		DebugOverlayTent,
		[Token(Token = "0x4007E03")]
		DebugOverlayBox
	}

	[Token(Token = "0x2000C8C")]
	private struct Level
	{
		[Token(Token = "0x4007E04")]
		[FieldOffset(Offset = "0x0")]
		internal int down;

		[Token(Token = "0x4007E05")]
		[FieldOffset(Offset = "0x4")]
		internal int up;
	}

	[Token(Token = "0x4007DF8")]
	[FieldOffset(Offset = "0x20")]
	private Level[] m_Pyramid;

	[Token(Token = "0x4007DF9")]
	private const int k_MaxPyramidSize = 16;

	[Token(Token = "0x600649F")]
	[Address(RVA = "0xFEBB10", Offset = "0xFEA910", Length = "0x241")]
	public override void Init()
	{
	}

	[Token(Token = "0x60064A0")]
	[Address(RVA = "0xFEBD60", Offset = "0xFEAB60", Length = "0x15F0")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064A1")]
	[Address(RVA = "0xFED360", Offset = "0xFEC160", Length = "0x3E")]
	public BloomRenderer()
	{
	}
}
