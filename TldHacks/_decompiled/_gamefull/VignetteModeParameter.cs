using System;
using Cpp2ILInjected;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000AD5")]
public sealed class VignetteModeParameter : ParameterOverride<VignetteShape>
{
	[Token(Token = "0x6005CAC")]
	[Address(RVA = "0xF50B60", Offset = "0xF4F960", Length = "0x4C")]
	public VignetteModeParameter()
	{
	}
}
