using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000C95")]
internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
{
	[Token(Token = "0x2000C96")]
	private enum Pass
	{
		[Token(Token = "0x4007E7C")]
		LutGenLDRFromScratch,
		[Token(Token = "0x4007E7D")]
		LutGenLDR,
		[Token(Token = "0x4007E7E")]
		LutGenHDR2D,
		[Token(Token = "0x4007E7F")]
		LutGenBlendHDR2D
	}

	[Token(Token = "0x4007E5D")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D m_GradingCurves;

	[Token(Token = "0x4007E5E")]
	[FieldOffset(Offset = "0x28")]
	private readonly Color[] m_Pixels;

	[Token(Token = "0x4007E5F")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_InternalLdrLut;

	[Token(Token = "0x4007E60")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture m_InternalLogLut;

	[Token(Token = "0x4007E61")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture m_InternalBlendLut1A;

	[Token(Token = "0x4007E62")]
	[FieldOffset(Offset = "0x48")]
	private RenderTexture m_InternalBlendLut1B;

	[Token(Token = "0x4007E63")]
	[FieldOffset(Offset = "0x50")]
	private RenderTexture m_InternalBlendLut2A;

	[Token(Token = "0x4007E64")]
	[FieldOffset(Offset = "0x58")]
	private RenderTexture m_InternalBlendLut2B;

	[Token(Token = "0x4007E65")]
	[FieldOffset(Offset = "0x60")]
	private RenderTexture m_PainSettingsLut;

	[Token(Token = "0x4007E66")]
	[FieldOffset(Offset = "0x68")]
	private RenderTexture m_StimSettingsLut;

	[Token(Token = "0x4007E67")]
	[FieldOffset(Offset = "0x70")]
	private RenderTexture m_ElectrocutionSettingsLut;

	[Token(Token = "0x4007E68")]
	[FieldOffset(Offset = "0x78")]
	private RenderTexture m_BoostSettingsLut;

	[Token(Token = "0x4007E69")]
	[FieldOffset(Offset = "0x80")]
	private RenderTexture m_HeadacheSettingsLut;

	[Token(Token = "0x4007E6A")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture m_SuffocationSettingsLut;

	[Token(Token = "0x4007E6B")]
	[FieldOffset(Offset = "0x90")]
	private RenderTexture m_AuxSettingsLut;

	[Token(Token = "0x4007E6C")]
	private const int k_Lut2DSize = 32;

	[Token(Token = "0x4007E6D")]
	private const int k_Lut3DSize = 33;

	[Token(Token = "0x4007E6E")]
	[FieldOffset(Offset = "0x98")]
	private readonly HableCurve m_HableCurve;

	[Token(Token = "0x4007E6F")]
	[FieldOffset(Offset = "0xA0")]
	private MaterialPropertyBlock m_Settings1AProperties;

	[Token(Token = "0x4007E70")]
	[FieldOffset(Offset = "0xA8")]
	private MaterialPropertyBlock m_Settings1BProperties;

	[Token(Token = "0x4007E71")]
	[FieldOffset(Offset = "0xB0")]
	private MaterialPropertyBlock m_Settings2AProperties;

	[Token(Token = "0x4007E72")]
	[FieldOffset(Offset = "0xB8")]
	private MaterialPropertyBlock m_Settings2BProperties;

	[Token(Token = "0x4007E73")]
	[FieldOffset(Offset = "0xC0")]
	private MaterialPropertyBlock m_PainSettingsProperties;

	[Token(Token = "0x4007E74")]
	[FieldOffset(Offset = "0xC8")]
	private MaterialPropertyBlock m_StimSettingsProperties;

	[Token(Token = "0x4007E75")]
	[FieldOffset(Offset = "0xD0")]
	private MaterialPropertyBlock m_ElectrocutionSettingsProperties;

	[Token(Token = "0x4007E76")]
	[FieldOffset(Offset = "0xD8")]
	private MaterialPropertyBlock m_BoostSettingsProperties;

	[Token(Token = "0x4007E77")]
	[FieldOffset(Offset = "0xE0")]
	private MaterialPropertyBlock m_HeadacheSettingsProperties;

	[Token(Token = "0x4007E78")]
	[FieldOffset(Offset = "0xE8")]
	private MaterialPropertyBlock m_SuffocationSettingsProperties;

	[Token(Token = "0x4007E79")]
	[FieldOffset(Offset = "0xF0")]
	private MaterialPropertyBlock m_AuxSettingsProperties;

	[Token(Token = "0x4007E7A")]
	public static float s_Brightness;

	[Token(Token = "0x60064B0")]
	[Address(RVA = "0xFF02D0", Offset = "0xFEF0D0", Length = "0x9F")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064B1")]
	[Address(RVA = "0xFF0370", Offset = "0xFEF170", Length = "0x41E")]
	private void RenderExternalPipeline3D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064B2")]
	[Address(RVA = "0xFF0790", Offset = "0xFEF590", Length = "0x1A1A")]
	private void RenderHDRPipeline3D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064B3")]
	[Address(RVA = "0xFF21B0", Offset = "0xFF0FB0", Length = "0x19B3")]
	private void RenderHDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064B4")]
	[Address(RVA = "0xFF3B70", Offset = "0xFF2970", Length = "0x3248")]
	private void RenderHDRBlendPipeline2D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064B5")]
	[Address(RVA = "0xFF6DC0", Offset = "0xFF5BC0", Length = "0x152B")]
	private void RenderLDRPipeline2D(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064B6")]
	[Address(RVA = "0xFF82F0", Offset = "0xFF70F0", Length = "0x324")]
	private void CheckInternalLogLut()
	{
	}

	[Token(Token = "0x60064B7")]
	[Address(RVA = "0xFF8620", Offset = "0xFF7420", Length = "0x2E3")]
	private void MaybeCreateLut(ref RenderTexture lut)
	{
	}

	[Token(Token = "0x60064B8")]
	[Address(RVA = "0xFF8910", Offset = "0xFF7710", Length = "0xC8")]
	private void CheckInternalStripLut()
	{
	}

	[Token(Token = "0x60064B9")]
	[Address(RVA = "0xFF89E0", Offset = "0xFF77E0", Length = "0x59D")]
	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	[Token(Token = "0x60064BA")]
	[Address(RVA = "0xFF8F80", Offset = "0xFF7D80", Length = "0x108")]
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
	{
		return false;
	}

	[Token(Token = "0x60064BB")]
	[Address(RVA = "0xFF9090", Offset = "0xFF7E90", Length = "0x8D")]
	private static RenderTextureFormat GetLutFormat()
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x60064BC")]
	[Address(RVA = "0xFF9120", Offset = "0xFF7F20", Length = "0x26")]
	public static TextureFormat GetCurveFormat()
	{
		return default(TextureFormat);
	}

	[Token(Token = "0x60064BD")]
	[Address(RVA = "0xFF9150", Offset = "0xFF7F50", Length = "0x5AE")]
	public override void Release()
	{
	}

	[Token(Token = "0x60064BE")]
	[Address(RVA = "0xFF9700", Offset = "0xFF8500", Length = "0x13D")]
	public ColorGradingRenderer()
	{
	}
}
