using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008C2")]
public class PlayerSkills : MonoBehaviour
{
	[Token(Token = "0x4005B5E")]
	[FieldOffset(Offset = "0x20")]
	public PlayerSkillsSaveData m_SaveData;

	[Token(Token = "0x4005B5F")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<PlayerSkillType> m_IncreasedSkills;

	[Token(Token = "0x6005071")]
	[Address(RVA = "0xE06AF0", Offset = "0xE058F0", Length = "0x88")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005072")]
	[Address(RVA = "0xE06B80", Offset = "0xE05980", Length = "0x1A8")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005073")]
	[Address(RVA = "0xE06D30", Offset = "0xE05B30", Length = "0x58")]
	public float GetSkill(PlayerSkillType playerSkillType)
	{
		return 0f;
	}

	[Token(Token = "0x6005074")]
	[Address(RVA = "0xE06D90", Offset = "0xE05B90", Length = "0x126")]
	public void SetSkill(PlayerSkillType playerSkillType, float value)
	{
	}

	[Token(Token = "0x6005075")]
	[Address(RVA = "0xE06EC0", Offset = "0xE05CC0", Length = "0x1FB")]
	public void RollForSkillIncrease(PlayerSkillType playerSkillType, float chance, float increase = 1f)
	{
	}

	[Token(Token = "0x6005076")]
	[Address(RVA = "0xE070C0", Offset = "0xE05EC0", Length = "0x3A4")]
	public void ShowSkillIncreaseMessages()
	{
	}

	[Token(Token = "0x6005077")]
	[Address(RVA = "0xE07470", Offset = "0xE06270", Length = "0xEA")]
	private string GetIncreaseString(PlayerSkillType playerSkillType)
	{
		return null;
	}

	[Token(Token = "0x6005078")]
	[Address(RVA = "0xE07560", Offset = "0xE06360", Length = "0xE3")]
	public PlayerSkills()
	{
	}
}
