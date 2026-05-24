using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.AI;
using TLD.Cooking;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Placement;
using TLD.Player;
using TLD.Trader;

[Token(Token = "0x2000931")]
public class GlobalSaveGameFormat
{
	[Token(Token = "0x4005F56")]
	[FieldOffset(Offset = "0x10")]
	public int m_Version;

	[Token(Token = "0x4005F57")]
	[FieldOffset(Offset = "0x18")]
	public string m_GameManagerSerialized;

	[Token(Token = "0x4005F58")]
	[FieldOffset(Offset = "0x20")]
	public string m_HudManagerSerialized;

	[Token(Token = "0x4005F59")]
	[FieldOffset(Offset = "0x28")]
	public string m_TimeOfDay_Serialized;

	[Token(Token = "0x4005F5A")]
	[FieldOffset(Offset = "0x30")]
	public string m_Wind_Serialized;

	[Token(Token = "0x4005F5B")]
	[FieldOffset(Offset = "0x38")]
	public string m_Weather_Serialized;

	[Token(Token = "0x4005F5C")]
	[FieldOffset(Offset = "0x40")]
	public string m_WeatherTransition_Serialized;

	[Token(Token = "0x4005F5D")]
	[FieldOffset(Offset = "0x48")]
	public string m_Condition_Serialized;

	[Token(Token = "0x4005F5E")]
	[FieldOffset(Offset = "0x50")]
	public string m_Encumber_Serialized;

	[Token(Token = "0x4005F5F")]
	[FieldOffset(Offset = "0x58")]
	public string m_Hunger_Serialized;

	[Token(Token = "0x4005F60")]
	[FieldOffset(Offset = "0x60")]
	public string m_Thirst_Serialized;

	[Token(Token = "0x4005F61")]
	[FieldOffset(Offset = "0x68")]
	public string m_Fatigue_Serialized;

	[Token(Token = "0x4005F62")]
	[FieldOffset(Offset = "0x70")]
	public string m_Freezing_Serialized;

	[Token(Token = "0x4005F63")]
	[FieldOffset(Offset = "0x78")]
	public string m_Willpower_Serialized;

	[Token(Token = "0x4005F64")]
	[FieldOffset(Offset = "0x80")]
	public string m_Inventory_Serialized;

	[Token(Token = "0x4005F65")]
	[FieldOffset(Offset = "0x88")]
	public string m_SandboxManagerSerialized;

	[Token(Token = "0x4005F66")]
	[FieldOffset(Offset = "0x90")]
	public string m_StoryManagerSerialized;

	[Token(Token = "0x4005F67")]
	[FieldOffset(Offset = "0x98")]
	public string m_PlayerManagerSerialized;

	[Token(Token = "0x4005F68")]
	[FieldOffset(Offset = "0xA0")]
	public string m_PlayerClimbRopeSerialized;

	[Token(Token = "0x4005F69")]
	[FieldOffset(Offset = "0xA8")]
	public string m_PlayerSkillsSerialized;

	[Token(Token = "0x4005F6A")]
	[FieldOffset(Offset = "0xB0")]
	public string m_PlayerGameStatsSerialized;

	[Token(Token = "0x4005F6B")]
	[FieldOffset(Offset = "0xB8")]
	public string m_HypothermiaSerialized;

	[Token(Token = "0x4005F6C")]
	[FieldOffset(Offset = "0xC0")]
	public string m_WellFedSerialized;

	[Token(Token = "0x4005F6D")]
	[FieldOffset(Offset = "0xC8")]
	public string m_FrostbiteSerialized;

	[Token(Token = "0x4005F6E")]
	[FieldOffset(Offset = "0xD0")]
	public string m_FoodPoisoningSerialized;

	[Token(Token = "0x4005F6F")]
	[FieldOffset(Offset = "0xD8")]
	public string m_DysenterySerialized;

	[Token(Token = "0x4005F70")]
	[FieldOffset(Offset = "0xE0")]
	public string m_SprainPainSerialized;

	[Token(Token = "0x4005F71")]
	[FieldOffset(Offset = "0xE8")]
	public string m_SprainedAnkleSerialized;

	[Token(Token = "0x4005F72")]
	[FieldOffset(Offset = "0xF0")]
	public string m_SprainedWristSerialized;

	[Token(Token = "0x4005F73")]
	[FieldOffset(Offset = "0xF8")]
	public string m_SprainedWristMajorSerialized;

	[Token(Token = "0x4005F74")]
	[FieldOffset(Offset = "0x100")]
	public string m_SprainsSerialized;

	[Token(Token = "0x4005F75")]
	[FieldOffset(Offset = "0x108")]
	public string m_BurnsSerialized;

	[Token(Token = "0x4005F76")]
	[FieldOffset(Offset = "0x110")]
	public string m_BurnsElectricSerialized;

	[Token(Token = "0x4005F77")]
	[FieldOffset(Offset = "0x118")]
	public string m_BloodLossSerialized;

	[Token(Token = "0x4005F78")]
	[FieldOffset(Offset = "0x120")]
	public string m_BrokenRibSerialized;

