using Cpp2ILInjected;

[Token(Token = "0x20007DA")]
public class SkillsManagerSaveData
{
	[Token(Token = "0x400542D")]
	[FieldOffset(Offset = "0x10")]
	public string m_Skill_FirestartingSerialized;

	[Token(Token = "0x400542E")]
	[FieldOffset(Offset = "0x18")]
	public string m_Skill_CarcassHarvestingSerialized;

	[Token(Token = "0x400542F")]
	[FieldOffset(Offset = "0x20")]
	public string m_Skill_CookingSerialized;

	[Token(Token = "0x4005430")]
	[FieldOffset(Offset = "0x28")]
	public string m_Skill_IceFishingSerialized;

	[Token(Token = "0x4005431")]
	[FieldOffset(Offset = "0x30")]
	public string m_Skill_RifleSerialized;

	[Token(Token = "0x4005432")]
	[FieldOffset(Offset = "0x38")]
	public string m_Skill_ArcherySerialized;

	[Token(Token = "0x4005433")]
	[FieldOffset(Offset = "0x40")]
	public string m_Skill_ClothingRepairSerialized;

	[Token(Token = "0x4005434")]
	[FieldOffset(Offset = "0x48")]
	public string m_Skill_RevolverSerialized;

	[Token(Token = "0x4005435")]
	[FieldOffset(Offset = "0x50")]
	public string m_Skill_GunsmithingSerialized;

	[Token(Token = "0x6004A2A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SkillsManagerSaveData()
	{
	}
}
