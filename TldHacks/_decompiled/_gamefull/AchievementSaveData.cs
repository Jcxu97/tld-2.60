using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;

[Token(Token = "0x2000706")]
public class AchievementSaveData
{
	[Token(Token = "0x4004A5D")]
	[FieldOffset(Offset = "0x10")]
	public int m_Version;

	[Token(Token = "0x4004A5E")]
	[FieldOffset(Offset = "0x14")]
	public int m_NumDaysSurvived;

	[Token(Token = "0x4004A5F")]
	[FieldOffset(Offset = "0x18")]
	public float m_NumDaysSurvivedHourOffset;

	[Token(Token = "0x4004A60")]
	[FieldOffset(Offset = "0x1C")]
	public int m_ConsecutiveNightsSurvived;

	[Token(Token = "0x4004A61")]
	[FieldOffset(Offset = "0x20")]
	public int m_FullyHarvestedDeer;

	[Token(Token = "0x4004A62")]
	[FieldOffset(Offset = "0x24")]
	public bool m_StartedNightOutside;

	[Token(Token = "0x4004A63")]
	[FieldOffset(Offset = "0x25")]
	public bool m_WentInsideThisNight;

	[Token(Token = "0x4004A64")]
	[FieldOffset(Offset = "0x26")]
	public bool m_HasFiredGun;

	[Token(Token = "0x4004A65")]
	[FieldOffset(Offset = "0x27")]
	public bool m_HasKilledSomething;

	[Token(Token = "0x4004A66")]
	[FieldOffset(Offset = "0x28")]
	public bool m_LakeRegionAllInteriors;

	[Token(Token = "0x4004A67")]
	[FieldOffset(Offset = "0x29")]
	public bool m_CoastalRegionAllInteriors;

	[Token(Token = "0x4004A68")]
	[FieldOffset(Offset = "0x2C")]
	public int m_NumDaysLivingOffLand;

	[Token(Token = "0x4004A69")]
	[FieldOffset(Offset = "0x30")]
	public bool m_UsedRosehipTea;

	[Token(Token = "0x4004A6A")]
	[FieldOffset(Offset = "0x31")]
	public bool m_UsedReishiTea;

	[Token(Token = "0x4004A6B")]
	[FieldOffset(Offset = "0x32")]
	public bool m_UsedOldMansBeardDressing;

	[Token(Token = "0x4004A6C")]
	[FieldOffset(Offset = "0x34")]
	public int m_NumRosehipPlantsHarvested;

	[Token(Token = "0x4004A6D")]
	[FieldOffset(Offset = "0x38")]
	public int m_NumReishiPlantsHarvested;

	[Token(Token = "0x4004A6E")]
	[FieldOffset(Offset = "0x3C")]
	public int m_NumOldMansPlantsHarvested;

	[Token(Token = "0x4004A6F")]
	[FieldOffset(Offset = "0x40")]
	public int m_NumCatTailPlantsHarvested;

	[Token(Token = "0x4004A70")]
	[FieldOffset(Offset = "0x44")]
	public int m_NumDaysCalorieStoreAboveZero;

	[Token(Token = "0x4004A71")]
	[FieldOffset(Offset = "0x48")]
	public int m_NumArcheryBooksRead;

	[Token(Token = "0x4004A72")]
	[FieldOffset(Offset = "0x4C")]
	public int m_NumCarcassHarvestingBooksRead;

	[Token(Token = "0x4004A73")]
	[FieldOffset(Offset = "0x50")]
	public int m_NumCookingBooksRead;

	[Token(Token = "0x4004A74")]
	[FieldOffset(Offset = "0x54")]
	public int m_NumFireStartingBooksRead;

	[Token(Token = "0x4004A75")]
	[FieldOffset(Offset = "0x58")]
	public int m_NumIceFishingBooksRead;

	[Token(Token = "0x4004A76")]
	[FieldOffset(Offset = "0x5C")]
	public int m_NumMendingBooksRead;

