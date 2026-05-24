using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;

[Token(Token = "0x2000944")]
public class Skill_Cooking : Skill
{
	[Header("Tuning")]
	[Token(Token = "0x400605A")]
	[FieldOffset(Offset = "0x68")]
	public int m_LevelWhereNoCalorieLossFromSmashing;

	[Token(Token = "0x400605B")]
	[FieldOffset(Offset = "0x6C")]
	public int m_LevelWhereNoParasitesOrFoodPoisoning;

	[Token(Token = "0x400605C")]
	[FieldOffset(Offset = "0x70")]
	public int[] m_CaloriePercentBonus;

	[Token(Token = "0x400605D")]
	[FieldOffset(Offset = "0x78")]
	public int[] m_CookingTimeReducePercent;

	[Token(Token = "0x400605E")]
	[FieldOffset(Offset = "0x80")]
	public int[] m_ReadyTimeIncreasePercent;

	[Token(Token = "0x400605F")]
	[FieldOffset(Offset = "0x88")]
	public int[] m_LowConditionChance;

	[Token(Token = "0x4006060")]
	[FieldOffset(Offset = "0x90")]
	public int[] m_ConditionMax;

	[Token(Token = "0x4006061")]
	[FieldOffset(Offset = "0x98")]
	public GameplayTag m_ConditionSkillCheckGameplayTag;

	[Range(0f, 1f)]
	[Token(Token = "0x4006062")]
	[FieldOffset(Offset = "0xA8")]
	public float m_LowConditionMin;

	[Range(0f, 1f)]
	[Token(Token = "0x4006063")]
	[FieldOffset(Offset = "0xAC")]
	public float m_LowConditionMax;

	[Token(Token = "0x4006064")]
	private static Skill_CookingSaveData m_Skill_CookingSaveData;

	[Token(Token = "0x6005412")]
	[Address(RVA = "0xE7A810", Offset = "0xE79610", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005413")]
	[Address(RVA = "0xE7A8F0", Offset = "0xE796F0", Length = "0xE6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005414")]
	[Address(RVA = "0xE78D00", Offset = "0xE77B00", Length = "0x91")]
	public float GetCalorieScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005415")]
	[Address(RVA = "0xE78DA0", Offset = "0xE77BA0", Length = "0xBE")]
	public float GetCookingTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005416")]
	[Address(RVA = "0xE7A280", Offset = "0xE79080", Length = "0x91")]
	public float GetReadyTimeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005417")]
	[Address(RVA = "0xE7A9E0", Offset = "0xE797E0", Length = "0x87")]
	public float GetConditionLowConditionChance()
	{
		return 0f;
	}

	[Token(Token = "0x6005418")]
	[Address(RVA = "0xE7AA70", Offset = "0xE79870", Length = "0x87")]
	public float GetConditionMaxScale()
	{
		return 0f;
	}

	[Token(Token = "0x6005419")]
	[Address(RVA = "0xE7AB00", Offset = "0xE79900", Length = "0x172")]
	public float CalculateCondition(float currentHP, float maxHP)
	{
		return 0f;
	}

	[Token(Token = "0x600541A")]
	[Address(RVA = "0xE7AC80", Offset = "0xE79A80", Length = "0x2F2")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[Token(Token = "0x600541B")]
	[Address(RVA = "0xE7AF80", Offset = "0xE79D80", Length = "0xA2")]
	public bool NoCalorieLossWhenSmashingOpen()
	{
		return false;
	}

	[Token(Token = "0x600541C")]
	[Address(RVA = "0xE79880", Offset = "0xE78680", Length = "0xA2")]
	public bool NoParasitesOrFoodPosioning()
	{
		return false;
	}

	[Token(Token = "0x600541D")]
	[Address(RVA = "0xE7B030", Offset = "0xE79E30", Length = "0x248")]
	public Skill_Cooking()
	{
	}
}
