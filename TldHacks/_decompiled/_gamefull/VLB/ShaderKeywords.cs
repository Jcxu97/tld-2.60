using Cpp2ILInjected;

namespace VLB;

[Token(Token = "0x2000BE3")]
public static class ShaderKeywords
{
	[Token(Token = "0x400795E")]
	public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

	[Token(Token = "0x400795F")]
	public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

	[Token(Token = "0x4007960")]
	public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

	[Token(Token = "0x4007961")]
	public const string DepthBlend = "VLB_DEPTH_BLEND";

	[Token(Token = "0x4007962")]
	public const string Noise3D = "VLB_NOISE_3D";

	[Token(Token = "0x4007963")]
	public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

	[Token(Token = "0x4007964")]
	public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

	[Token(Token = "0x4007965")]
	public const string MeshSkewing = "VLB_MESH_SKEWING";

	[Token(Token = "0x4007966")]
	public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
}
