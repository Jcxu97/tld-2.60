using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001E9")]
public class Freezing : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x40010FF")]
	[FieldOffset(Offset = "0x20")]
	public float m_CurrentFreezingPerHour;

	[HideInInspector]
	[Token(Token = "0x4001100")]
	[FieldOffset(Offset = "0x24")]
	public float m_CurrentWarmingPerHour;

	[Header("Basics")]
	[Token(Token = "0x4001101")]
	[FieldOffset(Offset = "0x28")]
	public float m_CurrentFreezing;

	[Token(Token = "0x4001102")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxFreezing;

	[Token(Token = "0x4001103")]
	[FieldOffset(Offset = "0x30")]
	public float m_TemperatureFreezingStarts;

	[Token(Token = "0x4001104")]
	[FieldOffset(Offset = "0x34")]
	public float m_FreezingIncreasePerHourPerDegreeCelsius;

	[Token(Token = "0x4001105")]
	[FieldOffset(Offset = "0x38")]
	public float m_WarmingIncreasePerHourPerDegreeCelsius;

	[Token(Token = "0x4001106")]
	[FieldOffset(Offset = "0x3C")]
	public float m_CalorieBurnMultiplier;

	[Header("Thresholds")]
	[Token(Token = "0x4001107")]
	[FieldOffset(Offset = "0x40")]
	public float m_SlightlyColdThreshold;

	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x44")]
	public float m_ColdThreshold;

	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x48")]
	public float m_VeryColdThreshold;

	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FreezingThreshold;

	[Header("Running Warmth Bonus")]
	[Range(0f, 10f)]
	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x50")]
	public float m_MaxTemperatureBonusFromRunning;

	[Range(0f, 30f)]
	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x54")]
	public float m_NumGameMinutesToRampRunningTemperatureBonus;

	[Range(0f, 30f)]
	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x58")]
	public float m_NumGameMinutesToHoldRunningTemperatureBonus;

	[Range(0f, 30f)]
	[Token(Token = "0x400110E")]
	[FieldOffset(Offset = "0x5C")]
	public float m_NumGameMinutesToRampDownRunningTemperatureBonus;

	[Header("Audio")]
	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0x60")]
	public AK.Wwise.Event m_SlightlyColdAudio;

	[Token(Token = "0x4001110")]
	[FieldOffset(Offset = "0x68")]
	public AK.Wwise.Event m_ColdAudio;

	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x70")]
	public AK.Wwise.Event m_VeryColdAudio;

	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x78")]
	public AK.Wwise.Event m_FreezingAudio;

	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x80")]
	public AK.Wwise.Event m_FreezingTeethChatterAudio;

	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x88")]
	public float m_MinSecondsBetweenVoiceOverVariations;

	[Header("HUD")]
	[SerializeField]
	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x98")]
	public float m_TimeToDisplayFreezingWhenChanged;

	[Header("Wet Clothes")]
	[Tooltip("For example, if you set it to 5%, then if you are wearing wet socks, wet jeans, and a wet shirt, you warm up 15% slower and freeze 15% faster")]
	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x9C")]
	public float m_PercentModifierPerWetClothingItem;

	[Token(Token = "0x4001118")]
	public static bool m_ShowRunningTempBonus;

	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0xA0")]
	private FreezingLevel m_FreezingLevelForPreviousVoiceOver;

	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0xA4")]
	private float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0xA8")]
	private float m_TimeDisableFreezingOnHUD;

	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0xAC")]
	private int m_FreezingLevelLastStatusChange;

	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0xB0")]
	private float m_TemperatureBonusFromRunning;

	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_FreezingInLog;

	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0xB8")]
	private float m_HoldRunningTemperatureBonusMinutes;

	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0xBC")]
	private float m_HoursInRangeOfFire;

	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_SuppressVoiceOver;

	[Token(Token = "0x4001123")]
	private static FreezingSaveDataProxy m_FreezingSaveDataProxy;

	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_FreezingTeethChatterSoundId;

	[Token(Token = "0x6001150")]
	[Address(RVA = "0x63B8C0", Offset = "0x63A6C0", Length = "0xEA")]
	private void Start()
	{
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0x63B9B0", Offset = "0x63A7B0", Length = "0x25F")]
	private void Update()
	{
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6001153")]
	[Address(RVA = "0x63BC10", Offset = "0x63AA10", Length = "0x197")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001154")]
	[Address(RVA = "0x63BDB0", Offset = "0x63ABB0", Length = "0x1A7")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001155")]
	[Address(RVA = "0x63BF60", Offset = "0x63AD60", Length = "0x8A")]
	public string GetFreezingStateString()
	{
		return null;
	}

	[Token(Token = "0x6001156")]
	[Address(RVA = "0x63BFF0", Offset = "0x63ADF0", Length = "0x9")]
	public float GetTemperatureBonusFromRunning()
	{
		return 0f;
	}

	[Token(Token = "0x6001157")]
	[Address(RVA = "0x63C000", Offset = "0x63AE00", Length = "0xAE")]
	public void AddFreezing(float freezeValue)
	{
	}

	[Token(Token = "0x6001158")]
	[Address(RVA = "0x63C0B0", Offset = "0x63AEB0", Length = "0xD")]
	public bool IsFreezing()
	{
		return false;
	}

	[Token(Token = "0x6001159")]
	[Address(RVA = "0x63C0C0", Offset = "0x63AEC0", Length = "0x2D9")]
	public float CalculateBodyTemperature()
	{
		return 0f;
	}

	[Token(Token = "0x600115A")]
	[Address(RVA = "0x63C3A0", Offset = "0x63B1A0", Length = "0x7")]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[Token(Token = "0x600115B")]
	[Address(RVA = "0x63C3B0", Offset = "0x63B1B0", Length = "0x86")]
	public void MaybePlayPlayerFreezingTeethChatter()
	{
	}

	[Token(Token = "0x600115C")]
	[Address(RVA = "0x63C440", Offset = "0x63B240", Length = "0x91")]
	public void MaybeCancelPlayerFreezingTeethChatter()
	{
	}

	[Token(Token = "0x600115D")]
	[Address(RVA = "0x63C4E0", Offset = "0x63B2E0", Length = "0x720")]
	private void UpdateFreezingStatus()
	{
	}

	[Token(Token = "0x600115E")]
	[Address(RVA = "0x63CC10", Offset = "0x63BA10", Length = "0xC7")]
	private bool ShouldPlayFreezingVoiceOver()
	{
		return false;
	}

	[Token(Token = "0x600115F")]
	[Address(RVA = "0x63CCE0", Offset = "0x63BAE0", Length = "0x1EB")]
	private void MaybePlayPlayerFreezingVoiceOver()
	{
	}

	[Token(Token = "0x6001160")]
	[Address(RVA = "0x63CED0", Offset = "0x63BCD0", Length = "0x33")]
	private FreezingLevel GetFreezingLevel()
	{
		return default(FreezingLevel);
	}

	[Token(Token = "0x6001161")]
	[Address(RVA = "0x63CF10", Offset = "0x63BD10", Length = "0x75")]
	private void UpdateBodyTempStats(float bodyTemp)
	{
	}

	[Token(Token = "0x6001162")]
	[Address(RVA = "0x63CF90", Offset = "0x63BD90", Length = "0xBD")]
	private void DisplayFreezingOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x6001163")]
	[Address(RVA = "0x63D050", Offset = "0x63BE50", Length = "0xD8")]
	private string GetFreezingTextForHud()
	{
		return null;
	}

	[Token(Token = "0x6001164")]
	[Address(RVA = "0x63D130", Offset = "0x63BF30", Length = "0x241")]
	private void MaybeUpdateFreezingStatusLabel(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6001165")]
	[Address(RVA = "0x63D380", Offset = "0x63C180", Length = "0x393")]
	private void UpdateFreezingStatusOnHUD()
	{
	}

	[Token(Token = "0x6001166")]
	[Address(RVA = "0x63D720", Offset = "0x63C520", Length = "0x132")]
	private void MaybeUpdateFreezingStatusInLog()
	{
	}

	[Token(Token = "0x6001167")]
	[Address(RVA = "0x63D860", Offset = "0x63C660", Length = "0x346")]
	private void UpdateHoursWithinRangeOfFire()
	{
	}

	[Token(Token = "0x6001168")]
	[Address(RVA = "0x557960", Offset = "0x556760", Length = "0x9")]
	public float GetHoursWithinRangeOfFire()
	{
		return 0f;
	}

	[Token(Token = "0x6001169")]
	[Address(RVA = "0x63DBB0", Offset = "0x63C9B0", Length = "0x207")]
	private void UpdateTemperatureBonusFromRunning()
	{
	}

	[Token(Token = "0x600116A")]
	[Address(RVA = "0x63DDC0", Offset = "0x63CBC0", Length = "0x335")]
	private void MaybeAdjustFreezingDueToNearbyFire()
	{
	}

	[Token(Token = "0x600116B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Freezing()
	{
	}
}
