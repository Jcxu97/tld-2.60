using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AC3")]
public sealed class RLPRO_SRP_JitterRenderer : PostProcessEffectRenderer<RLProJitter>
{
	[Token(Token = "0x40068E3")]
	[FieldOffset(Offset = "0x20")]
	private float start;

	[Token(Token = "0x40068E4")]
	[FieldOffset(Offset = "0x24")]
	private float _time;

	[Token(Token = "0x40068E5")]
	[FieldOffset(Offset = "0x28")]
	private bool once;

	[Token(Token = "0x6005C8F")]
	[Address(RVA = "0xF499D0", Offset = "0xF487D0", Length = "0xBC2")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C90")]
	[Address(RVA = "0xF3F1C0", Offset = "0xF3DFC0", Length = "0x3F")]
	private void ParamSwitch(PropertySheet mat, bool paramValue, string paramName)
	{
	}

	[Token(Token = "0x6005C91")]
	[Address(RVA = "0xF4A5A0", Offset = "0xF493A0", Length = "0x3E")]
	public RLPRO_SRP_JitterRenderer()
	{
	}
}
