using Cpp2ILInjected;
using TLD.Events;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200032A")]
public class WeatherStageEventListener : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001C4C")]
	[FieldOffset(Offset = "0x20")]
	private WeatherStage m_WeatherStage;

	[SerializeField]
	[Token(Token = "0x4001C4D")]
	[FieldOffset(Offset = "0x28")]
	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	[SerializeField]
	[Token(Token = "0x4001C4E")]
	[FieldOffset(Offset = "0x30")]
	private UnityEvent<bool> m_WeatherStageActive;

	[Token(Token = "0x4001C4F")]
	[FieldOffset(Offset = "0x38")]
	private WeatherStage m_LastWeatherStage;

	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x7460F0", Offset = "0x744EF0", Length = "0x234")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x746330", Offset = "0x745130", Length = "0x165")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x7464A0", Offset = "0x7452A0", Length = "0x10F")]
	private void OnWeatherChanged()
	{
	}

	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x7465B0", Offset = "0x7453B0", Length = "0x4A")]
	public WeatherStageEventListener()
	{
	}
}
