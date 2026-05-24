using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001D3")]
public class BearHuntWaypoint : MissionWaypoint
{
	[Range(0f, 100f)]
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x28")]
	public float m_ChanceFlee;

	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x2C")]
	public WeatherStage m_WeatherStage;

	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x30")]
	public float m_WeatherTransitionSeconds;

	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x62BDA0", Offset = "0x62ABA0", Length = "0x51")]
	public BearHuntWaypoint()
	{
	}
}
