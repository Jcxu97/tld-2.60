using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A5A")]
public class ODE3
{
	[Token(Token = "0x400674F")]
	[FieldOffset(Offset = "0x10")]
	public int numEquations;

	[Token(Token = "0x4006750")]
	[FieldOffset(Offset = "0x18")]
	public Vector3[] q;

	[Token(Token = "0x4006751")]
	[FieldOffset(Offset = "0x20")]
	public float t;

	[Token(Token = "0x6005AA7")]
	[Address(RVA = "0xF1B5E0", Offset = "0xF1A3E0", Length = "0x9C")]
	public ODE3(int _numEquations)
	{
	}

	[Token(Token = "0x6005AA8")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public virtual Vector3[] GetRightHandSide(float t, Vector3[] q, Vector3[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[Token(Token = "0x6005AA9")]
	[Address(RVA = "0xF1B680", Offset = "0xF1A480", Length = "0x30E")]
	public void Update(float dt)
	{
	}

	[Token(Token = "0x6005AAA")]
	[Address(RVA = "0xF1B990", Offset = "0xF1A790", Length = "0x3D5")]
	public void Update2(float dt)
	{
	}
}
