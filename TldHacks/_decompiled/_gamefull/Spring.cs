using Cpp2ILInjected;

[Token(Token = "0x2000A59")]
public class Spring : ODE
{
	[Token(Token = "0x400674B")]
	[FieldOffset(Offset = "0x28")]
	public float mass;

	[Token(Token = "0x400674C")]
	[FieldOffset(Offset = "0x2C")]
	public float damp;

	[Token(Token = "0x400674D")]
	[FieldOffset(Offset = "0x30")]
	public float k;

	[Token(Token = "0x400674E")]
	[FieldOffset(Offset = "0x34")]
	public float restLen;

	[Token(Token = "0x6005AA0")]
	[Address(RVA = "0xF1B270", Offset = "0xF1A070", Length = "0x121")]
	public Spring(float _mass, float _dampening, float _k, float _restLength, float _initialLength)
		: base(0)
	{
	}

	[Token(Token = "0x6005AA1")]
	[Address(RVA = "0xF1B3A0", Offset = "0xF1A1A0", Length = "0x140")]
	public override float[] GetRightHandSide(float t, float[] q, float[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[Token(Token = "0x6005AA2")]
	[Address(RVA = "0xF1B4F0", Offset = "0xF1A2F0", Length = "0x2D")]
	public float GetLength()
	{
		return 0f;
	}

	[Token(Token = "0x6005AA3")]
	[Address(RVA = "0xF1B520", Offset = "0xF1A320", Length = "0x2D")]
	public void SetLength(float length)
	{
	}

	[Token(Token = "0x6005AA4")]
	[Address(RVA = "0xF1B550", Offset = "0xF1A350", Length = "0x28")]
	public float GetVelocity()
	{
		return 0f;
	}

	[Token(Token = "0x6005AA5")]
	[Address(RVA = "0xF1B580", Offset = "0xF1A380", Length = "0x28")]
	public void SetVelocity(float velocity)
	{
	}

	[Token(Token = "0x6005AA6")]
	[Address(RVA = "0xF1B5B0", Offset = "0xF1A3B0", Length = "0x2D")]
	public void AddForce(float force)
	{
	}
}
