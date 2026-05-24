using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001F8")]
public class Thirst : MonoBehaviour
{
	[Token(Token = "0x40011C8")]
	[FieldOffset(Offset = "0x20")]
	public float m_ThirstQuenchedPerLiter;

	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x24")]
	public float m_CurrentThirst;

	[Token(Token = "0x40011CA")]
	[FieldOffset(Offset = "0x28")]
	public float m_MaxThirst;

	[Range(0f, 1000f)]
	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ThirstIncreasePerDay;

	[Range(0f, 1000f)]
	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x30")]
	public float m_ThirstIncreasePerDayWhenResting;

	[Token(Token = "0x40011CD")]
	[FieldOffset(Offset = "0x34")]
	public float m_SlightlyThirstyThreshold;

	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x38")]
	public float m_ThirstyThreshold;

	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x3C")]
	public float m_VeryThirstyThreshold;

	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0x40")]
	public float m_DehydratedThreshold;

	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0x48")]
	public string m_SlightlyThirstyVoiceOver;

	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0x50")]
	public string m_ThirstyVoiceOver;

	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0x58")]
	public string m_VeryThirstyVoiceOver;

	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x60")]
	public string m_DehydratedVoiceOver;

	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x68")]
	public float m_MinSecondsBetweenVoiceOverVariations;

	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x6C")]
	public float m_TimeToDisplayThirstWhenChanged;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40011D7")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40011D8")]
	[FieldOffset(Offset = "0x78")]
	private ThirstLevel m_ThirstLevelForPreviousVoiceOver;

	[Token(Token = "0x40011D9")]
	[FieldOffset(Offset = "0x7C")]
	private float m_NumSecondsSinceLastVoiceOver;

	[Token(Token = "0x40011DA")]
	[FieldOffset(Offset = "0x80")]
	private float m_TimeDisableThirstOnHUD;

	[Token(Token = "0x40011DB")]
	[FieldOffset(Offset = "0x84")]
	private int m_ThirstLevelLastStatusChange;

	[Token(Token = "0x40011DC")]
	[FieldOffset(Offset = "0x88")]
	private bool m_DehydratedInLog;

	[Token(Token = "0x40011DD")]
	[FieldOffset(Offset = "0x90")]
	private ItemLiquidVolume m_LitersToDrinkOverTime;

	[Token(Token = "0x40011DE")]
	[FieldOffset(Offset = "0x98")]
	private ItemLiquidVolume m_LitersLeftToDrink;

	[Token(Token = "0x40011DF")]
	[FieldOffset(Offset = "0xA0")]
	private float m_LitersToDrinkOverTimeDuration;

	[Token(Token = "0x40011E0")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40011E1")]
	[FieldOffset(Offset = "0xA5")]
	private bool m_SuppressVoiceOver;

	[Token(Token = "0x40011E2")]
	private static ThirstSaveDataProxy m_ThirstSaveDataProxy;

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x644880", Offset = "0x643680", Length = "0xE1")]
	private void Start()
	{
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x644970", Offset = "0x643770", Length = "0x4AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x644E20", Offset = "0x643C20", Length = "0x167")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x644F90", Offset = "0x643D90", Length = "0x187")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x645120", Offset = "0x643F20", Length = "0x8A")]
	public string GetThirstStateString()
	{
		return null;
	}

	[Token(Token = "0x60011E9")]
	[Address(RVA = "0x6451B0", Offset = "0x643FB0", Length = "0x9F")]
	public void AddThirst(float thirstValue)
	{
	}

	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x645250", Offset = "0x644050", Length = "0x17")]
	public void AddThirstOverTime(ItemLiquidVolume litersToDrink, float timeSeconds)
	{
	}

	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x645270", Offset = "0x644070", Length = "0x60")]
	public void ClearAddThirstOverTime()
	{
	}

	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x6452D0", Offset = "0x6440D0", Length = "0x63")]
	public bool IsAddingThirstOverTime()
	{
		return false;
	}

	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x645340", Offset = "0x644140", Length = "0xD")]
	public bool IsDehydrated()
	{
		return false;
	}

	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x645350", Offset = "0x644150", Length = "0xD")]
	public bool IsVeryThirsty()
	{
		return false;
	}

	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x645360", Offset = "0x644160", Length = "0x7")]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x645370", Offset = "0x644170", Length = "0xB4")]
	private bool ShouldPlayThirstVoiceOver()
	{
		return false;
	}

	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x645430", Offset = "0x644230", Length = "0x1D6")]
	private void MaybePlayPlayerThirstVoiceOver()
	{
	}

	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x645610", Offset = "0x644410", Length = "0x33")]
	private ThirstLevel GetThirstLevel()
	{
		return default(ThirstLevel);
	}

	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x645650", Offset = "0x644450", Length = "0xBD")]
	private void DisplayThirstOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x645710", Offset = "0x644510", Length = "0xD8")]
	private string GetThirstTextForHud()
	{
		return null;
	}

	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x6457F0", Offset = "0x6445F0", Length = "0x23E")]
	private void MaybeUpdateThirstStatusLabel(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x645A30", Offset = "0x644830", Length = "0x1F3")]
	private void UpdateAddThirstOverTime()
	{
	}

	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x645C30", Offset = "0x644A30", Length = "0x37C")]
	private void UpdateThirstStatusOnHUD(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x645FB0", Offset = "0x644DB0", Length = "0x132")]
	private void MaybeUpdateDehydratedStatusInLog()
	{
	}

	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Thirst()
	{
	}
}
