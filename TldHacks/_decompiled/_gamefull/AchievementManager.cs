using System.Collections.Generic;
using Cpp2ILInjected;
using TLD;
using TLD.Gameplay;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Logging;
using TLD.OptionalContent;
using TLD.Scenes;
using TLD.Stats;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000707")]
public class AchievementManager : MonoBehaviour
{
	[Token(Token = "0x2000708")]
	public enum ChallengeAchievement
	{
		[Token(Token = "0x4004AED")]
		RescueChallengeComplete,
		[Token(Token = "0x4004AEE")]
		HuntedChallengeComplete
	}

	[Token(Token = "0x4004A90")]
	public static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x4004A91")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Map> m_Map;

	[Header("DLC")]
	[SerializeField]
	[Token(Token = "0x4004A92")]
	[FieldOffset(Offset = "0x28")]
	private OptionalContentConfig m_ContentConfig;

	[Header("Tuning")]
	[Token(Token = "0x4004A93")]
	[FieldOffset(Offset = "0x30")]
	public FaithfulCartographerSO m_FaithfulCartographerSO;

	[Token(Token = "0x4004A94")]
	[FieldOffset(Offset = "0x38")]
	public SandboxConfig m_Interloper;

	[Token(Token = "0x4004A95")]
	[FieldOffset(Offset = "0x40")]
	public GameplayTag m_RareFishTag;

	[Token(Token = "0x4004A96")]
	[FieldOffset(Offset = "0x50")]
	public int m_RareFishNeeded;

	[Token(Token = "0x4004A97")]
	[FieldOffset(Offset = "0x58")]
	public GameplayTag m_FishingLureTag;

	[Token(Token = "0x4004A98")]
	[FieldOffset(Offset = "0x68")]
	public int m_FishingLuresNeeded;

	[Token(Token = "0x4004A99")]
	[FieldOffset(Offset = "0x6C")]
	public int m_CougarStrugglesNeeded;

	[Token(Token = "0x4004A9A")]
	[FieldOffset(Offset = "0x70")]
	public int m_NumTalesNeeded;

	[Token(Token = "0x4004A9B")]
	[FieldOffset(Offset = "0x74")]
	public int m_PtarmiganKillsWithArrowNeeded;

	[Token(Token = "0x4004A9C")]
	[FieldOffset(Offset = "0x78")]
	public int m_RabbitKillsWithHardenedArrowsNeeded;

	[SerializeField]
	[Token(Token = "0x4004A9D")]
	[FieldOffset(Offset = "0x7C")]
	private int m_UniqueRecipesNeeded;

	[SerializeField]
	[Token(Token = "0x4004A9E")]
	[FieldOffset(Offset = "0x80")]
	private int m_VistaLocationsNeeded;

	[SerializeField]
	[Token(Token = "0x4004A9F")]
	[FieldOffset(Offset = "0x88")]
	private GameplayTag m_FilmTypeTag;

	[SerializeField]
	[Token(Token = "0x4004AA0")]
	[FieldOffset(Offset = "0x98")]
	private int m_PhotoFilmTypesNeeded;

	[SerializeField]
	[Token(Token = "0x4004AA1")]
	[FieldOffset(Offset = "0x9C")]
	private int m_PhotosNeededPerFilmType;

	[SerializeField]
	[Token(Token = "0x4004AA2")]
	[FieldOffset(Offset = "0xA0")]
	private int m_PhotoRegionsNeeded;

	[SerializeField]
	[Token(Token = "0x4004AA3")]
	[FieldOffset(Offset = "0xA8")]
	private List<StatID> m_EndsOfTheEarthRegionStats;

	[SerializeField]
	[Token(Token = "0x4004AA4")]
	[FieldOffset(Offset = "0xB0")]
	private List<RegionSpecification> m_ThanksForTheMemoriesRegions;

	[SerializeField]
	[Token(Token = "0x4004AA5")]
	[FieldOffset(Offset = "0xB8")]
	private List<SceneSet> m_TrackedPrepperCaches;

	[SerializeField]
	[Token(Token = "0x4004AA6")]
	[FieldOffset(Offset = "0xC0")]
	private int m_RequiredPrepperCacheExplorations;

	[SerializeField]
	[Token(Token = "0x4004AA7")]
	[FieldOffset(Offset = "0xC8")]
	private string m_LangstonMineSceneSetName;

