using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Events;
using TLD.Gameplay;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000737")]
public class ExperienceModeManager : MonoBehaviour
{
	[Token(Token = "0x4004C68")]
	private const ExperienceModeType DefaultExperienceModeType = ExperienceModeType.Voyageur;

	[SerializeField]
	[Token(Token = "0x4004C69")]
	[FieldOffset(Offset = "0x20")]
	private GameEvent m_ExperienceModeChanged;

	[SerializeField]
	[Token(Token = "0x4004C6A")]
	[FieldOffset(Offset = "0x28")]
	private AssetLabelReference m_GameModeLabel;

	[SerializeField]
	[Token(Token = "0x4004C6B")]
	[FieldOffset(Offset = "0x30")]
	private AssetReferenceGameModeConfig m_MenuGameModeReference;

	[Token(Token = "0x4004C6C")]
	[FieldOffset(Offset = "0x38")]
	private AsyncOperationHandle<IList<GameModeConfig>> m_GameModesHandle;

	[Token(Token = "0x4004C6D")]
	private static readonly ExperienceModeManagerSaveDataProxy m_ExperienceModeManagerSaveDataProxy;

	[Token(Token = "0x4004C6E")]
	private static GameModeConfig s_MainMenuGameMode;

	[Token(Token = "0x4004C6F")]
	private static GameModeConfig s_CurrentGameMode;

	[Token(Token = "0x1700031E")]
	[field: Token(Token = "0x4004C70")]
	public static ExperienceModeManager Instance
	{
		[Token(Token = "0x600411D")]
		[Address(RVA = "0xC1AD50", Offset = "0xC19B50", Length = "0x54")]
		get;
		[Token(Token = "0x600411E")]
		[Address(RVA = "0xC1ADB0", Offset = "0xC19BB0", Length = "0xB7")]
		private set;
	}

	[Token(Token = "0x600411F")]
	[Address(RVA = "0xC1AE70", Offset = "0xC19C70", Length = "0x10C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004120")]
	[Address(RVA = "0xC1AF80", Offset = "0xC19D80", Length = "0x94")]
	private void Start()
	{
	}

