using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CB9")]
public sealed class VignetteModeParameter : ParameterOverride<VignetteMode>
{
	[Token(Token = "0x600651F")]
	[Address(RVA = "0x100D240", Offset = "0x100C040", Length = "0x4C")]
	public VignetteModeParameter()
	{
	}
}
