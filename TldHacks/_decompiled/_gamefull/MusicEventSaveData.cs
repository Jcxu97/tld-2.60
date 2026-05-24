using Cpp2ILInjected;

[Token(Token = "0x2000788")]
public class MusicEventSaveData
{
	[Token(Token = "0x4005099")]
	[FieldOffset(Offset = "0x10")]
	public float m_HappySuccessLastPlayTime;

	[Token(Token = "0x400509A")]
	[FieldOffset(Offset = "0x14")]
	public float m_SorrowLastPlayTime;

	[Token(Token = "0x400509B")]
	[FieldOffset(Offset = "0x18")]
	public float m_RopeClimbStressLastPlayTime;

	[Token(Token = "0x400509C")]
	[FieldOffset(Offset = "0x1C")]
	public float m_BeingStalkedLastPlayTime;

	[Token(Token = "0x400509D")]
	[FieldOffset(Offset = "0x20")]
	public float m_NumHoursWithAffliction;

	[Token(Token = "0x6004688")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public MusicEventSaveData()
	{
	}
}
