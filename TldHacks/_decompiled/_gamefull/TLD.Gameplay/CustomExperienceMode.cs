using System;
using System.Collections;
using Cpp2ILInjected;
using TLD.AI;
using TLD.Gameplay.Tunable;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Experience Modes/Custom Experience Mode")]
[Token(Token = "0x2001469")]
public class CustomExperienceMode : ExperienceMode
{
	[Token(Token = "0x4009407")]
	private const int SHARING_STRING_LEN = 20;

	[SerializeField]
	[Token(Token = "0x4009408")]
	[FieldOffset(Offset = "0x248")]
	private CustomExperienceModeTunableLookupTable m_LookupTable;

	[Token(Token = "0x4009409")]
	[FieldOffset(Offset = "0x250")]
	public bool m_AllowInteriorStartingSpawn;

	[Token(Token = "0x400940A")]
	[FieldOffset(Offset = "0x251")]
	public bool m_SurvivorVoiceOver;

	[Token(Token = "0x400940B")]
	[FieldOffset(Offset = "0x252")]
	public bool m_WeakIce;

	[Token(Token = "0x400940C")]
	[FieldOffset(Offset = "0x253")]
	public bool m_UseMinAirTempValue;

	[Token(Token = "0x400940D")]
	[FieldOffset(Offset = "0x254")]
	public bool m_EnableDysentery;

	[Token(Token = "0x400940E")]
	[FieldOffset(Offset = "0x255")]
	public bool m_EnableSprains;

	[Token(Token = "0x400940F")]
	[FieldOffset(Offset = "0x256")]
	public bool m_EnableFoodPoisoning;

	[Token(Token = "0x4009410")]
	[FieldOffset(Offset = "0x257")]
	public bool m_EnableBrokenRibs;

	[Token(Token = "0x4009411")]
	[FieldOffset(Offset = "0x258")]
	public bool m_LimitedRest;

	[Token(Token = "0x4009412")]
	[FieldOffset(Offset = "0x259")]
	public bool m_AdjustFreezingDueToNearbyFire;

	[Token(Token = "0x4009413")]
	[FieldOffset(Offset = "0x25A")]
	public bool m_InterruptIfFreezingWhileSleeping;

	[Token(Token = "0x4009414")]
	[FieldOffset(Offset = "0x25B")]
	public bool m_RiflesInWorld;

	[Token(Token = "0x4009415")]
	[FieldOffset(Offset = "0x25C")]
	public bool m_RevolversInWorld;

	[Token(Token = "0x4009416")]
	[FieldOffset(Offset = "0x25D")]
	public bool m_IsBirchBarkTreeCraftable;

	[Token(Token = "0x4009417")]
	[FieldOffset(Offset = "0x260")]
	public CustomTunableNLMH m_StruggleClothingDamageBonus;

	[Token(Token = "0x4009418")]
	[FieldOffset(Offset = "0x264")]
	public CustomTunableDayNightMultiplier m_DayNightLengthMultiplier;

	[Token(Token = "0x4009419")]
	[FieldOffset(Offset = "0x268")]
	public CustomTunableLMHV m_WeatherChangeFrequency;

	[Token(Token = "0x400941A")]
	[FieldOffset(Offset = "0x26C")]
	public CustomTunableNLMH m_StrugglePlayerStrengthBonus;

	[Token(Token = "0x400941B")]
	[FieldOffset(Offset = "0x270")]
	public CustomTunableNLMH m_GradualTempReductionRate;

	[Token(Token = "0x400941C")]
	[FieldOffset(Offset = "0x274")]
	public CustomTunableNLMH m_AuroraFrequency;

	[Token(Token = "0x400941D")]
	[FieldOffset(Offset = "0x278")]
	public CustomTunableLMHV m_CalorieBurnRate;

	[Token(Token = "0x400941E")]
	[FieldOffset(Offset = "0x27C")]
	public CustomTunableLMHV m_ThirstIncrease;

	[Token(Token = "0x400941F")]
	[FieldOffset(Offset = "0x280")]
	public CustomTunableLMHV m_FatigueIncrease;

	[Token(Token = "0x4009420")]
	[FieldOffset(Offset = "0x284")]
	public CustomTunableLMHV m_FreezingIncrease;

	[Token(Token = "0x4009421")]
	[FieldOffset(Offset = "0x288")]
	public CustomTunableLMHV m_HoursWarmthToCureHypothermia;

