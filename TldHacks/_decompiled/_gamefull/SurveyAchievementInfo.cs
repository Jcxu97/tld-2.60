using Cpp2ILInjected;

[Token(Token = "0x2000686")]
public class SurveyAchievementInfo
{
	[Token(Token = "0x40043ED")]
	[FieldOffset(Offset = "0x10")]
	public string m_AchievementName;

	[Token(Token = "0x40043EE")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Completed;

	[Token(Token = "0x60037B6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SurveyAchievementInfo()
	{
	}
}
