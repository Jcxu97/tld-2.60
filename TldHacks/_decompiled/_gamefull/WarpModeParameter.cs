using System;
using Cpp2ILInjected;
using RetroLookPro.Enums;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000AD2")]
public sealed class WarpModeParameter : ParameterOverride<WarpMode>
{
	[Token(Token = "0x6005CA8")]
	[Address(RVA = "0xF4FCC0", Offset = "0xF4EAC0", Length = "0x4C")]
	public WarpModeParameter()
	{
	}
}
