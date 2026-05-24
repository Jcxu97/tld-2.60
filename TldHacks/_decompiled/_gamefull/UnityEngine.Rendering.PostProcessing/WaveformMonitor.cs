using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CC2")]
public sealed class WaveformMonitor : Monitor
{
	[Token(Token = "0x4007F40")]
	[FieldOffset(Offset = "0x20")]
	public float exposure;

	[Token(Token = "0x4007F41")]
	[FieldOffset(Offset = "0x24")]
	public int height;

	[Token(Token = "0x4007F42")]
	[FieldOffset(Offset = "0x28")]
	private ComputeBuffer m_Data;

	[Token(Token = "0x4007F43")]
	private const int k_ThreadGroupSize = 256;

	[Token(Token = "0x4007F44")]
	private const int k_ThreadGroupSizeX = 16;

	[Token(Token = "0x4007F45")]
	private const int k_ThreadGroupSizeY = 16;

	[Token(Token = "0x600653B")]
	[Address(RVA = "0x100F800", Offset = "0x100E600", Length = "0xBC")]
	internal override void OnDisable()
	{
	}

	[Token(Token = "0x600653C")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	internal override bool NeedsHalfRes()
	{
		return false;
	}

	[Token(Token = "0x600653D")]
	[Address(RVA = "0x1010420", Offset = "0x100F220", Length = "0xF2")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x600653E")]
	[Address(RVA = "0x1010520", Offset = "0x100F320", Length = "0xCC4")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600653F")]
	[Address(RVA = "0x10111F0", Offset = "0x100FFF0", Length = "0xF")]
	public WaveformMonitor()
	{
	}
}
