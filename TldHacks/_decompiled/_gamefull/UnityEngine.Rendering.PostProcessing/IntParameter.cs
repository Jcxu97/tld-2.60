using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CC6")]
public sealed class IntParameter : ParameterOverride<int>
{
	[Token(Token = "0x6006554")]
	[Address(RVA = "0x10112F0", Offset = "0x10100F0", Length = "0x22")]
	public override void Interp(int from, int to, float t)
	{
	}

	[Token(Token = "0x6006555")]
	[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
	public override bool Equals(int a, int b)
	{
		return false;
	}

	[Token(Token = "0x6006556")]
	[Address(RVA = "0x1011320", Offset = "0x1010120", Length = "0x4C")]
	public IntParameter()
	{
	}
}
