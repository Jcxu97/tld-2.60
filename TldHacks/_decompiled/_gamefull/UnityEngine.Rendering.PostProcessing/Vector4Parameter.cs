using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CCB")]
public sealed class Vector4Parameter : ParameterOverride<Vector4>
{
	[Token(Token = "0x6006566")]
	[Address(RVA = "0x10113C0", Offset = "0x10101C0", Length = "0x62")]
	public override void Interp(Vector4 from, Vector4 to, float t)
	{
	}

	[Token(Token = "0x6006567")]
	[Address(RVA = "0x1011860", Offset = "0x1010660", Length = "0x26")]
	public static implicit operator Vector2(Vector4Parameter prop)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6006568")]
	[Address(RVA = "0x1011890", Offset = "0x1010690", Length = "0x3F")]
	public static implicit operator Vector3(Vector4Parameter prop)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6006569")]
	[Address(RVA = "0x10118D0", Offset = "0x10106D0", Length = "0x69")]
	public override bool Equals(Vector4 a, Vector4 b)
	{
		return false;
	}

	[Token(Token = "0x600656A")]
	[Address(RVA = "0x1011940", Offset = "0x1010740", Length = "0x3B")]
	public Vector4Parameter()
	{
	}
}
