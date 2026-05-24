using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
[Token(Token = "0x2000C9D")]
public sealed class FastApproximateAntialiasing
{
	[FormerlySerializedAs("mobileOptimized")]
	[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	[Token(Token = "0x4007E9B")]
	[FieldOffset(Offset = "0x10")]
	public bool fastMode;

	[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.\nThis setting has no effect if the camera render target has no alpha channel.")]
	[Token(Token = "0x4007E9C")]
	[FieldOffset(Offset = "0x11")]
	public bool keepAlpha;

	[Token(Token = "0x60064CC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FastApproximateAntialiasing()
	{
	}
}
