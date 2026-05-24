using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AI;
using TLD.Gameplay.Tunable;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Trader;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Experience Modes/Experience Mode")]
[Token(Token = "0x2001478")]
public class ExperienceMode : ScriptableObject
{
	[Token(Token = "0x4009464")]
	[FieldOffset(Offset = "0x18")]
	public ExperienceModeType m_ModeType;

	[Token(Token = "0x4009465")]
	[FieldOffset(Offset = "0x1C")]
	public CustomTunableLMHV m_BaseResourceAvailability;

	[Token(Token = "0x4009466")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4009467")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Header("TOD and Weather")]
	[Range(0f, 10f)]
	[Token(Token = "0x4009468")]
	[FieldOffset(Offset = "0x30")]
	public float m_DayNightDurationScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009469")]
	[FieldOffset(Offset = "0x34")]
	public float m_WeatherDurationScale;

	[Range(0f, 10f)]
	[Token(Token = "0x400946A")]
	[FieldOffset(Offset = "0x38")]
	public float m_ChanceOfBlizzardScale;

	[Token(Token = "0x400946B")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_ForceStartTimeOfDay;

	[Token(Token = "0x400946C")]
	[FieldOffset(Offset = "0x40")]
	public string m_ExplicitStartTimeOfDay;

	[Token(Token = "0x400946D")]
	[FieldOffset(Offset = "0x48")]
	public bool m_ForceStartWeather;

	[Token(Token = "0x400946E")]
	[FieldOffset(Offset = "0x4C")]
	public CustomTunableWeather m_StartWeather;

	[Token(Token = "0x400946F")]
	[FieldOffset(Offset = "0x50")]
	public bool m_WeatherWindForceCalm;

	[Tooltip("Force aurora after X days if one hasn't happened yet. 0 = don't force")]
	[Token(Token = "0x4009470")]
	[FieldOffset(Offset = "0x54")]
	public float m_DaysUntilForceAurora;

	[Header("Player")]
	[Range(0f, 10f)]
	[Token(Token = "0x4009471")]
	[FieldOffset(Offset = "0x58")]
	public float m_CalorieBurnScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009472")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ThirstRateScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009473")]
	[FieldOffset(Offset = "0x60")]
	public float m_FreezingRateScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009474")]
	[FieldOffset(Offset = "0x64")]
	public float m_FatigueRateScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009475")]
	[FieldOffset(Offset = "0x68")]
	public float m_ConditonRecoveryFromRestScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009476")]
	[FieldOffset(Offset = "0x6C")]
	public float m_ConditonRecoveryWhileAwakeScale;

	[SerializeField]
	[Token(Token = "0x4009477")]
	[FieldOffset(Offset = "0x70")]
	private bool m_ShouldInterruptSleepIfFreezing;

	[Token(Token = "0x4009478")]
	[FieldOffset(Offset = "0x78")]
	public StartGearData m_StartGear;

	[Header("Life after Death")]
	[Token(Token = "0x4009479")]
	[FieldOffset(Offset = "0x80")]
	public LifeAfterDeathTunables m_LifeAfterDeathTunables;

	[Header("Trader")]
	[Token(Token = "0x400947A")]
	[FieldOffset(Offset = "0x158")]
	public TraderTunables m_TraderTunables;

	[Header("Afflictions")]
	[Token(Token = "0x400947B")]
	[FieldOffset(Offset = "0x18C")]
	public float m_FrostbiteDamageMultiplier;

	[Token(Token = "0x400947C")]
	[FieldOffset(Offset = "0x190")]
	public int m_IntestinalParasitesNumberOfRemedyDoses;

	[Token(Token = "0x400947D")]
	[FieldOffset(Offset = "0x194")]
	public int m_DaysBeforeCabinFeverRiskOnset;

	[Header("Nutrition")]
	[SerializeField]
	[Token(Token = "0x400947E")]
	[FieldOffset(Offset = "0x198")]
	private NutrientSettings m_NutrientSettings;

	[Header("Loot/Gear")]
	[Range(0f, 10f)]
	[Token(Token = "0x400947F")]
	[FieldOffset(Offset = "0x1A0")]
	public float m_DecayScale;

