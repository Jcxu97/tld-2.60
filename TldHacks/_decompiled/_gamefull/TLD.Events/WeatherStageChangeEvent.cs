using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Events;

[CreateAssetMenu(menuName = "Events/Weather Stage Changed Event")]
[Token(Token = "0x20013DE")]
public class WeatherStageChangeEvent : GameEvent
{
	[NonSerialized]
	[Token(Token = "0x400918D")]
	[FieldOffset(Offset = "0x20")]
	public WeatherStage m_CurrentWeatherStage;

	[Token(Token = "0x6007EBA")]
	[Address(RVA = "0x11E5DE0", Offset = "0x11E4BE0", Length = "0xE")]
	public WeatherStageChangeEvent()
	{
	}
}
