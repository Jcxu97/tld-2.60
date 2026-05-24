using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200046F")]
public class CharcoalItem : MonoBehaviour
{
	[Token(Token = "0x40027F0")]
	public static CharcoalItem m_CharcoalItemInUseForSurvey;

	[Range(0f, 60f)]
	[Token(Token = "0x40027F1")]
	[FieldOffset(Offset = "0x20")]
	public float m_SurveyGameMinutes;

	[Range(0f, 60f)]
	[Token(Token = "0x40027F2")]
	[FieldOffset(Offset = "0x24")]
	public float m_SurveyRealSeconds;

	[Range(0f, 8f)]
	[Token(Token = "0x40027F3")]
	[FieldOffset(Offset = "0x28")]
	public float m_SurveySkillExtendedHours;

	[Header("Audio")]
	[Token(Token = "0x40027F4")]
	[FieldOffset(Offset = "0x30")]
	public string m_SurveyLoopAudio;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40027F5")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40027F6")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x40027F7")]
	[FieldOffset(Offset = "0x48")]
	private GearItem m_GearItem;

	[Token(Token = "0x40027F8")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsActive;

	[Token(Token = "0x40027F9")]
	[FieldOffset(Offset = "0x51")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x40027FA")]
	[FieldOffset(Offset = "0x54")]
	private float m_DayLengthScaleBeforeSurveying;

	[Token(Token = "0x40027FB")]
	[FieldOffset(Offset = "0x58")]
	private float m_TimeSpentSurveying;

	[Token(Token = "0x40027FC")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_SurveyAudioID;

	[Token(Token = "0x600213D")]
	[Address(RVA = "0x80DBF0", Offset = "0x80C9F0", Length = "0x124")]
	private void Awake()
	{
	}

	[Token(Token = "0x600213E")]
	[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
	private float GetSurveyRealSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x600213F")]
	[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
	private float GetSurveyGameMinutes()
	{
		return 0f;
	}

	[Token(Token = "0x6002140")]
	[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
	private float GetSurveyExtendedTimeSkillBonus()
	{
		return 0f;
	}

	[Token(Token = "0x6002141")]
	[Address(RVA = "0x80DD20", Offset = "0x80CB20", Length = "0x31E")]
	private void Update()
	{
	}

	[Token(Token = "0x6002142")]
	[Address(RVA = "0x80E040", Offset = "0x80CE40", Length = "0x2C7")]
	public static bool HasSurveyVisibility(float extendedHoursBonus)
	{
		return false;
	}

	[Token(Token = "0x6002143")]
	[Address(RVA = "0x80E310", Offset = "0x80D110", Length = "0x30A")]
	public void StartDetailSurvey()
	{
	}

	[Token(Token = "0x6002144")]
	[Address(RVA = "0x80E620", Offset = "0x80D420", Length = "0xFC")]
	public void CancelDetailSurvey()
	{
	}

	[Token(Token = "0x6002145")]
	[Address(RVA = "0x80E720", Offset = "0x80D520", Length = "0x1DA")]
	private void DetailSurveyComplete()
	{
	}

	[Token(Token = "0x6002146")]
	[Address(RVA = "0x80E900", Offset = "0x80D700", Length = "0xAE")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x6002147")]
	[Address(RVA = "0x80E9B0", Offset = "0x80D7B0", Length = "0xDB")]
	private void AccelerateTimeOfDay()
	{
	}

	[Token(Token = "0x6002148")]
	[Address(RVA = "0x80EA90", Offset = "0x80D890", Length = "0x192")]
	private void ConsumeCharcoal()
	{
	}

	[Token(Token = "0x6002149")]
	[Address(RVA = "0x80EC30", Offset = "0x80DA30", Length = "0x54")]
	private void StopSurveyAudio()
	{
	}

	[Token(Token = "0x600214A")]
	[Address(RVA = "0x80EC90", Offset = "0x80DA90", Length = "0x58")]
	public CharcoalItem()
	{
	}
}