	[Range(0f, 1f)]
	[Token(Token = "0x4009480")]
	[FieldOffset(Offset = "0x1A4")]
	public float m_GearSpawnChanceScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009481")]
	[FieldOffset(Offset = "0x1A8")]
	public int m_ReduceMaxItemsInContainer;

	[Tooltip("Only used when ReduceMaxItemsInContainer results in empty container")]
	[Range(0f, 100f)]
	[Token(Token = "0x4009482")]
	[FieldOffset(Offset = "0x1AC")]
	public int m_ChanceForEmptyContainer;

	[Range(0f, 2f)]
	[Token(Token = "0x4009483")]
	[FieldOffset(Offset = "0x1B0")]
	public float m_TidelineSpawnModifier;

	[Header("AI")]
	[Token(Token = "0x4009484")]
	[FieldOffset(Offset = "0x1B4")]
	public bool m_NoPredatorsFirstDay;

	[SerializeField]
	[Token(Token = "0x4009485")]
	[FieldOffset(Offset = "0x1B8")]
	private List<SpawnRegionLevel> m_SpawnLevels;

	[Range(0f, 10f)]
	[Token(Token = "0x4009486")]
	[FieldOffset(Offset = "0x1C0")]
	public float m_SpawnRegionChanceActiveScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009487")]
	[FieldOffset(Offset = "0x1C4")]
	public float m_ClosestSpawnDistanceAfterTransitionScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009488")]
	[FieldOffset(Offset = "0x1C8")]
	public float m_SmellRangeScale;

	[Token(Token = "0x4009489")]
	[FieldOffset(Offset = "0x1CC")]
	public bool m_SetWildlifeNotAttackUnprovoked;

	[Token(Token = "0x400948A")]
	[FieldOffset(Offset = "0x1CD")]
	public bool m_SetWildlifeInterruptRest;

	[Header("AI Attack Damage")]
	[Token(Token = "0x400948B")]
	[FieldOffset(Offset = "0x1D0")]
	public DamageEventTable m_GenericDamageTable;

	[Token(Token = "0x400948C")]
	[FieldOffset(Offset = "0x1D8")]
	public List<DamageEventTableOverride> m_DamageTableOverrides;

	[Header("AI Pack Settings")]
	[SerializeField]
	[Token(Token = "0x400948D")]
	[FieldOffset(Offset = "0x1E0")]
	private PackSettings m_PackSettings;

	[Header("AI Cougar Settings")]
	[SerializeField]
	[Token(Token = "0x400948E")]
	[FieldOffset(Offset = "0x1E8")]
	private CougarSettings m_CougarSettings;

	[Header("Struggle")]
	[Range(0f, 10f)]
	[Token(Token = "0x400948F")]
	[FieldOffset(Offset = "0x1F0")]
	public float m_StruggleTapStrengthScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009490")]
	[FieldOffset(Offset = "0x1F4")]
	public float m_StrugglePlayerDamageReceivedIntervalScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009491")]
	[FieldOffset(Offset = "0x1F8")]
	public float m_StrugglePlayerDamageReceivedScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009492")]
	[FieldOffset(Offset = "0x1FC")]
	public float m_StrugglePlayerClothingDamageScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4009493")]
	[FieldOffset(Offset = "0x200")]
	public float m_StugglePlayerPercentLossFromBearScale;

	[Header("Outdoor Temp Decrease")]
	[Token(Token = "0x4009494")]
	[FieldOffset(Offset = "0x204")]
	public float m_OutdoorTempDropCelsiusMax;

	[Token(Token = "0x4009495")]
	[FieldOffset(Offset = "0x208")]
	public int m_OutdoorTempDropDayStart;

	[Token(Token = "0x4009496")]
	[FieldOffset(Offset = "0x20C")]
	public int m_OutdoorTempDropDayFinal;

	[SerializeField]
	[Token(Token = "0x4009497")]
	[FieldOffset(Offset = "0x210")]
	private bool m_ShouldAdjustFreezingDueToNearbyFire;

	[Header("Weather")]
	[Token(Token = "0x4009498")]
	[FieldOffset(Offset = "0x214")]
	public float m_MinAirTemperatureFromFireOutdoors;

