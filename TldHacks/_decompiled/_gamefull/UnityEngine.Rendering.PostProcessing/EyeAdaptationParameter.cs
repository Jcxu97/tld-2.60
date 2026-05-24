using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000C86")]
public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation>
{
	[Token(Token = "0x6006496")]
	[Address(RVA = "0xFE9600", Offset = "0xFE8400", Length = "0x4C")]
	public EyeAdaptationParameter()
	{
	}
}