	[SerializeField]
	[Token(Token = "0x4004AA8")]
	[FieldOffset(Offset = "0xD0")]
	private int m_LangstonMineRequiredDays;

	[SerializeField]
	[Token(Token = "0x4004AA9")]
	[FieldOffset(Offset = "0xD8")]
	private List<AssetReferenceGearItemData> m_ValidExpansionFirearms;

	[SerializeField]
	[Token(Token = "0x4004AAA")]
	[FieldOffset(Offset = "0xE0")]
	private int m_RequiredExpansionFirearmVariants;

	[SerializeField]
	[Token(Token = "0x4004AAB")]
	[FieldOffset(Offset = "0xE4")]
	private int m_RequiredInsulatedFlaskVariants;

	[Header("Achievement Data")]
	[Token(Token = "0x4004AAC")]
	[FieldOffset(Offset = "0xE8")]
	public int m_NumDaysSurvived;

	[Token(Token = "0x4004AAD")]
	[FieldOffset(Offset = "0xEC")]
	public float m_NumDaysSurvivedHourOffset;

	[Token(Token = "0x4004AAE")]
	[FieldOffset(Offset = "0xF0")]
	public int m_ConsecutiveNightsSurvived;

	[Token(Token = "0x4004AAF")]
	[FieldOffset(Offset = "0xF4")]
	public int m_FullyHarvestedDeer;

	[Token(Token = "0x4004AB0")]
	[FieldOffset(Offset = "0xF8")]
	public bool m_StartedNightOutside;

	[Token(Token = "0x4004AB1")]
	[FieldOffset(Offset = "0xF9")]
	public bool m_WentInsideThisNight;

	[Token(Token = "0x4004AB2")]
	[FieldOffset(Offset = "0xFA")]
	public bool m_HasFiredGun;

	[Token(Token = "0x4004AB3")]
	[FieldOffset(Offset = "0xFB")]
	public bool m_HasKilledSomething;

	[Token(Token = "0x4004AB4")]
	[FieldOffset(Offset = "0xFC")]
	public bool m_LakeRegionAllInteriors;

	[Token(Token = "0x4004AB5")]
	[FieldOffset(Offset = "0xFD")]
	public bool m_CoastalRegionAllInteriors;

	[Token(Token = "0x4004AB6")]
	[FieldOffset(Offset = "0x100")]
	public int m_NumDaysLivingOffLand;

	[Token(Token = "0x4004AB7")]
	[FieldOffset(Offset = "0x104")]
	public bool m_UsedRosehipTea;

	[Token(Token = "0x4004AB8")]
	[FieldOffset(Offset = "0x105")]
	public bool m_UsedReishiTea;

	[Token(Token = "0x4004AB9")]
	[FieldOffset(Offset = "0x106")]
	public bool m_UsedOldMansBeardDressing;

	[Token(Token = "0x4004ABA")]
	[FieldOffset(Offset = "0x108")]
	public int m_NumRosehipPlantsHarvested;

	[Token(Token = "0x4004ABB")]
	[FieldOffset(Offset = "0x10C")]
	public int m_NumReishiPlantsHarvested;

	[Token(Token = "0x4004ABC")]
	[FieldOffset(Offset = "0x110")]
	public int m_NumOldMansPlantsHarvested;

	[Token(Token = "0x4004ABD")]
	[FieldOffset(Offset = "0x114")]
	public int m_NumCatTailPlantsHarvested;

	[Token(Token = "0x4004ABE")]
	[FieldOffset(Offset = "0x118")]
	public int m_NumDaysCalorieStoreAboveZero;

	[Token(Token = "0x4004ABF")]
	[FieldOffset(Offset = "0x11C")]
	public int m_NumArcheryBooksRead;

	[Token(Token = "0x4004AC0")]
	[FieldOffset(Offset = "0x120")]
	public int m_NumCarcassHarvestingBooksRead;

	[Token(Token = "0x4004AC1")]
	[FieldOffset(Offset = "0x124")]
	public int m_NumCookingBooksRead;

	[Token(Token = "0x4004AC2")]
	[FieldOffset(Offset = "0x128")]
	public int m_NumFireStartingBooksRead;

	[Token(Token = "0x4004AC3")]
	[FieldOffset(Offset = "0x12C")]
	public int m_NumIceFishingBooksRead;

