using Cpp2ILInjected;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001337")]
public class PlayVoiceSimple : BaseSimpleAudioComponent
{
	[Token(Token = "0x4008DCF")]
	[FieldOffset(Offset = "0x28")]
	public string m_EventName;

	[Token(Token = "0x4008DD0")]
	[FieldOffset(Offset = "0x30")]
	public float m_Radius;

	[Token(Token = "0x4008DD1")]
	[FieldOffset(Offset = "0x34")]
	public bool m_StopWhenDisabled;

	[Token(Token = "0x4008DD2")]
	[FieldOffset(Offset = "0x35")]
	public bool m_TrackPosition;

	[Token(Token = "0x4008DD3")]
	[FieldOffset(Offset = "0x36")]
	public bool m_UseDurationForSubtitle;

	[Token(Token = "0x6007B2D")]
	[Address(RVA = "0x119D9E0", Offset = "0x119C7E0", Length = "0x1AD")]
	private void Start()
	{
	}

	[Token(Token = "0x6007B2E")]
	[Address(RVA = "0x119DB90", Offset = "0x119C990", Length = "0x4A")]
	public PlayVoiceSimple()
	{
	}
}
