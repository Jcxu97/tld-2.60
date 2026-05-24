using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CAD")]
public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset>
{
	[Token(Token = "0x6006501")]
	[Address(RVA = "0x1008400", Offset = "0x1007200", Length = "0x4C")]
	public ScreenSpaceReflectionPresetParameter()
	{
	}
}
