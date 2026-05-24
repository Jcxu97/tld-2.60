using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000C9A")]
internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
{
	[Token(Token = "0x2000C9B")]
	private enum Pass
	{
		[Token(Token = "0x4007E8F")]
		CoCCalculation,
		[Token(Token = "0x4007E90")]
		CoCTemporalFilter,
		[Token(Token = "0x4007E91")]
		DownsampleAndPrefilter,
		[Token(Token = "0x4007E92")]
		BokehSmallKernel,
		[Token(Token = "0x4007E93")]
		BokehMediumKernel,
		[Token(Token = "0x4007E94")]
		BokehLargeKernel,
		[Token(Token = "0x4007E95")]
		BokehVeryLargeKernel,
		[Token(Token = "0x4007E96")]
		PostFilter,
		[Token(Token = "0x4007E97")]
		Combine,
		[Token(Token = "0x4007E98")]
		DebugOverlay
	}

	[Token(Token = "0x4007E89")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x4007E8A")]
	private const int k_NumCoCHistoryTextures = 2;

	[Token(Token = "0x4007E8B")]
	[FieldOffset(Offset = "0x20")]
	private readonly RenderTexture[][] m_CoCHistoryTextures;

	[Token(Token = "0x4007E8C")]
	[FieldOffset(Offset = "0x28")]
	private int[] m_HistoryPingPong;

	[Token(Token = "0x4007E8D")]
	private const float k_FilmHeight = 0.024f;

	[Token(Token = "0x60064C3")]
	[Address(RVA = "0xFF9B80", Offset = "0xFF8980", Length = "0x2CE")]
	public DepthOfFieldRenderer()
	{
	}

	[Token(Token = "0x60064C4")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x60064C5")]
	[Address(RVA = "0xFF9E50", Offset = "0xFF8C50", Length = "0x94")]
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x60064C6")]
	[Address(RVA = "0xFF9EF0", Offset = "0xFF8CF0", Length = "0x81")]
	private float CalculateMaxCoCRadius(int screenHeight)
	{
		return 0f;
	}

	[Token(Token = "0x60064C7")]
	[Address(RVA = "0xFF9F80", Offset = "0xFF8D80", Length = "0x3F2")]
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
	{
		return null;
	}

	[Token(Token = "0x60064C8")]
	[Address(RVA = "0xFFA380", Offset = "0xFF9180", Length = "0x1585")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064C9")]
	[Address(RVA = "0xFFB910", Offset = "0xFFA710", Length = "0xF9")]
	public override void Release()
	{
	}
}
