using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000C81")]
public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality>
{
	[Token(Token = "0x6006485")]
	[Address(RVA = "0xFE84E0", Offset = "0xFE72E0", Length = "0x4C")]
	public AmbientOcclusionQualityParameter()
	{
	}
}
