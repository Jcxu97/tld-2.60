using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x20003FF")]
public sealed class SuffocationScreenEffectRenderer : PostProcessEffectRenderer<SuffocationScreenEffect>
{
	[Token(Token = "0x40023FE")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_Shader;

	[Token(Token = "0x40023FF")]
	private static readonly int s_IntensityPropertyID;

	[Token(Token = "0x4002400")]
	private static readonly int s_PackedParametersPropertyID;

	[Token(Token = "0x4002401")]
	private static readonly int s_NoiseScaleAndSpeedPropertyID;

	[Token(Token = "0x4002402")]
	private static readonly int s_NoiseTexturePropertyID;

	[Token(Token = "0x4002403")]
	private static readonly int s_BlurTexturePropertyID;

	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x7C1B30", Offset = "0x7C0930", Length = "0x87")]
	public override void Init()
	{
	}

	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0x7C1BC0", Offset = "0x7C09C0", Length = "0x709")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x7C22D0", Offset = "0x7C10D0", Length = "0x3E")]
	public SuffocationScreenEffectRenderer()
	{
	}
}
