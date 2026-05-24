using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004F8")]
public class Anxiety : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002D77")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4002D78")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_NoSleepString;

	[Token(Token = "0x4002D79")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_NoPassTimeString;

	[Token(Token = "0x4002D7A")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_AnxietyLocalizedString;

	[Token(Token = "0x4002D7B")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_AnxietyDescription;

	[Token(Token = "0x4002D7C")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_AnxietyTreatment;

	[Token(Token = "0x4002D7D")]
	[FieldOffset(Offset = "0x50")]
	public string m_AnxietyIcon;

	[Token(Token = "0x4002D7E")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_AnxietyCause;

	[Token(Token = "0x4002D7F")]
	[FieldOffset(Offset = "0x60")]
	public bool m_CanPassTime;

	[Range(0f, 100f)]
	[Token(Token = "0x4002D80")]
	[FieldOffset(Offset = "0x64")]
	public float m_HealthLossPerMinute;

	[Token(Token = "0x4002D81")]
	[FieldOffset(Offset = "0x68")]
	public string m_AudioEvent;

	[Token(Token = "0x4002D82")]
	[FieldOffset(Offset = "0x70")]
	public float m_SubtitleDisplayTime;

	[Token(Token = "0x4002D83")]
	[FieldOffset(Offset = "0x74")]
	private uint m_AudioPlayingID;

	[Token(Token = "0x4002D84")]
	[FieldOffset(Offset = "0x78")]
	private bool m_HasAffliction;

	[Token(Token = "0x4002D85")]
	private static AnxietySaveDataProxy m_AnxietySaveDataProxy;

	[Token(Token = "0x600258D")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool HasAffliction()
	{
		return false;
	}

	[Token(Token = "0x600258E")]
	[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
	public string GetNoSleepString()
	{
		return null;
	}

	[Token(Token = "0x600258F")]
	[Address(RVA = "0x87D650", Offset = "0x87C450", Length = "0x1B")]
	public string GetAfflictionLocId()
	{
		return null;
	}

	[Token(Token = "0x6002590")]
	[Address(RVA = "0x87D670", Offset = "0x87C470", Length = "0x5D")]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[Token(Token = "0x6002591")]
	[Address(RVA = "0x87D6D0", Offset = "0x87C4D0", Length = "0x5D")]
	public string GetAfflictionCause()
	{
		return null;
	}

	[Token(Token = "0x6002592")]
	[Address(RVA = "0x750030", Offset = "0x74EE30", Length = "0x5D")]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x87D730", Offset = "0x87C530", Length = "0x69")]
	public bool CanPassTime()
	{
		return false;
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
	public string GetNoPassTimeString()
	{
		return null;
	}

	[Token(Token = "0x6002595")]
	[Address(RVA = "0x87D7A0", Offset = "0x87C5A0", Length = "0xE0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0x87D890", Offset = "0x87C690", Length = "0x8D")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002597")]
	[Address(RVA = "0x87D920", Offset = "0x87C720", Length = "0x244")]
	public void StartAffliction()
	{
	}

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x87DB70", Offset = "0x87C970", Length = "0xFB")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x87DC70", Offset = "0x87CA70", Length = "0x109")]
	public void StopAffliction(bool silent)
	{
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0x87DD80", Offset = "0x87CB80", Length = "0x1AB")]
	public void Update()
	{
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x87DF30", Offset = "0x87CD30", Length = "0x143")]
	public Anxiety()
	{
	}
}
