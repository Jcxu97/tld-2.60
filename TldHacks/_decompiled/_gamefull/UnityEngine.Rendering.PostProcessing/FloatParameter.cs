using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CC5")]
public sealed class FloatParameter : ParameterOverride<float>
{
	[Token(Token = "0x6006551")]
	[Address(RVA = "0x1011200", Offset = "0x1010000", Length = "0x12")]
	public override void Interp(float from, float to, float t)
	{
	}

	[Token(Token = "0x6006552")]
	[Address(RVA = "0x1011220", Offset = "0x1010020", Length = "0x72")]
	public override bool Equals(float a, float b)
	{
		return false;
	}

	[Token(Token = "0x6006553")]
	[Address(RVA = "0x10112A0", Offset = "0x10100A0", Length = "0x4C")]
	public FloatParameter()
	{
	}
}
