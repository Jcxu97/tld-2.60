using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x20008C1")]
public class PlayerSkillsSaveData
{
	[Token(Token = "0x4005B5B")]
	[FieldOffset(Offset = "0x10")]
	public float m_RepairSkill;

	[Token(Token = "0x4005B5C")]
	[FieldOffset(Offset = "0x14")]
	public float m_CleanSkill;

	[Token(Token = "0x4005B5D")]
	[FieldOffset(Offset = "0x18")]
	public float m_SharpenSkill;

	[Token(Token = "0x6005070")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PlayerSkillsSaveData()
	{
	}
}
