using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000CA9")]
internal sealed class ScalableAO : IAmbientOcclusionMethod
{
	[Token(Token = "0x2000CAA")]
	private enum Pass
	{
		[Token(Token = "0x4007ED7")]
		OcclusionEstimationForward,
		[Token(Token = "0x4007ED8")]
		OcclusionEstimationDeferred,
		[Token(Token = "0x4007ED9")]
		HorizontalBlurForward,
		[Token(Token = "0x4007EDA")]
		HorizontalBlurDeferred,
		[Token(Token = "0x4007EDB")]
		VerticalBlur,
		[Token(Token = "0x4007EDC")]
		CompositionForward,
		[Token(Token = "0x4007EDD")]
		CompositionDeferred,
		[Token(Token = "0x4007EDE")]
		DebugOverlay
	}

	[Token(Token = "0x4007ED1")]
	[FieldOffset(Offset = "0x10")]
	private RenderTexture m_Result;

	[Token(Token = "0x4007ED2")]
	[FieldOffset(Offset = "0x18")]
	private PropertySheet m_PropertySheet;

	[Token(Token = "0x4007ED3")]
	[FieldOffset(Offset = "0x20")]
	private AmbientOcclusion m_Settings;

	[Token(Token = "0x4007ED4")]
	[FieldOffset(Offset = "0x28")]
	private readonly RenderTargetIdentifier[] m_MRT;

	[Token(Token = "0x4007ED5")]
	[FieldOffset(Offset = "0x30")]
	private readonly int[] m_SampleCount;

	[Token(Token = "0x60064F8")]
	[Address(RVA = "0x10063A0", Offset = "0x10051A0", Length = "0x25E")]
	public ScalableAO(AmbientOcclusion settings)
	{
	}

	[Token(Token = "0x60064F9")]
	[Address(RVA = "0x457130", Offset = "0x455F30", Length = "0x6")]
	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x60064FA")]
	[Address(RVA = "0x1006600", Offset = "0x1005400", Length = "0x54A")]
	private void DoLazyInitialization(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064FB")]
	[Address(RVA = "0x1006B50", Offset = "0x1005950", Length = "0xFB8")]
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
	{
	}

	[Token(Token = "0x60064FC")]
	[Address(RVA = "0x1007B10", Offset = "0x1006910", Length = "0x29B")]
	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064FD")]
	[Address(RVA = "0x1007DB0", Offset = "0x1006BB0", Length = "0x99")]
	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064FE")]
	[Address(RVA = "0x1007E50", Offset = "0x1006C50", Length = "0x28C")]
	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064FF")]
	[Address(RVA = "0x10080E0", Offset = "0x1006EE0", Length = "0xAC")]
	public void Release()
	{
	}

	[Token(Token = "0x6006500")]
	[Address(RVA = "0x1008190", Offset = "0x1006F90", Length = "0x261")]
	private static void BlitFullscreenTriangle_KeepDepthTarget(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier keepDepthTarget, PropertySheet propertySheet, int pass)
	{
	}
}
