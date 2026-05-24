using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000515")]
public class Fear : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002E91")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4002E92")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_NoSleepString;

	[Token(Token = "0x4002E93")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_NoPassTimeString;

	[Token(Token = "0x4002E94")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_FearLocalizedString;

	[Token(Token = "0x4002E95")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_FearDescription;

	[Token(Token = "0x4002E96")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_FearTreatment;

	[Token(Token = "0x4002E97")]
	[FieldOffset(Offset = "0x50")]
	public string m_FearIcon;

	[Token(Token = "0x4002E98")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_FearCause;

	[Token(Token = "0x4002E99")]
	[FieldOffset(Offset = "0x60")]
	public bool m_CanPassTime;

	[Range(0f, 100f)]
	[Token(Token = "0x4002E9A")]
	[FieldOffset(Offset = "0x64")]
	public float m_HealthLossPerMinute;

	[Token(Token = "0x4002E9B")]
	[FieldOffset(Offset = "0x68")]
	public string m_AudioEvent;

	[Token(Token = "0x4002E9C")]
	[FieldOffset(Offset = "0x70")]
	public float m_SubtitleDisplayTime;

	[Token(Token = "0x4002E9D")]
	[FieldOffset(Offset = "0x74")]
	private uint m_AudioPlayingID;

	[Token(Token = "0x4002E9E")]
	[FieldOffset(Offset = "0x78")]
	private bool m_HasAffliction;

	[Token(Token = "0x4002E9F")]
	private static FearSaveDataProxy m_FearSaveDataProxy;

	[Token(Token = "0x6002696")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x6002697")]
	[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
	public string GetNoSleepString()
	{
		return null;
	}

	[Token(Token = "0x6002698")]
	[Address(RVA = "0x864050", Offset = "0x862E50", Length = "0x5")]
	public bool CanPassTime()
	{
		return false;
	}

	[Token(Token = "0x6002699")]
	[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
	public string GetNoPassTimeString()
	{
		return null;
	}

	[Token(Token = "0x600269A")]
	[Address(RVA = "0x87D650", Offset = "0x87C450", Length = "0x1B")]
	public string GetAfflictionLocId()
	{
		return null;
	}

	[Token(Token = "0x600269B")]
	[Address(RVA = "0x87D670", Offset = "0x87C470", Length = "0x5D")]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[Token(Token = "0x600269C")]
	[Address(RVA = "0x750030", Offset = "0x74EE30", Length = "0x5D")]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[Token(Token = "0x600269D")]
	[Address(RVA = "0x87D6D0", Offset = "0x87C4D0", Length = "0x5D")]
	public string GetAfflictionCause()
	{
		return null;
	}

	[Token(Token = "0x600269E")]
	[Address(RVA = "0x8A3E30", Offset = "0x8A2C30", Length = "0xE0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600269F")]
	[Address(RVA = "0x8A3F20", Offset = "0x8A2D20", Length = "0x8D")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60026A0")]
	[Address(RVA = "0x8A3FB0", Offset = "0x8A2DB0", Length = "0x244")]
	public void StartAffliction()
	{
	}

	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x8A4200", Offset = "0x8A3000", Length = "0xFB")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x8A4300", Offset = "0x8A3100", Length = "0x109")]
	public void StopAffliction(bool silent)
	{
	}

	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x8A4410", Offset = "0x8A3210", Length = "0x1AB")]
	public void Update()
	{
	}

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x8A45C0", Offset = "0x8A33C0", Length = "0x143")]
	public Fear()
	{
	}
}
