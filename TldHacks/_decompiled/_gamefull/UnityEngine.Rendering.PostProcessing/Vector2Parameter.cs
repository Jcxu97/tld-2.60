using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CC9")]
public sealed class Vector2Parameter : ParameterOverride<Vector2>
{
	[Token(Token = "0x600655C")]
	[Address(RVA = "0x1011530", Offset = "0x1010330", Length = "0x46")]
	public override void Interp(Vector2 from, Vector2 to, float t)
	{
	}

	[Token(Token = "0x600655D")]
	[Address(RVA = "0x1011580", Offset = "0x1010380", Length = "0x37")]
	public static implicit operator Vector3(Vector2Parameter prop)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600655E")]
	[Address(RVA = "0x10115C0", Offset = "0x10103C0", Length = "0x41")]
	public static implicit operator Vector4(Vector2Parameter prop)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600655F")]
	[Address(RVA = "0x1011610", Offset = "0x1010410", Length = "0x43")]
	public override bool Equals(Vector2 a, Vector2 b)
	{
		return false;
	}

	[Token(Token = "0x6006560")]
	[Address(RVA = "0x1011660", Offset = "0x1010460", Length = "0x53")]
	public Vector2Parameter()
	{
	}
}
