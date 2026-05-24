using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000AB3")]
public sealed class RLPRO_SRP_ColormapPaletteRenderer : PostProcessEffectRenderer<RLProColormapPalette>
{
	[Token(Token = "0x40068A4")]
	[FieldOffset(Offset = "0x20")]
	public int tempPresetIndex;

	[Token(Token = "0x40068A5")]
	[FieldOffset(Offset = "0x24")]
	private bool m_Init;

	[Token(Token = "0x40068A6")]
	[FieldOffset(Offset = "0x28")]
	private Texture2D colormapPalette;

	[Token(Token = "0x40068A7")]
	[FieldOffset(Offset = "0x30")]
	private Texture3D colormapTexture;

	[Token(Token = "0x6005C6F")]
	[Address(RVA = "0xF42BB0", Offset = "0xF419B0", Length = "0x5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6005C70")]
	[Address(RVA = "0xF42BC0", Offset = "0xF419C0", Length = "0x467")]
	public override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x6005C71")]
	[Address(RVA = "0xF43030", Offset = "0xF41E30", Length = "0x3F2")]
	public void ApplyMaterialVariables(MaterialPropertyBlock bl)
	{
	}

	[Token(Token = "0x6005C72")]
	[Address(RVA = "0xF43430", Offset = "0xF42230", Length = "0x231")]
	public void ApplyColormapToMaterial(MaterialPropertyBlock bl)
	{
	}

	[Token(Token = "0x6005C73")]
	[Address(RVA = "0xF43670", Offset = "0xF42470", Length = "0x498")]
	private void ApplyPalette(MaterialPropertyBlock bl)
	{
	}

	[Token(Token = "0x6005C74")]
	[Address(RVA = "0xF43B10", Offset = "0xF42910", Length = "0x340")]
	public void ApplyMap(MaterialPropertyBlock bl)
	{
	}

	[Token(Token = "0x6005C75")]
	[Address(RVA = "0xF43E60", Offset = "0xF42C60", Length = "0x9")]
	public bool intHasChanged(int A, int B)
	{
		return false;
	}

	[Token(Token = "0x6005C76")]
	[Address(RVA = "0xF43E70", Offset = "0xF42C70", Length = "0x3E")]
	public RLPRO_SRP_ColormapPaletteRenderer()
	{
	}
}
