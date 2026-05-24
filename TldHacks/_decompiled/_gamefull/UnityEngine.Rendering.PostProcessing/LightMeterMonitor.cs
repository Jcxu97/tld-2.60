using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CBE")]
public sealed class LightMeterMonitor : Monitor
{
	[Token(Token = "0x4007F31")]
	[FieldOffset(Offset = "0x20")]
	public int width;

	[Token(Token = "0x4007F32")]
	[FieldOffset(Offset = "0x24")]
	public int height;

	[Token(Token = "0x4007F33")]
	[FieldOffset(Offset = "0x28")]
	public bool showCurves;

	[Token(Token = "0x6006529")]
	[Address(RVA = "0x100EB00", Offset = "0x100D900", Length = "0x127")]
	internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x600652A")]
	[Address(RVA = "0x100EC30", Offset = "0x100DA30", Length = "0x81F")]
	internal override void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x600652B")]
	[Address(RVA = "0x100F450", Offset = "0x100E250", Length = "0x13")]
	public LightMeterMonitor()
	{
	}
}
