using Cpp2ILInjected;

[Token(Token = "0x200081A")]
public class HuntedPart2WaypointControllerSaveData
{
	[Token(Token = "0x4005562")]
	[FieldOffset(Offset = "0x10")]
	public int m_CurrentWaypoint;

	[Token(Token = "0x4005563")]
	[FieldOffset(Offset = "0x14")]
	public int m_CurrentWeatherStage;

	[Token(Token = "0x4005564")]
	[FieldOffset(Offset = "0x18")]
	public HuntedPart2WaypointControllerState m_State;

	[Token(Token = "0x6004B5D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HuntedPart2WaypointControllerSaveData()
	{
	}
}
