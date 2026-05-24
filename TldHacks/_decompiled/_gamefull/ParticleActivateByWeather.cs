using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003E3")]
public class ParticleActivateByWeather : ParticleActivateBase
{
	[SerializeField]
	[Token(Token = "0x40022ED")]
	[FieldOffset(Offset = "0x30")]
	private WeatherStage[] m_ValidWeatherStages;

	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0x7B3120", Offset = "0x7B1F20", Length = "0xDC")]
	public override bool CanBeActive()
	{
		return false;
	}

	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public ParticleActivateByWeather()
	{
	}
}
