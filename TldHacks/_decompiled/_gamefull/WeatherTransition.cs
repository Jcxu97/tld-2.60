using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200032D")]
public class WeatherTransition : MonoBehaviour
{
	[Token(Token = "0x4001C60")]
	public static float m_WeatherTransitionTimeScalar;

	[Token(Token = "0x4001C61")]
	public static bool m_SuppressBlizzards;

	[Token(Token = "0x4001C62")]
	[FieldOffset(Offset = "0x20")]
	public WeatherStage m_DefaultStartWeather;

	[Token(Token = "0x4001C63")]
	[FieldOffset(Offset = "0x28")]
	private WeatherSetData m_CurrentWeatherSet;

	[Token(Token = "0x4001C64")]
	[FieldOffset(Offset = "0x30")]
	private WeatherStage m_PreviousWeatherSetType;

	[Token(Token = "0x4001C65")]
	[FieldOffset(Offset = "0x34")]
	private WeatherStage m_UnmanagedWeatherStage;

	[Token(Token = "0x4001C66")]
	[FieldOffset(Offset = "0x38")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4001C67")]
	[FieldOffset(Offset = "0x40")]
	private readonly WeatherTransitionWeights m_Weights;

	[Token(Token = "0x4001C68")]
	private static WeatherTransitionSaveDataProxy m_WeatherTransitionSaveDataProxy;

	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x746600", Offset = "0x745400", Length = "0x6D")]
	public void Start()
	{
	}

	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x746670", Offset = "0x745470", Length = "0x10E")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x746780", Offset = "0x745580", Length = "0x4C5")]
	public void Update()
	{
	}

	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x746C50", Offset = "0x745A50", Length = "0x3D8")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x747030", Offset = "0x745E30", Length = "0x30B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x747340", Offset = "0x746140", Length = "0x43B")]
	private bool UpdateWeights(WeatherTransitionWeights customWeights)
	{
		return false;
	}

	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x747780", Offset = "0x746580", Length = "0x51C")]
	public void ChooseNextWeatherSet(WeatherTransitionWeights customWeights = null, bool forceClear = false, bool forceAurora = false)
	{
	}

	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x747E60", Offset = "0x746C60", Length = "0x150")]
	public bool ActivateWeatherSet(string customTypeName)
	{
		return false;
	}

	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x747FC0", Offset = "0x746DC0", Length = "0xA7")]
	public void ActivateWeatherSetImmediate(WeatherStage reqType)
	{
	}

	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x748070", Offset = "0x746E70", Length = "0x1BC")]
	public void ActivateWeatherSetAtFrac(WeatherStage reqType, float startAtFrac)
	{
	}

	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x748230", Offset = "0x747030", Length = "0x5D")]
	public void ActivateWeatherSet(WeatherStage reqType)
	{
	}

	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x748290", Offset = "0x747090", Length = "0x528")]
	public void ActivateWeatherSet(WeatherSetData ws, float startAtFrac, WeatherStage previousType = WeatherStage.Undefined)
	{
	}

	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x7487C0", Offset = "0x7475C0", Length = "0x5E")]
	public void ActivateDefaultWeatherSet()
	{
	}

	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x748820", Offset = "0x747620", Length = "0x14E")]
	public void ForceTransitionToWeatherStage(int forceIndex)
	{
	}

	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x748970", Offset = "0x747770", Length = "0xEE")]
	public void ForceNextWeatherStage(int forceIndex = -1)
	{
	}

	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x748A60", Offset = "0x747860", Length = "0x1E5")]
	public void ForceUnmanagedWeatherStage(WeatherStage ws, float transitionTime)
	{
	}

	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x748C50", Offset = "0x747A50", Length = "0x179")]
	public string GetDebugString()
	{
		return null;
	}

	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x748DD0", Offset = "0x747BD0", Length = "0xCA")]
	public bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x748EA0", Offset = "0x747CA0", Length = "0x1A4")]
	public void OverrideDurationOfStageInCurrentWeatherSet(WeatherStage weatherType, float duration)
	{
	}

	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x749050", Offset = "0x747E50", Length = "0x181")]
	public float GetDurationOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return 0f;
	}

	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x7491E0", Offset = "0x747FE0", Length = "0x135")]
	public float GetElapsedTimeOfStageInCurrentWeatherSet(WeatherStage weatherType)
	{
		return 0f;
	}

	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x749320", Offset = "0x748120", Length = "0xD2")]
	public WeatherTransition()
	{
	}
}
