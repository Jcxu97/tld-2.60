using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x200133C")]
public class VoiceTracker : LoopTracker
{
	[SerializeField]
	[Token(Token = "0x4008DEC")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4008DED")]
	[FieldOffset(Offset = "0x70")]
	private float m_CaptionDisplayTime;

	[Token(Token = "0x4008DEE")]
	[FieldOffset(Offset = "0x74")]
	private bool m_UseDurationForSubtitle;

	[Token(Token = "0x6007B52")]
	[Address(RVA = "0x11A0360", Offset = "0x119F160", Length = "0x41")]
	public VoiceTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position, bool useDurationForSubtitle)
		: base((string)null, (GameObject)null, 0f, stopWhenDisabled: false, position: false)
	{
	}

	[Token(Token = "0x6007B53")]
	[Address(RVA = "0x11A03B0", Offset = "0x119F1B0", Length = "0x207")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6007B54")]
	[Address(RVA = "0x11A05C0", Offset = "0x119F3C0", Length = "0x166")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}
}
