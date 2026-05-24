using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AC9")]
public sealed class RLPRO_SRP_NoiseRenderer : PostProcessEffectRenderer<RLProNoise>
{
	[Token(Token = "0x40068FE")]
	[FieldOffset(Offset = "0x20")]
	private float _time;

	[Token(Token = "0x40068FF")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture texTape;

	[Token(Token = "0x6005C99")]
	[Address(RVA = "0xF4BEB0", Offset = "0xF4ACB0", Length = "0x1610")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C9A")]
	[Address(RVA = "0xF3F1C0", Offset = "0xF3DFC0", Length = "0x3F")]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[Token(Token = "0x6005C9B")]
	[Address(RVA = "0xF4D4D0", Offset = "0xF4C2D0", Length = "0x3E")]
	public RLPRO_SRP_NoiseRenderer()
	{
	}
}