	[Token(Token = "0x4004AC4")]
	[FieldOffset(Offset = "0x130")]
	public int m_NumMendingBooksRead;

	[Token(Token = "0x4004AC5")]
	[FieldOffset(Offset = "0x134")]
	public int m_NumRifleFirearmAdvancedBooksRead;

	[Token(Token = "0x4004AC6")]
	[FieldOffset(Offset = "0x138")]
	public int m_NumRifleFirearmBooksRead;

	[Token(Token = "0x4004AC7")]
	[FieldOffset(Offset = "0x13C")]
	public int m_NumRevolverBooksRead;

	[Token(Token = "0x4004AC8")]
	[FieldOffset(Offset = "0x140")]
	public int m_NumGunsmithingBooksRead;

	[Token(Token = "0x4004AC9")]
	[FieldOffset(Offset = "0x144")]
	public int m_NumImprovisedKnivesCrafted;

	[Token(Token = "0x4004ACA")]
	[FieldOffset(Offset = "0x148")]
	public int m_NumImprovisedHatchetsCrafted;

	[Token(Token = "0x4004ACB")]
	[FieldOffset(Offset = "0x14C")]
	public int m_LongestBurningCampFire;

	[Token(Token = "0x4004ACC")]
	[FieldOffset(Offset = "0x150")]
	public bool m_FoundAllCachesEpisodeOne;

	[Token(Token = "0x4004ACD")]
	[FieldOffset(Offset = "0x151")]
	public bool m_FoundAllCachesEpisodeTwo;

	[Token(Token = "0x4004ACE")]
	[FieldOffset(Offset = "0x154")]
	public int m_NumTimberwolfPacksDefeated;

	[Token(Token = "0x4004ACF")]
	[FieldOffset(Offset = "0x158")]
	public int m_NumPtarmiganKilledWithArrows;

	[Token(Token = "0x4004AD0")]
	[FieldOffset(Offset = "0x15C")]
	public int m_NumRabbitsKilledWithHardenedArrows;

	[Token(Token = "0x4004AD1")]
	[FieldOffset(Offset = "0x160")]
	public int m_NumSpecialRecipesCooked;

	[Token(Token = "0x4004AD2")]
	[FieldOffset(Offset = "0x164")]
	public int m_HoursSurvivedInsideLangstonMineStart;

	[Token(Token = "0x4004AD3")]
	[FieldOffset(Offset = "0x168")]
	public bool m_PrepperCachesExploredChecked;

	[Token(Token = "0x4004AD4")]
	[FieldOffset(Offset = "0x170")]
	private readonly List<string> m_VistaLocationsVisited;

	[Token(Token = "0x4004AD5")]
	[FieldOffset(Offset = "0x178")]
	private readonly Dictionary<string, int> m_FilmPhotoCounts;

	[Token(Token = "0x4004AD6")]
	[FieldOffset(Offset = "0x180")]
	private readonly Dictionary<string, int> m_RegionPhotoCounts;

	[Token(Token = "0x4004AD7")]
	[FieldOffset(Offset = "0x188")]
	private readonly List<string> m_MementoRegions;

	[Token(Token = "0x4004AD8")]
	[FieldOffset(Offset = "0x190")]
	private readonly List<string> m_PrepperCachesExplored;

	[Token(Token = "0x4004AD9")]
	[FieldOffset(Offset = "0x198")]
	private readonly List<string> m_CollectedExpansionFirearmVariants;

	[Token(Token = "0x4004ADA")]
	[FieldOffset(Offset = "0x1A0")]
	private readonly List<string> m_CollectedInsulatedFlaskVariants;

	[Token(Token = "0x4004ADB")]
	[FieldOffset(Offset = "0x1A8")]
	private readonly Dictionary<string, int> m_RareFishCaught;

	[Token(Token = "0x4004ADC")]
	[FieldOffset(Offset = "0x1B0")]
	private readonly Dictionary<string, int> m_LureCollection;

	[Token(Token = "0x4004ADD")]
	[FieldOffset(Offset = "0x1B8")]
	public readonly Dictionary<string, bool> m_MappedRegions;

	[Token(Token = "0x4004ADE")]
	[FieldOffset(Offset = "0x1C0")]
	public bool m_KilledBear;

	[Token(Token = "0x4004ADF")]
	[FieldOffset(Offset = "0x1C1")]
	public bool m_WrappedInFur;

