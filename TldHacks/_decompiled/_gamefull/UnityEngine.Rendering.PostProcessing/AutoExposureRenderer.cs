using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000C88")]
internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
{
	[Token(Token = "0x4007DE9")]
	private const int k_NumEyes = 2;

	[Token(Token = "0x4007DEA")]
	private const int k_NumAutoExposureTextures = 2;

	[Token(Token = "0x4007DEB")]
	[FieldOffset(Offset = "0x20")]
	private readonly RenderTexture[][] m_AutoExposurePool;

	[Token(Token = "0x4007DEC")]
	[FieldOffset(Offset = "0x28")]
	private int[] m_AutoExposurePingPong;

	[Token(Token = "0x4007DED")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_CurrentAutoExposure;

	[Token(Token = "0x6006499")]
	[Address(RVA = "0xFE9C80", Offset = "0xFE8A80", Length = "0x2CE")]
	public AutoExposureRenderer()
	{
	}

	[Token(Token = "0x600649A")]
	[Address(RVA = "0xFE9F50", Offset = "0xFE8D50", Length = "0x2DA")]
	private void CheckTexture(int eye, int id)
	{
	}

	[Token(Token = "0x600649B")]
	[Address(RVA = "0xFEA230", Offset = "0xFE9030", Length = "0x1194")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600649C")]
	[Address(RVA = "0xFEB3D0", Offset = "0xFEA1D0", Length = "0xC9")]
	public override void Release()
	{
	}
}
