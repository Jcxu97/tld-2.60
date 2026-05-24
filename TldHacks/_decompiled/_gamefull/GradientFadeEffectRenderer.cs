using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x20003AC")]
public class GradientFadeEffectRenderer : PostProcessEffectRenderer<GradientFadeEffect>
{
	[Token(Token = "0x40020C3")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_Shader;

	[Token(Token = "0x40020C4")]
	private static readonly int s_ColorPropertyID;

	[Token(Token = "0x40020C5")]
	private static readonly int s_IntensityPropertyID;

	[Token(Token = "0x40020C6")]
	private static readonly int s_PositionPropertyID;

	[Token(Token = "0x40020C7")]
	private static readonly int s_GradientPowerPropertyID;

	[Token(Token = "0x40020C8")]
	private static readonly int s_DirectionPropertyID;

	[Token(Token = "0x40020C9")]
	private static readonly int s_CurvatureStrengthPropertyID;

	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x792310", Offset = "0x791110", Length = "0x87")]
	public override void Init()
	{
	}

	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x7923A0", Offset = "0x7911A0", Length = "0x613")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x7929C0", Offset = "0x7917C0", Length = "0x3E")]
	public GradientFadeEffectRenderer()
	{
	}
}
