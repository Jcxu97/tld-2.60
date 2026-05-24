using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000CB0")]
internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
{
	[Token(Token = "0x2000CB1")]
	private class QualityPreset
	{
		[Token(Token = "0x4007EF7")]
		[FieldOffset(Offset = "0x10")]
		public int maximumIterationCount;

		[Token(Token = "0x4007EF8")]
		[FieldOffset(Offset = "0x14")]
		public float thickness;

		[Token(Token = "0x4007EF9")]
		[FieldOffset(Offset = "0x18")]
		public ScreenSpaceReflectionResolution downsampling;

		[Token(Token = "0x600650A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public QualityPreset()
		{
		}
	}

	[Token(Token = "0x2000CB2")]
	private enum Pass
	{
		[Token(Token = "0x4007EFB")]
		Test,
		[Token(Token = "0x4007EFC")]
		Resolve,
		[Token(Token = "0x4007EFD")]
		Reproject,
		[Token(Token = "0x4007EFE")]
		Composite
	}

	[Token(Token = "0x4007EF3")]
	[FieldOffset(Offset = "0x20")]
	private RenderTexture m_Resolve;

	[Token(Token = "0x4007EF4")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture m_History;

	[Token(Token = "0x4007EF5")]
	[FieldOffset(Offset = "0x30")]
	private int[] m_MipIDs;

	[Token(Token = "0x4007EF6")]
	[FieldOffset(Offset = "0x38")]
	private readonly QualityPreset[] m_Presets;

	[Token(Token = "0x6006505")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6006506")]
	[Address(RVA = "0x1008AD0", Offset = "0x10078D0", Length = "0x388")]
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
	{
	}

	[Token(Token = "0x6006507")]
	[Address(RVA = "0x1008E60", Offset = "0x1007C60", Length = "0x1705")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006508")]
	[Address(RVA = "0x100A570", Offset = "0x1009370", Length = "0x119")]
	public override void Release()
	{
	}

	[Token(Token = "0x6006509")]
	[Address(RVA = "0x100A690", Offset = "0x1009490", Length = "0x382")]
	public ScreenSpaceReflectionsRenderer()
	{
	}
}
