using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000D02")]
internal class TextureLerper
{
	[Token(Token = "0x4008109")]
	private static TextureLerper m_Instance;

	[Token(Token = "0x400810A")]
	[FieldOffset(Offset = "0x10")]
	private CommandBuffer m_Command;

	[Token(Token = "0x400810B")]
	[FieldOffset(Offset = "0x18")]
	private PropertySheetFactory m_PropertySheets;

	[Token(Token = "0x400810C")]
	[FieldOffset(Offset = "0x20")]
	private PostProcessResources m_Resources;

	[Token(Token = "0x400810D")]
	[FieldOffset(Offset = "0x28")]
	private List<RenderTexture> m_Recycled;

	[Token(Token = "0x400810E")]
	[FieldOffset(Offset = "0x30")]
	private List<RenderTexture> m_Actives;

	[Token(Token = "0x1700070E")]
	internal static TextureLerper instance
	{
		[Token(Token = "0x60066F1")]
		[Address(RVA = "0x10357E0", Offset = "0x10345E0", Length = "0x1FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60066F2")]
	[Address(RVA = "0x10359E0", Offset = "0x10347E0", Length = "0x139")]
	private TextureLerper()
	{
	}

	[Token(Token = "0x60066F3")]
	[Address(RVA = "0x1035B20", Offset = "0x1034920", Length = "0x139")]
	internal void BeginFrame(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60066F4")]
	[Address(RVA = "0x1035C60", Offset = "0x1034A60", Length = "0x27A")]
	internal void EndFrame()
	{
	}

	[Token(Token = "0x60066F5")]
	[Address(RVA = "0x1035EE0", Offset = "0x1034CE0", Length = "0x35B")]
	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	[Token(Token = "0x60066F6")]
	[Address(RVA = "0x1036240", Offset = "0x1035040", Length = "0xC0F")]
	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	[Token(Token = "0x60066F7")]
	[Address(RVA = "0x1036E50", Offset = "0x1035C50", Length = "0xA3E")]
	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	[Token(Token = "0x60066F8")]
	[Address(RVA = "0x1037890", Offset = "0x1036690", Length = "0x310")]
	internal void Clear()
	{
	}
}
