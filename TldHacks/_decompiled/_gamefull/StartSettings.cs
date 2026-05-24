using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x20008D6")]
public class StartSettings : MonoBehaviour
{
	[Token(Token = "0x4005C6F")]
	[FieldOffset(Offset = "0x20")]
	public bool m_RandomSpawning;

	[Token(Token = "0x4005C70")]
	[FieldOffset(Offset = "0x21")]
	public bool m_RandomWeather;

	[Token(Token = "0x4005C71")]
	[FieldOffset(Offset = "0x22")]
	public bool m_RandomTimeOfDay;

	[Token(Token = "0x4005C72")]
	[FieldOffset(Offset = "0x23")]
	public bool m_LockWeather;

	[Token(Token = "0x4005C73")]
	[FieldOffset(Offset = "0x24")]
	public bool m_LockTimeOfDay;

	[Token(Token = "0x4005C74")]
	[FieldOffset(Offset = "0x28")]
	public WeatherStage m_LockedWeather;

	[Token(Token = "0x4005C75")]
	[FieldOffset(Offset = "0x30")]
	public string m_LockedTimeOfDay;

	[Token(Token = "0x4005C76")]
	[FieldOffset(Offset = "0x38")]
	public int m_WeatherClearWeight;

	[Token(Token = "0x4005C77")]
	[FieldOffset(Offset = "0x3C")]
	public int m_WeatherCloudyWeight;

	[Token(Token = "0x4005C78")]
	[FieldOffset(Offset = "0x40")]
	public int m_WeatherLightSnowWeight;

	[Token(Token = "0x4005C79")]
	[FieldOffset(Offset = "0x44")]
	public int m_WeatherHeavySnowWeight;

	[Token(Token = "0x4005C7A")]
	[FieldOffset(Offset = "0x48")]
	public int m_WeatherBlizzardWeight;

	[Token(Token = "0x4005C7B")]
	[FieldOffset(Offset = "0x4C")]
	public int m_WeatherLightFogWeight;

	[FormerlySerializedAs("m_WeatherFoggyWeight")]
	[Token(Token = "0x4005C7C")]
	[FieldOffset(Offset = "0x50")]
	public int m_WeatherDenseFogWeight;

	[Token(Token = "0x4005C7D")]
	[FieldOffset(Offset = "0x54")]
	public int m_WeatherElectrostaticFogWeight;

	[Token(Token = "0x4005C7E")]
	[FieldOffset(Offset = "0x58")]
	public int m_WeatherAurora;

	[Token(Token = "0x4005C7F")]
	[FieldOffset(Offset = "0x5C")]
	public int m_TimeOfDayDawnWeight;

	[Token(Token = "0x4005C80")]
	[FieldOffset(Offset = "0x60")]
	public int m_TimeOfDayMorningWeight;

	[Token(Token = "0x4005C81")]
	[FieldOffset(Offset = "0x64")]
	public int m_TimeOfDayAfternoonWeight;

	[Token(Token = "0x4005C82")]
	[FieldOffset(Offset = "0x68")]
	public int m_TimeOfDayDuskWeight;

	[Token(Token = "0x4005C83")]
	[FieldOffset(Offset = "0x6C")]
	public int m_TimeOfDayNightWeight;

	[Token(Token = "0x4005C84")]
	[FieldOffset(Offset = "0x70")]
	public GameplayTag m_ForceMorningStartTag;

	[Token(Token = "0x4005C85")]
	[FieldOffset(Offset = "0x80")]
	private readonly WeatherTransitionWeights m_WeatherWeights;

	[Token(Token = "0x4005C86")]
	[FieldOffset(Offset = "0x88")]
	private int m_SumWeatherWeights;

	[Token(Token = "0x600513E")]
	[Address(RVA = "0xE213B0", Offset = "0xE201B0", Length = "0x1BC")]
	private void InitializeWeatherWeights()
	{
	}

	[Token(Token = "0x600513F")]
	[Address(RVA = "0xE21570", Offset = "0xE20370", Length = "0x5A1")]
	public string PickRandomSpawnPointName()
	{
		return null;
	}

	[Token(Token = "0x6005140")]
	[Address(RVA = "0xE21B20", Offset = "0xE20920", Length = "0xD")]
	public bool ShouldSetWeather()
	{
		return false;
	}

	[Token(Token = "0x6005141")]
	[Address(RVA = "0xE21B30", Offset = "0xE20930", Length = "0x1BA")]
	public void SetWeather()
	{
	}

	[Token(Token = "0x6005142")]
	[Address(RVA = "0xE21CF0", Offset = "0xE20AF0", Length = "0x148")]
	private void SetRandomWeather()
	{
	}

	[Token(Token = "0x6005143")]
	[Address(RVA = "0xE21E40", Offset = "0xE20C40", Length = "0x70")]
	private void SetLockedWeather()
	{
	}

	[Token(Token = "0x6005144")]
	[Address(RVA = "0xE21EC0", Offset = "0xE20CC0", Length = "0xD")]
	public bool ShouldSetTime()
	{
		return false;
	}

	[Token(Token = "0x6005145")]
	[Address(RVA = "0xE21ED0", Offset = "0xE20CD0", Length = "0xED")]
	public void SetTime()
	{
	}

	[Token(Token = "0x6005146")]
	[Address(RVA = "0xE21FC0", Offset = "0xE20DC0", Length = "0x650")]
	private void SetRandomTime()
	{
	}

	[Token(Token = "0x6005147")]
	[Address(RVA = "0xE22620", Offset = "0xE21420", Length = "0xC3")]
	private void SetLockedTime()
	{
	}

	[Token(Token = "0x6005148")]
	[Address(RVA = "0xE226F0", Offset = "0xE214F0", Length = "0xD2")]
	public StartSettings()
	{
	}
}
