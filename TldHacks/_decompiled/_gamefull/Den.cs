using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200016F")]
public class Den : MonoBehaviour
{
	[Range(0f, 48f)]
	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x20")]
	public float m_MinSleepHoursDay;

	[Range(0f, 48f)]
	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxSleepHoursDay;

	[Range(0f, 48f)]
	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x28")]
	public float m_MinSleepHoursNight;

	[Range(0f, 48f)]
	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxSleepHoursNight;

	[Range(0f, 100f)]
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x30")]
	public float m_ChanceSleepAfterWaypointsLoopDay;

	[Range(0f, 100f)]
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x34")]
	public float m_ChanceSleepAfterWaypointsLoopNight;

	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x5E9000", Offset = "0x5E7E00", Length = "0x6D")]
	public Den()
	{
	}
}