	[Token(Token = "0x4009422")]
	[FieldOffset(Offset = "0x28C")]
	public CustomTunableLMHV m_ItemDecayRate;

	[Token(Token = "0x4009423")]
	[FieldOffset(Offset = "0x290")]
	public CustomTunableLMHV m_ItemSpawnChance;

	[Token(Token = "0x4009424")]
	[FieldOffset(Offset = "0x294")]
	public CustomTunableNLMH m_ReduceWildlifePopOverTime;

	[Token(Token = "0x4009425")]
	[FieldOffset(Offset = "0x298")]
	public CustomTunableNLMH m_EmptyContainerChance;

	[Token(Token = "0x4009426")]
	[FieldOffset(Offset = "0x29C")]
	public CustomTunableLMHV m_StickBranchStoneSpawnFrequency;

	[Token(Token = "0x4009427")]
	[FieldOffset(Offset = "0x2A0")]
	public CustomTunableLMHV m_StartingGear;

	[Token(Token = "0x4009428")]
	[FieldOffset(Offset = "0x2A4")]
	public CustomTunableNLMH m_StruggleDamageReceivedBonus;

	[Token(Token = "0x4009429")]
	[FieldOffset(Offset = "0x2A8")]
	public CustomTunableNLMH m_ScentIncreaseFromMeatBlood;

	[Token(Token = "0x400942A")]
	[FieldOffset(Offset = "0x2AC")]
	public CustomTunableNLMH m_WolfFleeChance;

	[Token(Token = "0x400942B")]
	[FieldOffset(Offset = "0x2B0")]
	public CustomTunableLMH m_TimberWolfPackFear;

	[Token(Token = "0x400942C")]
	[FieldOffset(Offset = "0x2B4")]
	public CustomTunableLMHV m_StruggleDamageEventSeverity;

	[Token(Token = "0x400942D")]
	[FieldOffset(Offset = "0x2B8")]
	public CustomTunableLMHV m_WildlifeSmellRange;

	[Token(Token = "0x400942E")]
	[FieldOffset(Offset = "0x2BC")]
	public CustomTunableLMHV m_WildlifeSpawnFrequency;

	[Token(Token = "0x400942F")]
	[FieldOffset(Offset = "0x2C0")]
	public bool m_WildlifeNotAttackUnprovoked;

	[Token(Token = "0x4009430")]
	[FieldOffset(Offset = "0x2C1")]
	public bool m_CabinFeverEnabled;

	[Token(Token = "0x4009431")]
	[FieldOffset(Offset = "0x2C2")]
	public bool m_ParasitesEnabled;

	[Token(Token = "0x4009432")]
	[FieldOffset(Offset = "0x2C4")]
	public CustomTunableNLMHV m_ConditionRecoveryRest;

	[Token(Token = "0x4009433")]
	[FieldOffset(Offset = "0x2C8")]
	public CustomTunableNLMHV m_ConditionRecoveryAwake;

	[Token(Token = "0x4009434")]
	[FieldOffset(Offset = "0x2CC")]
	public CustomTunableNLMHV m_FrosbiteRisk;

	[Token(Token = "0x4009435")]
	[FieldOffset(Offset = "0x2D0")]
	public CustomTunableNLMHV m_RabbitSpawnChance;

	[Token(Token = "0x4009436")]
	[FieldOffset(Offset = "0x2D4")]
	public CustomTunableNLMHV m_BearSpawnChance;

	[Token(Token = "0x4009437")]
	[FieldOffset(Offset = "0x2D8")]
	public CustomTunableNLMHV m_BlizzardFrequency;

	[Token(Token = "0x4009438")]
	[FieldOffset(Offset = "0x2DC")]
	public CustomTunableNLMHV m_DeerSpawnChance;

	[Token(Token = "0x4009439")]
	[FieldOffset(Offset = "0x2E0")]
	public CustomTunableNLMHV m_FishSpawnChance;

	[Token(Token = "0x400943A")]
	[FieldOffset(Offset = "0x2E4")]
	public CustomTunableNLMH m_CougarDifficulty;

	[Token(Token = "0x400943B")]
	[FieldOffset(Offset = "0x2E8")]
	public CustomTunableNLMHV m_WolfSpawnChance;

	[Token(Token = "0x400943C")]
	[FieldOffset(Offset = "0x2EC")]
	public CustomTunableNLMHV m_TimberWolfSpawnChance;

