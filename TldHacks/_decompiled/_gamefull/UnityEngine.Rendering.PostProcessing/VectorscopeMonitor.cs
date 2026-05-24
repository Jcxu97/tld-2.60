using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CC1")]
public sealed class VectorscopeMonitor : Monitor
{
	[Token(Token = "0x4007F3B")]
	[FieldOffset(Offset = "0x20")]
	public int size;

	[Token(Token = "0x4007F3C")]
	[FieldOffset(Offset = "0x24")]
	public float exposure;

	[Token(Token = "0x4007F3D")]
	[FieldOffset(Offset = "0x28")]
	private ComputeBuffer m_Data;

	[Token(Token = "0x4007F3E")]
	private const int k_ThreadGroupSizeX = 16;

	[Token(Token = "0x4007F3F")]
	private const int k_ThreadGroupSizeY = 16;

	[Token(Token = "0x6006536")]
	[Address(RVA = "0x100F800", Offset = "0x100E600", Length = "0xBC")]
	internal override void OnDisable()
	{
	}

	[Token(Token = "0x6006537")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	internal override bool NeedsHalfRes()
	{
		return false;
	}

	[Token(Token = "0x6006538")]
	[Address(RVA = "0x100F8C0", Offset = "0x100E6C0", Length = "0xF2")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x6006539")]
	[Address(RVA = "0x100F9C0", Offset = "0x100E7C0", Length = "0xA47")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600653A")]
	[Address(RVA = "0x1010410", Offset = "0x100F210", Length = "0xF")]
	public VectorscopeMonitor()
	{
	}
}
