using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000CA4")]
internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
{
	[Token(Token = "0x2000CA5")]
	private enum Pass
	{
		[Token(Token = "0x4007EAF")]
		VelocitySetup,
		[Token(Token = "0x4007EB0")]
		TileMax1,
		[Token(Token = "0x4007EB1")]
		TileMax2,
		[Token(Token = "0x4007EB2")]
		TileMaxV,
		[Token(Token = "0x4007EB3")]
		NeighborMax,
		[Token(Token = "0x4007EB4")]
		Reconstruction
	}

	[Token(Token = "0x60064DD")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x60064DE")]
	[Address(RVA = "0xFFDEB0", Offset = "0xFFCCB0", Length = "0x102")]
	private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
	{
	}

	[Token(Token = "0x60064DF")]
	[Address(RVA = "0xFFDFC0", Offset = "0xFFCDC0", Length = "0x145F")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064E0")]
	[Address(RVA = "0xFFF420", Offset = "0xFFE220", Length = "0x3E")]
	public MotionBlurRenderer()
	{
	}
}
