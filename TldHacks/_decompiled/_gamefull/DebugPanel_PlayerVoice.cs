using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Voice;

[Token(Token = "0x20005D1")]
public class DebugPanel_PlayerVoice : Panel_Base
{
	[Token(Token = "0x20005D2")]
	private struct CompletedRequest
	{
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x0")]
		public uint m_EventID;

		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x8")]
		public string m_EventName;

		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x10")]
		public PlayerVoice.Reason m_Reason;

		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x18")]
		public TimeSpan m_Timestamp;
	}

	[Token(Token = "0x40035C2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Gender;

	[Token(Token = "0x40035C3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_NonCriticalDelay;

	[Token(Token = "0x40035C4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_PlaybackTime;

	[Token(Token = "0x40035C5")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_PlayingLine;

	[Token(Token = "0x40035C6")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_Queue;

	[Token(Token = "0x40035C7")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_Recent;

	[Token(Token = "0x40035C8")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, string> m_AudioEventNameLookup;

	[Token(Token = "0x40035C9")]
	private const int MAX_COMPLETED_REQUEST = 10;

	[Token(Token = "0x40035CA")]
	[FieldOffset(Offset = "0x60")]
	private List<CompletedRequest> m_CompletedRequests;

	[Token(Token = "0x6002D27")]
	[Address(RVA = "0x941E60", Offset = "0x940C60", Length = "0x1C7")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002D28")]
	[Address(RVA = "0x942030", Offset = "0x940E30", Length = "0x3B")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x942070", Offset = "0x940E70", Length = "0x77")]
	public string LookupEventName(uint eventID)
	{
		return null;
	}

	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x9420F0", Offset = "0x940EF0", Length = "0x39B")]
	public void MaybeConnectEventListener(PlayerVoice voice)
	{
	}

	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x942490", Offset = "0x941290", Length = "0x3F")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6002D2D")]
	[Address(RVA = "0x9424D0", Offset = "0x9412D0", Length = "0x289")]
	private void UpdateNonCriticalDelay()
	{
	}

	[Token(Token = "0x6002D2E")]
	[Address(RVA = "0x942760", Offset = "0x941560", Length = "0x152")]
	private void UpdateGender()
	{
	}

	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x9428C0", Offset = "0x9416C0", Length = "0x372")]
	private void UpdatePlayback()
	{
	}

	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x942C40", Offset = "0x941A40", Length = "0x609")]
	private void UpdateQueue()
	{
	}

	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x943250", Offset = "0x942050", Length = "0x5DE")]
	private void UpdateRecent()
	{
	}

	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x943830", Offset = "0x942630", Length = "0x1D3")]
	private void OnRequestEvent(Request request, PlayerVoice.Reason reason)
	{
	}

	[Token(Token = "0x6002D33")]
	[Address(RVA = "0x943A10", Offset = "0x942810", Length = "0x7")]
	private void OnVoicePersonaChanged(VoicePersona persona)
	{
	}

	[Token(Token = "0x6002D34")]
	[Address(RVA = "0x943A20", Offset = "0x942820", Length = "0x224")]
	public DebugPanel_PlayerVoice()
	{
	}
}
