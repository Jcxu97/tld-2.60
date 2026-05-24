using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x20003D5")]
internal sealed class MaskedBlurEffectRenderer : PostProcessEffectRenderer<MaskedBlurEffect>
{
	[Token(Token = "0x20003D6")]
	private enum Pass
	{
		[Token(Token = "0x40022A0")]
		CoCCalculation,
		[Token(Token = "0x40022A1")]
		CoCTemporalFilter,
		[Token(Token = "0x40022A2")]
		DownsampleAndPrefilter,
		[Token(Token = "0x40022A3")]
		BokehSmallKernel,
		[Token(Token = "0x40022A4")]
		BokehMediumKernel,
		[Token(Token = "0x40022A5")]
		BokehLargeKernel,
		[Token(Token = "0x40022A6")]
		BokehVeryLargeKernel,
		[Token(Token = "0x40022A7")]
		PostFilter,
		[Token(Token = "0x40022A8")]
		Combine,
		[Token(Token = "0x40022A9")]
		DebugOverlay
	}

	[Token(Token = "0x4002297")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_Shader;

	[Token(Token = "0x4002298")]
	[FieldOffset(Offset = "0x28")]
	private int m_DepthTextureShaderId;

	[Token(Token = "0x4002299")]
	[FieldOffset(Offset = "0x2C")]
	private int m_DepthTextureBlendShaderId;

	[Token(Token = "0x400229A")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x400229B")]
	private const int k_NumCoCHistoryTextures = 2;

	[Token(Token = "0x400229C")]
	[FieldOffset(Offset = "0x30")]
	private readonly RenderTexture[][] m_CoCHistoryTextures;

	[Token(Token = "0x400229D")]
	[FieldOffset(Offset = "0x38")]
	private int[] m_HistoryPingPong;

	[Token(Token = "0x400229E")]
	private const float k_FilmHeight = 0.024f;

	[Token(Token = "0x6001DDF")]
	[Address(RVA = "0x7AC0C0", Offset = "0x7AAEC0", Length = "0x37E")]
	public MaskedBlurEffectRenderer()
	{
	}

	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6001DE1")]
	[Address(RVA = "0x7AC440", Offset = "0x7AB240", Length = "0x94")]
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6001DE2")]
	[Address(RVA = "0x7AC4E0", Offset = "0x7AB2E0", Length = "0x81")]
	private float CalculateMaxCoCRadius(int screenHeight)
	{
		return 0f;
	}

	[Token(Token = "0x6001DE3")]
	[Address(RVA = "0x7AC570", Offset = "0x7AB370", Length = "0x3F2")]
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
	{
		return null;
	}

	[Token(Token = "0x6001DE4")]
	[Address(RVA = "0x7AC970", Offset = "0x7AB770", Length = "0x163E")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0x7ADFB0", Offset = "0x7ACDB0", Length = "0xF9")]
	public override void Release()
	{
	}
}
