using Cpp2ILInjected;

namespace Voice;

[Token(Token = "0x200132D")]
public class ActiveRequest : Request
{
	[Token(Token = "0x4008D9C")]
	[FieldOffset(Offset = "0x28")]
	public float m_Duration;

	[Token(Token = "0x4008D9D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Elapsed;

	[Token(Token = "0x4008D9E")]
	[FieldOffset(Offset = "0x30")]
	public uint m_PlaybackID;

	[Token(Token = "0x4008D9F")]
	[FieldOffset(Offset = "0x34")]
	public bool m_Subtitled;

	[Token(Token = "0x6007AF9")]
	[Address(RVA = "0x119B2C0", Offset = "0x119A0C0", Length = "0x19")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6007AFA")]
	[Address(RVA = "0x119B2E0", Offset = "0x119A0E0", Length = "0x8")]
	public bool IsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6007AFB")]
	[Address(RVA = "0x119B2F0", Offset = "0x119A0F0", Length = "0xAB")]
	public void Start(Request original, uint playbackID)
	{
	}

	[Token(Token = "0x6007AFC")]
	[Address(RVA = "0x119B3A0", Offset = "0x119A1A0", Length = "0x54")]
	public void Stop()
	{
	}

	[Token(Token = "0x6007AFD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ActiveRequest()
	{
	}
}
