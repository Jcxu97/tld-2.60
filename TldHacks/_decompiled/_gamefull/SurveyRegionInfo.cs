using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000687")]
public class SurveyRegionInfo
{
	[Token(Token = "0x40043EF")]
	[FieldOffset(Offset = "0x10")]
	public string m_RegionName;

	[Token(Token = "0x40043F0")]
	[FieldOffset(Offset = "0x18")]
	public string m_SceneName;

	[Token(Token = "0x40043F1")]
	[FieldOffset(Offset = "0x20")]
	public string m_numComplete;

	[Token(Token = "0x40043F2")]
	[FieldOffset(Offset = "0x28")]
	public float m_CompletePercent;

	[Token(Token = "0x40043F3")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_IsUnlocked;

	[Token(Token = "0x40043F4")]
	[FieldOffset(Offset = "0x30")]
	public List<SurveyAchievementInfo> m_Achievements;

	[Token(Token = "0x60037B7")]
	[Address(RVA = "0xADF570", Offset = "0xADE370", Length = "0xAD")]
	public SurveyRegionInfo()
	{
	}
}
