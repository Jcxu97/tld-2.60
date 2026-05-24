using Cpp2ILInjected;

[Token(Token = "0x20008B6")]
public class PlayerGameStatsProxy
{
	[Token(Token = "0x4005AE1")]
	[FieldOffset(Offset = "0x10")]
	public float m_CaloriesBurned;

	[Token(Token = "0x4005AE2")]
	[FieldOffset(Offset = "0x14")]
	public float m_CaloriesEaten;

	[Token(Token = "0x4005AE3")]
	[FieldOffset(Offset = "0x18")]
	public float m_BodyTempHigh;

	[Token(Token = "0x4005AE4")]
	[FieldOffset(Offset = "0x1C")]
	public float m_BodyTempLow;

	[Token(Token = "0x4005AE5")]
	[FieldOffset(Offset = "0x20")]
	public float m_DistanceTravelledDay;

	[Token(Token = "0x4005AE6")]
	[FieldOffset(Offset = "0x24")]
	public float m_DistanceTravelledNight;

	[Token(Token = "0x4005AE7")]
	[FieldOffset(Offset = "0x28")]
	public float m_ConditionGained;

	[Token(Token = "0x4005AE8")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ConditionLost;

	[Token(Token = "0x4005AE9")]
	[FieldOffset(Offset = "0x30")]
	public float m_CaloriesExpendedToday;

	[Token(Token = "0x600501A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerGameStatsProxy()
	{
	}
}