	[Token(Token = "0x4004AE0")]
	[FieldOffset(Offset = "0x1C2")]
	public bool m_CaughtBigFish;

	[Token(Token = "0x4004AE1")]
	[FieldOffset(Offset = "0x1C3")]
	public bool m_StunnedRabitFarAway;

	[Token(Token = "0x4004AE2")]
	[FieldOffset(Offset = "0x1C4")]
	public bool m_ClothingSlotsAllPerfect;

	[Token(Token = "0x4004AE3")]
	[FieldOffset(Offset = "0x1C5")]
	private bool m_IsInsideLangstonMine;

	[Token(Token = "0x4004AE4")]
	[FieldOffset(Offset = "0x1C8")]
	private int m_DaysSurvivedInsideLangstonMine;

	[Token(Token = "0x4004AE5")]
	[FieldOffset(Offset = "0x1D0")]
	private readonly bool[] m_ChallengeAchievements;

	[Token(Token = "0x4004AE6")]
	private static AsyncOperationHandle<IList<GearItemData>> s_ValidExpansionFirearmsHandle;

	[Token(Token = "0x4004AE7")]
	[FieldOffset(Offset = "0x1D8")]
	private int m_Version;

	[Token(Token = "0x4004AE8")]
	[FieldOffset(Offset = "0x1DC")]
	private bool m_Initialized;

	[Token(Token = "0x4004AE9")]
	private static AchievementSaveData m_AchievementSaveData;

	[Token(Token = "0x4004AEA")]
	[FieldOffset(Offset = "0x1DD")]
	private bool m_SaveProfileRequested;

	[Token(Token = "0x4004AEB")]
	public static bool s_DebugVerbose;

