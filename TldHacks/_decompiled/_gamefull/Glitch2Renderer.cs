using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000ABF")]
public sealed class Glitch2Renderer : PostProcessEffectRenderer<RLProGlitch2>
{
	[Token(Token = "0x40068CB")]
	[FieldOffset(Offset = "0x20")]
	private float T;

	[Token(Token = "0x40068CC")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture _trashFrame1;

	[Token(Token = "0x40068CD")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture _trashFrame2;

	[Token(Token = "0x40068CE")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D _noiseTexture;

	[Token(Token = "0x40068CF")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture trashFrame;

	[Token(Token = "0x6005C86")]
	[Address(RVA = "0xF47300", Offset = "0xF46100", Length = "0x9DE")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C87")]
	[Address(RVA = "0xF47CE0", Offset = "0xF46AE0", Length = "0x533")]
	private void SetUpResources(float g_2Res)
	{
	}

	[Token(Token = "0x6005C88")]
	[Address(RVA = "0xF48220", Offset = "0xF47020", Length = "0x32B")]
	private void UpdateNoiseTexture(float g_2Res)
	{
	}

	[Token(Token = "0x6005C89")]
	[Address(RVA = "0xF48550", Offset = "0xF47350", Length = "0x14F")]
	private static Color RandomColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6005C8A")]
	[Address(RVA = "0xF486A0", Offset = "0xF474A0", Length = "0x3E")]
	public Glitch2Renderer()
	{
	}
}
