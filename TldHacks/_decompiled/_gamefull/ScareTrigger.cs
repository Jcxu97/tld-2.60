using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009D3")]
public class ScareTrigger : MonoBehaviour
{
	[Token(Token = "0x40063D0")]
	[FieldOffset(Offset = "0x20")]
	public FlareGunRoundItem m_FlareGunRound;

	[Token(Token = "0x40063D1")]
	[FieldOffset(Offset = "0x28")]
	public float m_FleeRadiusScalarInFlight;

	[Token(Token = "0x40063D2")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FleeRadiusScalarOnGround;

	[Token(Token = "0x40063D3")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_OldPos;

	[Token(Token = "0x60056C4")]
	[Address(RVA = "0xEC07E0", Offset = "0xEBF5E0", Length = "0x354")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60056C5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ScareTrigger()
	{
	}
}
