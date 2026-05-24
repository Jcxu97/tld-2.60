using Cpp2ILInjected;

[Token(Token = "0x200033A")]
public class Feat_BlizzardWalkerSaveData
{
	[Token(Token = "0x4001CF7")]
	[FieldOffset(Offset = "0x10")]
	public float m_BlizzardHoursOutside;

	[Token(Token = "0x4001CF8")]
	[FieldOffset(Offset = "0x14")]
	public float m_BlizzardHoursOutsideAccumulator;

	[Token(Token = "0x6001A77")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Feat_BlizzardWalkerSaveData()
	{
	}
}
