using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008C3")]
public class PlayerSpawn : MonoBehaviour
{
	[Token(Token = "0x4005B60")]
	[FieldOffset(Offset = "0x20")]
	public int m_StartTimeHour;

	[Token(Token = "0x4005B61")]
	[FieldOffset(Offset = "0x24")]
	public int m_StartTimeMinutes;

	[Token(Token = "0x4005B62")]
	[FieldOffset(Offset = "0x28")]
	public bool m_ForceStartWeather;

	[Token(Token = "0x4005B63")]
	[FieldOffset(Offset = "0x2C")]
	public WeatherStage m_StartWeather;

	[Token(Token = "0x6005079")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x600507A")]
	[Address(RVA = "0xE07650", Offset = "0xE06450", Length = "0x120")]
	public void SetStartTimeAndWeather()
	{
	}

	[Token(Token = "0x600507B")]
	[Address(RVA = "0xE07780", Offset = "0xE06580", Length = "0x81")]
	private void SetTime()
	{
	}

	[Token(Token = "0x600507C")]
	[Address(RVA = "0xE07810", Offset = "0xE06610", Length = "0xAE")]
	private void SetWeather()
	{
	}

	[Token(Token = "0x600507D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerSpawn()
	{
	}
}
