using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000CB3")]
public sealed class SubpixelMorphologicalAntialiasing
{
	[Token(Token = "0x2000CB4")]
	private enum Pass
	{
		[Token(Token = "0x4007F01")]
		EdgeDetection = 0,
		[Token(Token = "0x4007F02")]
		BlendWeights = 3,
		[Token(Token = "0x4007F03")]
		NeighborhoodBlending = 6
	}

	[Token(Token = "0x2000CB5")]
	public enum Quality
	{
		[Token(Token = "0x4007F05")]
		Low,
		[Token(Token = "0x4007F06")]
		Medium,
		[Token(Token = "0x4007F07")]
		High
	}

	[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
	[Token(Token = "0x4007EFF")]
	[FieldOffset(Offset = "0x10")]
	public Quality quality;

	[Token(Token = "0x600650B")]
	[Address(RVA = "0x100AA20", Offset = "0x1009820", Length = "0x41")]
	public bool IsSupported()
	{
		return false;
	}

	[Token(Token = "0x600650C")]
	[Address(RVA = "0x100AA70", Offset = "0x1009870", Length = "0x829")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600650D")]
	[Address(RVA = "0x100B2A0", Offset = "0x100A0A0", Length = "0x8")]
	public SubpixelMorphologicalAntialiasing()
	{
	}
}
