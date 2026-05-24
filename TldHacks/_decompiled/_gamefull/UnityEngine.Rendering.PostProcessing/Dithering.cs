using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000C9C")]
internal sealed class Dithering
{
	[Token(Token = "0x4007E99")]
	[FieldOffset(Offset = "0x10")]
	private int m_NoiseTextureIndex;

	[Token(Token = "0x4007E9A")]
	[FieldOffset(Offset = "0x18")]
	private System.Random m_Random;

	[Token(Token = "0x60064CA")]
	[Address(RVA = "0xFFBA10", Offset = "0xFFA810", Length = "0x2A6")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064CB")]
	[Address(RVA = "0xFFBCC0", Offset = "0xFFAAC0", Length = "0x9D")]
	public Dithering()
	{
	}
}
