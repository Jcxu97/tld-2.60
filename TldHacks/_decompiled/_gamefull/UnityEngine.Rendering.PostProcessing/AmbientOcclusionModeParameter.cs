using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000C80")]
public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode>
{
	[Token(Token = "0x6006484")]
	[Address(RVA = "0xFE8490", Offset = "0xFE7290", Length = "0x4C")]
	public AmbientOcclusionModeParameter()
	{
	}
}
