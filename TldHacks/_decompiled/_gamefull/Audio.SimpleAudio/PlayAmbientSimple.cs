using AK.Wwise;
using Cpp2ILInjected;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001333")]
public class PlayAmbientSimple : BaseSimpleAudioComponent
{
	[Token(Token = "0x4008DB8")]
	[FieldOffset(Offset = "0x28")]
	public Event m_Event;

	[Token(Token = "0x4008DB9")]
	[FieldOffset(Offset = "0x30")]
	public MultiPositionTypeLabel m_MultiPositionType;

	[Token(Token = "0x4008DBA")]
	[FieldOffset(Offset = "0x34")]
	public float m_Radius;

	[Token(Token = "0x4008DBB")]
	[FieldOffset(Offset = "0x38")]
	public bool m_StopWhenDisabled;

	[Token(Token = "0x17000A4A")]
	public bool IsSimpleAmbient
	{
		[Token(Token = "0x6007B1A")]
		[Address(RVA = "0x119BDA0", Offset = "0x119ABA0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007B1B")]
	[Address(RVA = "0x119BDB0", Offset = "0x119ABB0", Length = "0x1C1")]
	private void Start()
	{
	}

	[Token(Token = "0x6007B1C")]
	[Address(RVA = "0x119BF80", Offset = "0x119AD80", Length = "0x75")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007B1D")]
	[Address(RVA = "0x119C000", Offset = "0x119AE00", Length = "0x51")]
	public PlayAmbientSimple()
	{
	}
}
