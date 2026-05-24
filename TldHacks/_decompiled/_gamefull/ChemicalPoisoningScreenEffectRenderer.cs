using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000374")]
public sealed class ChemicalPoisoningScreenEffectRenderer : PostProcessEffectRenderer<ChemicalPoisoningScreenEffect>
{
	[Token(Token = "0x4001EA7")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_Shader;

	[Token(Token = "0x4001EA8")]
	private static readonly int s_IntensityPropertyID;

	[Token(Token = "0x4001EA9")]
	private static readonly int s_ColorPropertyID;

	[Token(Token = "0x4001EAA")]
	private static readonly int s_PoisonMaskPropertyID;

	[Token(Token = "0x4001EAB")]
	private static readonly int s_MaskTilingPropertyID;

	[Token(Token = "0x4001EAC")]
	private static readonly int s_SceneBrightnessAdjustmentPropertyID;

	[Token(Token = "0x4001EAD")]
	private static readonly int s_GradientIncrementPropertyID;

	[Token(Token = "0x4001EAE")]
	private static readonly int s_VignettePowerPropertyID;

	[Token(Token = "0x4001EAF")]
	private static readonly int s_IntensityRangePropertyID;

	[Token(Token = "0x4001EB0")]
	private static readonly int s_AnimationControlPropertyID;

	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x76E7C0", Offset = "0x76D5C0", Length = "0x87")]
	public override void Init()
	{
	}

	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x76E850", Offset = "0x76D650", Length = "0x8A6")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x76F100", Offset = "0x76DF00", Length = "0x3E")]
	public ChemicalPoisoningScreenEffectRenderer()
	{
	}
}
