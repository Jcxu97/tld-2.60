using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000C84")]
internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	[Token(Token = "0x4007DDE")]
	[FieldOffset(Offset = "0x20")]
	private IAmbientOcclusionMethod[] m_Methods;

	[Token(Token = "0x600648D")]
	[Address(RVA = "0xFE9050", Offset = "0xFE7E50", Length = "0x1C0")]
	public override void Init()
	{
	}

	[Token(Token = "0x600648E")]
	[Address(RVA = "0xFE9220", Offset = "0xFE8020", Length = "0x8C")]
	public bool IsAmbientOnly(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x600648F")]
	[Address(RVA = "0xFE92B0", Offset = "0xFE80B0", Length = "0x64")]
	public IAmbientOcclusionMethod Get()
	{
		return null;
	}

	[Token(Token = "0x6006490")]
	[Address(RVA = "0xFE9320", Offset = "0xFE8120", Length = "0x97")]
	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x6006491")]
	[Address(RVA = "0xFE93C0", Offset = "0xFE81C0", Length = "0x119")]
	public override void Release()
	{
	}

	[Token(Token = "0x6006492")]
	[Address(RVA = "0xFE94E0", Offset = "0xFE82E0", Length = "0x6E")]
	public ScalableAO GetScalableAO()
	{
		return null;
	}

	[Token(Token = "0x6006493")]
	[Address(RVA = "0xFE9550", Offset = "0xFE8350", Length = "0x6E")]
	public MultiScaleVO GetMultiScaleVO()
	{
		return null;
	}

	[Token(Token = "0x6006494")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6006495")]
	[Address(RVA = "0xFE95C0", Offset = "0xFE83C0", Length = "0x3E")]
	public AmbientOcclusionRenderer()
	{
	}
}
