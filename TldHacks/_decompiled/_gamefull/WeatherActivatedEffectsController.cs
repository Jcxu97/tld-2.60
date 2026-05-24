using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Events;
using UnityEngine;

[Token(Token = "0x2000412")]
public class WeatherActivatedEffectsController : MonoBehaviour
{
	[Tooltip("Duplicate entries are not allowed")]
	[SerializeField]
	[Token(Token = "0x40024C5")]
	[FieldOffset(Offset = "0x20")]
	private WeatherActivatedEffectData[] m_Data;

	[SerializeField]
	[Token(Token = "0x40024C6")]
	[FieldOffset(Offset = "0x28")]
	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	[Token(Token = "0x40024C7")]
	[FieldOffset(Offset = "0x30")]
	private WeatherStage m_LastWeatherStage;

	[Token(Token = "0x40024C8")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<WeatherActivatedEffectData, WeatherActivatedEffect> m_LoadedInstances;

	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x7CCE80", Offset = "0x7CBC80", Length = "0x223")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6001ED2")]
	[Address(RVA = "0x7CD0B0", Offset = "0x7CBEB0", Length = "0x140")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0x7CD200", Offset = "0x7CC000", Length = "0x179")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x7CD380", Offset = "0x7CC180", Length = "0x454")]
	private void OnWeatherChanged()
	{
	}

	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x7CD7E0", Offset = "0x7CC5E0", Length = "0x450")]
	private void StopAndReleaseInstances(bool immediate)
	{
	}

	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0x7CDC40", Offset = "0x7CCA40", Length = "0xF2")]
	public WeatherActivatedEffectsController()
	{
	}
}