	[Token(Token = "0x4009499")]
	[FieldOffset(Offset = "0x218")]
	public float m_MinAirTemperatureFromFireIndoors;

	[Header("AI Respawn Decrease")]
	[Token(Token = "0x400949A")]
	[FieldOffset(Offset = "0x21C")]
	public float m_RespawnHoursScaleMax;

	[Token(Token = "0x400949B")]
	[FieldOffset(Offset = "0x220")]
	public int m_RespawnHoursScaleDayStart;

	[Token(Token = "0x400949C")]
	[FieldOffset(Offset = "0x224")]
	public int m_RespawnHoursScaleDayFinal;

	[Header("Fishing Catch Decrease")]
	[Token(Token = "0x400949D")]
	[FieldOffset(Offset = "0x228")]
	public float m_FishCatchTimeScaleMax;

	[Token(Token = "0x400949E")]
	[FieldOffset(Offset = "0x22C")]
	public int m_FishCatchTimeScaleDayStart;

	[Token(Token = "0x400949F")]
	[FieldOffset(Offset = "0x230")]
	public int m_FishCatchTimeScaleDayFinal;

	[Header("Radial Spawn Decrease")]
	[Token(Token = "0x40094A0")]
	[FieldOffset(Offset = "0x234")]
	public float m_RadialRespawnTimeScaleMax;

	[Token(Token = "0x40094A1")]
	[FieldOffset(Offset = "0x238")]
	public int m_RadialRespawnTimeScaleDayStart;

	[Token(Token = "0x40094A2")]
	[FieldOffset(Offset = "0x23C")]
	public int m_RadialRespawnTimeScaleDayFinal;

	[Header("First Aid")]
	[Range(0f, 10f)]
	[Token(Token = "0x40094A3")]
	[FieldOffset(Offset = "0x240")]
	public float m_NumHoursWarmForHypothermiaCureScale;

	[Token(Token = "0x17000B47")]
	public virtual bool InterruptIfFreezingWhileSleeping
	{
		[Token(Token = "0x6008222")]
		[Address(RVA = "0x664EB0", Offset = "0x663CB0", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B48")]
	public virtual bool AdjustFreezingDueToNearbyFire
	{
		[Token(Token = "0x6008223")]
		[Address(RVA = "0x5CC2E0", Offset = "0x5CB0E0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6008221")]
	[Address(RVA = "0x122C670", Offset = "0x122B470", Length = "0x8")]
	public NutrientSettings GetNutrientSettings()
	{
		return null;
	}

	[Token(Token = "0x6008224")]
	[Address(RVA = "0x5C5150", Offset = "0x5C3F50", Length = "0x8")]
	public virtual PackSettings GetPackSettings()
	{
		return null;
	}

	[Token(Token = "0x6008225")]
	[Address(RVA = "0x122C680", Offset = "0x122B480", Length = "0x8")]
	public virtual CougarSettings GetCougarSettings(bool oldGameOverride = false)
	{
		return null;
	}

	[Token(Token = "0x6008226")]
	[Address(RVA = "0x122C690", Offset = "0x122B490", Length = "0x1BA")]
	public DamageEventTable GetDamageEventTable(GameplayTag tag)
	{
		return null;
	}

	[Token(Token = "0x6008227")]
	[Address(RVA = "0x122C850", Offset = "0x122B650", Length = "0x2E5")]
	public CustomTunableNLMHV GetSpawnRegionLevel(GameplayTag tag)
	{
		return default(CustomTunableNLMHV);
	}

	[Token(Token = "0x6008228")]
	[Address(RVA = "0x122CB40", Offset = "0x122B940", Length = "0x218")]
	public void SetSpawnRegionLevel(GameplayTag tag, CustomTunableNLMHV level)
	{
	}

	[Token(Token = "0x6008229")]
	[Address(RVA = "0x122CD60", Offset = "0x122BB60", Length = "0x7A")]
	public virtual float GetNormalizedStartTimeOfDay()
	{
		return 0f;
	}

	[Token(Token = "0x600822A")]
	[Address(RVA = "0x122CDE0", Offset = "0x122BBE0", Length = "0x37")]
	public ExperienceMode()
	{
	}
}
