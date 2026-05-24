using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CC8")]
public sealed class ColorParameter : ParameterOverride<Color>
{
	[Token(Token = "0x6006558")]
	[Address(RVA = "0x10113C0", Offset = "0x10101C0", Length = "0x62")]
	public override void Interp(Color from, Color to, float t)
	{
	}

	[Token(Token = "0x6006559")]
	[Address(RVA = "0x1011430", Offset = "0x1010230", Length = "0x4E")]
	public static implicit operator Vector4(ColorParameter prop)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600655A")]
	[Address(RVA = "0x1011480", Offset = "0x1010280", Length = "0x69")]
	public override bool Equals(Color a, Color b)
	{
		return false;
	}

	[Token(Token = "0x600655B")]
	[Address(RVA = "0x10114F0", Offset = "0x10102F0", Length = "0x3B")]
	public ColorParameter()
	{
	}
}
