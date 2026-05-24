using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay.Tunable;

[CreateAssetMenu(menuName = "The Long Dark/Experience Modes/Custom Value Lookup Table")]
[Token(Token = "0x20014C2")]
public class CustomExperienceModeTunableLookupTable : ScriptableObject
{
	[Token(Token = "0x40095CE")]
	[FieldOffset(Offset = "0x18")]
	public GameplayTag m_WolfTag;

	[Token(Token = "0x40095CF")]
	[FieldOffset(Offset = "0x28")]
	public GameplayTag m_TimberwolfTag;

	[Token(Token = "0x40095D0")]
	[FieldOffset(Offset = "0x38")]
	public GameplayTag m_BearTag;

	[Token(Token = "0x40095D1")]
	[FieldOffset(Offset = "0x48")]
	public GameplayTag m_MooseTag;

	[Token(Token = "0x40095D2")]
	[FieldOffset(Offset = "0x58")]
	public GameplayTag m_DeerTag;

	[Token(Token = "0x40095D3")]
	[FieldOffset(Offset = "0x68")]
	public GameplayTag m_RabbitTag;

	[Token(Token = "0x40095D4")]
	[FieldOffset(Offset = "0x78")]
	public GameplayTag m_PtarmiganTag;

	[Token(Token = "0x40095D5")]
	[FieldOffset(Offset = "0x88")]
	public GameplayTag m_CougarTag;

	[Token(Token = "0x40095D6")]
	[FieldOffset(Offset = "0x98")]
	public float m_IndoorSpawnChance;

	[SerializeField]
	[Token(Token = "0x40095D7")]
	[FieldOffset(Offset = "0xA0")]
	private List<ExperienceMode> m_BaseExperienceModes;

	[Token(Token = "0x40095D8")]
	[FieldOffset(Offset = "0xA8")]
	public CustomTunableLookup_NLMH m_AuroraChanceModifierList;

	[Token(Token = "0x40095D9")]
	[FieldOffset(Offset = "0xB0")]
	public CustomTunableLookup_LMH m_WindSpeedModifierList;

	[Token(Token = "0x40095DA")]
	[FieldOffset(Offset = "0xB8")]
	public CustomTunableLookup_LMH m_WindChangeFrequencyModifierList;

	[Token(Token = "0x40095DB")]
	[FieldOffset(Offset = "0xC0")]
	public CustomTunableLookup_NLMH m_BloodScentModifierList;

	[Token(Token = "0x40095DC")]
	[FieldOffset(Offset = "0xC8")]
	public CustomTunableLookup_Distance m_WildlifeDetectionModifierList;

	[Token(Token = "0x40095DD")]
	[FieldOffset(Offset = "0xD0")]
	public CustomTunableLookup_NLMH m_WolfFleeModifierList;

	[Token(Token = "0x40095DE")]
	[FieldOffset(Offset = "0xD8")]
	public CustomTunableLookup_LMH m_PlantSpawnChanceList;

	[Token(Token = "0x40095DF")]
	[FieldOffset(Offset = "0xE0")]
	public CustomTunableLookup_LMHV m_WildlifeRespawnTimeModifierList;

	[Token(Token = "0x40095E0")]
	[FieldOffset(Offset = "0xE8")]
	public CustomTunableLookup_LMHV m_ThirstScaleList;

	[Token(Token = "0x40095E1")]
	[FieldOffset(Offset = "0xF0")]
	public CustomTunableLookup_LMHV m_FatigueScaleList;

	[Token(Token = "0x40095E2")]
	[FieldOffset(Offset = "0xF8")]
	public CustomTunableLookup_NLMHV m_ConditionRecoveryRestList;

	[Token(Token = "0x40095E3")]
	[FieldOffset(Offset = "0x100")]
	public CustomTunableLookup_NLMHV m_ConditionRecoveryAwakeList;

	[Token(Token = "0x40095E4")]
	[FieldOffset(Offset = "0x108")]
	public CustomTunableLookup_NLMH m_EmptyContainerChanceList;

	[Token(Token = "0x40095E5")]
	[FieldOffset(Offset = "0x110")]
	public CustomTunableLookup_LMHV m_SmellRangeList;

	[Token(Token = "0x40095E6")]
	[FieldOffset(Offset = "0x118")]
	public CustomTunableLookup_NLMH m_StruggleDamageReceivedList;

	[Token(Token = "0x40095E7")]
	[FieldOffset(Offset = "0x120")]
	public CustomTunableLookup_NLMH m_StruggleClothingDamageList;

	[Token(Token = "0x40095E8")]
	[FieldOffset(Offset = "0x128")]
	public CustomTunableLookup_NLMHV m_FishCatchTimeScaleMaxList;

	[Token(Token = "0x40095E9")]
	[FieldOffset(Offset = "0x130")]
	public CustomTunableLookup_NLMHV m_FishCatchTimeScaleDayStartList;

	[Token(Token = "0x40095EA")]
	[FieldOffset(Offset = "0x138")]
	public CustomTunableLookup_NLMHV m_FishCatchTimeScaleDayFinalList;

	[Token(Token = "0x40095EB")]
	[FieldOffset(Offset = "0x140")]
	public CustomPackSettingsLookup_LMH m_TimberWolfPackFearList;

	[Token(Token = "0x40095EC")]
	[FieldOffset(Offset = "0x148")]
	public CustomTunableLookup_ProportionalMaxItems m_MaxItemReductionByEmptyContainerChance;

	[Token(Token = "0x60082FB")]
	[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
	public IList<ExperienceMode> GetBaseExperienceModes()
	{
		return null;
	}

	[Token(Token = "0x60082FC")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public CustomExperienceModeTunableLookupTable()
	{
	}
}
