using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200040B")]
public sealed class UnsharpMaskRenderer : PostProcessEffectRenderer<UnsharpMask>
{
	[Token(Token = "0x40024AF")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_UnsharpBlur;

	[Token(Token = "0x40024B0")]
	[FieldOffset(Offset = "0x28")]
	private Shader m_UnsharpComposite;

	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0x7CB510", Offset = "0x7CA310", Length = "0x119")]
	public override void Init()
	{
	}

	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x7CB630", Offset = "0x7CA430", Length = "0xBC7")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x7CC200", Offset = "0x7CB000", Length = "0x3E")]
	public UnsharpMaskRenderer()
	{
	}
}
