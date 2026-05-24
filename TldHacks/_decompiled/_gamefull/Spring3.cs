using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A5B")]
public class Spring3 : ODE3
{
	[Token(Token = "0x4006752")]
	[FieldOffset(Offset = "0x28")]
	public float mass;

	[Token(Token = "0x4006753")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 damp;

	[Token(Token = "0x4006754")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 k;

	[Token(Token = "0x4006755")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 restPos;

	[Token(Token = "0x6005AAB")]
	[Address(RVA = "0xF1BD70", Offset = "0xF1AB70", Length = "0x1D2")]
	public Spring3(float _mass, Vector3 _dampening, Vector3 _k, Vector3 _restPosition, Vector3 _initialPosition)
		: base(0)
	{
	}

	[Token(Token = "0x6005AAC")]
	[Address(RVA = "0xF1BF50", Offset = "0xF1AD50", Length = "0x284")]
	public override Vector3[] GetRightHandSide(float t, Vector3[] q, Vector3[] deltaQ, float dt, float qScale)
	{
		return null;
	}

	[Token(Token = "0x6005AAD")]
	[Address(RVA = "0xF1C1E0", Offset = "0xF1AFE0", Length = "0x7A")]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005AAE")]
	[Address(RVA = "0xF1C260", Offset = "0xF1B060", Length = "0x81")]
	public void SetPosition(Vector3 position)
	{
	}

	[Token(Token = "0x6005AAF")]
	[Address(RVA = "0xF1C2F0", Offset = "0xF1B0F0", Length = "0x35")]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005AB0")]
	[Address(RVA = "0xF1C330", Offset = "0xF1B130", Length = "0x35")]
	public void SetVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x6005AB1")]
	[Address(RVA = "0xF1C370", Offset = "0xF1B170", Length = "0x77")]
	public void AddForce(Vector3 force)
	{
	}
}