	[Token(Token = "0x6004121")]
	[Address(RVA = "0xC1B020", Offset = "0xC19E20", Length = "0x11D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004122")]
	[Address(RVA = "0xC1B140", Offset = "0xC19F40", Length = "0x293")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004123")]
	[Address(RVA = "0xC1B3E0", Offset = "0xC1A1E0", Length = "0x167")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004124")]
	[Address(RVA = "0xC1B550", Offset = "0xC1A350", Length = "0x361")]
	public static GameModeConfig GetGameModeFromName(string gameModeName)
	{
		return null;
	}

	[Token(Token = "0x6004125")]
	[Address(RVA = "0xC1B8C0", Offset = "0xC1A6C0", Length = "0x203")]
	public static ExperienceModeType GetCurrentExperienceModeType()
	{
		return default(ExperienceModeType);
	}

	[Token(Token = "0x6004126")]
	[Address(RVA = "0xC1BAD0", Offset = "0xC1A8D0", Length = "0x54")]
	public static GameModeConfig GetCurrentGameModeConfig()
	{
		return null;
	}

	[Token(Token = "0x6004127")]
	[Address(RVA = "0xC1BB30", Offset = "0xC1A930", Length = "0x1A3")]
	public void SetMainMenuConfig()
	{
	}

	[Token(Token = "0x6004128")]
	[Address(RVA = "0xC1BCE0", Offset = "0xC1AAE0", Length = "0x45C")]
	public void SetGameModeConfig(GameModeConfig gameModeConfig)
	{
	}

	[Token(Token = "0x6004129")]
	[Address(RVA = "0xC1C140", Offset = "0xC1AF40", Length = "0x3F")]
	public IList<GameModeConfig> GetAvailableGameModes()
	{
		return null;
	}

	[Token(Token = "0x600412A")]
	[Address(RVA = "0xC1C180", Offset = "0xC1AF80", Length = "0x15B")]
	public bool IsChallengeActive()
	{
		return false;
	}

	[Token(Token = "0x600412B")]
	[Address(RVA = "0xC1C2E0", Offset = "0xC1B0E0", Length = "0x12F")]
	public ExperienceMode GetCurrentExperienceMode()
	{
		return null;
	}

	[Token(Token = "0x600412C")]
	[Address(RVA = "0xC1C410", Offset = "0xC1B210", Length = "0x23")]
	public bool SetCurrentCustomModeString(string inputString)
	{
		return false;
	}

	[Token(Token = "0x600412D")]
	[Address(RVA = "0xC1C440", Offset = "0xC1B240", Length = "0xE0")]
	public float GetDecayScale()
	{
		return 0f;
	}

	[Token(Token = "0x600412E")]
	[Address(RVA = "0xC1C520", Offset = "0xC1B320", Length = "0xDD")]
	public float GetCalorieBurnScale()
	{
		return 0f;
	}

	[Token(Token = "0x600412F")]
	[Address(RVA = "0xC1C600", Offset = "0xC1B400", Length = "0xDD")]
	public float GetThirstRateScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004130")]
	[Address(RVA = "0xC1C6E0", Offset = "0xC1B4E0", Length = "0xDD")]
	public float GetFreezingRateScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004131")]
	[Address(RVA = "0xC1C7C0", Offset = "0xC1B5C0", Length = "0xDD")]
	public float GetFatigueRateScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004132")]
	[Address(RVA = "0xC1C8A0", Offset = "0xC1B6A0", Length = "0xDD")]
	public float GetConditonRecoveryFromRestScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004133")]
	[Address(RVA = "0xC1C980", Offset = "0xC1B780", Length = "0xDD")]
	public float GetConditonRecoveryWhileAwakeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004134")]
	[Address(RVA = "0xC1CA60", Offset = "0xC1B860", Length = "0xDD")]
	public float GetWeatherDurationScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004135")]
	[Address(RVA = "0xC1CB40", Offset = "0xC1B940", Length = "0xDD")]
	public float GetChanceOfBlizzardScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004136")]
	[Address(RVA = "0xC1CC20", Offset = "0xC1BA20", Length = "0xDD")]
	public float GetTimeOfDayScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004137")]
	[Address(RVA = "0xC1CD00", Offset = "0xC1BB00", Length = "0xE0")]
	public float GetSpawnRegionChanceActiveScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004138")]
	[Address(RVA = "0xC1CDE0", Offset = "0xC1BBE0", Length = "0xE0")]
	public float GetGearSpawnChanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004139")]
	[Address(RVA = "0xC1CEC0", Offset = "0xC1BCC0", Length = "0xD8")]
	public int GetReduceMaxItemsInContainer()
	{
		return 0;
	}

	[Token(Token = "0x600413A")]
	[Address(RVA = "0xC1CFA0", Offset = "0xC1BDA0", Length = "0xD8")]
	public int GetChanceForEmptyContainer()
	{
		return 0;
	}

	[Token(Token = "0x600413B")]
	[Address(RVA = "0xC1D080", Offset = "0xC1BE80", Length = "0xE0")]
	public float GetClosestSpawnDistanceAfterTransitionScale()
	{
		return 0f;
	}

	[Token(Token = "0x600413C")]
	[Address(RVA = "0xC1D160", Offset = "0xC1BF60", Length = "0xE0")]
	public float GetSmellRangeScale()
	{
		return 0f;
	}

	[Token(Token = "0x600413D")]
	[Address(RVA = "0xC1D240", Offset = "0xC1C040", Length = "0xE0")]
	public float GetStruggleTapStrenthScale()
	{
		return 0f;
	}

	[Token(Token = "0x600413E")]
	[Address(RVA = "0xC1D320", Offset = "0xC1C120", Length = "0xE0")]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return 0f;
	}

	[Token(Token = "0x600413F")]
	[Address(RVA = "0xC1D400", Offset = "0xC1C200", Length = "0xE0")]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004140")]
	[Address(RVA = "0xC1D4E0", Offset = "0xC1C2E0", Length = "0xE0")]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004141")]
	[Address(RVA = "0xC1D5C0", Offset = "0xC1C3C0", Length = "0xE0")]
	public float GetStugglePlayerPercentLossFromBearScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004142")]
	[Address(RVA = "0xC1D6A0", Offset = "0xC1C4A0", Length = "0x1D2")]
	public float GetOutdoorTempDropCelcius(float numDays)
	{
		return 0f;
	}

	[Token(Token = "0x6004143")]
	[Address(RVA = "0xC1D880", Offset = "0xC1C680", Length = "0x1D7")]
	public float GetRespawnHoursScale(float numDays)
	{
		return 0f;
	}

	[Token(Token = "0x6004144")]
	[Address(RVA = "0xC1DA60", Offset = "0xC1C860", Length = "0x1D7")]
	public float GetFishCatchTimeScale(float numDays)
	{
		return 0f;
	}

	[Token(Token = "0x6004145")]
	[Address(RVA = "0xC1DC40", Offset = "0xC1CA40", Length = "0x1D7")]
	public float GetRadialRespawnTimeScale(float numDays)
	{
		return 0f;
	}

	[Token(Token = "0x6004146")]
	[Address(RVA = "0xC1DE20", Offset = "0xC1CC20", Length = "0xE0")]
	public float GetNumHoursWarmForHypothermiaCureScale()
	{
		return 0f;
	}

	[Token(Token = "0x6004147")]
	[Address(RVA = "0xC1DF00", Offset = "0xC1CD00", Length = "0x116")]
	public bool GetWildlifeNotAttackUnprovoked()
	{
		return false;
	}

	[Token(Token = "0x6004148")]
	[Address(RVA = "0xC1E020", Offset = "0xC1CE20", Length = "0xD9")]
	public bool GetWildlifeInterruptRest()
	{
		return false;
	}

	[Token(Token = "0x6004149")]
	[Address(RVA = "0xC1E100", Offset = "0xC1CF00", Length = "0xD6")]
	public bool GetWeatherWindForceCalm()
	{
		return false;
	}

	[Token(Token = "0x600414A")]
	[Address(RVA = "0xC1E1E0", Offset = "0xC1CFE0", Length = "0x233")]
	public CustomExperienceMode GetCustomMode()
	{
		return null;
	}

	[Token(Token = "0x600414B")]
	[Address(RVA = "0xC1E420", Offset = "0xC1D220", Length = "0x1A9")]
	public bool InCustomMode()
	{
		return false;
	}

	[Token(Token = "0x600414C")]
	[Address(RVA = "0xC1E5D0", Offset = "0xC1D3D0", Length = "0x95")]
	public float GetProportionalReduceMaxItems()
	{
		return 0f;
	}

	[Token(Token = "0x600414D")]
	[Address(RVA = "0xC1E670", Offset = "0xC1D470", Length = "0x6A")]
	public float GetCustomAuroraChanceModifier()
	{
		return 0f;
	}

	[Token(Token = "0x600414E")]
	[Address(RVA = "0xC1E6E0", Offset = "0xC1D4E0", Length = "0xD8")]
	public float GetDaysUntilForceAurora()
	{
		return 0f;
	}

	[Token(Token = "0x600414F")]
	[Address(RVA = "0xC1E7C0", Offset = "0xC1D5C0", Length = "0x6A")]
	public float GetCustomWindSpeedModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004150")]
	[Address(RVA = "0xC1E830", Offset = "0xC1D630", Length = "0x6A")]
	public float GetCustomWindChangeFrequencyModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004151")]
	[Address(RVA = "0xC1E8A0", Offset = "0xC1D6A0", Length = "0x6A")]
	public float GetCustomBloodScentModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004152")]
	[Address(RVA = "0xC1E910", Offset = "0xC1D710", Length = "0x6A")]
	public float GetCustomWildlifeDetectionModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004153")]
	[Address(RVA = "0xC1E980", Offset = "0xC1D780", Length = "0x8A")]
	public float GetCustomWolfFleeModifier(WolfType wolfType)
	{
		return 0f;
	}

	[Token(Token = "0x6004154")]
	[Address(RVA = "0xC1EA10", Offset = "0xC1D810", Length = "0x6A")]
	public float GetCustomPlantSpawnModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004155")]
	[Address(RVA = "0xC1EA80", Offset = "0xC1D880", Length = "0x6A")]
	public float GetCustomWildlifeRespawnTimeModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6004156")]
	[Address(RVA = "0xC1EAF0", Offset = "0xC1D8F0", Length = "0x50")]
	public ExperienceModeType GetCustomLootXPType()
	{
		return default(ExperienceModeType);
	}

	[Token(Token = "0x6004157")]
	[Address(RVA = "0xC1EB50", Offset = "0xC1D950", Length = "0x2F3")]
	private CustomExperienceMode GetCustomExperienceModeDefinition()
	{
		return null;
	}

	[Token(Token = "0x6004158")]
	[Address(RVA = "0xC1EE50", Offset = "0xC1DC50", Length = "0x19")]
	private string GetCurrentCustomModeString()
	{
		return null;
	}

	[Token(Token = "0x6004159")]
	[Address(RVA = "0xC1EE70", Offset = "0xC1DC70", Length = "0xD9")]
	private bool GetStandardModeWildlifeNotAttackUnprovoked()
	{
		return false;
	}

	[Token(Token = "0x600415A")]
	[Address(RVA = "0xC1EF50", Offset = "0xC1DD50", Length = "0x2A")]
	private float GetCustomRegularWolfFleeModifier()
	{
		return 0f;
	}

	[Token(Token = "0x600415B")]
	[Address(RVA = "0xC1EF80", Offset = "0xC1DD80", Length = "0x53")]
	private float GetCustomTimberWolfFleeModifier()
	{
		return 0f;
	}

	[Token(Token = "0x600415C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExperienceModeManager()
	{
	}
}