	[Token(Token = "0x400943D")]
	[FieldOffset(Offset = "0x2F0")]
	public CustomTunableTimeOfDay m_StartTimeOfDay;

	[Token(Token = "0x400943E")]
	[FieldOffset(Offset = "0x2F4")]
	public bool m_WildlifeInterruptRest;

	[Token(Token = "0x400943F")]
	[FieldOffset(Offset = "0x2F8")]
	public CustomTunableLMH m_WindVariability;

	[Token(Token = "0x4009440")]
	[FieldOffset(Offset = "0x2FC")]
	public CustomTunableLMH m_PlantSpawnFrequency;

	[Token(Token = "0x4009441")]
	[FieldOffset(Offset = "0x300")]
	public CustomTunableNLH m_ReduceMaxItemsContainers;

	[Token(Token = "0x4009442")]
	[FieldOffset(Offset = "0x304")]
	public CustomTunableDistance m_WolfSpawnDistance;

	[Token(Token = "0x4009443")]
	[FieldOffset(Offset = "0x308")]
	public CustomTunableDistance m_WildlifeDetectionRange;

	[Token(Token = "0x4009444")]
	[FieldOffset(Offset = "0x30C")]
	public CustomTunableNLMHV m_MooseSpawnChance;

	[Token(Token = "0x4009445")]
	[FieldOffset(Offset = "0x310")]
	public CustomTunableOMH m_ScurvyDrain;

	[Token(Token = "0x4009446")]
	[FieldOffset(Offset = "0x314")]
	public bool m_EndlessNight;

	[NonSerialized]
	[Token(Token = "0x4009447")]
	[FieldOffset(Offset = "0x318")]
	public int m_Version;

	[Token(Token = "0x4009448")]
	public const int CURRENT_VERSION = 3;

