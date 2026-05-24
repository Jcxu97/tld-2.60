using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CCA")]
public sealed class Vector3Parameter : ParameterOverride<Vector3>
{
	[Token(Token = "0x6006561")]
	[Address(RVA = "0x10116C0", Offset = "0x10104C0", Length = "0x49")]
	public override void Interp(Vector3 from, Vector3 to, float t)
	{
	}

	[Token(Token = "0x6006562")]
	[Address(RVA = "0x1011710", Offset = "0x1010510", Length = "0x27")]
	public static implicit operator Vector2(Vector3Parameter prop)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6006563")]
	[Address(RVA = "0x1011740", Offset = "0x1010540", Length = "0x51")]
	public static implicit operator Vector4(Vector3Parameter prop)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6006564")]
	[Address(RVA = "0x10117A0", Offset = "0x10105A0", Length = "0x63")]
	public override bool Equals(Vector3 a, Vector3 b)
	{
		return false;
	}

	[Token(Token = "0x6006565")]
	[Address(RVA = "0x1011810", Offset = "0x1010610", Length = "0x48")]
	public Vector3Parameter()
	{
	}
}
