using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006D8")]
public class Panel_Subtitles : Panel_AutoReferenced
{
	[Token(Token = "0x40048D9")]
	private const string CENSORED_ID_SUFFIX = "_PG";

	[Token(Token = "0x40048DA")]
	private const string SPEAKER_FORMAT = "[c]{2}[{0}]:[-] {3}{1}[-][/c]";

	[Token(Token = "0x40048DB")]
	private const string SPEAKER_ID_PREFIX = "_SM";

	[Token(Token = "0x40048DC")]
	private const int SPEAKER_ID_LENGTH = 3;

	[Token(Token = "0x40048DD")]
	private static readonly string[] AUDIO_EVENT_REPLACEMENTS;

	[Token(Token = "0x40048DE")]
	private const string AUDIO_PREFIX_PLAY = "Play_";

	[Token(Token = "0x40048DF")]
	private const string AUDIO_PREFIX_SNDVO = "SndVO";

	[Token(Token = "0x40048E0")]
	[FieldOffset(Offset = "0x30")]
	public Color m_DefaultSubtitleColor;

	[Token(Token = "0x40048E1")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_Label_Subtitles;

	[Token(Token = "0x40048E2")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_Background_Subtitles;

	[Token(Token = "0x40048E3")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_Label_Subtitles_Oversized;

	[Token(Token = "0x40048E4")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_Background_Subtitles_Oversized;

	[Token(Token = "0x40048E5")]
	[FieldOffset(Offset = "0x60")]
	public int m_SubtitleSizeNormal;

	[Token(Token = "0x40048E6")]
	[FieldOffset(Offset = "0x64")]
	public int m_SubtitleSizeLarge;

	[Range(1f, 10f)]
	[Token(Token = "0x40048E7")]
	[FieldOffset(Offset = "0x68")]
	public int m_MaximumSubtitleLineCount;

	[Header("Speaker Mapping")]
	[Token(Token = "0x40048E8")]
	[FieldOffset(Offset = "0x6C")]
	public Episode m_EarliestEnabledEpisode;

	[Token(Token = "0x40048E9")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_UnknownSpeakerName;

	[Token(Token = "0x40048EA")]
	[FieldOffset(Offset = "0x78")]
	public SubtitleSpeakerMapping[] m_SpeakerMapping;

	[Header("Speaker Name - Phone Calls")]
	[Token(Token = "0x40048EB")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_SpeakerLabelGameObject;

	[Token(Token = "0x40048EC")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_SpeakerLabel;

	[Token(Token = "0x40048ED")]
	[FieldOffset(Offset = "0x90")]
	public UISprite m_PhoneIcon;

	[Token(Token = "0x40048EE")]
	[FieldOffset(Offset = "0x98")]
	public UISprite m_CommSpeakerIcon;

	[Token(Token = "0x40048EF")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite m_SpeakerBackground;

	[Token(Token = "0x40048F0")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite m_IconBackground;

	[Token(Token = "0x40048F1")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<string, SubtitleSpeakerMapping> m_SpeakerMappingDict;

	[Token(Token = "0x40048F2")]
	[FieldOffset(Offset = "0xB8")]
	private float m_TimeToHideSubtitles;

	[Token(Token = "0x40048F3")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_IsUnknownSpeaker;

	[Token(Token = "0x40048F4")]
	private static readonly int s_Stop;

	[Token(Token = "0x6003C25")]
	[Address(RVA = "0xB755F0", Offset = "0xB743F0", Length = "0xC1")]
	private void Start()
	{
	}

	[Token(Token = "0x6003C26")]
	[Address(RVA = "0xB756C0", Offset = "0xB744C0", Length = "0x24C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003C27")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6003C28")]
	[Address(RVA = "0xB75910", Offset = "0xB74710", Length = "0x7")]
	public void SetIsUnknownSpeaker(bool isUnknownSpeaker)
	{
	}

	[Token(Token = "0x6003C29")]
	[Address(RVA = "0xB75920", Offset = "0xB74720", Length = "0x109")]
	public bool ShowSubtitles(string locID)
	{
		return false;
	}

	[Token(Token = "0x6003C2A")]
	[Address(RVA = "0xB75A30", Offset = "0xB74830", Length = "0x116")]
	public bool ShowSubtitles(string locID, float duration)
	{
		return false;
	}

	[Token(Token = "0x6003C2B")]
	[Address(RVA = "0xB75B50", Offset = "0xB74950", Length = "0x34")]
	public void ShowSubtitlesForced(string locID)
	{
	}

	[Token(Token = "0x6003C2C")]
	[Address(RVA = "0xB75B90", Offset = "0xB74990", Length = "0x3C")]
	public void ShowSubtitlesForced(string locID, float duration)
	{
	}

	[Token(Token = "0x6003C2D")]
	[Address(RVA = "0xB75BD0", Offset = "0xB749D0", Length = "0x2A6")]
	private void DisplaySubtitleText(string locID)
	{
	}

	[Token(Token = "0x6003C2E")]
	[Address(RVA = "0xB75E80", Offset = "0xB74C80", Length = "0x148")]
	private string FormatSubtitleText(string locID)
	{
		return null;
	}

	[Token(Token = "0x6003C2F")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	private bool ShouldShowSpeakerName(string _)
	{
		return false;
	}

	[Token(Token = "0x6003C30")]
	[Address(RVA = "0xB75FD0", Offset = "0xB74DD0", Length = "0x1BE")]
	public void HideSubtitles(float secondsUntilHide = 0.5f)
	{
	}

	[Token(Token = "0x6003C31")]
	[Address(RVA = "0xB76190", Offset = "0xB74F90", Length = "0x6A")]
	public void HideSubtitlesImmediate()
	{
	}

	[Token(Token = "0x6003C32")]
	[Address(RVA = "0xB76200", Offset = "0xB75000", Length = "0xF6")]
	public void EnableLargeSubtitles(bool enableLargeSubtitles)
	{
	}

	[Token(Token = "0x6003C33")]
	[Address(RVA = "0xB76300", Offset = "0xB75100", Length = "0xFE")]
	public bool MaybeShowSubtitleForAudioEvent(string eventName, bool forced)
	{
		return false;
	}

	[Token(Token = "0x6003C34")]
	[Address(RVA = "0xB76400", Offset = "0xB75200", Length = "0x365")]
	public static string LocIdFromEvent(string eventName, out string audioPrefix)
	{
		audioPrefix = null;
		return null;
	}

	[Token(Token = "0x6003C35")]
	[Address(RVA = "0xB76770", Offset = "0xB75570", Length = "0x160")]
	public void ShowSpeakerNameDuringPhoneCalls(string locID, bool isCommunitySpeaker)
	{
	}

	[Token(Token = "0x6003C36")]
	[Address(RVA = "0xB768E0", Offset = "0xB756E0", Length = "0x208")]
	public void HideSpeakerName()
	{
	}

	[Token(Token = "0x6003C37")]
	[Address(RVA = "0xB76AF0", Offset = "0xB758F0", Length = "0x8F")]
	private void FadeSpeakerName(bool enable)
	{
	}

	[Token(Token = "0x6003C38")]
	[Address(RVA = "0xB76B80", Offset = "0xB75980", Length = "0xB5")]
	private string GetSpeakerName(string locID)
	{
		return null;
	}

	[Token(Token = "0x6003C39")]
	[Address(RVA = "0xB76C40", Offset = "0xB75A40", Length = "0x1D9")]
	private bool IsSubtitleClosedCaptioning(string locID)
	{
		return false;
	}

	[Token(Token = "0x6003C3A")]
	[Address(RVA = "0xB76E20", Offset = "0xB75C20", Length = "0x11F")]
	private SubtitleSpeakerMapping GetSpeakerMappingFromLocID(string locID)
	{
		return null;
	}

	[Token(Token = "0x6003C3B")]
	[Address(RVA = "0xB76F40", Offset = "0xB75D40", Length = "0xCE")]
	public bool AreSubtitlesVisible()
	{
		return false;
	}

	[Token(Token = "0x6003C3C")]
	[Address(RVA = "0xB77010", Offset = "0xB75E10", Length = "0xF2")]
	public Panel_Subtitles()
	{
	}
}
