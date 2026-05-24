using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AA8")]
public sealed class RLPRO_SRP_BleedRenderer : PostProcessEffectRenderer<RLProBleed>
{
	[Token(Token = "0x400688A")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve cu;

	[Token(Token = "0x400688B")]
	[FieldOffset(Offset = "0x28")]
	private int max_curve_length;

	[Token(Token = "0x400688C")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D texCurves;

	[Token(Token = "0x400688D")]
	[FieldOffset(Offset = "0x38")]
	private Vector4 curvesOffest;

	[Token(Token = "0x400688E")]
	[FieldOffset(Offset = "0x48")]
	private float[,] curvesData;

	[Token(Token = "0x6005C5D")]
	[Address(RVA = "0xF3FA30", Offset = "0xF3E830", Length = "0x5C")]
	public override void Init()
	{
	}

	[Token(Token = "0x6005C5E")]
	[Address(RVA = "0xF3FA90", Offset = "0xF3E890", Length = "0x68A")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C5F")]
	[Address(RVA = "0xF3F1C0", Offset = "0xF3DFC0", Length = "0x3F")]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[Token(Token = "0x6005C60")]
	[Address(RVA = "0xF40120", Offset = "0xF3EF20", Length = "0x6FB")]
	private void Curves()
	{
	}

	[Token(Token = "0x6005C61")]
	[Address(RVA = "0xF40820", Offset = "0xF3F620", Length = "0x15F")]
	public RLPRO_SRP_BleedRenderer()
	{
	}
}
