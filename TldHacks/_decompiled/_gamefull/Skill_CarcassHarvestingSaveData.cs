using Cpp2ILInjected;

[Token(Token = "0x200093F")]
public class Skill_CarcassHarvestingSaveData
{
	[Token(Token = "0x4006049")]
	[FieldOffset(Offset = "0x10")]
	public int m_Points;

	[Token(Token = "0x400604A")]
	[FieldOffset(Offset = "0x14")]
	public float m_NumHoursToConvertToSkillPoints;

	[Token(Token = "0x60053FB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Skill_CarcassHarvestingSaveData()
	{
	}
}
