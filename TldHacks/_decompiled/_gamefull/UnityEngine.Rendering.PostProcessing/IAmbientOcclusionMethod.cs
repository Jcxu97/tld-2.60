using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000C83")]
internal interface IAmbientOcclusionMethod
{
	[Token(Token = "0x6006488")]
	DepthTextureMode GetCameraFlags();

	[Token(Token = "0x6006489")]
	void RenderAfterOpaque(PostProcessRenderContext context);

	[Token(Token = "0x600648A")]
	void RenderAmbientOnly(PostProcessRenderContext context);

	[Token(Token = "0x600648B")]
	void CompositeAmbientOnly(PostProcessRenderContext context);

	[Token(Token = "0x600648C")]
	void Release();
}