	[Token(Token = "0x4005F79")]
	[FieldOffset(Offset = "0x128")]
	public string m_InfectionSerialized;

	[Token(Token = "0x4005F7A")]
	[FieldOffset(Offset = "0x130")]
	public string m_InfectionRiskSerialized;

	[Token(Token = "0x4005F7B")]
	[FieldOffset(Offset = "0x138")]
	public string m_LogSerialized;

	[Token(Token = "0x4005F7C")]
	[FieldOffset(Offset = "0x140")]
	public string m_RestSerialized;

	[Token(Token = "0x4005F7D")]
	[FieldOffset(Offset = "0x148")]
	public string m_FlyOverSerialized;

	[Token(Token = "0x4005F7E")]
	[FieldOffset(Offset = "0x150")]
	public string m_AchievementManagerSerialized;

	[Token(Token = "0x4005F7F")]
	[FieldOffset(Offset = "0x158")]
	public string m_ExperienceModeManagerSerialized;

	[Token(Token = "0x4005F80")]
	[FieldOffset(Offset = "0x160")]
	public string m_AuroraManagerSerialized;

	[Token(Token = "0x4005F81")]
	[FieldOffset(Offset = "0x168")]
	public string m_PlayerMovementSerialized;

	[Token(Token = "0x4005F82")]
	[FieldOffset(Offset = "0x170")]
	public string m_PlayerStruggleSerialized;

	[Token(Token = "0x4005F83")]
	[FieldOffset(Offset = "0x178")]
	public string m_PanelStatsSerialized;

	[Token(Token = "0x4005F84")]
	[FieldOffset(Offset = "0x180")]
	public string m_EmergencyStimSerialized;

	[Token(Token = "0x4005F85")]
	[FieldOffset(Offset = "0x188")]
	public string m_EnergyBoostSerialized;

	[Token(Token = "0x4005F86")]
	[FieldOffset(Offset = "0x190")]
	public string m_HeadacheSerialized;

	[Token(Token = "0x4005F87")]
	[FieldOffset(Offset = "0x198")]
	public string m_MusicEventManagerSerialized;

	[Token(Token = "0x4005F88")]
	[FieldOffset(Offset = "0x1A0")]
	public string m_ChimneyDataSerialized;

	[Token(Token = "0x4005F89")]
	[FieldOffset(Offset = "0x1A8")]
	public string m_CabinFeverSerialized;

	[Token(Token = "0x4005F8A")]
	[FieldOffset(Offset = "0x1B0")]
	public string m_IntestinalParasitesSerialized;

	[Token(Token = "0x4005F8B")]
	[FieldOffset(Offset = "0x1B8")]
	public string m_SnowPatchManagerSerialized;

	[Token(Token = "0x4005F8C")]
	[FieldOffset(Offset = "0x1C0")]
	public string m_PlayerAnimationSerialized;

	[Token(Token = "0x4005F8D")]
	[FieldOffset(Offset = "0x1C8")]
	public string m_SkillsManagerSerialized;

	[Token(Token = "0x4005F8E")]
	[FieldOffset(Offset = "0x1D0")]
	public string m_LockCompanionsSerialized;

	[Token(Token = "0x4005F8F")]
	[FieldOffset(Offset = "0x1D8")]
	public string m_FeatsEnabledSerialized;

	[Token(Token = "0x4005F90")]
	[FieldOffset(Offset = "0x1E0")]
	public string m_MapDataSerialized;

	[Token(Token = "0x4005F91")]
	[FieldOffset(Offset = "0x1E8")]
	public string m_BearHuntSerialized;

	[Token(Token = "0x4005F92")]
	[FieldOffset(Offset = "0x1F0")]
	public string m_BearHuntReduxSerialized;

	[Token(Token = "0x4005F93")]
	[FieldOffset(Offset = "0x1F8")]
	public string m_KnowledgeManagerSerialized;

	[Token(Token = "0x4005F94")]
	[FieldOffset(Offset = "0x200")]
	public string m_UnlockedBlueprintsSerialized;

	[Token(Token = "0x4005F95")]
	[FieldOffset(Offset = "0x208")]
	public string m_CollectionManagerSerialized;

	[Token(Token = "0x4005F96")]
	[FieldOffset(Offset = "0x210")]
	public string m_AuroraScreenManagerSerialized;

	[Token(Token = "0x4005F97")]
	[FieldOffset(Offset = "0x218")]
	public string m_StoryMissionDataSerialized;

	[Token(Token = "0x4005F98")]
	[FieldOffset(Offset = "0x220")]
	public bool m_CurrentEpisodeComplete;

	[Token(Token = "0x4005F99")]
	[FieldOffset(Offset = "0x228")]
	public string m_PhoneManagerSerialized;

	[Token(Token = "0x4005F9A")]
	[FieldOffset(Offset = "0x230")]
	public string m_MissionObjectiveTableSerialized;

	[Token(Token = "0x4005F9B")]
	[FieldOffset(Offset = "0x238")]
	public string m_BigCarrySystemSerialized;

