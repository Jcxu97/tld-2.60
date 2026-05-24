using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A5")]
public class SnowDepthSphereRecord : SnowDepthTriggerRecord
{
	[Token(Token = "0x400207D")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider m_Sphere;

	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public SnowDepthSphereRecord(SnowDepth sd, SphereCollider sphere)
		: base(null)
	{
	}

	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0x78A260", Offset = "0x789060", Length = "0x2FC")]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
