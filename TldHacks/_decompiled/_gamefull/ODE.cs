using Cpp2ILInjected;

[Token(Token = "0x2000A58")]
public class ODE
{
	[Token(Token = "0x4006748")]
	[FieldOffset(Offset = "0x10")]
	public int numEquations;

	[Token(Token = "0x4006749")]
	[FieldOffset(Offset = "0x18")]
	public float[] q;

	[Token(Token = "0x400674A")]
	[FieldOffset(Offset = "0x20")]
	public float t;

	[Token(Token = "0x6005A9C")]
	[Address(RVA = "0xF1AD50", Offset = "0xF19B50", Length = "0x9C")]
	public ODE(int _numEquations)
	{
	}

	[Token(Token = "0x6005A9D")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public virtual float[] GetRightHandSide(float t, float[] q, float[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[Token(Token = "0x6005A9E")]
	[Address(RVA = "0xF1ADF0", Offset = "0xF19BF0", Length = "0x214")]
	public void Update(float dt)
	{
	}

	[Token(Token = "0x6005A9F")]
	[Address(RVA = "0xF1B010", Offset = "0xF19E10", Length = "0x256")]
	public void Update2(float dt)
	{
	}
}