	[Token(Token = "0x4005F9C")]
	[FieldOffset(Offset = "0x240")]
	public string m_NPCGlobalSerialized;

	[Token(Token = "0x4005F9D")]
	[FieldOffset(Offset = "0x248")]
	public string m_PackManagerGlobalSerialized;

	[Token(Token = "0x4005F9E")]
	[FieldOffset(Offset = "0x250")]
	public string m_RockCacheInfoSerialized;

	[Token(Token = "0x4005F9F")]
	[FieldOffset(Offset = "0x258")]
	public string m_SprayPaintPanelInfoSerialized;

	[Token(Token = "0x4005FA0")]
	[FieldOffset(Offset = "0x260")]
	public string m_InvisibleEntityInfoSerialized;

	[Token(Token = "0x4005FA1")]
	[FieldOffset(Offset = "0x268")]
	public string m_ToxicFogManagerSerialized;

	[Token(Token = "0x4005FA2")]
	[FieldOffset(Offset = "0x270")]
	public string m_FearSerialized;

	[Token(Token = "0x4005FA3")]
	[FieldOffset(Offset = "0x278")]
	public string m_AnxietySerialized;

	[Token(Token = "0x4005FA4")]
	[FieldOffset(Offset = "0x280")]
	public string m_SuffocatingSerialized;

	[Token(Token = "0x4005FA5")]
	[FieldOffset(Offset = "0x288")]
	public string m_HighResolutionTimerSerialized;

	[Token(Token = "0x4005FA6")]
	[FieldOffset(Offset = "0x290")]
	public string m_SceneManagerSerialized;

	[Token(Token = "0x4005FA7")]
	[FieldOffset(Offset = "0x298")]
	public string m_NotificationFlagSerialized;

	[Token(Token = "0x4005FA8")]
	[FieldOffset(Offset = "0x2A0")]
	public string m_InsomniaSerialized;

	[Token(Token = "0x4005FA9")]
	[FieldOffset(Offset = "0x2A8")]
	public string m_TransmitterSerialized;

	[Token(Token = "0x4005FAA")]
	[FieldOffset(Offset = "0x2B0")]
	public string m_BeachcombingManagerSerialized;

	[Token(Token = "0x4005FAB")]
	[FieldOffset(Offset = "0x2B8")]
	public string m_TrackableItemSerialized;

	[Token(Token = "0x4005FAC")]
	[FieldOffset(Offset = "0x2C0")]
	public RecipeBookGameState m_RecipeBookState;

	[Token(Token = "0x4005FAD")]
	[FieldOffset(Offset = "0x2C8")]
	public List<FoodMaxStatBuffEffect> m_FoodMaxStatBuffEffects;

	[Token(Token = "0x4005FAE")]
	[FieldOffset(Offset = "0x2D0")]
	public ChemicalPoisoningSaveData m_ChemicalPoisoningSerialized;

	[Token(Token = "0x4005FAF")]
	[FieldOffset(Offset = "0x2E0")]
	public ScurvySaveDataGobal m_ScurvySerialized;

	[Token(Token = "0x4005FB0")]
	[FieldOffset(Offset = "0x2E8")]
	public NutritionSaveDataGlobal m_PlayerNutritionSerialized;

	[Token(Token = "0x4005FB1")]
	[FieldOffset(Offset = "0x2F0")]
	public MiseryManagerSaveData m_MiseryManagerSerialized;

	[Token(Token = "0x4005FB2")]
	[FieldOffset(Offset = "0x2F8")]
	public LifeAfterDeathState m_LifeAfterDeathSerialized;

	[Token(Token = "0x4005FB3")]
	[FieldOffset(Offset = "0x300")]
	public CheatDeathAfflictionState m_CheatDeathAfflictionSerialized;

	[Token(Token = "0x4005FB4")]
	[FieldOffset(Offset = "0x308")]
	public DiminishedStateAfflictionState m_DiminishedStateAfflictionSerialized;

	[Token(Token = "0x4005FB5")]
	[FieldOffset(Offset = "0x310")]
	public SevereLacerationsSaveData m_SevereLacerationSerialized;

	[Token(Token = "0x4005FB6")]
	[FieldOffset(Offset = "0x318")]
	public CougarManagerData m_CougarManagerSerialized;

	[Token(Token = "0x4005FB7")]
	[FieldOffset(Offset = "0x320")]
	public TraderState m_TraderSerialized;

	[Token(Token = "0x4005FB8")]
	[FieldOffset(Offset = "0x328")]
	public List<PhotoManager.PhotoInfo> m_PhotoManagerSerialized;

	[Token(Token = "0x4005FB9")]
	[FieldOffset(Offset = "0x330")]
	public List<PlaceableInfoSaveData> m_PlacementListSerialized;

	[Token(Token = "0x4005FBA")]
	[FieldOffset(Offset = "0x338")]
	public List<PlaceableInfoSaveData> m_TempInventoryPlacementListSerialized;

	[Token(Token = "0x60053C6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GlobalSaveGameFormat()
	{
	}
}