	[Token(Token = "0x6003D81")]
	[Address(RVA = "0xB99EE0", Offset = "0xB98CE0", Length = "0x477")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D82")]
	[Address(RVA = "0xB9A360", Offset = "0xB99160", Length = "0x5C")]
	private void MaybeSaveProfile()
	{
	}

	[Token(Token = "0x6003D83")]
	[Address(RVA = "0xB9A3C0", Offset = "0xB991C0", Length = "0x30A")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D84")]
	[Address(RVA = "0xB9A6D0", Offset = "0xB994D0", Length = "0xB2D")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003D85")]
	[Address(RVA = "0xB9B200", Offset = "0xB9A000", Length = "0x1324")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003D86")]
	[Address(RVA = "0xB9C530", Offset = "0xB9B330", Length = "0x113")]
	public void UpdateAchievements()
	{
	}

	[Token(Token = "0x6003D87")]
	[Address(RVA = "0xB9C650", Offset = "0xB9B450", Length = "0x126")]
	public void UpdateDaysSurvived(int numDays)
	{
	}

	[Token(Token = "0x6003D88")]
	[Address(RVA = "0xB9C780", Offset = "0xB9B580", Length = "0x3B")]
	public void UpdateHoursSurvived(int hours)
	{
	}

	[Token(Token = "0x6003D89")]
	[Address(RVA = "0xB9C7C0", Offset = "0xB9B5C0", Length = "0x61")]
	public void SendStat(GameIntStatType statistic, int amount)
	{
	}

	[Token(Token = "0x6003D8A")]
	[Address(RVA = "0xB9C830", Offset = "0xB9B630", Length = "0xFF")]
	public void SendStat(GameFloatStatType statistic, float amount)
	{
	}

	[Token(Token = "0x6003D8B")]
	[Address(RVA = "0xB9C930", Offset = "0xB9B730", Length = "0xF1")]
	public void SendStat(GameEventStatType statistic)
	{
	}

	[Token(Token = "0x6003D8C")]
	[Address(RVA = "0xB9CA30", Offset = "0xB9B830", Length = "0x93")]
	public void NightStarted()
	{
	}

	[Token(Token = "0x6003D8D")]
	[Address(RVA = "0xB9CAD0", Offset = "0xB9B8D0", Length = "0xB2")]
	public void NightEnded()
	{
	}

	[Token(Token = "0x6003D8E")]
	[Address(RVA = "0xB9CB90", Offset = "0xB9B990", Length = "0x12")]
	public void WentInsideDuringNight()
	{
	}

	[Token(Token = "0x6003D8F")]
	[Address(RVA = "0xB9CBB0", Offset = "0xB9B9B0", Length = "0x71")]
	public void FullyHarvestedDeer()
	{
	}

	[Token(Token = "0x6003D90")]
	[Address(RVA = "0xB9CC30", Offset = "0xB9BA30", Length = "0x118")]
	public void AteFoodItem(FoodItem foodItem)
	{
	}

	[Token(Token = "0x6003D91")]
	[Address(RVA = "0xB9CD50", Offset = "0xB9BB50", Length = "0x17E")]
	private void MaybeUpdateRareFishAchievement(GearItem fishItem)
	{
	}

	[Token(Token = "0x6003D92")]
	[Address(RVA = "0xB9CED0", Offset = "0xB9BCD0", Length = "0x1F2")]
	public void CaughtFish(GearItem fishItem)
	{
	}

	[Token(Token = "0x6003D93")]
	[Address(RVA = "0xB9D0D0", Offset = "0xB9BED0", Length = "0x18")]
	public void MaybeUnlockStoneAgeSniper(float distance)
	{
	}

	[Token(Token = "0x6003D94")]
	[Address(RVA = "0xB9D0F0", Offset = "0xB9BEF0", Length = "0xD")]
	public void PtarmiganKilledWithArrow()
	{
	}

	[Token(Token = "0x6003D95")]
	[Address(RVA = "0xB9D100", Offset = "0xB9BF00", Length = "0xD")]
	public void RabbitKilledWithHardenedArrow()
	{
	}

	[Token(Token = "0x6003D96")]
	[Address(RVA = "0xB9D110", Offset = "0xB9BF10", Length = "0xE")]
	public void SetWearingPerfectClothesInAllSlots()
	{
	}

	[Token(Token = "0x6003D97")]
	[Address(RVA = "0xB9D120", Offset = "0xB9BF20", Length = "0x232")]
	public void WentToSleep(GearItem bedroll)
	{
	}

	[Token(Token = "0x6003D98")]
	[Address(RVA = "0xB9D360", Offset = "0xB9C160", Length = "0x1F8")]
	public void UsedMedicine(GearItem medicineItem)
	{
	}

	[Token(Token = "0x6003D99")]
	[Address(RVA = "0xB9D560", Offset = "0xB9C360", Length = "0x14E")]
	public void HarvestedPlant(string plantName)
	{
	}

	[Token(Token = "0x6003D9A")]
	[Address(RVA = "0xB9D6B0", Offset = "0xB9C4B0", Length = "0x22E")]
	public void ResearchedBook(string bookName)
	{
	}

	[Token(Token = "0x6003D9B")]
	[Address(RVA = "0xB9D8E0", Offset = "0xB9C6E0", Length = "0x22C")]
	private void MaybeUpdateLureAchievement(GearItem gearItem)
	{
	}

	[Token(Token = "0x6003D9C")]
	[Address(RVA = "0xB9DB10", Offset = "0xB9C910", Length = "0xB5")]
	public void CraftedItem(GearItem gearItem, string itemName)
	{
	}

	[Token(Token = "0x6003D9D")]
	[Address(RVA = "0xB9DBD0", Offset = "0xB9C9D0", Length = "0xD")]
	public void DefeatTimberwolfPack()
	{
	}

	[Token(Token = "0x6003D9E")]
	[Address(RVA = "0xB9DBE0", Offset = "0xB9C9E0", Length = "0x34")]
	public void SetLongestBurningCampFire(float hours)
	{
	}

	[Token(Token = "0x6003D9F")]
	[Address(RVA = "0xB9DC20", Offset = "0xB9CA20", Length = "0x1D4")]
	public void TriggeredLevelLoad(string sceneName, string guid, bool alreadyExplored)
	{
	}

	[Token(Token = "0x6003DA0")]
	[Address(RVA = "0xB9DE00", Offset = "0xB9CC00", Length = "0x1B3")]
	private void MaybeUpdatePrepperCacheAchievement()
	{
	}

	[Token(Token = "0x6003DA1")]
	[Address(RVA = "0xB9DFC0", Offset = "0xB9CDC0", Length = "0x290")]
	private void MaybeUpdateExploredPrepperCache(string keyName)
	{
	}

	[Token(Token = "0x6003DA2")]
	[Address(RVA = "0xB9E260", Offset = "0xB9D060", Length = "0x10E")]
	private void ExploredNewInterior()
	{
	}

	[Token(Token = "0x6003DA3")]
	[Address(RVA = "0xB9E370", Offset = "0xB9D170", Length = "0xFD")]
	private void ExploredPrepperCache(string sceneName, string guid)
	{
	}

	[Token(Token = "0x6003DA4")]
	[Address(RVA = "0xB9E470", Offset = "0xB9D270", Length = "0xC7")]
	public void TrackVistaLocationVisited(string guid)
	{
	}

	[Token(Token = "0x6003DA5")]
	[Address(RVA = "0xB9E540", Offset = "0xB9D340", Length = "0x2E")]
	public void SetChallengeAchievementStatus(ChallengeAchievement type, bool completed)
	{
	}

	[Token(Token = "0x6003DA6")]
	[Address(RVA = "0xB9E570", Offset = "0xB9D370", Length = "0xB")]
	public void ResetNumDaysCalorieStoreAboveZero()
	{
	}

	[Token(Token = "0x6003DA7")]
	[Address(RVA = "0xB9E580", Offset = "0xB9D380", Length = "0x330")]
	public void MaybeUnlockFaithfulCartographer(string sceneName, bool areAllNamedLocationsUnlocked)
	{
	}

	[Token(Token = "0x6003DA8")]
	[Address(RVA = "0xB9E8C0", Offset = "0xB9D6C0", Length = "0x1ED")]
	public bool IsRegionCompleteFaithfulCartographer(string sceneName, ref int numCompleted, ref int total)
	{
		return false;
	}

	[Token(Token = "0x6003DA9")]
	[Address(RVA = "0xB9EAB0", Offset = "0xB9D8B0", Length = "0xD")]
	public void CookedSpecialRecipe()
	{
	}

	[Token(Token = "0x6003DAA")]
	[Address(RVA = "0xB9EAC0", Offset = "0xB9D8C0", Length = "0x151")]
	public void PickedUpMemento(RegionSpecification region)
	{
	}

	[Token(Token = "0x6003DAB")]
	[Address(RVA = "0xB9EC20", Offset = "0xB9DA20", Length = "0x292")]
	public void PickedUpWeapon(GearItemData gearItemData)
	{
	}

	[Token(Token = "0x6003DAC")]
	[Address(RVA = "0xB9EEC0", Offset = "0xB9DCC0", Length = "0xF7")]
	public void PickedUpInsulatedFlask(GearItemData gearItemData)
	{
	}

	[Token(Token = "0x6003DAD")]
	[Address(RVA = "0xB9EFC0", Offset = "0xB9DDC0", Length = "0x1FE")]
	public void ResetSingleGameAchievements()
	{
	}

	[Token(Token = "0x6003DAE")]
	[Address(RVA = "0xB9F1C0", Offset = "0xB9DFC0", Length = "0xDF")]
	public static void ListAllUnlockedAchievements()
	{
	}

	[Token(Token = "0x6003DAF")]
	[Address(RVA = "0xB9F2A0", Offset = "0xB9E0A0", Length = "0x14B")]
	public static void UnlockAchievement(Achievement achievement)
	{
	}

	[Token(Token = "0x6003DB0")]
	[Address(RVA = "0xB9F3F0", Offset = "0xB9E1F0", Length = "0x291")]
	private void MaybeUnlockFaithfulCartographerForAllRegions()
	{
	}

	[Token(Token = "0x6003DB1")]
	[Address(RVA = "0xB9F690", Offset = "0xB9E490", Length = "0x19FC")]
	private void CheckAchievements()
	{
	}

	[Token(Token = "0x6003DB2")]
	[Address(RVA = "0xBA11A0", Offset = "0xB9FFA0", Length = "0x2B0")]
	private bool CheckInteriors(string sceneName)
	{
		return false;
	}

	[Token(Token = "0x6003DB3")]
	[Address(RVA = "0xBA1460", Offset = "0xBA0260", Length = "0x1B2")]
	private static bool CompletedAllChallenges()
	{
		return false;
	}

	[Token(Token = "0x6003DB4")]
	[Address(RVA = "0xBA1620", Offset = "0xBA0420", Length = "0x31F")]
	public void OnPhotoTaken(RegionSpecification region, GearItemData filmUsed)
	{
	}

	[Token(Token = "0x6003DB5")]
	[Address(RVA = "0xBA1940", Offset = "0xBA0740", Length = "0x727")]
	public AchievementManager()
	{
	}
}
