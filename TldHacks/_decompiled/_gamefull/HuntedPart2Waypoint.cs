using Cpp2ILInjected;

[Token(Token = "0x2000817")]
public class HuntedPart2Waypoint : MissionWaypoint
{
	[Token(Token = "0x2000818")]
	public enum WaypointType
	{
		[Token(Token = "0x400555A")]
		AttackOnDetect,
		[Token(Token = "0x400555B")]
		FleeOnDetect,
		[Token(Token = "0x400555C")]
		RunThrough,
		[Token(Token = "0x400555D")]
		FinalAmbush
	}

	[Token(Token = "0x4005557")]
	[FieldOffset(Offset = "0x28")]
	public WaypointType m_WaypointType;

	[Token(Token = "0x4005558")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_IncrementWeatherStage;

	[Token(Token = "0x6004B5B")]
	[Address(RVA = "0xD521B0", Offset = "0xD50FB0", Length = "0x3F4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004B5C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HuntedPart2Waypoint()
	{
	}
}
