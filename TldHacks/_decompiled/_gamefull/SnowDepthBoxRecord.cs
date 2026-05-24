using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A4")]
public class SnowDepthBoxRecord : SnowDepthTriggerRecord
{
	[Token(Token = "0x400207C")]
	[FieldOffset(Offset = "0x18")]
	private BoxCollider m_Box;

	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public SnowDepthBoxRecord(SnowDepth sd, BoxCollider box)
		: base(null)
	{
	}

	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x789E70", Offset = "0x788C70", Length = "0x3E9")]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
