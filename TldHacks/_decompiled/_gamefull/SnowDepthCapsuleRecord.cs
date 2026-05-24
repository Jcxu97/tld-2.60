using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A3")]
public class SnowDepthCapsuleRecord : SnowDepthTriggerRecord
{
	[Token(Token = "0x400207B")]
	[FieldOffset(Offset = "0x18")]
	private CapsuleCollider m_Capsule;

	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public SnowDepthCapsuleRecord(SnowDepth sd, CapsuleCollider capsule)
		: base(null)
	{
	}

	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x7898C0", Offset = "0x7886C0", Length = "0x5A4")]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
