using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000839")]
public class MissionWaypoint : MonoBehaviour
{
	[Token(Token = "0x4005633")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Token(Token = "0x6004C6B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6004C6C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MissionWaypoint()
	{
	}
}
