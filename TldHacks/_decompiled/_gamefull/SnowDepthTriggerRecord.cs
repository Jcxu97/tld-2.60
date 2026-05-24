using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A2")]
public abstract class SnowDepthTriggerRecord
{
	[Token(Token = "0x400207A")]
	[FieldOffset(Offset = "0x10")]
	public SnowDepth m_SnowDepthObject;

	[Token(Token = "0x6001CC3")]
	[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
	public SnowDepthTriggerRecord(SnowDepth sd)
	{
	}

	[Token(Token = "0x6001CC4")]
	public abstract float GetDepthFracAtPosition(Vector3 pos);

	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x789860", Offset = "0x788660", Length = "0x51")]
	protected float GetScaledDepthFrac(float frac)
	{
		return 0f;
	}
}
