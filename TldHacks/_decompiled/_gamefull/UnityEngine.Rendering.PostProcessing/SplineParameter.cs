using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CCC")]
public sealed class SplineParameter : ParameterOverride<Spline>
{
	[Token(Token = "0x600656B")]
	[Address(RVA = "0x1011980", Offset = "0x1010780", Length = "0x17")]
	protected internal override void OnEnable()
	{
	}

	[Token(Token = "0x600656C")]
	[Address(RVA = "0x10119A0", Offset = "0x10107A0", Length = "0x104")]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[Token(Token = "0x600656D")]
	[Address(RVA = "0x1011AB0", Offset = "0x10108B0", Length = "0x1B9")]
	public override void Interp(Spline from, Spline to, float t)
	{
	}

	[Token(Token = "0x600656E")]
	[Address(RVA = "0x1011C70", Offset = "0x1010A70", Length = "0x7B")]
	public SplineParameter()
	{
	}
}