	[Token(Token = "0x17000B3D")]
	public override bool InterruptIfFreezingWhileSleeping
	{
		[Token(Token = "0x60081D3")]
		[Address(RVA = "0x1225D50", Offset = "0x1224B50", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B3E")]
	public override bool AdjustFreezingDueToNearbyFire
	{
		[Token(Token = "0x60081D4")]
		[Address(RVA = "0x1225D60", Offset = "0x1224B60", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60081D5")]
	[Address(RVA = "0x1225D70", Offset = "0x1224B70", Length = "0x5E")]
	public override PackSettings GetPackSettings()
	{
		return null;
	}

	[Token(Token = "0x60081D6")]
	[Address(RVA = "0x1225DD0", Offset = "0x1224BD0", Length = "0x80")]
	public override CougarSettings GetCougarSettings(bool oldGameOverride)
	{
		return null;
	}

	[Token(Token = "0x60081D7")]
	[Address(RVA = "0x1225E60", Offset = "0x1224C60", Length = "0x22")]
	public float GetIndoorStartChance()
	{
		return 0f;
	}

	[Token(Token = "0x60081D8")]
	[Address(RVA = "0x1225E90", Offset = "0x1224C90", Length = "0x5E")]
	public float GetAuroraChanceModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081D9")]
	[Address(RVA = "0x1225EF0", Offset = "0x1224CF0", Length = "0x5E")]
	public float GetWindSpeedModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081DA")]
	[Address(RVA = "0x1225F50", Offset = "0x1224D50", Length = "0x5E")]
	public float GetWindChangeFrequencyModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081DB")]
	[Address(RVA = "0x1225FB0", Offset = "0x1224DB0", Length = "0x5E")]
	public float GetBloodScentModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081DC")]
	[Address(RVA = "0x1226010", Offset = "0x1224E10", Length = "0x5E")]
	public float GetWildlifeDetectionModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081DD")]
	[Address(RVA = "0x1226070", Offset = "0x1224E70", Length = "0x5E")]
	public float GetPlantSpawnModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081DE")]
	[Address(RVA = "0x12260D0", Offset = "0x1224ED0", Length = "0x5E")]
	public float GetWildlifeRespawnTimeModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081DF")]
	[Address(RVA = "0x1226130", Offset = "0x1224F30", Length = "0x65")]
	public float GetWolfFleeModifier(CustomTunableNLMH tunable)
	{
		return 0f;
	}

	[Token(Token = "0x60081E0")]
	[Address(RVA = "0x12261A0", Offset = "0x1224FA0", Length = "0xE")]
	public float GetRegularWolfFleeModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081E1")]
	[Address(RVA = "0x12261B0", Offset = "0x1224FB0", Length = "0x30")]
	public float GetTimberWolfFleeModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60081E2")]
	[Address(RVA = "0x12261E0", Offset = "0x1224FE0", Length = "0x89")]
	public float GetProportionalReduceMaxItems()
	{
		return 0f;
	}

	[Token(Token = "0x60081E3")]
	[Address(RVA = "0x1226270", Offset = "0x1225070", Length = "0x6")]
	public static int GetSharingStringLengthWithDashes()
	{
		return 0;
	}

	[Token(Token = "0x60081E4")]
	[Address(RVA = "0x1226280", Offset = "0x1225080", Length = "0x336")]
	private void UpdateSpawnRegionLevels()
	{
	}

	[Token(Token = "0x60081E5")]
	[Address(RVA = "0x12265C0", Offset = "0x12253C0", Length = "0x29")]
	private void UpdateSpawnRegionLevel(GameplayTag tag, CustomTunableNLMHV spawnChance)
	{
	}

	[Token(Token = "0x60081E6")]
	[Address(RVA = "0x12265F0", Offset = "0x12253F0", Length = "0x5B")]
	public ExperienceMode GetPilgrimExperienceMode()
	{
		return null;
	}

	[Token(Token = "0x60081E7")]
	[Address(RVA = "0x1226650", Offset = "0x1225450", Length = "0x5E")]
	public ExperienceMode GetVoyageurExperienceMode()
	{
		return null;
	}

	[Token(Token = "0x60081E8")]
	[Address(RVA = "0x12266B0", Offset = "0x12254B0", Length = "0x5E")]
	public ExperienceMode GetStalkerExperienceMode()
	{
		return null;
	}

	[Token(Token = "0x60081E9")]
	[Address(RVA = "0x1226710", Offset = "0x1225510", Length = "0x5E")]
	public ExperienceMode GetInterloperExperienceMode()
	{
		return null;
	}

	[Token(Token = "0x60081EA")]
	[Address(RVA = "0x1226770", Offset = "0x1225570", Length = "0xF31")]
	public bool UpdateBaseValues()
	{
		return false;
	}

	[Token(Token = "0x60081EB")]
	[Address(RVA = "0x12276B0", Offset = "0x12264B0", Length = "0x12")]
	public CustomTunableNLMHV GetWolfSpawnChance(WolfType wolfType)
	{
		return default(CustomTunableNLMHV);
	}

	[Token(Token = "0x60081EC")]
	[Address(RVA = "0x12276D0", Offset = "0x12264D0", Length = "0x44")]
	public override float GetNormalizedStartTimeOfDay()
	{
		return 0f;
	}

	[Token(Token = "0x60081ED")]
	[Address(RVA = "0x1227720", Offset = "0x1226520", Length = "0xB")]
	private void Awake()
	{
	}

	[Token(Token = "0x60081EE")]
	[Address(RVA = "0x1227730", Offset = "0x1226530", Length = "0xDF")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60081EF")]
	[Address(RVA = "0x1227810", Offset = "0x1226610", Length = "0x802")]
	public static bool CreateCustomModeFromString(CustomExperienceMode customMode, string inputString)
	{
		return false;
	}

	[Token(Token = "0x60081F0")]
	[Address(RVA = "0x1228020", Offset = "0x1226E20", Length = "0x1731")]
	public static string CreateStringFromCustomMode(CustomExperienceMode customMode)
	{
		return null;
	}

	[Token(Token = "0x60081F1")]
	[Address(RVA = "0x1229760", Offset = "0x1228560", Length = "0x10B")]
	private static int BitsToDecimal(BitArray bitArray, int startIndex, int length)
	{
		return 0;
	}

	[Token(Token = "0x60081F2")]
	[Address(RVA = "0x1229870", Offset = "0x1228670", Length = "0x165")]
	private static int[] ConvertDecToBase(int decimalValue, int baseValue, int size)
	{
		return null;
	}

	[Token(Token = "0x60081F3")]
	[Address(RVA = "0x12299E0", Offset = "0x12287E0", Length = "0x179")]
	private static BitArray GetBitArrayFromDec(int decValue, int desiredLength)
	{
		return null;
	}

	[Token(Token = "0x60081F4")]
	[Address(RVA = "0x1225D10", Offset = "0x1224B10", Length = "0x40")]
	public CustomExperienceMode()
	{
	}
}