	[Token(Token = "0x4004A77")]
	[FieldOffset(Offset = "0x60")]
	public int m_NumRifleFirearmAdvancedBooksRead;

	[Token(Token = "0x4004A78")]
	[FieldOffset(Offset = "0x64")]
	public int m_NumRifleFirearmBooksRead;

	[Token(Token = "0x4004A79")]
	[FieldOffset(Offset = "0x68")]
	public int m_NumRevolverBooksRead;

	[Token(Token = "0x4004A7A")]
	[FieldOffset(Offset = "0x6C")]
	public int m_NumGunsmithingBooksRead;

	[Token(Token = "0x4004A7B")]
	[FieldOffset(Offset = "0x70")]
	public int m_NumImprovisedKnivesCrafted;

	[Token(Token = "0x4004A7C")]
	[FieldOffset(Offset = "0x74")]
	public int m_NumImprovisedHatchetsCrafted;

	[Token(Token = "0x4004A7D")]
	[FieldOffset(Offset = "0x78")]
	public int m_LongestBurningCampFire;

	[Token(Token = "0x4004A7E")]
	[FieldOffset(Offset = "0x7C")]
	public bool m_FoundAllCachesEpisodeOne;

	[Token(Token = "0x4004A7F")]
	[FieldOffset(Offset = "0x7D")]
	public bool m_FoundAllCachesEpisodeTwo;

	[Token(Token = "0x4004A80")]
	[FieldOffset(Offset = "0x80")]
	public int m_NumTimberwolfPacksDefeated;

	[Token(Token = "0x4004A81")]
	[FieldOffset(Offset = "0x84")]
	public int m_NumPtarmiganKilledWithArrows;

	[Token(Token = "0x4004A82")]
	[FieldOffset(Offset = "0x88")]
	public int m_NumRabbitsKilledWithHardenedArrows;

	[Token(Token = "0x4004A83")]
	[FieldOffset(Offset = "0x8C")]
	public int m_NumSpecialRecipesCooked;

	[Token(Token = "0x4004A84")]
	[FieldOffset(Offset = "0x90")]
	public List<string> m_VistaLocationsVisited;

	[Token(Token = "0x4004A85")]
	[FieldOffset(Offset = "0x98")]
	public Dictionary<string, bool> m_MappedRegions;

	[Token(Token = "0x4004A86")]
	[FieldOffset(Offset = "0xA0")]
	public Dictionary<string, int> m_RareFishCaught;

	[Token(Token = "0x4004A87")]
	[FieldOffset(Offset = "0xA8")]
	public Dictionary<string, int> m_LureCollection;

	[Token(Token = "0x4004A88")]
	[FieldOffset(Offset = "0xB0")]
	public Dictionary<string, int> m_FilmPhotoCounts;

	[Token(Token = "0x4004A89")]
	[FieldOffset(Offset = "0xB8")]
	public Dictionary<string, int> m_RegionPhotoCounts;

	[Token(Token = "0x4004A8A")]
	[FieldOffset(Offset = "0xC0")]
	public List<string> m_MementoRegions;

	[Token(Token = "0x4004A8B")]
	[FieldOffset(Offset = "0xC8")]
	public List<string> m_PrepperCachesExplored;

	[Token(Token = "0x4004A8C")]
	[FieldOffset(Offset = "0xD0")]
	public bool m_PrepperCachesExploredChecked;

	[DefaultValue(-1)]
	[Token(Token = "0x4004A8D")]
	[FieldOffset(Offset = "0xD4")]
	public int m_HoursSurvivedInsideLangstonMineStart;

	[Token(Token = "0x4004A8E")]
	[FieldOffset(Offset = "0xD8")]
	public List<string> m_CollectedExpansionFirearmVariants;

	[Token(Token = "0x4004A8F")]
	[FieldOffset(Offset = "0xE0")]
	public List<string> m_CollectedInsulatedFlaskVariants;

	[Token(Token = "0x6003D80")]
	[Address(RVA = "0xB99ED0", Offset = "0xB98CD0", Length = "0xB")]
	public AchievementSaveData()
	{
	}
}
