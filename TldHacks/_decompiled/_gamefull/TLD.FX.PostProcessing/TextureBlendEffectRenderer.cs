using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace TLD.FX.PostProcessing;

[Token(Token = "0x20013DC")]
public sealed class TextureBlendEffectRenderer : PostProcessEffectRenderer<TextureBlendEffect>
{
	[Token(Token = "0x4009184")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_Shader;

	[Token(Token = "0x4009185")]
	private static readonly int s_StrengthPropertyID;

	[Token(Token = "0x4009186")]
	private static readonly int s_TilingPropertyID;

	[Token(Token = "0x4009187")]
	private static readonly int s_TexturePropertyID;

	[Token(Token = "0x4009188")]
	private static readonly int s_TempTexture1PropertyID;

	[Token(Token = "0x4009189")]
	private static readonly int s_TempTexture2PropertyID;

	[Token(Token = "0x6007EB4")]
	[Address(RVA = "0x11E4AD0", Offset = "0x11E38D0", Length = "0x87")]
	public override void Init()
	{
	}

	[Token(Token = "0x6007EB5")]
	[Address(RVA = "0x11E4B60", Offset = "0x11E3960", Length = "0xE90")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6007EB6")]
	[Address(RVA = "0x11E5A00", Offset = "0x11E4800", Length = "0x263")]
	private void SetProperties(MaterialPropertyBlock properties, float strength, Vector2 tiling, Texture texture)
	{
	}

	[Token(Token = "0x6007EB7")]
	[Address(RVA = "0x11E5C70", Offset = "0x11E4A70", Length = "0x3E")]
	public TextureBlendEffectRenderer()
	{
	}
}
