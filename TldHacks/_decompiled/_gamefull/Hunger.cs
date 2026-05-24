using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001F2")]
public class Hunger : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentReserveCalories;

	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x24")]
	private float m_ReserveCaloriesAccumulator;

	[Token(Token = "0x4001170")]
	[FieldOffset(Offset = "0x28")]
	public float m_SlightlyHungryCalorieThreshold;

	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HungryCalorieThreshold;

	[Token(Token = "0x4001172")]
	[FieldOffset(Offset = "0x30")]
	public float m_VeryHungryCalorieThreshold;

	[Token(Token = "0x4001173")]
	[FieldOffset(Offset = "0x34")]
	public float m_StarvingCalorieThreshold;

	[Token(Token = "0x4001174")]
	[FieldOffset(Offset = "0x38")]
	public string m_SlightlyHungryVoiceOver;

	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0x40")]
	public string m_HungryVoiceOver;

	[Token(Token = "0x4001176")]
	[FieldOffset(Offset = "0x48")]
	public string m_VeryHungryVoiceOver;

	[Token(Token = "0x4001177")]
	[FieldOffset(Offset = "0x50")]
	public string m_StarvingVoiceOver;

	[Token(Token = "0x4001178")]
	[FieldOffset(Offset = "0x58")]
	public float m_MinSecondsBetweenVoiceOverVariations;

	[Token(Token = "0x4001179")]
	[FieldOffset(Offset = "0x5C")]
	public float m_TimeToDisplayCaloriesWhenChanged;

	[Token(Token = "0x400117A")]
	[FieldOffset(Offset = "0x60")]
	public float m_TimeToDisplayHungerWhenChanged;

	[Range(0f, 48f)]
	[Token(Token = "0x400117B")]
	[FieldOffset(Offset = "0x64")]
	public float m_HoursStarvingBeforeFatiguePenalty;

	[Range(0f, 50f)]
	[Token(Token = "0x400117C")]
	[FieldOffset(Offset = "0x68")]
	public float m_FatiguePenaltyPerHourIncrease;

	[Range(0f, 50f)]
	[Token(Token = "0x400117D")]
	[FieldOffset(Offset = "0x6C")]
	public float m_FatiguePenaltyPerHourDecrease;

	[Range(0f, 100f)]
	[Token(Token = "0x400117E")]
	[FieldOffset(Offset = "0x70")]
	public float m_MaxFatiguePenalty;

	[Range(-1000f, 2000f)]
	[Token(Token = "0x400117F")]
	[FieldOffset(Offset = "0x74")]
	public float m_HungerStartsAtCalories;

	[Range(0f, 5000f)]
	[Token(Token = "0x4001180")]
	[FieldOffset(Offset = "0x78")]
	public float m_MaxReserveCalories;

	[Range(-5000f, 0f)]
	[Token(Token = "0x4001181")]
	[FieldOffset(Offset = "0x7C")]
	public float m_MaxDeficitCalories;

	[Range(0f, 5000f)]
	[Token(Token = "0x4001182")]
	[FieldOffset(Offset = "0x80")]
	public float m_StartingReserveCalories;

	[Header("Calorie Burn")]
	[Range(0f, 1000f)]
	[Token(Token = "0x4001183")]
	[FieldOffset(Offset = "0x84")]
	public float m_CalorieBurnPerHourSleeping;

	[Range(0f, 1000f)]
	[Token(Token = "0x4001184")]
	[FieldOffset(Offset = "0x88")]
	public float m_CalorieBurnPerHourStanding;

	[Range(0f, 1000f)]
	[Token(Token = "0x4001185")]
	[FieldOffset(Offset = "0x8C")]
	public float m_CalorieBurnPerHourWalking;

	[Range(0f, 1000f)]
	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x90")]
	public float m_CalorieBurnPerHourSprinting;

	[Range(0f, 1000f)]
	[Token(Token = "0x4001187")]
	[FieldOffset(Offset = "0x94")]
	public float m_CalorieBurnPerHourBreakingDown;

	[Range(0f, 1000f)]
	[Token(Token = "0x4001188")]
	[FieldOffset(Offset = "0x98")]
	public float m_CalorieBurnPerHourBuildingSnowShelter;

	[Range(0f, 1000f)]
	[Token(Token = "0x4001189")]
	[FieldOffset(Offset = "0x9C")]
	public float m_CalorieBurnPerHourRepairingSnowShelter;

	[Range(0f, 1000f)]
	[Token(Token = "0x400118A")]
	[FieldOffset(Offset = "0xA0")]
	public float m_CalorieBurnPerHourDismantlingSnowShelter;

	[Range(0f, 1000f)]
	[Token(Token = "0x400118B")]
	[FieldOffset(Offset = "0xA4")]
	public float m_CalorieBurnPerHourHarvestingCarcass;

	[Range(0f, 1000f)]
	[Token(Token = "0x400118C")]
	[FieldOffset(Offset = "0xA8")]
	public float m_CalorieBurnPerHourClimbing;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400118D")]
	[FieldOffset(Offset = "0xB0")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0xB8")]
	private float m_CurrentCalorieBurnPerHour;

	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0xBC")]
	private HungerLevel m_HungerLevelForPreviousVoiceOver;

	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0xC0")]
	private float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x4001191")]
	[FieldOffset(Offset = "0xC8")]
	private FoodItem m_FoodItemProvidingCalories;

	[Token(Token = "0x4001192")]
	[FieldOffset(Offset = "0xD0")]
	private float m_CaloriesToAddOverTime;

	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0xD4")]
	private float m_CaloriesLeftToAdd;

	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0xD8")]
	private float m_CalroiesToAddOverTimeDuration;

	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0xDC")]
	private float m_TimeDisableCaloriesOnHUD;

	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0xE0")]
	private float m_TimeDisableHungerOnHUD;

	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0xE4")]
	private int m_HungerLevelLastStatusChange;

	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0xE8")]
	private float m_NumHoursStarving;

	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0xEC")]
	private float m_FatiguePenalty;

	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_StarvingInLog;

	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0xF1")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400119C")]
	[FieldOffset(Offset = "0xF2")]
	private bool m_SuppressVoiceOver;

	[Token(Token = "0x400119D")]
	private static HungerSaveDataProxy m_HungerSaveDataProxy;

	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x640D80", Offset = "0x63FB80", Length = "0x1B1")]
	public void Start()
	{
	}

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x640F40", Offset = "0x63FD40", Length = "0x318")]
	public void Update()
	{
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x641260", Offset = "0x640060", Length = "0x1B3")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x641420", Offset = "0x640220", Length = "0xCE")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x6414F0", Offset = "0x6402F0", Length = "0x1AD")]
	public void AddReserveCalories(float calories)
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x6416A0", Offset = "0x6404A0", Length = "0x137")]
	public void RemoveReserveCalories(float calories)
	{
	}

	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x6417E0", Offset = "0x6405E0", Length = "0x78")]
	public void AddReserveCaloriesOverTime(FoodItem fi, float calories, float timeSeconds)
	{
	}

	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x641860", Offset = "0x640660", Length = "0x52")]
	public void ResetFoodItemProvingCalories()
	{
	}

	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x6418C0", Offset = "0x6406C0", Length = "0x23")]
	public float GetAdjustedMaxReserveCalories()
	{
		return 0f;
	}

	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x6418F0", Offset = "0x6406F0", Length = "0x88")]
	public float GetMaxReserveCaloriesModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x641980", Offset = "0x640780", Length = "0xCD")]
	public bool IsEatingInProgress()
	{
		return false;
	}

	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x641A50", Offset = "0x640850", Length = "0xB")]
	public void ClearAddReserveCaloriesOverTime()
	{
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x641A60", Offset = "0x640860", Length = "0x12")]
	public bool IsAddingCaloriesOverTime()
	{
		return false;
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x641A80", Offset = "0x640880", Length = "0x11D")]
	public bool ItemBeingEatenAffectsThirst()
	{
		return false;
	}

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x502670", Offset = "0x501470", Length = "0x8")]
	public FoodItem GetItemBeingEaten()
	{
		return null;
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x641BA0", Offset = "0x6409A0", Length = "0x9")]
	public float GetCaloriesToAddOverTime()
	{
		return 0f;
	}

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x641BB0", Offset = "0x6409B0", Length = "0xD")]
	public bool IsStarving()
	{
		return false;
	}

	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x549440", Offset = "0x548240", Length = "0x9")]
	public void SetCalorieBurnPerHour(float burnRate)
	{
	}

	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
	public float GetCalorieReserves()
	{
		return 0f;
	}

	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x549430", Offset = "0x548230", Length = "0x9")]
	public float GetCurrentCalorieBurnPerHour()
	{
		return 0f;
	}

	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x641BC0", Offset = "0x6409C0", Length = "0xBD")]
	public void DisplayCaloriesOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x54FA10", Offset = "0x54E810", Length = "0x9")]
	public float GetFatiguePenalty()
	{
		return 0f;
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x641C80", Offset = "0x640A80", Length = "0x7")]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x641C90", Offset = "0x640A90", Length = "0x485")]
	private void UpdateCalorieReserves()
	{
	}

	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x642120", Offset = "0x640F20", Length = "0xD4")]
	private bool ShouldPlayHungerVoiceOver()
	{
		return false;
	}

	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x642200", Offset = "0x641000", Length = "0x208")]
	private void MaybePlayPlayerHungryVoiceOver()
	{
	}

	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x642410", Offset = "0x641210", Length = "0x43")]
	private HungerLevel GetHungerLevel()
	{
		return default(HungerLevel);
	}

	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x642460", Offset = "0x641260", Length = "0x490")]
	private void UpdateCaloriesOnHUD(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x642900", Offset = "0x641700", Length = "0xBD")]
	private void DisplayHungerOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x6429C0", Offset = "0x6417C0", Length = "0xEF")]
	private string GetHungerTextForHud()
	{
		return null;
	}

	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x642AB0", Offset = "0x6418B0", Length = "0x364")]
	private void MaybeUpdateStarvingStatusLabel(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x642E20", Offset = "0x641C20", Length = "0x14B")]
	private string GetHungerIconName(int currHungerLevel)
	{
		return null;
	}

	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x642F70", Offset = "0x641D70", Length = "0x2F1")]
	private void UpdateStarvingStatusOnHUD(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x643270", Offset = "0x642070", Length = "0x64")]
	private float CalculateNextCaloriesThresholdForDisplayOnHud()
	{
		return 0f;
	}

	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x6432E0", Offset = "0x6420E0", Length = "0x132")]
	private void MaybeUpdateStarvingStatusInLog()
	{
	}

	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x643420", Offset = "0x642220", Length = "0x1F4")]
	private void UpdateFatiguePenalty()
	{
	}

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Hunger()
	{
	}
}
