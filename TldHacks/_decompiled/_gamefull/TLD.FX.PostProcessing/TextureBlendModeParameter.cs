using System;
using Cpp2ILInjected;
using UnityEngine.Rendering.PostProcessing;

namespace TLD.FX.PostProcessing;

[Serializable]
[Token(Token = "0x20013DA")]
public sealed class TextureBlendModeParameter : ParameterOverride<TextureBlendMode>
{
	[Token(Token = "0x6007EB2")]
	[Address(RVA = "0x11E4280", Offset = "0x11E3080", Length = "0x4C")]
	public TextureBlendModeParameter()
	{
	}
}
