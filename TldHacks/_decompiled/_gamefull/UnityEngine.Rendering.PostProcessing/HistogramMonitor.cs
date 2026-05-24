using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CBC")]
public sealed class HistogramMonitor : Monitor
{
	[Token(Token = "0x2000CBD")]
	public enum Channel
	{
		[Token(Token = "0x4007F2D")]
		Red,
		[Token(Token = "0x4007F2E")]
		Green,
		[Token(Token = "0x4007F2F")]
		Blue,
		[Token(Token = "0x4007F30")]
		Master
	}

	[Token(Token = "0x4007F25")]
	[FieldOffset(Offset = "0x20")]
	public int width;

	[Token(Token = "0x4007F26")]
	[FieldOffset(Offset = "0x24")]
	public int height;

	[Token(Token = "0x4007F27")]
	[FieldOffset(Offset = "0x28")]
	public Channel channel;

	[Token(Token = "0x4007F28")]
	[FieldOffset(Offset = "0x30")]
	private ComputeBuffer m_Data;

	[Token(Token = "0x4007F29")]
	private const int k_NumBins = 256;

	[Token(Token = "0x4007F2A")]
	private const int k_ThreadGroupSizeX = 16;

	[Token(Token = "0x4007F2B")]
	private const int k_ThreadGroupSizeY = 16;

	[Token(Token = "0x6006524")]
	[Address(RVA = "0x100DFE0", Offset = "0x100CDE0", Length = "0xBC")]
	internal override void OnDisable()
	{
	}

	[Token(Token = "0x6006525")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	internal override bool NeedsHalfRes()
	{
		return false;
	}

	[Token(Token = "0x6006526")]
	[Address(RVA = "0x100E0A0", Offset = "0x100CEA0", Length = "0xF2")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6006527")]
	[Address(RVA = "0x100E1A0", Offset = "0x100CFA0", Length = "0x939")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006528")]
	[Address(RVA = "0x100EAE0", Offset = "0x100D8E0", Length = "0x16")]
	public HistogramMonitor()
	{
	}
}
