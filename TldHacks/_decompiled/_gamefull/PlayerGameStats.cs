using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008B7")]
public class PlayerGameStats : MonoBehaviour
{
	[Token(Token = "0x4005AEA")]
	[FieldOffset(Offset = "0x20")]
	public float m_CaloriesBurned;

	[Token(Token = "0x4005AEB")]
	[FieldOffset(Offset = "0x24")]
	public float m_CaloriesEaten;

	[Token(Token = "0x4005AEC")]
	[FieldOffset(Offset = "0x28")]
	public float m_BodyTempHigh;

	[Token(Token = "0x4005AED")]
	[FieldOffset(Offset = "0x2C")]
	public float m_BodyTempLow;

	[Token(Token = "0x4005AEE")]
	[FieldOffset(Offset = "0x30")]
	public float m_DistanceTraveledDay;

	[Token(Token = "0x4005AEF")]
	[FieldOffset(Offset = "0x34")]
	public float m_DistanceTravelledNight;

	[Token(Token = "0x4005AF0")]
	[FieldOffset(Offset = "0x38")]
	public float m_ConditionGained;

	[Token(Token = "0x4005AF1")]
	[FieldOffset(Offset = "0x3C")]
	public float m_ConditionLost;

	[Token(Token = "0x4005AF2")]
	[FieldOffset(Offset = "0x40")]
	public float m_CaloriesExpendedToday;

	[Token(Token = "0x4005AF3")]
	[FieldOffset(Offset = "0x44")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4005AF4")]
	private static PlayerGameStatsProxy m_PlayerGameStatsProxy;

	[Token(Token = "0x600501B")]
	[Address(RVA = "0xDFE830", Offset = "0xDFD630", Length = "0x28")]
	public void Start()
	{
	}

	[Token(Token = "0x600501C")]
	[Address(RVA = "0xDFE860", Offset = "0xDFD660", Length = "0x1DF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600501D")]
	[Address(RVA = "0xDFEA40", Offset = "0xDFD840", Length = "0xEE")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600501E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerGameStats()
	{
	}
}
