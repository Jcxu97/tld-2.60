using Cpp2ILInjected;

[Token(Token = "0x2000792")]
public class PhoneSaveDataInfo
{
	[Token(Token = "0x40050F1")]
	[FieldOffset(Offset = "0x10")]
	public string m_MissionId;

	[Token(Token = "0x40050F2")]
	[FieldOffset(Offset = "0x18")]
	public bool m_HasStartedRinging;

	[Token(Token = "0x40050F3")]
	[FieldOffset(Offset = "0x1C")]
	public int m_RingCycleCount;

	[Token(Token = "0x60046B3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PhoneSaveDataInfo()
	{
	}
}
