using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000C9E")]
public sealed class Fog
{
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	[Token(Token = "0x4007E9D")]
	[FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Tooltip("Mark true for the fog to ignore the skybox")]
	[Token(Token = "0x4007E9E")]
	[FieldOffset(Offset = "0x11")]
	public bool excludeSkybox;

	[Token(Token = "0x60064CD")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[Token(Token = "0x60064CE")]
	[Address(RVA = "0xFFBD60", Offset = "0xFFAB60", Length = "0x162")]
	internal bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60064CF")]
	[Address(RVA = "0xFFBED0", Offset = "0xFFACD0", Length = "0x5DE")]
	internal void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60064D0")]
	[Address(RVA = "0xFFC4B0", Offset = "0xFFB2B0", Length = "0x7")]
	public Fog()
	{
	}
}
