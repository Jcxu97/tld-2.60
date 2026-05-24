using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000304")]
public class InteriorWeatherController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000305")]
	public struct InteriorWeatherSet
	{
		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x0")]
		public WeatherStage m_WeatherType;

		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x8")]
		public GameObject m_WeatherHierarchy;
	}

	[Token(Token = "0x4001A8D")]
	[FieldOffset(Offset = "0x20")]
	public List<InteriorWeatherSet> m_InteriorWeatherList;

	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x6F71F0", Offset = "0x6F5FF0", Length = "0x176")]
	public void SetInteriorWeather(WeatherStage currentWeatherStage)
	{
	}

	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InteriorWeatherController()
	{
	}
}
