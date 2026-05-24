using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CCE")]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	[Token(Token = "0x4007F4E")]
	[FieldOffset(Offset = "0x20")]
	public TextureParameterDefault defaultState;

	[Token(Token = "0x600656F")]
	[Address(RVA = "0x1011CF0", Offset = "0x1010AF0", Length = "0xA4A")]
	public override void Interp(Texture from, Texture to, float t)
	{
	}

	[Token(Token = "0x6006570")]
	[Address(RVA = "0x1012740", Offset = "0x1011540", Length = "0x8B")]
	public TextureParameter()
	{
	}
}
